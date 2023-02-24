namespace ProductReviwLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management System");
            List<ProductReview> list = Managment.Reviews();

            Console.WriteLine("1.Create a Product Review List\n2.Top Three Records\n3.Rating Greater than Thre\n4.Count of Review\n5.Retrieve only Product ID" +
                "\n5.Skip Top Five Records");
            var option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: 
                    Managment.DisplayeProductsReview(list);
                    break;
                case 2:
                    Managment.TopThreeRecords(list);
                    
                    break;
                case 3:
                    Managment.RatingGreaterThanThree(list);
                    
                    break;
                case 4:
                    Managment.CountofReviewForEachProductID(list);
                    break;
                case 5:
                    Managment.RetrieveProductIDWithReview(list);
                    break;
                case 6:
                    Managment.SkipTop5Records(list);
                    break;

 
            } 
            Console.ReadLine();
        }
    }
}