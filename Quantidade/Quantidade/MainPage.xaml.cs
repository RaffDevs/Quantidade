using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quantidade
{
    public partial class MainPage : ContentPage
    {
        int quantity = 0;

        public MainPage()
        {
            InitializeComponent();
            LbQuantidade.Text = quantity.ToString();
            
        }

        private void Plus(object sender, EventArgs e)
        {
            quantity++;
            LbQuantidade.Text = quantity.ToString();
        }

        private void Minus(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                LbQuantidade.Text = quantity.ToString();
            }
            
        }
    }
}
