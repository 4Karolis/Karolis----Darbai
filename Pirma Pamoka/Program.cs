using System;

namespace Pirma_Pamoka
{
    class Program
    {
        static void Main(string[] args)
        {

            //paverst inputa mazosiom:
            //apacioj esantys kodai vienoda reiksmes turi kai naudoji string'a
            //Komertaras dedasi su // arba CTRL+ K + C
            //Atkomentuoja CTRL + K + U 

            //string vardas = "";
            //string pavarde = "";

            //while (vardas != "stop")
            //{
            //    Console.WriteLine("Iveskite savo varda:");
            //    vardas = Console.ReadLine();

            //    vardas = vardas.ToLower();

            //    Console.WriteLine("Iveskite savo pavarde:");
            //    pavarde = Console.ReadLine();

            //    Console.WriteLine($"Sveiki {vardas} {pavarde} Noredami testi spuaskite ENTER");
            //    Console.WriteLine("Sveiki {0}, {1} Noredami testi spuaskite ENTER", vardas, pavarde);
            //    Console.WriteLine("Sveiki " + vardas + " Noredami testi spuaskite ENTER");

            //}
            //Console.Clear();
            //Console.WriteLine($"Gero vakaro {vardas} {pavarde}!");
            //Console.ReadLine();



            //1 uzduotis ------------------------------------------------------------
            string spalva = "";

            while (spalva != "stop")
            {
                Console.WriteLine("Sveiki, kokia yra jusu megstama spalva? ");
                spalva = Console.ReadLine();

                Console.WriteLine($"Mano irgi!");

            }
            Console.Clear();
            Console.WriteLine($"Smagiai pabazarinom, gero vakaro!");
            Console.ReadLine();



            //2 uzduotis -----------------------------------------------------------
            // geriau naudot int vietoj var
            //var skaicius1 = 17;
            //var skaicius2 = 23;
            //var suma = 17 + 23;
            //var sum = skaicius1 + skaicius2;

            //Console.WriteLine($"Pirmas skaicius yra: {skaicius1} ");
            //Console.WriteLine("+");
            //Console.WriteLine($"Antras skaicius yra: {skaicius2}");
            //Console.WriteLine("=");                      
            //Console.WriteLine($"Skaiciu suma: {suma}" );
            //Console.WriteLine($"Skaiciu suma: {sum}");

            //Console.ReadLine();



            //3 uzduotis-------------------------------------------------------------------

            // double num1 = 24;
            // double num2 = 5;
            // double num3 =  num1 / num2;
            // //double num4 = (double)24 / 5; kitas pavyzdys

            // Console.WriteLine("24");
            // Console.WriteLine("padalinus is");
            // Console.WriteLine("5");
            // Console.WriteLine("gausim");
            // Console.WriteLine($"{num3}");
            //// Console.WriteLine(num4); perskaityt
            // Console.ReadLine();



            //4 uzduotis-----------------------------------------------------------------------
            //int veiksmas1 = -6 + 3 * 5;
            //int veiksmas2 = (13 - 2) * 7;
            //int veiksmas3 = (5 + 2) + (20 / 10);
            //Console.WriteLine(veiksmas1);
            //Console.WriteLine(veiksmas2);
            //Console.WriteLine(veiksmas3);



            //5 uzduotis--------------------------------------------------------------------------
            //Console.WriteLine("iveskite pirma skaiciu:");
            //string skaicius1 = Console.ReadLine();
            //int num1 = int.Parse(skaicius1);// galim naudot sita arba zemiau esancia
            //Int32.TryParse(skaicius1, out int num3);//jei kazkas nepaeis panaudos nurodyta skaiciu - 32bit skaiciai dideli

            //Console.WriteLine("iveskite antra skaiciu");
            //string skaicius2 = Console.ReadLine();
            //int num2 = int.Parse(skaicius2);// galim naudot sita arba zemiau esancia
            //Int32.TryParse(skaicius2, out int num4);//jei kazkas nepaeis panaudos nurodyta skaiciu - 32bit skaiciai dideli

            //Console.WriteLine($"{num1}, {num2} suma: {num1 + num2}"); //detume num3 ir num4, jei neina
            //Console.WriteLine($"{num1}, {num2} sandauga: {num1 * num2}");//detume num3 ir num4, jei neina
            //Console.WriteLine($"{num1}, {num2} dalyba: {num1 / num2}");//detume num3 ir num4, jei neina
            //Console.WriteLine($"{num1}, {num2} skirtumas: {num1 - num2}");//detume num3 ir num4, jei neina



            //6 uzduotis--------------------------------------------------------------------------------------
            //Console.WriteLine("Iveskite skaiciu:");
            //string skaicius1 = Console.ReadLine();
            //int num1 = int.Parse(skaicius1);

            //Console.WriteLine("Skaiciaus daugybos lentele:");
            //Console.WriteLine($"{num1} * 1 = {num1 * 1}");
            //Console.WriteLine($"{num1} * 2 = {num1 * 2}");
            //Console.WriteLine($"{num1} * 3 = {num1 * 3}");
            //Console.WriteLine($"{num1} * 4 = {num1 * 4}");
            //Console.WriteLine($"{num1} * 5 = {num1 * 5}");
            //Console.WriteLine($"{num1} * 6 = {num1 * 6}");
            //Console.WriteLine($"{num1} * 7 = {num1 * 7}");
            //Console.WriteLine($"{num1} * 8 = {num1 * 8}");
            //Console.WriteLine($"{num1} * 9 = {num1 * 9}");



            //7 uzduotis-------------------------------------------------------------------------------------
            //int vidurkis;
            //Console.WriteLine("Iveskite pirma skaiciu");
            //string skaicius1 = Console.ReadLine();
            //int num1 = int.Parse(skaicius1);

            //Console.WriteLine("Iveskite antra skaiciu");
            //string skaicius2 = Console.ReadLine();
            //int num2 = int.Parse(skaicius2);

            //Console.WriteLine("Iveskite trecia skaiciu");
            //string skaicius3 = Console.ReadLine();
            //int num3 = int.Parse(skaicius3);

            //Console.WriteLine("Iveskite ketvirta skaiciu");
            //string skaicius4 = Console.ReadLine();
            //int num4 = int.Parse(skaicius4);

            //vidurkis = ( (num1 + num2 + num3 + num4) / 4);
            //Console.WriteLine($"Ivestu skaiciu vidurkis: {vidurkis}" );



            //8 uzduotis-----------------------------------------------------------------
            //int num4, num5;

            //Console.WriteLine("Iveskite skaiciu A:");
            //string skaicius1 = Console.ReadLine();
            //int num1 = int.Parse(skaicius1);

            //Console.WriteLine("Iveskite skaiciu B:"); 
            //string skaicius2 = Console.ReadLine();
            //int num2 = int.Parse(skaicius2);

            //Console.WriteLine("Iveskite skaiciu C:");
            //string skaicius3 = Console.ReadLine();
            //int num3 = int.Parse(skaicius3);

            //num4 = ((num1 + num2) * num3);
            //Console.WriteLine($"(A + B) * C = {num4}");

            //num5 = (num1 * num3 + num2 * num3);
            //Console.WriteLine($"A * C + B * C = {num5}");



            //9 uzduotis------------------------------------------------------------
            //string s1;
            //Console.WriteLine("Iveskite simboli:");
            //s1 = Console.ReadLine();

            //Console.WriteLine("\n");
            //Console.WriteLine("Va tau staciakampis:");
            //Console.WriteLine("\n");
            //Console.WriteLine($"{s1}{s1}{s1}");
            //Console.WriteLine($"{s1} {s1}");
            //Console.WriteLine($"{s1} {s1}");
            //Console.WriteLine($"{s1} {s1}");
            //Console.WriteLine($"{s1}{s1}{s1}");
            //Console.WriteLine("\n");
            //Console.WriteLine("NICE! Gero vakaro!");



            //10 uzduotis----------------------------------------------------------------

            //Console.WriteLine("Iveskite temperatura pgal CELSIJU: ");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("\n");

            //var tekstas1 = Int32.TryParse(input1, out int celsius);

            //int kelvin = celsius + 273;
            //Console.WriteLine($"Kelvin: {kelvin}");
            //Console.WriteLine("\n");

            //int fh = celsius * 18 / 10 + 32;
            //Console.WriteLine($"Farengheit: {fh}");
        }

    }
}
