using System;

using Xamarin.Forms;

namespace demoAppCenter
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Super Bock",
                Description = "This is an item description.",
                Brewing = "",
                Flavor = "#Light",
                Rating = 2,
                Style = "Pilsen"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
