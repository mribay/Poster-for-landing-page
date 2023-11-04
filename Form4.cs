using System;
using System.Windows.Forms;

namespace Poster_for_landing_page
{
    public partial class DeleteForm : Form
    {

        public MongoCRUD db;

        public DeleteForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = DeleteIDTextBox.Text;

            try
            {
                db.Delete(id);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
