using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public class StringValidator
    {
        IStringValidator _validate;

        public StringValidator(IStringValidator validate)
        {
            this._validate = validate;
        }

        public bool CheckValidString(string data)
        {
            return _validate.IsValidString(data);
        }
    }
}
