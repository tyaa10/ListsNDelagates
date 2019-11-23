using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal Price { get; set; }

        public override string ToString()
        {
            return $"Good(Id = {Id}, Title = {Title}, Price = {Price})";
        }
    }
}
