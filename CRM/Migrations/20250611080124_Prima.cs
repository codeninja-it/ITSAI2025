using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class Prima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contatti",
                columns: table => new
                {
                    IdContatto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cognome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatti", x => x.IdContatto);
                });

            migrationBuilder.CreateTable(
                name: "progetti",
                columns: table => new
                {
                    IdProgetto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommittenteIdContatto = table.Column<int>(type: "INTEGER", nullable: false),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Perimetro = table.Column<string>(type: "TEXT", nullable: false),
                    Creazione = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_progetti", x => x.IdProgetto);
                    table.ForeignKey(
                        name: "FK_progetti_contatti_CommittenteIdContatto",
                        column: x => x.CommittenteIdContatto,
                        principalTable: "contatti",
                        principalColumn: "IdContatto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "messaggi",
                columns: table => new
                {
                    IdMessaggio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DaIdContatto = table.Column<int>(type: "INTEGER", nullable: false),
                    AIdContatto = table.Column<int>(type: "INTEGER", nullable: false),
                    Testo = table.Column<string>(type: "TEXT", nullable: false),
                    ProgettoIdProgetto = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaggi", x => x.IdMessaggio);
                    table.ForeignKey(
                        name: "FK_messaggi_contatti_AIdContatto",
                        column: x => x.AIdContatto,
                        principalTable: "contatti",
                        principalColumn: "IdContatto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messaggi_contatti_DaIdContatto",
                        column: x => x.DaIdContatto,
                        principalTable: "contatti",
                        principalColumn: "IdContatto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messaggi_progetti_ProgettoIdProgetto",
                        column: x => x.ProgettoIdProgetto,
                        principalTable: "progetti",
                        principalColumn: "IdProgetto");
                });

            migrationBuilder.CreateTable(
                name: "richieste",
                columns: table => new
                {
                    IdRichiesta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProgettoIdProgetto = table.Column<int>(type: "INTEGER", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: false),
                    Inserimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fatto = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_richieste", x => x.IdRichiesta);
                    table.ForeignKey(
                        name: "FK_richieste_progetti_ProgettoIdProgetto",
                        column: x => x.ProgettoIdProgetto,
                        principalTable: "progetti",
                        principalColumn: "IdProgetto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_messaggi_AIdContatto",
                table: "messaggi",
                column: "AIdContatto");

            migrationBuilder.CreateIndex(
                name: "IX_messaggi_DaIdContatto",
                table: "messaggi",
                column: "DaIdContatto");

            migrationBuilder.CreateIndex(
                name: "IX_messaggi_ProgettoIdProgetto",
                table: "messaggi",
                column: "ProgettoIdProgetto");

            migrationBuilder.CreateIndex(
                name: "IX_progetti_CommittenteIdContatto",
                table: "progetti",
                column: "CommittenteIdContatto");

            migrationBuilder.CreateIndex(
                name: "IX_richieste_ProgettoIdProgetto",
                table: "richieste",
                column: "ProgettoIdProgetto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messaggi");

            migrationBuilder.DropTable(
                name: "richieste");

            migrationBuilder.DropTable(
                name: "progetti");

            migrationBuilder.DropTable(
                name: "contatti");
        }
    }
}
