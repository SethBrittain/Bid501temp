using System.Windows.Forms;

namespace Bid501Server
{
    partial class ServerView
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
            this.UxServerFormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.UxServerFormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxServerFormLayout
            // 
            this.UxServerFormLayout.ColumnCount = 2;
            this.UxServerFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UxServerFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UxServerFormLayout.Controls.Add(this.button1, 0, 1);
            this.UxServerFormLayout.Controls.Add(this.listView1, 0, 0);
            this.UxServerFormLayout.Controls.Add(this.listView2, 1, 0);
            this.UxServerFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxServerFormLayout.Location = new System.Drawing.Point(0, 0);
            this.UxServerFormLayout.Name = "UxServerFormLayout";
            this.UxServerFormLayout.RowCount = 2;
            this.UxServerFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.77778F));
            this.UxServerFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22222F));
            this.UxServerFormLayout.Size = new System.Drawing.Size(362, 331);
            this.UxServerFormLayout.TabIndex = 0;
            // 
            // button1
            // 
            this.UxServerFormLayout.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(120, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(15, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 247);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(196, 15);
            this.listView2.Margin = new System.Windows.Forms.Padding(15);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(151, 247);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 331);
            this.Controls.Add(this.UxServerFormLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.UxServerFormLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel UxServerFormLayout;
        private Button button1;
        private ListView listView1;
        private ListView listView2;
    }
}