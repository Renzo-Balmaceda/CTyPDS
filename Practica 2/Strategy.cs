using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public interface EstrategiadeComparacion 
    {
        public bool SosIgual(Suscriptor a, Suscriptor b);
        public bool SosMenor(Suscriptor a, Suscriptor b);
        public bool SosMayor(Suscriptor a, Suscriptor b);
    }

    public class EstrategiaPorNombre : EstrategiadeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getNombre().Equals(b.getNombre());
        }
        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getNombre().CompareTo(b.getNombre()) < 0;
        }
        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getNombre().CompareTo(b.getNombre()) > 0;
        }
    }
    public class EstrategiaPorID : EstrategiadeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getId() == b.getId();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getId() < b.getId();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getId() > b.getId();
        }
    }

    public class EstrategiaPorHorasVistas : EstrategiadeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() == b.getHorasVistas();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() < b.getHorasVistas();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() > b.getHorasVistas();
        }
    }

    public class EstrategiaPorMesesDeSuscripcion : EstrategiadeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getMesesdeSuscripcion() == b.getMesesdeSuscripcion();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesdeSuscripcion() < b.getMesesdeSuscripcion();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesdeSuscripcion() > b.getMesesdeSuscripcion();
        }
    }

}
