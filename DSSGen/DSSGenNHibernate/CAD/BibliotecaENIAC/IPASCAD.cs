
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IPASCAD
{
PASEN ReadOIDDefault (string DNI);

System.Collections.Generic.IList<PASEN> Damepersonal (int first, int size);


string New_ (PASEN pAS);
}
}
