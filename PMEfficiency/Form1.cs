namespace PMEfficiency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void btnSharePoint_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                ExcelFileHandler SharePoint = new ExcelFileHandler(openFileDialog.FileName);
                
                
            }
        }

        private void btnLoadFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelFileHandler File1 = new ExcelFileHandler(openFileDialog.FileName);

            }

        }
    }
}