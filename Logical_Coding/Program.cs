using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logical_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
            // 1. Reverse a string
            string name = "senaka";

            char[] charArray = name.ToCharArray();

            for(int i = charArray.Length, j=0; i > 0; i--,j++)
            {
                charArray[j] = name[i-1];
            }

            Console.WriteLine(new string(charArray));

            //2. How to find if the given string is a palindrome or not

            string phrase1 = "madam"; //"step on no pets"

            char[] charArray1 = phrase1.ToCharArray();

            for (int i = charArray1.Length, j = 0; i > 0; i--, j++)
            {
                charArray1[j] = phrase1[i - 1];
            }

            string reversePhrase = new string(charArray1);

            Console.WriteLine((phrase1.Equals(reversePhrase))? "Palindrome" : "Not Palindrome");

            //3. Reverse a order of words in string

            string word = "Welcome To C# Corner";

            string[] mywords = word.Split(" ");

            string[] finalSentence = new string[mywords.Length];

            for(int i = mywords.Length, j=0; i > 0; j++, i --)
            {
                finalSentence[j] = mywords[i - 1];
            }

            //Console.WriteLine(string.Concat(finalSentence));
            Console.WriteLine(string.Join(" ", finalSentence));

            //4. Reverse each word in given string

            string orginalString = "Welcome To My Forest";

            string[] orgStringArray = orginalString.Split(" ");
            string[] reverseStringArray = new string[orgStringArray.Length];

            for (int i = orgStringArray.Length, j=0; i > 0; i--, j++)
            {
                char[] charArray2 = orgStringArray[i-1].ToCharArray();
                char[] newArray = new char[charArray2.Length];

                int length = charArray2.Length;
                int k = 0;

                while(length > 0)
                {
                    newArray[length-1] = charArray2[k];
                    k++;
                    length--;
                }

                reverseStringArray[j] = new string(newArray);
            }

            Console.WriteLine(string.Join(" ", reverseStringArray));

            //5.Count the occurence in each string

            string wordToCount = "Hello World";

            Dictionary<char, int> countDic = new Dictionary<char, int>();

            char[] myCharArray = wordToCount.Replace(" ", "").ToCharArray();

            for(int i=0; i < myCharArray.Length; i++)
            {
               
                if(countDic.ContainsKey(myCharArray[i]))
                {
                    countDic[myCharArray[i]]++;
                }
                else
                {
                    countDic.Add(myCharArray[i], 1);
                }
            }

            foreach(KeyValuePair<char, int> pair in countDic)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            //6. remove duplicate characters in a given word

            string dupStringWork = "hello";

            //char[] charArray3 = dupStringWork.ToCharArray();
            List<char> myArray = new List<char>();

            for(int i = 0; i < dupStringWork.Length; i ++)
            {
                if(!myArray.Contains(dupStringWork[i]))
                {
                    myArray.Add(dupStringWork[i]);
                }
            }

            Console.WriteLine(string.Concat(myArray));


            //7. How to find possible substring of a given string

            string subString = "abcd";
            char[] charAr = subString.ToCharArray();          

            for (int i = 0; i < charAr.Length; i ++)
            {              
                StringBuilder builder = new StringBuilder(charAr.Length - i);

                for (int j = i; j < charAr.Length; j++)
                {
                    builder.Append(charAr[j]);
                    Console.WriteLine(builder.ToString());
                }
            }

            //8. Left circular rotation of an array 2 3 4 5 6 1

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int temp;          

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i-1];
                array[i - 1] = array[i];
                array[i] = temp;
            }

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //9. Right circular rotation of an array 6 1 2 3 4 5

            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int temp1;

            for (int i = 0; i < array1.Length; i++)
            {
                temp1 = array1[array1.Length - 1];
                array1[array1.Length - 1] = array1[i];
                array1[i] = temp1;
            }

            foreach (int i in array1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            int[] atr = new int[] { 1, 2, 3, 4, 5 };
            int temp2;

            for(int i = 0; i < atr.Length -1; i ++)
            {
                temp2 = atr[i];
                atr[i] = atr[i + 1];
                atr[i + 1] = temp2;
            }

            foreach (int i in atr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[] atr1 = new int[] { 1, 2, 3, 4, 5 };
            int temp3;

            for (int i = atr1.Length - 1; i > 0; i--)
            {
                temp3 = atr1[i];
                atr1[i] = atr1[i - 1];
                atr1[i - 1] = temp3;
            }

            foreach (int i in atr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //10. find positive number is a prime number or not

            int primeNumber = 11;
            bool isPrime = true;

            if (primeNumber == 1) isPrime = false;
            if (primeNumber == 2) isPrime = true;
            else
            {
                for (int i = 2; i < primeNumber; i++)
                {
                    if (primeNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime);

            // 11. Sum of digits of positive integer

            int sumNumber = 169;
            int sum = 0;

            while (sumNumber > 0)
            {
                sum += sumNumber % 10;
                sumNumber /= 10;
            }

            Console.WriteLine(sum);

            //12.find the second larget in array

            int[] largestArray = { 3, 5, 8, 2, 1, 9, 9 , 8 };

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach(int i in largestArray)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if ( i > max2 && i != max1  )
                {
                    max2 = i;
                }
            }

            Console.WriteLine( $"{ max1 } { max2 }" );

            // 13. find the third largest

            int[] largestArray1 = { 3, 5, 8, 2, 1, 9, 9, 8 };

            int max11 = int.MinValue;
            int max21 = int.MinValue;
            int max31 = int.MinValue;

            foreach (int i in largestArray1)
            {
                if (i > max11)
                {
                    max31 = max21;
                    max21 = max11;
                    max11 = i;
                }
                else if (i > max21 && i != max11)
                {
                    max31 = max21;
                    max21 = i;
                }

                else if( i > max31 && i != max11 && i != max21){
                    max31 = i;
                }
            }

            Console.WriteLine($"{ max11 } { max21 } { max31 }");

            //14.convert 2 dimensional to one dimensional

            int[,] twoDimArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9} };
            int index = 0;
            int width = twoDimArray.GetLength(0);
            int height = twoDimArray.GetLength(1);

            int[] single = new int[width * height];

            for(int i = 0; i < width; i ++)
            {
                for(int j=0; j < height; j++)
                {
                    single[index] = twoDimArray[i,j];
                    index++;
                }
            }
         
            foreach(int i in single)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //15. Convert one dimensional array to two

            int row = 2;
            int coloumn = 3;

            int[] singleArray = new int[] { 1, 2, 3, 4, 5, 6 };            

            int[,] twoDArray = new int[row,coloumn];
            int index1 = 0;

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < coloumn; j++ )
                {
                    twoDArray[i, j] = singleArray[index1];
                    index1++;
                    Console.Write(twoDArray[i, j]);
                }                
            }

            Console.WriteLine();

            //16. angle of clock and minute

            double hours = 10;
            double mins = 5;

            double hoursDegree = (hours * 30) + (30 * mins / 60);

            double minsDegree = mins * 6;

            double diff = Math.Abs(hoursDegree - minsDegree);

            if(diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine(diff);

            //17. Tower of Hanoi

            int[] TowerOne = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] TowerTwo = new int[TowerOne.Length -2];
            int[] TowerThree = new int[TowerTwo.Length];
            int index11 = 0;
            //1st swap
            for(int i = 0; i < TowerOne.Length -1; i++)
            {
                if(i == TowerOne.Length-2)
                {
                    TowerTwo[0] = TowerOne[i];
                }
                else
                {
                    TowerThree[index11] = TowerOne[i];
                    index11++;
                }
            }

            //2nd swap

        }
    }

}




