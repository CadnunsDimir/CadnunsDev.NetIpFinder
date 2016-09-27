namespace CadnunsDev.NetIPFinder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxQuant = new System.Windows.Forms.Label();
            this.ipPt3tbox = new System.Windows.Forms.TextBox();
            this.ipPt2tbox = new System.Windows.Forms.TextBox();
            this.ipPt1tbbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 274);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar IP\'s";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total de Ip\'s: ";
            // 
            // tboxQuant
            // 
            this.tboxQuant.AutoSize = true;
            this.tboxQuant.Location = new System.Drawing.Point(498, 297);
            this.tboxQuant.Name = "tboxQuant";
            this.tboxQuant.Size = new System.Drawing.Size(13, 13);
            this.tboxQuant.TabIndex = 4;
            this.tboxQuant.Text = "0";
            // 
            // ipPt3tbox
            // 
            this.ipPt3tbox.Location = new System.Drawing.Point(350, 295);
            this.ipPt3tbox.Name = "ipPt3tbox";
            this.ipPt3tbox.Size = new System.Drawing.Size(65, 20);
            this.ipPt3tbox.TabIndex = 5;
            // 
            // ipPt2tbox
            // 
            this.ipPt2tbox.Location = new System.Drawing.Point(279, 294);
            this.ipPt2tbox.Name = "ipPt2tbox";
            this.ipPt2tbox.Size = new System.Drawing.Size(65, 20);
            this.ipPt2tbox.TabIndex = 6;
            // 
            // ipPt1tbbox
            // 
            this.ipPt1tbbox.Location = new System.Drawing.Point(208, 294);
            this.ipPt1tbbox.Name = "ipPt1tbbox";
            this.ipPt1tbbox.Size = new System.Drawing.Size(65, 20);
            this.ipPt1tbbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 327);
            this.Controls.Add(this.ipPt1tbbox);
            this.Controls.Add(this.ipPt2tbox);
            this.Controls.Add(this.ipPt3tbox);
            this.Controls.Add(this.tboxQuant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tboxQuant;
        private System.Windows.Forms.TextBox ipPt3tbox;
        private System.Windows.Forms.TextBox ipPt2tbox;
        private System.Windows.Forms.TextBox ipPt1tbbox;
    }
}

