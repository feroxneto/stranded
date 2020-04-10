using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System;
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
            SeedNotification(context);
            SeedCountryCIty(context);
            //SeedInstitution(context); 
            await SeedDefaultUserAsync(userManager); 

            context.SaveChanges();
        }

        #region --- SeedMethods ---

        private static void SeedInstitution(ApplicationDbContext context)
        {

            //// Seed, if necessary
            if (!context.Institution.Any())
            {

                long SAId = 0;
                long AOId = 0; 
                long PTId = 0;
                long BRId = 0; 
                long MZId = 0;
                IList<Country> countries = context.Country.ToList();
                foreach (var item in countries)
                {
                    switch (item.Name) {
                        case "África do Sul": { SAId = item.Id; break; }
                        case "Angola": { AOId = item.Id; break; }
                        case "Brasil": { PTId = item.Id; break; }
                        case "Moçambique": {  MZId= item.Id; break; }
                        case "Portugal": { BRId = item.Id; break; }
                    }
                }
                Institution[] institutions =
                {  

                    new Institution { Name = "Embaixada de Portugal em Luanda", CountryId = AOId, IsActive = true },
                    new Institution { Name = "Embaixada de Moçambique em Angola", CountryId = MZId, IsActive = true },
                    new Institution { Name = "Embaixada de do Brasil em Angola", CountryId = BRId, IsActive = true },
                    new Institution { Name = "Consulado de Angola em Cape Town", CountryId = SAId, IsActive = true }
                };
                context.Institution.AddRange(institutions);
            }
        }

        private static void SeedCountryCIty(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Country.Any())
            {
                List<Country> countries = new List<Country>();
                countries.Add(new Country
                {
                    Name = "África do Sul",
                    CityList =
                        {
                            new City { Name = "Johannesburg",  IsActive = true },
                            new City { Name = "Pretoria",  IsActive = true },
                            new City { Name = "Durban",  IsActive = true },
                            new City { Name = "Cape Town",  IsActive = true },
                            new City { Name = "Kimberly",  IsActive = true },
                            new City { Name = "Porth Elizabeth",  IsActive = true }
                        }
                });
                countries.Add(new Country
                {
                    Name = "Angola",
                    CityList =
                        {
                            new City { Name = "Caxito",  IsActive = true },
                            new City { Name = "Benguela",  IsActive = true },
                            new City { Name = "Kuito",  IsActive = true },
                            new City { Name = "Cabinda",  IsActive = true },
                            new City { Name = "Menonge",  IsActive = true },
                            new City { Name = "N'dalatando",  IsActive = true },
                            new City { Name = "Sumbe",  IsActive = true },
                            new City { Name = "Ondjiva",  IsActive = true },
                            new City { Name = "Huambo",  IsActive = true },
                            new City { Name = "Kilamba",  IsActive = false },
                            new City { Name = "Lubango",  IsActive = true },
                            new City { Name = "Dundo",  IsActive = true },
                            new City { Name = "Saurimo",  IsActive = true },
                            new City { Name = "Malange",  IsActive = true },
                            new City { Name = "Luena",  IsActive = true },
                            new City { Name = "Moaçamedes",  IsActive = true },
                            new City { Name = "Uíge",  IsActive = true },
                            new City { Name = "Mbanza Congo",  IsActive = true },
                            new City { Name = "Lobito",  IsActive = true },
                            new City { Name = "Andulo",  IsActive = true },
                        }
                });
                countries.Add(new Country
                {
                    Name = "Brasil",
                    CityList =
                        {
                            new City { Name = "São Paulo",  IsActive = true },
                            new City { Name = "Rio de Janeiro",  IsActive = true },
                            new City { Name = "Brasilia",  IsActive = true },
                            new City { Name = "Bahia",  IsActive = true },
                            new City { Name = "Belo Horizonte",  IsActive = true },
                            new City { Name = "Mato Grosso",  IsActive = true }
                        }
                });
                countries.Add(new Country
                {
                    Name = "Moçambique",
                    CityList =
                        {
                            new City { Name = "Maputo",  IsActive = true },
                            new City { Name = "Gaza",  IsActive = true },
                            new City { Name = "Niassa",  IsActive = true },
                            new City { Name = "Cabo Delgado",  IsActive = true },
                            new City { Name = "Nampula",  IsActive = true }
                        }
                });
                countries.Add(new Country
                {
                    Name = "Portugal",
                    CityList =
                        {
                            new City { Name = "Lisboa",  IsActive = true },
                            new City { Name = "Porto",  IsActive = true }
                        }
                });

                context.Country.AddRange(countries);

            }

        }
        private static void SeedNotification(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Notification.Any())
            {
                Notification[] notifications =
                {
                    new Notification { Title = "Closing Airspace", Message = "The Angolans borader and air space will be clsoed from midnight friday the 20th of march for a period of 2 weeks.", PublishedDate = new DateTime(2020,03,18), IsActive = true },
                    new Notification { Title = "Grace Flights", Message = "The Angolan goverment will realised 2 grace flights in the next 24 hours in order to go and get the Angolan citizens stranded in Portugal", PublishedDate = new DateTime(2020,03,20), IsActive = true },
                    new Notification { Title = "Estado de Emergência", Message ="The Angolam goverment declases State of Emergency from midnight friday 27th of March 2020 for a period of 15 days.", PublishedDate = new DateTime(2020,03,25),  IsActive = true },
                    new Notification { Title = "Porrogação do estado de Emergência", Message ="The Angolan goverment anounces that the lockdown period will be extended for a period of 15 days from 11th May 2020" , PublishedDate = new DateTime(2020,03,25),  IsActive = true }
                };
                context.Notification.AddRange(notifications);
            }
        }
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
            if (!context.VisitPurpose.Any())
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
