using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace skrejp_api.Migrations
{
    /// <inheritdoc />
    public partial class slovoSlika : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slike_Nekretnina_NekretninaID",
                table: "Slike");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Slike",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "NekretninaID",
                table: "Slike",
                newName: "nekretninaID");

            migrationBuilder.RenameIndex(
                name: "IX_Slike_NekretninaID",
                table: "Slike",
                newName: "IX_Slike_nekretninaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slike_Nekretnina_nekretninaID",
                table: "Slike",
                column: "nekretninaID",
                principalTable: "Nekretnina",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slike_Nekretnina_nekretninaID",
                table: "Slike");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Slike",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "nekretninaID",
                table: "Slike",
                newName: "NekretninaID");

            migrationBuilder.RenameIndex(
                name: "IX_Slike_nekretninaID",
                table: "Slike",
                newName: "IX_Slike_NekretninaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slike_Nekretnina_NekretninaID",
                table: "Slike",
                column: "NekretninaID",
                principalTable: "Nekretnina",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
