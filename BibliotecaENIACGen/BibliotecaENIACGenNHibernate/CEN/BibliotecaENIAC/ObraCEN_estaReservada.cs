using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
public partial class ObraCEN
{
public bool EstaReservada (int p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_Obra_estaReservada) ENABLED START*/

        // Write here your custom code...
        return (_IObraCAD.BuscaPorId(p_oid)).Reservado;
        /*
        bool result = false;
        ObraEN obra = _IObraCAD.BuscaPorId (p_oid);
        if (obra.Reservado.Equals (true)) {
                result = true;
        }

        return result;
         * */
        /*PROTECTED REGION END*/
}
}
}
