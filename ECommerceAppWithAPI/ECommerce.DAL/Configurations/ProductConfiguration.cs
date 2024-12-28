using ECommerce.Core.Entityes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasIndex(x => x.Name)
				.IsUnique();
			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(x => x.Description)
				.IsRequired()
				.HasMaxLength(256);
			builder.HasOne(x => x.Categories)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.CategoryId);
			builder.HasMany(x => x.Tags)
				.WithMany(x => x.Products);

		}
	}
}
