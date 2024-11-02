using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAcces.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAcces.EntityFrameworks.Configurations.ConfigClasses
{
	public class ParfumConfig : BaseConfig<Parfum>
	{
		public override void Configure(EntityTypeBuilder<Parfum> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Name)
				.HasColumnType("nvarchar(50)")
				.IsRequired();
			builder.Property(x => x.Description)
				.HasColumnType("ntext");
			builder.Property(x=>x.Price).IsRequired();

			builder.HasOne(x => x.Brand)
				.WithMany(x => x.Parfums)
				.HasForeignKey(x => x.BrandId);
		}
	}
}
