using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Learning_Stuff
{
    class Program
    {

        static void Main(string[] args)
        {
            Translator tr = new Translator();
            Translator.InitializeDictionary();

            Console.WriteLine(
                "1 = HelloWorld + check if Bob or Alice\n" +
                "2 = Wypisywanie liczb \n" +
                "3 = Tabliczka mnozeni \n" +
                "4 = Liczby Pierwsze \n" +
                "5 = Gra w pytanie \n" +
                "6 = 6 = Dni przestepne \n" +
                "7 = Max int in array \n" +
                "8 = reverse string \n" +
                "9 = element in string \n" +
                "10 = odd elements in array \n" +
                "11 = sum of an array \n" +
                "12 = check Palindrome! \n" +
                "13 = square of numbers! \n" +
                "14 = Alternate strings \n" +
                "15 = Alternate Sorted String \n" +
                "16 = Obrót Stringa \n" +
                "17 = 100 licz fibonacciego \n" +
                "18 = wciąga liczbe i zmienia w array \n" +
                "19 = Hello World in a frame \n" +
                "20 = Tlumacz z morsa na angielski \n" +
                "21 = Pig translator lul \n" +
                "22 = Bubble Sort \n" +
                "23 = Selection Sort \n"
                            );








            Int32.TryParse(Console.ReadLine(), out int funkcja);
            switch (funkcja)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Hello World!");

                    String WhatName;
                    WhatName = ("ss");

                    Console.WriteLine("What's Your name?");
                    WhatName = Console.ReadLine();

                    if ((WhatName == "Bob") || (WhatName == "Alice"))
                    {
                        Console.WriteLine("Hello " + WhatName + "!");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 2:

                    // ------------------------- Wypisywanie 1 + n
                    Console.Clear();
                    Console.WriteLine("Podaj Liczbe");
                    int Secret;

                    Secret = 1;
                    Int32.TryParse(Console.ReadLine(), out Secret);

                    for (int i = 0; i <= Secret; i++)
                    {
                        Console.WriteLine(i + " ");
                        System.Threading.Thread.Sleep(10);
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 3:
                    // ------------------------- tabliczka mnozenia
                    int Koniecmnozenia = 0;
                    int PoczatekMnozenia = 0;
                    Console.Clear();

                    Console.WriteLine("od jakiej liczby chcesz zaczac tabliczke mnozenia?");
                    Int32.TryParse(Console.ReadLine(), out Koniecmnozenia);

                    Console.WriteLine("jak duża chcesz tabliczke mnozenia?");
                    Int32.TryParse(Console.ReadLine(), out PoczatekMnozenia);

                    for (int i = Koniecmnozenia; i <= PoczatekMnozenia; i++)
                    {
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(4);

                        for (int j = Koniecmnozenia; j <= PoczatekMnozenia; j++)
                        {
                            Console.Write((i * j).ToString() + "\t ");
                            System.Threading.Thread.Sleep(4);
                        }
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 4:

                    // ------------------------- Liczby Pierwsze
                    Console.WriteLine();
                    Console.Clear();

                    Console.WriteLine("Podaj Liczbe! \n");
                    int LiczbaPierwsza = 0;
                    
                    Int32.TryParse(Console.ReadLine(), out LiczbaPierwsza);
                    Console.WriteLine("\n to Liczby pierwsze do liczby " + LiczbaPierwsza);

                    for (int counter = 0; counter <= LiczbaPierwsza; counter++)
                    {
                        bool notPrime = false;
                        for (var i = 2; i <= counter; i++)

                        {

                            if (counter % i == 0 && i != counter)
                            {
                                notPrime = true;
                            }
                        }

                        if (notPrime == false)
                        {
                            Console.Write(counter + " ");
                            System.Threading.Thread.Sleep(10);
                        }
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 5:

                    // ----------------------- Gra w Pytanie
                    Console.Clear();
                    Console.WriteLine("Gra w Pytanie!");

                    Random rnd = new Random();
                    int stre;

                    int Liczba = rnd.Next(0, 100);
                    Console.WriteLine("Podaj Liczbe!");

                    for (int i = 0; i < 10; i++)
                    {
                        Int32.TryParse(Console.ReadLine(), out stre);

                        if (stre == Liczba)
                        {
                            Console.WriteLine("Nice");
                            Console.WriteLine("podjales tyle " + i + " prob");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        }

                        if (stre > Liczba)
                        {
                            Console.WriteLine("mniej!");
                        }

                        if (stre < Liczba)
                        {
                            Console.WriteLine("wiecej!");
                        }

                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 6:
                    // --------------- Dni przestepne
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine("Dni przestepne!");

                    int leap;
                    int Year;

                    Int32.TryParse(Console.ReadLine(), out Year);

                    for (int i = 0; i <= 20; i++)
                    {
                        leap = 4 * i;
                        leap += Year;
                        System.Threading.Thread.Sleep(10);
                        Console.WriteLine(leap + " ");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 7:

                    // --------------- Max int in Array
                    Console.Clear();
                    Console.WriteLine();

                    Console.WriteLine("Najwieksza w Array");
                    int[] MaxArrayNumber = new int[12] { 1, 23, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

                    Console.Write(MaxArrayNumber.Max());
                    Console.WriteLine();

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 8:
                    // --------------- Write function that reverses a list, preferably in place.
                    Console.Clear();

                    string InputStringToReverse = "Hej kej Tej Lej";
                    Console.WriteLine("przed zamiana\n" + InputStringToReverse);

                    string resultString = string.Join(" ", InputStringToReverse.Split(' ')
                        .Select(x => new String(x.Reverse().ToArray())));

                    Console.WriteLine("po zamianie\n" + resultString);

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();

                    break;


                // ------------ Element in a string
                case 9:
                    Console.Clear();

                    var ElementinList = new List<string>
                    {
                        "kot",
                        "pies",
                        "cma"
                    };

                    if (ElementinList.Contains("pies"))
                    {
                        Console.WriteLine("dog was found");
                    }

                    if (ElementinList.Contains("CMA", StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("MOTH was found");
                    }

                    Console.WriteLine(ElementinList.Contains("ryba"));

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ---------------- Odd numbers in array
                case 10:
                    Console.Clear();

                    int[] OddNumberInt = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                    for (int i = 1; i <= OddNumberInt.Length; i += 2)
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.Write(OddNumberInt[i] + ", ");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ---------------- Sum of array
                case 11:
                    Console.Clear();

                    int[] SumOfArray = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    Console.WriteLine(SumOfArray.Sum());

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // --------------- Palindrome check
                case 12:
                    Console.Clear();

                    Console.WriteLine("Write to check Palindrome!");

                    String palindrome = Console.ReadLine();
                    Console.WriteLine(palindrome.SequenceEqual(palindrome.Reverse()));

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // -------------- Prime Numbers
                case 13:
                    Console.Clear();

                    Console.WriteLine("check square of number");
                    int prime = 0;

                    Int32.TryParse(Console.ReadLine(), out prime);
                    int[] SquareAnumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, prime };

                    for (int i = 0; i < SquareAnumber.Length; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        SquareAnumber[i] *= SquareAnumber[i];
                        Console.WriteLine(SquareAnumber[i]);
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ------------------ Alternate strings
                case 14:
                    Console.Clear();

                    List<int> ListAlternate = new List<int>()
                    {
                        1,
                        2,
                        3,
                        4,
                        5,
                        6
                    };

                    string[] AlternateLetters = { "a", "b", "c", "d", "e", "f" };

                    for (int i = 0; i < AlternateLetters.Length; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.Write(ListAlternate[i] + ", " + AlternateLetters[i] + ", \n");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // --------- Merge two sorted list
                case 15:
                    Console.Clear();
                    
                    List<int> simultaneousMergeAndSort(List<int> FirstList, List<int> SecondList)
                    {
                        int firstIndex = 0;
                        int secondIndex = 0;

                        int lengthOfList = FirstList.Count() + SecondList.Count();
                        List<int> newList = new List<int>(lengthOfList);

                        while (firstIndex < FirstList.Count() || secondIndex < SecondList.Count())
                        {
                            System.Threading.Thread.Sleep(10);
                            if (firstIndex != FirstList.Count() && secondIndex != SecondList.Count())
                            {
                                if (FirstList[firstIndex] <= SecondList[secondIndex])
                                {
                                    newList.Add(FirstList[firstIndex]);
                                    firstIndex++;
                                }
                                else
                                {
                                    newList.Add(SecondList[secondIndex]);
                                    secondIndex++;
                                }
                            }
                            else if (secondIndex == SecondList.Count())
                            {
                                newList.Add(FirstList[firstIndex]);
                                firstIndex++;
                            }
                            else
                            {
                                newList.Add(SecondList[secondIndex]);
                                secondIndex++;
                            }
                        }

                        return newList;
                    }

                    List<int> first = new List<int>() { 1, 4, 6, 8, 10 };
                    List<int> second = new List<int>() { 2, 3, 5, 7, 9 };

                    foreach (var num in simultaneousMergeAndSort(first, second))
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.Write(num + ", "); // { 1, 2, 3, 4, 5, 6 }
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;

                // --------------- Zamiana kolejnosci w array
                case 16:
                    Console.Clear();

                    void printArray(int[] Arraytest, int size)
                    {
                        for (int i = 0; i < size; i++)
                            Console.Write(Arraytest[i] + " ");

                        System.Threading.Thread.Sleep(10);
                    }

                    void leftRotate(int[] Arraytest, int d,
                                                 int n)
                    {
                        for (int i = 0; i < d; i++)
                            leftRotatebyOne(Arraytest, n);
                    }

                    void leftRotatebyOne(int[] Arraytest, int n)
                    {
                        int i, TempArray = Arraytest[0];
                        for (i = 0; i < n - 1; i++)
                            Arraytest[i] = Arraytest[i + 1];

                        Arraytest[i] = TempArray;
                    }

                    Console.WriteLine("How much do you want to rotate?");
                    int Rotationint = 0;

                    Int32.TryParse(Console.ReadLine(), out Rotationint);
                    int[] RotateArray = { 1, 2, 3, 4, 5, 6, 7 };

                    leftRotate(RotateArray, Rotationint, 7);
                    printArray(RotateArray, 7);

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ----------- Liczba fibonacciego
                case 17:
                    Console.Clear();

                    Int64 FibonnaciPierwsza = 0;
                    Int64 FibonacciDruga = 1;

                    Console.WriteLine("Ile chcesz Liczb fibonacciego?");
                    int KtoraliczbaFib = 0;

                    Int32.TryParse(Console.ReadLine(), out KtoraliczbaFib);
                    for (int i = 0; i <= KtoraliczbaFib; i++)
                    {
                        Int64 FibTemporary = FibonnaciPierwsza;
                        FibonnaciPierwsza = FibonacciDruga;
                        FibonacciDruga = FibTemporary + FibonacciDruga;

                        Console.WriteLine("Liczba numer" + i + " " + FibTemporary);
                        System.Threading.Thread.Sleep(100);
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ---------- Nuymbekri w liste
                case 18:
                    Console.Clear();

                    List<double> numberToList(string num)
                    {
                        List<double> newList = new List<double>();
                        char[] tempArr;

                        tempArr = num.ToCharArray();
                        foreach (var value in tempArr)
                        {
                            double digit = char.GetNumericValue(value);
                            System.Threading.Thread.Sleep(10);

                            newList.Add(digit);
                        }
                        return newList;
                    }

                    Console.WriteLine("Podaj Liczbe do zmiany na produkt");
                    string liczbad = Console.ReadLine();

                    foreach (var value in numberToList(liczbad))
                    {
                        Console.Write(value + ", ");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ----------- Hello World in a frame
                case 19:
                    Console.Clear();

                    List<string> framing = new List<string>()
                    {
                        "Hello",
                        "world",
                        "in",
                        "a",
                        "frame"
                    };

                    for (int i = 0; i <= framing.Count; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.Write("**");
                    }

                    Console.WriteLine();

                    foreach (string value in framing)
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.WriteLine("* " + value + "\t   *");
                    }

                    for (int i = 0; i <= framing.Count; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Console.Write("**");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                // ---------------------- sum stuff to get result
                case 20:
                    Console.Clear();

                    Console.WriteLine("What did you want to say?");
                    string userInput = Translator.GetUserInput();
                    Console.WriteLine("Morse alphabet output is: " + Translator.Translate(userInput));

                    Console.WriteLine("[Press ANY KEY to exit]");
                    Console.ReadLine();

                    break;

                    // ------------------------ Pig lating translator
                case 21:
                    Console.Clear();

                    string[] english1 = new string[4] { "hey", "look", "now", "shrek" };

                    for (int i = 0; i < english1.Length; i++)
                    {
                        String output = String.Join(" ", english1[i].Split(' '));
                        char[] test = new char[4] { ' ', ' ', ' ', ' ' };
                        foreach(char s in output)
                        {
                            test[i] = output[0];
                        }
                        Console.Write((english1[i].Trim(test[i]))  + output[0] + "ay ");

                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;

                // ---------------- Bubble  sort
                case 22:
                    Console.Clear();

                    int[] bblarr = { 800, 11, 50, 771, 649, 770, 240, 9 };
                    Console.Write("input == 800, 11, 50, 771, 649, 770, 240, 9 ");
                    int temp = 0;
                    Console.WriteLine();
                    for (int i = 0; i < bblarr.Length; i++)
                    {

                        for (int srt = 0; srt < bblarr.Length - 1; srt++)
                        {

                            if (bblarr[srt] > bblarr[srt + 1])
                            {
                                temp = bblarr[srt + 1];

                                bblarr[srt + 1] = bblarr[srt];
                                bblarr[srt] = temp;
                            }
                        }
                    }
                        Console.Write("output == ");
                    for (int i = 0; i < bblarr.Length; i++)
                        
                        Console.Write(bblarr[i] + " ");

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;

                    // --------- Selection sort
                case 23:
                    Console.Clear();

                    int[] selsort = { 5, 3, 7, 2, 21, 713, 43170, 134, 754, 865 };
                    Console.Write("input == 5, 3, 7, 2, 21, 713, 43170, 134, 754, 865");
                    Console.WriteLine();
                    int SelSortLength = selsort.Length;

                    for (int i = 0; i < SelSortLength; i++)
                    {
                        int min_index = i;

                        for (int y = i; y < SelSortLength; y++)
                        {

                            if (selsort[min_index] > selsort[y])
                            {
                                min_index = y;
                            }
                        }

                        int seltemp = selsort[i];

                        selsort[i] = selsort[min_index];
                        selsort[min_index] = seltemp;
                    }

                    Console.WriteLine("Sort array in ascending order by using Selection Sort");
                    Console.Write("output == ");
                    foreach (int i in selsort)
                    {
                        Console.Write(i + ", ");
                    }

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;


                case 24:
                    Console.Clear();

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }   
        }
    }
}

