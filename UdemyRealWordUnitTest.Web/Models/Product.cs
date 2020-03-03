using System;
using System.Collections.Generic;

namespace UdemyRealWordUnitTest.Web.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string Color { get; set; }
    }
}
