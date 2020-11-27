using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto.Classi
{
    class Volo
    {
        public DateTime DataOraPartenza { get; set; }
        public DateTime DataOraArrivo { get; set; }
        public string Codice { get; set; }
        // Associazione delle classi -> ho associato la classe Aereo e la classe Aereoporto alla classe Volo
        public Aereo AereoVolo { get; set; }
        public Aereoporto AereoportoVolo { get; set; }
        public int Durata {get;}
        public double GatePartenza { get; set; }

        public Volo(DateTime DataOraPartenza, DateTime DataOraArrivo, string Codice, Aereo AereoVolo, Aereoporto AereoportoVolo, double GatePartenza) 
        {
            this.DataOraPartenza = DataOraPartenza;
            this.DataOraArrivo = DataOraArrivo;
            this.Codice = Codice;
            this.AereoVolo = AereoVolo;
            this.AereoportoVolo = AereoportoVolo;
            this.GatePartenza = GatePartenza;
            // Calcolo la durata del volo in base a data e ora di partenza e arrivo
            TimeSpan ts = this.DataOraArrivo - this.DataOraPartenza;
            this.Durata = Convert.ToInt32(ts.TotalMinutes);
        }

    }
}
