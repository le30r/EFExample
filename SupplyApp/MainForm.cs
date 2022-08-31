using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyApp
{
    public partial class MainForm : Form
    {
        GridItem row;
        public MainForm()
        {
            InitializeComponent();
        }

        // Метод для получения списка товаров
        public IEnumerable GetItems()
        {
            using (var db = new SupplyModel())
            {
                var items = from item in db.Item
                            select new
                            {
                                item.ID,
                                item.Name,
                                item.Manufacturer,
                                item.Price
                            };
                return items.ToList();
            }
        }

        public IEnumerable GetSuppliers()
        {
            using (var db = new SupplyModel())
            {
                var suppliers = from supplier in db.Supplier
                                select new
                                {
                                    supplier.ID,
                                    supplier.Name,
                                    supplier.Address,
                                    supplier.Phone
                                };
                return suppliers.ToList();
            }
        }

        // Заполнение таблицы с товарами
        private void SetItemGrid()
        {            
            itemGrid.DataSource = GetItems();
            itemGrid.Columns[0].HeaderText = "Артикул";
            itemGrid.Columns[1].HeaderText = "Наименование";
            itemGrid.Columns[2].HeaderText = "Производитель";
            itemGrid.Columns[3].HeaderText = "Стоимость";
        }

        private void SetSupplierGrid()
        {
            supplierDataGrid.DataSource = GetSuppliers();
            supplierDataGrid.Columns[0].HeaderText = "Код поставщика";
            supplierDataGrid.Columns[1].HeaderText = "Название";
            supplierDataGrid.Columns[2].HeaderText = "Адрес";
            supplierDataGrid.Columns[3].HeaderText = "Телефон";
        }

        private void SetSupplyGrid()
        {
            supplyGrid.DataSource = GetSupplies();
            supplyGrid.Columns[0].HeaderText = "Дата поставки";
            supplyGrid.Columns[1].HeaderText = "Поставщик";
            supplyGrid.Columns[2].HeaderText = "Артикул";
            supplyGrid.Columns[3].HeaderText = "Наименование";
            supplyGrid.Columns[4].HeaderText = "Объем";
            supplyGrid.Columns[5].HeaderText = "Суммарная стоимость";


        }


        // Обновляем данные в таблице при загрузке формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetItemGrid();
            SetSupplierGrid();
            SetSupplyGrid();
        }

        // Обновляем данные в таблице при нажатии кнопки Обновить
        private void refreshItem_Click(object sender, EventArgs e)
        {
            SetItemGrid();
        }

        // Добавление нового товара при нажатии кнопки Добавить
        private void addItem_Click(object sender, EventArgs e)
        {
            // Добавление происходит на форме AddItemForm
            AddItemForm add = new AddItemForm();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                SetItemGrid();
            }
        }

        //Удаляем данные о товаре нажатием кнопки Удалить
        private void removeItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (itemGrid.SelectedCells.Count > 0)
                {
                    var i = itemGrid.SelectedCells[0].OwningRow.Index;
                    int itemId = (int)itemGrid[0, i].Value;
                    // Открываем соединение
                    using (var db = new SupplyModel())
                    {
                        Item item = db.Item.Where(x => x.ID == itemId).First();
                        db.Item.Remove(item);
                        // Обязательно сохраняем изменения в БД
                        db.SaveChanges();
                    }
                }
            }
            SetItemGrid();
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
      
            if (itemGrid.SelectedCells.Count > 0)
            {
                var i = itemGrid.SelectedCells[0].OwningRow.Index;
                EditItemForm edit = new EditItemForm((int)itemGrid[0, i].Value, (string)itemGrid[1, i].Value, (string)itemGrid[2, i].Value, (decimal)itemGrid[3, i].Value);
                if (edit.ShowDialog(this) == DialogResult.OK)
                {
                 
                }   
            }
            SetItemGrid();
        }

        private void updateSuppliersItem_Click(object sender, EventArgs e)
        {
            SetSupplierGrid();
        }

        private void addSupplierItem_Click(object sender, EventArgs e)
        {
            AddSupplierForm add = new AddSupplierForm();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                SetSupplierGrid();   
            }
        }

        private void supplierMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editSupplierItem_Click(object sender, EventArgs e)
        {

            if (supplierDataGrid.SelectedCells.Count > 0)
            {
                var i = supplierDataGrid.SelectedCells[0].OwningRow.Index;
                EditSupplierForm edit = new EditSupplierForm((int)supplierDataGrid[0, i].Value, (string)supplierDataGrid[1, i].Value, (string)supplierDataGrid[2, i].Value, (string)supplierDataGrid[3, i].Value);
                if (edit.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
            SetSupplierGrid();
        }

        private void deleteSupplierItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (supplierDataGrid.SelectedCells.Count > 0)
                {
                    var i = supplierDataGrid.SelectedCells[0].OwningRow.Index;
                    int supplierId = (int)supplierDataGrid[0, i].Value;
                    // Открываем соединение
                    using (var db = new SupplyModel())
                    {
                        Supplier supplier = db.Supplier.Where(x => x.ID == supplierId).First();
                        db.Supplier.Remove(supplier);
                        // Обязательно сохраняем изменения в БД
                        db.SaveChanges();
                    }
                }
            }
            SetSupplierGrid();
        }


        public IEnumerable GetSupplies()
        {
            using (var db = new SupplyModel())
            {
                var supplies = from supply in db.Supply
                               select new
                               {
                                   supply.Date,
                                   Supplier = supply.Supplier.Name,
                                   supply.ItemID,
                                   Item = supply.Item.Name,
                                   supply.Volume,
                                   Overall = supply.Volume * supply.Item.Price
                               };
                return supplies.ToList();
            }
        }

        private void updateSupplyMenuItem_Click(object sender, EventArgs e)
        {
            SetSupplyGrid();
        }

        private void supplyMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addSupplyMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplyForm add = new AddSupplyForm();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                SetSupplyGrid();
            }
        }

        private void editSupplyMenuItem_Click(object sender, EventArgs e)
        {
            if (supplyGrid.SelectedCells.Count > 0)
            {
                var i = supplyGrid.SelectedCells[0].OwningRow.Index;
                var name = supplyGrid[1, i].Value;
                int supplierId;
                using (var db = new SupplyModel())
                {
                    supplierId = db.Supplier.Where(s => s.Name == name).FirstOrDefault().ID;
                }
                    
                EditSupplyForm edit = new EditSupplyForm((DateTime)supplyGrid[0, i].Value, (int)supplyGrid[2, i].Value, supplierId, (int)supplyGrid[4, i].Value);
                if (edit.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
            SetSupplyGrid();
        }

        private void removeSupplyMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент?",
               "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (supplyGrid.SelectedCells.Count > 0)
                {
                    var i = supplyGrid.SelectedCells[0].OwningRow.Index;
                    DateTime date = (DateTime)supplyGrid[0, i].Value;
                    int itemId = (int)supplyGrid[2, i].Value;
                    string supplierName = (string)supplyGrid[1, i].Value;
                    int supplierId;
                    // Открываем соединение
                    using (var db = new SupplyModel())
                    {

                        supplierId = db.Supplier.Where(s => s.Name == supplierName).FirstOrDefault().ID;
                        Supply supplyToDelete = db.Supply.SingleOrDefault(x => (x.ItemID == itemId && x.SupplierID == supplierId && x.Date == date.Date));
                        db.Supply.Remove(supplyToDelete);
                        // Обязательно сохраняем изменения в БД
                        db.SaveChanges();
                    }
                }
            }
            SetSupplyGrid();
        }

        
    }
}
