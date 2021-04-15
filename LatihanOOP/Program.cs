using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    class Pilihan : Program
    {
        public void pilihan()
        {
            Console.WriteLine("Input Number from 1 - 4");
            Console.WriteLine("1. Body Max Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Print Even's Character");
            Console.WriteLine("4. Sum The Input Array");
        }
    }
    class ProsesHitung : Pilihan
    {
        public void HitungBMI(double bmi1, double bmi2)
        {
            bmi2 = bmi2 / 100;
            double hasilbmi = bmi1 / (bmi2 * bmi2);
            if (hasilbmi < 18.1)
            {
                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are Underweight");
            }
            else if ((hasilbmi >= 18.1) && (hasilbmi <= 23.1))
            {
                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are Normal");
            }
            else if ((hasilbmi >= 23.1) && (hasilbmi <= 28.1))
            {
                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are overweight");
            }
            else
            {
                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are obesitas");
            }
            Console.ReadLine();
        }
        public void UrutHuruf(string cetak)
        {
            char[] a = cetak.ToCharArray();
            for (int i = 0; i < cetak.Length; i++)
            {
                Console.WriteLine("Huruf ke " + (i + 1) + " adalah " + a[i]);
            }
        }
        public void HurufGenap(string nama)
        {
            char[] per = nama.ToCharArray();
            for (int i = 0; i < per.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(per[i]);
                }
            }
            Console.ReadLine();
        }
        public void SumArray(int angka)
        {
            int z = 0;
            int y = 0;
            for (int i = 1; i <= angka; i++)
            {
                z = Convert.ToInt16(Console.ReadLine());
                y = y + z;
            }
            Console.Write("Result Sum Array is " + y);
        }
    }

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
                            Console.Write("Input your weight(kg): ");
                            double bmi1 = double.Parse(Console.ReadLine());
                            Console.Write("Input Your Height(cm):");
                            double bmi2 = double.Parse(Console.ReadLine());
                            class2.HitungBMI(bmi1, bmi2);
                            Console.ReadLine();
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
