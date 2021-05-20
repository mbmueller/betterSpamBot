
namespace betterSpamBot
{
    partial class betterSpamBot
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msg0 = new System.Windows.Forms.Label();
            this.msg3 = new System.Windows.Forms.Label();
            this.msg2 = new System.Windows.Forms.Label();
            this.msg1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(12, 33);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(776, 20);
            this.textBox0.TabIndex = 0;
            this.textBox0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(776, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(776, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 20);
            this.textBox1.TabIndex = 3;
            // 
            // msg0
            // 
            this.msg0.AutoSize = true;
            this.msg0.Location = new System.Drawing.Point(12, 17);
            this.msg0.Name = "msg0";
            this.msg0.Size = new System.Drawing.Size(59, 13);
            this.msg0.TabIndex = 4;
            this.msg0.Text = "Message 1";
            this.msg0.Click += new System.EventHandler(this.label1_Click);
            // 
            // msg3
            // 
            this.msg3.AutoSize = true;
            this.msg3.Location = new System.Drawing.Point(12, 187);
            this.msg3.Name = "msg3";
            this.msg3.Size = new System.Drawing.Size(59, 13);
            this.msg3.TabIndex = 6;
            this.msg3.Text = "Message 4";
            // 
            // msg2
            // 
            this.msg2.AutoSize = true;
            this.msg2.Location = new System.Drawing.Point(12, 131);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(59, 13);
            this.msg2.TabIndex = 7;
            this.msg2.Text = "Message 3";
            // 
            // msg1
            // 
            this.msg1.AutoSize = true;
            this.msg1.Location = new System.Drawing.Point(12, 71);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(59, 13);
            this.msg1.TabIndex = 8;
            this.msg1.Text = "Message 2";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 353);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(188, 86);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(600, 354);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(188, 85);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 45100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // betterSpamBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.msg1);
            this.Controls.Add(this.msg2);
            this.Controls.Add(this.msg3);
            this.Controls.Add(this.msg0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox0);
            this.Name = "betterSpamBot";
            this.Text = "better Spam Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label msg0;
        private System.Windows.Forms.Label msg3;
        private System.Windows.Forms.Label msg2;
        private System.Windows.Forms.Label msg1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
    }
}

