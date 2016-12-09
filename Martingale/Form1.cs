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
            public int inWarehouseCose { get; set; }
            [DisplayName("累積成本")]
            public int sumCost { get; set; }
            [DisplayName("平均價格")]
            public int avgPrice { get; set; }
            [DisplayName("獲利價格")]
            public int profitPrice { get; set; }
            [DisplayName("最遠馬丁距離")]
            public int longMartingDistance { get; set; }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal startHandQty = Convert.ToDecimal(txtStartQty.Text);
            int startProfit = Convert.ToInt32(txtStartProfit.Text);
            int martingProfit = Convert.ToInt32(txtMartinPorfit.Text);
            //int warehoucePrice = Convert.ToInt32()
            decimal scale = Convert.ToDecimal(txtScale.Text);
            int pointDistance = Convert.ToInt32(txtPointDistance);
            int maxSheet = Convert.ToInt32(txtMaxSheet.Text);
            int fakeProfit = Convert.ToInt32(txtFakeProfit.Text);
            int testFunds = Convert.ToInt32(txtTestFunds.Text);

            List<MartingCalculus> ListMarting = new List<MartingCalculus>();
            int MaxTotalQty = Convert.ToInt32(numTotalQty.Value);

            decimal preHandQty, preWarehourcePrice;
            for (int i = 1; i <= MaxTotalQty; i++)  //算10手
            {
                //if (i == 1)
                //{
                //    preHandQty = startHandQty;
                //    preWarehourcePrice = start
                //}
            
                MartingCalculus MC = new MartingCalculus();
                MC.sn = i;
                MC.handQty = i==1 ? startHandQty : startHandQty * scale;
                //MC.sumHandQty = i == 1 ? startHandQty : startHandQty +
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
