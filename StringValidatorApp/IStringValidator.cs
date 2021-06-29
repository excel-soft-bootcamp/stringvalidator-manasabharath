using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public interface IStringValidator
    {
        bool IsValidString(string data);
    }
}
