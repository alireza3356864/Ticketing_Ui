
// function SendTicket() {
//   var request= new XMLHttpRequest();
//   request.open("Post", "https://localhost:44357/home");
//   request.onreadystatechange = function(){
//     if(request.readyState==4 && request.status==200){
//       alert("test");
//       // var item=JSON.parse(request.response);

//       // var output="<ul>"
//       // for(k in item){
//       //   output+="<li>"+item[k].title+"<li>"
//       // }
//       // output+="</ul>"
//     }
//   }
//   xhttp.send();
// }
var title = document.getElementById("input-title");
var body = document.getElementById("ticket-body");
var topic = document.getElementById("ticket-topic");
var priority = document.getElementById("ticket-priority");
var sectiontype = document.getElementById("ticket-sectiontype");

title.addEventListener("input", function () {
    if (title.value != "") {
        title.style.border = "1px solid green";
    } else {
        title.style.border = "1px solid red";
    }

});
body.addEventListener("input", function () {
    if (body.value != "") {
        body.style.border = "1px solid green";
    } else {
        body.style.border = "1px solid red";
    }
});


function SendTicket() {
    try {
        if (title.value == "") {
            title.style.border = "1px solid red";
            if (body.value == "") {
                body.style.border = "1px solid red";
            }
        } else {

            $.ajax({
                url: "https://localhost:44358/ticketing/InsertTicket",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify({
                    title: title.value,
                    body: body.value,
                    status: 1,
                    priority: Number(priority.value),
                    topicId: "e6d1d44e-fe68-4952-a743-fb3c4e8ef9e6",
                    sectionType: Number(sectiontype.value)
                }),

                success: function (response) {
                    console.log(response);
                    alert("تیکت با موفقیت ثبت شد");
                    // You will get response from your PHP page (what you echo or print)
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(textStatus, errorThrown);
                }
            });

        }


    } catch (error) {
        throw error;
    }

}

