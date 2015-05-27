

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FareManagement.Model;
using Excel = Microsoft.Office.Interop.Excel; 

namespace FareManagement.DAL
{
    class ExportGatway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public bool ExportToExcel(int zid, string name)
        {
            string data;
            Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet xlWorkSheet ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "visitorListByZoneId";
                command.Parameters.Add(new SqlParameter("@zid", SqlDbType.Int)).Value = zid;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                    dataSet.Tables.Add(dataTable);
                    int counter = 1;

                    xlWorkSheet.Cells[2, 2] = "SN";
                    xlWorkSheet.Cells[2, 3] = "Name";
                    xlWorkSheet.Cells[2, 4] = "Email";
                    xlWorkSheet.Cells[2, 5] = "Contact";
                    for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 3, 2] = counter++.ToString();
                        for (int j = 0; j < dataSet.Tables[0].Columns.Count - 1; j++)
                        {
                            data = dataSet.Tables[0].Rows[i].ItemArray[j].ToString();
                            xlWorkSheet.Cells[i + 3, j + 3] = data;
                        }
                    }
                    connection.Close();
                    xlWorkSheet.Columns.AutoFit();
                    xlWorkSheet.Rows.AutoFit();
                    xlWorkSheet.Cells[2, 2].EntireRow.Font.Bold = true;
                    xlWorkSheet.Cells[2, 2].EntireRow.Font.Size = 14;
                    xlWorkBook.Application.DisplayAlerts = false;
                    xlWorkBook.SaveAs(name,Excel.XlFileFormat.xlWorkbookDefault,misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange,misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                }
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
