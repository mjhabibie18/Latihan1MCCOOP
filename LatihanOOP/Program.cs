using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    class Program
    {
        static void Main()
        {
            int pilih;
            int jml = 0;

            for (; ; )
            {

                string InputPilih = "yes";


                if (jml != 0)
                {
                    Console.Write("You want Restart? [yes/no]: ");
                    InputPilih = Console.ReadLine();
                }
                if (InputPilih.ToLower() == "no" && jml != 0)
                {
                    break;
                }
                else if (InputPilih.ToLower() == "yes" && jml != 0 || jml == 0)
                {

                    Pilihan class1 = new Pilihan();
                    ProsesHitung class2 = new ProsesHitung();
                    class1.pilihan();
                    pilih = Convert.ToInt16(Console.ReadLine());

                    switch (pilih)
                    {
                        case 1:
                            try { 
                            Console.Write("Input your weight(kg): ");
                            double bmi1 = double.Parse(Console.ReadLine());
                            Console.Write("Input Your Height(cm):");
                            double bmi2 = double.Parse(Console.ReadLine());
                            class2.HitungBMI(bmi1, bmi2);
                            Console.ReadLine();
                            }
                            catch (FormatException e){
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Data Harus angka");
                                Console.ResetColor();
                            }
                            break;

                        case 2:
                            Console.Write("Please Input Name: ");
                            string cetak = Console.ReadLine();
                            class2.UrutHuruf(cetak);
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Input your name: ");
                            string nama = Console.ReadLine();
                            class2.HurufGenap(nama);
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("Input number aray = ");
                            int angka = Convert.ToInt16(Console.ReadLine());
                            class2.SumArray(angka);
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("please input number from 1 - 4");
                            Console.ReadLine();
                            break;
                    }
                    jml++;
                }
            }

        }
    }
}
