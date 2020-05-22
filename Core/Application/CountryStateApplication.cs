using Core.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class CountryStateApplication : BaseApplication
    {
        public IEnumerable<KeyValuePair<int,string>> GetCountries()
        {
            var list = new List<KeyValuePair<int, string>>();
            var entities = Context.Countries;
            foreach (var e in entities)
            {
                list.Add(new KeyValuePair<int, string>(e.id, e.Name));
            }
            return list;
        }

        public IEnumerable<KeyValuePair<int, string>> GetStates()
        {
            var list = new List<KeyValuePair<int, string>>();
            var entities = Context.States;
            foreach (var e in entities)
            {
                list.Add(new KeyValuePair<int, string>(e.Id, e.Name));
            }
            return list;
        }
    }
}
