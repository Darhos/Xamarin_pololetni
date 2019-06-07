using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Collection
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewmodel = BindingContext as MainViewModel;

            var figurka = e.Item as Figurka;


            viewmodel?.SkrytNeboZobrazitFigurku(figurka);
        }

        private void Button_OnClick(object sender, ClickedEventArgs e)
        {
            string udaj_1 = nazev.Text;
            string udaj_2 = druh.Text;
            string udaj_3 = cislo.Text;
            string zaznam = udaj_1 + " " + udaj_2 + " " + udaj_3;     
        }
    }
}
