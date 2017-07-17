using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirts.Models
{
    public class ValidacionesPersonalizadas : ValidationAttribute
    {
        private readonly int _maxValue;

        public ValidacionesPersonalizadas(int maxValue)
        {
            _maxValue = maxValue;
        }

        public override bool IsValid(object value)
        {
            return (int)value <= _maxValue;
        }
    }
}