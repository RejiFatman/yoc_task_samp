using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Task.Migrations
{
    public partial class InsertDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Example: Insert data into a "Properties" table
            migrationBuilder.Sql(@"
                INSERT INTO Properties (Name, Address, PricePerMonth)
                VALUES 
                    ('Sunset Villa', '123 Main St', 1200),
                    ('Downtown Loft', '456 Center Ave', 1800),
                    ('Cozy Cottage', '789 Country Rd', 900)
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove inserted data (assuming Name is unique)
            migrationBuilder.Sql(@"
                DELETE FROM Properties
                WHERE Name IN ('Sunset Villa', 'Downtown Loft', 'Cozy Cottage')
            ");
        }
    }
}
