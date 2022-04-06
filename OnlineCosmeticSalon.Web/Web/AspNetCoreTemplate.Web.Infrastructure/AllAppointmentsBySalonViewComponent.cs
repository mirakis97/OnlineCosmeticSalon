using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.Appointments;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Infrastructure
{
    public class AllAppointmentsBySalonViewComponent : ViewComponent
    {

        private readonly IAppointmentsService appointmentsService;

        public AllAppointmentsBySalonViewComponent(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId)
        {
            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetAllBySalonAsync<AppointmentViewModel>(salonId),
            };

            return this.View(viewModel);
        }
    }
}
