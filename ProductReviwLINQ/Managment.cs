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
    }
}

