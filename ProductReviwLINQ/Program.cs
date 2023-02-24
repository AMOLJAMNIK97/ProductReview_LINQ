namespace ProductReviwLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management System");
            List<ProductReview> list = Managment.Reviews();
            Managment.DisplayeProductsReview(list);
            Console.ReadLine();
        }
    }
}