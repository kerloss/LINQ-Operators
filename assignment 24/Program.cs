using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ-Element Operators
            #region question 1
            //1.Get first Product out of Stock

            //var FirstProductOutOfStock = ListGenerators.ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //if (FirstProductOutOfStock != null)
            //    Console.WriteLine(FirstProductOutOfStock);
            //else
            //    Console.WriteLine("No Product is out of stock");

            //OR

            ////var FirstProductOutOfStock = ListGenerators.ProductList.FirstOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName = "No product is out of stock" });
            ////Console.WriteLine(FirstProductOutOfStock);
            #endregion

            #region question 2
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var FirstProductPriceMore1000 = ListGenerators.ProductList.FirstOrDefault(P => P.UnitPrice > 1000, new Product() { UnitPrice = 0 });
            //Console.WriteLine(FirstProductPriceMore1000);

            ////OR

            //FirstProductPriceMore1000 = ListGenerators.ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //if (FirstProductPriceMore1000 != null)
            //    Console.WriteLine(FirstProductPriceMore1000);
            //else
            //    Console.WriteLine("No product is less than 1000");
            #endregion

            #region question 3
            //3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThan5 = Arr.Where(num => num > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondNumberGreaterThan5);
            #endregion
            #endregion

            #region LINQ-Aggregate Operators
            #region question 1
            //1.Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////int countOfOddNumbers = Arr.Count(n => n % 2 != 0);
            ////Console.WriteLine(countOfOddNumbers);
            ////OR
            //var countOfOddNumbers = from n in Arr
            //                    where n % 2 != 0
            //                    select n;
            //Console.WriteLine(countOfOddNumbers.Count());
            #endregion

            #region question 2
            //2. Return a list of customers and how many orders each has.

            //var customerOrdersCount = ListGenerators.CustomerList.Select(c => new { CustomerName = c.CustomerName, OrderCount = c.Orders.Count() });
            ////OR
            ////var customerOrdersCount = from c in ListGenerators.CustomerList
            ////                          select new
            ////                          {
            ////                              CustomerName = c.CustomerName,
            ////                              OrderCount = c.Orders.Count()
            ////                          };
            //foreach (var item in customerOrdersCount)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 3
            // 3.Return a list of categories and how many products each has

            //var categoryProductCount = ListGenerators.ProductList.GroupBy(p => p.Category).Select(c => new { category = c.Key, ProductCount = c.Count() });
            //foreach (var item in categoryProductCount)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 4
            //4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int totalOfNumbers = Arr.Sum();
            //Console.WriteLine(totalOfNumbers);
            #endregion

            #region question 5
            //5. Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalChar = words.Sum(w => w.Length);
            //Console.WriteLine(totalChar);
            #endregion

            #region question 6
            //6. Get the length of the shortest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int shortestLengthWord = words.Min(w => w.Length);
            //Console.WriteLine(shortestLengthWord);
            #endregion

            #region question 7
            //7. Get the length of the longest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int longestLengthWord = words.Max(l => l.Length);
            //Console.WriteLine(longestLengthWord);
            #endregion

            #region question 8
            //8. Get the average length of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //double AverageLengthWord = words.Average(a => a.Length);
            //Console.WriteLine(AverageLengthWord);
            #endregion

            #region question 9
            //9. Get the total units in stock for each product category.

            //var totalUnitInStockPerCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                            .Select(g => new
            //                                                            {
            //                                                                Category = g.Key,
            //                                                                totalUnitInStock = g.Sum(p => p.UnitsInStock)
            //                                                            });
            //foreach (var item in totalUnitInStockPerCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 10
            //10. Get the cheapest price among each category's products

            //var cheapestPrivePerCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                         .Select(g => new
            //                                                         {
            //                                                             Category = g.Key,
            //                                                             CheapestPrice = g.Min(c => c.UnitPrice)
            //                                                         });
            //foreach (var item in cheapestPrivePerCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 11
            //11. Get the products with the cheapest price in each category (Use Let)

            // //var cheapestProductPerCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            // //                                                         .SelectMany(c =>
            // //                                                         {
            // //                                                             var minPrice = c.Min(p => p.UnitPrice);
            // //                                                             return c.Where(p => p.UnitPrice == minPrice)
            // //                                                             .Select(p => new { Category = c.Key, Product = p });
            // //                                                         });

            ////OR

            //var cheapestProductPerCategory = from p in ListGenerators.ProductList
            //                                 group p by p.Category
            //                                 into g
            //                                 let cheapestPrice = g.Min(p => p.UnitPrice)
            //                                 select new
            //                                 {
            //                                     Category = g.Key,
            //                                     CheapestProducts = g.Where(p => p.UnitPrice == cheapestPrice)
            //                                 };

            //foreach (var group in cheapestProductPerCategory)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.CheapestProducts)
            //    {
            //        Console.WriteLine($"Cheapest Product: {product.ProductName} - Price: {product.UnitPrice}");
            //    }
            //}
            #endregion

            #region question 12
            //12. Get the most expensive price among each category's products.

            //var expansivePricePerCategoryProduct = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                                 .Select(g => new
            //                                                                 {
            //                                                                     Category = g.Key,
            //                                                                     ExpansivePrice = g.Max(e => e.UnitPrice)
            //                                                                 });
            //foreach (var item in expansivePricePerCategoryProduct)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 13
            //13. Get the products with the most expensive price in each category.

            //var ProductMostExpensivePricePerCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                         .Select(g => new
            //                                                         {
            //                                                             Category = g.Key,
            //                                                             ProductMostExpensive = g.Where(P => P.UnitPrice == g.Max(P => P.UnitPrice))
            //                                                         });
            //foreach (var category in ProductMostExpensivePricePerCategory)
            //{
            //    Console.WriteLine(category.Category);
            //}
            #endregion

            #region question 14
            //14. Get the average price of each category's products.

            //var AveragePricePerCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                        .Select(g => new
            //                                                        {
            //                                                            Category = g.Key,
            //                                                            AveragePrice = g.Average(a => a.UnitPrice)
            //                                                        });
            //foreach (var item in AveragePricePerCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ-Set Operators
            #region question 1
            //1.Find the unique Category names from Product List

            //var uniqueCategories = ListGenerators.ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in uniqueCategories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 2
            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var uniqueFirstLetter = ListGenerators.ProductList.Select(p => p.ProductName[0])
            //                                                  .Union(ListGenerators.CustomerList.Select(c => c.CustomerName[0]))
            //                                                  .Distinct();
            //foreach (var item in uniqueFirstLetter)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 3
            //3. Create one sequence that contains the common first letter from both product and customer names.

            //var CommonFirstLetter = ListGenerators.ProductList.Select(p => p.ProductName[0])
            //                                                  .Intersect(ListGenerators.CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in CommonFirstLetter)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 4
            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var commonFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0])
            //                                                   .Except(ListGenerators.CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in commonFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 5
            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var lastThreeChar = ListGenerators.ProductList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //                                              .Concat(ListGenerators.CustomerList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));
            //foreach (var item in lastThreeChar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ-Partitioning Operators
            #region question 1
            //1.Get the first 3 orders from customers in Washington

            //var first3Orders = ListGenerators.CustomerList.Where(c => c.City=="Washington").Take(3);
            //foreach (var item in first3Orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 2
            //2. Get all but the first 2 orders from customers in Washington.

            //var first2OrdersFromCustomers = ListGenerators.CustomerList.Where(c => c.City == "Washington").Skip(2);
            //foreach (var item in first2OrdersFromCustomers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 3
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((num, index) => (num >= index));
            //Console.WriteLine(string.Join(',', Result));
            #endregion

            #region question 4
            //4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(n => n % 3 != 0);
            //Console.WriteLine(string.Join(',', Result));
            #endregion

            #region question 5
            //5. Get the elements of the array starting from the first element less than its position.
            
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((num, index) => (num >= index));
            //Console.WriteLine(string.Join(',', Result));
            #endregion
            #endregion

            #region LINQ-Quantifiers
            #region question 1
            //1. Determine if any of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(containsEi);
            #endregion

            #region question 2
            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var outOfStockCategories = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                     .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                                                     .ToList();

            //foreach (var categoryGroup in outOfStockCategories)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}");
            //    }
            //}
            #endregion

            #region question 3
            //3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var allInStockCategories = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                     .Where(g => g.All(p => p.UnitsInStock >= 0))
            //                                                     .ToList();
            //foreach (var categoryGroup in allInStockCategories)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}");
            //    }
            //}
            #endregion
            #endregion

            #region LINQ-Grouping Operators
            #region question 1
            //1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupedNumbers = numbers.GroupBy(num => num % 5);
            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder {group.Key}: when divided by 5:\n{string.Join(", ", group)}");
            //}
            #endregion

            #region question 2
            //2.	Uses group by to partition a list of words by their first letter.
            //(Use dictionary_english.txt for Input)

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var groupedWords = words.GroupBy(w => w[0]);
            //foreach (var item in groupedWords)
            //{
            //    Console.WriteLine($"Words with first letters {item.Key}: {string.Join(',', item)}");
            //}
            #endregion

            #region question 3
            //3.	Consider this Array as an Input
            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var groupedArray = Arr.GroupBy(w => w, new WordComparer());
            //foreach (var item in groupedArray)
            //{
            //    Console.WriteLine($"words with same characters {item.Key} : {string.Join(',', item)}");
            //}
            #endregion
            #endregion
        }
    }
}
