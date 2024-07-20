using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeStewart.MyWorkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameBracketExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetExercises");

            migrationBuilder.CreateTable(
                name: "BracketExercises",
                columns: table => new
                {
                    BracketExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    BracketId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracketExercises", x => x.BracketExerciseId);
                    table.ForeignKey(
                        name: "FK_BracketExercises_Brackets_BracketId",
                        column: x => x.BracketId,
                        principalTable: "Brackets",
                        principalColumn: "BracketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BracketExercises_BracketId",
                table: "BracketExercises",
                column: "BracketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BracketExercises");

            migrationBuilder.CreateTable(
                name: "SetExercises",
                columns: table => new
                {
                    SetExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracketId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetExercises", x => x.SetExerciseId);
                    table.ForeignKey(
                        name: "FK_SetExercises_Brackets_BracketId",
                        column: x => x.BracketId,
                        principalTable: "Brackets",
                        principalColumn: "BracketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SetExercises_BracketId",
                table: "SetExercises",
                column: "BracketId");
        }
    }
}
