using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroCarrosdosAlunosIF.Migrations
{
    /// <inheritdoc />
    public partial class Cadastros_IF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    Prontuário = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Período = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.Prontuário);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_CNH",
                table: "Cadastros",
                column: "CNH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_Email",
                table: "Cadastros",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_Placa",
                table: "Cadastros",
                column: "Placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_Telefone",
                table: "Cadastros",
                column: "Telefone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");
        }
    }
}
