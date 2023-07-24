namespace PMEfficiency
{
    public partial class Form1 : Form
    {
        //intance of the CompareFileForm to select files location
        CompareFilesForm compareFilesForm = new CompareFilesForm();


        private Label previousClickedLabel;

        public Form1()
        {
            InitializeComponent();

        }




        private void btnCompare_Click(object sender, EventArgs e)
        {
            //open the CompareFileForm window 
            compareFilesForm.ShowDialog();
        }


        //temporary method to handle tab selection
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;

            // Revert the previous clicked label's background color (if any)
            if (previousClickedLabel != null)
            {
                previousClickedLabel.BackColor = Color.FromArgb(38, 113, 61); // Revert to the default background color
            }

            // Change the background color of the currently clicked label
            clickedLabel.BackColor = Color.DarkGreen;

            // Update the previousClickedLabel to the current clicked label
            previousClickedLabel = clickedLabel;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //toggle menu
            if (panelTabMenu.Visible)
            {
                panelTabMenu.Visible = false;
            }
            else
            {
                panelTabMenu.Visible = true;
            }

        }
    }
}