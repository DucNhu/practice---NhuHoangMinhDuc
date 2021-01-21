


using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace HummanResourcesManagement.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbcontext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDbcontext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.EnsureCreatedAsync();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        EmployeeFirstName = "Kayak5",
                        EmployeeLastName = "Kayak Kuye",
                        EmployeeEmail = "nothing1@gmail.com",
                        EmployeeAvatar = "imagesDefault.jpg"
                    },
                    new Employee
                    {
                        EmployeeFirstName = "Kayak4",
                        EmployeeLastName = "Kayak Kuye 2",
                        EmployeeEmail = "nothing2@gmail.com",
                        EmployeeAvatar = "imagesDefault.jpg"
                    },
                    new Employee
                    {
                        EmployeeFirstName = "Kayak3",
                        EmployeeLastName = "Kayak Kuye 3",
                        EmployeeEmail = "nothing3@gmail.com",
                        EmployeeAvatar = "imagesDefault.jpg"
                    },
                    new Employee
                    {
                        EmployeeFirstName = "Kayak2",
                        EmployeeLastName = "Kayak Kuye 4",
                        EmployeeEmail = "nothing4@gmail.com",
                        EmployeeAvatar = "imagesDefault.jpg"
                    },
                    new Employee
                    {
                        EmployeeFirstName = "Kayak1",
                        EmployeeLastName = "Kayak Kuye 5",
                        EmployeeEmail = "nothing5@gmail.com",
                        EmployeeAvatar = "imagesDefault.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
