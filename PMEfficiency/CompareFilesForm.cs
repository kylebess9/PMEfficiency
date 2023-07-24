using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMEfficiency
{
    public partial class CompareFilesForm : Form
    {
        public CompareFilesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenCompare_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCompare = new OpenFileDialog();
            if (openFileDialogCompare.ShowDialog() == DialogResult.OK)
            {
                lblOutputCompare.Text = openFileDialogCompare.FileName;

            }
        }

        private void btnOpenTo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTo = new OpenFileDialog();
            if (openFileDialogTo.ShowDialog() == DialogResult.OK)
            {
                lblOutputTo.Text = openFileDialogTo.FileName;

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
