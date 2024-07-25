using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeStewart.MyWorkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompletedBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "BracketExercises",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "BracketExercises");
        }
    }
}
