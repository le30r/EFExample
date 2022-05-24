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
    public partial class AddSupplierForm : Form
    {
        private int id;
        private string name;
        private string address;
        private string phone;
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        // Можно вводить только целые числа
        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            string input = txtId.Text.Trim();
            
            if ( Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
            {
                int id;
                int.TryParse(input, out id);
                bool isNotUnique;
                using (var db = new SupplyModel())
                {
                    isNotUnique = db.Supplier.Where(x => x.ID == id).Count() > 0;
                }
                if (!isNotUnique) {
                    errorProvider.SetError(txtId, String.Empty);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(txtId, "Ошибка!");
                    e.Cancel = true;
                }
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
            string input = txtAddress.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(txtAddress, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddress, String.Empty);
                e.Cancel = false;
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
            address = txtAddress.Text.Trim();
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
                AddSupplier();
            }
            this.Close();
        }

        // Метод для добавления нового товара
        private void AddSupplier()
        {
            try
            {
                // Открываем соединение
                using (var db = new SupplyModel())
                {
                    db.Supplier.Add(new Supplier {
                        ID = id,
                        Name = name,
                        Address = address,
                        Phone = phone
                    }); ;
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            var input = txtPhone;
            if (!txtPhone.MaskCompleted)
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

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            phone = Regex.Replace(txtPhone.Text, @"[^\d]+", "");
        }
    }
}

