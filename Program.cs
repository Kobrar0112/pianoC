using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Piano1
{
    class Program
    {
        static void Main()
        {
            string abc = " ";
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Инструкция");
                Console.WriteLine("Первая цифра - это номер кнопки");
                Console.WriteLine("Вторая буква после тире - это нота");
                Console.WriteLine("Кнопки 4 и 7 октавы: 0 - C  1 - C#  2 - D  3 - Eb  4 - E  5 - F  6 - F#  7 - G  8 - G#  9 - A  F10 - Bb  F11 - B");
                Console.WriteLine("Кнопки 5 и 8 октавы: K - C  Q - C#  W - D  E - Eb  R - E  T - F  Y - F#  U - G  I - G#  O - A  P - Bb    L - B");
                Console.WriteLine(" ");
                Console.WriteLine("Меню:");
                Console.WriteLine("F1. Выход в меню");
                Console.WriteLine("c. Октава 4 и 5");
                Console.WriteLine("x. Октава 7 и 8");
                Console.WriteLine("z. Выход");
                Console.WriteLine(" ");
                abc = Convert.ToString(Console.ReadLine());

                if (abc == "c")
                {
                    while (true)
                    {
                        int[] octava4 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        int[] octava5 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

                        ConsoleKeyInfo txt = Console.ReadKey(); //true отвечает за отображение нажатых клавиш
                        if (txt.Key == ConsoleKey.F1)
                            break;
                        Clavishi(txt, octava4, octava5);
                    }
                }
                else if (abc == "x")
                {
                    while (true)
                    {
                        int[] octava7 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                        int[] octava8 = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7740, 7459, 7902 };

                        ConsoleKeyInfo txt = Console.ReadKey(); //true отвечает за отображение нажатых клавиш
                        if (txt.Key == ConsoleKey.F1)
                            break;
                        Clavishi(txt, octava7, octava8);
                    }
                }


                static void Clavishi(ConsoleKeyInfo txt, int[] octava4, int[] octava5)
                {

                    if (txt.Key == ConsoleKey.D0) Console.Beep(octava4[0], 400);
                    else if (txt.Key == ConsoleKey.D1) Console.Beep(octava4[1], 400);
                    else if (txt.Key == ConsoleKey.D2) Console.Beep(octava4[2], 400);
                    else if (txt.Key == ConsoleKey.D3) Console.Beep(octava4[3], 400);
                    else if (txt.Key == ConsoleKey.D4) Console.Beep(octava4[4], 400);
                    else if (txt.Key == ConsoleKey.D5) Console.Beep(octava4[5], 400);
                    else if (txt.Key == ConsoleKey.D6) Console.Beep(octava4[6], 400);
                    else if (txt.Key == ConsoleKey.D7) Console.Beep(octava4[7], 400);
                    else if (txt.Key == ConsoleKey.D8) Console.Beep(octava4[8], 400);
                    else if (txt.Key == ConsoleKey.D9) Console.Beep(octava4[9], 400);
                    else if (txt.Key == ConsoleKey.F10) Console.Beep(octava4[10], 400);
                    else if (txt.Key == ConsoleKey.F11) Console.Beep(octava4[11], 400);
                    //актава 5
                    else if (txt.Key == ConsoleKey.K) { Console.Beep(octava5[0], 400); }
                    else if (txt.Key == ConsoleKey.Q) { Console.Beep(octava5[1], 400); }
                    else if (txt.Key == ConsoleKey.W) { Console.Beep(octava5[2], 400); }
                    else if (txt.Key == ConsoleKey.E) { Console.Beep(octava5[3], 400); }
                    else if (txt.Key == ConsoleKey.R) { Console.Beep(octava5[4], 400); }
                    else if (txt.Key == ConsoleKey.T) { Console.Beep(octava5[5], 400); }
                    else if (txt.Key == ConsoleKey.Y) { Console.Beep(octava5[6], 400); }
                    else if (txt.Key == ConsoleKey.U) { Console.Beep(octava5[7], 400); }
                    else if (txt.Key == ConsoleKey.I) { Console.Beep(octava5[8], 400); }
                    else if (txt.Key == ConsoleKey.O) { Console.Beep(octava5[9], 400); }
                    else if (txt.Key == ConsoleKey.P) { Console.Beep(octava5[10], 400); }
                    else if (txt.Key == ConsoleKey.L) { Console.Beep(octava5[11], 400); }
                }

            }
            while (abc != "z");
            Console.WriteLine(" ");
            Console.WriteLine("До свидания");
        }

    }
}