using OfficeOpenXml;
using OfficeOpenXml.Style;
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

namespace Martingale
{
    public partial class Form1 : Form
    {
        private class MartingCalculus
        {
            public int sn { get; set; }
            [DisplayName("手數")]
            public decimal handQty { get; set; }
            [DisplayName("累積手數")]
            public decimal sumHandQty { get; set; }
            [DisplayName("距前一單點數")]
            public int diffDistance { get; set; }
            [DisplayName("進倉價格")]
            public int inWarehousePrice { get; set; }
            [DisplayName("進倉成本")]
            public int inWarehouseCost { get; set; }
            [DisplayName("累積成本")]
            public int sumCost { get; set; }
            [DisplayName("平均價格")]
            public int avgPrice { get; set; }
            [DisplayName("獲利價格")]
            public int profitPrice { get; set; }
            [DisplayName("最遠馬丁距離")]
            public int longMartingDistance { get; set; }

        }
        private string saveFilePath;
        public Form1()
        {
            InitializeComponent();
            //if (!System.IO.Directory.Exists("data"))
            //    System.IO.Directory.CreateDirectory("data");
            
        }
        #region Control
       
        private void Form1_Load(object sender, EventArgs e)
        {
            txtFakeProfit.Text = "100";
            txtInWarehousePrice.Text = "110500";
            txtMartinPorfit.Text = "30";
            txtMaxSheet.Text = "5";
            txtPointDistance.Text = "230";
            txtScale.Text = "4";
            txtStartProfit.Text = "100";
            txtStartQty.Text = "0.04";
            txtTestFunds.Text = "10000";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory + "data\\");
            System.Diagnostics.Process.Start("explorer.exe", saveFilePath);
        }
        /// <summary>
        /// 匯出按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            int maxSheet;
            List<MartingCalculus> BuyListMarting;
            getData(out maxSheet, out BuyListMarting, "Buy");

