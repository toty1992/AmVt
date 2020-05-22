using Core.Application.Base;
using Core.DATA;
using Core.Models;
using Core.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class WeatherApplication: BaseApplication
    {
        public IEnumerable<WeatherModel> Get(int stateId)
        {
            var entities = Context.Weathers.Where(e => e.Date >= DateTime.Today 
                        && e.IdState==stateId).OrderBy(x => x.Date).Take(7);
            return entities.toModel();
        }
    }
}
