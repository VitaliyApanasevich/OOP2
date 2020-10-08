using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bool_var=true;
            Console.WriteLine(bool_var);
            byte byte_var = 17;
            Console.WriteLine(byte_var);
            sbyte sbyte_var = 5;
            Console.WriteLine(sbyte_var);
            char char_var = 'b';
            Console.WriteLine(char_var);
            decimal decimal_var = 3.05m;
            Console.WriteLine(decimal_var);
            double double_var = 1.74;
            Console.WriteLine(double_var);
            float float_var = 2.5f;
            Console.WriteLine(float_var);
            int int_var = 4;
            Console.WriteLine(int_var);
            uint uint_var = 15;
            Console.WriteLine(uint_var);
            long long_var = 256;
            Console.WriteLine(long_var);
            ulong ulong_var = 333;
            Console.WriteLine(ulong_var);
            short short_var = 2;
            Console.WriteLine(short_var);
            ushort ushort_var = 444;
            Console.WriteLine(ushort_var);
            object object_var = 1;
            Console.WriteLine(object_var);
            dynamic dynamic_var = 2;
            Console.WriteLine(dynamic_var);
            string string_var = "hello";
            Console.WriteLine(string_var);

            byte short_var2 = 100;
            short byte_short = Convert.ToInt16(short_var2);
            byte int_var2 = 11;
            int byte_int=Convert.ToInt32(int_var2);
            byte long_var2 = 12;
            long byte_long = Convert.ToInt64(long_var2);
            short short_var3 = 1212;
            int short_int = Convert.ToInt32(short_var3);
            short short_var4 = 12455;
            long short_long = Convert.ToInt64(short_var4);

            long long_var3 = 12355665;
            int int_long = Convert.ToInt32(long_var3);
            long long_var4 = 2342;
            short short_long1 = Convert.ToInt16(long_var4);
            int int_var5 = 125;
            short int_short = Convert.ToInt16(int_var5);
            int int_var4 = 11;
            byte byte_int1 = Convert.ToByte(int_var4);
            short short_var5 = 11;
            byte byte_short1 = Convert.ToByte(short_var5);


            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine(i);
            Console.WriteLine(o);

            int k = 123;      
            object ob = k;    
            int kr = (int)ob;

            var ik = 5;
            var sk = "Hello";
            var ak = new[] { 0, 1, 2 };

            //int? x = null;
            //string cantBeNull = string.Empty;
            //Console.WriteLine(x.Value);

            //var f = 16;
            //f = "fa";

            string string_var2 = "Hello World2";
            string string_var3 = "Hello World3";
            string string_var4 = "HelloWorld4";
            string s2;
            s2 = string.Copy(string_var2);
            string string_koncat = string_var2 + string_var3 + string_var4;
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));
            System.Console.WriteLine(s3.Replace("C#", "Basic"));
            String s = "Hello dear world";
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string s4 = string_var3.Remove(5, 5);
            Console.WriteLine(string_var3.Insert(5, ""));

            string name = "Vitaliy";
            var date = DateTime.Now;
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            string s5 = "abcd";
            string s6 = "";
            string s7 = null;
            Console.WriteLine("String s5 {0}.", Test(s5));
            Console.WriteLine("String s6 {0}.", Test(s6));
            Console.WriteLine("String s7 {0}.", Test(s7));
            String Test(string t)
            {
                if (String.IsNullOrEmpty(t))
                    return "is null or empty";
                else
                    return "string is not null or empty";
            }

            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Insert(0, "компьютерный ");
            sb.Insert(23, "! ");
            Console.WriteLine(sb);

            int[,] myArray = new int[4, 5];
            Random rand = new Random();
            for (int j=0; j<4;j++)
            {
                for(int m = 0; m < 5; m++)
                {
                    myArray[j, m] = rand.Next(1, 30);
                    Console.Write("{0}\t", myArray[j, m]);
                }
                Console.WriteLine();
            }

            int[] MyArray =new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine($"Длина массива={MyArray.Length}");
            int temp1;
            int temp2;
            temp1 = MyArray[2];
            temp2 = MyArray[3];
            MyArray[2] = temp2;
            MyArray[3] = temp1;
            for (int t = 0; t< MyArray.Length; t++)
            {
               
                Console.Write(MyArray[t]);
                
            }

     
  
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            for (; i < 2; i++)
            {

                myArr[0][i] = i;
                Console.Write("{0}\t", myArr[0][i]);
            }
            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                myArr[1][i] = i;
                Console.Write("{0}\t", myArr[1][i]);
            }
            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[2][i] = i;
                Console.Write("{0}\t", myArr[2][i]);
            }


            var A = new[] { 5, 10, 23, 16, 8 };
            var string1 = "string";
            Console.WriteLine();
            (int, string, char, string, ulong) kort = (4, "hi", 'r', "name", 444);
            Console.WriteLine(kort);
            Console.WriteLine($"Первый элемент кортежа:{kort.Item1}");

            (int ii, string str, char c, string ss, ulong l) = kort;
            var (ii1,str1,c1,ss1,l1) = kort;
            (_, _, _, _, _) = kort;

            var firstTuple = (9, 3);
            var secondTuple = (9, 3);

            if (firstTuple == secondTuple)
                Console.WriteLine("Первый кортеж равен второму");
            else
                Console.WriteLine("Первый кортеж не равен второму");


            (int, int, int, char) TopleFunction(int[] intArray, string myString)
            {
                Array.Sort(intArray);
                (int, int, int, char) returnTouple;
                returnTouple.Item1 = intArray[0];
                returnTouple.Item2 = intArray[intArray.Length - 1];
                int sum = 0;

                foreach (var element in intArray)
                {
                    sum += element;
                }

                returnTouple.Item3 = sum;
                returnTouple.Item4 = myString[0];
                return returnTouple;
            }
            (int, int, int, char) toupleFunction = TopleFunction(new int[] { 56, 41, 8, 9, 11, 1, 6, 112, 29 }, "MyString");


            Console.WriteLine($"Min: {toupleFunction.Item1}");
            Console.WriteLine($"Max: {toupleFunction.Item2}");
            Console.WriteLine($"Sum: {toupleFunction.Item3}");
            Console.WriteLine($"First Letter: {toupleFunction.Item4}");


            void checkFunctions()
            {
                checked
                {
                    byte sum = (byte)Add(Byte.MaxValue, 1);
                    Console.WriteLine("sum is -> " + sum);
                }
            }
            void uncheckFunnction()
            {
                unchecked
                {
                    byte sum = (byte)Add(Byte.MaxValue, 10);
                    Console.WriteLine("sum is -> " + sum);
                }
            }
            int Add(int x, int y) { return x + y; }
            //checkedFunction();
            uncheckFunnction();
        












        Console.ReadKey(true);
        }
    }
}
