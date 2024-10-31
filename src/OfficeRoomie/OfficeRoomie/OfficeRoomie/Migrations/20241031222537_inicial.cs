using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeRoomie.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    senha = table.Column<string>(type: "TEXT", nullable: false),
                    cpf = table.Column<string>(type: "TEXT", nullable: true),
                    permissoes = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cancelamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancelamentos", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    cpf = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_logradouro = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_numero = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_complemento = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_cep = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_bairro = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_cidade = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_estado = table.Column<string>(type: "TEXT", nullable: true),
                    endereco_pais = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "salas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    descricao = table.Column<string>(type: "TEXT", nullable: false),
                    capacidade = table.Column<string>(type: "TEXT", nullable: false),
                    categoria = table.Column<string>(type: "TEXT", nullable: false),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    hora_inicio = table.Column<string>(type: "TEXT", nullable: false),
                    hora_fim = table.Column<string>(type: "TEXT", nullable: false),
                    data_reserva = table.Column<string>(type: "TEXT", nullable: false),
                    protocolo = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    cliente_id = table.Column<int>(type: "INTEGER", nullable: false),
                    sala_id = table.Column<int>(type: "INTEGER", nullable: false),
                    cartão_id = table.Column<int>(type: "INTEGER", nullable: false),
                    clienteid = table.Column<int>(type: "INTEGER", nullable: true),
                    salaid = table.Column<int>(type: "INTEGER", nullable: true),
                    cartaoid = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.id);
                    table.ForeignKey(
                        name: "FK_reservas_cartoes_cartaoid",
                        column: x => x.cartaoid,
                        principalTable: "cartoes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_reservas_clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_reservas_salas_salaid",
                        column: x => x.salaid,
                        principalTable: "salas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservas_cartaoid",
                table: "reservas",
                column: "cartaoid");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_clienteid",
                table: "reservas",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_salaid",
                table: "reservas",
                column: "salaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "Cancelamentos");

            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "cartoes");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "salas");
        }
    }
}
