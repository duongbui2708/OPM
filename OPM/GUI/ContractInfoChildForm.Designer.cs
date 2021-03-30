
using System.Drawing;

namespace OPM.GUI
{
    partial class ContractInfoChildForm
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
            this.btnDescriptionA = new System.Windows.Forms.Button();
            this.tbContract = new System.Windows.Forms.TextBox();
            this.tbBidName = new System.Windows.Forms.TextBox();
            this.tbAccountingCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxDurationContract = new System.Windows.Forms.TextBox();
            this.txbTypeContract = new System.Windows.Forms.TextBox();
            this.tbxValueContract = new System.Windows.Forms.TextBox();
            this.tbxDurationPO = new System.Windows.Forms.TextBox();
            this.tbxSiteA = new System.Windows.Forms.TextBox();
            this.tbxSiteB = new System.Windows.Forms.TextBox();
            this.btnNewPO = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbGaranteeValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerDateSignedPO = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDurationDateContract = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerActiveDateContract = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txbKHMS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txbGaranteeActiveDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDescriptionA
            // 
            this.btnDescriptionA.Location = new System.Drawing.Point(369, 365);
            this.btnDescriptionA.Name = "btnDescriptionA";
            this.btnDescriptionA.Size = new System.Drawing.Size(75, 23);
            this.btnDescriptionA.TabIndex = 0;
            this.btnDescriptionA.Text = "Desc...";
            this.btnDescriptionA.UseVisualStyleBackColor = true;
            this.btnDescriptionA.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbContract
            // 
            this.tbContract.BackColor = System.Drawing.SystemColors.Window;
            this.tbContract.Location = new System.Drawing.Point(140, 35);
            this.tbContract.Name = "tbContract";
            this.tbContract.Size = new System.Drawing.Size(305, 23);
            this.tbContract.TabIndex = 1;
            // 
            // tbBidName
            // 
            this.tbBidName.Location = new System.Drawing.Point(140, 65);
            this.tbBidName.Name = "tbBidName";
            this.tbBidName.Size = new System.Drawing.Size(305, 23);
            this.tbBidName.TabIndex = 1;
            // 
            // tbAccountingCode
            // 
            this.tbAccountingCode.Location = new System.Drawing.Point(140, 95);
            this.tbAccountingCode.Name = "tbAccountingCode";
            this.tbAccountingCode.Size = new System.Drawing.Size(305, 23);
            this.tbAccountingCode.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Desc...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Gói Thầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Kế Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời Hạn Thực Hiện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại Hợp Đồng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Hiệu Lực";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá Trị Hợp Đồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thời Hạn Bảo Lãnh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "SiteA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "SiteB";
            // 
            // tbxDurationContract
            // 
            this.tbxDurationContract.Location = new System.Drawing.Point(140, 155);
            this.tbxDurationContract.Name = "tbxDurationContract";
            this.tbxDurationContract.Size = new System.Drawing.Size(78, 23);
            this.tbxDurationContract.TabIndex = 1;
            this.tbxDurationContract.TextChanged += new System.EventHandler(this.tbxDurationContract_TextChanged);
            // 
            // txbTypeContract
            // 
            this.txbTypeContract.Location = new System.Drawing.Point(140, 185);
            this.txbTypeContract.Name = "txbTypeContract";
            this.txbTypeContract.Size = new System.Drawing.Size(305, 23);
            this.txbTypeContract.TabIndex = 1;
            // 
            // tbxValueContract
            // 
            this.tbxValueContract.Location = new System.Drawing.Point(140, 245);
            this.tbxValueContract.Name = "tbxValueContract";
            this.tbxValueContract.Size = new System.Drawing.Size(250, 23);
            this.tbxValueContract.TabIndex = 1;
            // 
            // tbxDurationPO
            // 
            this.tbxDurationPO.Location = new System.Drawing.Point(140, 275);
            this.tbxDurationPO.Name = "tbxDurationPO";
            this.tbxDurationPO.Size = new System.Drawing.Size(250, 23);
            this.tbxDurationPO.TabIndex = 1;
            // 
            // tbxSiteA
            // 
            this.tbxSiteA.Location = new System.Drawing.Point(140, 365);
            this.tbxSiteA.Name = "tbxSiteA";
            this.tbxSiteA.Size = new System.Drawing.Size(202, 23);
            this.tbxSiteA.TabIndex = 1;
            // 
            // tbxSiteB
            // 
            this.tbxSiteB.Location = new System.Drawing.Point(140, 395);
            this.tbxSiteB.Name = "tbxSiteB";
            this.tbxSiteB.Size = new System.Drawing.Size(202, 23);
            this.tbxSiteB.TabIndex = 1;
            // 
            // btnNewPO
            // 
            this.btnNewPO.Location = new System.Drawing.Point(369, 457);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 23);
            this.btnNewPO.TabIndex = 4;
            this.btnNewPO.Text = "New PO";
            this.btnNewPO.UseVisualStyleBackColor = true;
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(203, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(122, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tạo Bảo Lãnh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbGaranteeValue
            // 
            this.txbGaranteeValue.Location = new System.Drawing.Point(140, 305);
            this.txbGaranteeValue.Name = "txbGaranteeValue";
            this.txbGaranteeValue.Size = new System.Drawing.Size(100, 23);
            this.txbGaranteeValue.TabIndex = 7;
            this.txbGaranteeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Giá Trị Bảo Lãnh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ngày hết hạn bảo lãnh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(240, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "%";
            // 
            // dateTimePickerDateSignedPO
            // 
            this.dateTimePickerDateSignedPO.Location = new System.Drawing.Point(245, 125);
            this.dateTimePickerDateSignedPO.Name = "dateTimePickerDateSignedPO";
            this.dateTimePickerDateSignedPO.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDateSignedPO.TabIndex = 8;
            // 
            // dateTimePickerDurationDateContract
            // 
            this.dateTimePickerDurationDateContract.Location = new System.Drawing.Point(245, 155);
            this.dateTimePickerDurationDateContract.Name = "dateTimePickerDurationDateContract";
            this.dateTimePickerDurationDateContract.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDurationDateContract.TabIndex = 9;
            // 
            // dateTimePickerActiveDateContract
            // 
            this.dateTimePickerActiveDateContract.Location = new System.Drawing.Point(245, 215);
            this.dateTimePickerActiveDateContract.Name = "dateTimePickerActiveDateContract";
            this.dateTimePickerActiveDateContract.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerActiveDateContract.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Kế Hoạch Mua Sắm";
            // 
            // txbKHMS
            // 
            this.txbKHMS.Location = new System.Drawing.Point(140, 5);
            this.txbKHMS.Name = "txbKHMS";
            this.txbKHMS.Size = new System.Drawing.Size(305, 23);
            this.txbKHMS.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(399, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "VND";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(399, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "Ngày";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Location = new System.Drawing.Point(245, 336);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(200, 23);
            this.ExpirationDate.TabIndex = 15;
            // 
            // txbGaranteeActiveDate
            // 
            this.txbGaranteeActiveDate.Location = new System.Drawing.Point(140, 336);
            this.txbGaranteeActiveDate.Name = "txbGaranteeActiveDate";
            this.txbGaranteeActiveDate.Size = new System.Drawing.Size(79, 23);
            this.txbGaranteeActiveDate.TabIndex = 16;
            this.txbGaranteeActiveDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContractInfoChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 550);
            this.Controls.Add(this.txbGaranteeActiveDate);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txbKHMS);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerActiveDateContract);
            this.Controls.Add(this.dateTimePickerDurationDateContract);
            this.Controls.Add(this.dateTimePickerDateSignedPO);
            this.Controls.Add(this.txbGaranteeValue);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxSiteB);
            this.Controls.Add(this.tbxSiteA);
            this.Controls.Add(this.tbxDurationPO);
            this.Controls.Add(this.tbxValueContract);
            this.Controls.Add(this.txbTypeContract);
            this.Controls.Add(this.tbxDurationContract);
            this.Controls.Add(this.tbAccountingCode);
            this.Controls.Add(this.tbBidName);
            this.Controls.Add(this.tbContract);
            this.Controls.Add(this.btnDescriptionA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractInfoChildForm";
            this.Text = "ContractInfoChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescriptionA;
        private System.Windows.Forms.TextBox tbContract;
        private System.Windows.Forms.TextBox tbBidName;
        private System.Windows.Forms.TextBox tbAccountingCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxDurationContract;
        private System.Windows.Forms.TextBox txbTypeContract;
        private System.Windows.Forms.TextBox tbxValueContract;
        private System.Windows.Forms.TextBox tbxDurationPO;
        private System.Windows.Forms.TextBox tbxSiteA;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnNewPO;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSiteB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbGaranteeValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSignedPO;
        private System.Windows.Forms.DateTimePicker dateTimePickerDurationDateContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerActiveDateContract;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbKHMS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker ExpirationDate;
        private System.Windows.Forms.TextBox txbGaranteeActiveDate;
    }
}