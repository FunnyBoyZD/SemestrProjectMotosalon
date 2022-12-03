using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon
{
    class PriceException : Exception
    {
        public int Value { get; }
        public PriceException(string message, int Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class VolumeException : Exception
    {
        public int Value { get; }
        public VolumeException(string message, int Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class TypeMotorcycleException : Exception
    {
        public string Value { get; }
        public TypeMotorcycleException(string message, string Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class PhoneException : Exception
    {
        public string Value { get; }
        public PhoneException(string message) : base(message)
        {
        }
        public PhoneException(string message, string value) : base(message)
        {
            Value = value;
        }
    }
    class TypeScooterException : Exception
    {
        public string Value { get; }
        public TypeScooterException(string message, string Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class CommentException : Exception
    {
        public int Value { get; }
        public CommentException(string message, int Value) : base(message)
        {
            this.Value = Value;
        }
    }
}
