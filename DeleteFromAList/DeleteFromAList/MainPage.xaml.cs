using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeleteFromAList
{
    public partial class MainPage : ContentPage
    {
        public List<Item> allItems;
        ItemList items;

        public MainPage()
        {
            allItems = new List<Item>
            {
                new Item(){ItemName = "Rice", ItemDetails = "Rich in carbohydrates"},
                new Item(){ItemName = "Dal", ItemDetails = "Rich in protine"},
                new Item(){ItemName = "Milk", ItemDetails = "Rich in protine"},
            };
            InitializeComponent();
            items = new ItemList(allItems);
            lstItems.ItemsSource = items.Items;

        }


        public void DeleteClicked(object sender, EventArgs e)
        {
            var item = (Xamarin.Forms.Button)sender;
            Item listitem = (from itm in items.Items where itm.ItemName == item.CommandParameter.ToString() select itm).FirstOrDefault<Item>();
            items.Items.Remove(listitem);
        }

    }
}
