using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            T array;
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    array = (T)formatter.Deserialize(fs);
                }
            }
            catch
            {
                return default(T);
            }
           
            return array;
        }

        public void WritingToFile(T array, string FilePath)
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
                    formatter.Serialize(fs, array);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
