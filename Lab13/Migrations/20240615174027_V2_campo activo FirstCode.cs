using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab13.Migrations
{
    /// <inheritdoc />
    public partial class V2_campoactivoFirstCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "activo",
                table: "Customers");
        }
    }
}
