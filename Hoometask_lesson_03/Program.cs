using System.Numerics;
using static System.Console;

namespace Hometask_03
{
    class Geometry /*Класс для задания 1*/
    {
        char Symbol;
        int Length;
        public Geometry()
        {
            WriteLine("Введите символ: ");
            this.Symbol = Convert.ToChar(ReadLine());
            WriteLine("Введите длину стороны квадрата: ");
            this.Length = Convert.ToInt32(ReadLine());
        }
        public void Print_square()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Write($"{Symbol}  ");
                }
                WriteLine();
            }
        }
    }
    class Programm
    {
        //Метод для задания 2
        static void Palyndrome(int number)
        {
            string num = Convert.ToString(number);
            bool check = true;
            for (int i = 0, j = num.Length - 1; i < num.Length / 2; i++, j--)
            {
                if (num[i] != num[j])
                {
                    check = false;
                    break;
                }
            }
            WriteLine(check == true ? ($"Число {number} является палиндромом") : ($"Число {number} НЕ является палиндромом"));
        }
        //Метод для задания 3
        static Array Sorting(ref int[] input, int[] sort)
        {
            input = input.Except(sort).ToArray();
            return input;
        }

        //Класс для задания 4

        class Web
        {
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _address;
            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            private string _description;
            public string Description
            {
                get { return _description; }
                set { _description= value; }
            }
            private string _ip;
            public string Ip
            {
                get { return _ip; }
                set { _ip = value; }
            }
            public void Print ()
            {
                WriteLine("{0}\n{1}\n{2}\n{3}", _name, _address, _description, _ip);
            }

        }
        static void Main(string[] arg)
        {
            /*Задание 1*/
            /*Geometry g1 = new Geometry();
            g1.Print_square();*/

            /*Задание 2*/
            //Palyndrome(2);


            /*Задание 3*/
            /*int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 2, 4, 5 };
            Sorting(ref arr1, arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                Write($"{arr1[i]}\t");
            }
            WriteLine();*/

            /*Задание 4*/
            /*Web site=new Web();
            site.Address = "krjfhr";
            site.Ip = "1736.947.485";
            site.Name = "hyutghbjnk"; 
            site.Print();*/


            
            
        }

    }
}


