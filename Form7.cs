using System;
using System.Windows.Forms;
using MongoDB.Bson;

namespace Poster_for_landing_page
{
    public partial class AddRepositoryForm : Form
    {

        public MongoCRUD db;

        public AddRepositoryForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void RepositoryCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RepositoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = RepositoryNameTextBox.Text;
                string url = RepositoryUrlTextBox.Text;

                var document = new BsonDocument
                {
                    {"type", "repository"},
                    {"name", name},
                    {"url", url},
                };

                db.Create(document);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
