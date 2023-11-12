namespace Lab5AVPZ
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            this.Table_1_1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Table_1_1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_1_1
            // 
            this.Table_1_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_1_1.Location = new System.Drawing.Point(12, 42);
            this.Table_1_1.Name = "Table_1_1";
            this.Table_1_1.RowHeadersVisible = false;
            this.Table_1_1.RowHeadersWidth = 51;
            this.Table_1_1.RowTemplate.Height = 24;
            this.Table_1_1.Size = new System.Drawing.Size(876, 589);
            this.Table_1_1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 28);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recountToolStripMenuItem});
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // recountToolStripMenuItem
            // 
            this.recountToolStripMenuItem.Name = "recountToolStripMenuItem";
            this.recountToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.recountToolStripMenuItem.Text = "Recount";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1,
            this.recountToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // recountToolStripMenuItem1
            // 
            this.recountToolStripMenuItem1.Name = "recountToolStripMenuItem1";
            this.recountToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.recountToolStripMenuItem1.Text = "Recount";
            this.recountToolStripMenuItem1.Click += new System.EventHandler(this.recountToolStripMenuItem1_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 777);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Table_1_1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Data";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.Table_1_1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_1_1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recountToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recountToolStripMenuItem1;
    }
}