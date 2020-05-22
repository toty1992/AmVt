using AVService.Helper;
using Core.Application;
using Core.Factory;
using System.Web.Http;

namespace AVService.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: Weather
        public IHttpActionResult Get(int stateId)
        {
            Logger.Instance.LogString("Metodo Get Weather");
            var fac = new ApplicationFactory();
            var wApp = fac.GetApplication<WeatherApplication>();
            var response = wApp.Get(stateId);

            if(response!=null)
                return Ok(response);

            return NotFound();
        }
    }
}