using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Appointments
{
     public class AppointmentsListViewModel
    {
        public IEnumerable<AppointmentViewModel> Appointments { get; set; }
    }
}
