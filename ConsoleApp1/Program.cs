﻿using ConsoleApp1.HomeWork_lecture5;
using ConsoleApp1.HomeWork_lecture6.Clinic;
using ConsoleApp1.HomeWork_lecture6.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using TMS_homeworks.HomeWork_Lecture10_Generics;
using TMS_homeworks.HomeWork_lecture11_Delegates;
using TMS_homeworks.HomeWork_lecture12_LINQ;
using TMS_homeworks.HomeWork_lecture6.Autopark;
using TMS_homeworks.HomeWork_lecture8_Exceptions;
using TMS_homeworks.HomeWork_lecture9_Collections;
using static TMS_homeworks.HomeWork_lecture11_Delegates.PriceMonitor;

namespace TMS_homeworks
{
    internal class Program_lecture5
    {
        public static string[] words = {"3", "k", "Katy", "Null", "3", "Null", "l", "tree", "tee", "33", "33", "rail" };
        public static void Main()
        {
            Console.WriteLine($"First one character word in array - {Words.GetOneLetterWord(words)}");
            Console.WriteLine($"Last word containing 'ee' is {Words.GetLastSubstringWord(words)}");
            Console.WriteLine($"Number of unique words in the array: {Words.GetQntyUniqueValues(words)}");
            //Console.WriteLine($"Words from 5th position with '3' are {Words.GetValuesWith3(words)}");
            Console.WriteLine($"The length of the shortest word is {Words.GetLengthOfShortest(words)}");
            Console.WriteLine($"Last word with defined length is {Words.GetLastLengthWord(words)}");
        }

        public static void Observer()
        {
            Random random = new();

            int price = random.Next(300, 2500);

            PriceMonitor monitor = new PriceMonitor();
            Subscriber300_500 subscriber300_500 = new Subscriber300_500();
            Subscriber300_800 subscriber300_800 = new Subscriber300_800();

            MonitorDelegate monitorDelegate = new MonitorDelegate(ShowPrice);
            monitorDelegate(price);

            monitor.Subscribe(subscriber300_500);
            monitor.Subscribe(subscriber300_800);
            subscriber300_500.InformSubscribers(monitor, price);
            subscriber300_800.InformSubscribers(monitor, price);

            Console.ReadKey();
        }

        public static void CarTask()
        {
            var dieselEngine = new Diesel();
            var car = new Car<Diesel>(dieselEngine);
            car.Move();
            car.Refill();
        }

