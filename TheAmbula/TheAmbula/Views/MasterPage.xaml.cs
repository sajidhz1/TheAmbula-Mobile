using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheAmbula.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "reminders.png",
                TargetType = typeof(AboutPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "slideout.png",
                TargetType = typeof(NewItemPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Items",
                IconSource = "reminders.png",
                TargetType = typeof(ItemsPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}