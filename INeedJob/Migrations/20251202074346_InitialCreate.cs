using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INeedJob.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    Industry = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateApplied = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Connections = table.Column<string>(type: "TEXT", nullable: false),
                    HasCoverLetter = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasResumeForm = table.Column<bool>(type: "INTEGER", nullable: false),
                    SalaryRange = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    LatestContactName = table.Column<string>(type: "TEXT", nullable: false),
                    AppliedLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplications");
        }
    }
}
