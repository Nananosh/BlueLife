using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueLife.Migrations
{
    public partial class EditPharmacyWarehouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineName_MedicineNameId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineType_MedicineTypeId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineUnit_MedicineUnitId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineName_CatalogMedicine_CatalogMedicinesId",
                table: "MedicineName");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMedicine_Order_OrderId",
                table: "OrderMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMedicine_PharmacyWarehouses_PharmacyWarehouseId",
                table: "OrderMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyWarehouses_ReleaseMedicine_ReleaseMedicineId",
                table: "PharmacyWarehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseMedicine_Medicine_MedicineId",
                table: "ReleaseMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseMedicine_MedicineManufacturer_ManufacturerId",
                table: "ReleaseMedicine");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "ReleaseMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "ReleaseMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseMedicineId",
                table: "PharmacyWarehouses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRecipe",
                table: "PharmacyWarehouses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PharmacyWarehouseId",
                table: "OrderMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatalogMedicinesId",
                table: "MedicineName",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicineUnitId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicineTypeId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicineNameId",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineName_MedicineNameId",
                table: "Medicine",
                column: "MedicineNameId",
                principalTable: "MedicineName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineType_MedicineTypeId",
                table: "Medicine",
                column: "MedicineTypeId",
                principalTable: "MedicineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineUnit_MedicineUnitId",
                table: "Medicine",
                column: "MedicineUnitId",
                principalTable: "MedicineUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineName_CatalogMedicine_CatalogMedicinesId",
                table: "MedicineName",
                column: "CatalogMedicinesId",
                principalTable: "CatalogMedicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMedicine_Order_OrderId",
                table: "OrderMedicine",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMedicine_PharmacyWarehouses_PharmacyWarehouseId",
                table: "OrderMedicine",
                column: "PharmacyWarehouseId",
                principalTable: "PharmacyWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyWarehouses_ReleaseMedicine_ReleaseMedicineId",
                table: "PharmacyWarehouses",
                column: "ReleaseMedicineId",
                principalTable: "ReleaseMedicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseMedicine_Medicine_MedicineId",
                table: "ReleaseMedicine",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseMedicine_MedicineManufacturer_ManufacturerId",
                table: "ReleaseMedicine",
                column: "ManufacturerId",
                principalTable: "MedicineManufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineName_MedicineNameId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineType_MedicineTypeId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_MedicineUnit_MedicineUnitId",
                table: "Medicine");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineName_CatalogMedicine_CatalogMedicinesId",
                table: "MedicineName");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMedicine_Order_OrderId",
                table: "OrderMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMedicine_PharmacyWarehouses_PharmacyWarehouseId",
                table: "OrderMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyWarehouses_ReleaseMedicine_ReleaseMedicineId",
                table: "PharmacyWarehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseMedicine_Medicine_MedicineId",
                table: "ReleaseMedicine");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseMedicine_MedicineManufacturer_ManufacturerId",
                table: "ReleaseMedicine");

            migrationBuilder.DropColumn(
                name: "IsRecipe",
                table: "PharmacyWarehouses");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "ReleaseMedicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "ReleaseMedicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseMedicineId",
                table: "PharmacyWarehouses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PharmacyWarehouseId",
                table: "OrderMedicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderMedicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogMedicinesId",
                table: "MedicineName",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineUnitId",
                table: "Medicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineTypeId",
                table: "Medicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineNameId",
                table: "Medicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineName_MedicineNameId",
                table: "Medicine",
                column: "MedicineNameId",
                principalTable: "MedicineName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineType_MedicineTypeId",
                table: "Medicine",
                column: "MedicineTypeId",
                principalTable: "MedicineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_MedicineUnit_MedicineUnitId",
                table: "Medicine",
                column: "MedicineUnitId",
                principalTable: "MedicineUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineName_CatalogMedicine_CatalogMedicinesId",
                table: "MedicineName",
                column: "CatalogMedicinesId",
                principalTable: "CatalogMedicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMedicine_Order_OrderId",
                table: "OrderMedicine",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMedicine_PharmacyWarehouses_PharmacyWarehouseId",
                table: "OrderMedicine",
                column: "PharmacyWarehouseId",
                principalTable: "PharmacyWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyWarehouses_ReleaseMedicine_ReleaseMedicineId",
                table: "PharmacyWarehouses",
                column: "ReleaseMedicineId",
                principalTable: "ReleaseMedicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseMedicine_Medicine_MedicineId",
                table: "ReleaseMedicine",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseMedicine_MedicineManufacturer_ManufacturerId",
                table: "ReleaseMedicine",
                column: "ManufacturerId",
                principalTable: "MedicineManufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
