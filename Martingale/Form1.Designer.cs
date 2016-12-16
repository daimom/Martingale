namespace Martingale
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtStartProfit = new System.Windows.Forms.MaskedTextBox();
            this.txtMartinPorfit = new System.Windows.Forms.MaskedTextBox();
            this.txtScale = new System.Windows.Forms.MaskedTextBox();
            this.txtPointDistance = new System.Windows.Forms.MaskedTextBox();
            this.txtMaxSheet = new System.Windows.Forms.MaskedTextBox();
            this.txtFakeProfit = new System.Windows.Forms.MaskedTextBox();
            this.txtTestFunds = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numTotalQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInWarehousePrice = new System.Windows.Forms.MaskedTextBox();
            this.txtStartQty = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQty)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始手數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始單獲利";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "馬丁後獲利";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(282, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "比例";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(248, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "馬丁點距";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(248, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "最大張數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(484, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "浮虧比";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(467, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "測試資金";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(468, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(868, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 265);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtStartProfit
            // 
            this.txtStartProfit.Location = new System.Drawing.Point(117, 55);
            this.txtStartProfit.Mask = "000000";
            this.txtStartProfit.Name = "txtStartProfit";
            this.txtStartProfit.Size = new System.Drawing.Size(100, 22);
            this.txtStartProfit.TabIndex = 6;
            // 
            // txtMartinPorfit
            // 
            this.txtMartinPorfit.Location = new System.Drawing.Point(117, 91);
            this.txtMartinPorfit.Mask = "000000";
            this.txtMartinPorfit.Name = "txtMartinPorfit";
            this.txtMartinPorfit.Size = new System.Drawing.Size(100, 22);
            this.txtMartinPorfit.TabIndex = 6;
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(332, 23);
            this.txtScale.Mask = "0";
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(100, 22);
            this.txtScale.TabIndex = 6;
            // 
            // txtPointDistance
            // 
            this.txtPointDistance.Location = new System.Drawing.Point(332, 55);
            this.txtPointDistance.Mask = "000000";
            this.txtPointDistance.Name = "txtPointDistance";
            this.txtPointDistance.Size = new System.Drawing.Size(100, 22);
            this.txtPointDistance.TabIndex = 6;
            // 
            // txtMaxSheet
            // 
            this.txtMaxSheet.Location = new System.Drawing.Point(332, 87);
            this.txtMaxSheet.Mask = "00";
            this.txtMaxSheet.Name = "txtMaxSheet";
            this.txtMaxSheet.Size = new System.Drawing.Size(100, 22);
            this.txtMaxSheet.TabIndex = 6;
            // 
            // txtFakeProfit
            // 
            this.txtFakeProfit.Location = new System.Drawing.Point(550, 23);
            this.txtFakeProfit.Mask = "000000";
            this.txtFakeProfit.Name = "txtFakeProfit";
            this.txtFakeProfit.Size = new System.Drawing.Size(100, 22);
            this.txtFakeProfit.TabIndex = 6;
            // 
            // txtTestFunds
            // 
            this.txtTestFunds.Location = new System.Drawing.Point(550, 55);
            this.txtTestFunds.Mask = "0000000000";
            this.txtTestFunds.Name = "txtTestFunds";
            this.txtTestFunds.Size = new System.Drawing.Size(100, 22);
            this.txtTestFunds.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(697, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "計算手數";
            // 
            // numTotalQty
            // 
            this.numTotalQty.Location = new System.Drawing.Point(779, 23);
            this.numTotalQty.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTotalQty.Name = "numTotalQty";
            this.numTotalQty.Size = new System.Drawing.Size(63, 22);
            this.numTotalQty.TabIndex = 7;
            this.numTotalQty.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(663, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "起始進倉價格";
            // 
            // txtInWarehousePrice
            // 
            this.txtInWarehousePrice.Location = new System.Drawing.Point(779, 61);
            this.txtInWarehousePrice.Mask = "000000";
            this.txtInWarehousePrice.Name = "txtInWarehousePrice";
            this.txtInWarehousePrice.Size = new System.Drawing.Size(100, 22);
            this.txtInWarehousePrice.TabIndex = 8;
            // 
            // txtStartQty
            // 
            this.txtStartQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Martingale.Properties.Settings.Default, "startHandQty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtStartQty.Location = new System.Drawing.Point(117, 23);
            this.txtStartQty.Mask = "0.00";
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(100, 22);
            this.txtStartQty.TabIndex = 6;
            this.txtStartQty.Text = global::Martingale.Properties.Settings.Default.startHandQty;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "開啟資料夾";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(20, 27);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(821, 22);
            this.txtMsg.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 428);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtPointDistance);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtInWarehousePrice);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numTotalQty);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMartinPorfit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMaxSheet);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtTestFunds);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtFakeProfit);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtScale);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtStartProfit);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtStartQty);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1019, 265);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQty)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtStartQty;
        private System.Windows.Forms.MaskedTextBox txtStartProfit;
        private System.Windows.Forms.MaskedTextBox txtMartinPorfit;
        private System.Windows.Forms.MaskedTextBox txtScale;
        private System.Windows.Forms.MaskedTextBox txtPointDistance;
        private System.Windows.Forms.MaskedTextBox txtMaxSheet;
        private System.Windows.Forms.MaskedTextBox txtFakeProfit;
        private System.Windows.Forms.MaskedTextBox txtTestFunds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numTotalQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtInWarehousePrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
    }
}

