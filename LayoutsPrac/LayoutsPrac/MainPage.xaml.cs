using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsPrac
{
    public partial class MainPage : ContentPage
    {
        public double count;
        
        public MainPage()
        {
            InitializeComponent();
            count = 0.03;
        }

        private void U_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X;
            double y = c.Y - count;
            if (y < 0)
            {
                U.IsEnabled = false;
                y = 0;
            }
            else
            {
                D.IsEnabled = true;               
            }
            AbsoluteLayout.SetLayoutBounds(circle,
                         new Rectangle(x, y,
                             AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void D_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X;
            double y = c.Y + count;
            if (y > 1)
            {
                D.IsEnabled = false;
                y = 1;
            }
            else
            {
                U.IsEnabled = true;                
            }
            AbsoluteLayout.SetLayoutBounds(circle,
                        new Rectangle(x, y,
                            AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void R_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X + count;
            double y = c.Y;
            if (x > 1)
            {
                R.IsEnabled = false;
                x = 1;
            }
            else
            {
                L.IsEnabled = true;
            }
            AbsoluteLayout.SetLayoutBounds(circle,
                         new Rectangle(x, y,
                             AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void L_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X - count;
            double y = c.Y;
            if (x < 0)
            {
                L.IsEnabled = false;
                x = 0;
            }
            else
            {
                R.IsEnabled = true;
            }
            AbsoluteLayout.SetLayoutBounds(circle,
                         new Rectangle(x, y,
                             AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }
    }
}
