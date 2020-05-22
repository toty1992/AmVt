using AVService.Helper;
using Core.Application;
using Core.Factory;
using System.Web.Http;

namespace AVService.Controllers
{
    public class CountryController : ApiController
    {
        // GET: Weather
        public IHttpActionResult Get()
        {
            Logger.Instance.LogString("Metodo Get Country");
            var fac = new ApplicationFactory();
            var wApp = fac.GetApplication<CountryStateApplication>();
            var response = wApp.GetCountries();

            if (response != null)
                return Ok(response);

            return NotFound();
        }
    }
}