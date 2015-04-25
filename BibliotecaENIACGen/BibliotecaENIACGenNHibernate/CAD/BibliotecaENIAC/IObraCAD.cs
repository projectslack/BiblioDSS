
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IObraCAD
{
ObraEN ReadOIDDefault (int Isbn);

int New_ (ObraEN obra);

void Modify (ObraEN obra);


void Destroy (int Isbn);


System.Collections.Generic.IList<ObraEN> DameObras (int first, int size);


ObraEN BuscaPorId (int Isbn);


System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorNombre (string nombre);


System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorAutor (string autor);


System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorTematica (string tema);
}
}
