using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheresaFacts
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            TheresaFactData fact = (TheresaFactData)e.SelectedItem;
            DisplayAlert("That's the fact, Jack!",fact.TheFact, "Cool!");
            //Yes, this IS a reference to "Stripes" with Bill Murray.  Thought you might get a kick out of it xD.
        }
    }
}
