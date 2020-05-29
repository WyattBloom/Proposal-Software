using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartsheet.Api;
using Smartsheet.Api.Models;

namespace JobEnter
{
    class APIRequests
    {
        public static String accessToken = "zja8p39vwwxywjoch3nuwpy1de";
        public SmartsheetClient smartsheet = new SmartsheetBuilder()
            .SetAccessToken(accessToken)
            .Build();

        private long sheetID;

        private String name;
        public void setName(String n) { this.name = n; }
        
        private String address;
        public void setAddress(String a) { this.address = a; }
        
        private int number;
        public void setNumber(int pn) { this.number = pn; }
        
        private DateTime date;
        public void setDate(DateTime d) { this.date = d; }

        public APIRequests(String sheetName, String accessTokenIn)
        {
            accessToken = accessTokenIn;
            sheetID = this.getSheetID(sheetName);
        }

        public APIRequests(String sheetName, string accessTokenIn, 
                String name, String address, int phoneNum, DateTime date)
        {
            accessToken = accessTokenIn;
            sheetID = this.getSheetID(sheetName);
            this.name = name;
            this.address = address;
            this.number = phoneNum;
            this.date = date;
        }
        public void addRow( String name, String address, int phone, 
                            DateObjectValue date, String money)
        {


        }


        public void updateCell()
        {

        }

        public long getSheetID(String sheetName)
        {
            PaginatedResult<Sheet> sheets = smartsheet.SheetResources.ListSheets(
                new SheetInclusion[] { SheetInclusion.SOURCE },
                new PaginationParameters(
                true,           // includeAll
                null,           // int pageSize
                null)           // int page
            );
            foreach(var x in sheets.Data)
            {
                if(x.Name == sheetName)
                {
                    return Convert.ToInt64(x.Id);
                }
            }
            return 0;
        }

        // Returns a column ID from a given column name
        public long getColumnID(String columnName)
        {
            // Omit all parameters
            Sheet sheet = smartsheet.SheetResources.GetSheet(
              sheetID,                    // sheetId
              null,                       // IEnumerable<SheetLevelInclusion> includes
              null,                       // IEnumerable<SheetLevelExclusion> excludes
              null,                       // IEnumerable<long> rowIds
              null,                       // IEnumerable<int> rowNumbers
              null,                       // IEnumerable<long> columnIds
              null,                       // Nullable<long> pageSize
              null                        // Nullable<long> page
            );

            foreach(var x in sheet.Columns)
            {
                if (x.Title == columnName)
                    return Convert.ToInt64(x.Id);
            }
            return 0;
        }

        public void addRow()
        {

            // Specify cell values of second row
            Cell[] cellsA = new Cell[] {
                new Cell
                {
                    ColumnId = this.getColumnID("Name"),
                    Value = this.name
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Address"),
                    Value = this.address
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Phone"),
                    Value = this.number
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Date"),
                    Value = this.date
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Money"),
                    Value = 3500
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Accepted"),
                    Value = "Pending"
                }
            };

            // Specify contents of second row
            Row rowA = new Row
            {
                ToBottom = true,
                Cells = cellsA
            };



            // Add rows to sheet
            IList<Row> newRows = smartsheet.SheetResources.RowResources.AddRows(
              4235468226226052,               // sheetId
              new Row[] { rowA }             // IEnumerable<Row> rowsToAdd
            );
        }

    }
}
