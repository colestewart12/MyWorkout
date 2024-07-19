using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeStewart.MyWorkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class Brackets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetExercises_Exercises_ExerciseId",
                table: "SetExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_SetExercises_WorkoutSets_WorkoutSetId",
                table: "SetExercises");

            migrationBuilder.DropIndex(
                name: "IX_SetExercises_ExerciseId",
                table: "SetExercises");

            migrationBuilder.RenameColumn(
                name: "WorkoutName",
                table: "WorkoutSets",
                newName: "BracketName");

            migrationBuilder.RenameColumn(
                name: "WorkoutSetId",
                table: "WorkoutSets",
                newName: "BracketId");

            migrationBuilder.RenameColumn(
                name: "WorkoutSetId",
                table: "SetExercises",
                newName: "BracketId");

            migrationBuilder.RenameIndex(
                name: "IX_SetExercises_WorkoutSetId",
                table: "SetExercises",
                newName: "IX_SetExercises_BracketId");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "SetExercises",
                type: "int",
                nullable: true);

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

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "SetExercises");

            migrationBuilder.RenameColumn(
                name: "BracketName",
                table: "WorkoutSets",
                newName: "WorkoutName");

            migrationBuilder.RenameColumn(
                name: "BracketId",
                table: "WorkoutSets",
                newName: "WorkoutSetId");

            migrationBuilder.RenameColumn(
                name: "BracketId",
                table: "SetExercises",
                newName: "WorkoutSetId");

            migrationBuilder.RenameIndex(
                name: "IX_SetExercises_BracketId",
                table: "SetExercises",
                newName: "IX_SetExercises_WorkoutSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SetExercises_ExerciseId",
                table: "SetExercises",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetExercises_Exercises_ExerciseId",
                table: "SetExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Restrict);

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
