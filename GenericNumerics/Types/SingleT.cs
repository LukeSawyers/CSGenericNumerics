using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public class SingleT : Numeric<float>
    {
        private SingleT(float value)
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
            return (SingleT)Value--;
        }
        protected override Numeric DoIncrement()
        {
            return (SingleT)Value++;
        }
        protected override Numeric Negative()
        {
            return (SingleT)(-(uint)Value);
        }
        protected override Numeric Positive()
        {
            return (SingleT)(Value);
        }

        public static SingleT operator ++(SingleT n)
        {
            return (SingleT)n.Value++;
        }

        public static SingleT operator --(SingleT n)
        {
            return (SingleT)n.Value--;
        }

        public static SingleT operator +(SingleT n)
        {
            return (SingleT)(+n.Value);
        }

        public static SingleT operator -(SingleT n)
        {
            return (SingleT)(-(uint)n.Value);
        }

        #endregion

        #region Casts

        public static implicit operator SingleT(UInt8T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(UInt16T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(UInt32T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(UInt64T n)
        {
            return new SingleT((float)n.Value);
        }

        public static implicit operator SingleT(Int16T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(Int32T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(Int64T n)
        {
            return new SingleT((float)n.Value);
        }
        public static implicit operator SingleT(DoubleT n)
        {
            return new SingleT((float)n.Value);
        }

        public static implicit operator SingleT(byte n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(ushort n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(uint n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(ulong n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(short n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(int n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(float n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(long n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(double n)
        {
            return new SingleT((float)n);
        }
        public static implicit operator SingleT(string n)
        {
            float val = 0;
            var success = float.TryParse(n, out val);
            return new SingleT(val);
        }

        #endregion

        #endregion
    }
}
