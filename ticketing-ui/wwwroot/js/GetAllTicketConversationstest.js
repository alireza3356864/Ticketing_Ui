
var ticketing = {
    data: null,
    init: function () {
        var that = this;
        that.getAll();

    },
    loadData: function () {
        var className = ""
        var htmlValue = '';


        this.searchedData.forEach(element => {
            switch (element.status) {
                case 0:
                    {
                        status = "نامشخص"
                        className = "waiting"
                    }
                    break;

                case 1:
                    {
                        status = "جدید"
                        className = "active"
                    }
                    break;

                case 2:
                    {
                        status = "پاسخ مشتری"
                        className = "waiting"
                    }

                    break;

                case 2: status = "پاسخ کارشناس"
                    break;

                case 3: status = "بسته"
                    break;



                default: "نامشخص";
            }


            htmlValue = `${htmlValue}
             <div class="row justify-content-start">
                <section class="col-8 col-md-6 col-lg-4 card-text-ticketconversation-store">
                    <a href="#" class="text-decoration-none d-block mb-4 margin-botton">
                        <section class="card bg-primary text-white border-none">
                            <section class="card-body">
                                <section class="d-flex justify-content-between">
                                    <section class="info-box-body">
                                        <p> شش  سس بب اا متن تیکت تستی </p>
                                    </section>
                                </section>
                            </section>
                            <section class="p-2 info-box-footer">
                                <i class="fas fa-clock mx-2"></i>
                                24:42
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
        var that = this;
        $.ajax({
            url: "https://localhost:44358/ticketing/GetAllTicketConversation",
            type: "POST",
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                console.log(response);


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
//    ticketing.init();
});



