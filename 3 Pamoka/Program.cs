using System;

namespace _3_Pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //// FLOAT ir DOUBLE
            //float numFloat = 1f / 3;
            //double numDouble = 1D / 3;

            //if (numFloat == numDouble)
            //{
            //    Console.WriteLine($"Skaicius Float: {numFloat}, skaicius Double: {numDouble}");            
            //}
            //else 
            //{
            //    Console.WriteLine($"Skaicius Float: {numFloat}, nera lygus skaiciui Double: {numDouble}");
            //}

            // STRING ir CHAR
            //string name = "Jonas";
            //char simbolis = 'J';

            //// byte gali dirb 0 - 255 skaiciu
            //byte a = 0;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a = 254;
            //a++;

            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //// sbyte yra nuo -128 iki 127
            //sbyte b = 126;
            //b++;
            //b++;
            //b++;

            //// reference tipas
            //string lastname = "Jonas";
            //string lastname1 = null;
            //lastname1 = "Petras";

            //Human human1 = new Human();
            //human1.name = "Jonas";

            //List<string> vardai = new List<string>();

            ////Implicit casting
            //byte c = 57;
            //int i = c;
            //long l = i;
            //float f = l;

            //Console.WriteLine($"SBYTE {b}");
            //Console.WriteLine($"INT {i}");
            //Console.WriteLine($"LONG {l}");
            //Console.WriteLine($"FLOAT {f}");

            ////Explicit Casting
            //double x = 1234.5D;
            //int o = (int)x; //skliaustai nurodo tipa i kuri konvertinam, kai exxplicit naudojam is didesnio tipo i mazesni tada naudojam
            //                // nes is mazesnio i didesni auto konvertuot gali.
            //Console.WriteLine($"{o}");

            //// Konvertavimo klases pvz:\
            //int k = 12;
            //double d = 765.12D;
            //float g = 56.12F;

            //string convertedToString = Convert.ToString(f);
            //int convertedToInt = Convert.ToInt32(d);
            //double convertedDouble = Convert.ToDouble(g);

            // ----------------------------------------------- 1 UZDUOTIS ------------------------------------------

            //Console.WriteLine("Iveskite atstuma metrais: ");
            //string input1 = Console.ReadLine();
            //double atstumas = Convert.ToDouble(input1);

            //Console.WriteLine("Iveskite laika sekundemis: ");
            //string input2 = Console.ReadLine();
            //double laikas = Convert.ToDouble(input2);

            //double greitis = atstumas / laikas;
            //double greitisKMH = greitis * 3.6;
            //Console.WriteLine($"Greitis Km/h: {greitisKMH}");

            //------------------------------------------------- 2 UZDUOTIS ------------------------------------------

            //Console.WriteLine("Iveskite kvadrato krastine: ");
            //string input1 = Console.ReadLine();
            //double inputas = Convert.ToDouble(input1);

            //double plotas = inputas * inputas;
            //double turis = inputas * inputas * inputas;

            //Console.WriteLine($"Kvadrato plotas: {plotas}");
            //Console.WriteLine($"Kvadrato turis: {turis}");

            // ------------------------------------------------ 3 UZDUOTIS ------------------------------------------

            //Console.WriteLine("Iveskite pirma skaiciu: ");
            //string input1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(input1);

            //Console.WriteLine("Iveskite antra skaiciu: ");
            //string input2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(input2);

            //bool pirmas = num1 % 2 == 0;
            //bool antras = num2 % 2 == 0;
            //bool tiesa = pirmas && antras;

            //Console.WriteLine($"\nTiesos akimirka: Ar abu skaiciai buvo lyginiai?\n");

            //if (tiesa)
            //{
            //    Console.WriteLine($"{tiesa}");
            //}
            //else 
            //{
            //    Console.WriteLine($"{tiesa}");
            //}

            //-------------------------------------------------- 4 UZDUOTIS --------------------------------------------
            //----------------------------------Susipisa jei gerai suvedi is 2 arba 3 karto-----------------------------

            //var vardas = "karolis";
            //var slaptazodis = "69";

            //Console.Write("Iveskite PRISIJUNGIMO VARDA: ");
            //var input1 = Console.ReadLine();

            //Console.Write("Iveskite SLAPTAZODI: ");
            //var input2 = Console.ReadLine();

            //bool teisingai = input1 == vardas && input2 == slaptazodis;
            //// 1 bandymas
            //if (teisingai)
            //{
            //    Console.WriteLine("\nSveikiname sekmingai prisijungus pries savo PornHub paskyros! Malonaus narsymo ;)");
            //}
            //else// 2bandymas:
            //{
            //    Console.Clear();
            //    Console.WriteLine("\nNeteisingi prisijungimo duomenys, jums liko 2 bandymai.");
            //    Console.Write("Iveskite PRISIJUNGIMO VARDA: ");
            //    input1 = Console.ReadLine();
            //    Console.Write("Iveskite SLAPTAZODI: ");
            //    input2 = Console.ReadLine();

            //    teisingai = input1 == vardas && input2 == slaptazodis;
            //    if (teisingai)
            //    {
            //        Console.WriteLine("\nSveikiname sekmingai prisijungus pries savo PornHub paskyros! Malonaus narsymo ;)");
            //    }
            //    else// 3 bandymas
            //    {
            //        Console.Clear();
            //        Console.WriteLine("\nBicas susiimk, dar 1 neteisingas bandymas ir teks naudot fantazija! :D");
            //        Console.Write("Iveskite PRISIJUNGIMO VARDA: ");
            //        input1 = Console.ReadLine();
            //        Console.Write("Iveskite SLAPTAZODI: ");
            //        input2 = Console.ReadLine();

            //        teisingai = input1 == vardas && input2 == slaptazodis;

            //        if (teisingai)
            //        {
            //            Console.WriteLine("\nSveikiname sekmingai prisijungus pries savo PornHub paskyros! Malonaus narsymo ;)");
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("\nKLAIDA! Viskas, prisizaidei. Kita kart uzsirasyk kur nors ta slaptazodi...");
            //        }
            //    }
            //    // tekstas icykzdius salyga
            //    //Console.WriteLine("\nSveikiname sekmingai prisijungus pries savo PornHub paskyros! Malonaus narsymo ;)");
            //}

            //-------------------------------------------------- 5 UZDUOTIS --------------------------------------------
            //---------------------------------------Breikina ties konvertavimu i INT16---------------------------------
            //--------------------------------------------Net su CHECKED funkcija---------------------------------------

            //Console.WriteLine("Iveskite dideli (10 skaitmenu skaiciu): ");
            //string input1 = Console.ReadLine();
            //double inputas = Convert.ToDouble(input1);

            //int num1 = Convert.ToInt32(inputas);
            //Int16 num2 = (Convert.ToInt16(inputas));
            //byte num3 = (Convert.ToByte(inputas));
            ////byte num4 = checked(NotFiniteNumberException(inputas));

            //Console.WriteLine($"Konvertuojam i INT: {num1}");
            //Console.WriteLine($"Konvertuojam i SHORT: {num2}");
            //Console.WriteLine($"Konvertuojam i BYTE: {num3}");
            ////Console.WriteLine($"Konvertuojam i BYTE: {num4}");
            ////Console.ReadLine();


            //---------------------------------------------------CONDITIONS---------------------------------------------------------------

            //Console.WriteLine("Iveskite grupes pavadinima: ");
            //string grupesPavadinimas = Console.ReadLine();

            //Console.WriteLine("Iveskite grupes nariu skaiciu: ");
            ////int nariuSkaicius = int.Parse(Console.ReadLine()); // sudejom i IF, kad nereiktu deklaruot cia
            //// galima rasyt ilgesniu budu:
            ////string input = Console.ReadLine();
            ////int nariuSkaicius = int.Parse(input);


            //if (!int.TryParse(Console.ReadLine(), out int nariuSkaicius)) ;
            //{
            //    Console.WriteLine("Neteisingai ivestas skaicius!");
            //    Environment.Exit(0); // naudojam kad uzbaigtu programa
            //}

            // ------------ ELSE IF---------------
            //string spalva = Console.ReadLine();

            //if (spalva == "geltona")
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else if (spalva == "zalia")
            //{
            //    Console.WriteLine("Irgi grazi spalva");
            //}
            //else if (spalva == "raudona")
            //{
            //    Console.WriteLine("Padori spalva");
            //}
            //else
            //{
            //    Console.WriteLine("Nezinau tokios spalvos");
            //}



            //Console.WriteLine("Koki veiksma norite atlikti?");
            //Console.WriteLine("[1] - istrinti vartotoja, [2] - sukurti vartotoja, [3] - redaguoti esama vartotoja");

            //int veiksmas = int.Parse(.ReadLine());

            //if (veiksmas == 1)// NAUDOJANT IF METODA
            //{
            //    Console.WriteLine("VarConsoletotojas istrintas");
            //}
            //else if (veiksmas == 2)
            //{
            //    Console.WriteLine("Vartotojas sukurtas");
            //}
            //else if (veiksmas == 3)
            //{
            //    Console.WriteLine("Vartotojas pakoreguotas");
            //}
            //else
            //{
            //    Console.WriteLine("Nesuprantu komandos");
            //}

            //switch (veiksmas)// SAME tik su SWITCH metodu
            //{
            //    case 1:
            //        Console.WriteLine("Vartotojas istrintas");
            //        break;
            //    case 2:
            //        Console.WriteLine("Vartotojas sukurtas");
            //        break;
            //    case 3:
            //        Console.WriteLine("Vartotojas pakoreguotas");
            //        break;
            //    default: //tas pats kas ELSE 
            //        Console.WriteLine("Nesuprantu komandos");
            //        break;
            //}

            // -------------- TERNARY OPERATOR----------------------
            // int skaicius =  10;

            //string vardas = "Marija";

            //if(vardas == "Marija")
            //{
            //    Console.WriteLine("Marija yra moteris");
            //}
            //else
            //{
            //    Console.WriteLine($"{vardas} yra vyras");
            //}
            //// jei vardas = Marija, darom pirma po klaustuko, jei ne tada po dvitaskio
            //var testas = vardas == "Marija" ? "Marija yra moteris" : $"{vardas} yra vyras";

            // ------------------------------------------- 1 UZDUOTIS ---------------------------------------

            //Console.WriteLine("Iveskite grupes nariu saiciu:");
            //int skaicius = int.Parse(Console.ReadLine());

            //if (skaicius == 1)
            //{
            //    Console.WriteLine("Tai solo atlikejas");
            //}
            //else if (skaicius == 2)
            //{
            //    Console.WriteLine("Tai duetas");
            //}
            //else if (skaicius == 3)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 4)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 5)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 6)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 7)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 8)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 9)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            //else if (skaicius == 10)
            //{
            //    Console.WriteLine("Tai ansamblis");
            //}
            ////else if (skaicius >= 3 && skaicius <= 10)
            ////{
            ////    Console.WriteLine("Tai snasamblis");
            ////}
            //else if(skaicius > 10)
            //{
            //    Console.WriteLine("Tai kamerinis ansamblis");
            //}
            //else
            //{
            //    Console.WriteLine("Tai kamerinis ansamblis");
            //}

            //CASE

            //switch (skaicius)
            //{
            //    case 1:
            //        Console.WriteLine("Tai solo atlikejas");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tai duetass");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //        Console.WriteLine("Tai ansamblis");
            //        break;
            //    case int x when (skaicius >= 10):
            //        Console.WriteLine("Tai kamerinis ansamblis ");
            //        break;
            //    default:
            //        Console.WriteLine("Blogai ivestas skaicius");
            //        break;
            //}

            // ------------------------------------------------ 2 UZDUOTIS --------------------------------------------

            //Console.WriteLine("Iveskite isdirbtas valandas: ");
            //int valandos = int.Parse(Console.ReadLine());

            //if(valandos < 160)
            //{
            //    Console.WriteLine($"Iki pilno etato jums liko isdirbti: {160 - valandos} val.");
            //}
            //else if(valandos == 160)
            //{
            //    Console.WriteLine("Maladec, isdirborte pilna etata!");
            //}
            //else if(valandos > 160)
            //{
            //    Console.WriteLine($"Isdirbote pilna etata + {valandos - 160} val. virsvalandziu");
            //}
            //else
            //{
            //    Console.WriteLine("Padarete ivedimo klaida!");
            //}


            // --------------------------------------------- 3 UZDUOTIS ---------------------------------------

            //Console.WriteLine("Iveskite savo egzamino ");
            //int pazymys = int.Parse (Console.ReadLine());

            //if (pazymys <= 4)
            //{
            //    Console.WriteLine("NEPATENKINAMAI");
            //}
            //else if (pazymys == 5)
            //{
            //    Console.WriteLine("SILPNAI");
            //}
            //else if (pazymys == 6)
            //{
            //    Console.WriteLine("PATENKINAMAI");
            //}
            //else if (pazymys == 7)
            //{
            //    Console.WriteLine("VIDUTINISKAI");
            //}
            //else if (pazymys == 8)
            //{
            //    Console.WriteLine("GERAI");
            //}
            //else if (pazymys == 9)
            //{
            //    Console.WriteLine("LABAI GERAI");
            //}
            //else if (pazymys == 10)
            //{
            //    Console.WriteLine("PUIKU");
            //}
            //else
            //{
            //    Console.WriteLine("Neteisingai ivedete pazymi");
            //}
            //// CASE

            //switch (pazymys)
            //{
            //    case 0:  case 1: case 2: case 3: case 4:
            //        Console.WriteLine("NEPATENKINAMAI");
            //        break;
            //    case 5:
            //        Console.WriteLine("SILPNAI");
            //        break;
            //    case 6:
            //        Console.WriteLine("PATENKINAMAI");
            //        break;
            //    case 7:
            //        Console.WriteLine("VIDUTINISKAI");
            //        break;
            //    case 8:
            //        Console.WriteLine("GERAI");
            //        break;
            //    case 9:
            //        Console.WriteLine("LABAI GERAI");
            //        break;
            //    case 10:
            //        Console.WriteLine("PUIKU");
            //        break;
            //    default:
            //        Console.WriteLine("Neteisingai ivedete pazymi");
            //        break;
            //}
        }
        //private static byte NotFiniteNumberException(double inputas)
        //{
        //    throw new NotImplementedException();
        //    Console.WriteLine("Iveskite dideli (10 skaitmenu skaiciu): ");
        //    string input1 = Console.ReadLine();
        //    double inputas = Convert.ToDouble(input1);

        //    int num1 = Convert.ToInt32(inputas);
        //    //Int16 num2 = checked (Convert.ToInt16(inputas));
        //    //byte num3 = checked (Convert.ToByte(inputas));
        //    byte num4 = checked(NotFiniteNumberException(inputas));

        //    Console.WriteLine($"Konvertuojam i INT: {num1}");
        //    //Console.WriteLine($"Konvertuojam i SHORT: {num2}");
        //    //Console.WriteLine($"Konvertuojam i BYTE: {num3}");
        //    Console.WriteLine($"Konvertuojam i BYTE: {num4}");
        //    //Console.ReadLine();

        //}


        // sitas tekstas nesikompialiuos aukstesniam skliauste, todel rasom cia. P.S Kodus rasyt virs sito!
        //public class Human 
        //{
        //    public string name;
        //}
    }

    internal class List<T>
    {
    }
}
