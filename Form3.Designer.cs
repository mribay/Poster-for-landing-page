
namespace Poster_for_landing_page
{
    partial class AddPostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PostHeaderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PostSubHeaderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PostBodyTextBox = new System.Windows.Forms.TextBox();
            this.PostAddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PostCancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header";
            // 
            // PostHeaderTextBox
            // 
            this.PostHeaderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PostHeaderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostHeaderTextBox.Location = new System.Drawing.Point(72, 69);
            this.PostHeaderTextBox.Name = "PostHeaderTextBox";
            this.PostHeaderTextBox.Size = new System.Drawing.Size(436, 22);
            this.PostHeaderTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Header";
            // 
            // PostSubHeaderTextBox
            // 
            this.PostSubHeaderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PostSubHeaderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostSubHeaderTextBox.Location = new System.Drawing.Point(72, 139);
            this.PostSubHeaderTextBox.Name = "PostSubHeaderTextBox";
            this.PostSubHeaderTextBox.Size = new System.Drawing.Size(436, 22);
            this.PostSubHeaderTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Body";
            // 
            // PostBodyTextBox
            // 
            this.PostBodyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PostBodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostBodyTextBox.Location = new System.Drawing.Point(72, 210);
            this.PostBodyTextBox.Multiline = true;
            this.PostBodyTextBox.Name = "PostBodyTextBox";
            this.PostBodyTextBox.Size = new System.Drawing.Size(436, 172);
            this.PostBodyTextBox.TabIndex = 5;
            // 
            // PostAddButton
            // 
            this.PostAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostAddButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PostAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PostAddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PostAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostAddButton.Location = new System.Drawing.Point(277, 6);
            this.PostAddButton.Name = "PostAddButton";
            this.PostAddButton.Size = new System.Drawing.Size(269, 38);
            this.PostAddButton.TabIndex = 6;
            this.PostAddButton.Text = "Add";
            this.PostAddButton.UseVisualStyleBackColor = false;
            this.PostAddButton.Click += new System.EventHandler(this.PostAddButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PostCancelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PostAddButton, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 424);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 50);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PostCancelButton
            // 
            this.PostCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostCancelButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PostCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PostCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PostCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostCancelButton.Location = new System.Drawing.Point(3, 6);
            this.PostCancelButton.Name = "PostCancelButton";
            this.PostCancelButton.Size = new System.Drawing.Size(268, 38);
            this.PostCancelButton.TabIndex = 7;
            this.PostCancelButton.Text = "Cancel";
            this.PostCancelButton.UseVisualStyleBackColor = false;
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(573, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PostBodyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PostSubHeaderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostHeaderTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Post";
            this.Load += new System.EventHandler(this.AddPostForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostHeaderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PostSubHeaderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PostBodyTextBox;
        private System.Windows.Forms.Button PostAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PostCancelButton;
    }
}