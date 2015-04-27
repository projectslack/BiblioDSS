
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface ITematicaCAD
{
TematicaEN ReadOIDDefault (string nombre);

string New_ (TematicaEN tematica);

void Modify (TematicaEN tematica);


void Destroy (string nombre);
}
}
