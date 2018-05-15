using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class DoubleT : Numeric<double>
    {
        private DoubleT(double value)
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
            return (DoubleT)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (DoubleT)Value++;
        }
        protected override Numeric Negative()
        {
            return (DoubleT)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (DoubleT)(Value);
        }

        public static DoubleT operator ++(DoubleT n)
        {
            return (DoubleT)n.Value++;
        }

        public static DoubleT operator --(DoubleT n)
        {
            return (DoubleT)n.Value--;
        }

        public static DoubleT operator +(DoubleT n)
        {
            return (DoubleT)(+n.Value);
        }

        public static DoubleT operator -(DoubleT n)
        {
            return (DoubleT)(-(uint)n.Value);
        }

        #endregion

#endregion

        #region Casts

        public static implicit operator DoubleT(UInt8T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(UInt16T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(UInt32T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(UInt64T n)
        {
            return new DoubleT((double)n.Value);
        }

        public static implicit operator DoubleT(Int16T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(Int32T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(Int64T n)
        {
            return new DoubleT((double)n.Value);
        }
        public static implicit operator DoubleT(SingleT n)
        {
            return new DoubleT((double)n.Value);
        }

        public static implicit operator DoubleT(byte n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(ushort n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(uint n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(ulong n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(short n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(int n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(double n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(long n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(float n)
        {
            return new DoubleT((double)n);
        }
        public static implicit operator DoubleT(string n)
        {
            double val = 0;
            var success = double.TryParse(n, out val);
            return new DoubleT(val);
        }

        #endregion

    }
}
