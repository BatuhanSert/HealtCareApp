using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HealtCareApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Products = GetProducts();
            MenuList = GetMenus();
        }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }


        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        public void ShowDetails()
        {
            var page = new DetailsPage() { BindingContext = new DetailsViewModel { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon = "order.png", Name = "My Order"},
                new Menu { Icon = "favorite.png", Name = "My WishList"},
                new Menu { Icon = "shopping.png", Name = "Shopping Cart"},
                new Menu { Icon = "settings.png", Name = "Settings"}
            };
        }

        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new Product { Name = "Orhan Gencebay", Price = 249.99f, Image = "dio2.png", Model = "Yarabbim", Rating = 4.5, Views = 4.5, Description = "Yarabbim, Orhan Gencebay'ın 1979'da Kervan Plakçılık'tan çıkan albümüdür. Albümde 11 şarkı bulunmaktadır."},
                new Product { Name = "AC-DC", Price = 349.99f, Image = "dio2.png", Model = "Back in Black", Rating = 4.5, Views = 4.5, Description = "Back in Black, Avustralyalı hard rock grubu AC/DC'nin 25 Temmuz 1980 tarihinde piyasaya sürdüğü 7. stüdyo albümüdür. Eski vokalist Bon Scott'un 19 Şubat 1980 tarihinde ölmesinin ardından grubun yayımladığı ilk albümdür."},
                new Product { Name = "Dio", Price = 899.99f, Image = "dio2.png", Model = "Holly Diver", Rating = 4.5, Views = 4.5, Description = "Holy Diver, 1983 yılında piyasaya sürülen Amerikan heavy metal grubu Dio'nun ilk stüdyo albümüdür. Vokalist Ronnie James Dio, davulcusu Vinny Appice ile birlikte kendi grubunu bir araya getirmek için yanına aldığı Black Sabbath'ta ilk görevini bitirmişti."},
                new Product { Name = "Rammstein", Price = 189.99f, Image = "dio2.png", Model = "Rosenrot", Rating = 4.5, Views = 4.5, Description = "Rosenrot, Rammstein adlı Alman metal grubunun çıkardığı beşinci albümdür."},
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }
        public double Views { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }

    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }

}
