using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcinKrupnikLab3Zadanie.Models;
using MarcinKrupnikLab3Zadanie.Repositories;

namespace MarcinKrupnikLab3Zadanie
{
    public partial class FormMain : Form
    {
        private readonly IClothesMagazineGeneric<AddClothe> _clothes;
        private readonly IClothesMagazineGeneric<Brand> _brands;
        private readonly IClothesMagazineGeneric<AddShoes> _shoes;
        private readonly IClothesMagazineGeneric<BrandShoes> _brandsShoe;
        public FormMain()
        {
            InitializeComponent();
            _clothes = new ClothesMagazineGeneric<AddClothe>();
            _brands = new ClothesMagazineGeneric<Brand>();
            _shoes = new ClothesMagazineGeneric<AddShoes>();
            _brandsShoe = new ClothesMagazineGeneric<BrandShoes>();
            LoadClothes();
            LoadBrands();
            LoadShoes();
            LoadBrandsShoe();
        }
        private void LoadClothes()
        {
            dataGridViewClothes.DataSource = _clothes.GetAll();
        }
        private void LoadBrands()
        {
            dataGridViewBrands.DataSource = _brands.GetAll();
        }
        private void LoadShoes()
        {
            dataGridViewShoes.DataSource = _shoes.GetAll();
        }
        private void LoadBrandsShoe()
        {
            dataGridViewBrandsShoe.DataSource = _brandsShoe.GetAll();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addClotheClothe = textBoxClothe.Text;
            var addClothePrice = textBoxPrice.Text;
            var addClotheDate = dateTimePickerDate.Text;
            var brandId = textBoxBrandId.Text;

            AddClothe newClothe = new AddClothe
            {
                Clothe = addClotheClothe,
                Price = Int32.Parse(addClothePrice),
                Date = Convert.ToDateTime(addClotheDate),
                BrandId = Int32.Parse(brandId)
            };

            _clothes.Create(newClothe);
            _clothes.Save();

            LoadClothes();
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            var brandBrandName = textBoxBrandName.Text;
            var brandCountry = textBoxCountry.Text;

            Brand brand = new Brand
            {
                BrandName = brandBrandName,
                Country = brandCountry
            };
            _brands.Create(brand);
            _brands.Save();

            LoadBrands();
        }

        private void buttonDeleteClothe_Click(object sender, EventArgs e)
        {
            var selectedClotheIndex = Int32.Parse(dataGridViewClothes.SelectedRows[0].Cells[0].Value.ToString());
            

            _clothes.DeleteById(selectedClotheIndex);
            _clothes.Save();
            LoadClothes();
        }

        private void buttonEditClothe_Click(object sender, EventArgs e)
        {
            var selectedClotheIndex = Int32.Parse(dataGridViewClothes.SelectedRows[0].Cells[0].Value.ToString());
          

            _clothes.DeleteById(selectedClotheIndex);
            _clothes.Save();
            LoadClothes();
            var addClotheClothe = textBoxClothe.Text;
            var addClothePrice = textBoxPrice.Text;
            var addClotheDate = dateTimePickerDate.Text;
            var brandId = textBoxBrandId.Text;

            AddClothe newClothe = new AddClothe
            {
                Clothe = addClotheClothe,
                Price = Int32.Parse(addClothePrice),
                Date = Convert.ToDateTime(addClotheDate),
                BrandId = Int32.Parse(brandId)
            };

            _clothes.Create(newClothe);
            _clothes.Save();
            LoadClothes();
        }

        private void buttonBrandShow_Click(object sender, EventArgs e)
        {
            var selectedClotheIndex = Int32.Parse(dataGridViewClothes.SelectedRows[0].Cells[0].Value.ToString());
            var ShowClothe = _clothes.GetById(selectedClotheIndex);

            ShowClothe.Brand = _brands.GetById(ShowClothe.BrandId);
            MessageBox.Show("Brand: " + ShowClothe.Brand.BrandName);
        }

        private void buttonDeleteBrand_Click(object sender, EventArgs e)
        {
            var selectedBrandIndex = Int32.Parse(dataGridViewBrands.SelectedRows[0].Cells[0].Value.ToString());
            

            _brands.DeleteById(selectedBrandIndex);
            _brands.Save();
            LoadBrands();
        }

        private void buttonEditBrand_Click(object sender, EventArgs e)
        {
            var selectedBrandIndex = Int32.Parse(dataGridViewBrands.SelectedRows[0].Cells[0].Value.ToString());


            _brands.DeleteById(selectedBrandIndex);
            _brands.Save();
            LoadBrands();
            var brandBrandName = textBoxBrandName.Text;
            var brandCountry = textBoxCountry.Text;

            Brand brand = new Brand
            {
                BrandName = brandBrandName,
                Country = brandCountry
            };
            _brands.Create(brand);
            _brands.Save();

            LoadBrands();
        }

