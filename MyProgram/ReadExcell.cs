//http://www.dotnet-tutorials.net/Article/read-an-excel-file-in-csharp
            var empList = new List<Employee>();
            // path to your excel file
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            // get number of rows and columns in the sheet
            int rows = worksheet.Dimension.Rows; // 20
            int columns = worksheet.Dimension.Columns; // 7

            // loop through the worksheet rows and columns
            for (int i = 2; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {

                    //string content = worksheet.Cells[i, j].Value.ToString();
                    /* Do something ...*/
                    empList.Add(new Employee {NationalCode= worksheet.Cells[i,j].Value.ToString()});
                }
            }
