using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace SupplyApp
{
    public partial class AddSupplyForm : Form
    {
        private int volume;
        private int itemId;
        private int supplierId;
        public AddSupplyForm()
        {
            InitializeComponent();
        }
        
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        // Кнопка Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddSupply();
            }
            this.Close();
        }

        // Метод для добавления нового товара
        private void AddSupply()
        {
            try
            {
                // Открываем соединение
                using (var db = new SupplyModel())
                {
                    // Добавляем новую запись в таблицу
                    db.Supply.Add(new Supply
                    {
                        ItemID = itemId,
                        SupplierID = supplierId,
                        Volume = volume,
                        Date = supplyDatePicker.Value
                    });
                    // Сохраняем изменения
                    db.SaveChanges();
                }
                MessageBox.Show("Данные добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void AddSupplyForm_Load(object sender, EventArgs e)
        {
            
            supplierComboBox.DisplayMember = "Name";
            supplierComboBox.ValueMember = "ID";
            supplierComboBox.DataSource = GetSuppliers();
            
            itemComboBox.DisplayMember = "Name";
            itemComboBox.ValueMember = "ID";
            itemComboBox.DataSource = GetItems();
            supplyDatePicker.MaxDate = DateTime.Now;
        }

        private List<Supplier> GetSuppliers()
        {
            using (var db   = new SupplyModel())
            {
              
                return db.Supplier.ToList();
            }
        }

        private List<Item> GetItems()
        {
            using (var db = new SupplyModel())
            {
              
                return db.Item.ToList();
            }
        }

        private void txtVolume_Validating(object sender, CancelEventArgs e)
        {
            string input = txtVolume.Text.Trim();
            if (Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
            {
                errorProvider.SetError(txtVolume, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtVolume, "Ошибка!");
                e.Cancel = true;
            }
        }

       

        private void txtVolume_Validated(object sender, EventArgs e)
        {
            volume = Convert.ToInt32(txtVolume.Text.Trim());
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           supplierId = (Int32)supplierComboBox.SelectedValue;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemId = (Int32)itemComboBox.SelectedValue;
        }
    }
}
