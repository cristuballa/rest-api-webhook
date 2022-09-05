using Microsoft.EntityFrameworkCore;
using RMSRestApiWebHook.Database;
using RMSRestApiWebHook.Domain;

namespace RMSRestApiWebHook.Services
{
    public class ReservvationService
    {
        private readonly DataContext _dbContext;

        public ReservvationService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Reservation> GetResevationByid(int id)
        {
            var reservation = await _dbContext.Reservations.SingleAsync(x => x.ReservationId == id);
            return reservation;
        }
        public async Task CreateReservation(Reservation reservation)
        {
            _dbContext.Add(reservation);
            await _dbContext.SaveChangesAsync();
        }
    }
}
