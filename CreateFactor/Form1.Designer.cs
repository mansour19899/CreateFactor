namespace CreateFactor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbPart = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.kala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(110, 602);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(101, 47);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "خروج";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.Location = new System.Drawing.Point(913, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 46);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "تاریخ";
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDate.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(757, 39);
            this.txtDate.Name = "txtDate";
            this.txtDate.PreventEnterBeep = true;
            this.txtDate.Size = new System.Drawing.Size(137, 41);
            this.txtDate.TabIndex = 2;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPart
            // 
            this.cmbPart.DisplayMember = "Text";
            this.cmbPart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPart.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPart.ForeColor = System.Drawing.Color.Navy;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.ItemHeight = 36;
            this.cmbPart.Location = new System.Drawing.Point(406, 39);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPart.Size = new System.Drawing.Size(212, 42);
            this.cmbPart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbPart.TabIndex = 3;
            this.cmbPart.WatermarkColor = System.Drawing.Color.Gray;
            // 
            // txtNumber
            // 
            // 
            // 
            // 
            this.txtNumber.Border.Class = "TextBoxBorder";
            this.txtNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumber.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumber.Location = new System.Drawing.Point(54, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PreventEnterBeep = true;
            this.txtNumber.Size = new System.Drawing.Size(137, 41);
            this.txtNumber.TabIndex = 7;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(206, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 46);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "شماره";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewX1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kala,
            this.count,
            this.unit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(82, 177);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewX1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridViewX1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dataGridViewX1.RowTemplate.ErrorText = "52";
            this.dataGridViewX1.RowTemplate.Height = 30;
            this.dataGridViewX1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.ShowCellToolTips = false;
            this.dataGridViewX1.ShowRowErrors = false;
            this.dataGridViewX1.Size = new System.Drawing.Size(882, 377);
            this.dataGridViewX1.TabIndex = 8;
            // 
            // kala
            // 
            this.kala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kala.FillWeight = 30.45685F;
            this.kala.HeaderText = "شرح جنس";
            this.kala.Name = "kala";
            this.kala.Width = 600;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.FillWeight = 134.7716F;
            this.count.HeaderText = "تعداد";
            this.count.Name = "count";
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 134.7716F;
            this.unit.HeaderText = "واحد";
            this.unit.Name = "unit";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(453, 602);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(208, 70);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 9;
            this.buttonX2.Text = "صدور فاکتور";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "162e3ce256194ef688edb9e83a71d98d";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Millimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 695);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور فاکتور";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPart;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNumber;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kala;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}

