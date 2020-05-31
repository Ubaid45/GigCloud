using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigCloud.Core.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out var dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}