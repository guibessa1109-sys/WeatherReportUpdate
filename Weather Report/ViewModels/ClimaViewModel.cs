using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using Weather_Report.Models;

namespace Weather_Report.ViewModels
{
    public partial class ClimaViewModel:ObservableObject
    {
        [ObservableProperty]
        private string cidade;

        [ObservableProperty]
        private string estado;
        [ObservableProperty]
        private DateTime atualizado_em;

        [ObservableProperty]
        private List<Clima> clima;

        public ICommand getPrevisaoCommand { get; }

        public ClimaViewModel()
        {
            getPrevisaoCommand = new Command(getPrevisao);
            cidade = "Guarulhos";
        }

        public void getPrevisao()
        {
            Cidade = "São Paulo";
        }

    }
}
