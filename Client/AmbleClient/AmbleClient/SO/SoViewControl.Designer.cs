﻿namespace AmbleClient.SO
{
    partial class SoViewControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbShipTo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbBillto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSpecialInstructions = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCustomerAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFreightTerm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPaymentTerm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCustomerPo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalesOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbApprover = new System.Windows.Forms.TextBox();
            this.tbApproveDate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rohs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSp = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(93, 321);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 25);
            this.btAdd.TabIndex = 53;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Items:";
            // 
            // tbShipTo
            // 
            this.tbShipTo.Location = new System.Drawing.Point(534, 258);
            this.tbShipTo.Multiline = true;
            this.tbShipTo.Name = "tbShipTo";
            this.tbShipTo.Size = new System.Drawing.Size(316, 45);
            this.tbShipTo.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ship To:";
            // 
            // tbBillto
            // 
            this.tbBillto.Location = new System.Drawing.Point(107, 258);
            this.tbBillto.Multiline = true;
            this.tbBillto.Name = "tbBillto";
            this.tbBillto.Size = new System.Drawing.Size(315, 45);
            this.tbBillto.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Bill To:";
            // 
            // tbSpecialInstructions
            // 
            this.tbSpecialInstructions.Location = new System.Drawing.Point(183, 177);
            this.tbSpecialInstructions.Multiline = true;
            this.tbSpecialInstructions.Name = "tbSpecialInstructions";
            this.tbSpecialInstructions.Size = new System.Drawing.Size(667, 54);
            this.tbSpecialInstructions.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Special Instructions:";
            // 
            // tbCustomerAccount
            // 
            this.tbCustomerAccount.Location = new System.Drawing.Point(732, 135);
            this.tbCustomerAccount.Name = "tbCustomerAccount";
            this.tbCustomerAccount.Size = new System.Drawing.Size(118, 20);
            this.tbCustomerAccount.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Customer Account:";
            // 
            // tbFreightTerm
            // 
            this.tbFreightTerm.Location = new System.Drawing.Point(399, 135);
            this.tbFreightTerm.Name = "tbFreightTerm";
            this.tbFreightTerm.Size = new System.Drawing.Size(169, 20);
            this.tbFreightTerm.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Freight Terms:";
            // 
            // tbPaymentTerm
            // 
            this.tbPaymentTerm.Location = new System.Drawing.Point(121, 139);
            this.tbPaymentTerm.Name = "tbPaymentTerm";
            this.tbPaymentTerm.Size = new System.Drawing.Size(144, 20);
            this.tbPaymentTerm.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Payment Term:";
            // 
            // tbCustomerPo
            // 
            this.tbCustomerPo.Location = new System.Drawing.Point(732, 89);
            this.tbCustomerPo.Name = "tbCustomerPo";
            this.tbCustomerPo.Size = new System.Drawing.Size(118, 20);
            this.tbCustomerPo.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Customer PO#";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Order Date:";
            // 
            // tbSalesOrder
            // 
            this.tbSalesOrder.Location = new System.Drawing.Point(119, 89);
            this.tbSalesOrder.Name = "tbSalesOrder";
            this.tbSalesOrder.Size = new System.Drawing.Size(155, 20);
            this.tbSalesOrder.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sales Order#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "S/P:";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(372, 30);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(113, 20);
            this.tbContact.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Contact:";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(107, 25);
            this.tbCustomer.Multiline = true;
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(174, 40);
            this.tbCustomer.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(685, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Apvd. By:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(720, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "On:";
            // 
            // tbApprover
            // 
            this.tbApprover.Location = new System.Drawing.Point(749, 30);
            this.tbApprover.Name = "tbApprover";
            this.tbApprover.ReadOnly = true;
            this.tbApprover.Size = new System.Drawing.Size(101, 20);
            this.tbApprover.TabIndex = 56;
            // 
            // tbApproveDate
            // 
            this.tbApproveDate.Location = new System.Drawing.Point(749, 60);
            this.tbApproveDate.Name = "tbApproveDate";
            this.tbApproveDate.ReadOnly = true;
            this.tbApproveDate.Size = new System.Drawing.Size(100, 20);
            this.tbApproveDate.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.saleType,
            this.PartNo,
            this.Mfg,
            this.Rohs,
            this.Dc,
            this.IntPartNo,
            this.ShipFrom,
            this.ShipMethod,
            this.TrackingNo,
            this.Qty,
            this.QtyShipped,
            this.Currency,
            this.UnitPrice,
            this.Total,
            this.DockDate,
            this.ShippedDate});
            this.dataGridView1.Location = new System.Drawing.Point(21, 364);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(829, 204);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 46;
            // 
            // saleType
            // 
            this.saleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saleType.HeaderText = "Sale Type";
            this.saleType.Name = "saleType";
            this.saleType.Width = 80;
            // 
            // PartNo
            // 
            this.PartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartNo.HeaderText = "Part #";
            this.PartNo.Name = "PartNo";
            this.PartNo.Width = 61;
            // 
            // Mfg
            // 
            this.Mfg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mfg.HeaderText = "Mfg";
            this.Mfg.Name = "Mfg";
            this.Mfg.Width = 50;
            // 
            // Rohs
            // 
            this.Rohs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rohs.HeaderText = "RoHS";
            this.Rohs.Name = "Rohs";
            this.Rohs.Width = 42;
            // 
            // Dc
            // 
            this.Dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dc.HeaderText = "D/C";
            this.Dc.Name = "Dc";
            this.Dc.Width = 52;
            // 
            // IntPartNo
            // 
            this.IntPartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IntPartNo.HeaderText = "Int Part #";
            this.IntPartNo.Name = "IntPartNo";
            this.IntPartNo.Width = 76;
            // 
            // ShipFrom
            // 
            this.ShipFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShipFrom.HeaderText = "Ship From";
            this.ShipFrom.Name = "ShipFrom";
            this.ShipFrom.Width = 79;
            // 
            // ShipMethod
            // 
            this.ShipMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShipMethod.HeaderText = "Ship Method";
            this.ShipMethod.Name = "ShipMethod";
            this.ShipMethod.Width = 92;
            // 
            // TrackingNo
            // 
            this.TrackingNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrackingNo.HeaderText = "tracking #";
            this.TrackingNo.Name = "TrackingNo";
            this.TrackingNo.Width = 80;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 48;
            // 
            // QtyShipped
            // 
            this.QtyShipped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyShipped.HeaderText = "Qty.shipped";
            this.QtyShipped.Name = "QtyShipped";
            this.QtyShipped.Width = 88;
            // 
            // Currency
            // 
            this.Currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.Width = 74;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 78;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 56;
            // 
            // DockDate
            // 
            this.DockDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DockDate.HeaderText = "Dock Date";
            this.DockDate.Name = "DockDate";
            this.DockDate.Width = 84;
            // 
            // ShippedDate
            // 
            this.ShippedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShippedDate.HeaderText = "Shipped Date";
            this.ShippedDate.Name = "ShippedDate";
            this.ShippedDate.Width = 97;
            // 
            // cbSp
            // 
            this.cbSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSp.FormattingEnabled = true;
            this.cbSp.Location = new System.Drawing.Point(557, 31);
            this.cbSp.Name = "cbSp";
            this.cbSp.Size = new System.Drawing.Size(110, 21);
            this.cbSp.TabIndex = 59;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(199, 321);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 25);
            this.btDelete.TabIndex = 60;
            this.btDelete.Text = "button1";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // SoViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cbSp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbApproveDate);
            this.Controls.Add(this.tbApprover);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbShipTo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbBillto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSpecialInstructions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCustomerAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFreightTerm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPaymentTerm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCustomerPo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSalesOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.label1);
            this.Name = "SoViewControl";
            this.Size = new System.Drawing.Size(918, 571);
            this.Load += new System.EventHandler(this.SoViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbShipTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbBillto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSpecialInstructions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCustomerAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFreightTerm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPaymentTerm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCustomerPo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSalesOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbApprover;
        private System.Windows.Forms.TextBox tbApproveDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mfg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rohs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDate;
        private System.Windows.Forms.Button btDelete;

    }
}
