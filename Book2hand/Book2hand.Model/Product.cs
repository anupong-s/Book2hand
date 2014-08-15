using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2hand.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int PublisherId { get; set; }

        public Category Category { get; set; }

        public Publisher Publisher { get; set; }


    }
}
