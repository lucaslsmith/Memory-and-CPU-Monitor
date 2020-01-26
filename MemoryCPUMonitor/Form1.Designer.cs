namespace MemoryCPUMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cpumonitor = new System.Windows.Forms.Label();
            this.memorymonitor = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.MemoryUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpumonitor
            // 
            this.cpumonitor.AutoSize = true;
            this.cpumonitor.BackColor = System.Drawing.Color.Transparent;
            this.cpumonitor.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpumonitor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cpumonitor.Location = new System.Drawing.Point(86, 9);
            this.cpumonitor.Name = "cpumonitor";
            this.cpumonitor.Size = new System.Drawing.Size(68, 11);
            this.cpumonitor.TabIndex = 0;
            this.cpumonitor.Text = "CPU Usage";
            // 
            // memorymonitor
            // 
            this.memorymonitor.AutoSize = true;
            this.memorymonitor.BackColor = System.Drawing.Color.Black;
            this.memorymonitor.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorymonitor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.memorymonitor.Location = new System.Drawing.Point(65, 70);
            this.memorymonitor.Name = "memorymonitor";
            this.memorymonitor.Size = new System.Drawing.Size(89, 11);
            this.memorymonitor.TabIndex = 1;
            this.memorymonitor.Text = "Memory Usage";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(198, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 105);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start Monitoring";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 84);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(189, 30);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 4;
            // 
            // CPUUsage
            // 
            this.CPUUsage.AutoSize = true;
            this.CPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.CPUUsage.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUsage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CPUUsage.Location = new System.Drawing.Point(160, 9);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(19, 11);
            this.CPUUsage.TabIndex = 5;
            this.CPUUsage.Text = "0%";
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.AutoSize = true;
            this.MemoryUsage.BackColor = System.Drawing.Color.Transparent;
            this.MemoryUsage.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryUsage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MemoryUsage.Location = new System.Drawing.Point(160, 70);
            this.MemoryUsage.Name = "MemoryUsage";
            this.MemoryUsage.Size = new System.Drawing.Size(19, 11);
            this.MemoryUsage.TabIndex = 6;
            this.MemoryUsage.Text = "0%";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(317, 121);
            this.Controls.Add(this.MemoryUsage);
            this.Controls.Add(this.CPUUsage);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.memorymonitor);
            this.Controls.Add(this.cpumonitor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memory and CPU Monitor";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarMemory;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label cpumonitor;
        private System.Windows.Forms.Label memorymonitor;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.Label MemoryUsage;
    }
}

