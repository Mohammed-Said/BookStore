﻿using BookStore.User.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.User.Forms
{
  public partial class BooksForm : Form
  {
    List<BookControl> books = new();

    public BooksForm()
    {
      InitializeComponent();
      for (int i = 0; i < 8; i++)
      {
        var book = new BookControl();
        book.BookName = "BookTitle";
        book.BookPrice = "Price $";
        book.BookImage = Image.FromFile(@"C:\Users\Mohamed\Desktop\User\User\bin\Images\book2.jpg");
        //Bitmap b = new Bitmap(book.BookImage);
        //book.BookImage = ResizeImage(b, new Size(600, 450));
        books.Add(book);
      }
      foreach (var book in books)
        flowLayoutPanel1.Controls.Add(book);

    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    //private static Image ResizeImage(Image imgToResize, Size size)
    //{
    //  // Get the image current width
    //  int sourceWidth = imgToResize.Width;
    //  // Get the image current height
    //  int sourceHeight = imgToResize.Height;
    //  float nPercent = 0;
    //  float nPercentW = 0;
    //  float nPercentH = 0;
    //  // Calculate width and height with new desired size
    //  nPercentW = ((float)size.Width / (float)sourceWidth);
    //  nPercentH = ((float)size.Height / (float)sourceHeight);
    //  nPercent = Math.Min(nPercentW, nPercentH);
    //  // New Width and Height
    //  int destWidth = (int)(sourceWidth * nPercent);
    //  int destHeight = (int)(sourceHeight * nPercent);
    //  Bitmap b = new Bitmap(destWidth, destHeight);
    //  Graphics g = Graphics.FromImage((Image)b);
    //  g.InterpolationMode = InterpolationMode.HighQualityBicubic;
    //  // Draw image with new width and height
    //  g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
    //  g.Dispose();
    //  return (Image)b;
    //}

  }


}