using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Exceptions
{
    public class BadValueException : Exception
    {
        public object Value { get; private set; }
        public Type ValueType { get; private set; }

        public BadValueException(string message, object value) : this(message)
        {
            Value = value;
            ValueType = value.GetType();
        }
        public BadValueException(string message) : base(message)
        {

        }

        public BadValueException() : this("Valeur non attendue")
        {

        }
    }
}
