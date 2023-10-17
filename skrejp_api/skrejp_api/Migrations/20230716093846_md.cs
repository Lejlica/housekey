using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace skrejp_api.Migrations
{
    /// <inheritdoc />
    public partial class md : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "Slike",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "nekretninaID",
                table: "Slike",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Slike",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "naziv",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cijena",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Nekretnina",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "alarm",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "balkon",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "blindirana_vrata",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "broj_soba",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "datum_objave",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "detaljan_opis",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "garaza",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "godina_izgradnje",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "internet",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isKoristeno",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isNovogradnja",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kablovska_tv",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kanalizacija",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "klima",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "kvadratura",
                table: "Nekretnina",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kvadratura_balkona",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lift",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lokacija",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nedavno_adaptiran",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "opremljenost",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ostava_spajz",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parking",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primarna_orjentacija",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sprat",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "struja",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefonski_prikljucak",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tip_akcije",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tip_nekretnine",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uknjizeno_zk",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "video_nadzor",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "voda",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vrsta_grijanja",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vrsta_poda",
                table: "Nekretnina",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alarm",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "balkon",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "blindirana_vrata",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "broj_soba",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "datum_objave",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "detaljan_opis",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "garaza",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "godina_izgradnje",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "internet",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "isKoristeno",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "isNovogradnja",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "kablovska_tv",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "kanalizacija",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "klima",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "kvadratura",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "kvadratura_balkona",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "lift",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "lokacija",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "nedavno_adaptiran",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "opremljenost",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "ostava_spajz",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "parking",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "primarna_orjentacija",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "sprat",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "struja",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "telefonski_prikljucak",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "tip_akcije",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "tip_nekretnine",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "uknjizeno_zk",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "video_nadzor",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "voda",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "vrsta_grijanja",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "vrsta_poda",
                table: "Nekretnina");

            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "Slike",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "nekretninaID",
                table: "Slike",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Slike",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "naziv",
                table: "Nekretnina",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "cijena",
                table: "Nekretnina",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Nekretnina",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
