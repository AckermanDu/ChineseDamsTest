namespace ChineseDamsTest
{
    partial class Statistics
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.locBox = new System.Windows.Forms.ComboBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staticNum = new System.Windows.Forms.Button();
            this.findcoordinate = new System.Windows.Forms.Button();
            this.crdBox = new System.Windows.Forms.ListBox();
            this.statisticsTopPanel = new System.Windows.Forms.Panel();
            this.statisticsTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // locBox
            // 
            this.locBox.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.locBox.FormattingEnabled = true;
            this.locBox.Items.AddRange(new object[] {
            "所有",
            "江苏",
            "台湾"});
            this.locBox.Location = new System.Drawing.Point(271, 83);
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(150, 40);
            this.locBox.TabIndex = 0;
            // 
            // classBox
            // 
            this.classBox.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "所有",
            "流水坝",
            "非流水坝"});
            this.classBox.Location = new System.Drawing.Point(725, 83);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(150, 40);
            this.classBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 14F);
            this.label1.Location = new System.Drawing.Point(66, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "省份/直辖市：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14F);
            this.label2.Location = new System.Drawing.Point(550, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "水坝类型：";
            // 
            // staticNum
            // 
            this.staticNum.Location = new System.Drawing.Point(344, 216);
            this.staticNum.Name = "staticNum";
            this.staticNum.Size = new System.Drawing.Size(140, 63);
            this.staticNum.TabIndex = 4;
            this.staticNum.Text = "查询数量";
            this.staticNum.UseVisualStyleBackColor = true;
            this.staticNum.Click += new System.EventHandler(this.staticNum_Click);
            // 
            // findcoordinate
            // 
            this.findcoordinate.Location = new System.Drawing.Point(544, 216);
            this.findcoordinate.Name = "findcoordinate";
            this.findcoordinate.Size = new System.Drawing.Size(140, 63);
            this.findcoordinate.TabIndex = 5;
            this.findcoordinate.Text = "导出坐标";
            this.findcoordinate.UseVisualStyleBackColor = true;
            this.findcoordinate.Click += new System.EventHandler(this.findcoordinate_Click);
            // 
            // crdBox
            // 
            this.crdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crdBox.Font = new System.Drawing.Font("等线", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crdBox.FormattingEnabled = true;
            this.crdBox.HorizontalScrollbar = true;
            this.crdBox.ItemHeight = 29;
            this.crdBox.Location = new System.Drawing.Point(16, 394);
            this.crdBox.Name = "crdBox";
            this.crdBox.Size = new System.Drawing.Size(1083, 406);
            this.crdBox.TabIndex = 6;
            // 
            // statisticsTopPanel
            // 
            this.statisticsTopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsTopPanel.Controls.Add(this.locBox);
            this.statisticsTopPanel.Controls.Add(this.classBox);
            this.statisticsTopPanel.Controls.Add(this.findcoordinate);
            this.statisticsTopPanel.Controls.Add(this.label1);
            this.statisticsTopPanel.Controls.Add(this.staticNum);
            this.statisticsTopPanel.Controls.Add(this.label2);
            this.statisticsTopPanel.Location = new System.Drawing.Point(16, 12);
            this.statisticsTopPanel.Name = "statisticsTopPanel";
            this.statisticsTopPanel.Size = new System.Drawing.Size(1083, 358);
            this.statisticsTopPanel.TabIndex = 7;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.statisticsTopPanel);
            this.Controls.Add(this.crdBox);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(1115, 870);
            this.statisticsTopPanel.ResumeLayout(false);
            this.statisticsTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox locBox;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button staticNum;
        private System.Windows.Forms.Button findcoordinate;
        private System.Windows.Forms.ListBox crdBox;
        private System.Windows.Forms.Panel statisticsTopPanel;
    }
}
