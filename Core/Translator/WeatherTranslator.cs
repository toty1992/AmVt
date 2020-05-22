using Core.DATA;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Translator
{
    public static class WeatherTranslator
    {
        public static WeatherModel toModel(this Weather entity)
        {

            var Model = new WeatherModel()
            {
                Temperature = entity.Temperature.Value,
                Weather = entity.Weather1,
                DayName = entity.Date.Value.ToString("dddd"),
            };
            return Model;
        }

        public static List<WeatherModel> toModel(this IEnumerable<Weather> entities)
        {

            var ModelList = new List<WeatherModel>();
            foreach (var e in entities)
            {
                ModelList.Add( e.toModel());
            }
            return ModelList;
        }
    }
}