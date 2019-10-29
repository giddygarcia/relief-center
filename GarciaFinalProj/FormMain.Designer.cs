namespace GarciaFinalProj
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addgoodUnitcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addgoodRatetb = new System.Windows.Forms.TextBox();
            this.addgoodNametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.donateQuantitytb = new System.Windows.Forms.TextBox();
            this.donateNamecb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnameReliefCenter = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.releaseAmounttb = new System.Windows.Forms.TextBox();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addgoodUnitcb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addgoodRatetb);
            this.groupBox1.Controls.Add(this.addgoodNametb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Goods";
            // 
            // addgoodUnitcb
            // 
            this.addgoodUnitcb.BackColor = System.Drawing.Color.DimGray;
            this.addgoodUnitcb.ForeColor = System.Drawing.Color.White;
            this.addgoodUnitcb.FormattingEnabled = true;
            this.addgoodUnitcb.Items.AddRange(new object[] {
            "cans",
            "kilos",
            "liters",
            "packs"});
            this.addgoodUnitcb.Location = new System.Drawing.Point(123, 117);
            this.addgoodUnitcb.Name = "addgoodUnitcb";
            this.addgoodUnitcb.Size = new System.Drawing.Size(219, 24);
            this.addgoodUnitcb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Release Rate:";
            // 
            // addgoodRatetb
            // 
            this.addgoodRatetb.BackColor = System.Drawing.Color.DimGray;
            this.addgoodRatetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgoodRatetb.ForeColor = System.Drawing.Color.White;
            this.addgoodRatetb.Location = new System.Drawing.Point(123, 77);
            this.addgoodRatetb.Name = "addgoodRatetb";
            this.addgoodRatetb.Size = new System.Drawing.Size(219, 24);
            this.addgoodRatetb.TabIndex = 4;
            // 
            // addgoodNametb
            // 
            this.addgoodNametb.BackColor = System.Drawing.Color.DimGray;
            this.addgoodNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgoodNametb.ForeColor = System.Drawing.Color.White;
            this.addgoodNametb.Location = new System.Drawing.Point(123, 37);
            this.addgoodNametb.Name = "addgoodNametb";
            this.addgoodNametb.Size = new System.Drawing.Size(219, 24);
            this.addgoodNametb.TabIndex = 2;
            this.addgoodNametb.TextChanged += new System.EventHandler(this.addgoodNametb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(18, 160);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(324, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Goods";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMain.ForeColor = System.Drawing.Color.SpringGreen;
            this.rtbMain.Location = new System.Drawing.Point(10, 21);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMain.Size = new System.Drawing.Size(734, 673);
            this.rtbMain.TabIndex = 1;
            this.rtbMain.Text = "";
            this.rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            // 
            // buttonDonate
            // 
            this.buttonDonate.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonate.Location = new System.Drawing.Point(18, 121);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(324, 30);
            this.buttonDonate.TabIndex = 2;
            this.buttonDonate.Text = "Donate Goods";
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.donateQuantitytb);
            this.groupBox2.Controls.Add(this.donateNamecb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonDonate);
            this.groupBox2.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(13, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 173);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donate Goods";
            // 
            // donateQuantitytb
            // 
            this.donateQuantitytb.BackColor = System.Drawing.Color.DimGray;
            this.donateQuantitytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateQuantitytb.ForeColor = System.Drawing.Color.White;
            this.donateQuantitytb.Location = new System.Drawing.Point(123, 80);
            this.donateQuantitytb.Name = "donateQuantitytb";
            this.donateQuantitytb.Size = new System.Drawing.Size(219, 24);
            this.donateQuantitytb.TabIndex = 6;
            // 
            // donateNamecb
            // 
            this.donateNamecb.BackColor = System.Drawing.Color.DimGray;
            this.donateNamecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donateNamecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateNamecb.ForeColor = System.Drawing.Color.White;
            this.donateNamecb.FormattingEnabled = true;
            this.donateNamecb.Location = new System.Drawing.Point(123, 34);
            this.donateNamecb.Name = "donateNamecb";
            this.donateNamecb.Size = new System.Drawing.Size(219, 26);
            this.donateNamecb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relief Good:";
            // 
            // lnameReliefCenter
            // 
            this.lnameReliefCenter.AutoSize = true;
            this.lnameReliefCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameReliefCenter.ForeColor = System.Drawing.Color.SpringGreen;
            this.lnameReliefCenter.Location = new System.Drawing.Point(434, 20);
            this.lnameReliefCenter.Name = "lnameReliefCenter";
            this.lnameReliefCenter.Size = new System.Drawing.Size(187, 36);
            this.lnameReliefCenter.TabIndex = 6;
            this.lnameReliefCenter.Text = "Relief Center";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrint.Location = new System.Drawing.Point(13, 627);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(364, 40);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print Inventory";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(13, 683);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(364, 43);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear Output Window";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClear);
            this.groupBox4.Controls.Add(this.buttonPrint);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox4.Location = new System.Drawing.Point(18, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 746);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toolbox";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.releaseAmounttb);
            this.groupBox3.Controls.Add(this.buttonRelease);
            this.groupBox3.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox3.Location = new System.Drawing.Point(13, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 132);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Release Packs of Goods";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Amount:";
            // 
            // releaseAmounttb
            // 
            this.releaseAmounttb.BackColor = System.Drawing.Color.DimGray;
            this.releaseAmounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseAmounttb.ForeColor = System.Drawing.Color.White;
            this.releaseAmounttb.Location = new System.Drawing.Point(121, 40);
            this.releaseAmounttb.Name = "releaseAmounttb";
            this.releaseAmounttb.Size = new System.Drawing.Size(221, 24);
            this.releaseAmounttb.TabIndex = 4;
            // 
            // buttonRelease
            // 
            this.buttonRelease.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelease.Location = new System.Drawing.Point(18, 83);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(324, 30);
            this.buttonRelease.TabIndex = 3;
            this.buttonRelease.Text = "Release Packs";
            this.buttonRelease.UseVisualStyleBackColor = false;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbMain);
            this.groupBox5.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox5.Location = new System.Drawing.Point(430, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 700);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output Window";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1197, 782);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lnameReliefCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Relief Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addgoodRatetb;
        private System.Windows.Forms.TextBox addgoodNametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox donateNamecb;
        private System.Windows.Forms.TextBox donateQuantitytb;
        private System.Windows.Forms.Label lnameReliefCenter;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox addgoodUnitcb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox releaseAmounttb;
        private System.Windows.Forms.Button buttonRelease;
    }
}