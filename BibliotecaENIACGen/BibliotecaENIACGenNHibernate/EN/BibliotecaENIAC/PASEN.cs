
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class PASEN              :                           BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director;





public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN Director {
        get { return director; } set { director = value;  }
}





public PASEN() : base ()
{
        reserva = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
}



public PASEN(string dNI, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
{
        this.init (dNI, reserva, director, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo, contrasenya, logeado);
}


public PASEN(PASEN pAS)
{
        this.init (pAS.DNI, pAS.Reserva, pAS.Director, pAS.Nombre, pAS.Apellidos, pAS.Telefono, pAS.Correo, pAS.Penalizacion, pAS.Recomienda, pAS.Reservar, pAS.Prestamo, pAS.Contrasenya, pAS.Logeado);
}

private void init (string dNI, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
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

        this.Contrasenya = contrasenya;

        this.Logeado = logeado;
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
