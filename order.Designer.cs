namespace LaundryManagementSystem.Properties
{
    partial class order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSpecCase = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtSpecCase = new System.Windows.Forms.ComboBox();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtDelivery = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.btnOrderReset = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblShowBill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Image = ((System.Drawing.Image)(resources.GetObject("lblOrder.Image")));
            this.lblOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrder.Location = new System.Drawing.Point(39, 42);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(320, 44);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "     Order Details";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(94, 133);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(210, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight of the stuffs";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(94, 213);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(150, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Washing Type";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(94, 289);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(146, 25);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Date of order";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(94, 378);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(173, 25);
            this.lblDelivery.TabIndex = 4;
            this.lblDelivery.Text = "Date of delivery";
            // 
            // lblSpecCase
            // 
            this.lblSpecCase.AutoSize = true;
            this.lblSpecCase.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecCase.Location = new System.Drawing.Point(94, 467);
            this.lblSpecCase.Name = "lblSpecCase";
            this.lblSpecCase.Size = new System.Drawing.Size(167, 25);
            this.lblSpecCase.TabIndex = 5;
            this.lblSpecCase.Text = "Special Criteria";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(99, 161);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(242, 27);
            this.txtWeight.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Normal Wash",
            "Dry clean",
            "Special Criteria"});
            this.txtType.Location = new System.Drawing.Point(99, 241);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(242, 26);
            this.txtType.TabIndex = 7;
            // 
            // txtSpecCase
            // 
            this.txtSpecCase.FormattingEnabled = true;
            this.txtSpecCase.Items.AddRange(new object[] {
            "Ink stain",
            "Oil stain",
            "None"});
            this.txtSpecCase.Location = new System.Drawing.Point(99, 495);
            this.txtSpecCase.Name = "txtSpecCase";
            this.txtSpecCase.Size = new System.Drawing.Size(242, 26);
            this.txtSpecCase.TabIndex = 8;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtOrderDate.Location = new System.Drawing.Point(99, 317);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(242, 32);
            this.txtOrderDate.TabIndex = 9;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDelivery.Location = new System.Drawing.Point(99, 406);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(242, 32);
            this.txtDelivery.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnOrderSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderSave.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderSave.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderSave.Image")));
            this.btnOrderSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderSave.Location = new System.Drawing.Point(588, 579);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(104, 52);
            this.btnOrderSave.TabIndex = 12;
            this.btnOrderSave.Text = "Save";
            this.btnOrderSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderSave.UseVisualStyleBackColor = false;
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // btnOrderReset
            // 
            this.btnOrderReset.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnOrderReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderReset.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderReset.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderReset.Image")));
            this.btnOrderReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderReset.Location = new System.Drawing.Point(736, 579);
            this.btnOrderReset.Name = "btnOrderReset";
            this.btnOrderReset.Size = new System.Drawing.Size(110, 52);
            this.btnOrderReset.TabIndex = 13;
            this.btnOrderReset.Text = "Reset";
            this.btnOrderReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderReset.UseVisualStyleBackColor = false;
            this.btnOrderReset.Click += new System.EventHandler(this.btnOrderReset_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(15, 38);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(97, 25);
            this.lblBill.TabIndex = 14;
            this.lblBill.Text = "Total bill";
            // 
            // lblShowBill
            // 
            this.lblShowBill.AutoSize = true;
            this.lblShowBill.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBill.Location = new System.Drawing.Point(128, 38);
            this.lblShowBill.Name = "lblShowBill";
            this.lblShowBill.Size = new System.Drawing.Size(57, 25);
            this.lblShowBill.TabIndex = 15;
            this.lblShowBill.Text = "-----";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowBill);
            this.groupBox1.Controls.Add(this.lblBill);
            this.groupBox1.Location = new System.Drawing.Point(455, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBill.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(455, 579);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(97, 52);
            this.btnBill.TabIndex = 17;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnOrderReset);
            this.Controls.Add(this.btnOrderSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtSpecCase);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblSpecCase);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "order";
            this.Size = new System.Drawing.Size(1027, 659);
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblSpecCase;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ComboBox txtSpecCase;
        private System.Windows.Forms.DateTimePicker txtOrderDate;
        private System.Windows.Forms.DateTimePicker txtDelivery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.Button btnOrderReset;
        private System.Diagnostics.EventLog eventLog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShowBill;
        private System.Windows.Forms.Label lblBill;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnBill;
    }
}
