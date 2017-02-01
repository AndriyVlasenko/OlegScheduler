namespace PlannerForm
{
    partial class FormEventDel
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
            this.ContextListDelBox = new System.Windows.Forms.ListBox();
            this.SaveChangesDelBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.EventListBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextListDelBox
            // 
            this.ContextListDelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContextListDelBox.FormattingEnabled = true;
            this.ContextListDelBox.Location = new System.Drawing.Point(12, 35);
            this.ContextListDelBox.Name = "ContextListDelBox";
            this.ContextListDelBox.Size = new System.Drawing.Size(354, 134);
            this.ContextListDelBox.TabIndex = 0;
            this.ContextListDelBox.SelectedIndexChanged += new System.EventHandler(this.ContextListDelBox_SelectedIndexChanged);
            // 
            // SaveChangesDelBut
            // 
            this.SaveChangesDelBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesDelBut.Location = new System.Drawing.Point(291, 191);
            this.SaveChangesDelBut.Name = "SaveChangesDelBut";
            this.SaveChangesDelBut.Size = new System.Drawing.Size(75, 23);
            this.SaveChangesDelBut.TabIndex = 1;
            this.SaveChangesDelBut.Text = "Удалить";
            this.SaveChangesDelBut.UseVisualStyleBackColor = true;
            this.SaveChangesDelBut.Click += new System.EventHandler(this.SaveChangesDelBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите событие для удаления:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите ID события:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(143, 194);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EventListBut
            // 
            this.EventListBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventListBut.Location = new System.Drawing.Point(232, 8);
            this.EventListBut.Name = "EventListBut";
            this.EventListBut.Size = new System.Drawing.Size(134, 23);
            this.EventListBut.TabIndex = 5;
            this.EventListBut.Text = "Список событий";
            this.EventListBut.UseVisualStyleBackColor = true;
            this.EventListBut.Click += new System.EventHandler(this.EventListBut_Click);
            // 
            // FormEventDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.EventListBut);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveChangesDelBut);
            this.Controls.Add(this.ContextListDelBox);
            this.MaximumSize = new System.Drawing.Size(500, 380);
            this.MinimumSize = new System.Drawing.Size(400, 280);
            this.Name = "FormEventDel";
            this.Text = "Удалить Событие";
            this.Load += new System.EventHandler(this.FormEventDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContextListDelBox;
        private System.Windows.Forms.Button SaveChangesDelBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button EventListBut;
    }
}