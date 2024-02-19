﻿using BookStore.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Presentation.AutoFag;
using Autofac;
using BookStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.Admin.Forms
{
    public partial class CategoriesForm : Form
    {
        Autofac.IContainer connectionCategory;
        ICategoryService CategoryService;
        public CategoriesForm()
        {
            InitializeComponent();
            connectionCategory = AutoFag.RegisterCategory();
            CategoryService = connectionCategory.Resolve<ICategoryService>();
            dataGridView1.DataSource = CategoryService.GetAllCategories();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            category.Name =textBox1.Text;
            CategoryService.AddCategory(category);
            dataGridView1.DataSource = CategoryService.GetAllCategories();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name=textBox1.Text;
            category.Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            CategoryService.UpdateCategory(category);
            dataGridView1.DataSource = CategoryService.GetAllCategories();

        }

        private void getOne_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            textBox1.Text = row.Cells[1].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            CategoryService.DeleteCategory(Id);
            dataGridView1.DataSource = CategoryService.GetAllCategories();
        }
    }
}
