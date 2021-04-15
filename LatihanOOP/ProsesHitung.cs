using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    class ProsesHitung : Pilihan
    {
        private double hasilbmi;
        public void setHasilBMI(double hasilbmi)
        {
            this.hasilbmi = hasilbmi;
        }

        public double getHasilBMI()
        {
            return hasilbmi;
        }

        public void HitungBMI(double bmi1, double bmi2)
        {
            bmi2 = bmi2 / 100;
            setHasilBMI( bmi1 / (bmi2 * bmi2));
            if (getHasilBMI() < 18.1)
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
                if (i % 2 == 0)
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
                //penampung berupa array
            {
                z = Convert.ToInt16(Console.ReadLine());
                y = y + z;
            }
            Console.Write("Result Sum Array is " + y);
        }
    }
}
