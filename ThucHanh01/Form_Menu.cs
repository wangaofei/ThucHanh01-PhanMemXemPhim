using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Threading;
using DataDB = System.Data.OleDb;
using System.Diagnostics;

namespace ThucHanh01
{
    public partial class Form_Menu : Form
    { 
        string[] data = new string[9];
        public Form_Menu()
        {
            InitializeComponent();
            label2.Select();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string path = "dataphim.xlsx";
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
            int rows = worksheet.Dimension.Rows;
            int columns = worksheet.Dimension.Columns;
           
            for (int i = 2; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    data[j - 1] = worksheet.Cells[i, j].Value.ToString();

                }
                listView1.Items.Add(data[1],i-2);

            }
            listView1.LargeImageList = imageList1;

            this.Icon = new Icon("logoicon.ico");
            pictureBoxBannerMain.Load("ads//hoa88.gif");
            pictureBoxAds1.Load("ads//slider.gif");
            pictureBoxAds2.Load("ads//slider.gif");
        }
        //slider
        private int imageNumber = 1;
        private void LoadNextImages()
        {
            if (imageNumber > 10)
                imageNumber = 1;
            pictureBoxSlider.ImageLocation = String.Format(@"..\\wallpaper\\" + imageNumber + ".jpg");
            imageNumber++;
        }


        private void timerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem list = listView1.GetItemAt(e.X, e.Y);
            int index = list.Index;
            int pos = index+1;
            TangView(pos.ToString());
            FormInfo forminfo = new FormInfo(index);
            forminfo.Show();
            this.Hide();
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void pictureBoxSlider_Click(object sender, EventArgs e)
        {

        }


        //This method for update view when watch_btn is clicked!
        private void TangView(string idPhim)
        {

            
            var package = new ExcelPackage(new FileInfo("dataphim.xlsx"));

            string[] s = new string[9];

            //Làm việc ở worksheets đầu 
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            //Duyệt tuần tự từ dòng 2 tới dòng cuối 

            for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
            {
                try
                {
                    //Biến j thể hiện các cột
                    for (int j = 1; j < 10; j++)
                    {
                        string str = worksheet.Cells[i, 1].Value.ToString();

                        if (str == idPhim)
                        {
                            string viewStr = worksheet.Cells[i, 8].Value.ToString();
                            int viewplus = Int32.Parse(viewStr);
                            viewplus++;
                            viewStr = viewplus.ToString();

                            //cExcel.Application excel = new cExcel.Application();
                            //cExcel.Workbook sheet = excel.Workbooks.Open(@"C:\Users\DELL\Desktop\C#\Đồ án\dataphim.xlsx");
                            //cExcel.Worksheet x = excel.ActiveSheet as cExcel.Worksheet;

                            //cExcel.Range userRange = x.UsedRange;
                            //x.Cells[i,8] = viewStr;
                            //sheet.Save();
                            //sheet.Close(true, Type.Missing, Type.Missing);
                            //excel.Quit();
                            DataDB.OleDbConnection MyCnt;
                            DataDB.OleDbCommand cmd = new DataDB.OleDbCommand();
                            string sql = "";
                            //string filePath = "C:\\Users\\DELL\\Desktop\\C#\\Đồ án\\dataphim.xlsx";
                            MyCnt = new DataDB.OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" + "dataphim.xlsx" + "';Extended Properties=\"Excel 12.0;HDR=YES;\"");
                            MyCnt.Open();
                            cmd.Connection = MyCnt;
                            sql = "update [sheet1$] set LuotXem ="+viewStr+" where STT =" +idPhim;
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MyCnt.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Err");
                }
            }

        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                    e.Item.Selected = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           pictureBoxBannerMain.Visible = false;
           button1.Visible = false;
            label2.Select();
        }

        private void pictureBoxBannerMain_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://linktr.ee/hoapham.z");
        }

        private void pictureBoxAds1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://tuyensinh.uit.edu.vn/");
        }
        private void pictureBoxAds2_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://tuyensinh.uit.edu.vn/");
        }
    }
}
