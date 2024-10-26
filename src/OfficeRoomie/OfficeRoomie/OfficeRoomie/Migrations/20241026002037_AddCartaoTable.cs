using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeRoomie.Migrations
{
    /// <inheritdoc />
    public partial class AddCartaoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cartoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numeroDoCartao = table.Column<string>(type: "TEXT", nullable: false),
                    nomeDoTitular = table.Column<string>(type: "TEXT", nullable: false),
                    validade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cvv = table.Column<int>(type: "INTEGER", nullable: false),
                    idUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartoes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartoes");
        }
    }
}
