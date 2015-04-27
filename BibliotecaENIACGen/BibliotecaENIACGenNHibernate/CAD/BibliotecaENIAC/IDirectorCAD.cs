
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IDirectorCAD
{
DirectorEN ReadOIDDefault (string DNI);

System.Collections.Generic.IList<DirectorEN> ListarDirectores (int first, int size);


string New_ (DirectorEN director);
}
}
