using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ToolsApp.Components.Validators
{
  public class HexcodeAttribute: ValidationAttribute {

    private Regex _hexcodeRegex;

    public HexcodeAttribute(int hexcodeLength) {
      _hexcodeRegex = new Regex("^[0-9a-fA-F]{" + hexcodeLength.ToString() + "}$");
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var inputValue = Convert.ToString(value);

      if (inputValue is null)
      {
        return new ValidationResult($"{validationContext.DisplayName} is not a valid hexcode");
      }

      if (!_hexcodeRegex.IsMatch(inputValue))
      {
        return new ValidationResult($"{validationContext.DisplayName} is not a valid hexcode");
      }

      return ValidationResult.Success;

    }

  }


}