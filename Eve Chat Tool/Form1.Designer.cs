namespace Eve_Chat_Tool
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumXs = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.btnFullReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers of X\'s in Chat ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X\'s";
            // 
            // lblNumXs
            // 
            this.lblNumXs.AutoSize = true;
            this.lblNumXs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumXs.Location = new System.Drawing.Point(61, 51);
            this.lblNumXs.Name = "lblNumXs";
            this.lblNumXs.Size = new System.Drawing.Size(103, 25);
            this.lblNumXs.TabIndex = 2;
            this.lblNumXs.Text = "lblNumXs";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your character";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(135, 84);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(58, 20);
            this.lblChar.TabIndex = 5;
            this.lblChar.Text = "lblChar";
            // 
            // btnFullReset
            // 
            this.btnFullReset.Location = new System.Drawing.Point(248, 55);
            this.btnFullReset.Name = "btnFullReset";
            this.btnFullReset.Size = new System.Drawing.Size(75, 23);
            this.btnFullReset.TabIndex = 6;
            this.btnFullReset.Text = "New Fleet";
            this.btnFullReset.UseVisualStyleBackColor = true;
            this.btnFullReset.Click += new System.EventHandler(this.btnFullReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 116);
            this.Controls.Add(this.btnFullReset);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNumXs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Eve X Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumXs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button btnFullReset;
    }
}

