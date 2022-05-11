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

namespace SupplyApp
{
    public partial class EditItemForm : Form
    {
        private int id;
        private string name;
        private string manufacturer;
        private decimal price;
        public EditItemForm()
        {
            InitializeComponent();
        }

        public EditItemForm(int id, string name, string manufacturer, decimal price)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;

            FillFields();
        }

        private void FillFields()
        {
            txtId.Text = id.ToString();
            txtName.Text = name;
            txtManufacturer.Text = manufacturer;
            txtPrice.Text = price.ToString();
        }

        // Можно вводить только целые числа
        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            string input = txtId.Text.Trim();
            if (Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
            {
                errorProvider.SetError(txtId, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtId, "Ошибка!");
                e.Cancel = true;
            }
        }

        // Непустая строка
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtName.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(txtName, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, String.Empty);
                e.Cancel = false;
            }
        }

        // Непустая строка
        private void txtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            string input = txtManufacturer.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(txtManufacturer, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtManufacturer, String.Empty);
                e.Cancel = false;
            }
        }

        // Вещественное число с разделителем ,
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string input = txtPrice.Text.Trim();
            if (Regex.IsMatch(input, @"^(([0-9]*[,])?[0-9]+)$"))
            {
                errorProvider.SetError(txtPrice, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtPrice, "Ошибка!");
                e.Cancel = true;
            }
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text.Trim());
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
        }

        private void txtManufacturer_Validated(object sender, EventArgs e)
        {
            manufacturer = txtManufacturer.Text.Trim();
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            price = Convert.ToDecimal(txtPrice.Text.Trim());
        }

        // Кнопка Отмена
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
                EditItem();
            }
            this.Close();
        }

        // Метод для добавления нового товара
        private void EditItem()
        {
            try
            {
                // Открываем соединение
                using (var db = new SupplyModel())
                {
                    var result = db.Item.SingleOrDefault(i => i.ID == id);
                    if (result != null)
                    {
                        result.Name = name;
                        result.Manufacturer = manufacturer;
                        result.Price = price;
                    }

                    db.SaveChanges();
                }
                MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
