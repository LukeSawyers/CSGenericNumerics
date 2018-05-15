using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics.Example
{
    public class App<TNumeric> where TNumeric : Numeric
    {
        TNumeric value;

        public void DoAthing()
        {
            Numeric number = 1;
            number = number + value;
        }
    }
}
