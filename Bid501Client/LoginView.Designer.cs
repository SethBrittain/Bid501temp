using System.Windows.Forms;

namespace Bid501Client
{
    partial class UxLoginForm
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
            this.UxLoginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UxPasswordInput = new System.Windows.Forms.TextBox();
            this.UxPasswordLabel = new System.Windows.Forms.Label();
            this.UxUsernameLabel = new System.Windows.Forms.Label();
            this.UxUsernameInput = new System.Windows.Forms.TextBox();
            this.UxLoginButton = new System.Windows.Forms.Button();
            this.UxLoginLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxLoginLayout
            // 
            this.UxLoginLayout.ColumnCount = 3;
            this.UxLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.UxLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.UxLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.UxLoginLayout.Controls.Add(this.UxPasswordInput, 1, 2);
            this.UxLoginLayout.Controls.Add(this.UxPasswordLabel, 0, 2);
            this.UxLoginLayout.Controls.Add(this.UxUsernameLabel, 0, 1);
            this.UxLoginLayout.Controls.Add(this.UxUsernameInput, 1, 1);
            this.UxLoginLayout.Controls.Add(this.UxLoginButton, 1, 3);
            this.UxLoginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLoginLayout.Location = new System.Drawing.Point(0, 0);
            this.UxLoginLayout.Name = "UxLoginLayout";
            this.UxLoginLayout.RowCount = 4;
            this.UxLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.33663F));
            this.UxLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.66337F));
            this.UxLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.UxLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.UxLoginLayout.Size = new System.Drawing.Size(347, 279);
            this.UxLoginLayout.TabIndex = 0;
            // 
            // UxPasswordInput
            // 
            this.UxPasswordInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxPasswordInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxPasswordInput.Location = new System.Drawing.Point(107, 104);
            this.UxPasswordInput.Name = "UxPasswordInput";
            this.UxPasswordInput.Size = new System.Drawing.Size(132, 29);
            this.UxPasswordInput.TabIndex = 2;
            // 
            // UxPasswordLabel
            // 
            this.UxPasswordLabel.AutoSize = true;
            this.UxPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxPasswordLabel.Location = new System.Drawing.Point(3, 101);
            this.UxPasswordLabel.Name = "UxPasswordLabel";
            this.UxPasswordLabel.Size = new System.Drawing.Size(98, 38);
            this.UxPasswordLabel.TabIndex = 0;
            this.UxPasswordLabel.Text = "Password";
            this.UxPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UxUsernameLabel
            // 
            this.UxUsernameLabel.AutoSize = true;
            this.UxUsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxUsernameLabel.Location = new System.Drawing.Point(3, 67);
            this.UxUsernameLabel.Name = "UxUsernameLabel";
            this.UxUsernameLabel.Size = new System.Drawing.Size(98, 34);
            this.UxUsernameLabel.TabIndex = 3;
            this.UxUsernameLabel.Text = "Username";
            this.UxUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UxUsernameInput
            // 
            this.UxUsernameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxUsernameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxUsernameInput.Location = new System.Drawing.Point(107, 70);
            this.UxUsernameInput.Name = "UxUsernameInput";
            this.UxUsernameInput.Size = new System.Drawing.Size(132, 29);
            this.UxUsernameInput.TabIndex = 1;
            // 
            // UxLoginButton
            // 
            this.UxLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLoginButton.Location = new System.Drawing.Point(119, 179);
            this.UxLoginButton.Margin = new System.Windows.Forms.Padding(15, 40, 15, 40);
            this.UxLoginButton.Name = "UxLoginButton";
            this.UxLoginButton.Size = new System.Drawing.Size(108, 60);
            this.UxLoginButton.TabIndex = 4;
            this.UxLoginButton.Text = "Login";
            this.UxLoginButton.UseVisualStyleBackColor = true;
            this.UxLoginButton.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // UxLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.UxLoginLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UxLoginForm";
            this.Text = "``";
            this.UxLoginLayout.ResumeLayout(false);
            this.UxLoginLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel UxLoginLayout;
        private TextBox UxPasswordInput;
        private Label UxPasswordLabel;
        private Label UxUsernameLabel;
        private TextBox UxUsernameInput;
        private Button UxLoginButton;
    }
}