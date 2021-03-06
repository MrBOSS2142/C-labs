﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte r; r = 56; // От -128 до 127
            short g; g = 32342; //От -32768 до 32767
            int e; e = 12412; // От -2 147 483 648 до 2 147 483 647 
            long q; q = 35; // От –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807
            byte w; w = 251; // От 0 до 255
            ushort t; t = 5343; // От 0 до 65 535 	
            uint h; h = 3242342342; // От 0 до 4 294 967 295
            ulong b; b = 43423; // От 0 до 18 446 744 073 709 551 615
            char m; m = 'g';
            bool d; d = false;
            float l; l = 3.5F; //  -3.4 × 1038 до +3.4 × 1038
            double v; v = 3.7; // ±5.0 × 10−324 до ±1.7 × 10308
            decimal s; s = 353334534345; // до 29 десятичных цифр 1.0x10^-28 до 7.9x10^28
            string z; z = "fsdfdsf";
            object p; p = l;


            Int32 i32 = 5; // int
            Int64 i64 = i32; // long
            Single se = i32;// float
            Double dob = i32;
            Decimal dec = i32;
            Char chr = 'r';
            Object obj = chr;

            Byte bt = (Byte)i32; // byte
            Int16 vv = (Int16)se; // short
            Int32 ii32 = (Int32)chr;
            Decimal nt = (Decimal)i32;
            Double dd = (Double)i32;

            int val = 5;
            object obj1 = val;//упаковка
            int valUnboxed = (int)obj1;//распаковка

            var name = "QQQQQQQ";

            // Определяем тип переменных
            Type nameType = name.GetType();

            // Выводим в консоль результаты
            Console.WriteLine("Тип name: {0}", nameType);
            //Console.ReadLine();

            int? x1 = null;
            int? x2 = null;
            Console.WriteLine(x1 == x2);

            //Строки
            String string1 = "12345";
            String string2 = "54321";
            Console.WriteLine(string1 == string2);

            //соеденение строк
            String str1 = "Hello";
            String str2 = "World1";
            String str3 = "World2";
            Console.WriteLine(str1 + str2 + str3);

            //копирование строки
            string2 = String.Copy(string1);
            Console.WriteLine(string2);

            //выделение подстроки
            String n1 = "Star Wars";
            String n2 = n1.Substring(5, 3);
            Console.WriteLine(n2);

            //разделене строки на слова
            string text = "abc!asd fgr . sadsad";
            char[] delims = ".,;:!?\n\xD\xA\' ".ToCharArray();
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                Console.WriteLine(word);

            //вставка подстроки в заданную позицию
            string original = "QQQWWW";
            string modified = original.Insert(3, " III ");
            Console.WriteLine(modified);

            //удаление подстроки
            string orig = "ASBSWES";
            string rem = orig.Remove(1, 3);
            Console.WriteLine(rem);

            //null строки
            string empty = "";
            string null1 = null;
            Console.WriteLine("String length: " + empty.Length);
            Int32 y = empty.Length;
            Console.WriteLine(null1 == null);

            StringBuilder sg = new StringBuilder("ASDFG", 40);
            sg.Append(new char[] { 'q', 'w' });
            sg.Insert(0, "Star ");
            sg.Remove(3, 1);
            sg.Remove(5, 2);
            Console.WriteLine(sg);

            //Massiv
            int[][] ms = { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 3, 5, 7 } };
            foreach (int[] x in ms)
            {
                foreach (int ss in x)
                    Console.Write("\t" + ss);
                Console.WriteLine();
            }


            string[] masstr = new string[] { "Hello", "all", "humans\n" };
            foreach (string ss in masstr)
                Console.Write("\t" + ss);
            Console.WriteLine("Длина массива {0}", masstr.Length);


            Console.Write($"Введите позицию, от 0 до {masstr.Length - 1}: ");
            System.Int32 position;
            position = Int32.Parse(Console.ReadLine());
            Console.WriteLine(position);
            System.String inf;
            Console.Write("Введите элемент:");
            inf = (Console.ReadLine());
            masstr[position] = inf;
            foreach (string i in masstr)
            {
                Console.WriteLine(i);
            }

            //Ступенчатый масив
            double[][] MyArray = new double[3][];
            MyArray[0] = new double[2];
            MyArray[1] = new double[3];
            MyArray[2] = new double[4];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 2; i++)
            {
                MyArray[0][i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                MyArray[1][i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                MyArray[2][i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ступенчатый массив:");
            foreach (double[] i in MyArray)
            {
                foreach (double j in i)
                {
                    Console.Write("\t" + j);
                }
                Console.WriteLine();
            }
            //Создайте неявно типизированные переменные для хранения массива и строки. 
            Console.WriteLine();
            var stroc = "String1 string 2 string3";
            Console.WriteLine();
            var array1 = new[] { 2, 1, 4, 2 };
            Console.WriteLine(stroc);
            foreach (var i in array1)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine();
            Console.WriteLine();


            //Кортежи
            (int num0, string num1, char num2, string num3, ulong num4) tuple = (17, "Word", 'S', "Letter", 7);//имненование при объявлении
            Console.WriteLine($"Kортеж {tuple}");
            Console.WriteLine(tuple.num0 + " " + tuple.num2 + " " + tuple.num3);

            //Сравнение кортежей
            Console.WriteLine();
            var (o1, t1, th, f1, fi) = (tuple);
            Console.WriteLine("Rasp " + o1 + " " + t1 + " " + th + " " + f1 + " " + fi);
            Console.WriteLine();
            (Int32, String, Char, String, UInt64) person = (17, "Word", 'S', "Letter", 7);
            Console.WriteLine("Сравнение кортежей: " + tuple.Equals(person));

            Int32[] ar = { 2, 3, 8, 6, -1, 0, 6 };
            System.String s1 = "Home";
            Console.WriteLine(fun(ar, s1));
            (Int32, Int32, Int32, String) fun(Int32[] number, String name11)
            {
                Int32 max = 0, min = 0, sum = 0;
                for (Int32 i = 0; i < 7; i++)
                {
                    if (max < number[i])
                    {
                        max = number[i];
                    }
                }
                for (Int32 i = 0; i < 7; i++)
                {
                    if (min > ar[i])
                    {
                        min = ar[i];
                    }
                }
                for (Int32 i = 0; i < 7; i++)
                {
                    sum += ar[i];
                }
                System.String b_1 = name11.Substring(0, 1);
                return (max, min, sum, b_1);
            }

        }
    }
}
