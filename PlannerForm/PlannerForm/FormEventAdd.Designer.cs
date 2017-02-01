namespace PlannerForm
{
    partial class FormEventAdd
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
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.SaveEventText = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст события:";
            // 
            // EventTextBox
            // 
            this.EventTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTextBox.Location = new System.Drawing.Point(157, 13);
            this.EventTextBox.Multiline = true;
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(373, 56);
            this.EventTextBox.TabIndex = 1;
            this.EventTextBox.TextChanged += new System.EventHandler(this.EventTextBox_TextChanged);
            // 
            // SaveEventText
            // 
            this.SaveEventText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEventText.Location = new System.Drawing.Point(210, 150);
            this.SaveEventText.Name = "SaveEventText";
            this.SaveEventText.Size = new System.Drawing.Size(96, 23);
            this.SaveEventText.TabIndex = 2;
            this.SaveEventText.Text = "Сохранить";
            this.SaveEventText.UseVisualStyleBackColor = true;
            this.SaveEventText.Click += new System.EventHandler(this.SaveEventText_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите дату события:";
            // 
            // FormEventAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SaveEventText);
            this.Controls.Add(this.EventTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(658, 324);
            this.MinimumSize = new System.Drawing.Size(558, 224);
            this.Name = "FormEventAdd";
            this.Text = "Добавить событие";
            this.Load += new System.EventHandler(this.FormEventAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.Button SaveEventText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}