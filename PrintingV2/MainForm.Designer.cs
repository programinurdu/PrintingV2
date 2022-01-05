namespace PrintingV2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalToPayLabel = new System.Windows.Forms.Label();
            this.TotalToPayTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.PrintOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(973, 529);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ControlText;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(-29, -1);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1070, 69);
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGroupBox.Controls.Add(this.AddToCartButton);
            this.ItemGroupBox.Controls.Add(this.ItemNameComboBox);
            this.ItemGroupBox.Controls.Add(this.UnitPriceTextBox);
            this.ItemGroupBox.Controls.Add(this.QuantityTextBox);
            this.ItemGroupBox.Controls.Add(this.ClientNameTextBox);
            this.ItemGroupBox.Controls.Add(this.UnitPriceLabel);
            this.ItemGroupBox.Controls.Add(this.QuantityLabel);
            this.ItemGroupBox.Controls.Add(this.ItemNameLabel);
            this.ItemGroupBox.Controls.Add(this.ClientNameLabel);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(13, 76);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Size = new System.Drawing.Size(766, 143);
            this.ItemGroupBox.TabIndex = 2;
            this.ItemGroupBox.TabStop = false;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(32, 97);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(232, 24);
            this.ItemNameComboBox.TabIndex = 1;
            this.ItemNameComboBox.SelectedValueChanged += new System.EventHandler(this.ItemNameComboBox_SelectedValueChanged);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(436, 97);
            this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.ReadOnly = true;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(93, 23);
            this.UnitPriceTextBox.TabIndex = 3;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(294, 97);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(93, 23);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(128, 22);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(432, 23);
            this.ClientNameTextBox.TabIndex = 0;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(447, 74);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.UnitPriceLabel.TabIndex = 0;
            this.UnitPriceLabel.Text = "Unit Price:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(311, 74);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(65, 17);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(29, 74);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(79, 17);
            this.ItemNameLabel.TabIndex = 0;
            this.ItemNameLabel.Text = "Item Name:";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(29, 25);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(88, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(13, 239);
            this.CartDataGridView.MultiSelect = false;
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.ReadOnly = true;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(939, 173);
            this.CartDataGridView.TabIndex = 4;
            this.CartDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartDataGridView_MouseDown);
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(684, 432);
            this.TotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(118, 17);
            this.TotalAmountLabel.TabIndex = 0;
            this.TotalAmountLabel.Text = "Total Amount (£):";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountTextBox.Location = new System.Drawing.Point(826, 429);
            this.TotalAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.ReadOnly = true;
            this.TotalAmountTextBox.Size = new System.Drawing.Size(126, 23);
            this.TotalAmountTextBox.TabIndex = 9;
            this.TotalAmountTextBox.Text = "0";
            this.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(684, 463);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(138, 17);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax (16%) (£):";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxTextBox.Location = new System.Drawing.Point(826, 460);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(126, 23);
            this.SalesTaxTextBox.TabIndex = 10;
            this.SalesTaxTextBox.Text = "0";
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalToPayLabel
            // 
            this.TotalToPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPayLabel.AutoSize = true;
            this.TotalToPayLabel.Location = new System.Drawing.Point(684, 494);
            this.TotalToPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalToPayLabel.Name = "TotalToPayLabel";
            this.TotalToPayLabel.Size = new System.Drawing.Size(115, 17);
            this.TotalToPayLabel.TabIndex = 0;
            this.TotalToPayLabel.Text = "Total To Pay (£):";
            // 
            // TotalToPayTextBox
            // 
            this.TotalToPayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPayTextBox.Location = new System.Drawing.Point(826, 491);
            this.TotalToPayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalToPayTextBox.Name = "TotalToPayTextBox";
            this.TotalToPayTextBox.ReadOnly = true;
            this.TotalToPayTextBox.Size = new System.Drawing.Size(126, 23);
            this.TotalToPayTextBox.TabIndex = 11;
            this.TotalToPayTextBox.Text = "0";
            this.TotalToPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelOrderButton.Enabled = false;
            this.CancelOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelOrderButton.Image")));
            this.CancelOrderButton.Location = new System.Drawing.Point(13, 426);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(151, 38);
            this.CancelOrderButton.TabIndex = 8;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreviewButton.Enabled = false;
            this.PrintPreviewButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewButton.Image")));
            this.PrintPreviewButton.Location = new System.Drawing.Point(802, 180);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(151, 38);
            this.PrintPreviewButton.TabIndex = 7;
            this.PrintPreviewButton.Text = "Print Preview";
            this.PrintPreviewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPreviewButton.UseVisualStyleBackColor = true;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewButton_Click);
            // 
            // PrintOrderButton
            // 
            this.PrintOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintOrderButton.Enabled = false;
            this.PrintOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintOrderButton.Image")));
            this.PrintOrderButton.Location = new System.Drawing.Point(802, 132);
            this.PrintOrderButton.Name = "PrintOrderButton";
            this.PrintOrderButton.Size = new System.Drawing.Size(151, 38);
            this.PrintOrderButton.TabIndex = 6;
            this.PrintOrderButton.Text = "Print Order";
            this.PrintOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintOrderButton.UseVisualStyleBackColor = true;
            this.PrintOrderButton.Click += new System.EventHandler(this.PrintOrderButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("NewOrderButton.Image")));
            this.NewOrderButton.Location = new System.Drawing.Point(802, 84);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(151, 38);
            this.NewOrderButton.TabIndex = 5;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToCartButton.Image")));
            this.AddToCartButton.Location = new System.Drawing.Point(583, 23);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(106, 97);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 529);
            this.Controls.Add(this.TotalToPayTextBox);
            this.Controls.Add(this.TotalToPayLabel);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.PrintOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.ItemGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Javed Trading Ltd - Lahore";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button PrintOrderButton;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label TotalToPayLabel;
        private System.Windows.Forms.TextBox TotalToPayTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

