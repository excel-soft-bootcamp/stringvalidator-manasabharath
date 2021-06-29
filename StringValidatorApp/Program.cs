using System;

namespace StringValidatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IsNullOrEmpty _nullOrEmpty = new IsNullOrEmpty();
            StringValidator _validateNullOrEmpty = new StringValidator(_nullOrEmpty);
            _validateNullOrEmpty.CheckValidString(null);

            CheckLength _length = new CheckLength();
            StringValidator _validateLength = new StringValidator(_length);
            _validateLength.CheckValidString("string");

            StartsWith _startswith = new StartsWith();
            StringValidator _validateStartsWith = new StringValidator(_startswith);
            _validateStartsWith.CheckValidString("ex");
        }
    }
}
