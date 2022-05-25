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
    public partial class EditSupplierForm : Form
    {
        private int id;
        private string name;
        private string address;
        private string phone;
        public EditSupplierForm()
        {
            InitializeComponent();
        }


        public EditSupplierForm(int id, string name, string address, string phone) : this()
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            
        }
        // Можно вводить только целые числа
        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            string input = txtId.Text.Trim();
            
            if ( Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
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
                EditSupplier();
            }
            this.Close();
        }

        // Метод для добавления нового товара
        private void EditSupplier()
        {
            try
            {
                // Открываем соединение
                using (var db = new SupplyModel())
                {
                    var supplier = db.Supplier.SingleOrDefault(s=> s.ID == id);
                    supplier.Name = name;
                    supplier.Address = address;
                    supplier.Phone = phone;
                    // Сохраняем изменения
                    db.SaveChanges();
                }
                MessageBox.Show("Данные изменены", "Изменено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            var input = txtPhone;
            if (!txtPhone.MaskCompleted)
            {
                errorProvider.SetError(txtPhone, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            phone = Regex.Replace(txtPhone.Text, @"[^\d]+", "");
        }

        private void EditSupplierForm_Load(object sender, EventArgs e)
        {
            FillFields();
        }

        private void FillFields()
        {
            txtId.Text = id.ToString();
            txtId.Enabled = false;
            txtName.Text = name.ToString();
            txtAddress.Text = address.ToString();
            txtPhone.Text = phone.ToString();
        }
    }
}

