using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gestion_commandes.Migrations
{
    /// <inheritdoc />
    public partial class ClientCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Utilisateurs",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "adresse",
                table: "Utilisateurs",
                newName: "Adresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Utilisateurs",
                newName: "telephone");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Utilisateurs",
                newName: "adresse");
        }
    }
}
