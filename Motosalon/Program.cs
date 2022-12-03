using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motosalon
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*List<string> Typemotorcycle = new List<string>()
            {
                "Спортивний",
                "Кросовий",
                "Туристичний"
            };
            List<string> TypeScooterList = new List<string>()
            {
                "Дорожний",
                "Максі",
                "Скутеретта",
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("TypeScooter.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, TypeScooterList);
            }*/
            /*Dictionary<string, List<string>> BrandModelMotorcycle = new Dictionary<string, List<string>>();
            BrandModelMotorcycle.Add("BMW", new List<string>() { "K1600GTL", "S1000RR", "G650GS Sertao" });
            BrandModelMotorcycle.Add("Ducati", new List<string>() { "SuperSport", "Multistrada", "1299 Panigale" });
            BrandModelMotorcycle.Add("Honda", new List<string>() { "CBR600RR", "GL1800", "CRF450X" });
            BrandModelMotorcycle.Add("Kawasaki", new List<string>() { "ZX-10RR", "1400GTR", "KLX125" });
            BrandModelMotorcycle.Add("Suzuki", new List<string>() { "GSX-R1000", "V-Strom", "Hayabusa" });
            BrandModelMotorcycle.Add("Yamaha", new List<string>() { "YZF-R6", "XT1200ZE", "WR250R" });*/
            /*Dictionary<string, List<string>> BrandModelScooter = new Dictionary<string, List<string>>();
            BrandModelScooter.Add("VIPER", new List<string>() { "ACTIVE 125", "VP150F" });
            BrandModelScooter.Add("LIFAN", new List<string>() { "KPV 150 ADV " });
            BrandModelScooter.Add("FORTE", new List<string>() { "NEW JOG", "CANOE" });
            BrandModelScooter.Add("SPARK", new List<string>() { "SP110С-3С", "SP80S-16" });
            BrandModelScooter.Add("MUSSTANG", new List<string>() { "MT125-3", "MT110-3" });
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BrandModelScooter.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, BrandModelScooter);
            }*/


            /*List<Mototransport> mototransports = new List<Mototransport>()
             {
                 new Motorcycle("BMW", "K1600GTL", 24000, 1649, "Туристичний"),
                 new Motorcycle("BMW", "S1000RR", 17000, 999, "Спортивний"),
                 new Motorcycle("BMW", "G650GS Sertao", 9500, 652, "Кросовий"),
                 new Motorcycle("Ducati", "SuperSport", 12000, 937 , "Спортивний"),
                 new Motorcycle("Ducati", "Multistrada", 13000, 1198, "Туристичний"),
                 new Motorcycle("Ducati", "1299 Panigale", 27000, 1285, "Спортивний"),
                 new Motorcycle("Honda", "CBR600RR", 10000, 599, "Спортивний"),
                 new Motorcycle("Honda", "GL1800", 13000, 1833, "Туристичний"),
                 new Motorcycle("Honda", "CRF450X", 8000, 449, "Кросовий"),
                 new Motorcycle("Kawasaki", "ZX-10RR", 19000, 998, "Спортивний"),
                 new Motorcycle("Kawasaki", "1400GTR", 20000, 1352, "Туристичний"),
                 new Motorcycle("Kawasaki", "KLX125", 4000, 125, "Кросовий"),
                 new Motorcycle("Suzuki", "GSX-R1000", 15000, 999, "Спортивний"),
                 new Motorcycle("Suzuki", "V-Strom", 10000, 1037, "Туристичний"),
                 new Motorcycle("Suzuki", "Hayabusa", 14000, 1340 , "Туристичний"),
                 new Motorcycle("Yamaha", "YZF-R6", 13000, 599, "Спортивний"),
                 new Motorcycle("Yamaha", "XT1200ZE", 13000, 1199, "Туристичний"),
                 new Motorcycle("Yamaha", "WR250R", 7000, 250, "Кросовий"),

                 new Scooter("VIPER", "ACTIVE 125", 700, 125, "Скутеретта"),
                 new Scooter("VIPER", "VP150F", 750, 150, "Дорожний"),
                 new Scooter("LIFAN", "KPV 150 ADV ", 2000, 150, "Дорожний"),
                 new Scooter("FORTE", "NEW JOG", 750, 80, "Дорожний"),
                 new Scooter("FORTE", "CANOE", 1000, 150, "Дорожний"),
                 new Scooter("SPARK", "SP110С-3С", 600, 110, "Скутеретта"),
                 new Scooter("SPARK", "SP80S-16", 800, 80, "Дорожний"),
                 new Scooter("MUSSTANG", "MT125-3", 800, 125, "Скутеретта"),
                 new Scooter("MUSSTANG", "MT110-3", 800, 110, "Скутеретта"),
             };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("MotoTransport.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, mototransports);
            }*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
