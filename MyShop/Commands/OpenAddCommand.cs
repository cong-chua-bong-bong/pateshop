﻿using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Commands
{
    class OpenAddCommand : BaseCommand
    {
        private readonly ProductsViewModel _productsViewModel;

        public OpenAddCommand(ProductsViewModel productsViewModel)
        {
            _productsViewModel = productsViewModel;
        }

        public override async void Execute(object parameter)
        {
            _productsViewModel.AddProductVisibility = System.Windows.Visibility.Visible;
            _productsViewModel.CurView++;
        }
    }
}
