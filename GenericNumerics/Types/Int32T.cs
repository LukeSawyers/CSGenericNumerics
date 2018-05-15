using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class Int32T : Numeric<int>
    {
        private Int32T(int value)
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
            return (Int32T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (Int32T)Value++;
        }
        protected override Numeric Negative()
        {
            return (Int32T)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (Int32T)(Value);
        }

        public static Int32T operator ++(Int32T n)
        {
            return (Int32T)n.Value++;
        }

        public static Int32T operator --(Int32T n)
        {
            return (Int32T)n.Value--;
        }

        public static Int32T operator +(Int32T n)
        {
            return (Int32T)(+n.Value);
        }

        public static Int32T operator -(Int32T n)
        {
            return (Int32T)(-(uint)n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator Int32T(UInt8T n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(UInt16T n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(UInt32T n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(UInt64T n)
        {
            return new Int32T((int)n.Value);
        }

        public static implicit operator Int32T(Int16T n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(Int64T n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(SingleT n)
        {
            return new Int32T((int)n.Value);
        }
        public static implicit operator Int32T(DoubleT n)
        {
            return new Int32T((int)n.Value);
        }

        public static implicit operator Int32T(byte n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(ushort n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(uint n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(ulong n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(short n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(int n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(long n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(float n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(double n)
        {
            return new Int32T((int)n);
        }
        public static implicit operator Int32T(string n)
        {
            int val = 0;
            var success = int.TryParse(n, out val);
            return new Int32T(val);
        }

        #endregion

        #endregion
    }
}
