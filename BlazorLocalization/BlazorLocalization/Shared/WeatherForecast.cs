using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLocalization.Shared.Languages;


namespace BlazorLocalization.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        //[Range(18, 80, ErrorMessage = "Temperature must be between 18°C and 22°C.")]
        [Range(18, 22, ErrorMessageResourceName = nameof(Languages.ResourceLanguage.TemperatureValidationMessageRange), ErrorMessageResourceType = typeof(Languages.ResourceLanguage))]
        public int TemperatureC { get; set; }

        //[Required(ErrorMessage = "The field is required")]
        [Required(ErrorMessageResourceName = nameof(Languages.ResourceLanguage.ErrorValidationRequired), ErrorMessageResourceType = typeof(Languages.ResourceLanguage))]
        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }
}
