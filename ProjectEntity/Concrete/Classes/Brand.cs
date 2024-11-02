using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Classes
{
	public class Brand : BaseEntity
	{
        public Brand()
        {
            Parfums = new HashSet<Parfum>();
        }
        public string Name { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
        public ICollection<Parfum> Parfums { get; set; }
    }
}
