using EPC.Core.Domain.Documents;
using EPC.Core.Domain.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EPC.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope().ServiceProvider
                 .GetRequiredService<AppDbContext>();


            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Documents.Any())
            {
                context.Documents.AddRange(
                    new Document
                    {
                        DocumentGuid = Guid.NewGuid(),
                        Title = "Certificate",
                        FileName = "Certificate Of Ownership",
                        Authority = "State Government",
                        Description = "a document attesting that something is true or someone is qualified, or " +
                            "proving debt or ownership, or, as a verb, to certify",
                        Licensor = "Land and Environmental ministry",
                        DateAdded = DateTime.UtcNow,
                        IsValid = true,
                        ExpiryDate = DateTime.UtcNow,
                        AutoRenew = true,
                        UserGuid = Guid.NewGuid(),
                        User = new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userone",
                            Email = "user1@epc.com",
                            EmailToRevalidate = "user1@epc",
                            AdminComment = "First User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Secretary",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    },
                    new Document
                    {
                        DocumentGuid = Guid.NewGuid(),
                        Title = "Contract",
                        FileName = "Contract Of Facility Construction",
                        Authority = "Local Government",
                        Description = "a document detailing an agreement, often enforceable by law, between " +
                            "people or parties, or the agreement itself, or, as a verb, to enter into an agreement; " +
                            "also, in criminal jargon, an arrangement to assassinate someone",
                        Licensor = "Ministry For Works and Environmental",
                        DateAdded = DateTime.UtcNow,
                        IsValid = true,
                        ExpiryDate = DateTime.UtcNow,
                        AutoRenew = true,
                        UserGuid = Guid.NewGuid(),
                        User = new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "usertwo",
                            Email = "user2@epc.com",
                            EmailToRevalidate = "user2@epc",
                            AdminComment = "Second User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Officer",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    },
                    new Document
                    {
                        DocumentGuid = Guid.NewGuid(),
                        Title = "Warrent",
                        FileName = "Warrant to Search Facility",
                        Authority = "Federal Government",
                        Description = "a document assigning authority to do or act, or, as a verb, to assure, declare, or guarantee",
                        Licensor = "Justice Department",
                        DateAdded = DateTime.UtcNow,
                        IsValid = true,
                        ExpiryDate = DateTime.UtcNow,
                        AutoRenew = true,
                        UserGuid = Guid.NewGuid(),
                        User = new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userthree",
                            Email = "user3@epc.com",
                            EmailToRevalidate = "user3@epc",
                            AdminComment = "Third User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Project Manager",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    },
                    new Document
                    {
                        DocumentGuid = Guid.NewGuid(),
                        Title = "Charter",
                        FileName = "Contract Of Logistics in Steel",
                        Authority = "Private Institution",
                        Description = "a written contract or instrument, or grant or guarantee, that defines conditions, privileges, " +
                            "or rights, or a lease of all or part of a vessel, or, as a verb, to confer such an agreement, or to offer" +
                            "for hire",
                        Licensor = "Ministry Logistics and Transportation",
                        DateAdded = DateTime.UtcNow,
                        IsValid = true,
                        ExpiryDate = DateTime.UtcNow,
                        AutoRenew = true,
                        UserGuid = Guid.NewGuid(),
                        User = new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userfour",
                            Email = "user4@epc.com",
                            EmailToRevalidate = "user4@epc",
                            AdminComment = "Fourth User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Product Designer",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    },
                    new Document
                    {
                        DocumentGuid = Guid.NewGuid(),
                        Title = "Bond",
                        FileName = "Bond Transferring Equity After Liquidation",
                        Authority = "Private Institution",
                        Description = "an agreement made binding by a payment of money if the agreement is not " +
                            "honored; also, an adhesive, restraining, or uniting element, force, or object, or, " +
                            "as a verb, to create such an effect",
                        Licensor = "Ministry Of Finance",
                        DateAdded = DateTime.UtcNow,
                        IsValid = true,
                        ExpiryDate = DateTime.UtcNow,
                        AutoRenew = true,
                        UserGuid = Guid.NewGuid(),
                        User = new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userfive",
                            Email = "user5@epc.com",
                            EmailToRevalidate = "user5@epc",
                            AdminComment = "Fifth User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Logistician",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null // (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    }
                );

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userone",
                            Email = "user1@epc.com",
                            EmailToRevalidate = "user1@epc",
                            AdminComment = "First User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Secretary",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        },
                        new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "usertwo",
                            Email = "user2@epc.com",
                            EmailToRevalidate = "user2@epc",
                            AdminComment = "Second User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Officer",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        },
                        new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userthree",
                            Email = "user3@epc.com",
                            EmailToRevalidate = "user3@epc",
                            AdminComment = "Third User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Project Manager",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        },
                        new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userfour",
                            Email = "user4@epc.com",
                            EmailToRevalidate = "user4@epc",
                            AdminComment = "Fourth User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Product Designer",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        },
                        new User
                        {
                            UserGuid = Guid.NewGuid(),
                            Username = "userfive",
                            Email = "user5@epc.com",
                            EmailToRevalidate = "user5@epc",
                            AdminComment = "Fifth User",
                            RequireReLogin = true,
                            FailedLoginAttempts = 4,
                            Active = true,
                            Deleted = false,
                            IsAdmin = true,
                            AdminRole = "Logistician",
                            LastIpAddress = "123456789",
                            ShippingAddressId = 1,
                            BillingAddressId = 2,
                            Documents = null //  (ICollection<Document>)new List<string>() { "License", "Certificate", "Endorsement" }
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}