
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
public partial class UsuarioCEN
{
public void HacerPrestamo (string p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_Usuario_hacerPrestamo) ENABLED START*/

        // Write here your custom code...


        PrestamoEN prestamo = new PrestamoEN (); //_IUsuarioCAD.DameporOID(p_oid);



        /*PROTECTED REGION END*/
}
}
}
