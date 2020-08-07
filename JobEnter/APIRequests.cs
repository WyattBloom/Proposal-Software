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

        private String gisLink = "GIS Link";
        private String name = "";
        private String email = "";
        private String address = "";
        private String city = "";
        private String county = "";
        private String number = "";
        private String SI = "";
        private String price = "";
        private DateTime date = new DateTime();
        private String jobType = "";

        public void setGISLink(String gisIn) { this.gisLink = gisIn; }

        public void setName(String n) { this.name = n; }

        public void setEmail(String e) { this.email = e; }

        public void setAddress(String a) { this.address = a; }

        public void setCity(String c) { this.city = c; }

        public void setCounty(String c) { this.county = c; }

        public void setSI(String s) { this.SI = s; }

        public void setNumber(String pn) { this.number = pn; }

        public void setPrice(String p) { this.price = p; }
        
        public void setDate(DateTime d) { this.date = d; }

        public APIRequests(String sheetName, String accessTokenIn)
        {
            accessToken = accessTokenIn;
            smartsheet = new SmartsheetBuilder()
                .SetAccessToken(accessToken)
                .Build();
            sheetID = this.getSheetID(sheetName);
        }

        // Includes GIS Link
        public APIRequests(String sheetName, string accessTokenIn,
                    String gisIn, String name, String email,
                    String address, String city, String county,
                    String price, String phoneNum, String SI,
                    DateTime date, String jobType)
        {
            accessToken = accessTokenIn;
            smartsheet = new SmartsheetBuilder()
                            .SetAccessToken(accessToken)
                            .Build();
            sheetID = this.getSheetID(sheetName);
            try
            {
                if (gisIn != null) { this.gisLink = gisIn; }
                if (name != null) { this.name = name; }
                if (address != null) { this.address = address; }
                if (email != null) { this.email = email; }
                if (phoneNum != null) { this.number = phoneNum; }
                if (city != null) { this.city = city; }
                if (county != null) { this.county = county; }
                if (jobType != null) { this.jobType = jobType; }
                if (SI != null) { this.SI = SI; }
                if (price != null) { this.price = price; }
                this.date = date;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error in API 1. " + ex.Message);
            }
        }



        // Includes Email Authentication
        /*public APIRequests(String sheetName, string accessTokenIn, String GIS, 
                            String userEmail, String name, String email, 
                            String address, String city, String state, 
                            String price, String phoneNum, DateTime date)
        {
            accessToken = accessTokenIn;
            smartsheet  = new SmartsheetBuilder()
                            .SetAccessToken(accessToken)
                            .SetAssumedUser(userEmail)
                            .Build();
            sheetID     = this.getSheetID(sheetName);

            if (name     != null) { this.name    = name;     }
            if (address  != null) { this.address = address;  }
            if (email    != null) { this.email   = email;    }
            if (phoneNum != null) { this.number  = phoneNum; }
            if (city     != null) { this.city    = city;     }
            if (state    != null) { this.state   = state;    }
        }*/
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
            if (gisLink == null)
                gisLink = "";

            int priceVal;
            bool canConvert = int.TryParse(price, out priceVal);
            if (canConvert == false)
                throw new System.InvalidCastException("Error converting price to an Integer");
            
            try
            {
                Console.WriteLine("Sheet ID: " + this.sheetID + "| Access Token: " + this.accessToken);
                Console.WriteLine(this.getColumnID("Project Stage: ") + "Sent" + "\n" +
                                  this.getColumnID("GIS Link: ") + gisLink + "\n" +
                                  this.getColumnID("Client: ") + name + "\n" +
                                  this.getColumnID("Client Email: ") + email + "\n" + 
                                  this.getColumnID("Phone No.: ") + number + "\n" +
                                  this.getColumnID("Address: ") + address + "\n" +
                                  this.getColumnID("City: ") + city + "\n" +
                                  this.getColumnID("County: ") + county);
                // Specify cell values of row
                Cell[] cellsA = new Cell[] {
                new Cell
                {
                    ColumnId = this.getColumnID("Project Stage"),
                    Value = "Sent"
                },new Cell
                {
                    ColumnId = this.getColumnID("GIS Link"),
                    Value = this.gisLink
                },new Cell
                {
                    ColumnId = this.getColumnID("Client"),
                    Value = this.name
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Client Email"),
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
                    ColumnId = this.getColumnID("County"),
                    Value = this.county
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Type"),
                    Value = this.jobType
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Phone No."),
                    Value = this.number
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Date Approved"),
                    Value = this.date
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Special Instructions"),
                    Value = this.SI
                },
                new Cell
                {
                    ColumnId = this.getColumnID("Fee"),
                    Value = Int32.Parse(price)
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
                  this.sheetID,                  // sheetId
                  new Row[] { rowA }             // IEnumerable<Row> rowsToAdd
                );
            }catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

    }
}
