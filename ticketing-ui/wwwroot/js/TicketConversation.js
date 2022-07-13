
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
            var ticketid = document.getElementById("ticketid").innerHTML;
            $.ajax({
                url: "https://localhost:44358/ticketing/InsertTicketConversation",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify({
                    body: body.value,
                    status: 2,
                    TicketId: ticketid,
                    ParentId: ""
                }),

                success: function (response) {
                    console.log(response.ticketConversation.body);

                    var htmlValue = '';
                    var className = "";
                    var ColorBox = "";
                    var JustifyElement = "";

                    switch (response.ticketConversation.sectionType) {
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
                                        <p>${response.ticketConversation.body}</p >
                                    </section>
                                </section>
                            </section>
                            <section class="p-2 info-box-footer">
                                <i class="fas fa-clock mx-2"></i>
                               ${response.ticketConversation.createdPersian}
                            </section>
                        </section>
                    </a>
                </section>
             </div>

`
                   /* $("[sgs-ticket-section]").html(htmlValue);*/


                    $("[sgs-ticket-section]").append(htmlValue);

                    

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










