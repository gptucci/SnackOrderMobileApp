using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSnackOrder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPanino : ContentPage
    {
        public EditPanino()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(entryNomePanino.Text))
                return;



            App.ListaPanini.Add(entryNomePanino.Text);


            MainPage clsMainPage=new MainPage();

            App.Current.MainPage = clsMainPage;

        }
    }
}