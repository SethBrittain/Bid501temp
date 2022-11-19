using System.Windows.Forms;

namespace Bid501Server
{
    partial class UxAddProductForm
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
            this.UxAddProductTable = new System.Windows.Forms.TableLayoutPanel();
            this.UxProductList = new System.Windows.Forms.ListView();
            this.UxAddProductButton = new System.Windows.Forms.Button();
            this.UxAddProductTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxAddProductTable
            // 
            this.UxAddProductTable.ColumnCount = 1;
            this.UxAddProductTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UxAddProductTable.Controls.Add(this.UxProductList, 0, 0);
            this.UxAddProductTable.Controls.Add(this.UxAddProductButton, 0, 1);
            this.UxAddProductTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxAddProductTable.Location = new System.Drawing.Point(0, 0);
            this.UxAddProductTable.Name = "UxAddProductTable";
            this.UxAddProductTable.RowCount = 2;
            this.UxAddProductTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.04738F));
            this.UxAddProductTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95262F));
            this.UxAddProductTable.Size = new System.Drawing.Size(278, 401);
            this.UxAddProductTable.TabIndex = 0;
            // 
            // UxProductList
            // 
            this.UxProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxProductList.Location = new System.Drawing.Point(15, 15);
            this.UxProductList.Margin = new System.Windows.Forms.Padding(15);
            this.UxProductList.Name = "UxProductList";
            this.UxProductList.Size = new System.Drawing.Size(248, 294);
            this.UxProductList.TabIndex = 0;
            this.UxProductList.UseCompatibleStateImageBehavior = false;
            // 
            // UxAddProductButton
            // 
            this.UxAddProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxAddProductButton.Location = new System.Drawing.Point(50, 334);
            this.UxAddProductButton.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.UxAddProductButton.Name = "UxAddProductButton";
            this.UxAddProductButton.Size = new System.Drawing.Size(178, 57);
            this.UxAddProductButton.TabIndex = 1;
            this.UxAddProductButton.Text = "Add Product";
            this.UxAddProductButton.UseVisualStyleBackColor = true;
            // 
            // UxAddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 401);
            this.Controls.Add(this.UxAddProductTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UxAddProductForm";
            this.Text = "Add Product";
            this.UxAddProductTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel UxAddProductTable;
        private ListView UxProductList;
        private Button UxAddProductButton;
    }
}