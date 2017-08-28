using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kiddypi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentViewPage : ContentPage
    {
        public StudentViewPage()
        {
            InitializeComponent();
        }

        //private async void button_clicked(object sender, eventargs e)
        //{
        //    var nextpage = new videoviewmodel();
        //    await this.navigation.pushasync(nextpage);
        //}
    }
}