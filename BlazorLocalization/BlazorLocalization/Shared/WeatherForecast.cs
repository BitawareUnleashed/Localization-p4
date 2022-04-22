using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLocalization.Shared.Languages;
using Microsoft.Extensions.Localization;


namespace BlazorLocalization.Shared
{
    public class WeatherForecast
    {
        private IStringLocalizer<ResourceLanguage> localizer;

        public DateTime Date { get; set; }

        [Range(18, 80, ErrorMessage = "Temperature must be between 18°C and 22°C.")]
        public int TemperatureC { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public WeatherForecast()
        {
            localizer = new StringLocalizer<ResourceLanguage>(new ResourceManagerStringLocalizerFactory(this));

        }
    }
}
