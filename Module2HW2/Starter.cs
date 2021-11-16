using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2
{
    public class Starter
    {
        private ConfigService _configService;
        private User _user;
        private Actions _action;
        private Cart _cart;

        public Starter()
        {
            _user = new User { Name = "Ar Tom", Phone = "+3800501234567", Email = "Ar.Tom@gmail.com", Currency = Currency.UAH, SendEMail = true, SendSms = true };
            _configService = new ConfigService();
            _configService.Init(_user.Currency);
            _action = new Actions(_user, _configService);
            _cart = Cart.Instance;
        }

        public void Run()
        {
            _action.GetListDevices();

            _action.AddIntoCart(1);
            _action.AddIntoCart(3);
            _action.AddIntoCart(7);

            _action.DisplayCart();

            _action.Checkout();
        }
    }
}