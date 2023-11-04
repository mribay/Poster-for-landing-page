
namespace Poster_for_landing_page
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.DashboardTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.SelectedListBox = new System.Windows.Forms.ListBox();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DashboardDataGridView = new System.Windows.Forms.DataGridView();
            this.DashboardProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DashboardPanel.SuspendLayout();
            this.DashboardTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DashboardPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DashboardPanel.Controls.Add(this.DashboardTableLayout);
            this.DashboardPanel.Controls.Add(this.SelectedListBox);
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(372, 544);
            this.DashboardPanel.TabIndex = 0;
            // 
            // DashboardTableLayout
            // 
            this.DashboardTableLayout.ColumnCount = 2;
            this.DashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DashboardTableLayout.Controls.Add(this.DashboardLabel, 0, 0);
            this.DashboardTableLayout.Location = new System.Drawing.Point(12, 12);
            this.DashboardTableLayout.Name = "DashboardTableLayout";
            this.DashboardTableLayout.RowCount = 1;
            this.DashboardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DashboardTableLayout.Size = new System.Drawing.Size(742, 100);
            this.DashboardTableLayout.TabIndex = 1;
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.DashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.Location = new System.Drawing.Point(87, 34);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(196, 31);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "DASHBOARD";
            this.DashboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedListBox
            // 
            this.SelectedListBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SelectedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedListBox.ForeColor = System.Drawing.Color.White;
            this.SelectedListBox.FormattingEnabled = true;
            this.SelectedListBox.ItemHeight = 24;
            this.SelectedListBox.Items.AddRange(new object[] {
            "POST",
            "PROJECT",
            "REPOSITORY"});
            this.SelectedListBox.Location = new System.Drawing.Point(12, 129);
            this.SelectedListBox.Name = "SelectedListBox";
            this.SelectedListBox.Size = new System.Drawing.Size(349, 72);
            this.SelectedListBox.TabIndex = 0;
            this.SelectedListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedListBox_SelectedIndexChanged);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedLabel.Location = new System.Drawing.Point(494, 46);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(182, 31);
            this.SelectedLabel.TabIndex = 1;
            this.SelectedLabel.Text = "SELLECTED";
            this.SelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(276, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 33);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DashboardDataGridView
            // 
            this.DashboardDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DashboardDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DashboardDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashboardDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DashboardDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DashboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DashboardDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DashboardDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DashboardDataGridView.Location = new System.Drawing.Point(387, 118);
            this.DashboardDataGridView.Name = "DashboardDataGridView";
            this.DashboardDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashboardDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DashboardDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DashboardDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DashboardDataGridView.Size = new System.Drawing.Size(367, 368);
            this.DashboardDataGridView.TabIndex = 3;
            // 
            // DashboardProgressBar
            // 
            this.DashboardProgressBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DashboardProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.DashboardProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardProgressBar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.DashboardProgressBar.Location = new System.Drawing.Point(0, 0);
            this.DashboardProgressBar.MarqueeAnimationSpeed = 1;
            this.DashboardProgressBar.Name = "DashboardProgressBar";
            this.DashboardProgressBar.Size = new System.Drawing.Size(766, 5);
            this.DashboardProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.DashboardProgressBar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReloadButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateButton, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(387, 492);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 39);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 33);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadButton.BackColor = System.Drawing.Color.Orange;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(94, 3);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(85, 33);
            this.ReloadButton.TabIndex = 4;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(185, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 33);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(766, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DashboardProgressBar);
            this.Controls.Add(this.DashboardDataGridView);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.DashboardPanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardTableLayout.ResumeLayout(false);
            this.DashboardTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.ListBox SelectedListBox;
        private System.Windows.Forms.TableLayoutPanel DashboardTableLayout;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DashboardDataGridView;
        private System.Windows.Forms.ProgressBar DashboardProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}