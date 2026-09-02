using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable componente) : base(componente) { }
        public override string MostrarInfo()
        {
            string info = componente.MostrarInfo();
            string asteriscos = new string('*', info.Length);

            return asteriscos + "\n"
                 + info + "\n"
                 + asteriscos;
        }
    }

    public class DecoradorRango : DecoradorSuscriptor
    {
        public DecoradorRango(Mostrable componente) : base(componente) { }

        public override string MostrarInfo()
        {
            int horas = componente.GetSuscriptor().getHorasVistas();
            if (horas < 10)
            {
                return $"[Bronce] " + componente.MostrarInfo();
            }
            else if (horas < 49)
            {
                return $"[Plata] " + componente.MostrarInfo();
            }
            else
            {
                return $"[Oro] " + componente.MostrarInfo();
            }
        }
    }

    public class DecoradorEstadoCuenta : DecoradorSuscriptor
    {
        public DecoradorEstadoCuenta(Mostrable componente) : base(componente) { }

        public override string MostrarInfo()
        {
            int horas = componente.GetSuscriptor().getHorasVistas();
            int pos = componente.MostrarInfo().IndexOf(" - ");
            string info = componente.MostrarInfo();
            if (horas > 0)
            {
                return info.Insert(pos, " (Cuenta Activa)");
            }
            else
            {
                return info.Insert(pos, " (Cuenta Inactiva)");
            }
        }
    }

    public class DecoradorMesesAntiguedad : DecoradorSuscriptor
    {
        public DecoradorMesesAntiguedad(Mostrable componente) : base(componente) { }

        public override string MostrarInfo()
        {
            int meses = componente.GetSuscriptor().getMesesdeSuscripcion();
            string info = componente.MostrarInfo();
            int pos = info.IndexOf(" - ");
            return info.Insert(pos, $" (Suscriptor hace {meses} meses)");
        }
    }
}
