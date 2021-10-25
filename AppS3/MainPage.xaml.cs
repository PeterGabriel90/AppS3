using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;
            if ((usuario == "estudiante2021") && (contraseña == "uisrael2021"))
            {
                await Navigation.PushAsync(new Vista2(usuario, contraseña));

            }
            else
            {
                lblMensaje.Text = "El usuario o password son incorrectos";
            }
        }
    }
}
