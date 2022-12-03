using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon
{
    class WorkingWithFiles<T>
    {
        public T ReadingFromFile(string FilePath)
        {
            if (FilePath == "")
            {
                return default(T);
            }

            var file = new FileInfo(FilePath);
            if (file.Exists == false)
            {
                return default(T);
            }
            if (file.Length == 0)
            {
                return default(T);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            T massiv;
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    massiv = (T)formatter.Deserialize(fs);
                }
            }
            catch
            {
                return default(T);
            }
           
            return massiv;
        }
        public void WritingToFile(T massiv, string FilePath)
        {
            if (FilePath == "")
            {
                return;
            }

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, massiv);
                   
                }
            }
            catch
            {
                return;
            }
        }
    }
}
