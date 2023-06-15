using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


try
{
    byte[] geoPerformLogo = File.ReadAllBytes("GeoPerformanceLogo.png");
    byte[] exxonMobilLogo = File.ReadAllBytes("ExxonMobil.png");
    void ComposeTable(IContainer container)
    {
        container
            .Table(table =>
            {
                IContainer DefaultCellStyle(IContainer container, string backgroundColor)
                {
                    return container
                        .Border(1)

                        .Background(backgroundColor)
                        .PaddingVertical(5)
                        .PaddingHorizontal(10)
                        .AlignCenter()
                        .AlignMiddle()

                        ;
                }
                IContainer RotatedCellStyle(IContainer container, string backgroundColor)
                {
                    return container.Border(1)
                    .RotateLeft()


                        .Background(backgroundColor)
                        .PaddingVertical(5)
                        .PaddingHorizontal(10)
                        .AlignCenter()
                        .AlignMiddle();
                }

                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();

                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().ColumnSpan(6).Element(CellStyle).Text("Voyage 1: Ballast Passage (Antwerp to Gibraltar");
                    header.Cell().ColumnSpan(20).Element(CellStyle).Text(" ");


                    //header.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().Text("Report");
                    //header.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().Text("Date/Time");

                    header.Cell().RowSpan(3).Element(CellStyle).Text("Report");
                    header.Cell().RowSpan(3).Element(CellStyle).Text("Date/Time");
                    header.Cell().RowSpan(3).Element(CellStyleRotated).Text("Hours");
                    header.Cell().RowSpan(3).Element(CellStyleRotated).Text("Distance");
                    header.Cell().RowSpan(3).Element(CellStyleRotated).Text("Sog");
                    header.Cell().RowSpan(3).Element(CellStyle).Text("Ordered Speed");
                    header.Cell().ColumnSpan(3).Element(CellStyle).Text("ROB");

                    header.Cell().ColumnSpan(5).Element(CellStyle).Text("Consumptions");
                    header.Cell().ColumnSpan(4).Element(CellStyle).Text("Engine Parameters");
                    header.Cell().ColumnSpan(3).Element(CellStyle).Text("Wind BF");
                    header.Cell().ColumnSpan(3).Element(CellStyle).Text("Waves DSS");
                    header.Cell().RowSpan(3).Element(CellStyle).Text("Effective Current Kts");
                    header.Cell().RowSpan(3).Element(CellStyle).Text("Conditions");

                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("LSMGO");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("VLSFO");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("HFO");

                    header.Cell().ColumnSpan(2).Element(CellStyleRotated).Text("ME");
                    header.Cell().ColumnSpan(2).Element(CellStyleRotated).Text("AUX");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Others");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("RPM");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Slip");

                    header.Cell().RowSpan(2).Element(CellStyle).Text("Shaft Power");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Fuel Rate");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Reported");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Analysed");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Difference");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Reported");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Analysed");
                    header.Cell().RowSpan(2).Element(CellStyleRotated).Text("Difference");

                    header.Cell().Element(CellStyle).Text("FO");
                    header.Cell().Element(CellStyle).Text("GO");
                    header.Cell().Element(CellStyle).Text("FO");
                    header.Cell().Element(CellStyle).Text("GO");
                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                    IContainer CellStyleRotated(IContainer container) => RotatedCellStyle(container, Colors.Grey.Lighten3);
                });

                for (var i = 0; i <= 828; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }

                //foreach (var page in pageSizes)
                //{
                //    table.Cell().Element(CellStyle).ExtendHorizontal().AlignLeft().Text(page.name);
                //    table.Cell().Element(CellStyle).Text("2");
                //    // inches
                //    table.Cell().Element(CellStyle).Text(page.width);
                //    table.Cell().Element(CellStyle).Text(page.height);

                //    // points
                //    table.Cell().Element(CellStyle).Text(page.width * inchesToPoints);
                //    table.Cell().Element(CellStyle).Text(page.height * inchesToPoints);

                //    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                //}

            });

    }
    void ComposeHeading(IContainer container)
    {
        container.Text("AT SEA PERFORMANCE DETAILS");
    }
    Document.Create(document =>
    {
        for (int pageIndex = 1; pageIndex <= 30; pageIndex++)
        {
            document.Page(page =>
            {

            page.Size(PageSizes.A3.Landscape());
            page.Margin(30);

            page.Header().Column(column =>
            {
                column.Item().Width(200).Image(exxonMobilLogo);
                //column.Item().ShowOnce().Background(Colors.Blue.Lighten2).Height(60);
                //column.Item().SkipOnce().Background(Colors.Green.Lighten2).Height(40);
            });

            page.Content().Padding(10).Column(column=>{
                column.Item().Element(ComposeHeading);
                column.Item().Element(ComposeTable);
                
            });

               
               
                page.Footer().Column(column =>
                {
                    column.Item().Width(300).Image(geoPerformLogo);
                    column.Item().AlignCenter().Text(text =>
                    {
                        text.DefaultTextStyle(x => x.Size(16));

                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });

                });
            });
        }
    })
    .GeneratePdf("Test2.pdf");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}
