namespace AlgoritmiekContainerVervoer
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
            this.ConfigShip = new System.Windows.Forms.GroupBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.btnSetShip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoShip = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypesContainer = new System.Windows.Forms.ComboBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.nudContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSortedContainersFront = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbSortedContainersMid = new System.Windows.Forms.ListBox();
            this.lbSortedContainersBack = new System.Windows.Forms.ListBox();
            this.ConfigShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.InfoShip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigShip
            // 
            this.ConfigShip.Controls.Add(this.nudWidth);
            this.ConfigShip.Controls.Add(this.nudLength);
            this.ConfigShip.Controls.Add(this.btnSetShip);
            this.ConfigShip.Controls.Add(this.label2);
            this.ConfigShip.Controls.Add(this.label1);
            this.ConfigShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigShip.Location = new System.Drawing.Point(13, 13);
            this.ConfigShip.Name = "ConfigShip";
            this.ConfigShip.Size = new System.Drawing.Size(310, 150);
            this.ConfigShip.TabIndex = 0;
            this.ConfigShip.TabStop = false;
            this.ConfigShip.Text = "Information Ship";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(181, 58);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 24);
            this.nudWidth.TabIndex = 6;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(181, 30);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 24);
            this.nudLength.TabIndex = 5;
            // 
            // btnSetShip
            // 
            this.btnSetShip.Location = new System.Drawing.Point(181, 104);
            this.btnSetShip.Name = "btnSetShip";
            this.btnSetShip.Size = new System.Drawing.Size(120, 29);
            this.btnSetShip.TabIndex = 4;
            this.btnSetShip.Text = "Save";
            this.btnSetShip.UseVisualStyleBackColor = true;
            this.btnSetShip.Click += new System.EventHandler(this.BtnSetShip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length in containers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width in containers:";
            // 
            // InfoShip
            // 
            this.InfoShip.Controls.Add(this.lblCount);
            this.InfoShip.Controls.Add(this.lblWidth);
            this.InfoShip.Controls.Add(this.lblLength);
            this.InfoShip.Controls.Add(this.label5);
            this.InfoShip.Controls.Add(this.label3);
            this.InfoShip.Controls.Add(this.label4);
            this.InfoShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoShip.Location = new System.Drawing.Point(13, 169);
            this.InfoShip.Name = "InfoShip";
            this.InfoShip.Size = new System.Drawing.Size(310, 150);
            this.InfoShip.TabIndex = 5;
            this.InfoShip.TabStop = false;
            this.InfoShip.Text = "Information Ship";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(178, 87);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 18);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "label8";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(178, 60);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 18);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "label7";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(178, 32);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 18);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount of containers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Length in containers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Width in containers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.lbContainers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTypesContainer);
            this.groupBox1.Controls.Add(this.btnAddContainer);
            this.groupBox1.Controls.Add(this.nudContainerWeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(329, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 300);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Containers";
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(466, 266);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(153, 28);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.ItemHeight = 18;
            this.lbContainers.Location = new System.Drawing.Point(266, 28);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(353, 220);
            this.lbContainers.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type:";
            // 
            // cbTypesContainer
            // 
            this.cbTypesContainer.FormattingEnabled = true;
            this.cbTypesContainer.Location = new System.Drawing.Point(70, 57);
            this.cbTypesContainer.Name = "cbTypesContainer";
            this.cbTypesContainer.Size = new System.Drawing.Size(153, 26);
            this.cbTypesContainer.TabIndex = 10;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Enabled = false;
            this.btnAddContainer.Location = new System.Drawing.Point(70, 104);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(153, 28);
            this.btnAddContainer.TabIndex = 8;
            this.btnAddContainer.Text = "Add Container";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.BtnAddContainer_Click);
            // 
            // nudContainerWeight
            // 
            this.nudContainerWeight.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudContainerWeight.Location = new System.Drawing.Point(70, 28);
            this.nudContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudContainerWeight.Name = "nudContainerWeight";
            this.nudContainerWeight.Size = new System.Drawing.Size(153, 24);
            this.nudContainerWeight.TabIndex = 9;
            this.nudContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Weight:";
            // 
            // lbSortedContainersFront
            // 
            this.lbSortedContainersFront.FormattingEnabled = true;
            this.lbSortedContainersFront.ItemHeight = 16;
            this.lbSortedContainersFront.Location = new System.Drawing.Point(6, 21);
            this.lbSortedContainersFront.Name = "lbSortedContainersFront";
            this.lbSortedContainersFront.Size = new System.Drawing.Size(282, 180);
            this.lbSortedContainersFront.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 242);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSortedContainersFront);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 214);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Front";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSortedContainersMid);
            this.groupBox4.Location = new System.Drawing.Point(316, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 214);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mid";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbSortedContainersBack);
            this.groupBox5.Location = new System.Drawing.Point(625, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 214);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Back";
            // 
            // lbSortedContainersMid
            // 
            this.lbSortedContainersMid.FormattingEnabled = true;
            this.lbSortedContainersMid.ItemHeight = 16;
            this.lbSortedContainersMid.Location = new System.Drawing.Point(6, 21);
            this.lbSortedContainersMid.Name = "lbSortedContainersMid";
            this.lbSortedContainersMid.Size = new System.Drawing.Size(282, 180);
            this.lbSortedContainersMid.TabIndex = 15;
            // 
            // lbSortedContainersBack
            // 
            this.lbSortedContainersBack.FormattingEnabled = true;
            this.lbSortedContainersBack.ItemHeight = 16;
            this.lbSortedContainersBack.Location = new System.Drawing.Point(6, 21);
            this.lbSortedContainersBack.Name = "lbSortedContainersBack";
            this.lbSortedContainersBack.Size = new System.Drawing.Size(282, 180);
            this.lbSortedContainersBack.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoShip);
            this.Controls.Add(this.ConfigShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConfigShip.ResumeLayout(false);
            this.ConfigShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.InfoShip.ResumeLayout(false);
            this.InfoShip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigShip;
        private System.Windows.Forms.Button btnSetShip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InfoShip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTypesContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.NumericUpDown nudContainerWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lbSortedContainersFront;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbSortedContainersBack;
        private System.Windows.Forms.ListBox lbSortedContainersMid;
    }
}

