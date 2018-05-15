using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericNumerics
{
    public abstract class Numeric<TType, TNumber> : INumeric<TNumber> where TType : Numeric<TType, TNumber>, new()
    {
        public static TType operator+ (INumeric n1, INumeric n2)
        {
            var result = new TType();
            result.Value = (TNumber)n1.Value + (TNumber)n2.Value;
            return 
        }

        private TNumber _value;

        public object Value
        {
            get
            {
                return (object)_value;
            }
            set
            {
                _value = (TNumber)value;
            }
        }

        public TNumber ToNative()
        {
            return _value;
        }
    }

    public interface INumeric<T> : INumeric
    {
        T ToNative();
    }

    public interface INumeric
    {
        object Value { get; set; }
    }
}
