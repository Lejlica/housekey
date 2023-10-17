using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace skrejp_api.Migrations
{
    /// <inheritdoc />
    public partial class slova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naziv",
                table: "Nekretnina",
                newName: "naziv");

            migrationBuilder.RenameColumn(
                name: "Cijena",
                table: "Nekretnina",
                newName: "cijena");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "naziv",
                table: "Nekretnina",
                newName: "Naziv");

            migrationBuilder.RenameColumn(
                name: "cijena",
                table: "Nekretnina",
                newName: "Cijena");
        }
    }
}
