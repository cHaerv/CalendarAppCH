using CalendarAppCH.Models;
using CalendarAppCH.Data;
using Microsoft.EntityFrameworkCore;

namespace CalendarAppCH.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }
        private readonly CalendarDbContext _context;

        public AppointmentRepository(CalendarDbContext context)
        {
            _context = context;
        }

        public async Task<List<CalendarAppCH.Models.Appointment>> GetAppointmentsAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
