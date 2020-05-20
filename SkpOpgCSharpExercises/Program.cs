using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SkpOpgCSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise01();
            // Exercise02(5.5,7.25);
            // Exercise03(10, 5);
            // Exercise04();
            // Exercise05(5, 6);
            // Exercise06();
            // Exercise07();
            // Exercise08(5);
            // Exercise09();
            // Exercise10(5,6,7);
            // Exercise11();
            // Exercise12(25);
            // Exercise13(5);
            // Exercise14();
            // Exercise15("w3resource", 3);
            // Exercise16("w3resource");
            // Exercise17("The quick brown fox jumps over the lazy dog.);
            // Console.WriteLine(Exercise18(-2,5));
            // Console.WriteLine(Exercise19(8,8));
            // Console.WriteLine(Exercise20(5, 7));
            // Console.WriteLine(Exercise21(10, 10));
            // Console.WriteLine(Exercise22(85));
            // Exercise23("BENNY BENTE");
            // Exercise24("Write a C# Sharp Program to display the following pattern using the alphabet");
            // Exercise25();
            // Exercise26();
            // Exercise27(1234);
            // Exercise28("Display the pattern like pyramid using the alphabet.");
            // Exercise29();
            //Exercise30("82F");
            //Exercise31(new int[] {1, 3, -5, 4}, new int[] {1, 4, -5, -2});
            //Exercise32("The quick brown fox jumps over the lazy dog.");
            //Console.WriteLine(Exercise33(15));
            //Console.WriteLine(Exercise34("Hello", "Hello how are you?"));
            //Exercise35(75, 250);
            //Exercise36(-5, 8);
            //Exercise37("PHP Tutorial");
            //Exercise38("PHP");
            //Exercise39(15, 25, 30);
            //Exercise40(15, 12);
            //Exercise41("w3resource");
            //Exercise42("W3RESOURCE");
            //Console.WriteLine(Exercise43("wwww"));
            //Exercise44("w3resource");
            //Exercise45(new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 }, 5);
            //Console.WriteLine(Exercise46(new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 25 }, 25));
            //Exercise47(new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 });
            //Console.WriteLine(Exercise48(new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 }));
            //Console.WriteLine(Exercise49(new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 }, new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 }));
            //Exercise50(new int[] { 1, 2, 8 });
            //Exercise51(new int[] { 1, 2, 5, 7, 8 });
            //Exercise52(new int[] { 1, 2, 5 }, new int[] { 0, 3, 8 }, new int[] { -1, 0, 2 });
            //Console.WriteLine(Exercise53(new int[] { 2, 4, 5, 8, 6 }));
            //Exercise54(1799);
            //Exercise55(new int[] { 2, 4, 2, 6, 9, 3 }, 27);
            //Console.WriteLine(Exercise56("ibofobi"));
            //Exercise57(new int[] { 1, -3, 4, -5, 1 });
            //Exercise58(new int[] { 1, 3, 4, 7, 9, 13, 14, 20});
            //Console.WriteLine(Exercise59(new int[] { 1, 7, 4, 8, 9 }));
            //Exercise60(new int[][] { new int[] {0, 2, 3, 2}, new int[] {0, 6, 0, 1}, new int[] {4, 0, 3, 0} });
            //Exercise61(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
            //Exercise62("ab(cd(ef)gh)ij");
            Console.ReadLine();
        }
        static void Exercise62(string a)
        {
            bool FirstIndexParenthesis = false;
            int ParenthesisCounter = 0;
            string Newa = "";
            char[] aCharArr = a.ToCharArray();
            for (int i = 0; i < aCharArr.Length; i++)
            {
                if (i == 0 && aCharArr[i] == '(')
                {
                    FirstIndexParenthesis = true;
                    ParenthesisCounter++;
                }
                else if (aCharArr[i] == '(' || aCharArr[i] == ')')
                {
                    ParenthesisCounter++;
                }
            }
            for (int i = 0; i < aCharArr.Length; i++)
            {
                if (aCharArr[i] == '(' || aCharArr[i] == ')')
                {
                    aCharArr[i] = ' ';
                }
            }
            for (int i = 0; i < aCharArr.Length; i++)
            {
                Newa += aCharArr[i];
            }
            Newa = Newa.Trim();
            string[] aArray = Newa.Split(' ');
            if (ParenthesisCounter == 2)
            {
                string SegmentToChange = aArray[(aArray.Length - 1) / 2];
                string NewSegment = "";
                for (int i = SegmentToChange.Length - 1; i >= 0; i--)
                {
                    NewSegment += SegmentToChange[i];
                }
                aArray[(aArray.Length - 1) / 2] = NewSegment;
                string NewString = "";
                for (int i = 0; i < aArray.Length; i++)
                {
                    NewString += aArray[i];
                }
                Console.WriteLine(NewString);
            }
            else
            {
                string First = aArray[0];
                string Last = aArray[aArray.Length - 1];
                string[] reversedaArray = new string[aArray.Length];
                int ReverseArrayCounter = 0;
                for (int i = aArray.Length - 1; i >= 0; i--)
                {
                    reversedaArray[ReverseArrayCounter] = aArray[i];
                    ReverseArrayCounter++;
                }
                for (int i = 0; i < reversedaArray.Length; i++)
                {
                    if (i != (reversedaArray.Length - 1) / 2)
                    {
                        char[] CurrIndex = reversedaArray[i].ToCharArray();
                        string CurrIndexReversed = "";
                        for (int j = CurrIndex.Length - 1; j >= 0; j--)
                        {
                            CurrIndexReversed += CurrIndex[j];
                        }
                        reversedaArray[i] = CurrIndexReversed;
                    }
                }
                if (FirstIndexParenthesis == false)
                {
                    reversedaArray[0] = First;
                    reversedaArray[reversedaArray.Length - 1] = Last;
                }
                string NewString = "";
                for (int i = 0; i < reversedaArray.Length; i++)
                {
                    NewString += reversedaArray[i];
                }
                Console.WriteLine(NewString);
            }
        }
        static void Exercise61(int[] numberArr)
        {
            for (int i = 0; i < numberArr.Length; i++)
            {
                for (int j = i; j < numberArr.Length; j++)
                {
                    if (numberArr[i] != -5 && numberArr[j] != -5 && numberArr[j] < numberArr[i])
                    {
                        int temp = numberArr[i];
                        numberArr[i] = numberArr[j];
                        numberArr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < numberArr.Length; i++)
            {
                Console.WriteLine(numberArr[i]);
            }
        }
        static void Exercise60(int[][] intMatrix)
        {
            int summarizer = 0;
            for (int i = 0; i < intMatrix.Length; i++)
            {
                if (i > 0)
                {
                    for (int j = 0; j < intMatrix[i].Length; j++)
                    {
                        if (intMatrix[i - 1][j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            summarizer += intMatrix[i][j];
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < intMatrix[i].Length; j++)
                    {
                        summarizer += intMatrix[i][j];
                    }
                }
            }
            Console.WriteLine(summarizer);
        }
        static bool Exercise59(int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                for (int j = 1 + i; j < numbersArr.Length; j++)
                {
                    if (numbersArr[i] == numbersArr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Exercise58(int[] numbersArr)
        {
            int potentialLargest = numbersArr[0];
            int potentialLowest = numbersArr[0];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] > potentialLargest)
                {
                    potentialLargest = numbersArr[i];
                }
                if (numbersArr[i] < potentialLowest)
                {
                    potentialLowest = numbersArr[i];
                }
            }
            int intervalDiff = potentialLargest - potentialLowest;
            int missingNumbers = intervalDiff - numbersArr.Length + 1;
            Console.WriteLine(missingNumbers);
        }
        static void Exercise57(int[] numbersArr)
        {
            int largestProduct = numbersArr[0] * numbersArr[1];
            for (int i = 0; i < numbersArr.Length - 1; i++)
            {
                if (numbersArr[i] * numbersArr[i + 1] > largestProduct)
                {
                    largestProduct = numbersArr[i] * numbersArr[i + 1];
                }
            }
            Console.WriteLine(largestProduct);
        }
        static bool Exercise56(string potentialPalindrome)
        {
            for (int i = 0; i < potentialPalindrome.Length / 2; i++)
            {
                if (potentialPalindrome[i] != potentialPalindrome[potentialPalindrome.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Exercise55(int[] numbersArr, int number)
        {

            int potentialLargestProduct = numbersArr[0] * numbersArr[1];
            for (int i = 0; i < numbersArr.Length - 1; i++)
            {
                if (numbersArr[i] * numbersArr[i + 1] > potentialLargestProduct)
                {
                    potentialLargestProduct = numbersArr[i] * numbersArr[i + 1];
                }
            }
            Console.WriteLine(potentialLargestProduct == number);
        }
        static void Exercise54(int year)
        {
            int century = 0;
            if (year > 100)
            {
                if (year % 100 == 0)
                {
                    century = year / 100;
                }
                else
                {
                    century = (year / 100) + 1;
                }
            }
            else
            {
                if (year == 0)
                {
                    century = 0;
                }
                else
                {
                    century = 1;
                }
            }
            Console.WriteLine(century);
        }
        static bool Exercise53(int[] numberArr)
        {
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Exercise52(int[] numArr01, int[] numArr02, int[] numArr03)
        {
            if (numArr01.Length == numArr02.Length && numArr02.Length == numArr03.Length)
            {
                int[][] numArrs = { numArr01, numArr02, numArr03 };
                int[] newNumArr = new int[numArr01.Length];
                for (int i = 0; i < numArrs.Length; i++)
                {
                    newNumArr[i] = numArrs[i][(numArrs[i].Length - 1) / 2];
                }
                for (int i = 0; i < newNumArr.Length; i++)
                {
                    Console.Write(newNumArr[i] + " ");
                }
            }

        }
        static void Exercise51(int[] numberArr)
        {
            if (numberArr[0] > numberArr[numberArr.Length - 1])
            {
                Console.WriteLine(numberArr[0]);
            }
            else if (numberArr[0] < numberArr[numberArr.Length - 1])
            {
                Console.WriteLine(numberArr[numberArr.Length - 1]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        static void Exercise50(int[] numberArr)
        {
            int[] rotatedNumberArr = new int[numberArr.Length];
            for (int i = 0; i < numberArr.Length - 1; i++)
            {
                rotatedNumberArr[i] = numberArr[i + 1];
            }
            rotatedNumberArr[rotatedNumberArr.Length - 1] = numberArr[0];
            for (int i = 0; i < numberArr.Length; i++)
            {
                Console.Write(rotatedNumberArr[i] + " ");
            }
        }
        static bool Exercise49(int[] numberArr01, int[] numberArr02)
        {
            if (numberArr01.Length > 1 && numberArr02.Length > 1)
            {
                return numberArr01[0] == numberArr02[0] || numberArr01[numberArr01.Length - 1] == numberArr02[numberArr02.Length - 1];
            }
            else
            {
                return false;
            }
        }
        static bool Exercise48(int[] numberArr)
        {
            return numberArr[0] == numberArr[numberArr.Length - 1];
        }
        static void Exercise47(int[] numberArr)
        {
            int summer = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                summer += numberArr[i];
            }
            Console.WriteLine(summer);
        }
        static bool Exercise46(int[] numberArr, int number)
        {
            if (numberArr[0] == number || numberArr[numberArr.Length - 1] == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Exercise45(int[] numberArr, int number)
        {
            int counter = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] == number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Exercise44(string word)
        {
            string concatContainer = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    concatContainer += word[i];
                }
            }
            Console.WriteLine(concatContainer);
        }
        static bool Exercise43(string word)
        {
            if (word.Length >= 5)
            {
                if (word.Substring(0, 1) == "w")
                {
                    if (word.Substring(1, 2) == "ww" && word.Substring(3, 2) == "ww")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Exercise42(string word)
        {
            if (word.Length >= 4)
            {
                string firstFour = word.Substring(0, 4).ToLower();
                word = word.Remove(0, 4);
                word = firstFour + word;
                Console.WriteLine(word);
            }
            else
            {
                word = word.ToUpper();
                Console.WriteLine(word);
            }
        }
        static void Exercise41(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[counter] == 'w')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter > 0);
        }
        static void Exercise40(int firstInt, int secondInt)
        {
            if (firstInt == secondInt)
            {
                Console.WriteLine(0);
            }
            else if (Math.Abs(20 - firstInt) < Math.Abs(20 - secondInt))
            {
                Console.WriteLine(firstInt);
            }
            else
            {
                Console.WriteLine(secondInt);
            }
        }
        static void Exercise39(int firstInt, int secondInt, int thirdInt)
        {
            int[] intArray = { firstInt, secondInt, thirdInt };
            int potentialLargest = intArray[0];
            int potentialSmallest = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (potentialLargest > intArray[i])
                {
                    potentialLargest = intArray[i];
                }

                if (potentialSmallest < intArray[i])
                {
                    potentialSmallest = intArray[i];
                }
            }
            Console.WriteLine(potentialLargest);
            Console.WriteLine(potentialSmallest);
        }
        static void Exercise38(string word)
        {
            string newWord = string.Empty;
            if (word.Substring(0, 2) == "PH")
            {
                newWord = word.Substring(0, 2);
            }
            Console.WriteLine(newWord);
        }
        static void Exercise37(string word)
        {
            string newWord = string.Empty;
            if (word.Substring(1, 2) == "HP")
            {
                newWord = word.Remove(1, 2);
            }
            Console.WriteLine(newWord);
        }
        static void Exercise36(int firstInt, int secondInt)
        {
            Console.WriteLine((firstInt >= -10 && firstInt <= 10) || (secondInt >= -10 && secondInt <= 10));
        }
        static void Exercise35(int firstInt, int secondInt)
        {
            Console.WriteLine(firstInt < 100 && secondInt > 200);
        }
        static bool Exercise34(string word, string sentence)
        {
            string[] words = sentence.Split(' ');
            if (word == words[0])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool Exercise33(int inNumber)
        {
            if (inNumber % 5 == 0 || inNumber % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Exercise32(string sentence)
        {
            string lastFourChars = sentence.Substring(sentence.Length - 4, 4);
            Console.WriteLine(lastFourChars + lastFourChars + lastFourChars + lastFourChars);
        }
        static void Exercise31(int[] numbers01, int[] numbers02)
        {
            if (numbers01.Length == numbers02.Length)
            {
                for (int i = 0; i < numbers01.Length; i++)
                {
                    Console.WriteLine(numbers01[i] * numbers02[i]);
                }
            }
            else
            {
                Console.WriteLine("Længden på de to arrays skal være ens.");
            }

        }
        static void Exercise30(string hexaNumber)
        {
            int hexaSummarizer = 0;
            char[] hexaNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] integers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            for (int i = hexaNumber.Length - 1; i >= 0; i--)
            {
                int counter = 0;
                int tempPlaceValueMulti = 1;
                while (counter < i)
                {
                    if (i == 0)
                    {
                        tempPlaceValueMulti = 1;
                    }
                    else
                    {
                        tempPlaceValueMulti *= 16;
                    }
                    counter++;
                }
                for (int j = 0; j < hexaNumbers.Length; j++)
                {
                    if (hexaNumbers[j] == hexaNumber[hexaNumber.Length - 1 - i])
                    {
                        hexaSummarizer += integers[j] * tempPlaceValueMulti;
                    }
                }
            }
            Console.WriteLine(hexaSummarizer);
        }
        static void Exercise29()
        {
            FileInfo file = new FileInfo("C:/eksempelfil.txt");
            Console.WriteLine(file.Length.ToString());
        }
        static void Exercise28(string sentence)
        {
            string[] individualWords = sentence.Split(' ');
            string sentenceReversed = string.Empty;
            for (int i = individualWords.Length - 1; i >= 0; i--)
            {
                sentenceReversed += individualWords[i] + " ";
            }
            Console.WriteLine(sentenceReversed);
        }
        static void Exercise27(int inInt)
        {
            int summer = 0;
            string tempContainer = string.Empty;
            string intString = inInt.ToString();
            for (int i = 0; i < intString.Length; i++)
            {
                if (i < intString.Length - 1)
                {
                    tempContainer += intString[i] + " ";
                }
                else
                {
                    tempContainer += intString[i];
                }
            }
            string[] numberStrings = tempContainer.Split(' ');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                summer += int.Parse(numberStrings[i]);
            }
            Console.WriteLine(summer);
        }
        static void Exercise26()
        {
            List<int> primes = new List<int>();
            int potentialPrime = 2;
            primes.Add(potentialPrime);
            int primeSum = potentialPrime;
            int primeCounter = 0;
            while (primeCounter < 499)
            {
                potentialPrime++;
                for (int i = 0; i < primes.Count; i++)
                {
                    if (potentialPrime % primes[i] == 0)
                    {
                        break;
                    }
                    if (i == primes.Count - 1)
                    {
                        primes.Add(potentialPrime);
                        primeSum += potentialPrime;
                        primeCounter++;
                    }
                }
            }
            Console.WriteLine(primeSum);
        }
        static void Exercise25()
        {
            int topValue = 100;
            int counter = 1;
            while (counter < topValue)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
        static void Exercise24(string sentence)
        {
            string[] words = sentence.Split(' ');
            string potentialLongest = string.Empty;
            foreach (string word in words)
            {
                if (word.Length > potentialLongest.Length)
                {
                    potentialLongest = word;
                }
            }
            Console.WriteLine(potentialLongest);
        }
        static void Exercise23(string sentence)
        {
            string newSentence = string.Empty;
            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    char tempChar = char.ToLower(letter);
                    newSentence += tempChar;
                }
                else
                {
                    newSentence += letter;
                }
            }
            Console.WriteLine(newSentence);
        }
        static bool Exercise22(int inInt)
        {
            if ((inInt >= 80 && inInt <= 120) || (inInt >= 180 && inInt <= 220))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Exercise21(int firstInt, int secondInt)
        {
            if ((firstInt == 20 || secondInt == 20) || (firstInt + secondInt == 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Exercise20(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return 2 * (firstInt - secondInt);
            }
            else
            {
                return -1 * (firstInt - secondInt);
            }
        }
        static int Exercise19(int firstInt, int secondInt)
        {
            if (firstInt == secondInt)
            {
                return 3 * (firstInt + secondInt);
            }
            else
            {
                return firstInt + secondInt;
            }
        }
        static bool Exercise18(int firstInt, int secondInt)
        {
            if (firstInt > 0 && secondInt < 0 || firstInt < 0 && secondInt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Exercise17(string word)
        {
            string firstChar = word.Substring(0, 1);
            Console.WriteLine(firstChar + word + firstChar);
        }
        static void Exercise16(string word)
        {
            string firstChar = word.Substring(0, 1);
            string between = word.Substring(1, word.Length - 2);
            string secondChar = word.Substring(word.Length - 1, 1);
            Console.WriteLine(secondChar + between + firstChar);
        }
        static void Exercise15(string word, int position)
        {
            Console.WriteLine(word.Remove(position - 1, 1));
        }
        static void Exercise14()
        {
            Console.WriteLine("Enter the amount of celsius:");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Fahrenheit:" + (celsius * 9 / 5 + 32).ToString());
            Console.WriteLine("Kelvin:" + (celsius + (decimal)273.15).ToString());
        }
        static void Exercise13(int a)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i > 0 && i < 4)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("{0}", a);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("{0}", a);
                    }
                }
                Console.Write('\n');
            }
        }
        static void Exercise12(int a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0} ", a);
                    }
                    else
                    {
                        Console.Write("{0}", a);
                    }
                }
                Console.Write('\n');
            }
        }
        static void Exercise11()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Look look exactly like a " + age.ToString() + " year old");
        }
        static void Exercise10(int a, int b, int c)
        {
            Console.WriteLine("(" + a.ToString() + "+" + b.ToString() + ")" + "*" + c.ToString() + "=" + ((a + b) * c).ToString() + " " + a.ToString() + "*" + b.ToString() + "+" + b.ToString() + "*" + c.ToString() + "=" + ((a * b) + (b * c)).ToString());
        }
        static void Exercise09()
        {
            double number = 0;
            const double divisor = 4;
            int counter = 0;
            while (counter < divisor)
            {
                number += Convert.ToDouble(Console.ReadLine());
                counter++;
            }
            Console.WriteLine((number / divisor).ToString());
        }
        static void Exercise08(int inNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(inNumber.ToString() + " * " + i.ToString() + " = " + (inNumber * i).ToString());
            }
        }
        static void Exercise07()
        {
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine(firstNumber % secondNumber);
        }
        static void Exercise06()
        {
            int counter = 0;
            double product = 1;
            List<double> numbers = new List<double>();
            while (counter < 3)
            {
                numbers.Add(Convert.ToDouble(Console.ReadLine()));
                counter++;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }
        static void Exercise05(double first, double second)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
            double container = first;
            first = second;
            second = container;
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        static void Exercise04()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        static void Exercise03(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void Exercise02(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Exercise01()
        {
            System.Console.WriteLine("Hello");
            System.Console.WriteLine("World");
        }
    }
}
