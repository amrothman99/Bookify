using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.Web.Migrations
{
    public partial class UpdateSequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "Serial",
                schema: "shared",
                startValue: 1000001L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "Serial",
                schema: "shared");

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
    }
}
