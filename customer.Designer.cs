namespace LaundryManagementSystem.Properties
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.Label();
            this.cMobile = new System.Windows.Forms.Label();
            this.cNIC = new System.Windows.Forms.Label();
            this.cAddress = new System.Windows.Forms.Label();
            this.notificaton = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusMobile = new System.Windows.Forms.TextBox();
            this.txtCusNIC = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.txtCusNotification = new System.Windows.Forms.ComboBox();
            this.btnCusSave = new System.Windows.Forms.Button();
            this.btnCusReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Image = ((System.Drawing.Image)(resources.GetObject("lblCustomer.Image")));
            this.lblCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomer.Location = new System.Drawing.Point(36, 55);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(406, 44);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "      Customer Details";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(91, 152);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(70, 25);
            this.cName.TabIndex = 1;
            this.cName.Text = "Name";
            // 
            // cMobile
            // 
            this.cMobile.AutoSize = true;
            this.cMobile.Location = new System.Drawing.Point(91, 231);
            this.cMobile.Name = "cMobile";
            this.cMobile.Size = new System.Drawing.Size(157, 25);
            this.cMobile.TabIndex = 2;
            this.cMobile.Text = "MobileNumber";
            // 
            // cNIC
            // 
            this.cNIC.AutoSize = true;
            this.cNIC.Location = new System.Drawing.Point(91, 319);
            this.cNIC.Name = "cNIC";
            this.cNIC.Size = new System.Drawing.Size(49, 25);
            this.cNIC.TabIndex = 3;
            this.cNIC.Text = "NIC";
            // 
            // cAddress
            // 
            this.cAddress.AutoSize = true;
            this.cAddress.Location = new System.Drawing.Point(91, 480);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(91, 25);
            this.cAddress.TabIndex = 4;
            this.cAddress.Text = "Address";
            // 
            // notificaton
            // 
            this.notificaton.AutoSize = true;
            this.notificaton.Location = new System.Drawing.Point(91, 395);
            this.notificaton.Name = "notificaton";
            this.notificaton.Size = new System.Drawing.Size(242, 25);
            this.notificaton.TabIndex = 5;
            this.notificaton.Text = "Notification preference";
            // 
            // txtCusName
            // 
            this.txtCusName.BackColor = System.Drawing.Color.White;
            this.txtCusName.Location = new System.Drawing.Point(96, 180);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(237, 32);
            this.txtCusName.TabIndex = 6;
            // 
            // txtCusMobile
            // 
            this.txtCusMobile.BackColor = System.Drawing.Color.White;
            this.txtCusMobile.Location = new System.Drawing.Point(96, 259);
            this.txtCusMobile.Name = "txtCusMobile";
            this.txtCusMobile.Size = new System.Drawing.Size(237, 32);
            this.txtCusMobile.TabIndex = 7;
            // 
            // txtCusNIC
            // 
            this.txtCusNIC.BackColor = System.Drawing.Color.White;
            this.txtCusNIC.Location = new System.Drawing.Point(96, 347);
            this.txtCusNIC.Name = "txtCusNIC";
            this.txtCusNIC.Size = new System.Drawing.Size(237, 32);
            this.txtCusNIC.TabIndex = 8;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.BackColor = System.Drawing.Color.White;
            this.txtCusAddress.Location = new System.Drawing.Point(96, 508);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(237, 32);
            this.txtCusAddress.TabIndex = 9;
            // 
            // txtCusNotification
            // 
            this.txtCusNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCusNotification.FormattingEnabled = true;
            this.txtCusNotification.Items.AddRange(new object[] {
            "Whatsapp",
            "Viber",
            "SMS",
            "Call me"});
            this.txtCusNotification.Location = new System.Drawing.Point(96, 433);
            this.txtCusNotification.Name = "txtCusNotification";
            this.txtCusNotification.Size = new System.Drawing.Size(237, 33);
            this.txtCusNotification.TabIndex = 10;
            // 
            // btnCusSave
            // 
            this.btnCusSave.BackColor = System.Drawing.Color.Navy;
            this.btnCusSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCusSave.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnCusSave.Image = ((System.Drawing.Image)(resources.GetObject("btnCusSave.Image")));
            this.btnCusSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusSave.Location = new System.Drawing.Point(96, 594);
            this.btnCusSave.Name = "btnCusSave";
            this.btnCusSave.Size = new System.Drawing.Size(99, 44);
            this.btnCusSave.TabIndex = 11;
            this.btnCusSave.Text = "Save";
            this.btnCusSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCusSave.UseVisualStyleBackColor = false;
            this.btnCusSave.Click += new System.EventHandler(this.btnCusSave_Click);
            // 
            // btnCusReset
            // 
            this.btnCusReset.BackColor = System.Drawing.Color.Navy;
            this.btnCusReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCusReset.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnCusReset.Image = ((System.Drawing.Image)(resources.GetObject("btnCusReset.Image")));
            this.btnCusReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusReset.Location = new System.Drawing.Point(215, 594);
            this.btnCusReset.Name = "btnCusReset";
            this.btnCusReset.Size = new System.Drawing.Size(118, 44);
            this.btnCusReset.TabIndex = 12;
            this.btnCusReset.Text = "Reset";
            this.btnCusReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCusReset.UseVisualStyleBackColor = false;
            this.btnCusReset.Click += new System.EventHandler(this.btnCusReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCusReset);
            this.Controls.Add(this.btnCusSave);
            this.Controls.Add(this.txtCusNotification);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusNIC);
            this.Controls.Add(this.txtCusMobile);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.notificaton);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.cNIC);
            this.Controls.Add(this.cMobile);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.lblCustomer);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "customer";
            this.Size = new System.Drawing.Size(1485, 825);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.Label cMobile;
        private System.Windows.Forms.Label cNIC;
        private System.Windows.Forms.Label cAddress;
        private System.Windows.Forms.Label notificaton;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusMobile;
        private System.Windows.Forms.TextBox txtCusNIC;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.ComboBox txtCusNotification;
        private System.Windows.Forms.Button btnCusSave;
        private System.Windows.Forms.Button btnCusReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.EventLog eventLog1;
    }
}
