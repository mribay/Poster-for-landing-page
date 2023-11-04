using System;
using System.Windows.Forms;

namespace Poster_for_landing_page
{
    public partial class UpdateForm : Form
    {

        public MongoCRUD db;

        public UpdateForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateAddButton_Click(object sender, EventArgs e)
        {

            string id = UpdateIDTextBox.Text;
            string updateThe = UpdateTheTextBox.Text;
            string updateTo = UpdateToTextBox.Text;

            try
            {
                db.Update(id, updateThe, updateTo);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error updating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
