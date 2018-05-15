using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public static class BitConverter
    {
        public static byte[] GetBytes(Numeric value)
        {
            return System.BitConverter.GetBytes((dynamic)value);
        }
    }
}
