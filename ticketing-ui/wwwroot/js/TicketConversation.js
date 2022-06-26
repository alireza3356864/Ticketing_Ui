
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
                    TicketId: "87c7b203-2eac-443f-8081-f537c533ab6b",
                    ParentId:"81acab69-8c3e-468d-8fdd-cc46d95f917d"
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


    } catch (error) {
        throw error;
    }

}