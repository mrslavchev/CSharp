using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern 
{
  // The type T must be marked with the attribute [Serializable(  )]

    [Serializable()]
    public abstract class IPrototype<T>
    {

        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}