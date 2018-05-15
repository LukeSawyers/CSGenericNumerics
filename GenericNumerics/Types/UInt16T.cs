using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class UInt16T : Numeric<ushort>
    {
        private UInt16T(ushort value)
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
            return (UInt16T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (UInt16T)Value++;
        }
        protected override Numeric Negative()
        {
            return (UInt16T)(-Value);
        }
        protected override Numeric Positive()
        {
            return (UInt16T)(Value);
        }

        public static UInt16T operator ++(UInt16T n)
        {
            return (UInt16T)n.Value++;
        }

        public static UInt16T operator --(UInt16T n)
        {
            return (UInt16T)n.Value--;
        }

        public static UInt16T operator +(UInt16T n)
        {
            return (UInt16T)(+n.Value);
        }

        public static UInt16T operator -(UInt16T n)
        {
            return (UInt16T)(-n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator UInt16T(UInt8T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(UInt32T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(UInt64T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(Int16T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(Int32T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(Int64T n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(SingleT n)
        {
            return new UInt16T((ushort)n.Value);
        }
        public static implicit operator UInt16T(DoubleT n)
        {
            return new UInt16T((ushort)n.Value);
        }

        public static implicit operator UInt16T(byte n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(ushort n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(uint n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(ulong n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(short n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(int n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(long n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(float n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(double n)
        {
            return new UInt16T((ushort)n);
        }
        public static implicit operator UInt16T(string n)
        {
            ushort val = 0;
            var success = ushort.TryParse(n, out val);
            return new UInt16T(val);
        }

        #endregion

        #endregion
    }
}
