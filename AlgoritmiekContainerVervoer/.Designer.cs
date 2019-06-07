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
            this.lblContainersWeight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblShipWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountUnsorted = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbUnsortedContainers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypesContainer = new System.Windows.Forms.ComboBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.nudContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSortedContainers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConfigShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.InfoShip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.btnSetShip.Location = new System.Drawing.Point(181, 116);
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
            this.InfoShip.Controls.Add(this.lblContainersWeight);
            this.InfoShip.Controls.Add(this.label11);
            this.InfoShip.Controls.Add(this.lblShipWeight);
            this.InfoShip.Controls.Add(this.label9);
            this.InfoShip.Controls.Add(this.lblCountUnsorted);
            this.InfoShip.Controls.Add(this.lblWidth);
            this.InfoShip.Controls.Add(this.lblLength);
            this.InfoShip.Controls.Add(this.label5);
            this.InfoShip.Controls.Add(this.label3);
            this.InfoShip.Controls.Add(this.label4);
            this.InfoShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoShip.Location = new System.Drawing.Point(13, 169);
            this.InfoShip.Name = "InfoShip";
            this.InfoShip.Size = new System.Drawing.Size(310, 144);
            this.InfoShip.TabIndex = 5;
            this.InfoShip.TabStop = false;
            this.InfoShip.Text = "Information Ship";
            // 
            // lblContainersWeight
            // 
            this.lblContainersWeight.AutoSize = true;
            this.lblContainersWeight.Location = new System.Drawing.Point(232, 93);
            this.lblContainersWeight.Name = "lblContainersWeight";
            this.lblContainersWeight.Size = new System.Drawing.Size(46, 18);
            this.lblContainersWeight.TabIndex = 9;
            this.lblContainersWeight.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Containers weight:";
            // 
            // lblShipWeight
            // 
            this.lblShipWeight.AutoSize = true;
            this.lblShipWeight.Location = new System.Drawing.Point(232, 75);
            this.lblShipWeight.Name = "lblShipWeight";
            this.lblShipWeight.Size = new System.Drawing.Size(46, 18);
            this.lblShipWeight.TabIndex = 7;
            this.lblShipWeight.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ship weight:";
            // 
            // lblCountUnsorted
            // 
            this.lblCountUnsorted.AutoSize = true;
            this.lblCountUnsorted.Location = new System.Drawing.Point(232, 120);
            this.lblCountUnsorted.Name = "lblCountUnsorted";
            this.lblCountUnsorted.Size = new System.Drawing.Size(46, 18);
            this.lblCountUnsorted.TabIndex = 5;
            this.lblCountUnsorted.Text = "label8";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(232, 47);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 18);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "label7";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(232, 19);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 18);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount of unsorted containers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Length in containers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Width in containers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.lbUnsortedContainers);
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
            // lbUnsortedContainers
            // 
            this.lbUnsortedContainers.FormattingEnabled = true;
            this.lbUnsortedContainers.ItemHeight = 18;
            this.lbUnsortedContainers.Location = new System.Drawing.Point(266, 42);
            this.lbUnsortedContainers.Name = "lbUnsortedContainers";
            this.lbUnsortedContainers.Size = new System.Drawing.Size(353, 220);
            this.lbUnsortedContainers.TabIndex = 12;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.lbSortedContainers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 354);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship";
            // 
            // lbSortedContainers
            // 
            this.lbSortedContainers.FormattingEnabled = true;
            this.lbSortedContainers.ItemHeight = 16;
            this.lbSortedContainers.Location = new System.Drawing.Point(6, 21);
            this.lbSortedContainers.Name = "lbSortedContainers";
            this.lbSortedContainers.Size = new System.Drawing.Size(533, 324);
            this.lbSortedContainers.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Unsorted Containers:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(712, 21);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(16, 18);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(579, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Balance in percent:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 692);
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
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lblCountUnsorted;
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
        private System.Windows.Forms.ListBox lbUnsortedContainers;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbSortedContainers;
        private System.Windows.Forms.Label lblShipWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblContainersWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBalance;
    }
}

