
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IObraCAD
{
ObraEN ReadOIDDefault (int Isbn);

int New_ (ObraEN obra);

void Modify (ObraEN obra);


void Destroy (int Isbn);


System.Collections.Generic.IList<ObraEN> DameObras (int first, int size);


ObraEN BuscaPorId (int Isbn);
}
}
