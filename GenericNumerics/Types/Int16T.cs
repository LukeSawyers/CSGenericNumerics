using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class Int16T : Numeric<short>
    {
        private Int16T(short value)
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
            return (Int16T)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (Int16T)Value++;
        }
        protected override Numeric Negative()
        {
            return (Int16T)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (Int16T)(Value);
        }

        public static Int16T operator ++(Int16T n)
        {
            return (Int16T)n.Value++;
        }

        public static Int16T operator --(Int16T n)
        {
            return (Int16T)n.Value--;
        }

        public static Int16T operator +(Int16T n)
        {
            return (Int16T)(+n.Value);
        }

        public static Int16T operator -(Int16T n)
        {
            return (Int16T)(-(uint)n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator Int16T(UInt8T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(UInt16T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(UInt32T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(UInt64T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(Int32T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(Int64T n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(SingleT n)
        {
            return new Int16T((short)n.Value);
        }
        public static implicit operator Int16T(DoubleT n)
        {
            return new Int16T((short)n.Value);
        }

        public static implicit operator Int16T(byte n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(ushort n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(uint n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(ulong n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(short n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(int n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(long n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(float n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(double n)
        {
            return new Int16T((short)n);
        }
        public static implicit operator Int16T(string n)
        {
            short val = 0;
            var success = short.TryParse(n, out val);
            return new Int16T(val);
        }

        #endregion

        #endregion
    }
}
