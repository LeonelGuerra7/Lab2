using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Alarma
    {
    
        public delegate void AlarmaEventHandler(object sender, EventArgs e);

        public event AlarmaEventHandler AlarmaDisparada;

        public void DispararAlarma()
        {
            Console.WriteLine("¡Alarma disparada!");
            OnAlarmaDisparada(EventArgs.Empty);
        }

        protected virtual void OnAlarmaDisparada(EventArgs e)
        {
            AlarmaDisparada?.Invoke(this, e);
        }
    }
}
