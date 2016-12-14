using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martingale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
        /// <summary>
        /// Buy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal startHandQty = Convert.ToDecimal(txtStartQty.Text);
            int startProfit = Convert.ToInt32(txtStartProfit.Text);
            int martingProfit = Convert.ToInt32(txtMartinPorfit.Text);
            int warehoucePrice = Convert.ToInt32(txtInWarehousePrice.Text);
            decimal scale = Convert.ToDecimal(txtScale.Text);
            int pointDistance = Convert.ToInt32(txtPointDistance.Text);
            int maxSheet = Convert.ToInt32(txtMaxSheet.Text);
            int fakeProfit = Convert.ToInt32(txtFakeProfit.Text);
            int testFunds = Convert.ToInt32(txtTestFunds.Text);

            List<MartingCalculus> ListMarting = new List<MartingCalculus>();
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
                    MC.inWarehousePrice = ListMarting.Last().inWarehousePrice - pointDistance;
                    MC.longMartingDistance = ListMarting.First().inWarehousePrice - MC.inWarehousePrice;                    
                }
                MC.sn = i;
                MC.sumHandQty = LastMC == null ? MC.handQty : ListMarting.Sum(p=>p.handQty) + MC.handQty;
                MC.inWarehouseCost = Convert.ToInt32(MC.handQty * MC.inWarehousePrice);
                MC.sumCost = LastMC == null ? MC.inWarehouseCost :ListMarting.Sum(p => p.inWarehouseCost) + MC.inWarehouseCost;
                MC.avgPrice = Convert.ToInt32(MC.sumCost / MC.sumHandQty);
                MC.profitPrice = MC.avgPrice + (LastMC == null ? startProfit : martingProfit) ;
                ListMarting.Add(MC);
            }
            dataGridView1.DataSource = ListMarting;
            setGridView(maxSheet);
            

        }

        private void setGridView(int maxSheet)
        {
            //this.dataGridView1.Columns[5].DefaultCellStyle.Format = "N5";
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                
                if (i + 1 > maxSheet)
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
