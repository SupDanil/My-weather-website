using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: false),
                    OrderDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerOfDevice = table.Column<string>(nullable: false),
                    TypeOfDevice = table.Column<string>(nullable: true),
                    ModelOfDevice = table.Column<string>(nullable: true),
                    ConditionOfDevice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    SurName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            //Filling the table Customers with values
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "1", "Josh", "12.10.19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "2", "Ivan", "30.11.20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "3", "Vladimir", "14.01.19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "4", "Boris", "7.11.19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "5", "Oleg", "8.08.20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "OrderDate" },
                values: new object[] { "6", "Alexey", "16.11.19" });

            //Filling the table Devices with values
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
                values: new object[] { "1", "Apple", "Phone", "5s", "Broken 3g module" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
                values: new object[] { "2", "Samsung", "Phone", "Galaxy5", "Broken screen" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
                values: new object[] { "3", "Apple", "Watch", "3", "Pedometer does not work" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
                values: new object[] { "4", "Xiaomi", "Phone", "Redmi note 8", "Broken battery" });

            migrationBuilder.InsertData(
               table: "Devices",
               columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
               values: new object[] { "5", "Huawei", "Tablet", "MatePad Pro", "Does not turn on" });

            migrationBuilder.InsertData(
               table: "Devices",
               columns: new[] { "Id", "ManufacturerOfDevice", "TypeOfDevice", "ModelOfDevice", "ConditionOfDevice" },
               values: new object[] { "6", "Blackberry", "Phone", "KeyOne 4", "Wifi module not working" });

            //Filling the table Managers with values
            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "1", "Peter", "Parker" });

            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "2", "Logan", "Wolvererine" });

            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "3", "Tony", "Stark" });

            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "4", "Bruce", "Banner" });

            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "5", "Stephen", "Strange" });

            migrationBuilder.InsertData(
               table: "Managers",
               columns: new[] { "Id", "Name", "SurName" },
               values: new object[] { "6", "Mighty", "Thor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
