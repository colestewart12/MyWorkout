using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeStewart.MyWorkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class BracketNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetExercises_WorkoutSets_WorkoutSetId",
                table: "SetExercises");

            migrationBuilder.DropIndex(
                name: "IX_SetExercises_WorkoutSetId",
                table: "SetExercises");

            migrationBuilder.RenameColumn(
                name: "WorkoutName",
                table: "WorkoutSets",
                newName: "BracketName");

            migrationBuilder.RenameColumn(
                name: "WorkoutSetId",
                table: "WorkoutSets",
                newName: "BracketId");

            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "SetExercises",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SetExercises_BracketId",
                table: "SetExercises",
                column: "BracketId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetExercises_WorkoutSets_BracketId",
                table: "SetExercises",
                column: "BracketId",
                principalTable: "WorkoutSets",
                principalColumn: "BracketId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetExercises_WorkoutSets_BracketId",
                table: "SetExercises");

            migrationBuilder.DropIndex(
                name: "IX_SetExercises_BracketId",
                table: "SetExercises");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "SetExercises");

            migrationBuilder.RenameColumn(
                name: "BracketName",
                table: "WorkoutSets",
                newName: "WorkoutName");

            migrationBuilder.RenameColumn(
                name: "BracketId",
                table: "WorkoutSets",
                newName: "WorkoutSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SetExercises_WorkoutSetId",
                table: "SetExercises",
                column: "WorkoutSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetExercises_WorkoutSets_WorkoutSetId",
                table: "SetExercises",
                column: "WorkoutSetId",
                principalTable: "WorkoutSets",
                principalColumn: "WorkoutSetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
