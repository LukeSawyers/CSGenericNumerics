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
            if (value.GetType() == typeof(UInt8T))
            {
                return new byte[1] { (byte)value };
            }
            if (value.GetType() == typeof(UInt16T))
            {
                return System.BitConverter.GetBytes((ushort)value);
            }
            if (value.GetType() == typeof(UInt32T))
            {
                return System.BitConverter.GetBytes((uint)value);
            }
            if (value.GetType() == typeof(UInt64T))
            {
                return System.BitConverter.GetBytes((ulong)value);
            }
            if (value.GetType() == typeof(Int16T))
            {
                return System.BitConverter.GetBytes((short)value);
            }
            if (value.GetType() == typeof(Int32T))
            {
                return System.BitConverter.GetBytes((int)value);
            }
            if (value.GetType() == typeof(Int64T))
            {
                return System.BitConverter.GetBytes((long)value);
            }
            if (value.GetType() == typeof(SingleT))
            {
                return System.BitConverter.GetBytes((float)value);
            }
            if (value.GetType() == typeof(DoubleT))
            {
                return System.BitConverter.GetBytes((double)value);
            }
            return new byte[0];
        }
    }
}
