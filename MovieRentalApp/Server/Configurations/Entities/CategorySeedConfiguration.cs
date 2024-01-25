using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRentalApp.Shared.Domain;

namespace MovieRentalApp.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryID = 1,
                    Name = "Action",
                    LastUpdated = DateTime.UtcNow // Using UTC time is usually a good practice for consistency
                },
                new Category
                {
                    CategoryID = 2,
                    Name = "Comedy",
                    LastUpdated = DateTime.UtcNow
                },
                new Category
                {
                    CategoryID = 3,
                    Name = "Drama",
                    LastUpdated = DateTime.UtcNow
                }
                // Add as many categories as needed
            );
        }
    }
}