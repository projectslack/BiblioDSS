
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class DirectorEN                 :                           DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS;





public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PASEN> PAS {
        get { return pAS; } set { pAS = value;  }
}





public DirectorEN() : base ()
{
        pAS = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.PASEN>();
}



public DirectorEN(string dNI, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.init (dNI, pAS, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo);
}


public DirectorEN(DirectorEN director)
{
        this.init (director.DNI, director.PAS, director.Nombre, director.Apellidos, director.Telefono, director.Correo, director.Penalizacion, director.Recomienda, director.Reservar, director.Prestamo);
}

private void init (string dNI, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.DNI = DNI;


        this.PAS = pAS;

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
        DirectorEN t = obj as DirectorEN;
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
