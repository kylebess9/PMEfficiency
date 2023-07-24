namespace PMEfficiency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCompare = new Button();
            splitContainerDataGridView = new SplitContainer();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panelNavBar = new Panel();
            pictureBoxMenu = new PictureBox();
            lblHelp = new Label();
            lblSearch = new Label();
            panelTabMenu = new Panel();
            btnSharePoint = new Button();
            btnWorkbook1 = new Button();
            btnWorkbook2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainerDataGridView).BeginInit();
            splitContainerDataGridView.Panel1.SuspendLayout();
            splitContainerDataGridView.Panel2.SuspendLayout();
            splitContainerDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panelTabMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCompare
            // 
            btnCompare.BackColor = Color.FromArgb(38, 113, 61);
            btnCompare.FlatAppearance.BorderColor = Color.FromArgb(38, 113, 61);
            btnCompare.FlatStyle = FlatStyle.Flat;
            btnCompare.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompare.ForeColor = Color.White;
            btnCompare.Location = new Point(0, 579);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(170, 42);
            btnCompare.TabIndex = 0;
            btnCompare.Text = "Compare Files";
            btnCompare.UseVisualStyleBackColor = false;
            btnCompare.Click += btnCompare_Click;
            // 
            // splitContainerDataGridView
            // 
            splitContainerDataGridView.BackColor = Color.White;
            splitContainerDataGridView.Dock = DockStyle.Fill;
            splitContainerDataGridView.Location = new Point(170, 36);
            splitContainerDataGridView.Name = "splitContainerDataGridView";
            // 
            // splitContainerDataGridView.Panel1
            // 
            splitContainerDataGridView.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainerDataGridView.Panel2
            // 
            splitContainerDataGridView.Panel2.Controls.Add(dataGridView2);
            splitContainerDataGridView.Size = new Size(1179, 846);
            splitContainerDataGridView.SplitterDistance = 579;
            splitContainerDataGridView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, NameColumn, Description });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(579, 846);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 43;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 64;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(596, 846);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.FromArgb(64, 64, 64);
            panelNavBar.Controls.Add(pictureBoxMenu);
            panelNavBar.Controls.Add(lblHelp);
            panelNavBar.Controls.Add(lblSearch);
            panelNavBar.Dock = DockStyle.Top;
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(1349, 36);
            panelNavBar.TabIndex = 3;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = (Image)resources.GetObject("pictureBoxMenu.Image");
            pictureBoxMenu.Location = new Point(7, 6);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(28, 28);
            pictureBoxMenu.TabIndex = 2;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += Menu_Click;
            // 
            // lblHelp
            // 
            lblHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHelp.BackColor = Color.FromArgb(64, 64, 64);
            lblHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHelp.ForeColor = Color.White;
            lblHelp.Location = new Point(1294, 3);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(43, 30);
            lblHelp.TabIndex = 1;
            lblHelp.Text = "   ?";
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.BackColor = Color.White;
            lblSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(1148, 7);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(140, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search               ";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTabMenu
            // 
            panelTabMenu.BackColor = Color.FromArgb(38, 113, 61);
            panelTabMenu.Controls.Add(btnSharePoint);
            panelTabMenu.Controls.Add(btnWorkbook1);
            panelTabMenu.Controls.Add(btnWorkbook2);
            panelTabMenu.Controls.Add(btnCompare);
            panelTabMenu.Dock = DockStyle.Left;
            panelTabMenu.Location = new Point(0, 36);
            panelTabMenu.Name = "panelTabMenu";
            panelTabMenu.Size = new Size(170, 846);
            panelTabMenu.TabIndex = 4;
            // 
            // btnSharePoint
            // 
            btnSharePoint.BackColor = Color.FromArgb(38, 113, 61);
            btnSharePoint.FlatAppearance.BorderColor = Color.FromArgb(38, 113, 61);
            btnSharePoint.FlatStyle = FlatStyle.Flat;
            btnSharePoint.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSharePoint.ForeColor = Color.White;
            btnSharePoint.Location = new Point(0, 133);
            btnSharePoint.Name = "btnSharePoint";
            btnSharePoint.Size = new Size(170, 42);
            btnSharePoint.TabIndex = 3;
            btnSharePoint.Text = "Share Point";
            btnSharePoint.UseVisualStyleBackColor = false;
            // 
            // btnWorkbook1
            // 
            btnWorkbook1.BackColor = Color.FromArgb(38, 113, 61);
            btnWorkbook1.FlatAppearance.BorderColor = Color.FromArgb(38, 113, 61);
            btnWorkbook1.FlatStyle = FlatStyle.Flat;
            btnWorkbook1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkbook1.ForeColor = Color.White;
            btnWorkbook1.Location = new Point(0, 181);
            btnWorkbook1.Name = "btnWorkbook1";
            btnWorkbook1.Size = new Size(170, 42);
            btnWorkbook1.TabIndex = 2;
            btnWorkbook1.Text = "Workbook 1";
            btnWorkbook1.UseVisualStyleBackColor = false;
            // 
            // btnWorkbook2
            // 
            btnWorkbook2.BackColor = Color.FromArgb(38, 113, 61);
            btnWorkbook2.FlatAppearance.BorderColor = Color.FromArgb(38, 113, 61);
            btnWorkbook2.FlatStyle = FlatStyle.Flat;
            btnWorkbook2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkbook2.ForeColor = Color.White;
            btnWorkbook2.Location = new Point(0, 229);
            btnWorkbook2.Name = "btnWorkbook2";
            btnWorkbook2.Size = new Size(170, 42);
            btnWorkbook2.TabIndex = 1;
            btnWorkbook2.Text = "Workbook 2";
            btnWorkbook2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 882);
            Controls.Add(splitContainerDataGridView);
            Controls.Add(panelTabMenu);
            Controls.Add(panelNavBar);
            Name = "Form1";
            Text = "Excel Compare";
            splitContainerDataGridView.Panel1.ResumeLayout(false);
            splitContainerDataGridView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerDataGridView).EndInit();
            splitContainerDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panelTabMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCompare;
        private SplitContainer splitContainerDataGridView;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Description;
        private Panel panelNavBar;
        private Panel panelTabMenu;
        private Label lblSearch;
        private Label lblHelp;
        private PictureBox pictureBoxMenu;
        private Button btnSharePoint;
        private Button btnWorkbook1;
        private Button btnWorkbook2;
    }
}