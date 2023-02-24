namespace ProductReviwLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management System");
            List<ProductReview> list = Managment.Reviews();

            Console.WriteLine("1.Create a Product Review List\n2.Top Three Records\n3.Rating Greater than Thre");
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
 
            } 
            Console.ReadLine();
        }
    }
}