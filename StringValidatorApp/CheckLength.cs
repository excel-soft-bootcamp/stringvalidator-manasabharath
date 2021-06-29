using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public class CheckLength :IStringValidator
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
