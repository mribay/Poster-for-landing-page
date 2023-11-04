using System;
using System.Windows.Forms;
using MongoDB.Bson;

namespace Poster_for_landing_page
{
    public partial class AddPostForm : Form
    {

        public MongoCRUD db;

        public AddPostForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void PostAddButton_Click(object sender, EventArgs e)
        {

            try
            {
                string header = PostHeaderTextBox.Text;
                string subHeader = PostSubHeaderTextBox.Text;
                string body = PostBodyTextBox.Text;

                var document = new BsonDocument
                {
                    {"type", "post"},
                    {"header", header},
                    {"subHeader", subHeader},
                    {"body", body}
                };

                db.Create(document);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddPostForm_Load(object sender, EventArgs e)
        {
        }

        private void PostCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
