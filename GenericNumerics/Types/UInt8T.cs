using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class UInt8T : Numeric<byte>
    {
        private UInt8T(byte value)
        {
            Value = value;
        }

        #region Operators

        #region Binary 

        protected override Numeric DoAddition<TOther>(Numeric other)
        {
            return Value + (TOther)other.ObjectValue;
        }

        protected override Numeric DoDivision<TOther>(Numeric other)
        {
            return Value / (TOther)other.ObjectValue;
        }

        protected override Numeric DoModulo<TOther>(Numeric other)
        {
            return Value % (TOther)other.ObjectValue;
        }

        protected override Numeric DoMultiplication<TOther>(Numeric other)
        {
            return Value * (TOther)other.ObjectValue;
        }

        protected override Numeric DoSubtraction<TOther>(Numeric other)
        {
            return Value - (TOther)other.ObjectValue;
        }

        #endregion

        #region Unary

        protected override Numeric DoDecrement()
        {
            return (UInt8T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (UInt8T)Value++;
        }
        protected override Numeric Negative()
        {
            return (UInt8T)(-Value);
        }
        protected override Numeric Positive()
        {
            return (UInt8T)(Value);
        }

        public static UInt8T operator ++(UInt8T n)
        {
            return (UInt8T)n.Value++;
        }

        public static UInt8T operator --(UInt8T n)
        {
            return (UInt8T)n.Value--;
        }

        public static UInt8T operator +(UInt8T n)
        {
            return (UInt8T)(+n.Value);
        }

        public static UInt8T operator -(UInt8T n)
        {
            return (UInt8T)(-n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator UInt8T(UInt16T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(UInt32T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(UInt64T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(Int16T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(Int32T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(Int64T n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(SingleT n)
        {
            return new UInt8T((byte)n.Value);
        }
        public static implicit operator UInt8T(DoubleT n)
        {
            return new UInt8T((byte)n.Value);
        }

        public static implicit operator UInt8T(byte n) 
        {
            return new UInt8T(n);
        }
        public static implicit operator UInt8T(ushort n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(uint n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(ulong n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(short n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(int n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(long n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(float n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(double n)
        {
            return new UInt8T((byte)n);
        }
        public static implicit operator UInt8T(string n)
        {
            byte val = 0;
            var success = byte.TryParse(n, out val);
            return new UInt8T(val);
        }

        #endregion

        #endregion
    }
}
