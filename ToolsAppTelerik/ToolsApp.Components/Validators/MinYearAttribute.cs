using System;
using System.ComponentModel.DataAnnotations;

namespace ToolsApp.Components.Validators
{
  public class MinYearAttribute : ValidationAttribute
  {
    private int _minCarYear = 1886;

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if (Convert.ToInt32(value) < _minCarYear)
      {
        return new ValidationResult($"{validationContext.DisplayName} is not a valid car year.");
      }

      return ValidationResult.Success;
    }
  }

}
