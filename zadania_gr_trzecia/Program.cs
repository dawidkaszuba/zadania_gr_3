using System;
using System.Globalization;

namespace zadania_gr_trzecia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IfCanDonate(45,67,36.6,true,true));
            //Console.WriteLine(IfCanDonate(45,67,37.6,true,true));
            CreateAndFillTheCube();
            //CheckWhichBankDepositIsBetter(3300);
        }
        //---------------------------------------ZADANIE 1-------------------------------------------
        static void CheckWhichBankDepositIsBetter(double monthlyPayment)
        {
            double savings = monthlyPayment * 0.23;

            if (Wariant1(savings) > Wariant2(savings))
            {
                Console.WriteLine("Wariant 1: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant1(savings)));
                Console.WriteLine("Wariant 2: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant2(savings)));
                Console.WriteLine("Oprocentowanie 0.20 w skali roku na 30 miesięcy jest korzystniejsze.");
            }
            else if (Wariant1(savings) < Wariant2(savings))
            {
                Console.WriteLine("Wariant 1: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant1(savings)));
                Console.WriteLine("Wariant 2: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant2(savings)));
                Console.WriteLine("Oprocentowanie 0.35 w skali roku na 36 miesięcy jest korzystniejsze.");
            }
            else
            {
                Console.WriteLine("Wariant 1: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant1(savings)));
                Console.WriteLine("Wariant 2: " + string.Format(new CultureInfo("pl-PL"), "{0:c}", Wariant2(savings)));
                Console.WriteLine("Oba warianty daja tyle samo korzyści.");
            }
        }

        static double Wariant1(double savings)
        {
            int duration = 30;
            double interestRate = 0.0020;
            double deposit = 0.00;

            for (int i = 1; i <= duration; i++)
            {
                deposit += savings + (savings * (interestRate / 12)) + (savings * 0.001) / 12;
            }
            return deposit;
        }

        static double Wariant2(double savings)
        {
            int duration = 36;
            double interestRate = 0.0035;
            double deposit = 0.00;

            for (int i = 1; i <= duration; i++)
            {
               deposit += savings + (savings * (interestRate / 12));
            }
            return deposit;
        }

        //------------------------------------ZADANIE 2----------------------------------------------
        static bool IfCanDonate(int age, int weight, double temp, bool checker1, bool checker2) 
        {
            return IsAgeCorrect(age) && IsWeightCorrect(weight) && IsBodyTempProper(temp) && IsMedicalReviecCorrect(checker1) && IsAbridgedStudyCorrect(checker2);
        }

        static bool IsAgeCorrect(int age)
        {
            return (age >= 18 && age <= 65) ;
        }

        static bool IsWeightCorrect(int weight)
        {
            return (weight >= 50);
        }

        static bool IsBodyTempProper(double temp)
        {
            return temp <= 37.00;
        }

        static bool IsMedicalReviecCorrect(bool checker1)
        {
            return checker1;
        }

        static bool IsAbridgedStudyCorrect(bool checker2)
        {
            return checker2;
        }

        // --------------------------------------ZADANIE 3----------------------------------

        static void CreateAndFillTheCube() 
        {
            int[,,] array1 = new int[3, 3, 3];
            int[,,] array2 = new int[3, 3, 3];
            Random random = new Random();
          

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    for (int k = 0; k < array1.GetLength(2); k++)
                    {
                        array1[i,j,k] = random.Next(1,100);
                    }
                }
            }

            for (int l = 0; l < array2.GetLength(0); l++)
            {
                for (int m = 0; m < array2.GetLength(1); m++)
                {
                    for (int n = 0; n < array2.GetLength(2); n++)
                    {
                        array2[l, m, n] = random.Next(1,100);
                    }
                }
            }
            Console.WriteLine("Elemnty tablicy pierwszej: \n");


            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    for (int k = 0; k < array1.GetLength(2); k++)
                    {
                        Console.Write($"Element: [{i},{j},{k}]: " + array1[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Elemnty tablicy drugiej: \n");

            for (int l = 0; l < array2.GetLength(0); l++)
            {
                for (int m = 0; m < array2.GetLength(1); m++)
                {
                    for (int n = 0; n < array2.GetLength(2); n++)
                    {
                        Console.Write($"Element: [{l},{m},{n}]: " + array1[l, m, n] + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Wynik mnożenie elemntów: [1, 0, 0], [0, 1, 0], [0, 0, 1] tablicy pierwszej to: " + array1[1, 0, 0] * array1[0, 1, 0] * array1[0, 0, 1]);
            Console.WriteLine("Wynik mnożenie elemntów: [1, 0, 0], [0, 1, 0], [0, 0, 1] tablicy drugiej to: " + array2[1, 0, 0] * array2[0, 1, 0] * array2[0, 0, 1]);
        

        }

    }
}
