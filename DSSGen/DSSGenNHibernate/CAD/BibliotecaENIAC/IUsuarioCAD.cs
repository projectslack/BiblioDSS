
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string DNI);

string New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (string DNI);
}
}
