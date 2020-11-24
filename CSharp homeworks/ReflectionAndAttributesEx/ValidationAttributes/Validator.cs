using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.CustomAttributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType()
                .GetProperties();

            foreach (var property in properties)
            {
                IEnumerable<MyValidationAttribute> customAtt = property.GetCustomAttributes().Cast<MyValidationAttribute>();

                foreach (var attribute in customAtt)
                {

                    var valid = attribute.IsValid(property.GetValue(obj));
                    if (valid == false)
                    {
                        return false;
                    }

                }


            }

            return true;
        }
    }
}
