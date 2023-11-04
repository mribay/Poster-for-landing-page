
namespace Poster_for_landing_page
{
    partial class AddRepositoryForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RepositoryCancelButton = new System.Windows.Forms.Button();
            this.RepositoryAddButton = new System.Windows.Forms.Button();
            this.RepositoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RepositoryUrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RepositoryCancelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RepositoryAddButton, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 254);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 50);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // RepositoryCancelButton
            // 
            this.RepositoryCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RepositoryCancelButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RepositoryCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RepositoryCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.RepositoryCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepositoryCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepositoryCancelButton.Location = new System.Drawing.Point(3, 6);
            this.RepositoryCancelButton.Name = "RepositoryCancelButton";
            this.RepositoryCancelButton.Size = new System.Drawing.Size(268, 38);
            this.RepositoryCancelButton.TabIndex = 7;
            this.RepositoryCancelButton.Text = "Cancel";
            this.RepositoryCancelButton.UseVisualStyleBackColor = false;
            this.RepositoryCancelButton.Click += new System.EventHandler(this.RepositoryCancelButton_Click);
            // 
            // RepositoryAddButton
            // 
            this.RepositoryAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RepositoryAddButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RepositoryAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RepositoryAddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.RepositoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepositoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepositoryAddButton.Location = new System.Drawing.Point(277, 6);
            this.RepositoryAddButton.Name = "RepositoryAddButton";
            this.RepositoryAddButton.Size = new System.Drawing.Size(269, 38);
            this.RepositoryAddButton.TabIndex = 6;
            this.RepositoryAddButton.Text = "Add";
            this.RepositoryAddButton.UseVisualStyleBackColor = false;
            this.RepositoryAddButton.Click += new System.EventHandler(this.RepositoryAddButton_Click);
            // 
            // RepositoryNameTextBox
            // 
            this.RepositoryNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepositoryNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RepositoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepositoryNameTextBox.Location = new System.Drawing.Point(71, 68);
            this.RepositoryNameTextBox.Name = "RepositoryNameTextBox";
            this.RepositoryNameTextBox.Size = new System.Drawing.Size(436, 20);
            this.RepositoryNameTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // RepositoryUrlTextBox
            // 
            this.RepositoryUrlTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepositoryUrlTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RepositoryUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepositoryUrlTextBox.Location = new System.Drawing.Point(71, 133);
            this.RepositoryUrlTextBox.Name = "RepositoryUrlTextBox";
            this.RepositoryUrlTextBox.Size = new System.Drawing.Size(436, 20);
            this.RepositoryUrlTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Url";
            // 
            // AddRepositoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(573, 348);
            this.Controls.Add(this.RepositoryUrlTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RepositoryNameTextBox);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRepositoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Repository";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RepositoryCancelButton;
        private System.Windows.Forms.Button RepositoryAddButton;
        private System.Windows.Forms.TextBox RepositoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RepositoryUrlTextBox;
        private System.Windows.Forms.Label label1;
    }
}