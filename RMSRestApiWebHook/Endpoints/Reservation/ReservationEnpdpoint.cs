using RMSRestApiWebHook.Contracts.v1.Reservation.Requests;

namespace RMSRestApiWebHook.Endpoints.Reservation
{
    public class ReservationEnpdpoint: Endpoint<CreateReservationRequest>
    {
        public override void Configure()
        {
            Post("/reservations");
            AllowAnonymous();
        }
        
        public override async Task HandleAsync(CreateReservationRequest request, CancellationToken ct)
        {
            Console.WriteLine(JsonSerializer.Serialize(request));
            var response = new
            {
                name = "Crispin",
                age = 29,
            };
            await SendAsync(response, cancellation:ct);
        }
    }
}
