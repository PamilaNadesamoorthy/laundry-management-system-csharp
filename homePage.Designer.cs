namespace LaundryManagementSystem
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.homebtnpanel = new System.Windows.Forms.Panel();
            this.btnInventoryHistory = new System.Windows.Forms.Button();
            this.btnCusHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.homeFormPanel = new System.Windows.Forms.Panel();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.eventLog3 = new System.Diagnostics.EventLog();
            this.eventLog4 = new System.Diagnostics.EventLog();
            this.eventLog5 = new System.Diagnostics.EventLog();
            this.eventLog6 = new System.Diagnostics.EventLog();
            this.login1 = new LaundryManagementSystem.Properties.login();
            this.inventory1 = new LaundryManagementSystem.Properties.inventory();
            this.cusHistory1 = new LaundryManagementSystem.Properties.cusHistory();
            this.order1 = new LaundryManagementSystem.Properties.order();
            this.employee1 = new LaundryManagementSystem.Properties.employee();
            this.customer1 = new LaundryManagementSystem.Properties.customer();
            this.homebtnpanel.SuspendLayout();
            this.homeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog6)).BeginInit();
            this.SuspendLayout();
            // 
            // homebtnpanel
            // 
            this.homebtnpanel.BackColor = System.Drawing.Color.Honeydew;
            this.homebtnpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homebtnpanel.BackgroundImage")));
            this.homebtnpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtnpanel.Controls.Add(this.btnInventoryHistory);
            this.homebtnpanel.Controls.Add(this.btnCusHistory);
            this.homebtnpanel.Controls.Add(this.btnOrder);
            this.homebtnpanel.Controls.Add(this.btnEmployee);
            this.homebtnpanel.Controls.Add(this.btnCustomer);
            this.homebtnpanel.Controls.Add(this.btnMinimize);
            this.homebtnpanel.Controls.Add(this.btnExit);
            this.homebtnpanel.Location = new System.Drawing.Point(12, 12);
            this.homebtnpanel.Name = "homebtnpanel";
            this.homebtnpanel.Size = new System.Drawing.Size(273, 663);
            this.homebtnpanel.TabIndex = 0;
            // 
            // btnInventoryHistory
            // 
            this.btnInventoryHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryHistory.BackgroundImage")));
            this.btnInventoryHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventoryHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryHistory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryHistory.Location = new System.Drawing.Point(-1, 545);
            this.btnInventoryHistory.Name = "btnInventoryHistory";
            this.btnInventoryHistory.Size = new System.Drawing.Size(273, 83);
            this.btnInventoryHistory.TabIndex = 6;
            this.btnInventoryHistory.Text = "Inventory History";
            this.btnInventoryHistory.UseVisualStyleBackColor = true;
            this.btnInventoryHistory.Click += new System.EventHandler(this.btnInventoryHistory_Click);
            // 
            // btnCusHistory
            // 
            this.btnCusHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCusHistory.BackgroundImage")));
            this.btnCusHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCusHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCusHistory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCusHistory.Location = new System.Drawing.Point(0, 435);
            this.btnCusHistory.Name = "btnCusHistory";
            this.btnCusHistory.Size = new System.Drawing.Size(273, 83);
            this.btnCusHistory.TabIndex = 5;
            this.btnCusHistory.Text = "Customer History";
            this.btnCusHistory.UseVisualStyleBackColor = true;
            this.btnCusHistory.Click += new System.EventHandler(this.btnCusHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(0, 326);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(273, 83);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.BackgroundImage")));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(0, 209);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(273, 83);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Location = new System.Drawing.Point(0, 98);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(273, 83);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Location = new System.Drawing.Point(44, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // homeFormPanel
            // 
            this.homeFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeFormPanel.BackgroundImage")));
            this.homeFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeFormPanel.Controls.Add(this.login1);
            this.homeFormPanel.Controls.Add(this.inventory1);
            this.homeFormPanel.Controls.Add(this.cusHistory1);
            this.homeFormPanel.Controls.Add(this.order1);
            this.homeFormPanel.Controls.Add(this.employee1);
            this.homeFormPanel.Controls.Add(this.customer1);
            this.homeFormPanel.Location = new System.Drawing.Point(291, 12);
            this.homeFormPanel.Name = "homeFormPanel";
            this.homeFormPanel.Size = new System.Drawing.Size(1031, 663);
            this.homeFormPanel.TabIndex = 1;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // eventLog3
            // 
            this.eventLog3.SynchronizingObject = this;
            // 
            // eventLog4
            // 
            this.eventLog4.SynchronizingObject = this;
            // 
            // eventLog5
            // 
            this.eventLog5.SynchronizingObject = this;
            // 
            // eventLog6
            // 
            this.eventLog6.SynchronizingObject = this;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.ForestGreen;
            this.login1.Location = new System.Drawing.Point(1, -5);
            this.login1.Margin = new System.Windows.Forms.Padding(4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1379, 664);
            this.login1.TabIndex = 5;
            this.login1.VisibleChanged += new System.EventHandler(this.login1_VisibleChanged);
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.LightSalmon;
            this.inventory1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventory1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory1.Location = new System.Drawing.Point(1, 0);
            this.inventory1.Margin = new System.Windows.Forms.Padding(4);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(1030, 662);
            this.inventory1.TabIndex = 4;
            // 
            // cusHistory1
            // 
            this.cusHistory1.AutoSize = true;
            this.cusHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.cusHistory1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cusHistory1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusHistory1.Location = new System.Drawing.Point(0, 0);
            this.cusHistory1.Margin = new System.Windows.Forms.Padding(4);
            this.cusHistory1.Name = "cusHistory1";
            this.cusHistory1.Size = new System.Drawing.Size(1406, 732);
            this.cusHistory1.TabIndex = 3;
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.Thistle;
            this.order1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.order1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order1.Location = new System.Drawing.Point(0, 0);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(1031, 664);
            this.order1.TabIndex = 2;
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.employee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employee1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Margin = new System.Windows.Forms.Padding(4);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(1031, 663);
            this.employee1.TabIndex = 1;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.customer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customer1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer1.ForeColor = System.Drawing.Color.Black;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(4);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1031, 662);
            this.customer1.TabIndex = 0;
            this.customer1.Load += new System.EventHandler(this.customer1_Load);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 687);
            this.Controls.Add(this.homeFormPanel);
            this.Controls.Add(this.homebtnpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.homePage_Load);
            this.homebtnpanel.ResumeLayout(false);
            this.homebtnpanel.PerformLayout();
            this.homeFormPanel.ResumeLayout(false);
            this.homeFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homebtnpanel;
        private System.Windows.Forms.Panel homeFormPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnInventoryHistory;
        private System.Windows.Forms.Button btnCusHistory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Diagnostics.EventLog eventLog1;
        private Properties.customer customer1;
        private System.Diagnostics.EventLog eventLog2;
        private Properties.employee employee1;
        private System.Diagnostics.EventLog eventLog3;
        private Properties.order order1;
        private System.Diagnostics.EventLog eventLog4;
        private Properties.cusHistory cusHistory1;
        private System.Diagnostics.EventLog eventLog5;
        private Properties.inventory inventory1;
        private System.Diagnostics.EventLog eventLog6;
        private Properties.login login1;
    }
}

