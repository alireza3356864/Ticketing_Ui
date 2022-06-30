
//window.onload = function () {
//   scrollWi
//n();
//};
//function scrollWin() {
//    window.scrollTo
//, 1500);
//}
//function buttonClick() {
//}

var body = document.getElementById("input-search");
function SendTicket() {
    try {
        if (body.value == "") {
            body.style.border = ".5px solid red";
        } else {
            $.ajax({
                url: "https://localhost:44358/ticketing/InsertTicketConversation",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify({
                    body: body.value,
                    status: 0,
                    TicketId: "4E3FDD25-C51D-4B2B-AE36-966B7A91B5A1",
                    ParentId: ""
                }),

                success: function (response) {
                    console.log(response);

                    // You will get response from your PHP page (what you echo or print)
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(textStatus, errorThrown);
                }
            });

        }

        body.value = "";
    } catch (error) {
        throw error;
    }

}










