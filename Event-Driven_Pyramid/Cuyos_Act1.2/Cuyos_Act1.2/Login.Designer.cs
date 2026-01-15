namespace Cuyos_Act1._2
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cuyos_Act1._2.Properties.Resources.Untitled_design__2_;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 93);
            this.panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Bodoni MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(4, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 47);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Pyramid Volume Calculator";
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(223, 422);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(110, 25);
            this.txtVolume.TabIndex = 25;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(223, 385);
            this.txtBase.Multiline = true;
            this.txtBase.Name = "txtBase";
            this.txtBase.ReadOnly = true;
            this.txtBase.Size = new System.Drawing.Size(110, 25);
            this.txtBase.TabIndex = 24;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(67, 422);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(141, 25);
            this.lblVolume.TabIndex = 23;
            this.lblVolume.Text = "Volume Area:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.BackColor = System.Drawing.Color.Transparent;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(67, 383);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(106, 25);
            this.lblBase.TabIndex = 22;
            this.lblBase.Text = "Base Are:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = global::Cuyos_Act1._2.Properties.Resources.Untitled_design;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(285, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(182, 42);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(337, 241);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(148, 39);
            this.txtHeight.TabIndex = 20;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(337, 185);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(148, 39);
            this.txtWidth.TabIndex = 19;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(337, 128);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(148, 39);
            this.txtLength.TabIndex = 18;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(251, 250);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 25);
            this.lblHeight.TabIndex = 17;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(251, 191);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 25);
            this.lblWidth.TabIndex = 16;
            this.lblWidth.Text = "Width:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(250, 136);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(84, 25);
            this.lblLength.TabIndex = 15;
            this.lblLength.Text = "Length:";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Red;
            this.lblClear.Location = new System.Drawing.Point(448, 280);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(39, 16);
            this.lblClear.TabIndex = 28;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "cubics units";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "sq. units";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuyos_Act1._2.Properties.Resources.Untitled_design1;
            this.ClientSize = new System.Drawing.Size(501, 474);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}