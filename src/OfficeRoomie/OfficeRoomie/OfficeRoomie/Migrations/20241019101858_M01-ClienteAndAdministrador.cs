using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeRoomie.Migrations
{
    /// <inheritdoc />
    public partial class M01ClienteAndAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permissoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
