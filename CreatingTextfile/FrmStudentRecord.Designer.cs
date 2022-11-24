namespace CreatingTextfile
{
    partial class FrmStudentRecord
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(425, 62);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(75, 23);
            this.RegBtn.TabIndex = 2;
            this.RegBtn.Text = "Register";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(425, 91);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 3;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(425, 120);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 4;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 165);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 278);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
    }
}