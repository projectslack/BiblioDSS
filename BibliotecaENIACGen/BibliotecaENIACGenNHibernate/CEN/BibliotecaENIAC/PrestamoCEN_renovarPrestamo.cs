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
public partial class PrestamoCEN
{
public bool RenovarPrestamo (string p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_Prestamo_renovarPrestamo) ENABLED START*/

        // Write here your custom code...
        bool result = true;
        PrestamoEN prestamo = _IPrestamoCAD.BuscarPrestamo (p_oid);
        Nullable<DateTime> tiempoAux = prestamo.FechaVencimiento;
        prestamo.FechaVencimiento = tiempoAux.Value.AddDays(7);
        return result;
        /*PROTECTED REGION END*/
}
}
}
