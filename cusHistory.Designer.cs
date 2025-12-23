namespace LaundryManagementSystem.Properties
{
    partial class cusHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cusHistory));
            this.lblCusHistory = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.dataCusHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cusNamelabel = new System.Windows.Forms.Label();
            this.cusMobilelabel = new System.Windows.Forms.Label();
            this.cusNiclabel = new System.Windows.Forms.Label();
            this.cusNotificationlabel = new System.Windows.Forms.Label();
            this.cusAddresslabel = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusHistory)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCusHistory
            // 
            this.lblCusHistory.AutoSize = true;
            this.lblCusHistory.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusHistory.Image = ((System.Drawing.Image)(resources.GetObject("lblCusHistory.Image")));
            this.lblCusHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCusHistory.Location = new System.Drawing.Point(81, 38);
            this.lblCusHistory.Name = "lblCusHistory";
            this.lblCusHistory.Size = new System.Drawing.Size(359, 44);
            this.lblCusHistory.TabIndex = 0;
            this.lblCusHistory.Text = "  Customer History";
            this.lblCusHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // dataCusHistory
            // 
            this.dataCusHistory.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataCusHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataCusHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCusHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCusHistory.Location = new System.Drawing.Point(36, 101);
            this.dataCusHistory.Name = "dataCusHistory";
            this.dataCusHistory.RowHeadersWidth = 62;
            this.dataCusHistory.RowTemplate.Height = 28;
            this.dataCusHistory.Size = new System.Drawing.Size(917, 385);
            this.dataCusHistory.TabIndex = 1;
            this.dataCusHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCusHistory_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIC ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notification preference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // cusNamelabel
            // 
            this.cusNamelabel.AutoSize = true;
            this.cusNamelabel.Location = new System.Drawing.Point(265, 508);
            this.cusNamelabel.Name = "cusNamelabel";
            this.cusNamelabel.Size = new System.Drawing.Size(57, 25);
            this.cusNamelabel.TabIndex = 7;
            this.cusNamelabel.Text = "-----";
            // 
            // cusMobilelabel
            // 
            this.cusMobilelabel.AutoSize = true;
            this.cusMobilelabel.Location = new System.Drawing.Point(265, 572);
            this.cusMobilelabel.Name = "cusMobilelabel";
            this.cusMobilelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusMobilelabel.Size = new System.Drawing.Size(57, 25);
            this.cusMobilelabel.TabIndex = 8;
            this.cusMobilelabel.Text = "-----";
            // 
            // cusNiclabel
            // 
            this.cusNiclabel.AutoSize = true;
            this.cusNiclabel.Location = new System.Drawing.Point(265, 628);
            this.cusNiclabel.Name = "cusNiclabel";
            this.cusNiclabel.Size = new System.Drawing.Size(57, 25);
            this.cusNiclabel.TabIndex = 9;
            this.cusNiclabel.Text = "-----";
            // 
            // cusNotificationlabel
            // 
            this.cusNotificationlabel.AutoSize = true;
            this.cusNotificationlabel.Location = new System.Drawing.Point(746, 572);
            this.cusNotificationlabel.Name = "cusNotificationlabel";
            this.cusNotificationlabel.Size = new System.Drawing.Size(57, 25);
            this.cusNotificationlabel.TabIndex = 10;
            this.cusNotificationlabel.Text = "-----";
            // 
            // cusAddresslabel
            // 
            this.cusAddresslabel.AutoSize = true;
            this.cusAddresslabel.Location = new System.Drawing.Point(746, 508);
            this.cusAddresslabel.Name = "cusAddresslabel";
            this.cusAddresslabel.Size = new System.Drawing.Size(57, 25);
            this.cusAddresslabel.TabIndex = 11;
            this.cusAddresslabel.Text = "-----";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(1249, 550);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // cusHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.cusAddresslabel);
            this.Controls.Add(this.cusNotificationlabel);
            this.Controls.Add(this.cusNiclabel);
            this.Controls.Add(this.cusMobilelabel);
            this.Controls.Add(this.cusNamelabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCusHistory);
            this.Controls.Add(this.lblCusHistory);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cusHistory";
            this.Size = new System.Drawing.Size(1478, 819);
            this.Load += new System.EventHandler(this.cusHistory_Load);
            this.Enter += new System.EventHandler(this.cusHistory_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusHistory)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusHistory;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataCusHistory;
        private System.Windows.Forms.Label cusAddresslabel;
        private System.Windows.Forms.Label cusNotificationlabel;
        private System.Windows.Forms.Label cusNiclabel;
        private System.Windows.Forms.Label cusMobilelabel;
        private System.Windows.Forms.Label cusNamelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}
