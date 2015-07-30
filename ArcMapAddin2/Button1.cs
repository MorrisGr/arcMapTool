using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;


namespace ArcMapAddin2
{
    public class Button1 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Button1()
        {
        }

        protected override void OnClick()
        {
            Form1 form = new Form1();
            // frmStat.DefInstance.pApplication = pApplication
       // frmStat.DefInstance.Show()
       // SetWin_TOPMOST(frmStat.DefInstance.Handle.ToInt32)

            //
            //  TODO: Sample code showing how to access button host
            //
       /*     ArcMap.Application.CurrentTool = null;
            System.Windows.Forms.MessageBox.Show("testing");

      System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
    // TODO: Modify the connection string and include any
    // additional required properties for your database.
         //   conn.ConnectionString=@"C:\Users\d\Desktop\Meteorological_Data.mdb";
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data source=C:\Users\d\Desktop\Meteorological_Data.mdb";
     //   @"My Documents\AccessFile.mdb";
    try
    {
        conn.Open();


            System.Data.OleDb.OleDbCommand aCommand = conn.CreateCommand();
            aCommand.CommandText = "SELECT * FROM Max_Temperature";
            System.Data.OleDb.OleDbDataReader aReader = aCommand.ExecuteReader();
            aReader.Read();

            bool read;

            object[] meta = new object[5];
            if (aReader.Read() == true)
            {
                do
                {
                    int NumberOfColums = aReader.GetValues(meta);

                 //   for (int i = 0; i < NumberOfColums; i++)
                    System.Windows.Forms.MessageBox.Show("{0} " + meta[0].ToString() + meta[1].ToString() + meta[2].ToString() + meta[3].ToString() + meta[4].ToString());

                    //Console.WriteLine();
                    read = aReader.Read();
                } while (read == true);
            }

            aReader.Close();

              //  System.Windows.Forms.MessageBox.Show("e? = " + aReader.GetValues(meta));
            //aCommand.ExecuteReader();


        // Insert code to process data.
    }
        catch (Exception ex)
    {
        System.Windows.Forms.MessageBox.Show("failed");
    }
    finally
    {
        conn.Close();
    }*/


    System.Windows.Forms.MessageBox.Show("reached");
            form.ShowDialog();
             
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
