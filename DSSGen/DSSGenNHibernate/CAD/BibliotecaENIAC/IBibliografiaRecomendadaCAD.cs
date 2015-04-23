
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IBibliografiaRecomendadaCAD
{
BibliografiaRecomendadaEN ReadOIDDefault (int idSocioObras);

int New_ (BibliografiaRecomendadaEN bibliografiaRecomendada);

void Modify (BibliografiaRecomendadaEN bibliografiaRecomendada);


void Destroy (int idSocioObras);


System.Collections.Generic.IList<BibliografiaRecomendadaEN> Listarrecomendadas (int first, int size);
}
}
