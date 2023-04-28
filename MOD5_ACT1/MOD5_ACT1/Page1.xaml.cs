using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOD5_ACT1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void startDate_DateSelected(object sender, EventArgs e)
        {
            TimeSpan timeSpan = endDate.Date - startDate.Date;
            label.Text = $"Total day/s: {timeSpan.Days}";
        }
    }
}