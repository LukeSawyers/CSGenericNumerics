using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class Int64T : Numeric<long>
    {
        private Int64T(long value)
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
            return (Int64T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (Int64T)Value++;
        }
        protected override Numeric Negative()
        {
            return (Int64T)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (Int64T)(Value);
        }

        public static Int64T operator ++(Int64T n)
        {
            return (Int64T)n.Value++;
        }

        public static Int64T operator --(Int64T n)
        {
            return (Int64T)n.Value--;
        }

        public static Int64T operator +(Int64T n)
        {
            return (Int64T)(+n.Value);
        }

        public static Int64T operator -(Int64T n)
        {
            return (Int64T)(-(uint)n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator Int64T(UInt8T n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(UInt16T n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(UInt32T n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(UInt64T n)
        {
            return new Int64T((long)n.Value);
        }

        public static implicit operator Int64T(Int16T n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(Int32T n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(SingleT n)
        {
            return new Int64T((long)n.Value);
        }
        public static implicit operator Int64T(DoubleT n)
        {
            return new Int64T((long)n.Value);
        }

        public static implicit operator Int64T(byte n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(ushort n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(uint n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(ulong n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(short n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(int n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(long n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(float n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(double n)
        {
            return new Int64T((long)n);
        }
        public static implicit operator Int64T(string n)
        {
            long val = 0;
            var success = long.TryParse(n, out val);
            return new Int64T(val);
        }

        #endregion

        #endregion
    }
}
