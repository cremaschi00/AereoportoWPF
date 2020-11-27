using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Aeroporto.Classi;

namespace AeroportoWPF
{
    
    /// <summary>
    /// Logica di interazione per Statistiche.xaml
    /// </summary>
    public partial class Statistiche : Window
    {
        List<Volo> MieiVoli;
        List<Aereo> MieiAerei;
        List<Persona> MiePersone;
        List<Aereoporto> MieiAereoporti;
        List<Biglietto> MieiBiglietti;
        public Statistiche(List<Aereo> AereiPassati, List<Persona> PersonePassate, List<Aereoporto> AereoportiPassati, List<Volo> VoliPassati, List<Biglietto> BigliettiPassati)
        {
            MieiAerei = AereiPassati;
            MiePersone = PersonePassate;
            MieiAereoporti = AereoportiPassati;
            MieiVoli = VoliPassati;
            MieiBiglietti = BigliettiPassati;
            InitializeComponent();
        }
    }
}
