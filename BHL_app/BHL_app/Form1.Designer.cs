namespace BHL_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDevice = new System.Windows.Forms.Button();
            this.BtnGas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHome);
            this.groupBox1.Controls.Add(this.BtnOut);
            this.groupBox1.Location = new System.Drawing.Point(47, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gdzie  jesteś?";
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(179, 67);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(104, 29);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "W domu";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnOut
            // 
            this.BtnOut.Location = new System.Drawing.Point(35, 67);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(111, 29);
            this.BtnOut.TabIndex = 0;
            this.BtnOut.Text = "Na zewnątrz";
            this.BtnOut.UseVisualStyleBackColor = true;
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGas);
            this.groupBox2.Controls.Add(this.BtnDevice);
            this.groupBox2.Location = new System.Drawing.Point(401, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Co się dziaje w twoim domu?";
            // 
            // BtnDevice
            // 
            this.BtnDevice.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDevice.Location = new System.Drawing.Point(21, 59);
            this.BtnDevice.Name = "BtnDevice";
            this.BtnDevice.Size = new System.Drawing.Size(238, 54);
            this.BtnDevice.TabIndex = 0;
            this.BtnDevice.Text = "Historia użycia prądu przez podłączone urządzenia";
            this.BtnDevice.UseVisualStyleBackColor = false;
            this.BtnDevice.Click += new System.EventHandler(this.BtnDevice_Click);
            // 
            // BtnGas
            // 
            this.BtnGas.Location = new System.Drawing.Point(24, 155);
            this.BtnGas.Name = "BtnGas";
            this.BtnGas.Size = new System.Drawing.Size(235, 56);
            this.BtnGas.TabIndex = 1;
            this.BtnGas.Text = "Historia wskazań czujnika gazu";
            this.BtnGas.UseVisualStyleBackColor = true;
            this.BtnGas.Click += new System.EventHandler(this.BtnGas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGas;
        private System.Windows.Forms.Button BtnDevice;
    }
}

