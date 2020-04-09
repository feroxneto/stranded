using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            //seed todo list
            SeedToDoList(context);
            SeedCitizenshipType(context);
            SeedDocumentType(context);
            SeedRelationship(context);
            SeedVisitPurpose(context);
            SeedStranded(context);
            SeedHealthStatus(context);
            await SeedDefaultUserAsync(userManager);


            context.SaveChanges();
        }

        #region --- SeedMethods ---

        private static void SeedHealthStatus(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.HealthStatus.Any())
            {
                HealthStatus[] healthStatuses =
                {
                    new HealthStatus { Name = "Lockdown", IsActive = true },
                    new HealthStatus { Name = "Quarentena", IsActive = true },
                    new HealthStatus { Name = "Testou Positivo", IsActive = true },
                    new HealthStatus { Name = "Falecido", IsActive = true }
                };
                context.HealthStatus.AddRange(healthStatuses);
            }
        }

        private static void SeedStranded(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Stranded.Any())
            {
                Stranded[] strandedList =
                {
                    new Stranded { Name = "Abrigo", IsActive = true },
                    new Stranded { Name = "Aeroporto", IsActive = true },
                    new Stranded { Name = "Hotel", IsActive = true },
                    new Stranded { Name = "Férias", IsActive = true },
                    new Stranded { Name = "Família ou Amigos", IsActive = true },
                    new Stranded { Name = "Centro de  Acolhimento", IsActive = true },
                    new Stranded { Name = "Others", IsActive = true }
                };
                context.Stranded.AddRange(strandedList);
            }
        }



        private static void SeedVisitPurpose(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Relationship.Any())
            {
                VisitPurpose[] visitPurposes =
                {
                    new VisitPurpose { Name = "Estudo", IsActive = true },
                    new VisitPurpose { Name = "Trabalho", IsActive = true },
                    new VisitPurpose { Name = "Férias", IsActive = true },
                    new VisitPurpose { Name = "Turismo", IsActive = true },
                    new VisitPurpose { Name = "Negócio", IsActive = true },
                    new VisitPurpose { Name = "Others", IsActive = true }
                };
                context.VisitPurpose.AddRange(visitPurposes);
            }
        }


        private static void SeedRelationship(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Relationship.Any())
            {
                Relationship[] relationships =
                {
                    new Relationship { Name = "Esposo(a)", IsActive = true },
                    new Relationship { Name = "Filho(a)", IsActive = true },
                    new Relationship { Name = "Pai/Mãe", IsActive = true },
                    new Relationship { Name = "Familía Extendida", IsActive = true },
                    new Relationship { Name = "Amigo(a)", IsActive = true },
                    new Relationship { Name = "Colega", IsActive = true }
                };
                context.Relationship.AddRange(relationships);
            }
        }

        private static void SeedDocumentType(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.DocumentType.Any())
            {
                DocumentType[] documentTypes =
                {
                    new DocumentType { Name = "Bilhete de Identidade", IsActive = true },
                    new DocumentType { Name = "Passaport", IsActive = true }
                };
                context.DocumentType.AddRange(documentTypes);
            }
        }
        private static void SeedCitizenshipType(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.CitizenshipType.Any())
            {
                CitizenshipType[] citizenshipTypes =
                {
                    new CitizenshipType { Name = "Cidadão Nacional", IsActive = true },
                    new CitizenshipType { Name = "Residente Permanente", IsActive = true }
                };
                context.CitizenshipType.AddRange(citizenshipTypes);
            }
        }
        private static void SeedToDoList(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.TodoLists.Any())
            {
                context.TodoLists.Add(new TodoList
                {
                    Title = "Shopping",
                    Items =
                    {
                        new TodoItem { Title = "Apples", Done = true },
                        new TodoItem { Title = "Milk", Done = true },
                        new TodoItem { Title = "Bread", Done = true },
                        new TodoItem { Title = "Toilet paper" },
                        new TodoItem { Title = "Pasta" },
                        new TodoItem { Title = "Tissues" },
                        new TodoItem { Title = "Tuna" },
                        new TodoItem { Title = "Water" }
                    }
                });
            }

        }

        private static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager)
        {
            // Create default administrator
            var defaultUser = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }
        }

        #endregion --- SeedMethods ---
    }
}
