using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class UInt64T : Numeric<ulong>
    {
        private UInt64T(ulong value)
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
            return (UInt64T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (UInt64T)Value++;
        }
        protected override Numeric Negative()
        {
            return (UInt64T)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (UInt64T)(Value);
        }

        public static UInt64T operator ++(UInt64T n)
        {
            return (UInt64T)n.Value++;
        }

        public static UInt64T operator --(UInt64T n)
        {
            return (UInt64T)n.Value--;
        }

        public static UInt64T operator +(UInt64T n)
        {
            return (UInt64T)(+n.Value);
        }

        public static UInt64T operator -(UInt64T n)
        {
            return (UInt64T)(-(uint)n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator UInt64T(UInt8T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(UInt16T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(UInt32T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(Int16T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(Int32T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(Int64T n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(SingleT n)
        {
            return new UInt64T((ulong)n.Value);
        }
        public static implicit operator UInt64T(DoubleT n)
        {
            return new UInt64T((ulong)n.Value);
        }

        public static implicit operator UInt64T(byte n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(ushort n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(uint n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(ulong n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(short n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(int n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(long n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(float n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(double n)
        {
            return new UInt64T((ulong)n);
        }
        public static implicit operator UInt64T(string n)
        {
            ulong val = 0;
            var success = ulong.TryParse(n, out val);
            return new UInt64T(val);
        }

        #endregion

        #endregion
    }
}
