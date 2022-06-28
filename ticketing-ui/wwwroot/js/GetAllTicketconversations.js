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
        this.searchedData = this.data.filter(d => d.Body.indexOf(searchedTerm) >= 0);

        this.loadData();
    },
    loadData: function () {
        var htmlValue = '';


        this.searchedData.forEach(element => {
            //switch (element.status) {
            //    case 0:
            //        {
            //            status = "نامشخص"
            //            className = "waiting"
            //        }
            //        break;

            //    case 1:
            //        {
            //            status = "جدید"
            //            className = "active"
            //        }
            //        break;

            //    case 2:
            //        {
            //            status = "پاسخ مشتری"
            //            className = "waiting"
            //        }

            //        break;

            //    case 2: status = "پاسخ کارشناس"
            //        break;

            //    case 3: status = "بسته"
            //        break;



            //    default: "نامشخص";
            //}


            htmlValue = `${htmlValue}
                <tr class="alert" role="alert">
        
                <td class="d-flex align-items-center">
                    <div class="pl-3 email">
                        <span>${element.body}</span>
                        <span></span>
                    </div>
                </td>
                <td></td>
                <td class="status border-bottom-0"><span id="status-span" class=""></span></td>
                <td></td>
                <td></td>
                <td></td>
              </tr>

`
        });
        $("[sgs-ticket-section]").html(htmlValue);

    },

    getAll: function () {
        var that = this;
        $.ajax({
            url: "https://localhost:44358/ticketing/GetAllTicketConversation",
            type: "POST",
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                console.log(response.ticket.ticketConversations.sort(x => x.created));


                var htmlValue = "";
                that.data = response.ticket.ticketConversations.sort(x => x.created);
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


