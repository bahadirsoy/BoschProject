using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoschApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Istasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Istasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Butce = table.Column<float>(type: "real", nullable: false),
                    AlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departmants_Alans_AlanId",
                        column: x => x.AlanId,
                        principalTable: "Alans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltParcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Masraf = table.Column<float>(type: "real", nullable: false),
                    IstasyonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltParcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltParcas_Istasyons_IstasyonId",
                        column: x => x.IstasyonId,
                        principalTable: "Istasyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kisims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KisimNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kisims_Departmants_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokAlanis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokAdeti = table.Column<int>(type: "int", nullable: false),
                    AltParcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokAlanis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokAlanis_AltParcas_AltParcaId",
                        column: x => x.AltParcaId,
                        principalTable: "AltParcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enjektors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KisimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enjektors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enjektors_Kisims_KisimId",
                        column: x => x.KisimId,
                        principalTable: "Kisims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnjektorAltParcas",
                columns: table => new
                {
                    EnjektorId = table.Column<int>(type: "int", nullable: false),
                    AltParcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnjektorAltParcas", x => new { x.EnjektorId, x.AltParcaId });
                    table.ForeignKey(
                        name: "FK_EnjektorAltParcas_AltParcas_AltParcaId",
                        column: x => x.AltParcaId,
                        principalTable: "AltParcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnjektorAltParcas_Enjektors_EnjektorId",
                        column: x => x.EnjektorId,
                        principalTable: "Enjektors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    SiparisDurumu = table.Column<int>(type: "int", nullable: false),
                    EnjektorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparises_Enjektors_EnjektorId",
                        column: x => x.EnjektorId,
                        principalTable: "Enjektors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uretims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimDurumu = table.Column<int>(type: "int", nullable: false),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    AltParcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uretims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uretims_AltParcas_AltParcaId",
                        column: x => x.AltParcaId,
                        principalTable: "AltParcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uretims_Siparises_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltParcas_IstasyonId",
                table: "AltParcas",
                column: "IstasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Departmants_AlanId",
                table: "Departmants",
                column: "AlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EnjektorAltParcas_AltParcaId",
                table: "EnjektorAltParcas",
                column: "AltParcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enjektors_KisimId",
                table: "Enjektors",
                column: "KisimId");

            migrationBuilder.CreateIndex(
                name: "IX_Kisims_DepartmanId",
                table: "Kisims",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparises_EnjektorId",
                table: "Siparises",
                column: "EnjektorId");

            migrationBuilder.CreateIndex(
                name: "IX_StokAlanis_AltParcaId",
                table: "StokAlanis",
                column: "AltParcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uretims_AltParcaId",
                table: "Uretims",
                column: "AltParcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uretims_SiparisId",
                table: "Uretims",
                column: "SiparisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnjektorAltParcas");

            migrationBuilder.DropTable(
                name: "StokAlanis");

            migrationBuilder.DropTable(
                name: "Uretims");

            migrationBuilder.DropTable(
                name: "AltParcas");

            migrationBuilder.DropTable(
                name: "Siparises");

            migrationBuilder.DropTable(
                name: "Istasyons");

            migrationBuilder.DropTable(
                name: "Enjektors");

            migrationBuilder.DropTable(
                name: "Kisims");

            migrationBuilder.DropTable(
                name: "Departmants");

            migrationBuilder.DropTable(
                name: "Alans");
        }
    }
}
