using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon
{
    [Serializable]
    class Scooter : Mototransport
    {
        private string typeScooter;
        public string TypeScooter
        {
            get
            {
                return typeScooter;
            }
            set
            {
                WorkingWithFiles<List<string>> workingWithFiles = new WorkingWithFiles<List<string>>();
                if (value == "")
                {
                    typeScooter = "";
                    return;
                }

                List<string> TypeScooterList = workingWithFiles.ReadingFromFile("TypeScooter.bin");
                if (TypeScooterList == null)
                    return;

                if (TypeScooterList.Contains(value) == true)
                {
                    typeScooter = value;
                }
                else
                {
                    throw new TypeMotorcycleException("Неправильно введено тип мотоцикла", value);
                }
            }
        }
        public Scooter(string Brand, string Model, int Price, int Volume, string TypeScooter) : base(Brand, Model, Price, Volume)
        {
            this.TypeScooter = TypeScooter;
        }
    }
}