        private void buttonAddShoe_Click(object sender, EventArgs e)
        {
            var addShoeShoe = textBoxShoe.Text;
            var addShoePrice = textBoxPriceShoe.Text;
            var addShoeDate = dateTimePickerDateShoe.Text;
            var brandShoeId = textBoxBrandShoeId.Text;

            AddShoes newShoe = new AddShoes
            {
                Shoe = addShoeShoe,
                Price = Int32.Parse(addShoePrice),
                Date = Convert.ToDateTime(addShoeDate),
                BrandId = Int32.Parse(brandShoeId)
            };

            _shoes.Create(newShoe);
            _shoes.Save();

            LoadShoes();
        }

        private void buttonAddBrandShoe_Click(object sender, EventArgs e)
        {
            var brandBrandShoeName = textBoxBrandShoeName.Text;
            var brandCountryShoe = textBoxCountryShoe.Text;

            BrandShoes brandShoe = new BrandShoes
            {
                BrandName = brandBrandShoeName,
                Country = brandCountryShoe
            };
            _brandsShoe.Create(brandShoe);
            _brandsShoe.Save();

            LoadBrandsShoe();
        }

        private void buttonDeleteShoe_Click(object sender, EventArgs e)
        {
            var selectedShoeIndex = Int32.Parse(dataGridViewShoes.SelectedRows[0].Cells[0].Value.ToString());


            _shoes.DeleteById(selectedShoeIndex);
            _shoes.Save();
            LoadShoes();
        }

        private void buttonShoe_Click(object sender, EventArgs e)
        {
            var addShoeShoe = textBoxShoe.Text;
            var addShoePrice = textBoxPriceShoe.Text;
            var addShoeDate = dateTimePickerDateShoe.Text;
            var brandShoeId = textBoxBrandShoeId.Text;

            AddShoes newShoe = new AddShoes
            {
                Shoe = addShoeShoe,
                Price = Int32.Parse(addShoePrice),
                Date = Convert.ToDateTime(addShoeDate),
                BrandId = Int32.Parse(brandShoeId)
            };

            _shoes.Create(newShoe);
            _shoes.Save();

            LoadShoes();
            var selectedShoeIndex = Int32.Parse(dataGridViewShoes.SelectedRows[0].Cells[0].Value.ToString());


            _shoes.DeleteById(selectedShoeIndex);
            _shoes.Save();
            LoadShoes();
        }

        private void buttonBrandShoeShow_Click(object sender, EventArgs e)
        {
           
            var selectedShoeIndex = Int32.Parse(dataGridViewShoes.SelectedRows[0].Cells[0].Value.ToString());
            var ShowShoe = _shoes.GetById(selectedShoeIndex);

            ShowShoe.Brand = _brandsShoe.GetById(ShowShoe.BrandId);
            MessageBox.Show("Brand: " + ShowShoe.Brand.BrandName);
        }

        private void buttonDeleteBrandShoe_Click(object sender, EventArgs e)
        {
            var selectedBrandShoeIndex = Int32.Parse(dataGridViewBrandsShoe.SelectedRows[0].Cells[0].Value.ToString());


            _brandsShoe.DeleteById(selectedBrandShoeIndex);
            _brandsShoe.Save();
            LoadBrandsShoe();
        }

        private void buttonEditBrandShoe_Click(object sender, EventArgs e)
        {
            var selectedBrandShoeIndex = Int32.Parse(dataGridViewBrandsShoe.SelectedRows[0].Cells[0].Value.ToString());


            _brandsShoe.DeleteById(selectedBrandShoeIndex);
            _brandsShoe.Save();
            LoadBrandsShoe();
            var brandBrandShoeName = textBoxBrandShoeName.Text;
            var brandCountryShoe = textBoxCountryShoe.Text;

            BrandShoes brandShoe = new BrandShoes
            {
                BrandName = brandBrandShoeName,
                Country = brandCountryShoe
            };
            _brandsShoe.Create(brandShoe);
            _brandsShoe.Save();

            LoadBrandsShoe();
        }

        private void buttonAmount_Click(object sender, EventArgs e)
        {
            var count = _clothes.GetAll().Count();
            MessageBox.Show("Clothes: " + count);
        }

        private void buttonAmountShoe_Click(object sender, EventArgs e)
        {
            var count = _shoes.GetAll().Count();
            MessageBox.Show("Shoes: " + count);
        }
    }
}
