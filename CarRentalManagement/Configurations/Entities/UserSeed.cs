using CarRentalManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<CarRentalManagementUser>
    {
        public void Configure(EntityTypeBuilder<CarRentalManagementUser> builder)
        {
            var hasher = new PasswordHasher<CarRentalManagementUser>();
            builder.HasData(
                new CarRentalManagementUser
                {
                    Id = "f6d7659b-41aa-4bd6-bbe4-568adef28cd4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                }
                );
        }
    }
}
