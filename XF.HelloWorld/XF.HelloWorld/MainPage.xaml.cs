﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.HelloWorld
{
    public partial class MainPage : ContentPage
    {
        Entry entryTexto;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ClicarNomeBotao(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                DisplayAlert("Atenção"
                    , "Informe o seu nome na caixa de texto", "OK");
                entryTexto.Focus();
            }
            else
                DisplayAlert("Atenção"
                    , string.Format("Olá, {0}, seja bem-vindo", txtTexto.Text)
                    , "OK");

        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            //pushAsync -> vai pra frente empilhando
            Navigation.PushAsync(new HomePage());
        }

        void btnConfig_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigPage());
        }

        void btnConteudo_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CursoPage());
        }

        private void btnDataBinding_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindingPage());
        }
    }
}