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

        // Заполнение таблицы с товарами
        private void SetItemGrid()
        {            
            itemGrid.DataSource = GetItems();
            itemGrid.Columns[0].HeaderText = "Артикул";
            itemGrid.Columns[1].HeaderText = "Наименование";
            itemGrid.Columns[2].HeaderText = "Производитель";
            itemGrid.Columns[3].HeaderText = "Стоимость";
        }

        // Обновляем данные в таблице при загрузке формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetItemGrid();
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

        private void itemContextMenu_Opened(object sender, EventArgs e)
        {
          
        }
    }
}
