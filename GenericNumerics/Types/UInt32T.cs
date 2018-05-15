using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public sealed class UInt32T : Numeric<uint>
    {
        private UInt32T(uint value)
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
            return (UInt32T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (UInt32T)Value++;
        }
        protected override Numeric Negative()
        {
            return (UInt32T)(-Value);
        }
        protected override Numeric Positive()
        {
            return (UInt32T)(Value);
        }

        public static UInt32T operator ++(UInt32T n)
        {
            return (UInt32T)n.Value++;
        }

        public static UInt32T operator --(UInt32T n)
        {
            return (UInt32T)n.Value--;
        }

        public static UInt32T operator +(UInt32T n)
        {
            return (UInt32T)(+n.Value);
        }

        public static UInt32T operator -(UInt32T n)
        {
            return (UInt32T)(-n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator UInt32T(UInt8T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(UInt16T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(UInt64T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(Int16T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(Int32T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(Int64T n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(SingleT n)
        {
            return new UInt32T((uint)n.Value);
        }
        public static implicit operator UInt32T(DoubleT n)
        {
            return new UInt32T((uint)n.Value);
        }

        public static implicit operator UInt32T(byte n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(ushort n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(uint n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(ulong n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(short n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(int n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(long n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(float n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(double n)
        {
            return new UInt32T((uint)n);
        }
        public static implicit operator UInt32T(string n)
        {
            uint val = 0;
            var success = uint.TryParse(n, out val);
            return new UInt32T(val);
        }

        #endregion

        #endregion
    }
}
