// var tickets = this.getAll();
// $("[sgs-ticket-table] tbody").html(tickets);
// GetAllTicket();
// function GetAllTicket() {
//     try {
//         $.ajax({
//             url: "https://localhost:44358/ticketing/GetAllTicket",
//             type: "POST",
//             contentType: "application/json; charset=utf-8",
//             success: function (response) {
//                // console.log(response.ticket);
//                 var output=""
//                 response.ticket.forEach(element => {
//                     console.log(element.title)
//                     output+="";
//                 });
//                 // You will get response from your PHP page (what you echo or print)
//             },
//             error: function (jqXHR, textStatus, errorThrown) {
//                 console.log(textStatus, errorThrown);
//             }
//         });
//         document.getElementById("get-ticketing-container").inn

//const { values } = require("../lib/fontawesome/js/v4-shims");




//     } catch (error) {
//         throw error;
//     }

// }
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
        /* Toggle between adding and removing the "active" class,
        to highlight the button that controls the panel */
        this.classList.toggle("active");

        /* Toggle between hiding and showing the active panel */
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    });
}

var ticketing = {
    data: null,
    searchedData: null,
    init: function () {

        var that = this;
        that.getAll();
        $('#input-search').on('input', function (e) {
            that.search();
        });
        


    },
    search() {
        var searchedTerm = $("#input-search").val();
        //this.searchedData = this.data.filter(d => toString(d.year).indexOf(searchedTerm) >= 0);
        this.searchedData = this.data.filter(d => d.title.indexOf(searchedTerm) >= 0 || d.topic.title.indexOf(searchedTerm) >= 0);
        this.loadData();
    },
    loadData: function () {
        var className = '';
        var htmlValue = '';


        this.searchedData.forEach(element => {
            switch (element.status) {
                case 0:
                    {
                        status = "????????????"
                        className = "waiting"
                    }
                    break;

                case 1:
                    {
                        status = "????????"
                        className = "active"
                    }
                    break;

                case 2:
                    {
                        status = "???????? ??????????"
                        className = "waiting"
                    }

                    break;

                case 2: status = "???????? ??????????????"
                    break;

                case 3: status = "????????"
                    break;

                default: "????????????";
            }


            htmlValue = `${htmlValue}
           
                <tr class="alert" role="alert">
        
                <td class="d-flex align-items-center">
                    <div class="pl-3 email">
                        <span>${element.title}</span>
                        <span>??????????????:${element.modifiedPersian} </span>
                    </div>
                </td>
                <td>${element.topic.title}</td>
                <td class="status border-bottom-0"><span id="status-span" class="${className}">${status}</span></td>
                <td>${element.year}</td>
                <td>${element.code}</td>
                <td>${element.createdPersian}</td>
                <td id="${element.id}" class="showconversation"><i class="far fa-comment-alt pointer icon-get-ticketconversation"></i></td>
              </tr>
  
`
        });
        $("[sgs-ticket-section]").html(htmlValue);


        $('.showconversation').on('click', function (e) {

            //console.log(this.id);
            //window.location.href = "https://localhost:44333/Home/TicketConversation";


            window.location.href = "https://localhost:44333/Home/TicketConversation?ticketid=" + this.id;
      
        });
    },

    getAll: function () {
        var that = this;
        $.ajax({
            url: "https://localhost:44358/ticketing/GetAllTicket",
            type: "POST",
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                console.log(response.ticket);

                var htmlValue = "";
                var status = "";
                that.data = response.ticket;
                that.searchedData = that.data;
                that.loadData();
                return htmlValue;
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    }
}
$(document).ready(function () {
    ticketing.init();
});


