namespace PMEfficiency
{
    partial class CompareFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareFilesForm));
            btnOk = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblOutputCompare = new Label();
            lblOutputTo = new Label();
            btnOpenCompare = new Button();
            btnOpenTo = new Button();
            openFD = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(477, 237);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(123, 33);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(624, 237);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 2;
            label1.Text = "Brower and select files to compare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Compare:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 159);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 4;
            label3.Text = "To:";
            // 
            // lblOutputCompare
            // 
            lblOutputCompare.BackColor = Color.White;
            lblOutputCompare.BorderStyle = BorderStyle.FixedSingle;
            lblOutputCompare.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputCompare.Location = new Point(123, 97);
            lblOutputCompare.Name = "lblOutputCompare";
            lblOutputCompare.Size = new Size(558, 31);
            lblOutputCompare.TabIndex = 5;
            // 
            // lblOutputTo
            // 
            lblOutputTo.BackColor = Color.White;
            lblOutputTo.BorderStyle = BorderStyle.FixedSingle;
            lblOutputTo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputTo.Location = new Point(123, 158);
            lblOutputTo.Name = "lblOutputTo";
            lblOutputTo.Size = new Size(558, 31);
            lblOutputTo.TabIndex = 6;
            // 
            // btnOpenCompare
            // 
            btnOpenCompare.Image = (Image)resources.GetObject("btnOpenCompare.Image");
            btnOpenCompare.Location = new Point(699, 95);
            btnOpenCompare.Name = "btnOpenCompare";
            btnOpenCompare.Size = new Size(48, 33);
            btnOpenCompare.TabIndex = 7;
            btnOpenCompare.UseVisualStyleBackColor = true;
            btnOpenCompare.Click += btnOpenCompare_Click;
            // 
            // btnOpenTo
            // 
            btnOpenTo.Image = (Image)resources.GetObject("btnOpenTo.Image");
            btnOpenTo.Location = new Point(699, 154);
            btnOpenTo.Name = "btnOpenTo";
            btnOpenTo.Size = new Size(48, 33);
            btnOpenTo.TabIndex = 8;
            btnOpenTo.UseVisualStyleBackColor = true;
            btnOpenTo.Click += btnOpenTo_Click;
            // 
            // openFD
            // 
            openFD.FileName = "openFileDialog1";
            // 
            // CompareFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 308);
            Controls.Add(btnOpenTo);
            Controls.Add(btnOpenCompare);
            Controls.Add(lblOutputTo);
            Controls.Add(lblOutputCompare);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnOk);
            Name = "CompareFilesForm";
            Text = "CompareFilesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOpenCompare;
        private Button btnOpenTo;
        private OpenFileDialog openFD;
        public Label lblOutputCompare;
        public Label lblOutputTo;
    }
}