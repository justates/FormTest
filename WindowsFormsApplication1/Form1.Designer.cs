namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resulttext = new System.Windows.Forms.TextBox();
            this.TipText = new System.Windows.Forms.Label();
            this.HEX2GBK_Result = new System.Windows.Forms.Label();
            this.GBKResult = new System.Windows.Forms.TextBox();
            this.HEXOri = new System.Windows.Forms.TextBox();
            this.HEX2GBKBtn = new System.Windows.Forms.Button();
            this.GBK2HEX_Result = new System.Windows.Forms.Label();
            this.HEXResult = new System.Windows.Forms.TextBox();
            this.GBKOri = new System.Windows.Forms.TextBox();
            this.GBK2HEXBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "UINT转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 46);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // resulttext
            // 
            this.resulttext.Location = new System.Drawing.Point(385, 46);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(168, 21);
            this.resulttext.TabIndex = 3;
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Location = new System.Drawing.Point(572, 49);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(41, 12);
            this.TipText.TabIndex = 4;
            this.TipText.Text = "label1";
            this.TipText.Visible = false;
            // 
            // HEX2GBK_Result
            // 
            this.HEX2GBK_Result.AutoSize = true;
            this.HEX2GBK_Result.Location = new System.Drawing.Point(572, 198);
            this.HEX2GBK_Result.Name = "HEX2GBK_Result";
            this.HEX2GBK_Result.Size = new System.Drawing.Size(41, 12);
            this.HEX2GBK_Result.TabIndex = 8;
            this.HEX2GBK_Result.Text = "label1";
            this.HEX2GBK_Result.Visible = false;
            // 
            // GBKResult
            // 
            this.GBKResult.Location = new System.Drawing.Point(385, 195);
            this.GBKResult.Name = "GBKResult";
            this.GBKResult.Size = new System.Drawing.Size(168, 21);
            this.GBKResult.TabIndex = 7;
            // 
            // HEXOri
            // 
            this.HEXOri.BackColor = System.Drawing.Color.White;
            this.HEXOri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HEXOri.Location = new System.Drawing.Point(52, 195);
            this.HEXOri.MaxLength = 24;
            this.HEXOri.Name = "HEXOri";
            this.HEXOri.Size = new System.Drawing.Size(187, 21);
            this.HEXOri.TabIndex = 6;
            // 
            // HEX2GBKBtn
            // 
            this.HEX2GBKBtn.Location = new System.Drawing.Point(290, 189);
            this.HEX2GBKBtn.Name = "HEX2GBKBtn";
            this.HEX2GBKBtn.Size = new System.Drawing.Size(68, 30);
            this.HEX2GBKBtn.TabIndex = 5;
            this.HEX2GBKBtn.Text = "HEX2GBK";
            this.HEX2GBKBtn.UseVisualStyleBackColor = true;
            this.HEX2GBKBtn.Click += new System.EventHandler(this.ConverBtn_Click);
            // 
            // GBK2HEX_Result
            // 
            this.GBK2HEX_Result.AutoSize = true;
            this.GBK2HEX_Result.Location = new System.Drawing.Point(572, 250);
            this.GBK2HEX_Result.Name = "GBK2HEX_Result";
            this.GBK2HEX_Result.Size = new System.Drawing.Size(41, 12);
            this.GBK2HEX_Result.TabIndex = 12;
            this.GBK2HEX_Result.Text = "label1";
            this.GBK2HEX_Result.Visible = false;
            // 
            // HEXResult
            // 
            this.HEXResult.Location = new System.Drawing.Point(385, 247);
            this.HEXResult.Name = "HEXResult";
            this.HEXResult.Size = new System.Drawing.Size(168, 21);
            this.HEXResult.TabIndex = 11;
            // 
            // GBKOri
            // 
            this.GBKOri.BackColor = System.Drawing.Color.White;
            this.GBKOri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GBKOri.Location = new System.Drawing.Point(52, 247);
            this.GBKOri.MaxLength = 24;
            this.GBKOri.Name = "GBKOri";
            this.GBKOri.Size = new System.Drawing.Size(187, 21);
            this.GBKOri.TabIndex = 10;
            // 
            // GBK2HEXBtn
            // 
            this.GBK2HEXBtn.Location = new System.Drawing.Point(290, 241);
            this.GBK2HEXBtn.Name = "GBK2HEXBtn";
            this.GBK2HEXBtn.Size = new System.Drawing.Size(68, 30);
            this.GBK2HEXBtn.TabIndex = 9;
            this.GBK2HEXBtn.Text = "GBK2HEX";
            this.GBK2HEXBtn.UseVisualStyleBackColor = true;
            this.GBK2HEXBtn.Click += new System.EventHandler(this.GBK2HEXBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "DBTest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GBK2HEX_Result);
            this.Controls.Add(this.HEXResult);
            this.Controls.Add(this.GBKOri);
            this.Controls.Add(this.GBK2HEXBtn);
            this.Controls.Add(this.HEX2GBK_Result);
            this.Controls.Add(this.GBKResult);
            this.Controls.Add(this.HEXOri);
            this.Controls.Add(this.HEX2GBKBtn);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox resulttext;
        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.Label HEX2GBK_Result;
        private System.Windows.Forms.TextBox GBKResult;
        private System.Windows.Forms.TextBox HEXOri;
        private System.Windows.Forms.Button HEX2GBKBtn;
        private System.Windows.Forms.Label GBK2HEX_Result;
        private System.Windows.Forms.TextBox HEXResult;
        private System.Windows.Forms.TextBox GBKOri;
        private System.Windows.Forms.Button GBK2HEXBtn;
        private System.Windows.Forms.Button button2;
    }
}

