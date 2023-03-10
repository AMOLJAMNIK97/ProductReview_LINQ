using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviwLINQ
{
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }


        public override string ToString()
        {
            return $"ProductID: {ProductID}, UserID: {UserId}, Review: {Review}, IsLike: {IsLike}, Rating: {Rating}";
        }
    }
}
