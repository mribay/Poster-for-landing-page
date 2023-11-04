
namespace Poster_for_landing_page
{
    partial class CredentialsForm
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
            this.ConnectionString = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CredentialsProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ConnectionString, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConnectButton, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ConnectionString
            // 
            this.ConnectionString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionString.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionString.ForeColor = System.Drawing.Color.Black;
            this.ConnectionString.Location = new System.Drawing.Point(3, 49);
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.PasswordChar = '*';
            this.ConnectionString.Size = new System.Drawing.Size(279, 20);
            this.ConnectionString.TabIndex = 0;
            this.ConnectionString.UseSystemPasswordChar = true;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ConnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConnectButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(34, 158);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(216, 38);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CredentialsProgressBar
            // 
            this.CredentialsProgressBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CredentialsProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.CredentialsProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CredentialsProgressBar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CredentialsProgressBar.Location = new System.Drawing.Point(0, 0);
            this.CredentialsProgressBar.MarqueeAnimationSpeed = 1;
            this.CredentialsProgressBar.Name = "CredentialsProgressBar";
            this.CredentialsProgressBar.Size = new System.Drawing.Size(346, 5);
            this.CredentialsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CredentialsProgressBar.TabIndex = 1;
            // 
            // CredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(346, 260);
            this.Controls.Add(this.CredentialsProgressBar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CredentialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credentials";
            this.Load += new System.EventHandler(this.CredentialsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ConnectionString;
        private System.Windows.Forms.ProgressBar CredentialsProgressBar;
    }
}

