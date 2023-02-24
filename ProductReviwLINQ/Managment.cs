using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviwLINQ
{
    public class Managment
    {
        public static List<ProductReview> Reviews()
        {

            List<ProductReview> list = new List<ProductReview>() 
            {
                new ProductReview() { ProductID = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserId = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, UserId = 2, Rating = 4.1, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 5, UserId = 3, Rating = 3.2, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 6, UserId = 4, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 1, UserId = 3, Rating = 1, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 11, UserId = 10, Rating = 5, Review = "good", IsLike = true },
                new ProductReview() { ProductID = 12, UserId = 10, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 13, UserId = 10, Rating = 2, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 14, UserId = 10, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 15, UserId = 10, Rating = 2, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 16, UserId = 10, Rating = 4.1, Review = "Good", IsLike = true },
            };
            return list;

        }
        public static void DisplayeProductsReview(List<ProductReview> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void TopThreeRecords(List<ProductReview> list)
        {
            Console.WriteLine("Retrieve top 3 records from the list");
            
            var SortTopThreeProduct = from product in list orderby product.Rating descending select product;
            var top3 = SortTopThreeProduct.Take(3).ToList();
            DisplayeProductsReview(top3);
        }
        public static void RatingGreaterThanThree(List<ProductReview> list)
        {
            
            Console.WriteLine("Retrieving products based on rating greater than 3 and having ProductID as 1/4/9");

            var res = list.Where(p => p.Rating > 3 && (p.ProductID == 1 || p.ProductID == 4 || p.ProductID == 9)).ToList();
            DisplayeProductsReview(res);


        }
        public static void CountofReviewForEachProductID(List<ProductReview> list)
        {
            Console.WriteLine("Count of products for each ProductID");
             
            var result = list.GroupBy(p => p.ProductID).Select(product => new { Id = product.Key, Count = product.Count() }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductID: " + item.Id + " Count: " + item.Count);
            }
        }
    }
}

