using Autofac;
using BookStore.Application.Services;
using BookStore.Models;
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

namespace BookStore.User.Forms
{
    public partial class OneCategoryForm : Form
    {
        Autofac.IContainer container;
        IBookService bookService;
        int pageNum;
        int maxPageNum;
        string currentCategory;
        public OneCategoryForm(string selectedCategory)
        {
            container = AutoFag.RegisterBook();
            bookService = container.Resolve<IBookService>();

            InitializeComponent();

            currentCategory = selectedCategory;

            ShowBooks(bookService.GetByCategoryName(currentCategory));
            ShowButtons();
        }



        void ShowBooks(List<Book> books)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var book in books)
            {
                var bookControl = new BookControl();
                bookControl.BookName = book.Name;
                bookControl.BookPrice = book.Price.ToString() + " LE";
                bookControl.BookImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{book.BookImg}"));
                bookControl.Id = book.Id;
                flowLayoutPanel1.Controls.Add(bookControl);
            }
        }

        void ShowButtons()
        {
            if (maxPageNum == 1)
            {
                prevBtn.Visible = false;
                nextBtn.Visible = false;
            }
            else if (pageNum == 1)
            {
                prevBtn.Visible = false;
                nextBtn.Visible = true;
            }
            else if (pageNum == maxPageNum)
            {
                prevBtn.Visible = true;
                nextBtn.Visible = false;
            }
            else
            {
                prevBtn.Visible = true;
                nextBtn.Visible = true;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            ShowButtons();
            ShowBooks(bookService.GetByCategoryName(currentCategory));
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            ShowButtons();
            ShowBooks(bookService.GetByCategoryName(currentCategory));
        }

        private void OneCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}