        public static void GenericArrayTask()
        {
            {
                GenericArray<int> genericArray = new(new int[] { 1, 2, 465, 81, 44 });
                genericArray.Add(1);
                genericArray.Delete(8);
                genericArray.GetLength();
                genericArray.Print();
            }
        }
        public static void ListTask()
        {
            List<Product> productList = new List<Product>()
            {
                new Product("Banana milk", 540, new DateTime(2022, 11, 12), new DateTime(2023, 06, 12)),
                new Product("Gouda", 300, new DateTime(2023, 01, 25), new DateTime(2023, 07, 24)),
                new Product("Sour cream", 350, new DateTime(2022, 11, 25), new DateTime(2023, 04, 02)),
                new Product("Sandwich", 270, new DateTime(2023, 03, 08), new DateTime(2023, 03, 09)),
                new Product("Bread", 320, new DateTime(2023, 03, 08), new DateTime(2023, 03, 12)),
                new Product("Apple", 60, new DateTime(2023, 03, 08), new DateTime(2023, 05, 16)),
                new Product("Apple juice", 160, new DateTime(2023, 03, 08), new DateTime(2023, 05, 16)),
                new Product("Tomato", 60, new DateTime(2023, 03, 08), new DateTime(2023, 05, 16)),
                new Product("Beef", 560, new DateTime(2023, 03, 08), new DateTime(2023, 05, 16))
            };

            List<Product> expensiveProducts = new List<Product>();
            Console.WriteLine("Expensive products");

            foreach (var product in productList)
            {
                if (product.ProductPrice > 300)
                {
                    expensiveProducts.Add(product);
                    Console.WriteLine(product);
                }
            }

            int minPrice = expensiveProducts.Min(min => min.ProductPrice);

            Console.WriteLine("The cheapest " + minPrice);
            Console.WriteLine("\nModified list");

            productList[0].ProductPrice += 100;
            productList.RemoveAt(5);

            foreach (Product product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nRemove all");

            productList.RemoveRange(0, 5);

            foreach (Product product in productList)
            {
                Console.WriteLine(product);
            }
        }

        public static void ProductBase()
        {
            List<Product> productList = new List<Product>()
            {
                new Product("Chocolate milk", 150, new DateTime(2022, 11, 12), new DateTime(2023, 06, 12)),
                new Product("Camambert", 300, new DateTime(2023, 01, 25), new DateTime(2023, 07, 24)),
                new Product("Kefir", 250, new DateTime(2022, 11, 25), new DateTime(2023, 04, 02)),
                new Product("Croissant", 270, new DateTime(2023, 03, 08), new DateTime(2023, 03, 09)),
                new Product("Brezel", 180, new DateTime(2023, 03, 08), new DateTime(2023, 03, 12)),
                new Product("Carrot bun", 60, new DateTime(2023, 03, 08), new DateTime(2023, 05, 16))
            };

            foreach (var product in productList)
            {
                Console.WriteLine(product);
                product.CheckExpirationDate();
                Console.WriteLine();
            }

            List<ProductBatch> productBatches = new List<ProductBatch>()
            {
                new ProductBatch("Chocolate milk batch", productList[0], 10),
                new ProductBatch("Carrot bun batch", productList[5], 15)
            };

            foreach (var batches in productBatches)
            {
                Console.WriteLine(batches);
                Console.WriteLine("Batch price:" + batches.GetBatchPrice());
                batches.CheckExpirationDate();
                Console.WriteLine();
            }

            List<ProductSet> productSets = new List<ProductSet>()
            {
                new ProductSet("Paris mood", productList[1], productList[3]),
                new ProductSet("Child menu", productList[0],productList[5])
            };

            foreach (var productSet in productSets)
            {
                Console.WriteLine("Set discount price:" + productSet.GetSetPrice());
                productSet.CheckExpirationDate();
            }
        }

        public static void PrintStudentList()
        {
            StudentsList.Print();
        }

        public static void ExceptionTask()
        {
            ArrayList list = new ArrayList();
            try
            {
                object s = list[18];
            }
            catch
            {
                Console.WriteLine("Index out of bounds exception");
            }
        }
        public static void RegistrationExceptions()
        {
            try
            {
                Console.WriteLine("Your login:");
                string? login = Console.ReadLine();

                Console.WriteLine("Your password:");
                string? password = Console.ReadLine();

                Console.WriteLine("Confirm your password:");
                string? confirmPassword = Console.ReadLine();

                var registered = Registration.Register(login, password, confirmPassword);

                if (registered)
                {
                    Console.WriteLine("Registered successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Autopark()
        {
            Bus bus12 = new Bus("Pivet Drive", 12, "11:38", 12);
            Bus bus27 = new Bus("Sun street", 27, "10:05", 40);
            Subway subway44 = new Subway("Monumentale", 44, "14:55", 133);
            Subway subway793 = new Subway("Pivet Drive", 793, "09:37", 200);
            Tram tram25 = new Tram("King's Cross", 25, "05:40", 40);
            Tram tram3 = new Tram("Monumentale", 3, "07:40", 19);
            Trolleybus trolleybus78 = new Trolleybus("Sun street", 78, "12:04", 17);
            Trolleybus trolleybus5 = new Trolleybus("King's Cross", 5, "23:49", 44);

            PublicTransport[] publicTransports = new PublicTransport[] { bus12, bus27, subway44, subway793, tram25, tram3, trolleybus78, trolleybus5 };

            Array.Sort(publicTransports);

            foreach (var transport in publicTransports)
            {
                Console.WriteLine(transport);
            }
        }
        public static void Clinic()
        {
            Patient patient = new Patient("Tom Walker", "Headache", 3);
            patient.treatmentPlan.AssignDoctor();
        }
        public static void FiguresTask()
        {
            Figures[] figures = new Figures[]{
                new RectangleBuilder().CreateRectangle(4, 4, 4, 4),
                new TriangleBuilder().CreateTriangle(3, 4, 5)
            };
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetSquare());
            }
        }
        public void CreditCardTask()
        {
            {
                CreditCard johnsCard = new CreditCard(111265115456, 123);
                CreditCard davesCard = new CreditCard(2254654513, 0);
                CreditCard katesCard = new CreditCard(3546546541, -500);

                johnsCard.ReplenishCardAccount(1000);
                davesCard.ReplenishCardAccount(1);
                katesCard.WithdrawMoney(500);

                johnsCard.GetInfo();
                davesCard.GetInfo();
                katesCard.GetInfo();
            }
        }
        public void PhoneTask()
        {
            {
                Phone mashasPhone = new Phone(15456465, "Iphone X", 0.144);
                Phone mishasPhone = new Phone(24564464, "Samsung s22");
                Phone grishasPhone = new Phone();

                grishasPhone.GetInfo();
                mashasPhone.ReceiveCall("Mike");
                mashasPhone.ReceiveCall(12356114, "Мила");
                mashasPhone.SendMessage(13545, 54545465, 46545);
                mishasPhone.GetNumber();
            }
        }
    }
}