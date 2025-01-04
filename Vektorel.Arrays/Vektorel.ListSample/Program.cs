


namespace Vektorel.ListSample
{
    enum SortType
    {
        ASC, // Küçükten Büyüğe
        DESC // Büyükten Küçüğe
    }

    record Product(string Name, decimal Price, int Stock);

    internal class Program
    {
        static SortType acceptedSortType = SortType.ASC;
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            products.Add(new Product("Battaniye", 200, 3));
            products.Add(new Product("Kilim", 400, 2));
            products.Add(new Product("Çaydanlık", 54, 8));
            products.Add(new Product("Bardak", 14, 87));
            products.Add(new Product("Sürahi", 76, 21));
            products.Add(new Product("Tepsi", 87, 4));

            while (true)
            {
                OrderList();
                Print();

                Console.WriteLine();
                Console.WriteLine("[ ========= KOMUT SATIRI =========]");
                Console.WriteLine("[S] - Sıralama Değiştir\n[A] - Ürün Ekle\n[D] - Ürün Sil\n[F] - Ürün Ara");
                var keyInfo = Console.ReadKey();
                switch(keyInfo.Key)
                {
                    case ConsoleKey.S:
                        ChangeSortType();
                        break;
                    case ConsoleKey.A:
                        AddProduct();
                        break;
                    case ConsoleKey.D:
                        RemoveProduct();
                        break;
                    case ConsoleKey.F:
                        FindProduct();
                        break;
                }

                /*
                 if(keyInfo.Key == ConsoleKey.S),
                 {
                    ChangeSortType();
                 }
                 else if(keyInfo.Key == ConsoleKey.A),
                 {
                    AddProduct();
                 }
                 else if(keyInfo.Key == ConsoleKey.D),
                 {
                    RemoveProduct();
                 }
                 */
            }
        }

        static void FindProduct()
        {
            Console.Clear();
            Console.WriteLine("ÜRÜN ARAMA EKRANI");
            Console.Write("Ürün Adı............: ");
            var name = Console.ReadLine();

            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    Console.WriteLine("ÜRÜN BULUNDU");
                    Console.WriteLine("{0, -15} {1, 6} {2, 6}", product.Name, product.Price, product.Stock);
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Devam etmek için bir tuşa basınız");
            Console.ReadKey();
        }

        static void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("ÜRÜN SİLME EKRANI");
            Console.Write("Ürün Adı............: ");
            var name = Console.ReadLine();

            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    products.Remove(product);
                    break;
                }
            }
        }

        static void ChangeSortType()
        {
            if (acceptedSortType == SortType.ASC)
            {
                acceptedSortType = SortType.DESC;
            }
            else
            {
                acceptedSortType = SortType.ASC;
            }
        }

        static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("ÜRÜN EKLEME EKRANI");
            Console.Write("Ürün Adı............: ");
            var name = Console.ReadLine();
            Console.Write("Fiyatı..............: ");
            var price = decimal.Parse(Console.ReadLine());
            Console.Write("Stok Miktarı. ......: ");
            var stock = int.Parse(Console.ReadLine());

            products.Add(new Product(name, price, stock));
        }

        static void Print()
        {
            Console.Clear();
            Console.WriteLine("{0, -15} {1, 6} {2, 6}", "Ürün", "Fiyat", "Stok");
            Console.WriteLine("-----------------------------");

            foreach (var p in products)
            {
                Console.WriteLine("{0, -15} {1, 6} {2, 6}", p.Name, p.Price, p.Stock);
            }
        }

        static void OrderList()
        {
            //ÖDEV: Buradaki method tek seferde kullanıalcak 2 method birleştirilecek
            if (acceptedSortType == SortType.ASC)
            {
                OrderByPriceAscending();
            }
            else if (acceptedSortType == SortType.DESC)
            {
                OrderByPriceDescending();
            }
        }

        static void OrderByPriceDescending()
        {
            var hasSwapped = false;
            do
            {
                hasSwapped = false;
                //c : current, n: next
                for (var c = 0; c < products.Count; c++)
                {
                    var n = c + 1;
                    if (n >= products.Count)
                    {
                        break;
                    }
                    if (products[c].Price < products[n].Price)
                    {
                        Swap(products, c, n);
                        hasSwapped = true;
                    }
                }
            } while (hasSwapped);
        }

        static void OrderByPriceAscending()
        {
            var hasSwapped = false;
            do
            {
                hasSwapped = false;
                //c : current, n: next
                for (var c = 0; c < products.Count; c++)
                {
                    var n = c + 1;
                    if (n >= products.Count)
                    {
                        break;
                    }
                    if (products[c].Price > products[n].Price)
                    {
                        Swap(products, c, n);
                        hasSwapped = true;
                    }
                }
            } while (hasSwapped);
        }

        static void Swap(List<Product> products, int currentIndex, int nextIndex)
        {
            var temp = products[currentIndex];
            products[currentIndex] = products[nextIndex];
            products[nextIndex] = temp;
        }
    }
}
