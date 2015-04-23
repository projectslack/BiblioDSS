
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class SocioEN                    :                           DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
public SocioEN() : base ()
{
}



public SocioEN(string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.init (dNI, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo);
}


public SocioEN(SocioEN socio)
{
        this.init (socio.DNI, socio.Nombre, socio.Apellidos, socio.Telefono, socio.Correo, socio.Penalizacion, socio.Recomienda, socio.Reservar, socio.Prestamo);
}

private void init (string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Correo = correo;

        this.Penalizacion = penalizacion;

        this.Recomienda = recomienda;

        this.Reservar = reservar;

        this.Prestamo = prestamo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SocioEN t = obj as SocioEN;
        if (t == null)
                return false;
        if (DNI.Equals (t.DNI))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.DNI.GetHashCode ();
        return hash;
}
}
}
