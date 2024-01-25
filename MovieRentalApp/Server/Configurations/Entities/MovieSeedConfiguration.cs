using Microsoft.EntityFrameworkCore;
using MovieRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieRentalApp.Server.Configurations.Entities
{
    public class MovieSeedConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                    Duration = 148, // Duration in minutes
                    Rating = "PG-13",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    RentalPrice = 2.99M,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System"
                    // Assuming 'Make' is a foreign key to another entity, you might not seed it here
                    // Rentals is a navigation property and is typically not seeded here
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Duration = 152, // Duration in minutes
                    Rating = "PG-13",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    RentalPrice = 2.99M,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System"
                    // Similar note about 'Make' and 'Rentals' as above
                }
            // Add as many movies as needed
            );
        }
    }
}