            List<MartingCalculus> SelListMarting;
            getData(out maxSheet, out SelListMarting, "Sel");

            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                string fileName = saveFileDialog1.FileName;
                saveFilePath = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.LastIndexOf("\\"));
                exportExcell(fileName,BuyListMarting, SelListMarting);
            }
            
        }
        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about fm = new about();
            fm.Show();
        }
        /// <summary>
        /// 查詢按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int maxSheet;
            List<MartingCalculus> ListMarting;
            //buy
            tabControl1.SelectedIndex = 0;
            getData(out maxSheet, out ListMarting, "Buy");
            dataGridView1.DataSource = ListMarting;
            setGridView(maxSheet, dataGridView1);
            //sel
            tabControl1.SelectedIndex = 1;
            getData(out maxSheet, out ListMarting, "Sel");
            dataGridView2.DataSource = ListMarting;
            setGridView(maxSheet, dataGridView2);
        }

        #endregion

        #region function
        /// <summary>
        /// 資料產生
        /// </summary>
        /// <param name="maxSheet">最大手數</param>
        /// <param name="ListMarting">資料</param>
        private void getData(out int maxSheet, out List<MartingCalculus> ListMarting,string type)
        {
            decimal startHandQty = Convert.ToDecimal(txtStartQty.Text);
            int startProfit = Convert.ToInt32(txtStartProfit.Text);
            int martingProfit = Convert.ToInt32(txtMartinPorfit.Text);
            int warehoucePrice = Convert.ToInt32(txtInWarehousePrice.Text);
            decimal scale = Convert.ToDecimal(txtScale.Text);
            int pointDistance = Convert.ToInt32(txtPointDistance.Text);
            maxSheet = Convert.ToInt32(txtMaxSheet.Text);
            int fakeProfit = Convert.ToInt32(txtFakeProfit.Text);
            int testFunds = Convert.ToInt32(txtTestFunds.Text);

            ListMarting = new List<MartingCalculus>();
            int MaxTotalQty = Convert.ToInt32(numTotalQty.Value);

            for (int i = 1; i <= MaxTotalQty; i++)  //算10手
            {
                MartingCalculus MC = new MartingCalculus();
                var LastMC = ListMarting.Count == 0 ? null : ListMarting.Last();
                if (LastMC == null)
                {

                    MC.handQty = startHandQty;
                    MC.diffDistance = 0;
                    MC.inWarehousePrice = warehoucePrice;
                    MC.longMartingDistance = 0;

                }
                else
                {
                    MC.handQty = ListMarting.Last().handQty * scale;
                    MC.inWarehousePrice = type=="Buy" ? ListMarting.Last().inWarehousePrice - pointDistance : ListMarting.Last().inWarehousePrice + pointDistance;
                    MC.longMartingDistance = type=="Buy" ? ListMarting.First().inWarehousePrice - MC.inWarehousePrice : MC.inWarehousePrice - ListMarting.First().inWarehousePrice;
                }
                MC.sn = i;
                MC.sumHandQty = LastMC == null ? MC.handQty : ListMarting.Sum(p => p.handQty) + MC.handQty;
                MC.inWarehouseCost = Convert.ToInt32(MC.handQty * MC.inWarehousePrice);
                MC.sumCost = LastMC == null ? MC.inWarehouseCost : ListMarting.Sum(p => p.inWarehouseCost) + MC.inWarehouseCost;
                MC.avgPrice = Convert.ToInt32(MC.sumCost / MC.sumHandQty);
                MC.profitPrice = MC.avgPrice + (LastMC == null ? startProfit : martingProfit);
                ListMarting.Add(MC);
            }
        }
        /// <summary>
        /// 超過最大筆數標示
        /// </summary>
        /// <param name="maxSheet"></param>
        private void setGridView(int maxSheet, DataGridView gv)
        {
            
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                
                if (i + 1 > maxSheet)
                {
                    gv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        /// <summary>
        /// 匯出excel
        /// </summary>
        /// <param name="ListMarting"></param>
        private void exportExcell(string strFilePath,List<MartingCalculus> BuyListMarting, List<MartingCalculus>  SelListMarting)
        {
            //string pathFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            //string strFilePath = AppDomain.CurrentDomain.BaseDirectory + "data\\" + pathFileName;
   
            ExcelPackage export = new ExcelPackage();
            using (FileStream OutputStream = new FileStream(strFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                export.Workbook.Worksheets.Add("buy");
                export.Workbook.Worksheets.Add("sel");
                for (int sheetCount = 1;sheetCount < 3; sheetCount++)
                {                    
                    ExcelWorksheet sheet1;
                    sheet1 = sheetCount == 1 ? export.Workbook.Worksheets["buy"] : export.Workbook.Worksheets["sel"];
                                        
                    sheet1.Cells["B2"].Value = "資金控管";
                    sheet1.Cells["C2"].Value = "本金";
                    sheet1.Cells["D2"].Value = txtTestFunds.Text;
                    sheet1.Cells["E2"].Value = "浮虧比";
                    sheet1.Cells["F2"].Value = "";  //浮虧比欄位
                    sheet1.Cells["G2"].Value = "停損金額";
                    sheet1.Cells["H2"].Value = "";

                    sheet1.Cells["B4:B5"].Merge = true;
                    sheet1.Cells["B4:B5"].Value = "馬丁策略";
                    sheet1.Cells["C4"].Value = "起始手數";
                    sheet1.Cells["D4"].Value = txtStartQty.Text;
                    sheet1.Cells["C5"].Value = "馬丁比例";
                    sheet1.Cells["D5"].Value = txtScale.Text;
                    sheet1.Cells["E5"].Value = "馬丁點距";
                    sheet1.Cells["F5"].Value = txtPointDistance.Text;
                    sheet1.Cells["G4"].Value = "起始獲利點數";
                    sheet1.Cells["H4"].Value = txtStartProfit.Text;
                    sheet1.Cells["G5"].Value = "馬丁獲利點數";
                    sheet1.Cells["H5"].Value = txtMartinPorfit.Text;

                    sheet1.Cells[7, 2].Value = "進單序";
                    sheet1.Cells[7, 3].Value = "手數";
                    sheet1.Cells[7, 4].Value = "累積手數";
                    sheet1.Cells[7, 5].Value = "距前一單點數";
                    sheet1.Cells[7, 6].Value = "進倉價格";
                    sheet1.Cells[7, 7].Value = "進倉成本";
                    sheet1.Cells[7, 8].Value = "累積成本";
                    sheet1.Cells[7, 9].Value = "平均價格";
                    sheet1.Cells[7, 10].Value = "獲利價格";
                    sheet1.Cells[7, 11].Value = "最遠馬丁距離";
                    sheet1.Cells[7, 12].Value = "反彈距離比";
                    sheet1.Cells[7, 13].Value = "反彈距離";
                    sheet1.Cells[7, 14].Value = "虧損金額";
                    sheet1.Cells[7, 15].Value = "耐受區間";
                    sheet1.Cells[7, 16].Value = "獲利金額";
                    if(sheetCount==1)
                        sheet1.Cells[8, 2].LoadFromCollection<MartingCalculus>(BuyListMarting);
                    else
                        sheet1.Cells[8, 2].LoadFromCollection<MartingCalculus>(SelListMarting);
                    int MaxSheet = Convert.ToInt32(txtMaxSheet.Text);
                    setSheetStyle(MaxSheet, sheet1);
                }
                export.SaveAs(OutputStream);
                OutputStream.Close();
                

            }
            txtMsg.Text = string.Format("檔案： {0}，產生完成。請按『開啟資料夾』", strFilePath);
        }
        /// <summary>
        /// 樣式設定
        /// </summary>
        /// <param name="MaxSheet"></param>
        /// <param name="sheet1"></param>
        private static void setSheetStyle(int MaxSheet, ExcelWorksheet sheet1)
        {
            //樣式設定
            Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#4bbcf4");
            sheet1.Cells["B2"].Style.Fill.PatternType = ExcelFillStyle.Solid;   //設定背景的實線
            sheet1.Cells["B2"].Style.Fill.BackgroundColor.SetColor(colFromHex);
            sheet1.Cells["B4:B5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["B4:B5"].Style.Fill.BackgroundColor.SetColor(colFromHex);

            Color TEXT = System.Drawing.ColorTranslator.FromHtml("#bbded6");
            sheet1.Cells["D2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["D2"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["F2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["F2"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["H2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["H2"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["D4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["D4"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["D5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["D5"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["F5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["F5"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["H4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["H4"].Style.Fill.BackgroundColor.SetColor(TEXT);
            sheet1.Cells["H5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells["H5"].Style.Fill.BackgroundColor.SetColor(TEXT);


            int endRow = sheet1.Dimension.End.Row;
            int endColumn = sheet1.Dimension.End.Column;
            sheet1.Cells[7, 1, 7, endColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet1.Cells[1, 1, endRow, endColumn].Style.Font.SetFromFont(new Font("Arial", 12));  //這個要先打
            sheet1.Cells[1, 1, 7, endColumn].Style.Font.Bold = true;


            sheet1.Column(1).Width = 1;
            sheet1.Row(1).Height = 5;
            //調整寬度
            for (int i = 2; i < endColumn; i++)
            {
                sheet1.Column(i).AutoFit();
                sheet1.Column(i).Width += 10;
            }
            

            sheet1.Cells[8+MaxSheet,2,endRow,endColumn].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet1.Cells[8 + MaxSheet, 2, endRow, endColumn].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#ffb6b9"));
            
        }

        #endregion
    }
}
