namespace rsst_lv1
{
    partial class Form1
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
            this.lbl_vrijeme = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_vrijeme
            // 
            this.lbl_vrijeme.AutoSize = true;
            this.lbl_vrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lbl_vrijeme.Location = new System.Drawing.Point(242, 109);
            this.lbl_vrijeme.Name = "lbl_vrijeme";
            this.lbl_vrijeme.Size = new System.Drawing.Size(162, 51);
            this.lbl_vrijeme.TabIndex = 0;
            this.lbl_vrijeme.Text = "vrijeme";
            this.lbl_vrijeme.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(285, 181);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_start_stop.TabIndex = 1;
            this.btn_start_stop.Text = "pokreni";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(251, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(149, 46);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lbl_vrijeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vrijeme;
        private System.Windows.Forms.Button btn_start_stop;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

