using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NumberInStockBetween1And20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (20 >= movie.NumberInStock && movie.NumberInStock >= 1)
                return ValidationResult.Success;
            else
                return new ValidationResult("Number in Stock must be in between 1 and 20, inclusive");
        }
    }
}