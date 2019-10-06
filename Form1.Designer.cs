namespace Voice_Project_0
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.trkValume = new System.Windows.Forms.TrackBar();
            this.btn_read = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkValume)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(834, 262);
            this.textBox1.TabIndex = 0;
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(58, 300);
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(209, 37);
            this.trkSpeed.TabIndex = 1;
            // 
            // trkValume
            // 
            this.trkValume.Location = new System.Drawing.Point(58, 378);
            this.trkValume.Name = "trkValume";
            this.trkValume.Size = new System.Drawing.Size(209, 37);
            this.trkValume.TabIndex = 1;
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_read.FlatAppearance.BorderSize = 0;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.ForeColor = System.Drawing.Color.White;
            this.btn_read.Location = new System.Drawing.Point(490, 310);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(120, 46);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.Btn_read_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.BlueViolet;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(742, 310);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(120, 46);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.BlueViolet;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(490, 369);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 46);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.Location = new System.Drawing.Point(616, 310);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(120, 46);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.BlueViolet;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(616, 369);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(120, 46);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.BlueViolet;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(742, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.trkValume);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkValume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.TrackBar trkValume;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

