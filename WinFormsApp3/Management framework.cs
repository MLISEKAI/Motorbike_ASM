using Microsoft.VisualBasic.ApplicationServices;
using Motorcycle_management;
using Motorcycle_Management;

namespace WinFormsApp3
{
    public partial class Management_framework : Form
    {
        public Management_framework()
        {
            InitializeComponent();

            cb_Brand.Items.Add("HONDA");
            cb_Brand.Items.Add("YAMAHA");
            cb_Brand.Items.Add("SUZUKI");
            cb_Brand.Items.Add("KAWASAKI");
            cb_Brand.Items.Add("DUCATI");
            cb_Brand.Items.Add("PIAGGIO");
            cb_Brand.Items.Add("BMW MOTORRAD");
            cb_Brand.Items.Add("HARLEY-DAVIDSON");
            cb_Brand.Items.Add("KTM");
        }

        // Array of motorcycles list
        Motorcycle[] MotorcycleList = new Motorcycle[50];

        // Declare variable NumberMotorcycle to save the order of motorcycles
        int NumberMotorcycle = 0;

        // Function to display motorbike in DataGridView

        // Event handler for "Browse" button click
        private void btn_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Image.Text = openFileDialog1.FileName;
                picb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                picb_Image.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        // Event handler for the "Add" button click
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Motorcycle newMotorcycle = new Motorcycle();
            newMotorcycle.ID = txt_ID.Text;
            newMotorcycle.OwnerName = txt_Name.Text;
            newMotorcycle.Brand = cb_Brand.Text;
            newMotorcycle.Date = dtp_Date.Text;
            newMotorcycle.Image = txt_Image.Text;
            newMotorcycle.Describe = rtb_Describe.Text;

            // Add new motorcycle to the motorcycle list array
            MotorcycleList[NumberMotorcycle] = newMotorcycle;
            NumberMotorcycle++;

            // Clear the contents of the TextBox after adding
            txt_ID.Text = "";
            txt_Name.Text = "";
            cb_Brand.SelectedIndex = -1;
            dtp_Date.Value = DateTime.Now;
            txt_Image.Text = "";
            picb_Image.Image = null;
            rtb_Describe.Text = "";

            // Display the updated list of motorcycles
            DisplayMotorcycle();
        }
        
        //Store index of selected row in DataGridView
        int selectedIndex;
        // Event handler when a cell in the DataGridView is clicked
        private void dgv_Motorcycle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the selected row
            selectedIndex = e.RowIndex;
            // Check if selectedIndex is within the valid range of the array
            if (selectedIndex >= 0 && selectedIndex < NumberMotorcycle)
            {
                // Display motorcycle information line by line on the corresponding textbox
                txt_ID.Text = MotorcycleList[selectedIndex].ID;
                txt_Name.Text = MotorcycleList[selectedIndex].OwnerName;
                cb_Brand.Text = MotorcycleList[selectedIndex].Brand;
                dtp_Date.Text = MotorcycleList[selectedIndex].Date;
                txt_Image.Text = MotorcycleList[selectedIndex].Image;
                rtb_Describe.Text = MotorcycleList[selectedIndex].Describe;
            }
        }

        // Event handler for the "Edit" button click
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Check if selectedIndex is within the valid range of the array
            if (selectedIndex >= 0 && selectedIndex < NumberMotorcycle)
            {
                // Get data from textbox put into dgv
                MotorcycleList[selectedIndex].ID = txt_ID.Text;
                MotorcycleList[selectedIndex].OwnerName = txt_Name.Text;
                MotorcycleList[selectedIndex].Brand = cb_Brand.Text;
                MotorcycleList[selectedIndex].Date = dtp_Date.Text;
                MotorcycleList[selectedIndex].Image = txt_Image.Text;
                MotorcycleList[selectedIndex].Describe = rtb_Describe.Text;

                // Clear the contents of the TextBox after adding
                txt_ID.Text = "";
                txt_Name.Text = "";
                cb_Brand.SelectedIndex = -1;
                dtp_Date.Value = DateTime.Now;
                txt_Image.Text = "";
                picb_Image.Image = null;
                rtb_Describe.Text = "";

                // Display the updated list of motorcycles
                DisplayMotorcycle();
            }
        }
        public void DisplayMotorcycle()
        {
            dgv_Motorcycle.DataSource = null;
            dgv_Motorcycle.DataSource = MotorcycleList;
            dgv_Motorcycle.Refresh();
        }

        // Event handler for the "Delete" button click
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Check if the motorcycle has been selected to delete
            if (dgv_Motorcycle.SelectedRows.Count > 0)
            {
                // Get the index of the selected line
                selectedIndex = dgv_Motorcycle.SelectedRows[0].Index;

                // Ask for confirmation before deleting motorcycle
                DialogResult result = MessageBox.Show("You may want to delete?", "Notify",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // If the user confirms the deletion, proceed with the deletion
                if (result == DialogResult.OK)
                {

                    // Shift the elements in the motorcycle list array to remove the selected motorcycle
                    for (int i = selectedIndex; i < NumberMotorcycle - 1; i++)
                    {
                        MotorcycleList[i] = MotorcycleList[i + 1];
                    }

                    // Set last element to null to remove duplicate motorcycle element
                    MotorcycleList[NumberMotorcycle - 1] = null;

                    // Reduce the number of motorbikes
                    NumberMotorcycle--;

                    // Clear the contents of the TextBox after adding
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    cb_Brand.SelectedIndex = -1;
                    dtp_Date.Value = DateTime.Now;
                    txt_Image.Text = "";
                    picb_Image.Image = null;
                    rtb_Describe.Text = "";

                    // Display a success message
                    MessageBox.Show("Delete to public", "Notify", MessageBoxButtons.OK);

                    // Display the updated list of motorcycles
                    DisplayMotorcycle();
                }
            }
            else
            {
                //If the user does not select enough
                MessageBox.Show("Please select the motorcycle to delete", "Notify",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Notifly", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Exit the application completely.
                Application.Exit();
            }
        }
    }
}