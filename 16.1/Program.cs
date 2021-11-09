using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;

namespace _16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Код товара");
            int kod1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название товара");
            string name1 = Console.ReadLine();
            Console.WriteLine("Цена товара");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Tovar tovar1 = new Tovar(kod1, name1, price1)
            {
                Kod = kod1,
                Name = name1,
                Price = price1,
            };

            Console.WriteLine("Код товара");
            int kod2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название товара");
            string name2 = Console.ReadLine();
            Console.WriteLine("Цена товара");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Tovar tovar2 = new Tovar(kod2, name2, price2)
            {
                Kod = kod2,
                Name = name2,
                Price = price2,
            };

            Console.WriteLine("Код товара");
            int kod3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название товара");
            string name3 = Console.ReadLine();
            Console.WriteLine("Цена товара");
            double price3 = Convert.ToDouble(Console.ReadLine());
            Tovar tovar3 = new Tovar(kod3, name3, price3)
            {
                Kod = kod3,
                Name = name3,
                Price = price3,
            };

            Console.WriteLine("Код товара");
            int kod4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название товара");
            string name4 = Console.ReadLine();
            Console.WriteLine("Цена товара");
            double price4 = Convert.ToDouble(Console.ReadLine());
            Tovar tovar4 = new Tovar(kod4, name4, price4)
            {
                Kod = kod4,
                Name = name4,
                Price = price4,
            };

            Console.WriteLine("Код товара");
            int kod5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название товара");
            string name5 = Console.ReadLine();
            Console.WriteLine("Цена товара");
            double price5 = Convert.ToDouble(Console.ReadLine());
            Tovar tovar5 = new Tovar(kod5, name5, price5)
            {
                Kod = kod5,
                Name = name5,
                Price = price5,
            };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                //WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };

            string jsonString1 = JsonSerializer.Serialize(tovar1, options);
            string jsonString2 = JsonSerializer.Serialize(tovar2, options);
            string jsonString3 = JsonSerializer.Serialize(tovar3, options);
            string jsonString4 = JsonSerializer.Serialize(tovar4, options);
            string jsonString5 = JsonSerializer.Serialize(tovar5, options);

            string path = "Tovar";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string path2 = "Tovar/Product.json";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }
            string path3 = "Tovar/Product.json";
            using (StreamWriter sw = new StreamWriter(path3, false))
            {
                sw.WriteLine(jsonString1);
                sw.WriteLine(jsonString2);
                sw.WriteLine(jsonString3);
                sw.WriteLine(jsonString4);
                sw.WriteLine(jsonString5);
            }

            using (StreamReader sr = new StreamReader(path3))
            {
                Tovar restoredtovar1 = JsonSerializer.Deserialize<Tovar>(jsonString1);
                //Console.Write($"Код: {restoredtovar1.Kod}");
                //Console.Write($"  Название: {restoredtovar1.Name}");
                //Console.WriteLine($"  Цена: {restoredtovar1.Price}");

                Tovar restoredtovar2 = JsonSerializer.Deserialize<Tovar>(jsonString2);
                //Console.Write($"Код: {restoredtovar2.Kod}");
                //Console.Write($"  Название: {restoredtovar2.Name}");
                //Console.WriteLine($"  Цена: {restoredtovar2.Price}");

                Tovar restoredtovar3 = JsonSerializer.Deserialize<Tovar>(jsonString3);
                //Console.Write($"Код: {restoredtovar3.Kod}");
                //Console.Write($"  Название: {restoredtovar3.Name}");
                //Console.WriteLine($"  Цена: {restoredtovar3.Price}");

                Tovar restoredtovar4 = JsonSerializer.Deserialize<Tovar>(jsonString4);
                //Console.Write($"Код: {restoredtovar4.Kod}");
                //Console.Write($"  Название: {restoredtovar4.Name}");
                //Console.WriteLine($"  Цена: {restoredtovar4.Price}");

                Tovar restoredtovar5 = JsonSerializer.Deserialize<Tovar>(jsonString5);
                //Console.Write($"Код: {restoredtovar5.Kod}");
                //Console.Write($"  Название: {restoredtovar5.Name}");
                //Console.WriteLine($"  Цена: {restoredtovar5.Price}");


                double[] array = new double[5];
                array[0] = Convert.ToDouble(restoredtovar1.Price);
                array[1] = Convert.ToDouble(restoredtovar2.Price);
                array[2] = Convert.ToDouble(restoredtovar3.Price);
                array[3] = Convert.ToDouble(restoredtovar4.Price);
                array[4] = Convert.ToDouble(restoredtovar5.Price);

                double max = array[0];
                foreach (double a in array)
                {
                    if (a >= max)
                        max = a;
                }
                
                Console.WriteLine();
                Console.WriteLine("Цена товара {0}",max);
            }
            
            Console.ReadKey();
        }
    }
    
    class Tovar
    {
        public int Kod { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Tovar(int kod, string name, double price)
        {
            Kod = kod;
            Name = name;
            Price = price;
        }

    }
}
