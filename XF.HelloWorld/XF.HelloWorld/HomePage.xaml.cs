﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            Button goBackButton = new Button()
            {
                Text = "<- Voltar",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            goBackButton.Clicked += async (sender, args) =>
            {
                //Não elimina da fila, mas volta para o elemento que já esta na fila ao inves 
                // de criar mais um
                await Navigation.PopAsync();
            };

            this.rootLayout.Children.Add(goBackButton);
        }

        //event handler
        void OnAlterarIntensidadeSlider(Object sender, EventArgs e)
        {
            var vermelho = sliderVermelho.Value;
            var verde = sliderVerde.Value;
            var azul = sliderAzul.Value;

            boxviewCor.Color = Color.FromRgb(vermelho, verde, azul);
        }
    }
}