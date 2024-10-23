using CalendarAppCH.Data;
using CalendarAppCH.Models;


namespace CalendarAppCH.Repositories
{
    public interface IAppointmentRepository
    {
        Task<Appointment> GetAppointmentByIdAsync(int id);
        Task<List<Appointment>> GetAppointmentsAsync();
        Task AddAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
