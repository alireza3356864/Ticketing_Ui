////getticket
////---------------------------------------------------------------
//var ticketing = {
//    data: null,
//    init: function () {
//        var that = this;
//        that.getAll();
//    },

//    loadData: function () {
//        var htmlValue = '';
//        var className = "";
//        var ColorBox = "";
//        var JustifyElement = "";

//        this.Data.forEach(element => {
//            switch (element.sectionType) {
//                case 5:
//                    {
//                        className = "justify-content-end"
//                        ColorBox = "bg-gray-costom"
//                        JustifyElement = "card-text-ticketconversation-admin"
//                    }
//                    break; 

//                case 1:
//                    {
//                        className = "justify-content-start"
//                        ColorBox = "bg-primary"
//                        JustifyElement ="card-text-ticketconversation-store"
//                    }
//                    break;


//                default: {
//                    className = "justify-content-start"
//                    ColorBox = "bg-primary"
//                    JustifyElement = "card-text-ticketconversation-store"
//                }
               
//            }


//            htmlValue = `${htmlValue}
//             <div class="row ${className}">
//                <section class="col-8 col-md-6 col-lg-4 ${JustifyElement}">
//                    <a class="text-decoration-none d-block mb-4 margin-botton">
//                        <section class="card ${ColorBox} text-white border-none">
//                            <section class="card-body">
//                                <section class="d-flex justify-content-between">
//                                    <section class="info-box-body">
//                                        <p>${element.body}</p >
//                                    </section>
//                                </section>
//                            </section>
//                            <section class="p-2 info-box-footer">
//                                <i class="fas fa-clock mx-2"></i>
//                               ${element.createdPersian}
//                            </section>
//                        </section>
//                    </a>
//                </section>
//             </div>

//`
//        });
//        $("[sgs-ticket-section]").html(htmlValue);

//    },

//    getAll: function () {
//        var ticketid = document.getElementById("ticketid").innerHTML;
//        var that = this;
//        $.ajax({
//            url: "https://localhost:44358/ticketing/GetAllTicketConversation",
//            type: "POST",
//            dataType: "json",
//            data: JSON.stringify({
//                TicketId: ticketid

//            }),
//            contentType: "application/json; charset=utf-8",

//            success: function (response) {
//                console.log(response.ticket.ticketConversations);


//                var htmlValue = "";
//                that.data = response.ticket.ticketConversations;
//                that.Data = that.data;
//                that.loadData();
//                return htmlValue;
//            },
//            error: function (jqXHR, textStatus, errorThrown) {
//                console.log(textStatus, errorThrown);
//            }
//        });
//    }
//}
//$(document).ready(function () {
//    ticketing.init();
//});
////getticketconversation
////---------------------------------------------------------------
var ticketing = {
    data: null,
    init: function () {
        var that = this;
        that.getAll();
    },

    loadData: function () {
        var htmlValue = '';
        var className = "";
        var ColorBox = "";
        var JustifyElement = "";

        this.Data.forEach(element => {
            switch (element.sectionType) {
                case 5:
                    {
                        className = "justify-content-end"
                        ColorBox = "bg-gray-costom"
                        JustifyElement = "card-text-ticketconversation-admin"
                    }
                    break;

                case 1:
                    {
                        className = "justify-content-start"
                        ColorBox = "bg-primary"
                        JustifyElement = "card-text-ticketconversation-store"
                    }
                    break;


                default: {
                    className = "justify-content-start"
                    ColorBox = "bg-primary"
                    JustifyElement = "card-text-ticketconversation-store"
                }

            }


            htmlValue = `${htmlValue}
             <div class="row ${className}">
                <section class="col-8 col-md-6 col-lg-4 ${JustifyElement}">
                    <a class="text-decoration-none d-block mb-4 margin-botton">
                        <section class="card ${ColorBox} text-white border-none">
                            <section class="card-body">
                                <section class="d-flex justify-content-between">
                                    <section class="info-box-body">
                                        <p>${element.body}</p >
                                    </section>
                                </section>
                            </section>
                            <section class="p-2 info-box-footer">
                                <i class="fas fa-clock mx-2"></i>
                               ${element.createdPersian}
                            </section>
                        </section>
                    </a>
                </section>
             </div>

`
        });
        $("[sgs-ticket-section]").html(htmlValue);

    },

    getAll: function () {
        var ticketid = document.getElementById("ticketid").innerHTML;
        var that = this;
        $.ajax({
            url: "https://localhost:44358/ticketing/GetAllTicketConversation",
            type: "POST",
            dataType: "json",
            data: JSON.stringify({
                TicketId: ticketid

            }),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                console.log(response.ticketConversations);


                var htmlValue = "";
                that.data = response.ticketConversations;
                that.Data = that.data;
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


