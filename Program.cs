// See https://aka.ms/new-console-template for more information
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Reflection.Metadata;
using Document = QuestPDF.Fluent.Document;

Console.WriteLine("QuestPDF Started...");

QuestPDF.Settings.License = LicenseType.Community;
QuestPDF.Settings.EnableDebugging = true;

var document = Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(1, Unit.Centimetre);
        page.PageColor(QuestPDF.Helpers.Colors.White);
        page.DefaultTextStyle(x => x.FontSize(20));

        page.Background()
        .AlignCenter()
        .AlignMiddle()
        .ShowEntire()
        .Height(250)
        .Width(250)
        .Image("logo_Background.png");


        page.Header()
        .Height(100)
        .ShowOnce()
        .ScaleToFit()
        .PaddingHorizontal(0)
        .Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.RelativeColumn();
                columns.RelativeColumn();
            });

            table.Cell().Row(1)
            .Column(1)
            .AlignLeft()
            .Height(50)
            .Width(50)
            .Image("logo.png");

            table.Cell()
            .Row(1)
            .Column(2)
            .Column(r =>
            {
                r.Item()
                .AlignTop()
                .AlignRight()
                .Text("Dr. Swapnil Gaikwad");

                r.Item()
                .AlignTop()
                .AlignRight()
                .Text("Pune, Maharashtra, India");
            });

            table.Cell()
            .Row(2)
            .ColumnSpan(2)
            .PaddingVertical(5)
            .LineHorizontal(1)
            .LineColor(Colors.Grey.Medium);
        });


        page.Content()
            .PaddingVertical(1, Unit.Mil)
            .Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Cell()
                .Row(1)
                .Column(1)
                .AlignTop()
                .AlignLeft()
                .Padding(0)
                .Text("Patient Name")
                .SemiBold()
                .FontSize(15);


                table.Cell()
                .Row(1)
                .Column(2)
                .AlignMiddle()
                .Row(c =>
                {
                    c.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);

                    c.AutoItem()
                    .AlignTop()
                    .AlignLeft()
                    .Text("Anil ")
                    .FontSize(15);
                });

                table.Cell()
                .Row(1)
                .Column(3)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Visit Date")
                    .SemiBold()
                    .FontSize(15);

                    r.AutoItem().AlignTop()
                    .AlignRight()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);
                });



                table.Cell()
                .Row(1)
                .Column(4)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Jan,13 2024")
                    .FontSize(15);
                });

                table.Cell()
                .Row(2)
                .Column(1)
                .AlignTop()
                .AlignLeft()
                .Text("Address")
                .SemiBold()
                .FontSize(15);

                table.Cell()
                .Row(2)
                .Column(2)
                .PaddingHorizontal(0)
                .AlignMiddle()
                .Row(c =>
                {
                    c.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);

                    c.AutoItem()
                    .AlignTop()
                    .AlignLeft()
                    .Text("India")
                    .FontSize(15);
                });

                table.Cell()
                .Row(2)
                .Column(3)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Age")
                    .SemiBold()
                    .FontSize(15);

                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);
                });

                table.Cell()
                .Row(2)
                .Column(4)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("26")
                    .FontSize(15);
                });


                table.Cell()
                .Row(3)
                .Column(1)
                .AlignTop()
                .AlignLeft()
                .Text("Contact")
                .SemiBold()
                .FontSize(15);


                table.Cell()
                .Row(3)
                .Column(2)
                .AlignMiddle()
                .PaddingHorizontal(0)
                .Row(c =>
                {
                    c.AutoItem()
                    .AlignTop()
                    .AlignLeft()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);

                    c.AutoItem()
                    .AlignTop()
                    .AlignLeft()
                    .Text("+91 1234567890")
                    .FontSize(15);
                });

                table.Cell()
                .Row(3)
                .Column(3)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Sex")
                    .SemiBold()
                    .FontSize(15);

                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .PaddingHorizontal(5)
                    .Text(":")
                    .SemiBold()
                    .FontSize(15);
                });

                table.Cell()
                .Row(3)
                .Column(4)
                .AlignRight()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Male")
                    .FontSize(15);
                });

                table.Cell()
                .Row(4)
                .ColumnSpan(4)
                .PaddingVertical(5)
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Medium);

                table.Cell()
                .Row(5)
                .ColumnSpan(4)
                .Height(50)
                .Background(Colors.Grey.Lighten3)
                .Row(row =>
                {
                    row.Spacing(10);

                    row.RelativeItem(2)
                    .PaddingVertical(10)
                    .Text("Medicine Name")
                    .SemiBold()
                    .FontSize(15);

                    row.ConstantItem(120)
                    .PaddingVertical(10)
                    .ExtendVertical()
                    .Text("Mor-Non-Night")
                    .SemiBold()
                    .FontSize(15);

                    row.ConstantItem(70)
                    .PaddingVertical(10)
                    .Text("Duration")
                    .SemiBold()
                    .FontSize(15);

                    row.ConstantItem(40)
                    .PaddingVertical(10)
                    .Text("Qty")
                    .SemiBold()
                    .FontSize(15);

                });

                table.Cell()
                .Row(6)
                .ColumnSpan(4)
                .PaddingVertical(5)
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Medium);

                table.Cell()
               .Row(7)
               .ColumnSpan(4)
               .Row(row =>
               {
                   row.Spacing(10);

                   row.RelativeItem(2)
                   .PaddingVertical(5)
                   .Column(c =>
                   {
                       c.Item()
                       .Text("Omi 1 D Capsule")
                       .FontSize(12);

                       c.Item()
                       .Text("Composition: Domperidone (10mg) + Omeprazole (20mg)")
                       .FontSize(10);
                   });

                   row.ConstantItem(120)
                   .PaddingVertical(5)
                   .Text("1 - 1 - 1 - After Meal")
                   .FontSize(12);

                   row.ConstantItem(70)
                   .PaddingVertical(5)
                   .Text("1 days")
                   .FontSize(12);

                   row.ConstantItem(40)
                   .PaddingVertical(5)
                   .Text("3")
                   .FontSize(12);

               });

                table.Cell()
                .Row(8)
                .ColumnSpan(4)
                .AlignTop()
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Medium);

            });

        page.Footer()
            .AlignBottom()
            .AlignLeft()
            .ShowIf(x =>
            {
                return x.TotalPages == x.PageNumber ? true : false;
            })
            .Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Cell()
                .Row(1)
                .Column(1)
                .AlignLeft()
                .Row(r =>
                {
                    r.AutoItem()
                    .AlignTop()
                    .AlignRight()
                    .Text("Thank you,")
                    .FontSize(15);
                });

                table.Cell().Row(1)
                .Column(2)
                .AlignBottom()
                .AlignRight()
                .Column(r =>
                {

                    r.Item()
                    .AlignBottom()
                    .AlignRight()
                    .Text("----------------------")
                    .FontSize(12);

                    r.Item()
                    .AlignTop()
                    .AlignRight()
                    .Text("Signature    ")
                    .FontSize(15);
                });

                table.Cell().Row(2).Column(1).ColumnSpan(2)
                .AlignCenter()
                .Row(r =>
                {
                    r.AutoItem()
                    .Text("Powered by   ")
                    .FontColor(Colors.Black)
                    .FontSize(14);

                    r.AutoItem()
                    .AlignMiddle()
                    .Height(15)
                    .Width(15)
                    .Image("logo.png");

                    r.AutoItem()
                    .Text(" CMS")
                    .FontColor(Colors.Green.Lighten1)
                    .FontSize(14);
                });
            });
    });
});
document.GeneratePdf("Sample.pdf");
document.ShowInPreviewer();