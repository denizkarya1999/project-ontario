using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.Ontario.Models
{
    public class AppDBContext : DbContext
    {
        //Function responsible for managing dbContext
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        //Create datasets
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        //Make connections and seed the data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Generate new Id
            var IdOne = Guid.NewGuid();
            var IdTwo = Guid.NewGuid();

            //Add new sample project task
            ProjectTask ServerInstallation = new ProjectTask() {
                Id = IdOne,
                TaskName = "Install Microsoft SQL Server",
                Description = "Download and Install Microsoft SQL Server Server Manager from Microsoft.com",
                TaskCategory = "Back-End Development",
                NumberOfDevelopers = 1,
                CostOfTask = 25,
                EstimatedTime = 30
            };

            modelBuilder.Entity<ProjectTask>().HasData(ServerInstallation);

           //Add another sample task
           ProjectTask MudBlazor = new ProjectTask()
            {
                Id = IdTwo,
                TaskName = "Inject MudBlazor Components",
                Description = "Use Command-Line to intialize Mudblazor Components",
                TaskCategory = "Front-End Development",
                NumberOfDevelopers = 2,
                CostOfTask = 22,
               EstimatedTime = 10
        };

            //Add entity into ProjectTask class
            modelBuilder.Entity<ProjectTask>().HasData(MudBlazor);
        }
    }
}
