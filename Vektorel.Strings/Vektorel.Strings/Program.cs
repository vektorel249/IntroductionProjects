using System.Globalization;
using System.Text;

namespace Vektorel.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uygulama dilini değiştir
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("tr-US");
            //Unicode karakterleri göster
            Console.OutputEncoding = Encoding.UTF8;

            var word = "DIŞ";
            var wordLower1 = word.ToLower();
            var wordLower2 = word.ToLowerInvariant();

            var sampleRussianText = "Хей девушка! красавиться! Ты мне очень нравиться...";
            var sampleTurkishText = "İğne, iplik satarım. Işık saçar bakarım!";

            Console.WriteLine("[RU] Original.......: {0}", sampleRussianText);
            Console.WriteLine("[RU] Küçük Harf.....: {0}", sampleRussianText.ToLowerInvariant());
            Console.WriteLine("[RU] Büyük Harf.....: {0}", sampleRussianText.ToUpperInvariant());
            Console.WriteLine();

            Console.WriteLine("[TR] Original................: {0}", sampleTurkishText);
            Console.WriteLine("[TR] Uzunluk.................: {0}", sampleTurkishText.Length);
            Console.WriteLine("[TR] Küçük Harf..............: {0}", sampleTurkishText.ToLower());
            Console.WriteLine("[TR] Küçük Harf - Invariant..: {0}", sampleTurkishText.ToLowerInvariant());
            Console.WriteLine("[EN] Küçük Harf..............: {0}", sampleTurkishText.ToLower(new CultureInfo("en-US")));
            Console.WriteLine("[TR] Büyük Harf..............: {0}", sampleTurkishText.ToUpper());

            Console.WriteLine("[TR] İlk 10 Harf.............: {0}", sampleTurkishText.Substring(0, 10));
            Console.WriteLine("[TR] İlk 10 Harfi Kırp.......: {0}", sampleTurkishText.Substring(10));
            Console.WriteLine("[TR] Aradan 8 Harf...........: {0}", sampleTurkishText.Substring(5, 8));

            Console.WriteLine("İlk T harfi..................: {0}", sampleTurkishText.IndexOf("t"));
            Console.WriteLine("6. Karakter..................: {0}", sampleTurkishText[5]);
            Console.WriteLine("A -> E olsun.................: {0}", sampleTurkishText.Replace('a', 'e'));
            Console.WriteLine("Karadenizli Ol...............: {0}", sampleTurkishText.Replace("rım", "rum"));


            var eachSeparation = sampleTurkishText.Split(' ');
            var eachWord = sampleTurkishText.Split(',', '.', '!', ' ');

            Console.WriteLine("Ayrıştırılmıuş Kelimeler");
            foreach (var w in eachWord)
            {
                if (!string.IsNullOrEmpty(w))
                {
                    Console.WriteLine(w.ToLower());
                }
            }

            var allchars = sampleTurkishText.ToCharArray();
            Console.WriteLine();
            var n1 = "Can";
            var n2 = "Cem";
            var n3 = "Caner";
            var n4 = "Cantürk";
            var end = "geldiler";

            // Concat by plus
            var sentence1 = n1 + ", " + n2 + ", " + n3 + " ve " + n4 + " " + end;
            var suffix = " Bitti...";
            sampleTurkishText += suffix;

            //String format
            var sentence2 = string.Format("{0}, {1}, {2} ve {3} {4}", n1, n2, n3, n4, end);

            //Concating params
            var sentence3 = string.Concat(n1, ", ", n2, ", ", n3, " ve ", n4, " ", end);

            //String Interpolation
            var sentence4 = $"{n1}, {n2}, {n3} ve {n4} {end} ve gittiler.".ToString().ToString().ToString(); // Neen 3 kere string e çevirdik? Etkisi ne?

            var someString = "  ! öylesine bir ifade   !";
            //TRIM : Boşlukları kırp(sadece başta ve sonda olanları)
            var trimmed = someString.Trim();
            //TRIM : İstenilen karakterleri kırp(sadece başta ve sonda olanları)
            var trimmedCustom = someString.Trim('!', ' ');
            var trimmedFromStart = someString.TrimStart();
            var trimmedFromEnd = someString.TrimEnd();
            Console.WriteLine("\n\nTRIM");
            Console.WriteLine(someString);
            Console.WriteLine(trimmed);
            Console.WriteLine(trimmedCustom);
            Console.WriteLine(trimmedFromStart);
            Console.WriteLine(trimmedFromEnd);

            //PAD - Boşluk Doldurma
            var name1 = "CAN";
            var name2 = "MUSTAFA";
            var name3 = "ABDURRAHMAN";
            var printedName1 = name1.PadRight(10, 'X');
            var printedName2 = name2.PadRight(10, 'X');
            var printedName3 = name3.PadRight(10, 'X');
            Console.WriteLine(printedName1);
            Console.WriteLine(printedName2);
            Console.WriteLine(printedName3);

            var index = 10;
            var serialNumber1 = index.ToString().PadLeft(6, '0');
            index = 238;
            var serialNumber2 = index.ToString().PadLeft(6, '0');
            index = 1845;
            var serialNumber3 = index.ToString().PadLeft(6, '0');
            index = 34658;
            var serialNumber4 = index.ToString().PadLeft(6, '0');
            Console.WriteLine(serialNumber1);
            Console.WriteLine(serialNumber2);
            Console.WriteLine(serialNumber3);
            Console.WriteLine(serialNumber4);

            var originalName = "Mustafa Kemal Atatürk";
            //"MU**** KE**** AT****";
            var words = originalName.Trim().Split(' ');
            var anonymizedName = string.Empty;
            foreach (var w in words)
            {
                anonymizedName += w.Substring(0,2).ToUpper() + "**** ";
            }
            Console.WriteLine(anonymizedName);
        }
    }
}