namespace WeatherAppForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem2 = new ListViewItem("");
            button1 = new Button();
            update = new Label();
            ApiUpdate = new System.Windows.Forms.Timer(components);
            listData = new ListView();
            property = new ColumnHeader();
            value = new ColumnHeader();
            Warnings = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(3, 5);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 0;
            button1.Text = "Daj mi dane";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Right;
            update.AutoSize = true;
            update.Location = new Point(791, 9);
            update.Name = "update";
            update.Size = new Size(0, 15);
            update.TabIndex = 1;
            // 
            // ApiUpdate
            // 
            ApiUpdate.Enabled = true;
            ApiUpdate.Interval = 10000;
            ApiUpdate.Tick += ApiUpdate_Tick;
            // 
            // listData
            // 
            listData.Columns.AddRange(new ColumnHeader[] { property, value, Warnings });
            listData.Dock = DockStyle.Fill;
            listData.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listData.Location = new Point(3, 43);
            listData.Name = "listData";
            listData.Size = new Size(794, 404);
            listData.TabIndex = 3;
            listData.UseCompatibleStateImageBehavior = false;
            listData.View = View.Details;
            // 
            // property
            // 
            property.Text = "Właściwość";
            property.Width = 120;
            // 
            // value
            // 
            value.Text = "Wartość";
            // 
            // Warnings
            // 
            Warnings.Text = "Uwagi";
            Warnings.Width = 250;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(listData, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(update, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(794, 34);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label update;
        private System.Windows.Forms.Timer ApiUpdate;
        private ListView listData;
        private ColumnHeader property;
        private ColumnHeader value;
        private ColumnHeader Warnings;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
