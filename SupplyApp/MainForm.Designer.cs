
namespace SupplyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.itemTabPage = new System.Windows.Forms.TabPage();
            this.supplierTabPage = new System.Windows.Forms.TabPage();
            this.supplierDataGrid = new System.Windows.Forms.DataGridView();
            this.supplierMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSuppliersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSupplierItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyTabPage = new System.Windows.Forms.TabPage();
            this.supplyGrid = new System.Windows.Forms.DataGridView();
            this.supplyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.itemContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.itemTabPage.SuspendLayout();
            this.supplierTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).BeginInit();
            this.supplierMenuStrip.SuspendLayout();
            this.supplyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyGrid)).BeginInit();
            this.supplyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemGrid
            // 
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.ContextMenuStrip = this.itemContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemGrid.Location = new System.Drawing.Point(0, 41);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(2);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.RowHeadersWidth = 51;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemGrid.Size = new System.Drawing.Size(654, 223);
            this.itemGrid.TabIndex = 0;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.BackColor = System.Drawing.SystemColors.Window;
            this.itemContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshItem,
            this.addItem,
            this.updateItem,
            this.removeItem});
            this.itemContextMenu.Name = "itemContextMenu";
            this.itemContextMenu.Size = new System.Drawing.Size(129, 92);
            // 
            // refreshItem
            // 
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(128, 22);
            this.refreshItem.Text = "Обновить";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(128, 22);
            this.addItem.Text = "Добавить";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(128, 22);
            this.updateItem.Text = "Изменить";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(128, 22);
            this.removeItem.Text = "Удалить";
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.itemTabPage);
            this.tabControl1.Controls.Add(this.supplierTabPage);
            this.tabControl1.Controls.Add(this.supplyTabPage);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // itemTabPage
            // 
            this.itemTabPage.Controls.Add(this.itemGrid);
            this.itemTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemTabPage.Name = "itemTabPage";
            this.itemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemTabPage.Size = new System.Drawing.Size(654, 355);
            this.itemTabPage.TabIndex = 0;
            this.itemTabPage.Text = "Items";
            this.itemTabPage.UseVisualStyleBackColor = true;
            // 
            // supplierTabPage
            // 
            this.supplierTabPage.Controls.Add(this.supplierDataGrid);
            this.supplierTabPage.Location = new System.Drawing.Point(4, 22);
            this.supplierTabPage.Name = "supplierTabPage";
            this.supplierTabPage.Size = new System.Drawing.Size(654, 355);
            this.supplierTabPage.TabIndex = 2;
            this.supplierTabPage.Text = "Supplier";
            this.supplierTabPage.UseVisualStyleBackColor = true;
            // 
            // supplierDataGrid
            // 
            this.supplierDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.supplierDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.supplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGrid.ContextMenuStrip = this.supplierMenuStrip;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.supplierDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplierDataGrid.Location = new System.Drawing.Point(0, 66);
            this.supplierDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.supplierDataGrid.Name = "supplierDataGrid";
            this.supplierDataGrid.RowHeadersVisible = false;
            this.supplierDataGrid.RowHeadersWidth = 51;
            this.supplierDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supplierDataGrid.RowTemplate.Height = 24;
            this.supplierDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supplierDataGrid.Size = new System.Drawing.Size(654, 223);
            this.supplierDataGrid.TabIndex = 1;
            // 
            // supplierMenuStrip
            // 
            this.supplierMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.supplierMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supplierMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSuppliersItem,
            this.addSupplierItem,
            this.editSupplierItem,
            this.deleteSupplierItem});
            this.supplierMenuStrip.Name = "itemContextMenu";
            this.supplierMenuStrip.Size = new System.Drawing.Size(129, 92);
            this.supplierMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.supplierMenuStrip_Opening);
            // 
            // updateSuppliersItem
            // 
            this.updateSuppliersItem.Name = "updateSuppliersItem";
            this.updateSuppliersItem.Size = new System.Drawing.Size(128, 22);
            this.updateSuppliersItem.Text = "Обновить";
            this.updateSuppliersItem.Click += new System.EventHandler(this.updateSuppliersItem_Click);
            // 
            // addSupplierItem
            // 
            this.addSupplierItem.Name = "addSupplierItem";
            this.addSupplierItem.Size = new System.Drawing.Size(128, 22);
            this.addSupplierItem.Text = "Добавить";
            this.addSupplierItem.Click += new System.EventHandler(this.addSupplierItem_Click);
            // 
            // editSupplierItem
            // 
            this.editSupplierItem.Name = "editSupplierItem";
            this.editSupplierItem.Size = new System.Drawing.Size(128, 22);
            this.editSupplierItem.Text = "Изменить";
            this.editSupplierItem.Click += new System.EventHandler(this.editSupplierItem_Click);
            // 
            // deleteSupplierItem
            // 
            this.deleteSupplierItem.Name = "deleteSupplierItem";
            this.deleteSupplierItem.Size = new System.Drawing.Size(128, 22);
            this.deleteSupplierItem.Text = "Удалить";
            // 
            // supplyTabPage
            // 
            this.supplyTabPage.Controls.Add(this.supplyGrid);
            this.supplyTabPage.Location = new System.Drawing.Point(4, 22);
            this.supplyTabPage.Name = "supplyTabPage";
            this.supplyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.supplyTabPage.Size = new System.Drawing.Size(654, 355);
            this.supplyTabPage.TabIndex = 1;
            this.supplyTabPage.Text = "Supply";
            this.supplyTabPage.UseVisualStyleBackColor = true;
            // 
            // supplyGrid
            // 
            this.supplyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.supplyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.supplyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyGrid.ContextMenuStrip = this.supplyMenuStrip;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplyGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.supplyGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplyGrid.Location = new System.Drawing.Point(0, 66);
            this.supplyGrid.Margin = new System.Windows.Forms.Padding(2);
            this.supplyGrid.Name = "supplyGrid";
            this.supplyGrid.RowHeadersVisible = false;
            this.supplyGrid.RowHeadersWidth = 51;
            this.supplyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supplyGrid.RowTemplate.Height = 24;
            this.supplyGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supplyGrid.Size = new System.Drawing.Size(654, 223);
            this.supplyGrid.TabIndex = 2;
            // 
            // supplyMenuStrip
            // 
            this.supplyMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.supplyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supplyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSupplyMenuItem,
            this.addSupplyMenuItem,
            this.editSupplyMenuItem,
            this.removeSupplyMenuItem});
            this.supplyMenuStrip.Name = "itemContextMenu";
            this.supplyMenuStrip.Size = new System.Drawing.Size(181, 114);
            this.supplyMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.supplyMenuStrip_Opening);
            // 
            // updateSupplyMenuItem
            // 
            this.updateSupplyMenuItem.Name = "updateSupplyMenuItem";
            this.updateSupplyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSupplyMenuItem.Text = "Обновить";
            this.updateSupplyMenuItem.Click += new System.EventHandler(this.updateSupplyMenuItem_Click);
            // 
            // addSupplyMenuItem
            // 
            this.addSupplyMenuItem.Name = "addSupplyMenuItem";
            this.addSupplyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSupplyMenuItem.Text = "Добавить";
            this.addSupplyMenuItem.Click += new System.EventHandler(this.addSupplyMenuItem_Click);
            // 
            // editSupplyMenuItem
            // 
            this.editSupplyMenuItem.Name = "editSupplyMenuItem";
            this.editSupplyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editSupplyMenuItem.Text = "Изменить";
            this.editSupplyMenuItem.Click += new System.EventHandler(this.editSupplyMenuItem_Click);
            // 
            // removeSupplyMenuItem
            // 
            this.removeSupplyMenuItem.Name = "removeSupplyMenuItem";
            this.removeSupplyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeSupplyMenuItem.Text = "Удалить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(680, 405);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.itemContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.itemTabPage.ResumeLayout(false);
            this.supplierTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).EndInit();
            this.supplierMenuStrip.ResumeLayout(false);
            this.supplyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplyGrid)).EndInit();
            this.supplyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem updateItem;
        private System.Windows.Forms.ToolStripMenuItem removeItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage supplyTabPage;
        private System.Windows.Forms.TabPage itemTabPage;
        private System.Windows.Forms.TabPage supplierTabPage;
        private System.Windows.Forms.DataGridView supplierDataGrid;
        private System.Windows.Forms.ContextMenuStrip supplierMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateSuppliersItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierItem;
        private System.Windows.Forms.ToolStripMenuItem editSupplierItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierItem;
        private System.Windows.Forms.DataGridView supplyGrid;
        private System.Windows.Forms.ContextMenuStrip supplyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateSupplyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSupplyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSupplyMenuItem;
    }
}

