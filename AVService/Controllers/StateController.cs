using AVService.Helper;
using Core.Application;
using Core.Factory;
using System.Web.Http;

namespace AVService.Controllers
{
    public class StateController : ApiController
    {
        // GET: Weather
        public IHttpActionResult Get()
        {
            Logger.Instance.LogString("Metodo Get State");
            var fac = new ApplicationFactory();
            var wApp = fac.GetApplication<CountryStateApplication>();
            var response = wApp.GetStates();

            if (response != null)
                return Ok(response);

            return NotFound();
        }
    }
}