using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


try
{
    QuestPDF.Settings.DocumentLayoutExceptionThreshold = 1000;
    byte[] geoPerformLogo = File.ReadAllBytes("GeoPerformanceLogo.png");
    byte[] exxonMobilLogo = File.ReadAllBytes("ExxonMobil.png");
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
    IContainer Heading1(IContainer container,string text)
    {

        return (IContainer)container
         .Text(text)
            .FontSize(50)
            .ExtraBlack();
         



        
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
    void ComposeFooter(IContainer container)
    {
        container.Column(column =>
         {
             column.Item().Width(150).Image(geoPerformLogo);
             column.Item().AlignCenter().Text(text =>
             {
                 text.DefaultTextStyle(x => x.FontSize(16));

                 text.CurrentPageNumber();
                 text.Span(" / ");
                 text.TotalPages();
             });

         });
       
    }
    void ComposeHeader(IContainer container)
    {
        container.Width(200).Image(exxonMobilLogo);
    }
    void ComposeTitle(IContainer container)
    {
        container.Width(200).Image(exxonMobilLogo);
    }
    void ComposeAtSeaWarrantyTable1(IContainer container)
    {
        var columnsCount =8;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().RowSpan(3).Element(CellStyle).Text("Term Description");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Min Day");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Bad Day");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Min Passage");
                    header.Cell().ColumnSpan(4).Element(CellStyle).Text("Good Weather Evaluated Using:");
                    header.Cell().Element(CellStyle).Text("Wind Speed");
                    header.Cell().Element(CellStyle).Text("Wave Height");
                    header.Cell().Element(CellStyle).Text("Current");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Performance Speed");
                    header.Cell().Element(CellStyle).Text("hrs");
                    header.Cell().Element(CellStyle).Text("hrs");
                    header.Cell().Element(CellStyle).Text("hrs");
                    header.Cell().Element(CellStyle).Text("BF");
                    header.Cell().Element(CellStyle).Text("M");
                    header.Cell().Element(CellStyle).Text("kts");

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 7; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposeAtSeaWarrantyTable2(IContainer container)
    {
        var columnsCount = 6;

        container.AlignLeft()


            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Warranted Description");
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Load Condition");
                    header.Cell().Element(CellStyle).Text("Ordered Speed");
                    header.Cell().ColumnSpan(2).Element(CellStyle).Text("About Clause");

                    header.Cell().RowSpan(2).Element(CellStyle).Text("Warranted Fuel mt");

                    header.Cell().Element(CellStyle).Text("kts");
                    header.Cell().Element(CellStyle).Text("Speed kts(+/-)");
                    header.Cell().Element(CellStyle).Text("Fuel%(+/-)");


                    

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 14; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposeInPortWarrantyTable(IContainer container)
    {
        var columnsCount = 3;

        container.AlignLeft()


            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().RowSpan(2).Element(CellStyle).Text("Operation");
                 
                    
                    header.Cell().ColumnSpan(2).Element(CellStyle).Text("Warranted");

              
                    header.Cell().Element(CellStyle).Text("FO(mt/day)");
                    header.Cell().Element(CellStyle).Text("GO(mt/day)");




                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 14; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposePumpingWarrantyTable(IContainer container)
    {
        var columnsCount = 3;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text("Descriptions");
                    header.Cell().Element(CellStyle).Text("Warranties");
                    header.Cell().Element(CellStyle).Text("Units");
                   
                  

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 14; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }

               

            });
    }
    void ComposeTankDescriptionTable(IContainer container)
    {
        var columnsCount = 2;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text("Tank Descriptions");
                    header.Cell().Element(CellStyle).Text("Number of Tanks");
            



                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 1; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    // Cargo Heating Warranties and tank cleaning have same table structure so reuse this function 
    void ComposeOperationWarrantyTable(IContainer container)
    {
        var columnsCount = 3;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text("Category");
                    header.Cell().Element(CellStyle).Text("Warranted Cons. (mt/day) (IFO)");
                    header.Cell().Element(CellStyle).Text("Warranted Cons. (mt/day) (LSMGO)");



                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 5; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposePerformanceAnalysisSummaryTable(IContainer container)
    {
        var columnsCount = 9;

        container
            .Table(table =>
            {
               
                
                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text("Vessel Name");
                    header.Cell().ColumnSpan(2).Element(CellStyle).Text("XXXXX");
                    header.Cell().Element(CellStyle).Text("Date Range");
                    header.Cell().ColumnSpan(3).Element(CellStyle).Text("From: ");
                    header.Cell().ColumnSpan(2).Element(CellStyle).Text("To: ");
                    

                    header.Cell().Element(CellStyle).Text("Time Loss");
                    header.Cell().Element(CellStyle).Text("Fuel Over/Under Consumption (FO)");
                    header.Cell().Element(CellStyle).Text("Fuel Over/Under Consumption (MGO)");
                    header.Cell().Element(CellStyle).Text("Hire Rate ($)");
                    header.Cell().Element(CellStyle).Text("Bunker Rate FO($)");
                    header.Cell().Element(CellStyle).Text("Bunker Rate MGO($)");
                    header.Cell().Element(CellStyle).Text("Time Loss($)");
                    header.Cell().Element(CellStyle).Text("Fuel Over/Under Consumption($)");
                    header.Cell().Element(CellStyle).Text("Net Effective($)");
                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                  
                });

                for (var i = 0; i <= 17; i++)
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
    void ComposePerformanceAnalysisDetailTable(IContainer container)
    {
        var columnsCount = 4;

        container.PaddingVertical(20)
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                   
                    header.Cell().ColumnSpan(4).Element(CellStyle).Text("At Sea Performance");
                    header.Cell().Element(CellStyle).Text(" ");
                    header.Cell().Element(CellStyle).Text("Time Loss/Gain(hr)");
                    header.Cell().Element(CellStyle).Text("Fuel Over/Underconsumption (FO) (mt)");
                    header.Cell().Element(CellStyle).Text("Fuel Over/Underconsumption (MGO) (mt)");
              
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 17; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }

                

            });
    }
    void ComposeHeading(IContainer container)
    {
        container.Column(column =>
        {
            column.Item().Text("AT SEA PERFORMANCE DETAILS").FontSize(18).Underline()
                             .ExtraBlack();
            column.Item().Text("Passage Details:").FontSize(10).Underline()
                           .ExtraBlack();
            column.Item().Text("Passage details of Daily Weather Condition and Fuel Consumption to warrants displayed below:");
        });
       
    }
    void ComposeTable(IContainer container)
    {
        container
           .Table(table =>
           {

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

                   // you can extend existing styles by creating additional methods
                   IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                   IContainer CellStyleRotated(IContainer container) => RotatedCellStyle(container, Colors.Grey.Lighten3);
               });

               for (var i = 0; i <= 828; i++)
               {
                   table.Cell().Element(CellStyle).Text("0.2");



                   IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
               }

               

           });
    }
    void ComposePortPerformanceTable(IContainer container)
    {
        var columnsCount = 11;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().ColumnSpan(11).Element(CellStyle).Text("Voyage 01");
                    header.Cell().Element(CellStyle).Text("Port:");
                    header.Cell().ColumnSpan(10).Element(CellStyle).Text("Singapore");
                    header.Cell().Element(CellStyle).Text("Operation");
                    header.Cell().Element(CellStyle).Text("Start Time");
                    header.Cell().Element(CellStyle).Text("End Time");
                    header.Cell().Element(CellStyle).Text("Time (hrs)");
                    header.Cell().Element(CellStyle).Text("Warranted Cons (mt)");
                    header.Cell().Element(CellStyle).Text("Actual Cons FO (mt)");
                    header.Cell().Element(CellStyle).Text("Actual Cons DO (mt)");
                    header.Cell().Element(CellStyle).Text("Warranted Cons IGS(mt)");
                    header.Cell().Element(CellStyle).Text("Actual Cons IGS (mt)");

                    header.Cell().Element(CellStyle).Text("Fuel Saving/Loss FO(mt)");
                    header.Cell().Element(CellStyle).Text("Fuel  Saving/Loss DO(mt)");
                   
                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    //header.Cell().Element(CellStyle).Text("Width");
                    //header.Cell().Element(CellStyle).Text("Height");

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });

                for (var i = 0; i <= 32; i++)
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
    void ComposePumpingTable1(IContainer container)
    {
        var columnsCount = 4;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().ColumnSpan(4).Element(CellStyle).Text("Voyage 01");
                    header.Cell().Element(CellStyle).Text("Discharge Port");
                    header.Cell().ColumnSpan(3).Element(CellStyle).Text("DAESAN");
                    header.Cell().Element(CellStyle).Text("Cargo Grade Name");
                    header.Cell().Element(CellStyle).Text(" ");
                    header.Cell().Element(CellStyle).Text("Cargo Type");
                    header.Cell().Element(CellStyle).Text(" ");             

                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });


               
            });
    }
    void ComposePumpingTable2(IContainer container)
    {
        var columnsCount = 11;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text("Voyage No.");
                    header.Cell().Element(CellStyle).Text("Total Cargo Volume(m3)");
                    header.Cell().Element(CellStyle).Text("Activity");
                    header.Cell().Element(CellStyle).Text("Activity Start Time");
                    header.Cell().Element(CellStyle).Text("Activity End Time");
                    header.Cell().Element(CellStyle).Text("Activity Actual Time");
                    header.Cell().Element(CellStyle).Text("Actual Pressure");
                    header.Cell().Element(CellStyle).Text("Cargo Pumped");
                    header.Cell().Element(CellStyle).Text("COW Hours");
                    header.Cell().Element(CellStyle).Text("Adjusted CP Time");
                    header.Cell().Element(CellStyle).Text("Weighted Average");
                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });
                for (var i = 0; i <= 65; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposePumpingTable3(IContainer container)
    {
        var columnsCount = 8;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().Element(CellStyle).Text(" ");
                    header.Cell().Element(CellStyle).Text("Start of Operation");
                    header.Cell().Element(CellStyle).Text("End of Operation");
                    header.Cell().Element(CellStyle).Text("Actual Time Taken");
                    header.Cell().Element(CellStyle).Text("CP Time");
                    header.Cell().Element(CellStyle).Text("Time Loss/Gain");
                    header.Cell().Element(CellStyle).Text(" ");
                    header.Cell().Element(CellStyle).Text("Time Loss/Gain");
                    
                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });
                for (var i = 0; i <= 7; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }


            });
    }
    void ComposeHeatingTable1(IContainer container)
    {
        var columnsCount = 10;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().ColumnSpan(10).Element(CellStyle).Text("Voyage 01");
                    header.Cell().Element(CellStyle).Text("Operation");
                    header.Cell().Element(CellStyle).Text("Date");
                    header.Cell().Element(CellStyle).Text("Hours of Cargo Heating");
                    header.Cell().Element(CellStyle).Text("Number of Tanks Heated");
                    header.Cell().Element(CellStyle).Text("Actual Cons FO (mt)");
                    header.Cell().Element(CellStyle).Text("Actual Cons DO (mt)");
                    header.Cell().Element(CellStyle).Text("Warranted FO consumption (mt)");
                    header.Cell().Element(CellStyle).Text("Warranted DO consumption (mt)");

                    header.Cell().Element(CellStyle).Text("Fuel Loss/Gain FO(mt)");
                    header.Cell().Element(CellStyle).Text("Fuel  Loss/Gain DO(mt)");
                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });
                for (var i = 0; i <= 59; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    void ComposeHeatingTable2(IContainer container)
    {
        var columnsCount = 5;
        container.Table(table =>
        {


            table.ColumnsDefinition(columns =>
            {
                for (var i = 0; i < columnsCount; i++)
                {
                    columns.RelativeColumn();
                }
            });
            table.Header(header =>
            {
                // please be sure to call the 'header' handler!
                header.Cell().RowSpan(2).Element(CellStyle).Text("Heating performance Voyage 01");
                header.Cell().Element(CellStyle).Text("Warranted Consumption FO(mt)");
                header.Cell().Element(CellStyle).Text("Warranted Consumption FO(mt)");
                header.Cell().Element(CellStyle).Text("Time Loss/Gain FO(mt)");
                header.Cell().Element(CellStyle).Text("Time Loss/Gain FO(mt)");
                
                // you can extend existing styles by creating additional methods
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

            });
            for (var i = 0; i <= 3; i++)
            {
                table.Cell().Element(CellStyle).Text("0.2");



                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
            }



        });
    }
    void ComposeTankCleaningPerformance(IContainer container)
    {
        var columnsCount = 10;

        container
            .Table(table =>
            {


                table.ColumnsDefinition(columns =>
                {
                    for (var i = 0; i < columnsCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });
                table.Header(header =>
                {
                    // please be sure to call the 'header' handler!
                    header.Cell().ColumnSpan(10).Element(CellStyle).Text("Voyage 01");
                    header.Cell().Element(CellStyle).Text("Operation");
                    header.Cell().Element(CellStyle).Text("Date");
                    header.Cell().Element(CellStyle).Text("Hours of Tank Cleaned");
                    header.Cell().Element(CellStyle).Text("Number of Tanks Cleaned");
                    header.Cell().Element(CellStyle).Text("Actual Cons FO (mt)");
                    header.Cell().Element(CellStyle).Text("Actual Cons DO (mt)");
                    header.Cell().Element(CellStyle).Text("Warranted FO consumption (mt)");
                    header.Cell().Element(CellStyle).Text("Warranted DO consumption (mt)");

                    header.Cell().Element(CellStyle).Text("Fuel Loss/Gain FO(mt)");
                    header.Cell().Element(CellStyle).Text("Fuel  Loss/Gain DO(mt)");
                    // you can extend existing styles by creating additional methods
                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                });
                for (var i = 0; i <= 59; i++)
                {
                    table.Cell().Element(CellStyle).Text("0.2");



                    IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                }



            });
    }
    Document.Create(document =>
    {
        
        document.Page(titlePage =>
        {
            titlePage.Size(PageSizes.A3.Landscape());
            titlePage.Margin(30);
            titlePage.Header().Element(ComposeHeader);
            titlePage.Content().Column(column =>
            {
                column.Item().Text("Voyage TC Performance Analysis Report")
                
                             .FontSize(35)
                             
                             .ExtraBlack();
                
                column.Item().Text("Prepared For:")
                            ;
                column.Item().Text("Exxon Mobil")
                  .FontSize(25)
                             .ExtraBlack(); ;
                column.Item().Text("Prepared By:");
                column.Item().Text("Geoserve VPS")
                  .FontSize(25)
                             .ExtraBlack(); ;
                column.Item().Text("Vessel Name");
                column.Item().Text("xxxxxxx")
                  .FontSize(25)
                             .ExtraBlack(); ;
                column.Item().Text("Voyage Nos:");
                column.Item().Text("xxxxxxx");
               // IContainer TextStyle(IContainer container) => Heading1(container, text);
            });
            titlePage.Footer().Element(ComposeFooter);
        });
        document.Page(warrantyPage =>
        {
            warrantyPage.Size(PageSizes.A3.Landscape());
            warrantyPage.Margin(30);
            warrantyPage.Header().Element(ComposeHeader);
            warrantyPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Time Charter Party Terms Warrants").FontSize(25)
                             .ExtraBlack();
                column.Item().Text("At Sea Warranties:").FontSize(18)
                             .ExtraBlack();
                column.Item().Element(ComposeAtSeaWarrantyTable1);
                column.Item().Element(ComposeAtSeaWarrantyTable2);
                column.Item().Text("In Port Warranties:").FontSize(18)
                             .ExtraBlack();
                column.Item().Element(ComposeInPortWarrantyTable);
               
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            warrantyPage.Footer().Element(ComposeFooter) ;
        });

        document.Page(warrantyPage =>
        {
            warrantyPage.Size(PageSizes.A3.Landscape());
            warrantyPage.Margin(30);
            warrantyPage.Header().Element(ComposeHeader);
            warrantyPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Time Charter Party Terms Warrants").FontSize(25)
                             .ExtraBlack();
                column.Item().Text("Pumping Warranties:").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposePumpingWarrantyTable);
                column.Item().Element(ComposeTankDescriptionTable);
                column.Item().Text("Cargo Heating Warranties:").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposeOperationWarrantyTable);
                column.Item().Text("Tank CleaningWarranties:").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposeOperationWarrantyTable);
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            //warrantyPage.Footer().Column(column =>
            //{
            //    column.Item().Width(300).Image(geoPerformLogo);
            //    column.Item().AlignCenter().Text(text =>
            //    {
            //        text.DefaultTextStyle(x => x.FontSize(16));

            //        text.CurrentPageNumber();
            //        text.Span(" / ");
            //        text.TotalPages();
            //    });

            //});
            warrantyPage.Footer().Element(ComposeFooter);
        });

        document.Page(performanceSummaryPage =>
        {
           performanceSummaryPage.Size(PageSizes.A3.Landscape());
           performanceSummaryPage.Margin(30);
            performanceSummaryPage.Header().Element(ComposeHeader);
            performanceSummaryPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Element(CellStyle).Text("Voyage TC Performance Analysis Summary").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposePerformanceAnalysisSummaryTable);
                column.Item().Element(CellStyle).Text("Voyage TC Performance Analysis Detail").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposePerformanceAnalysisDetailTable);
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            performanceSummaryPage.Footer().Element(ComposeFooter);
        });
        
        for (int pageIndex = 1; pageIndex <= 3; pageIndex++)
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
                page.Footer().Element(ComposeFooter);
            });
        }
        document.Page(portPerformancePage =>
        {
            portPerformancePage.Size(PageSizes.A3.Landscape());
            portPerformancePage.Margin(30);
            portPerformancePage.Header().Element(ComposeHeader);
            portPerformancePage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Port Performance Detail").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposePortPerformanceTable);
                column.Item().Element(ComposePortPerformanceTable);
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            portPerformancePage.Footer().Element(ComposeFooter);
        });
        document.Page(pumpingPage => {

            pumpingPage.Size(PageSizes.A3.Landscape());
            pumpingPage.Margin(30);
            pumpingPage.Header().Element(ComposeHeader);
            pumpingPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Pumping Performance").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposePumpingTable1);
                column.Item().Element(ComposePumpingTable2);
                column.Item().Element(ComposePumpingTable3);
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            pumpingPage.Footer().Element(ComposeFooter);
        });
        document.Page(heatingPage => {

            heatingPage.Size(PageSizes.A3.Landscape());
            heatingPage.Margin(30);
            heatingPage.Header().Element(ComposeHeader);
            heatingPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Heating Performance").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposeHeatingTable1);
                column.Item().Element(ComposeHeatingTable2);
               
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            heatingPage.Footer().Element(ComposeFooter);
        });
        //change below to Tank Cleaning
        document.Page(tankCleaningPage => {

            tankCleaningPage.Size(PageSizes.A3.Landscape());
            tankCleaningPage.Margin(30);
            tankCleaningPage.Header().Column(column =>
            {
                column.Item().Width(200).Image(exxonMobilLogo);

            });
            tankCleaningPage.Content().Column(column => {
                //column.Item().Element(ComposeHeading);
                column.Item().Text("Tank Cleaning Performance").FontSize(25)
                             .ExtraBlack();
                column.Item().Element(ComposeHeatingTable1);
                column.Item().Element(ComposeHeatingTable2);

                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
            });
            tankCleaningPage.Footer().Element(ComposeFooter);
        });
    })
    .GeneratePdf("Test2.pdf");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}
