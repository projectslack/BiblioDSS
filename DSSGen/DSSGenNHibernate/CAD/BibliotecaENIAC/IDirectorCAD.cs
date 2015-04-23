
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IDirectorCAD
{
DirectorEN ReadOIDDefault (string DNI);

System.Collections.Generic.IList<DirectorEN> Listadirectores (int first, int size);


string New_ (DirectorEN director);
}
}
