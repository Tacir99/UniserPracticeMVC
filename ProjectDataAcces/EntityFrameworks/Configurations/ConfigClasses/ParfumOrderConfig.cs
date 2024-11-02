using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectEntity.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAcces.EntityFrameworks.Configurations.ConfigClasses
{
	public class ParfumOrderConfig : IEntityTypeConfiguration<ParfumOrder>
	{
		public void Configure(EntityTypeBuilder<ParfumOrder> builder)
		{
			builder.HasKey(x => new { x.OrderId, x.ParfumId });

			builder.HasOne(x => x.Order)
				.WithMany(x => x.ParfumOrders)
				.HasForeignKey(x => x.OrderId);
			builder.HasOne(x => x.Parfum)
				.WithMany(x => x.ParfumOrders)
				.HasForeignKey(x => x.ParfumId);
		}
	}
}
