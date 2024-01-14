using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.Web.Migrations
{
    public partial class UpdateSerialNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SerialNumber",
                table: "BookCopies",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR shared.SerialNumber",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR shared.Serial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<int>(
                name: "SerialNumber",
                table: "BookCopies",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR shared.Serial",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR shared.SerialNumber");
        }
    }
}
