using ProjectEntity.Concrete.Common;

namespace ProjectEntity.Concrete.Classes
{
	public class Parfum : BaseEntity
	{
		public Parfum()
		{
			ParfumOrders = new HashSet<ParfumOrder>();
			Brand = new Brand();
		}
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public double Price { get; set; }
		public int StockCount { get; set; }
		public int BrandId { get; set; }
		public Brand Brand { get; set; }
		public ICollection<ParfumOrder> ParfumOrders { get; set; }

	}
}
