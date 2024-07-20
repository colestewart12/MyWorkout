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

            migrationBuilder.DropTable(
                name: "WorkoutSets");

            migrationBuilder.DropIndex(
                name: "IX_SetExercises_ExerciseId",
                table: "SetExercises");

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

            migrationBuilder.CreateTable(
                name: "Brackets",
                columns: table => new
                {
                    BracketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracketName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brackets", x => x.BracketId);
                    table.ForeignKey(
                        name: "FK_Brackets_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brackets_WorkoutId",
                table: "Brackets",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetExercises_Brackets_BracketId",
                table: "SetExercises",
                column: "BracketId",
                principalTable: "Brackets",
                principalColumn: "BracketId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetExercises_Brackets_BracketId",
                table: "SetExercises");

            migrationBuilder.DropTable(
                name: "Brackets");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "SetExercises");

            migrationBuilder.RenameColumn(
                name: "BracketId",
                table: "SetExercises",
                newName: "WorkoutSetId");

            migrationBuilder.RenameIndex(
                name: "IX_SetExercises_BracketId",
                table: "SetExercises",
                newName: "IX_SetExercises_WorkoutSetId");

            migrationBuilder.CreateTable(
                name: "WorkoutSets",
                columns: table => new
                {
                    WorkoutSetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSets", x => x.WorkoutSetId);
                    table.ForeignKey(
                        name: "FK_WorkoutSets_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SetExercises_ExerciseId",
                table: "SetExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSets_WorkoutId",
                table: "WorkoutSets",
                column: "WorkoutId");

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
