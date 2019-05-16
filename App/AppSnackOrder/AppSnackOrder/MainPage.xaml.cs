using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSnackOrder
{
    //// Learn more about making custom code visible in the Xamarin.Forms previewer
    //// by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lstListaPanini.ItemsSource = App.ListaPanini;
        }

        private void CmdAggiungiPanino_Clicked(object sender, EventArgs e)
        {
            EditPanino clsEditPanino = new EditPanino();

            App.Current.MainPage = clsEditPanino;
        }
    }
}
