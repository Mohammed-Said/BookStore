using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.User.Forms
{
  public partial class BookControl : UserControl
  {
    public string BookName { get => label1.Text; set => label1.Text = value; }
    public string BookPrice { get => label2.Text; set => label2.Text = value; }

    public Image BookImage { get => pictureBox1?.BackgroundImage; set => pictureBox1.BackgroundImage = value; }

    public BookControl()
    {
      InitializeComponent();
      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
      button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
  }
}
