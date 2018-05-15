using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public abstract class Numeric<T> : Numeric
    {
        public T Value { get; set; }

        public override object ObjectValue
        {
            get { return Value; }
            set { Value = (T)value; }
        }
    }

    public abstract class Numeric
    {

        public abstract object ObjectValue { get; set; }

        public override string ToString()
        {
            return ObjectValue.ToString();
        }

        #region Operators

        #region Binary

        #region Addition

        protected abstract Numeric DoAddition<TOther>(Numeric other) where TOther : Numeric;

        public static Numeric operator +(Numeric n1, Numeric n2)
        {
            return n1.DoAddition<Numeric>(n2);
        }

        public static Numeric operator +(Numeric n1, UInt8T n2)
        {
            return n1.DoAddition<UInt8T>(n2);
        }
        public static Numeric operator +(Numeric n1, UInt16T n2)
        {
            return n1.DoAddition<UInt16T>(n2);
        }
        public static Numeric operator +(Numeric n1, UInt32T n2)
        {
            return n1.DoAddition<UInt32T>(n2);
        }
        public static Numeric operator +(Numeric n1, UInt64T n2)
        {
            return n1.DoAddition<UInt64T>(n2);
        }

        public static Numeric operator +(Numeric n1, Int16T n2)
        {
            return n1.DoAddition<Int16T>(n2);
        }
        public static Numeric operator +(Numeric n1, Int32T n2)
        {
            return n1.DoAddition<Int32T>(n2);
        }
        public static Numeric operator +(Numeric n1, Int64T n2)
        {
            return n1.DoAddition<Int64T>(n2);
        }

        public static Numeric operator +(Numeric n1, SingleT n2)
        {
            return n1.DoAddition<SingleT>(n2);
        }
        public static Numeric operator +(Numeric n1, DoubleT n2)
        {
            return n1.DoAddition<DoubleT>(n2);
        }

        public static Numeric operator +(UInt8T n1, Numeric n2)
        {
            return n1.DoAddition<UInt8T>(n2);
        }
        public static Numeric operator +(UInt16T n1, Numeric n2)
        {
            return n1.DoAddition<UInt16T>(n2);
        }
        public static Numeric operator +(UInt32T n1, Numeric n2)
        {
            return n1.DoAddition<UInt32T>(n2);
        }
        public static Numeric operator +(UInt64T n1, Numeric n2)
        {
            return n1.DoAddition<UInt64T>(n2);
        }

        public static Numeric operator +(Int16T n1, Numeric n2)
        {
            return n1.DoAddition<Int16T>(n2);
        }
        public static Numeric operator +(Int32T n1, Numeric n2)
        {
            return n1.DoAddition<Int32T>(n2);
        }
        public static Numeric operator +(Int64T n1, Numeric n2)
        {
            return n1.DoAddition<Int64T>(n2);
        }

        public static Numeric operator +(SingleT n1, Numeric n2)
        {
            return n1.DoAddition<SingleT>(n2);
        }
        public static Numeric operator +(DoubleT n1, Numeric n2)
        {
            return n1.DoAddition<DoubleT>(n2);
        }

        public static Numeric operator +(Numeric n1, byte n2)
        {
            return n1.DoAddition<UInt8T>(n2);
        }
        public static Numeric operator +(Numeric n1, ushort n2)
        {
            return n1.DoAddition<UInt16T>(n2);
        }
        public static Numeric operator +(Numeric n1, uint n2)
        {
            return n1.DoAddition<UInt32T>(n2);
        }
        public static Numeric operator +(Numeric n1, ulong n2)
        {
            return n1.DoAddition<UInt64T>(n2);
        }

        public static Numeric operator +(Numeric n1, short n2)
        {
            return n1.DoAddition<Int16T>(n2);
        }
        public static Numeric operator +(Numeric n1, int n2)
        {
            return n1.DoAddition<Int32T>(n2);
        }
        public static Numeric operator +(Numeric n1, long n2)
        {
            return n1.DoAddition<Int64T>(n2);
        }

        public static Numeric operator +(Numeric n1, float n2)
        {
            return n1.DoAddition<SingleT>(n2);
        }
        public static Numeric operator +(Numeric n1, double n2)
        {
            return n1.DoAddition<DoubleT>(n2);
        }
        public static Numeric operator +(Numeric n1, string n2)
        {
            return n1.DoAddition<DoubleT>((DoubleT)n2);
        }

        public static Numeric operator +(byte n1, Numeric n2)
        {
            return n2.DoAddition<UInt8T>(n1);
        }
        public static Numeric operator +(ushort n1, Numeric n2)
        {
            return n2.DoAddition<UInt16T>(n1);
        }
        public static Numeric operator +(uint n1, Numeric n2)
        {
            return n2.DoAddition<UInt32T>(n1);
        }
        public static Numeric operator +(ulong n1, Numeric n2)
        {
            return n2.DoAddition<UInt64T>(n1);
        }

        public static Numeric operator +(short n1, Numeric n2)
        {
            return n2.DoAddition<Int16T>(n1);
        }
        public static Numeric operator +(int n1, Numeric n2)
        {
            return n2.DoAddition<Int32T>(n1);
        }
        public static Numeric operator +(long n1, Numeric n2)
        {
            return n2.DoAddition<Int64T>(n1);
        }

        public static Numeric operator +(float n1, Numeric n2)
        {
            return n2.DoAddition<SingleT>(n1);
        }
        public static Numeric operator +(double n1, Numeric n2)
        {
            return n2.DoAddition<DoubleT>(n1);
        }
        public static Numeric operator +(string n1, Numeric n2)
        {
            return n2.DoAddition<DoubleT>((DoubleT)n1);
        }

        #endregion

        #region Subtraction

        protected abstract Numeric DoSubtraction<TOther>(Numeric other) where TOther : Numeric;

        public static Numeric operator -(Numeric n1, Numeric n2)
        {
            return n1.DoSubtraction<Numeric>(n2);
        }

        public static Numeric operator -(Numeric n1, UInt8T n2)
        {
            return n1.DoSubtraction<UInt8T>(n2);
        }
        public static Numeric operator -(Numeric n1, UInt16T n2)
        {
            return n1.DoSubtraction<UInt16T>(n2);
        }
        public static Numeric operator -(Numeric n1, UInt32T n2)
        {
            return n1.DoSubtraction<UInt32T>(n2);
        }
        public static Numeric operator -(Numeric n1, UInt64T n2)
        {
            return n1.DoSubtraction<UInt64T>(n2);
        }

        public static Numeric operator -(Numeric n1, Int16T n2)
        {
            return n1.DoSubtraction<Int16T>(n2);
        }
        public static Numeric operator -(Numeric n1, Int32T n2)
        {
            return n1.DoSubtraction<Int32T>(n2);
        }
        public static Numeric operator -(Numeric n1, Int64T n2)
        {
            return n1.DoSubtraction<Int64T>(n2);
        }

        public static Numeric operator -(Numeric n1, SingleT n2)
        {
            return n1.DoSubtraction<SingleT>(n2);
        }
        public static Numeric operator -(Numeric n1, DoubleT n2)
        {
            return n1.DoSubtraction<DoubleT>(n2);
        }

        public static Numeric operator -(UInt8T n1, Numeric n2)
        {
            return n1.DoSubtraction<UInt8T>(n2);
        }
        public static Numeric operator -(UInt16T n1, Numeric n2)
        {
            return n1.DoSubtraction<UInt16T>(n2);
        }
        public static Numeric operator -(UInt32T n1, Numeric n2)
        {
            return n1.DoSubtraction<UInt32T>(n2);
        }
        public static Numeric operator -(UInt64T n1, Numeric n2)
        {
            return n1.DoSubtraction<UInt64T>(n2);
        }

        public static Numeric operator -(Int16T n1, Numeric n2)
        {
            return n1.DoSubtraction<Int16T>(n2);
        }
        public static Numeric operator -(Int32T n1, Numeric n2)
        {
            return n1.DoSubtraction<Int32T>(n2);
        }
        public static Numeric operator -(Int64T n1, Numeric n2)
        {
            return n1.DoSubtraction<Int64T>(n2);
        }

        public static Numeric operator -(SingleT n1, Numeric n2)
        {
            return n1.DoSubtraction<SingleT>(n2);
        }
        public static Numeric operator -(DoubleT n1, Numeric n2)
        {
            return n1.DoSubtraction<DoubleT>(n2);
        }

        public static Numeric operator -(Numeric n1, byte n2)
        {
            return n1.DoSubtraction<UInt8T>(n2);
        }
        public static Numeric operator -(Numeric n1, ushort n2)
        {
            return n1.DoSubtraction<UInt16T>(n2);
        }
        public static Numeric operator -(Numeric n1, uint n2)
        {
            return n1.DoSubtraction<UInt32T>(n2);
        }
        public static Numeric operator -(Numeric n1, ulong n2)
        {
            return n1.DoSubtraction<UInt64T>(n2);
        }

        public static Numeric operator -(Numeric n1, short n2)
        {
            return n1.DoSubtraction<Int16T>(n2);
        }
        public static Numeric operator -(Numeric n1, int n2)
        {
            return n1.DoSubtraction<Int32T>(n2);
        }
        public static Numeric operator -(Numeric n1, long n2)
        {
            return n1.DoSubtraction<Int64T>(n2);
        }

        public static Numeric operator -(Numeric n1, float n2)
        {
            return n1.DoSubtraction<SingleT>(n2);
        }
        public static Numeric operator -(Numeric n1, double n2)
        {
            return n1.DoSubtraction<DoubleT>(n2);
        }
        public static Numeric operator -(Numeric n1, string n2)
        {
            return n1.DoSubtraction<DoubleT>((DoubleT)n2);
        }

        public static Numeric operator -(byte n1, Numeric n2)
        {
            return n2.DoSubtraction<UInt8T>(n1);
        }
        public static Numeric operator -(ushort n1, Numeric n2)
        {
            return n2.DoSubtraction<UInt16T>(n1);
        }
        public static Numeric operator -(uint n1, Numeric n2)
        {
            return n2.DoSubtraction<UInt32T>(n1);
        }
        public static Numeric operator -(ulong n1, Numeric n2)
        {
            return n2.DoSubtraction<UInt64T>(n1);
        }

        public static Numeric operator -(short n1, Numeric n2)
        {
            return n2.DoSubtraction<Int16T>(n1);
        }
        public static Numeric operator -(int n1, Numeric n2)
        {
            return n2.DoSubtraction<Int32T>(n1);
        }
        public static Numeric operator -(long n1, Numeric n2)
        {
            return n2.DoSubtraction<Int64T>(n1);
        }

        public static Numeric operator -(float n1, Numeric n2)
        {
            return n2.DoSubtraction<SingleT>(n1);
        }
        public static Numeric operator -(double n1, Numeric n2)
        {
            return n2.DoSubtraction<DoubleT>(n1);
        }
        public static Numeric operator -(string n1, Numeric n2)
        {
            return n2.DoSubtraction<DoubleT>((DoubleT)n1);
        }

        #endregion

        #region Multiplication

        protected abstract Numeric DoMultiplication<TOther>(Numeric other) where TOther : Numeric;

        public static Numeric operator *(Numeric n1, Numeric n2)
        {
            return n1.DoMultiplication<Numeric>(n2);
        }

        public static Numeric operator *(Numeric n1, UInt8T n2)
        {
            return n1.DoMultiplication<UInt8T>(n2);
        }
        public static Numeric operator *(Numeric n1, UInt16T n2)
        {
            return n1.DoMultiplication<UInt16T>(n2);
        }
        public static Numeric operator *(Numeric n1, UInt32T n2)
        {
            return n1.DoMultiplication<UInt32T>(n2);
        }
        public static Numeric operator *(Numeric n1, UInt64T n2)
        {
            return n1.DoMultiplication<UInt64T>(n2);
        }

        public static Numeric operator *(Numeric n1, Int16T n2)
        {
            return n1.DoMultiplication<Int16T>(n2);
        }
        public static Numeric operator *(Numeric n1, Int32T n2)
        {
            return n1.DoMultiplication<Int32T>(n2);
        }
        public static Numeric operator *(Numeric n1, Int64T n2)
        {
            return n1.DoMultiplication<Int64T>(n2);
        }

        public static Numeric operator *(Numeric n1, SingleT n2)
        {
            return n1.DoMultiplication<SingleT>(n2);
        }
        public static Numeric operator *(Numeric n1, DoubleT n2)
        {
            return n1.DoMultiplication<DoubleT>(n2);
        }

        public static Numeric operator *(UInt8T n1, Numeric n2)
        {
            return n1.DoMultiplication<UInt8T>(n2);
        }
        public static Numeric operator *(UInt16T n1, Numeric n2)
        {
            return n1.DoMultiplication<UInt16T>(n2);
        }
        public static Numeric operator *(UInt32T n1, Numeric n2)
        {
            return n1.DoMultiplication<UInt32T>(n2);
        }
        public static Numeric operator *(UInt64T n1, Numeric n2)
        {
            return n1.DoMultiplication<UInt64T>(n2);
        }

        public static Numeric operator *(Int16T n1, Numeric n2)
        {
            return n1.DoMultiplication<Int16T>(n2);
        }
        public static Numeric operator *(Int32T n1, Numeric n2)
        {
            return n1.DoMultiplication<Int32T>(n2);
        }
        public static Numeric operator *(Int64T n1, Numeric n2)
        {
            return n1.DoMultiplication<Int64T>(n2);
        }

        public static Numeric operator *(SingleT n1, Numeric n2)
        {
            return n1.DoMultiplication<SingleT>(n2);
        }
        public static Numeric operator *(DoubleT n1, Numeric n2)
        {
            return n1.DoMultiplication<DoubleT>(n2);
        }

        public static Numeric operator *(Numeric n1, byte n2)
        {
            return n1.DoMultiplication<UInt8T>(n2);
        }
        public static Numeric operator *(Numeric n1, ushort n2)
        {
            return n1.DoMultiplication<UInt16T>(n2);
        }
        public static Numeric operator *(Numeric n1, uint n2)
        {
            return n1.DoMultiplication<UInt32T>(n2);
        }
        public static Numeric operator *(Numeric n1, ulong n2)
        {
            return n1.DoMultiplication<UInt64T>(n2);
        }

        public static Numeric operator *(Numeric n1, short n2)
        {
            return n1.DoMultiplication<Int16T>(n2);
        }
        public static Numeric operator *(Numeric n1, int n2)
        {
            return n1.DoMultiplication<Int32T>(n2);
        }
        public static Numeric operator *(Numeric n1, long n2)
        {
            return n1.DoMultiplication<Int64T>(n2);
        }

        public static Numeric operator *(Numeric n1, float n2)
        {
            return n1.DoMultiplication<SingleT>(n2);
        }
        public static Numeric operator *(Numeric n1, double n2)
        {
            return n1.DoMultiplication<DoubleT>(n2);
        }
        public static Numeric operator *(Numeric n1, string n2)
        {
            return n1.DoMultiplication<DoubleT>((DoubleT)n2);
        }

        public static Numeric operator *(byte n1, Numeric n2)
        {
            return n2.DoMultiplication<UInt8T>(n1);
        }
        public static Numeric operator *(ushort n1, Numeric n2)
        {
            return n2.DoMultiplication<UInt16T>(n1);
        }
        public static Numeric operator *(uint n1, Numeric n2)
        {
            return n2.DoMultiplication<UInt32T>(n1);
        }
        public static Numeric operator *(ulong n1, Numeric n2)
        {
            return n2.DoMultiplication<UInt64T>(n1);
        }

        public static Numeric operator *(short n1, Numeric n2)
        {
            return n2.DoMultiplication<Int16T>(n1);
        }
        public static Numeric operator *(int n1, Numeric n2)
        {
            return n2.DoMultiplication<Int32T>(n1);
        }
        public static Numeric operator *(long n1, Numeric n2)
        {
            return n2.DoMultiplication<Int64T>(n1);
        }

        public static Numeric operator *(float n1, Numeric n2)
        {
            return n2.DoMultiplication<SingleT>(n1);
        }
        public static Numeric operator *(double n1, Numeric n2)
        {
            return n2.DoMultiplication<DoubleT>(n1);
        }
        public static Numeric operator *(string n1, Numeric n2)
        {
            return n2.DoMultiplication<DoubleT>((DoubleT)n1);
        }

        #endregion

        #region Division

        protected abstract Numeric DoDivision<TOther>(Numeric other) where TOther : Numeric;

        public static Numeric operator /(Numeric n1, Numeric n2)
        {
            return n1.DoDivision<Numeric>(n2);
        }

        public static Numeric operator /(Numeric n1, UInt8T n2)
        {
            return n1.DoDivision<UInt8T>(n2);
        }
        public static Numeric operator /(Numeric n1, UInt16T n2)
        {
            return n1.DoDivision<UInt16T>(n2);
        }
        public static Numeric operator /(Numeric n1, UInt32T n2)
        {
            return n1.DoDivision<UInt32T>(n2);
        }
        public static Numeric operator /(Numeric n1, UInt64T n2)
        {
            return n1.DoDivision<UInt64T>(n2);
        }

        public static Numeric operator /(Numeric n1, Int16T n2)
        {
            return n1.DoDivision<Int16T>(n2);
        }
        public static Numeric operator /(Numeric n1, Int32T n2)
        {
            return n1.DoDivision<Int32T>(n2);
        }
        public static Numeric operator /(Numeric n1, Int64T n2)
        {
            return n1.DoDivision<Int64T>(n2);
        }

        public static Numeric operator /(Numeric n1, SingleT n2)
        {
            return n1.DoDivision<SingleT>(n2);
        }
        public static Numeric operator /(Numeric n1, DoubleT n2)
        {
            return n1.DoDivision<DoubleT>(n2);
        }

        public static Numeric operator /(UInt8T n1, Numeric n2)
        {
            return n1.DoDivision<UInt8T>(n2);
        }
        public static Numeric operator /(UInt16T n1, Numeric n2)
        {
            return n1.DoDivision<UInt16T>(n2);
        }
        public static Numeric operator /(UInt32T n1, Numeric n2)
        {
            return n1.DoDivision<UInt32T>(n2);
        }
        public static Numeric operator /(UInt64T n1, Numeric n2)
        {
            return n1.DoDivision<UInt64T>(n2);
        }

        public static Numeric operator /(Int16T n1, Numeric n2)
        {
            return n1.DoDivision<Int16T>(n2);
        }
        public static Numeric operator /(Int32T n1, Numeric n2)
        {
            return n1.DoDivision<Int32T>(n2);
        }
        public static Numeric operator /(Int64T n1, Numeric n2)
        {
            return n1.DoDivision<Int64T>(n2);
        }

        public static Numeric operator /(SingleT n1, Numeric n2)
        {
            return n1.DoDivision<SingleT>(n2);
        }
        public static Numeric operator /(DoubleT n1, Numeric n2)
        {
            return n1.DoDivision<DoubleT>(n2);
        }

        public static Numeric operator /(Numeric n1, byte n2)
        {
            return n1.DoDivision<UInt8T>(n2);
        }
        public static Numeric operator /(Numeric n1, ushort n2)
        {
            return n1.DoDivision<UInt16T>(n2);
        }
        public static Numeric operator /(Numeric n1, uint n2)
        {
            return n1.DoDivision<UInt32T>(n2);
        }
        public static Numeric operator /(Numeric n1, ulong n2)
        {
            return n1.DoDivision<UInt64T>(n2);
        }

        public static Numeric operator /(Numeric n1, short n2)
        {
            return n1.DoDivision<Int16T>(n2);
        }
        public static Numeric operator /(Numeric n1, int n2)
        {
            return n1.DoDivision<Int32T>(n2);
        }
        public static Numeric operator /(Numeric n1, long n2)
        {
            return n1.DoDivision<Int64T>(n2);
        }

        public static Numeric operator /(Numeric n1, float n2)
        {
            return n1.DoDivision<SingleT>(n2);
        }
        public static Numeric operator /(Numeric n1, double n2)
        {
            return n1.DoDivision<DoubleT>(n2);
        }
        public static Numeric operator /(Numeric n1, string n2)
        {
            return n1.DoDivision<DoubleT>((DoubleT)n2);
        }

        public static Numeric operator /(byte n1, Numeric n2)
        {
            return n2.DoDivision<UInt8T>(n1);
        }
        public static Numeric operator /(ushort n1, Numeric n2)
        {
            return n2.DoDivision<UInt16T>(n1);
        }
        public static Numeric operator /(uint n1, Numeric n2)
        {
            return n2.DoDivision<UInt32T>(n1);
        }
        public static Numeric operator /(ulong n1, Numeric n2)
        {
            return n2.DoDivision<UInt64T>(n1);
        }

        public static Numeric operator /(short n1, Numeric n2)
        {
            return n2.DoDivision<Int16T>(n1);
        }
        public static Numeric operator /(int n1, Numeric n2)
        {
            return n2.DoDivision<Int32T>(n1);
        }
        public static Numeric operator /(long n1, Numeric n2)
        {
            return n2.DoDivision<Int64T>(n1);
        }

        public static Numeric operator /(float n1, Numeric n2)
        {
            return n2.DoDivision<SingleT>(n1);
        }
        public static Numeric operator /(double n1, Numeric n2)
        {
            return n2.DoDivision<DoubleT>(n1);
        }
        public static Numeric operator /(string n1, Numeric n2)
        {
            return n2.DoDivision<DoubleT>((DoubleT)n1);
        }

        #endregion

        #region Modulo

        protected abstract Numeric DoModulo<TOther>(Numeric other) where TOther : Numeric;

        public static Numeric operator %(Numeric n1, Numeric n2)
        {
            return n1.DoModulo<Numeric>(n2);
        }

        public static Numeric operator %(Numeric n1, UInt8T n2)
        {
            return n1.DoModulo<UInt8T>(n2);
        }
        public static Numeric operator %(Numeric n1, UInt16T n2)
        {
            return n1.DoModulo<UInt16T>(n2);
        }
        public static Numeric operator %(Numeric n1, UInt32T n2)
        {
            return n1.DoModulo<UInt32T>(n2);
        }
        public static Numeric operator %(Numeric n1, UInt64T n2)
        {
            return n1.DoModulo<UInt64T>(n2);
        }

        public static Numeric operator %(Numeric n1, Int16T n2)
        {
            return n1.DoModulo<Int16T>(n2);
        }
        public static Numeric operator %(Numeric n1, Int32T n2)
        {
            return n1.DoModulo<Int32T>(n2);
        }
        public static Numeric operator %(Numeric n1, Int64T n2)
        {
            return n1.DoModulo<Int64T>(n2);
        }

        public static Numeric operator %(Numeric n1, SingleT n2)
        {
            return n1.DoModulo<SingleT>(n2);
        }
        public static Numeric operator %(Numeric n1, DoubleT n2)
        {
            return n1.DoModulo<DoubleT>(n2);
        }

        public static Numeric operator %(UInt8T n1, Numeric n2)
        {
            return n1.DoModulo<UInt8T>(n2);
        }
        public static Numeric operator %(UInt16T n1, Numeric n2)
        {
            return n1.DoModulo<UInt16T>(n2);
        }
        public static Numeric operator %(UInt32T n1, Numeric n2)
        {
            return n1.DoModulo<UInt32T>(n2);
        }
        public static Numeric operator %(UInt64T n1, Numeric n2)
        {
            return n1.DoModulo<UInt64T>(n2);
        }

        public static Numeric operator %(Int16T n1, Numeric n2)
        {
            return n1.DoModulo<Int16T>(n2);
        }
        public static Numeric operator %(Int32T n1, Numeric n2)
        {
            return n1.DoModulo<Int32T>(n2);
        }
        public static Numeric operator %(Int64T n1, Numeric n2)
        {
            return n1.DoModulo<Int64T>(n2);
        }

        public static Numeric operator %(SingleT n1, Numeric n2)
        {
            return n1.DoModulo<SingleT>(n2);
        }
        public static Numeric operator %(DoubleT n1, Numeric n2)
        {
            return n1.DoModulo<DoubleT>(n2);
        }

        public static Numeric operator %(Numeric n1, byte n2)
        {
            return n1.DoModulo<UInt8T>(n2);
        }
        public static Numeric operator %(Numeric n1, ushort n2)
        {
            return n1.DoModulo<UInt16T>(n2);
        }
        public static Numeric operator %(Numeric n1, uint n2)
        {
            return n1.DoModulo<UInt32T>(n2);
        }
        public static Numeric operator %(Numeric n1, ulong n2)
        {
            return n1.DoModulo<UInt64T>(n2);
        }

        public static Numeric operator %(Numeric n1, short n2)
        {
            return n1.DoModulo<Int16T>(n2);
        }
        public static Numeric operator %(Numeric n1, int n2)
        {
            return n1.DoModulo<Int32T>(n2);
        }
        public static Numeric operator %(Numeric n1, long n2)
        {
            return n1.DoModulo<Int64T>(n2);
        }

        public static Numeric operator %(Numeric n1, float n2)
        {
            return n1.DoModulo<SingleT>(n2);
        }
        public static Numeric operator %(Numeric n1, double n2)
        {
            return n1.DoModulo<DoubleT>(n2);
        }
        public static Numeric operator %(Numeric n1, string n2)
        {
            return n1.DoModulo<DoubleT>((DoubleT)n2);
        }

        public static Numeric operator %(byte n1, Numeric n2)
        {
            return n2.DoModulo<UInt8T>(n1);
        }
        public static Numeric operator %(ushort n1, Numeric n2)
        {
            return n2.DoModulo<UInt16T>(n1);
        }
        public static Numeric operator %(uint n1, Numeric n2)
        {
            return n2.DoModulo<UInt32T>(n1);
        }
        public static Numeric operator %(ulong n1, Numeric n2)
        {
            return n2.DoModulo<UInt64T>(n1);
        }

        public static Numeric operator %(short n1, Numeric n2)
        {
            return n2.DoModulo<Int16T>(n1);
        }
        public static Numeric operator %(int n1, Numeric n2)
        {
            return n2.DoModulo<Int32T>(n1);
        }
        public static Numeric operator %(long n1, Numeric n2)
        {
            return n2.DoModulo<Int64T>(n1);
        }

        public static Numeric operator %(float n1, Numeric n2)
        {
            return n2.DoModulo<SingleT>(n1);
        }
        public static Numeric operator %(double n1, Numeric n2)
        {
            return n2.DoModulo<DoubleT>(n1);
        }
        public static Numeric operator %(string n1, Numeric n2)
        {
            return n2.DoModulo<DoubleT>((DoubleT)n1);
        }

        #endregion

        #endregion

        #region Unary

        #region Positive

        protected abstract Numeric Positive();
        public static Numeric operator +(Numeric n)
        {
            return n.Positive();
        }

        #endregion

        #region Negative

        protected abstract Numeric Negative();
        public static Numeric operator -(Numeric n)
        {
            return n.Negative();
        }

        #endregion

        #region Increment

        protected abstract Numeric DoIncrement();
        public static Numeric operator ++(Numeric n)
        {
            return n.DoIncrement();
        }

        #endregion

        #region Decrement

        protected abstract Numeric DoDecrement();
        public static Numeric operator --(Numeric n)
        {
            return n.DoDecrement();
        }

        #endregion

        #endregion

        #endregion

        #region Casts

        public static implicit operator Numeric(byte n)
        {
            return (UInt8T)(byte)n;
        }

        public static implicit operator Numeric(ushort n)
        {
            return (UInt16T)(ushort)n;
        }

        public static implicit operator Numeric(uint n)
        {
            return (UInt32T)n;
        }

        public static implicit operator Numeric(ulong n)
        {
            return (UInt64T)(ulong)n;
        }

        public static implicit operator Numeric(short n)
        {
            return (Int16T)(short)n;
        }

        public static implicit operator Numeric(int n)
        {
            return (Int32T)(int)n;
        }

        public static implicit operator Numeric(long n)
        {
            return (Int64T)(long)n;
        }

        public static implicit operator Numeric(float n)
        {
            return (SingleT)(float)n;
        }

        public static implicit operator Numeric(double n)
        {
            return (DoubleT)(double)n;
        }

        #endregion

    }
}
