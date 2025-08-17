using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSV_Library;
using 天天記帳.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace 天天記帳.Forms
{
    public partial class 記帳本 : Form
    {
        List<RecordModel> datas = new List<RecordModel>();
        public 記帳本()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DebounceTime((data) =>
            {
                for (int i = 0; i < datas.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[6].Dispose();
                    dataGridView1.Rows[i].Cells[7].Dispose();
                    dataGridView1.Rows[i].Cells[11].Dispose();
                }
                dataGridView1.DataSource = null;
                GC.Collect();
                datas.Clear();
                // HW:解決記帳本記憶體洩漏的問題
                CSV csv1 = new CSV();
                // 檢查該檔案是否存在
                // File.Exists
                string StartDate = StartPicker.Value.ToString("yyyy-MM-dd");
                string EndDate = EndPicker.Value.ToString("yyyy-MM-dd");
                TimeSpan timeSpan = EndPicker.Value - StartPicker.Value;
                for (int i = 0; i <= timeSpan.Days; i++)
                {
                    string Date = StartPicker.Value.AddDays(i).ToString("yyyy-MM-dd");
                    if (File.Exists("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + Date + "\\data.csv"))
                    {
                        List<RecordModel> csvread = csv1.Read<RecordModel>("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + Date + "\\data.csv");
                        datas.AddRange(csvread);
                    }
                }
                //8秒鐘=100%
                //1秒鐘=12.5%
                //上半部跟下半部放資料到畫面上要花1秒鐘
                //載入40張相片要花7秒鐘
                //一秒鐘可以讀取5.7張相片
                //40 => 7s
                //1 => 5s

                LoadDatas();
            }, 600);


            // progressBar1.Value = 100;

        }
        private void LoadDatas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = datas;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            //會透過反射方式，取得每一個List<RecordModel> 的欄位
            //先將每一個欄位進行 DataGridViewTextboxColumn創建
            //為每一筆資料建檔，創建DataGridViewRow
            //跑迴圈為每一筆資料進行填寫，填入到 DataGridViewTextboxCell

            DataGridViewComboBoxColumn comboBoxColumn1 = new DataGridViewComboBoxColumn();
            comboBoxColumn1.HeaderText = "消費類型";
            comboBoxColumn1.DataSource = DataModel.list;
            dataGridView1.Columns.Insert(2, comboBoxColumn1);
            DataGridViewComboBoxColumn comboBoxColumn2 = new DataGridViewComboBoxColumn();
            comboBoxColumn2.HeaderText = "消費目的";
            comboBoxColumn2.Name = "消費目的_combox";
            dataGridView1.Columns.Insert(3, comboBoxColumn2);
            DataGridViewComboBoxColumn comboBoxColumn3 = new DataGridViewComboBoxColumn();
            comboBoxColumn3.HeaderText = "消費對象";
            comboBoxColumn3.DataSource = DataModel.消費對象;

            dataGridView1.Columns.Insert(4, comboBoxColumn3);
            DataGridViewComboBoxColumn comboBoxColumn4 = new DataGridViewComboBoxColumn();
            comboBoxColumn4.HeaderText = "消費店家";
            dataGridView1.Columns.Insert(5, comboBoxColumn4);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            DataGridViewImageColumn iconColumn1 = new DataGridViewImageColumn();
            iconColumn1.Name = "圖片１";
            iconColumn1.HeaderText = "圖片１";
            iconColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn iconColumn2 = new DataGridViewImageColumn();
            iconColumn2.Name = "圖片２";
            iconColumn2.HeaderText = "圖片２";
            iconColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn iconColumn3 = new DataGridViewImageColumn();
            iconColumn3.Name = "刪除";
            iconColumn3.HeaderText = "刪除";
            iconColumn3.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Insert(6, iconColumn1);
            dataGridView1.Columns.Insert(7, iconColumn2);
            dataGridView1.Columns.Add(iconColumn3);
            //TODO: xxxxx
            dataGridView1.Columns["Imagepath1"].Visible = false;
            dataGridView1.Columns["Imagepath2"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            for (int i = 0; i < datas.Count; i++)
            {

                Bitmap map1 = new Bitmap(datas[i].Imagepath1);
                Bitmap map2 = new Bitmap(datas[i].Imagepath2);

                Bitmap map3 = new Bitmap("D:\\VisualStudio作業\\source\\repos\\trash-can.png");
                ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[2]).Value = datas[i].Type;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[4]).Value = datas[i].Object;


                List<string> purpose = DataModel.keyValuePairs[datas[i].Type];
                DataGridViewComboBoxCell purposebox = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[3];
                purposebox.DataSource = purpose;
                purposebox.Value = datas[i].Purpose;

                List<string> store = DataModel.keyValueStore[datas[i].Type];
                DataGridViewComboBoxCell storebox = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[5];
                storebox.DataSource = store;
                storebox.Value = datas[i].Store;


                ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[6]).Value = map1;
                ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[7]).Value = map2;
                ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[15]).Value = map3;

                Application.DoEvents();
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"row:{e.RowIndex} column:{e.ColumnIndex}");
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                string imagePath = "";
                switch (e.ColumnIndex)
                {
                    case 6:
                        imagePath = datas[e.RowIndex].Imagepath1.Replace("40x40_", "");
                        break;
                    case 7:
                        imagePath = datas[e.RowIndex].Imagepath2.Replace("40x40_", "");
                        break;

                }
                ImageDialog imageDialog = new ImageDialog(imagePath);
                imageDialog.ShowDialog();
            }
            else if (e.ColumnIndex == 15)
            {
                DialogResult result = MessageBox.Show(
                    "你確定要刪除這筆資料嗎？",
                    "確認刪除",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    //1. 先抓出該筆記帳的日期
                    //2. 透過LINQ Where 篩選datas的資料，只找出與該編輯日期相同的資料
                    //3. 刪除掉當前日期資料夾內的data.csv
                    //4. 將剛剛篩選完datas的資料透過CSVHelper 重新建檔回寫回去


                    RecordModel deletedata = datas[e.RowIndex];
                    datas.Remove(deletedata);
                    List<RecordModel> filterdates = datas.Where<RecordModel>(x => x.Date == deletedata.Date).ToList();
                    File.Delete("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + deletedata.Date + "\\data.csv");
                    CSV csv = new CSV();

                    csv.WriterList("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + deletedata.Date + "\\data.csv", filterdates);


                    dataGridView1.DataSource = null;
                    LoadDatas();
                }
            }



        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //HW 將編輯過後的結果回寫回去CSV進行存檔
            if (e.ColumnIndex == 1)
            {
                datas[e.RowIndex].Number = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (e.ColumnIndex == 2)
            {
                datas[e.RowIndex].Type = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else if (e.ColumnIndex == 3)
            {
                datas[e.RowIndex].Purpose = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else if (e.ColumnIndex == 5) 
            {
                datas[e.RowIndex].Store = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);


            Console.WriteLine(datas[e.RowIndex].Purpose);
            Console.WriteLine(datas[e.RowIndex].Store);

            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //HW: 把其他下拉選單連動也一起完成 (也要連動消費店家)
            if (e.ColumnIndex == 2)
            {
                //連動消費目的
                DataGridViewComboBoxCell PurposecomboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[3]; //第三個位子
                List<string> Purposedatas = DataModel.keyValuePairs[dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()];
                PurposecomboBoxCell.DataSource = Purposedatas;
                PurposecomboBoxCell.Value = Purposedatas[0];
                datas[e.RowIndex].Purpose = Purposedatas[0];

                //連動消費店家
                DataGridViewComboBoxCell StorecomboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[5]; //第五個位子
                List<string> Storedatas = DataModel.keyValueStore[dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()];
                StorecomboBoxCell.DataSource = Storedatas;
                StorecomboBoxCell.Value = Storedatas[0];
                datas[e.RowIndex].Store = Storedatas[0];
            }


            this.BeginInvoke((MethodInvoker)(() => {
                dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;
                dataGridView1.DataSource = null;
                RecordModel deletedata = datas[e.RowIndex];
                List<RecordModel> filterdates = datas.Where<RecordModel>(x => x.Date == deletedata.Date).ToList();
                File.Delete("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + deletedata.Date + "\\data.csv");
                CSV csv = new CSV();

                csv.WriterList("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + deletedata.Date + "\\data.csv", filterdates);


                LoadDatas();
            }));
           

        }
    }
}
