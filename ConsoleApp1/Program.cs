
//------11111111111----------
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, -1, 4, -5, -3 };

//            ArrayToo(ref arr);   

//            PrintArray(arr);
//        }
//        static void ArrayToo(ref int[] arr)
//        {     
//            for (int i = 0; i < arr.Length; i++)
//            {


//                if (arr[i] < 0)
//                {    

//                    arr[i] = -arr[i];
//                }

//            }
//        }
//        static void PrintArray(int[] arr)
//        {

//            foreach (int num in arr)
//            {
//                Console.Write(num + " ");


//            }          
//        }

//    }
//}

//--------------222222222-------------


//namespace ConsoleApp1
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            string text = "hello world";

//            bool containsA = CheckA(text, 'a');

//            if (containsA)
//            {
//                Console.WriteLine(true);
//            }
//            else
//            {
//                Console.WriteLine(false);
//            }
//        }

//        static bool CheckA(string text, char a)
//        {

//            foreach (char c in text)
//            {
//                if (c == a)
//                {

//                    return true;
//                }
//            }

//            return false;
//        }


//    }
//}

//-------------33333333----------


//namespace ConsoleApp1
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 3,1,2};

//            int minValue = MinValue(arr);

//            Console.WriteLine(minValue);
//        }

//        static int MinValue(int[] arr)
//        {

//            int min = arr[0];

//            foreach (int num in arr)
//            {
//                if (num < min)
//                {
//                    min = num;
//                }
//            }

//            return min;

//        }
//    }
//}

//--------------444444444444--------------------


//namespace ConsoleApp1
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            int number = 1234;

//            int length = NumLength(number);

//            Console.WriteLine(length);
//        }

//        static int NumLength(int number)
//        {
//            int count = 0;
//            number = Math.Abs(number);
//            do
//            {

//                count++;

//                number /= 10;

//            } while (number != 0);

//            return count;


//        }
//    }
//}


//----------5555555555---------------

//namespace ConsoleApp1
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            string text = "hello world";

//            int vowelCount = CountVowels(text);

//            Console.WriteLine(vowelCount);
//        }

//        static int CountVowels(string text)
//        {
//            int count = 0;


//            foreach (char c in text)
//            {
//                if (Vowel(c))
//                {
//                    count++;
//                }
//            }

//            return count;
//        }

//        static bool Vowel(char c)
//        {
//            switch (char.ToLower(c))
//            {
//                case 'a':
//                case 'e':
//                case 'ı':
//                case 'i':
//                case 'o':
//                case 'ö':
//                case 'u':
//                case 'ü':
//                    return true;
//                default:
//                    return false;
//            }
//        }
//    }
//}


//--------6666666-----------------


namespace ConsoleApp1
{
    internal class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            double average = FindAverage(arr);

            Console.WriteLine(average);
        }

        static double FindAverage(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }

            double average = (double)sum / arr.Length;

            return average;
        }
    }
}