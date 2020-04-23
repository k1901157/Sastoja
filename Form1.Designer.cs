namespace Säästöjä
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
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.btnMitkäSäädot = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbYesSir = new System.Windows.Forms.CheckBox();
            this.cbDontDo = new System.Windows.Forms.CheckBox();
            this.cbCrying = new System.Windows.Forms.CheckBox();
            this.cbChecking = new System.Windows.Forms.CheckBox();
            this.cbJumping = new System.Windows.Forms.CheckBox();
            this.cbPicking = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbObject = new System.Windows.Forms.RadioButton();
            this.rbVariable = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Checked = true;
            this.rbDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefault.Location = new System.Drawing.Point(6, 19);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(79, 24);
            this.rbDefault.TabIndex = 0;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default";
            this.rbDefault.UseVisualStyleBackColor = true;
            this.rbDefault.CheckedChanged += new System.EventHandler(this.RbDefault_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCustom);
            this.groupBox1.Controls.Add(this.rbDefault);
            this.groupBox1.Location = new System.Drawing.Point(44, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustom.Location = new System.Drawing.Point(6, 48);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(82, 24);
            this.rbCustom.TabIndex = 0;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // btnMitkäSäädot
            // 
            this.btnMitkäSäädot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMitkäSäädot.Location = new System.Drawing.Point(44, 143);
            this.btnMitkäSäädot.Name = "btnMitkäSäädot";
            this.btnMitkäSäädot.Size = new System.Drawing.Size(164, 45);
            this.btnMitkäSäädot.TabIndex = 2;
            this.btnMitkäSäädot.Text = "Mitkä säädot";
            this.btnMitkäSäädot.UseVisualStyleBackColor = true;
            this.btnMitkäSäädot.Click += new System.EventHandler(this.BtnMitkäSäädot_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(298, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 144);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(44, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbYesSir);
            this.groupBox5.Controls.Add(this.cbDontDo);
            this.groupBox5.Controls.Add(this.cbCrying);
            this.groupBox5.Controls.Add(this.cbChecking);
            this.groupBox5.Controls.Add(this.cbJumping);
            this.groupBox5.Controls.Add(this.cbPicking);
            this.groupBox5.Location = new System.Drawing.Point(21, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 163);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // cbYesSir
            // 
            this.cbYesSir.AutoSize = true;
            this.cbYesSir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYesSir.Location = new System.Drawing.Point(6, 130);
            this.cbYesSir.Name = "cbYesSir";
            this.cbYesSir.Size = new System.Drawing.Size(76, 24);
            this.cbYesSir.TabIndex = 0;
            this.cbYesSir.Text = "Yes sir";
            this.cbYesSir.UseVisualStyleBackColor = true;
            // 
            // cbDontDo
            // 
            this.cbDontDo.AutoSize = true;
            this.cbDontDo.Checked = true;
            this.cbDontDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDontDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDontDo.Location = new System.Drawing.Point(7, 109);
            this.cbDontDo.Name = "cbDontDo";
            this.cbDontDo.Size = new System.Drawing.Size(88, 24);
            this.cbDontDo.TabIndex = 0;
            this.cbDontDo.Text = "Don\'t do";
            this.cbDontDo.UseVisualStyleBackColor = true;
            // 
            // cbCrying
            // 
            this.cbCrying.AutoSize = true;
            this.cbCrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrying.Location = new System.Drawing.Point(7, 86);
            this.cbCrying.Name = "cbCrying";
            this.cbCrying.Size = new System.Drawing.Size(72, 24);
            this.cbCrying.TabIndex = 0;
            this.cbCrying.Text = "Crying";
            this.cbCrying.UseVisualStyleBackColor = true;
            // 
            // cbChecking
            // 
            this.cbChecking.AutoSize = true;
            this.cbChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChecking.Location = new System.Drawing.Point(7, 63);
            this.cbChecking.Name = "cbChecking";
            this.cbChecking.Size = new System.Drawing.Size(94, 24);
            this.cbChecking.TabIndex = 0;
            this.cbChecking.Text = "Checking";
            this.cbChecking.UseVisualStyleBackColor = true;
            // 
            // cbJumping
            // 
            this.cbJumping.AutoSize = true;
            this.cbJumping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJumping.Location = new System.Drawing.Point(7, 40);
            this.cbJumping.Name = "cbJumping";
            this.cbJumping.Size = new System.Drawing.Size(88, 24);
            this.cbJumping.TabIndex = 0;
            this.cbJumping.Text = "Jumping";
            this.cbJumping.UseVisualStyleBackColor = true;
            // 
            // cbPicking
            // 
            this.cbPicking.AutoSize = true;
            this.cbPicking.Checked = true;
            this.cbPicking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPicking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPicking.Location = new System.Drawing.Point(7, 20);
            this.cbPicking.Name = "cbPicking";
            this.cbPicking.Size = new System.Drawing.Size(78, 24);
            this.cbPicking.TabIndex = 0;
            this.cbPicking.Text = "Picking";
            this.cbPicking.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(233, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Team 1",
            "Team 2"});
            this.comboBox2.Location = new System.Drawing.Point(86, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Team 1";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Group 1",
            "Group 2"});
            this.comboBox1.Location = new System.Drawing.Point(86, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Group 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Groups";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbObject);
            this.groupBox4.Controls.Add(this.rbVariable);
            this.groupBox4.Location = new System.Drawing.Point(86, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // rbObject
            // 
            this.rbObject.AutoSize = true;
            this.rbObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObject.Location = new System.Drawing.Point(10, 48);
            this.rbObject.Name = "rbObject";
            this.rbObject.Size = new System.Drawing.Size(73, 24);
            this.rbObject.TabIndex = 0;
            this.rbObject.Text = "Object";
            this.rbObject.UseVisualStyleBackColor = true;
            // 
            // rbVariable
            // 
            this.rbVariable.AutoSize = true;
            this.rbVariable.Checked = true;
            this.rbVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVariable.Location = new System.Drawing.Point(10, 19);
            this.rbVariable.Name = "rbVariable";
            this.rbVariable.Size = new System.Drawing.Size(85, 24);
            this.rbVariable.TabIndex = 0;
            this.rbVariable.TabStop = true;
            this.rbVariable.Text = "Variable";
            this.rbVariable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMitkäSäädot);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Group 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.Button btnMitkäSäädot;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbObject;
        private System.Windows.Forms.RadioButton rbVariable;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbYesSir;
        private System.Windows.Forms.CheckBox cbDontDo;
        private System.Windows.Forms.CheckBox cbCrying;
        private System.Windows.Forms.CheckBox cbChecking;
        private System.Windows.Forms.CheckBox cbJumping;
        private System.Windows.Forms.CheckBox cbPicking;
    }
}

