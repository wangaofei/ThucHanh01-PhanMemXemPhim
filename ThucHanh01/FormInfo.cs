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
using System.Windows.Media;
using LicenseContext = OfficeOpenXml.LicenseContext;
using DataDB = System.Data.OleDb;

namespace ThucHanh01
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        public class phimInfo
        {
            public string idPhim { get; set; } 
            public string tenPhim { get; set; }
            public string thoiLuongPhim { get; set; }
            public string daoDien { get; set; }
            public string quocGia { get; set; }
            public string khoiChieu { get; set; }
            public string noiDungPhim { get; set; }
            public string LuotXem { get; set; }
            public string danhGia { get; set; }

        }
        static int sothutu;
        string idFilm="";
        static int pos = 0;
        List<phimInfo> phimList = new List<phimInfo>();
        public FormInfo(int sothutu)
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            DateTime today = DateTime.Now;
            pos = sothutu;
            string[] data = new string[9];
            try
            {
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

                    phimInfo phim = new phimInfo()
                    {
                        idPhim = data[0],
                        tenPhim = data[1],
                        thoiLuongPhim = data[2],
                        daoDien = data[3],
                        quocGia = data[4],
                        khoiChieu = data[5],
                        noiDungPhim = data[6],
                        LuotXem = data[7],
                        danhGia = data[8],

                    };

                    phimList.Add(phim);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");

            }

            ptbPoster.Load("Poster\\" + sothutu + ".jpg");

            
            idFilm = phimList[sothutu].idPhim;
            labelTenPhim.Text = phimList[sothutu].tenPhim;
            labelThoiLuongPhim.Text = phimList[sothutu].thoiLuongPhim;
            labelTenDaoDien.Text = phimList[sothutu].daoDien;
            labelTenQuocGia.Text = phimList[sothutu].quocGia;
            labelTenKhoiChieu.Text = phimList[sothutu].khoiChieu;
            labelNoiDungPhim.Text = phimList[sothutu].noiDungPhim;
            labelTenLuotXem.Text = phimList[sothutu].LuotXem;
            int n = Int32.Parse(phimList[sothutu].danhGia);
            showStar(n);
            this.Icon = new Icon("logoicon.ico");
        }

        //Show the amount of film's star
        private void showStar(int n)
        {
            listView1.Items.Clear();
            for (int i = 1; i <= n; i++)
            {
                listView1.Items.Add("", 0);
            }
            for (int j = n + 1; j <= 5; j++)
            {
                listView1.Items.Add("", 1);
            }
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }

        private void update_star(int n, string idPhim)
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
                            sql = "update [sheet1$] set Rating =" + n.ToString() + " where STT =" + idPhim;
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

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }

        private void FormInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem list = listView1.GetItemAt(e.X, e.Y);
            int index = list.Index + 1;
            showStar(index);
            update_star(index, idFilm);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Menu form = new Form_Menu();
            form.Show();
            this.Hide();
        }

        private void buttonWatchTrailer_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form = new Form1(sothutu);
            form.Show();
            this.Hide();
        }
    }
}
