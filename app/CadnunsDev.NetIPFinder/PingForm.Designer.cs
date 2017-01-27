namespace CadnunsDev.NetIPFinder
{
    partial class PingForm
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
            this.tboxLog = new System.Windows.Forms.RichTextBox();
            this.tboxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoraInicio = new System.Windows.Forms.Label();
            this.lbTempoOnline = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTempoOffLine = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxLog
            // 
            this.tboxLog.Location = new System.Drawing.Point(12, 27);
            this.tboxLog.Name = "tboxLog";
            this.tboxLog.ReadOnly = true;
            this.tboxLog.Size = new System.Drawing.Size(313, 222);
            this.tboxLog.TabIndex = 0;
            this.tboxLog.Text = "";
            // 
            // tboxUrl
            // 
            this.tboxUrl.Location = new System.Drawing.Point(352, 27);
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(330, 20);
            this.tboxUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Inicio:";
            // 
            // lbHoraInicio
            // 
            this.lbHoraInicio.AutoSize = true;
            this.lbHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraInicio.Location = new System.Drawing.Point(362, 90);
            this.lbHoraInicio.Name = "lbHoraInicio";
            this.lbHoraInicio.Size = new System.Drawing.Size(68, 17);
            this.lbHoraInicio.TabIndex = 5;
            this.lbHoraInicio.Text = "----------";
            // 
            // lbTempoOnline
            // 
            this.lbTempoOnline.AutoSize = true;
            this.lbTempoOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempoOnline.Location = new System.Drawing.Point(362, 139);
            this.lbTempoOnline.Name = "lbTempoOnline";
            this.lbTempoOnline.Size = new System.Drawing.Size(68, 17);
            this.lbTempoOnline.TabIndex = 7;
            this.lbTempoOnline.Text = "----------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tempo Online";
            // 
            // lbTempoOffLine
            // 
            this.lbTempoOffLine.AutoSize = true;
            this.lbTempoOffLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempoOffLine.Location = new System.Drawing.Point(362, 189);
            this.lbTempoOffLine.Name = "lbTempoOffLine";
            this.lbTempoOffLine.Size = new System.Drawing.Size(68, 17);
            this.lbTempoOffLine.TabIndex = 9;
            this.lbTempoOffLine.Text = "----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tempo OffLine";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(489, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(570, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ultimo Host:";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHost.Location = new System.Drawing.Point(486, 120);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(59, 20);
            this.lbHost.TabIndex = 13;
            this.lbHost.Text = "- - - - -";
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIp.Location = new System.Drawing.Point(486, 159);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(59, 20);
            this.lbIp.TabIndex = 14;
            this.lbIp.Text = "- - - - -";
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 261);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTempoOffLine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTempoOnline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHoraInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxUrl);
            this.Controls.Add(this.tboxLog);
            this.Name = "PingForm";
            this.Text = "PingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PingForm_FormClosing);
            this.Load += new System.EventHandler(this.PingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tboxLog;
        private System.Windows.Forms.TextBox tboxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoraInicio;
        private System.Windows.Forms.Label lbTempoOnline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTempoOffLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label lbIp;
    }
}