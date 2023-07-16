using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    public partial class HasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CateId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "PubId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CateId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Cố Mạn" },
                    { 2, "Kim Dung" },
                    { 3, "Thiền sư Thích Nhất Hạnh" },
                    { 4, "Twentine" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateId", "CateName", "Description" },
                values: new object[,]
                {
                    { 1, "Sách Khoa học công nghệ", null },
                    { 2, "Sách Văn học nghệ thuật", null },
                    { 3, "Truyện ngôn tình", null },
                    { 4, "Truyện Kiếm Hiệp", null },
                    { 5, "Sách lịch sử", null }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PubId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Nhà xuất bản Kim Đồng" },
                    { 2, null, "Nhà xuất bản giáo dục" },
                    { 3, null, "Nhà xuất bản Hội Nhà văn" },
                    { 4, null, "Pan Macmillan UK" },
                    { 5, null, "Nhà xuất bản Trẻ" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CateId", "CreatedDate", "IsActive", "ModifiedDate", "Price", "PubId", "Quantity", "Summary", "Title", "imgUrl" },
                values: new object[,]
                {
                    { 1, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 100000m, 5, 10, null, "Yêu em từ cái nhìn đầu tiên", null },
                    { 2, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 100000m, 5, 9, null, "Em Là Niềm Kiêu Hãnh Của Anh", null },
                    { 3, 4, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 120000m, 5, 20, null, "Chiếc bật lửa và váy công chúa", null },
                    { 4, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 89000m, 5, 10, null, "Thiên long bát bộ", null },
                    { 5, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 59000m, 5, 16, null, "Anh Hùng Xạ Điêu", null },
                    { 6, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20000m, 5, 30, null, "Tiếu Ngạo Giang Hồ", null },
                    { 7, 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20000m, 3, 30, null, "An lạc từng bước chân", null },
                    { 8, 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20000m, 3, 30, null, "Bụt là hình hài bụt là tâm thức", null },
                    { 9, 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20000m, 3, 30, null, "Từng bước nở hoa sen", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CateId",
                table: "Books",
                column: "CateId",
                principalTable: "Categories",
                principalColumn: "CateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books",
                column: "PubId",
                principalTable: "Publishers",
                principalColumn: "PubId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CateId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "PubId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CateId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CateId",
                table: "Books",
                column: "CateId",
                principalTable: "Categories",
                principalColumn: "CateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books",
                column: "PubId",
                principalTable: "Publishers",
                principalColumn: "PubId");
        }
    }
}
