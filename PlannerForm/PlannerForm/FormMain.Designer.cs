namespace PlannerForm
{
    partial class MainForm
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
            this.GetEventBut = new System.Windows.Forms.Button();
            this.ShowWinAddBut = new System.Windows.Forms.Button();
            this.ShowWinDelBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.ContextListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetEventBut
            // 
            this.GetEventBut.Location = new System.Drawing.Point(13, 24);
            this.GetEventBut.Name = "GetEventBut";
            this.GetEventBut.Size = new System.Drawing.Size(75, 23);
            this.GetEventBut.TabIndex = 0;
            this.GetEventBut.Text = "Показать";
            this.GetEventBut.UseVisualStyleBackColor = true;
            this.GetEventBut.Click += new System.EventHandler(this.GetEventBut_Click);
            // 
            // ShowWinAddBut
            // 
            this.ShowWinAddBut.Location = new System.Drawing.Point(12, 79);
            this.ShowWinAddBut.Name = "ShowWinAddBut";
            this.ShowWinAddBut.Size = new System.Drawing.Size(75, 23);
            this.ShowWinAddBut.TabIndex = 1;
            this.ShowWinAddBut.Text = "Добавить";
            this.ShowWinAddBut.UseVisualStyleBackColor = true;
            this.ShowWinAddBut.Click += new System.EventHandler(this.ShowWinAddBut_Click);
            // 
            // ShowWinDelBut
            // 
            this.ShowWinDelBut.Location = new System.Drawing.Point(13, 131);
            this.ShowWinDelBut.Name = "ShowWinDelBut";
            this.ShowWinDelBut.Size = new System.Drawing.Size(75, 23);
            this.ShowWinDelBut.TabIndex = 2;
            this.ShowWinDelBut.Text = "Удалить";
            this.ShowWinDelBut.UseVisualStyleBackColor = true;
            this.ShowWinDelBut.Click += new System.EventHandler(this.ShowWinDelBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitBut.Location = new System.Drawing.Point(13, 218);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(75, 23);
            this.ExitBut.TabIndex = 3;
            this.ExitBut.Text = "Выход";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // ContextListBox
            // 
            this.ContextListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContextListBox.FormattingEnabled = true;
            this.ContextListBox.Location = new System.Drawing.Point(111, 24);
            this.ContextListBox.Name = "ContextListBox";
            this.ContextListBox.ScrollAlwaysVisible = true;
            this.ContextListBox.Size = new System.Drawing.Size(268, 199);
            this.ContextListBox.TabIndex = 4;
            this.ContextListBox.SelectedIndexChanged += new System.EventHandler(this.ContextListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 273);
            this.Controls.Add(this.ContextListBox);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.ShowWinDelBut);
            this.Controls.Add(this.ShowWinAddBut);
            this.Controls.Add(this.GetEventBut);
            this.MaximumSize = new System.Drawing.Size(527, 412);
            this.MinimumSize = new System.Drawing.Size(427, 312);
            this.Name = "MainForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetEventBut;
        private System.Windows.Forms.Button ShowWinAddBut;
        private System.Windows.Forms.Button ShowWinDelBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.ListBox ContextListBox;
    }
}

