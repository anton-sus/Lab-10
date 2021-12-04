using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите градусы, минуты и секунды:");
            try
            {
                Angle angle1 = new Angle
                {
                    Gradus = Convert.ToInt32(Console.ReadLine()),
                    Min = Convert.ToInt32(Console.ReadLine()),
                    Sec = Convert.ToInt32(Console.ReadLine())
                };
                Console.Write("улог = {0}\xB0 {1}\' {2}\"", angle1.Gradus, angle1.Min, angle1.Sec);
                angle1.ToRadians();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus, min, sec;

        public Angle()
        {
            gradus = 1;
            min = 5;
            sec = 10;
        }
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    this.gradus = value;
                }
                else
                {
                    Console.WriteLine("Градусы не в диапазоне 0-360, присвоено начальнoe значениe: {0}", gradus);

                }

            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    this.min = value;
                }
                else
                {
                    Console.WriteLine("Минуты не в диапазоне от 0 до 60, присвоено начальнoe значениe: {0}", min);

                }

            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    this.sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды не в диапазоне от 0 до 60, присвоено начальнoe значениe: {0}", sec);

                }

            }
            get
            {
                return sec;
            }
        }

        public void ToRadians()
        {
            double g = Convert.ToDouble(gradus + min / 60 + sec / 3600);
            double rad = g * Math.PI / 180;
            Console.WriteLine(" = {0:f2} рад", rad);
        }
    }

}
