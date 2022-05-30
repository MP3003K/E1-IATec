using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class Flete
    {
        IReglaFlete reglaFlete;

        public decimal CalcularParaCiudad(Compra compra)
        {
            if (compra.CiudadEnum == Ciudad.Cusco)
            {
                reglaFlete = new ReglaFleteCusco();
            }
            switch (compra.CiudadEnum)
            {
                case Ciudad.BuenosAires:
                    reglaFlete = new ReglaFleteSaoPaulo();
                    break;
                case Ciudad.Cusco:
                    reglaFlete = new ReglaFleteCusco();
                    break;
                case Ciudad.LaPaz:
                    reglaFlete = new ReglaFleteLaPaz();
                    break;
                case Ciudad.Lima:
                    reglaFlete = new ReglaFleteLima();
                    break;
                case Ciudad.Montevideo:
                    reglaFlete = new ReglaFleteMontevideo();
                    break;
                case Ciudad.Quito:
                    reglaFlete = new ReglaFleteQuito();
                    break;
                case Ciudad.RioDeJaneiro:
                    reglaFlete = new ReglaFleteRioDeJaneiro();
                    break;
                case Ciudad.Santiago:
                    reglaFlete = new ReglaFleteSantiago();
                    break;
                case Ciudad.SaoPaulo:
                    reglaFlete = new ReglaFleteSaoPaulo();
                    break;
            }
            return reglaFlete.CalcularFlete(compra);
        }
    }
}

