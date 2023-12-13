
// string name = "Alex";
//
// int[] numbers = { 2, 35, 645, 4, 34, 6 };
// var number = 777;
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
//     numbers[4] = number;
// }
//
//
// class Person
// {
//     private string name;
//     private int age;
//
//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
//
//     void Print()
//     {
//         Console.WriteLine(name + ", " + age);
//     }
//     
//     static void Main(string[] args)
//     {
//         Person myObj = new Person("Bill", 25);
//         myObj.Print();
//     }
//     
// }


using System.Formats.Asn1;

namespace _01._Intro;
    


internal class Program
{
    static void Main(string[] args)
    {
        // int[] arr = new int[3];
        // arr[0] = 1;
        // arr[1] = 2;
        // arr[2] = 3;
        // Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2]);
        //
        // int[] arr2 = new int[5];
        // for (int i = 0; i < arr2.Length; i++)
        // {
        //     arr2[i] = i * 2;
        // }
        //
        // for (int i = 0; i < arr2.Length; i++)
        // {
        //     Console.Write(arr2[i] + " ");
        // }
        // Console.WriteLine();
        //
        // foreach (var i in arr2)
        // {
        //     //i = 5; read only
        //     Console.Write(i + " ");
        // }
        //
        // // 6 - references type
        // int[] arr3 = new int[7];
        // arr3 = null;
        
        
        // -------------------

        // int[,] arr = new int[3,4];
        //
        // arr[0, 0] = 1;
        // arr[0, 1] = 2;
        // arr[0, 2] = 3;
        //
        //
        //
        // arr[1, 0] = 4;
        // arr[1, 1] = 5;
        // arr[1, 2] = 6;
        //
        //
        //
        // arr[2, 0] = 7;
        // arr[2, 1] = 8;
        // arr[2, 2] = 9;
        // Console.Write(arr[0, 0] +" ");
        // Console.Write(arr[0, 1] + " ");
        // Console.Write(arr[0, 2] + " ");
        // Console.WriteLine();
        // Console.Write(arr[1, 0] + " ");
        // Console.Write(arr[1, 1] + " ");
        // Console.Write(arr[1, 2] + " ");
        // Console.WriteLine();
        // Console.Write(arr[2, 0] + " ");
        // Console.Write(arr[2, 1] + " ");
        // Console.Write(arr[2, 2] + " ");
        // Console.WriteLine();
        //
        // // 2 -----------------
        // Console.WriteLine();
        //
        // int[,] arr2 = new int[3, 4];
        // for (int i = 0; i < arr2.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arr2.GetLength(1); j++)
        //     {
        //         arr2[i, j] = i * j + 1;
        //     }
        // }
        //
        // for (int i = 0; i <= arr2.GetUpperBound(0); i++)
        // {
        //     for (int j = 0; j <= arr2.GetUpperBound(1); j++)
        //     {
        //         Console.Write(arr2[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }
        //
        // // 3 ---------------
        // Console.WriteLine();
        //
        // int[,] arr3 = new int[3, 4];
        //
        // for (int i = 0; i <= arr3.GetUpperBound(0); i++)
        // {
        //     for (int j = 0; j <= arr3.GetUpperBound(1); j++)
        //     {
        //         Console.Write(arr3[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }
        //
        // // 4 -----------------
        //
        // int[,] arr4 =
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };
        
        /*Завдання 1
           Створіть додаток, який відображає кількість парних,
           непарних, унікальних елементів масиву.*/
        
        bool PairNumber(int n)
        {
            return (n % 2 == 0);
        }
        
        bool UnpairNumber(int n)
        {
            return (n % 2 > 0);
        }

        bool UniqueNumber(int[] arr, int n)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                    temp++;
            }

            if (temp <= 1)
                return true;
            else if (temp > 1)
                return false;
            
            return false;
        }
        

        
        
        void Application(int[] arr)
        {
            int pair = 0;
            int unpair = 0;
            int unique = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (PairNumber(arr[i]))
                    pair++;
                if (UnpairNumber(arr[i]))
                    unpair++;
                if (UniqueNumber(arr, arr[i]))
                    unique++;

            }
            Console.WriteLine("Pair numbers: " + pair);
            Console.WriteLine("Unpair numbers: " + unpair);
            Console.WriteLine("Unique numbers: " + unique);
        }

        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter a number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Application(arr);
        
    }
}