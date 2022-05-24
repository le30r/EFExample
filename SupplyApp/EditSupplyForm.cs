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
    public partial class EditSupplyForm : Form
    {
        private int volume;
        private int itemId;
        private int supplierId;
        private DateTime date;
        public EditSupplyForm()
        {
            InitializeComponent();
        }

        public EditSupplyForm(DateTime date, int itemId, int supplierId, int volume) : this()
        {
            this.volume = volume;
            this.date = date;
            this.itemId = itemId;
            this.supplierId = supplierId;
        }

        public void FillFields()
        {
            supplyDatePicker.Value = date;
            supplyDatePicker.Enabled = false;

            supplierComboBox.SelectedValue = supplierId;
            supplierComboBox.Enabled = false;

            itemComboBox.SelectedValue = itemId;
            itemComboBox.Enabled = false;

            txtVolume.Text = volume.ToString();
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
                EditSupply();
            }
            this.Close();
        }

        // Метод для добавления нового товара
        private void EditSupply()
        {
            try
            {
                // Открываем соединение
                using (var db = new SupplyModel())
                {
                    var supply = db.Supply.SingleOrDefault(x=>(x.ItemID == itemId && x.SupplierID == supplierId && x.Date == date.Date));
                    supply.Volume = volume;
                    db.SaveChanges();
                   
                }
                MessageBox.Show("Данные изменены!", "Изменено", MessageBoxButtons.OK);
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

            FillFields();
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
