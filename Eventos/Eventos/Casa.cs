using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Casa
    {
        public Casa()
        {
            Alarma miAlarma = new Alarma();

            miAlarma.AlarmaDisparada += MiAlarma_AlarmaDisparada;

            miAlarma.DispararAlarma();
        }

        private void MiAlarma_AlarmaDisparada(object sender, EventArgs e)
        {
            Console.WriteLine("¡Alerta! La alarma de la casa ha sido disparada.");
        }
    }
}
