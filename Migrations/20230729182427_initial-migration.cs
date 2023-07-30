using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Ontario.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDevelopers = table.Column<int>(type: "int", nullable: false),
                    CostOfTask = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstimatedTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CostOfTask", "Description", "EstimatedTime", "NumberOfDevelopers", "TaskCategory", "TaskName" },
                values: new object[,]
                {
                    { new Guid("40fa08df-dbe2-4da8-baaf-86737bd3fb4e"), 25m, "Download and Install Microsoft SQL Server Server Manager from Microsoft.com", 30, 1, "Back-End Development", "Install Microsoft SQL Server" },
                    { new Guid("b0b141b1-8ee7-4d1b-9703-077ea4f29dcb"), 22m, "Use Command-Line to intialize Mudblazor Components", 10, 2, "Front-End Development", "Inject MudBlazor Components" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTasks");
        }
    }
}
