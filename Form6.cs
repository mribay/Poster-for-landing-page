using System;
using System.Windows.Forms;
using MongoDB.Bson;

namespace Poster_for_landing_page
{
    public partial class AddProjectForm : Form
    {

        public MongoCRUD db;

        public AddProjectForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void ProjectCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProjectAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string header = ProjectHeaderTextBox.Text;
                string body = ProjectBodyTextBox.Text;
                string url = ProjectUrlTextBox.Text;
                string imageUrl = ProjectImageUrlTextBox.Text;

                var document = new BsonDocument
                {
                    {"type", "project"},
                    {"header", header},
                    {"body", body},
                    {"url", url},
                    {"imageUrl", imageUrl},
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
