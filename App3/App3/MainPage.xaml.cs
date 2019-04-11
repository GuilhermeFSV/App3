using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;
            Label4.IsVisible = false;
            // verificar se período e semestre foram selecionados
            if (Entry2.Text != null &&
                Entry2.Text.Length > 0 &&
                Entry1.Text != null &&
                Entry1.Text.Length > 0 &&
                Picker.SelectedIndex >= 0 &&
                Picker2.SelectedIndex >= 0)
            {
                // criar variáveis 
                int professor = Picker2.SelectedIndex + 1;
                int disciplina = Picker.SelectedIndex + 1;
                int nota = int.Parse(Entry2.Text);
                // verificar se os valores são iguais
                if (professor == disciplina)
                {
                    // habilitar mensagem de ok
                    Label1.IsVisible = true;

                    if (nota>=6)
                    {
                        Label3.IsVisible = true;
                    }
                    else
                    {
                        Label4.IsVisible = true;
                    }
                }
                else
                {
                    // habilitar mensagem de erro
                    Label2.IsVisible = true;
                }
            }
            else
            {
                // habilitar mensagem de erro
                Label2.IsVisible = true;
            }

        }
    }
}
