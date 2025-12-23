namespace LaundryManagementSystem.Properties
{
    partial class inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            this.lblInventoryImg = new System.Windows.Forms.Label();
            this.lblInventoryHistory = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.dataInventory = new System.Windows.Forms.DataGridView();
            this.lblInvDetergent = new System.Windows.Forms.Label();
            this.lblInvSoftner = new System.Windows.Forms.Label();
            this.lblInvChemical = new System.Windows.Forms.Label();
            this.txtInvDetergent = new System.Windows.Forms.TextBox();
            this.txtInvSoftner = new System.Windows.Forms.MaskedTextBox();
            this.txtInvChemical = new System.Windows.Forms.MaskedTextBox();
            this.btnInvUpdate = new System.Windows.Forms.Button();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.txtInvDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryImg
            // 
            this.lblInventoryImg.AutoSize = true;
            this.lblInventoryImg.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryImg.Image = ((System.Drawing.Image)(resources.GetObject("lblInventoryImg.Image")));
            this.lblInventoryImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInventoryImg.Location = new System.Drawing.Point(40, 0);
            this.lblInventoryImg.Name = "lblInventoryImg";
            this.lblInventoryImg.Size = new System.Drawing.Size(151, 116);
            this.lblInventoryImg.TabIndex = 0;
            this.lblInventoryImg.Text = "   ";
            this.lblInventoryImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInventoryHistory
            // 
            this.lblInventoryHistory.AutoSize = true;
            this.lblInventoryHistory.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryHistory.Location = new System.Drawing.Point(142, 40);
            this.lblInventoryHistory.Name = "lblInventoryHistory";
            this.lblInventoryHistory.Size = new System.Drawing.Size(334, 44);
            this.lblInventoryHistory.TabIndex = 1;
            this.lblInventoryHistory.Text = "Inventory History";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // dataInventory
            // 
            this.dataInventory.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventory.Location = new System.Drawing.Point(276, 110);
            this.dataInventory.Name = "dataInventory";
            this.dataInventory.RowHeadersWidth = 62;
            this.dataInventory.RowTemplate.Height = 28;
            this.dataInventory.Size = new System.Drawing.Size(692, 365);
            this.dataInventory.TabIndex = 2;
            this.dataInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInventory_CellClick);
            // 
            // lblInvDetergent
            // 
            this.lblInvDetergent.AutoSize = true;
            this.lblInvDetergent.Location = new System.Drawing.Point(55, 232);
            this.lblInvDetergent.Name = "lblInvDetergent";
            this.lblInvDetergent.Size = new System.Drawing.Size(113, 25);
            this.lblInvDetergent.TabIndex = 3;
            this.lblInvDetergent.Text = "Detergent";
            // 
            // lblInvSoftner
            // 
            this.lblInvSoftner.AutoSize = true;
            this.lblInvSoftner.Location = new System.Drawing.Point(55, 317);
            this.lblInvSoftner.Name = "lblInvSoftner";
            this.lblInvSoftner.Size = new System.Drawing.Size(87, 25);
            this.lblInvSoftner.TabIndex = 4;
            this.lblInvSoftner.Text = "Softner";
            // 
            // lblInvChemical
            // 
            this.lblInvChemical.AutoSize = true;
            this.lblInvChemical.Location = new System.Drawing.Point(55, 406);
            this.lblInvChemical.Name = "lblInvChemical";
            this.lblInvChemical.Size = new System.Drawing.Size(104, 25);
            this.lblInvChemical.TabIndex = 5;
            this.lblInvChemical.Text = "Chemical";
            // 
            // txtInvDetergent
            // 
            this.txtInvDetergent.Location = new System.Drawing.Point(60, 260);
            this.txtInvDetergent.Name = "txtInvDetergent";
            this.txtInvDetergent.Size = new System.Drawing.Size(189, 32);
            this.txtInvDetergent.TabIndex = 6;
            // 
            // txtInvSoftner
            // 
            this.txtInvSoftner.Location = new System.Drawing.Point(60, 345);
            this.txtInvSoftner.Name = "txtInvSoftner";
            this.txtInvSoftner.Size = new System.Drawing.Size(189, 32);
            this.txtInvSoftner.TabIndex = 7;
            // 
            // txtInvChemical
            // 
            this.txtInvChemical.Location = new System.Drawing.Point(60, 434);
            this.txtInvChemical.Name = "txtInvChemical";
            this.txtInvChemical.Size = new System.Drawing.Size(189, 32);
            this.txtInvChemical.TabIndex = 8;
            // 
            // btnInvUpdate
            // 
            this.btnInvUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInvUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnInvUpdate.Location = new System.Drawing.Point(60, 509);
            this.btnInvUpdate.Name = "btnInvUpdate";
            this.btnInvUpdate.Size = new System.Drawing.Size(131, 57);
            this.btnInvUpdate.TabIndex = 9;
            this.btnInvUpdate.Text = "Update";
            this.btnInvUpdate.UseVisualStyleBackColor = false;
            this.btnInvUpdate.Click += new System.EventHandler(this.btnInvUpdate_Click);
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(55, 136);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(59, 25);
            this.lblInvDate.TabIndex = 10;
            this.lblInvDate.Text = "Date";
            // 
            // txtInvDate
            // 
            this.txtInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtInvDate.Location = new System.Drawing.Point(60, 164);
            this.txtInvDate.Name = "txtInvDate";
            this.txtInvDate.Size = new System.Drawing.Size(189, 32);
            this.txtInvDate.TabIndex = 11;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtInvDate);
            this.Controls.Add(this.lblInvDate);
            this.Controls.Add(this.btnInvUpdate);
            this.Controls.Add(this.txtInvChemical);
            this.Controls.Add(this.txtInvSoftner);
            this.Controls.Add(this.txtInvDetergent);
            this.Controls.Add(this.lblInvChemical);
            this.Controls.Add(this.lblInvSoftner);
            this.Controls.Add(this.lblInvDetergent);
            this.Controls.Add(this.dataInventory);
            this.Controls.Add(this.lblInventoryHistory);
            this.Controls.Add(this.lblInventoryImg);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(1485, 825);
            this.Load += new System.EventHandler(this.inventory_Load);
            this.Enter += new System.EventHandler(this.inventory_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryImg;
        private System.Windows.Forms.Label lblInventoryHistory;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataInventory;
        private System.Windows.Forms.Label lblInvDetergent;
        private System.Windows.Forms.Button btnInvUpdate;
        private System.Windows.Forms.MaskedTextBox txtInvChemical;
        private System.Windows.Forms.MaskedTextBox txtInvSoftner;
        private System.Windows.Forms.TextBox txtInvDetergent;
        private System.Windows.Forms.Label lblInvChemical;
        private System.Windows.Forms.Label lblInvSoftner;
        private System.Windows.Forms.DateTimePicker txtInvDate;
        private System.Windows.Forms.Label lblInvDate;
    }
}
