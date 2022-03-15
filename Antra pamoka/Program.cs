using System;

namespace Antra_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            ////inicializacija
            //int YearOfBirth;
            //string FirstName;

            ////Deklaravimas
            //var LastName = "Pavardenis";
            //decimal salary = 10m; //nurodom "m" gale, kad nurodyt kad ne paprastas skaicius, o decimal. Darbui su pinigais
            //double income = 5000d; //Skaiciams su liekana

            ////Priskirti reiksmes
            //YearOfBirth = 1992;
            //FirstName = "Vardenis";

            //DateTime LastPayDay = new DateTime(2022, 03, 07);// new nurodom kai patys inputinam
            //DateTime LastPayDay2 = DateTime.Today.AddDays(-1);//naudojam toki kai imam jau turima data 

            //Console.WriteLine(($"Vardas: {FirstName}, pavarde {LastName}"));
            //Console.WriteLine("Gimimo metai: {0}, {1}", YearOfBirth, FirstName);
            //Console.WriteLine($"Paskutini karta ismoketa alga {LastPayDay2}");

            // 1 uzduotis------------------------------------------------------------------------------                                 
            //Console.WriteLine("Iveskite pirma skaiciu X");
            //string X = Console.ReadLine();
            //int X1 = int.Parse(X);

            //Console.WriteLine("Iveskite pirma skaiciu Y");
            //string Y = Console.ReadLine();
            //int Y1 = int.Parse(Y);

            //// "\n" padaro tarpa
            //Console.WriteLine($"\n");
            //Console.WriteLine($"PRIES \nSkaicius X yra {X}, skaicius Y yra {Y}");

            //string temp;
            //temp = X;
            //X = Y;
            //Y = temp;

            //Console.WriteLine($"\n");
            //Console.WriteLine($"PO \nSkaicius X yra {X}, Skaicius X yra {Y}");



            //2 uzduotis ---------------------------------------------------------------------------------

            //string SchoolName, CourseName, StudentNumber;
            //DateTime Laikas;

            //string SchoolName = "Code Academy";
            //string CourseName = "CA.NET1";
            //string StudentNumber = "16";
            //DateTime Laikas = DateTime.Now;
            //string DateNowFormatted = DateTime.Now.ToLongDateString();    

            //Console.WriteLine($"Mokyklos pavadinimas: { SchoolName}");
            //Console.WriteLine($"Kurso pavadinimas: {CourseName}");
            //Console.WriteLine($"Sudentu skaicius: {StudentNumber}");
            //Console.WriteLine($"Siandienos data: {DateNowFormatted}");

            //Console.ReadLine();




            //3 uzduotis---------------------------------------------------------------------------------------

            //string SchoolName = "Code Academy";
            //string CourseName = "CA.NET1";
            //string StudentNumber = "16";
            //DateTime Laikas = DateTime.Now;
            //string DateNowFormatted = DateTime.Now.ToLongDateString();
            ////string DateNowFormatted = DateTime.Now.ToLongDateString("MM/dd/yyyy");


            //Console.WriteLine($"Mokyklos pavadinimas: { SchoolName}");
            //Console.WriteLine($"Kurso pavadinimas: {CourseName}");
            //Console.WriteLine($"Sudentu skaicius: {StudentNumber}");
            //Console.WriteLine($"Siandienos data: {DateNowFormatted}");

            //Console.ReadLine();

            //DateTime CourseStartDay = new DateTime(2022, 03, 01);
            //DateTime CourseEndDay = new DateTime(2022, 10, 25);
            //Double TotalDaysDiff = (CourseEndDay - CourseStartDay).TotalDays;
            //double totalWeekDiff = TotalDaysDiff / 7;
            ////double TotalWorkDays = totalWeekDiff * 7 - 3;
            //double TotalWorkDays = TotalDaysDiff - (totalWeekDiff * 3);


            //Console.WriteLine($"Kurso pradzios data: {CourseStartDay}");
            //Console.WriteLine($"Kurso pabaigos data: {CourseEndDay}");
            //Console.WriteLine($"Kurso trukme: {TotalDaysDiff}");
            //Console.WriteLine($"Kurso trukme savaitemis: {totalWeekDiff}");
            //Console.WriteLine($"Kurso trukme be darbo dienu ir savaitgaliu: {TotalWorkDays}");
            //Console.ReadLine();

            //-------LOGINIAI OPRATORIAI---------------------------------
            //bool A1 = false;
            //bool B1 = true;

            //bool A1_OR_B1 = A1 || B1;//>-FALSE
            //bool A1_AND_B1 = A1 && B1;//->FALSE
            //bool A1_NOT = !A1;//->TRUE

            //bool A2 = true;
            //bool B2 = false;

            //bool A2_OR_B2 = A2 || B2;//>-TRUE
            //bool A2_AND_B2 = A2 && B2;//->FALSE
            //bool A2_NOT = !A2;//->FALSE

            //bool A3 = true;
            //bool B3 = true;

            //bool A3_OR_B3 = A3 || B3;//>-TRUE
            //bool A3_AND_B3 = A3 && B3;//->RUE
            //bool A3_NOT = !A3;//->FALSE

            //string userinput = "raudona";
            //string a = "raudona";
            //string b = "juoda";
            //string c = "ruzava";

            //if (userinput == a || userinput == b || userinput == c) ;
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else 
            //{
            //    Console.WriteLine();
            //}


            //4 UZDUOTIS-------------------------------------------------------------
            //Console.WriteLine("Iveskite pirma skaiciu");
            //string input1 = Console.ReadLine();

            //bool isValidNumber = Int32.TryParse(input1, out int number1);


            //if (isValidNumber)
            //{
            //    Console.WriteLine("Iveskite antra skaiciu:");
            //    string input2 = Console.ReadLine();

            //     isValidNumber = Int32.TryParse(input2, out int number2);

            //    if (isValidNumber)
            //    {
            //        bool isEqual = number1 == number2;

            //        Console.WriteLine($"Sie skaiciai: {number1}, {number2} yra {isEqual}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Ivestas blogas inputas");                
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("Ivestas blogas inputas");
            //}

            //-------------------------------------5 UZDUOTIS---------------------------------------
            //bool isValidNumber = false;

            //do
            //{
            //    Console.WriteLine("Iveskite pirma skaiciu: ");
            //    string input1 = Console.ReadLine();

            //    isValidNumber = Int32.TryParse(input1, out int skaicius1);

            //    if (isValidNumber)
            //    {
            //        Console.WriteLine("Iveskite antra skaiciu: ");
            //        string input2 = Console.ReadLine();

            //        isValidNumber = Int32.TryParse(input2, out int skaicius2);

            //        if (isValidNumber)

            //            skaicius1++;
            //            skaicius2--;

            //        Console.WriteLine($"Pakoreguotas pirmas skaicius yra: {skaicius1}");
            //        Console.WriteLine($"Pakoreguotas antras skaicius yra: {skaicius2}");
            //    }
            //} while (isValidNumber);

            ////-------------------------------------5.1 UZDUOTIS---------------------------------------
            //bool isValidNumber = false;

            //do
            //{
            //    Console.WriteLine("Iveskite pirma skaiciu: ");
            //    string input1 = Console.ReadLine();

            //    isValidNumber = Int32.TryParse(input1, out int skaicius1);

            //    if (isValidNumber)
            //    {
            //        Console.WriteLine("Iveskite antra skaiciu: ");
            //        string input2 = Console.ReadLine();

            //        isValidNumber = Int32.TryParse(input2, out int skaicius2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Blogas inputas!");

            //    }
            //    if (isValidNumber)
            //    {

            //        skaicius1++;
            //        skaicius2--;
            //        Console.WriteLine($"Pakoreguotas pirmas skaicius yra: {skaicius1}");
            //        Console.WriteLine($"Pakoreguotas antras skaicius yra: {skaicius2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Blogas inputas!");

            //    }

            //    //else
            //    //{
            //    //    Console.WriteLine("Blogas inputas!");
            //    //}
            //} while (isValidNumber);

            //-----------------------------------5 UZDUOTIS TEISINGA-----------------------------------------
            //bool valid;
            //do
            //{

            //    Console.WriteLine("Ivesti pirma skaiciu: ");

            //    string A1 = Console.ReadLine();
            //    valid = Int32.TryParse(A1, out int number1);


            //    if (valid)
            //    {

            //        Console.WriteLine("Ivesti antra skaicu: ");
            //        string A2 = Console.ReadLine();
            //        valid = Int32.TryParse(A2, out int number2);
            //        if (valid)
            //        {
            //            Console.WriteLine($"{++number1}, {--number2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("bad input");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bad input");
            //    }

            //} while (!valid);
            //-----------------------------------6 UZDUOTIS--------------------------------------------------

            //Console.WriteLine("Iveskite bet koki teksta: ");
            //string input1 = Console.ReadLine();
            //bool isvalid = string.IsNullOrWhiteSpace(input1);
            //if (isvalid)
            //{
            //    Console.WriteLine($"Eilute nera tuscia: {isvalid}");
            //}
            //else
            //{
            //    Console.WriteLine("Bandykite dar karta:");
            //}
            // -------------------------------- 7 UZDUOTIS --------------------------------
            //Console.WriteLine("Iveskite skaiciu:");
            //string input = Console.ReadLine();
            //int num1;
            //double numberDouble;
            //bool isvalidnumber = Int32.TryParse(input, out num1);
            ////bool isValidDouble = double.TryParse(input, out numberDouble);

            ////if (isValidDouble)
            ////{
            ////    Console.WriteLine($"Sis skaicius {numberDouble} yra su kableliu");
            ////}

            //if (isvalidnumber)
            //{
            //    bool arMazesnisUzNuli = num1 < 0;
            //    bool arDidesnisUzNuli = num1 > 0;

            //    if (arMazesnisUzNuli)
            //    {
            //        Console.WriteLine($"Skaicius {num1} yra mazesnis uz nuli. Reiksme yra {arMazesnisUzNuli}");
            //    }
            //    if (arDidesnisUzNuli)
            //    {
            //        Console.WriteLine($"Jo, skaicius {num1} didesnis uz nuli. Reiksme yra {arDidesnisUzNuli}");
            //    }
            //}
            //----------------------------------8 UZDUOTIS--------------------------------

            string vardas = "Vardenis";
            string pavarde = "Pavardenis";
            string inputVardas = "VaRdenis";
            string inputPavarde = "pAVARDENIS";

            //same bool arSutampa = inputVardas == vardas;
            bool arSutampaVardas = string.Equals(inputVardas, vardas,StringComparison.OrdinalIgnoreCase);
            bool arSutampaPavarde = string.Equals(inputPavarde, pavarde,StringComparison.OrdinalIgnoreCase);

            if(arSutampaVardas)
            {
                Console.WriteLine("Vardas sutampa");
            }
            if (arSutampaPavarde)
            {
                Console.WriteLine("Pavarde sutampa");
            }

        }
    }
}
