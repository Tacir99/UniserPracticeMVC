using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Classes
{
	public class ParfumOrder
	{
        public ParfumOrder()
        {
            Parfum = new Parfum();
            Order = new Order();
        }
        public int ParfumId { get; set; }
		public int OrderId { get; set; }
		public Parfum Parfum { get; set; }
		public Order Order { get; set; }
	}
}
