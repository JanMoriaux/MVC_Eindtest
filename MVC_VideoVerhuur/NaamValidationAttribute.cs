using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace MVC_VideoVerhuur
{
    public class NaamValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex regex = new Regex("^[a-zA-Z']");

            if (value == null)
            {
                return true;
            }
            if (!regex.IsMatch((string)value))
            {
                return false;
            }
            return true;
        }
    }
}