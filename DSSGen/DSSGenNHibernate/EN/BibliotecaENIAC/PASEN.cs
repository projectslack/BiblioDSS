
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class PASEN              :                           DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva;

/**
 *
 */

private DSSGenNHibernate.EN.BibliotecaENIAC.DirectorEN director;





public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual DSSGenNHibernate.EN.BibliotecaENIAC.DirectorEN Director {
        get { return director; } set { director = value;  }
}





public PASEN() : base ()
{
        reserva = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
}



public PASEN(string dNI, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, DSSGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.init (dNI, reserva, director, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo);
}


public PASEN(PASEN pAS)
{
        this.init (pAS.DNI, pAS.Reserva, pAS.Director, pAS.Nombre, pAS.Apellidos, pAS.Telefono, pAS.Correo, pAS.Penalizacion, pAS.Recomienda, pAS.Reservar, pAS.Prestamo);
}

private void init (string dNI, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, DSSGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.DNI = DNI;


        this.Reserva = reserva;

        this.Director = director;

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
        PASEN t = obj as PASEN;
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
