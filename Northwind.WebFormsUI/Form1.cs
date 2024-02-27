using Northwind.Business.Concrete;
using Northwind.Business;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.ninject;
using Northwind.DataAccess.Concrete.EntityFreamework;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductServices _productService;
        ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductServices>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
        }
		void ListProducts()
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				dgwProduct.DataSource = context.Products.ToList();
				cbxCategory.DisplayMember = "CategoryName";
				cbxCategory.ValueMember = "CategoryId";
			}
		}
		private void ListProductsByProductName(string key)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				//datagridwiev'e ProductName'in verileri listeleniyor
				dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
			}
		}

		private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GettAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GettAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";


            cbxCategoryIdUpdate.DataSource = _categoryService.GettAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetByProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)
                });
                LoadProduct();
                MessageBox.Show("Ürün Kaydedildi!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    QuantityPerUnit = TbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitsinStockUpdate.Text)
                });

                LoadProduct();
                MessageBox.Show("Ürün Güncellendi!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            TbxQuantityPerUnitUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitsinStockUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProduct();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



        }

		private void tbxProduct_TextChanged(object sender, EventArgs e)
		{
			//Key'in icine tbxSearch.Text'attık
			string key = tbxProduct.Text;
			//Eğer Key'in ici bos veya NULL'ise 
			if (string.IsNullOrEmpty(key))
			{
				//ListProducts Methodunu calıstır.
				ListProducts();
			}
			else
			{
				//ListProductsByProductName methodu cagrılıyor ve icine deger atılıyor
				ListProductsByProductName(tbxProduct.Text);
			}
		}
	}
}
