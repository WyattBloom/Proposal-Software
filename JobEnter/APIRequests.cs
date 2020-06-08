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
        private String accessToken;
        private SmartsheetClient smartsheet;

        private long sheetID;

        private String name;
        private String email;
        private String address;
        private String city;
        private String number;
        private String state;
        private String zip;
        private DateTime date;

        public void setName(String n) { this.name = n; }

        public void setEmail(String e) { this.email = e; }

        public void setAddress(String a) { this.address = a; }

        public void setCity(String c) { this.city = c; }

        public void setState(String s) { this.state = s; }

        public void setZip(String z) { this.zip = z; }

        public void setNumber(String pn) { this.number = pn; }
        
        public void setDate(DateTime d) { this.date = d; }

        public APIRequests(String sheetName, String accessTokenIn)
        {
            accessToken = accessTokenIn;
            smartsheet = new SmartsheetBuilder()
                .SetAccessToken(accessToken)
                .Build();
            sheetID = this.getSheetID(sheetName);
        }

        public APIRequests(String sheetName, string accessTokenIn, 
                            String name, String email, String address, 
                            String city, String state, String zip,
                            String phoneNum, DateTime date)
        {
            accessToken = accessTokenIn;
            smartsheet  = new SmartsheetBuilder()
                            .SetAccessToken(accessToken)
                            .Build();
            sheetID     = this.getSheetID(sheetName);

            if (name     != null) { this.name    = name;     }
            if (address  != null) { this.address = address;  }
            if (email    != null) { this.email   = email;    }
            if (phoneNum != null) { this.number  = phoneNum; }
            if (city     != null) { this.city    = city;     }
            if (state    != null) { this.state   = state;    }
            if (zip      != null) { this.zip     = zip;      }
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

            foreach (var x in sheet.Columns)
            {
                if (x.Title == columnName)
                {
                    return Convert.ToInt64(x.Id);
                }
            }
            return 0;
        }

        public void addRow()
        {

            // Specify cell values of row
            Cell[] cellsA = new Cell[] {
                new Cell
                {
                    ColumnId = this.getColumnID("Name"),
                    Value = this.name
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Email"),
                    Value = this.email
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Address"),
                    Value = this.address
                },
                new Cell
                {
                    ColumnId = this.getColumnID("City"),
                    Value = this.city
                },
                new Cell
                {
                    ColumnId = this.getColumnID("State"),
                    Value = this.state
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Zip"),
                    Value = this.zip
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

            // Specify contents of row
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
