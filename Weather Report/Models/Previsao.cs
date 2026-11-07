using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_Report.Models
{
    public class Previsao
    {
        private string cidade;
        private string estado;
        private DateTime atualizacao;
        private List<Clima> Clima;
    }
}
