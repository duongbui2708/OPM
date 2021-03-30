
namespace OPM.GUI
{
    partial class DescriptionSiteForm
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
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbhead = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbFax = new System.Windows.Forms.TextBox();
            this.txbAccount = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Representative = new System.Windows.Forms.Label();
            this.txbRepresen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(107, 37);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(130, 23);
            this.txbID.TabIndex = 0;
            // 
            // txbhead
            // 
            this.txbhead.Location = new System.Drawing.Point(107, 102);
            this.txbhead.Name = "txbhead";
            this.txbhead.Size = new System.Drawing.Size(130, 23);
            this.txbhead.TabIndex = 1;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(108, 170);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(129, 23);
            this.txbAddress.TabIndex = 2;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(107, 243);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(130, 23);
            this.txbPhone.TabIndex = 3;
            // 
            // txbFax
            // 
            this.txbFax.Location = new System.Drawing.Point(107, 303);
            this.txbFax.Name = "txbFax";
            this.txbFax.Size = new System.Drawing.Size(130, 23);
            this.txbFax.TabIndex = 4;
            // 
            // txbAccount
            // 
            this.txbAccount.Location = new System.Drawing.Point(108, 359);
            this.txbAccount.Name = "txbAccount";
            this.txbAccount.Size = new System.Drawing.Size(129, 23);
            this.txbAccount.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Headquater Infor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account";
            // 
            // Representative
            // 
            this.Representative.AutoSize = true;
            this.Representative.Location = new System.Drawing.Point(7, 420);
            this.Representative.Name = "Representative";
            this.Representative.Size = new System.Drawing.Size(84, 15);
            this.Representative.TabIndex = 12;
            this.Representative.Text = "Representative";
            this.Representative.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbRepresen
            // 
            this.txbRepresen.Location = new System.Drawing.Point(107, 420);
            this.txbRepresen.Name = "txbRepresen";
            this.txbRepresen.Size = new System.Drawing.Size(130, 23);
            this.txbRepresen.TabIndex = 13;
            // 
            // DescriptionSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 494);
            this.Controls.Add(this.txbRepresen);
            this.Controls.Add(this.Representative);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txbAccount);
            this.Controls.Add(this.txbFax);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbhead);
            this.Controls.Add(this.txbID);
            this.Name = "DescriptionSiteForm";
            this.Text = "DesscriptionSiteFormcs";
            this.Activated += new System.EventHandler(this.DescriptionSiteForm_Activated);
            this.Load += new System.EventHandler(this.DescriptionSiteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbhead;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbFax;
        private System.Windows.Forms.TextBox txbAccount;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Representative;
        private System.Windows.Forms.TextBox txbRepresen;
    }
}