
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface ISocioCAD
{
SocioEN ReadOIDDefault (string DNI);

System.Collections.Generic.IList<SocioEN> Listasocios (int first, int size);


string New_ (SocioEN socio);
}
}
