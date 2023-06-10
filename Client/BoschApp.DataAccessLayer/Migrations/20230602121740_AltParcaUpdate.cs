using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoschApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AltParcaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AltParcas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AltParcas");
        }
    }
}
