using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Poster_for_landing_page
{
    public partial class DashboardForm : Form
    {

        public MongoCRUD db;

        public DashboardForm(MongoCRUD mongoCRUD)
        {
            InitializeComponent();
            db = mongoCRUD;
        }

        private void SelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = SelectedListBox.Text;
            SelectedLabel.Text = text;
            DashboardProgressBar.Show();
            LoadData(text.ToLower());
        }

        public async void LoadData(string type = "post")
        {
            string apiUrl = "http://localhost:3000/api/website"; // Replace this with your API endpoint URL

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonResponse = await client.GetStringAsync(apiUrl);
                    // Deserialize JSON data into a List of objects


                    switch (type)
                    {
                        case "post":

                            try
                            {
                                var allPostData = JsonConvert.DeserializeObject<List<Post>>(jsonResponse);
                                var postData = allPostData.Where(post => post.type == type).ToList();
                                DashboardDataGridView.DataSource = postData;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "project":
                            try
                            {
                                var allProjectData = JsonConvert.DeserializeObject<List<Project>>(jsonResponse);
                                var projectData = allProjectData.Where(project => project.type == type).ToList();
                                DashboardDataGridView.DataSource = projectData;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "repository":
                            try
                            {
                                var allRepoData = JsonConvert.DeserializeObject<List<Repository>>(jsonResponse);
                                var repoData = allRepoData.Where(repo => repo.type == type).ToList();
                                DashboardDataGridView.DataSource = repoData;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            MessageBox.Show("Error", "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    DashboardProgressBar.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DashboardProgressBar.Hide();
                }
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            SelectedListBox.SetSelected(0, true);
            LoadData(SelectedListBox.Text.ToLower());
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
       
            switch (SelectedListBox.Text.ToLower())
            {
                case "post":
                    AddPostForm addPostForm = new AddPostForm(db);
                    addPostForm.Show();
                    break;
                case "project":
                    AddProjectForm addProjectForm = new AddProjectForm(db);
                    addProjectForm.Show();
                    break;
                case "repository":
                    AddRepositoryForm addRepositoryForm = new AddRepositoryForm(db);
                    addRepositoryForm.Show();
                    break;
                default:
                    break;
            }

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DashboardProgressBar.Show();
            LoadData(SelectedListBox.Text.ToLower());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(db);
            deleteForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(db);
            updateForm.Show();
        }
    }
}
