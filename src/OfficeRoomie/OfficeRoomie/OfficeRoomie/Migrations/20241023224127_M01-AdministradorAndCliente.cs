using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace OfficeRoomie.Migrations
{
    /// <inheritdoc />
    public partial class M01AdministradorAndCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    senha = table.Column<string>(type: "longtext", nullable: false),
                    cpf = table.Column<string>(type: "longtext", nullable: true),
                    permissoes = table.Column<string>(type: "longtext", nullable: true),
                    created_at = table.Column<string>(type: "longtext", nullable: true),
                    updated_at = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    cpf = table.Column<string>(type: "longtext", nullable: true),
                    endereco_logradouro = table.Column<string>(type: "longtext", nullable: true),
                    endereco_numero = table.Column<string>(type: "longtext", nullable: true),
                    endereco_complemento = table.Column<string>(type: "longtext", nullable: true),
                    endereco_cep = table.Column<string>(type: "longtext", nullable: true),
                    endereco_bairro = table.Column<string>(type: "longtext", nullable: true),
                    endereco_cidade = table.Column<string>(type: "longtext", nullable: true),
                    endereco_estado = table.Column<string>(type: "longtext", nullable: true),
                    endereco_pais = table.Column<string>(type: "longtext", nullable: true),
                    created_at = table.Column<string>(type: "longtext", nullable: true),
                    updated_at = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
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
