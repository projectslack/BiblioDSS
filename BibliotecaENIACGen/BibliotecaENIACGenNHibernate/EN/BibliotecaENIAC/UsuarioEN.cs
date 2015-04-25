
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class UsuarioEN
{
/**
 *
 */

private string dNI;

/**
 *
 */

private string nombre;

/**
 *
 */

private string apellidos;

/**
 *
 */

private long telefono;

/**
 *
 */

private string correo;

/**
 *
 */

private int penalizacion;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo;

/**
 *
 */

private string contrasenya;

/**
 *
 */

private bool logeado;





public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual long Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Correo {
        get { return correo; } set { correo = value;  }
}


public virtual int Penalizacion {
        get { return penalizacion; } set { penalizacion = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> Recomienda {
        get { return recomienda; } set { recomienda = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reservar {
        get { return reservar; } set { reservar = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> Prestamo {
        get { return prestamo; } set { prestamo = value;  }
}


public virtual string Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}


public virtual bool Logeado {
        get { return logeado; } set { logeado = value;  }
}


public UsuarioEN()
{
        recomienda = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN>();
        reservar = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
        prestamo = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN>();
}



public UsuarioEN(string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
{
        this.init (dNI, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo, contrasenya, logeado);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.DNI, usuario.Nombre, usuario.Apellidos, usuario.Telefono, usuario.Correo, usuario.Penalizacion, usuario.Recomienda, usuario.Reservar, usuario.Prestamo, usuario.Contrasenya, usuario.Logeado);
}

private void init (string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
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
        this.Contrasenya = contrasenya;
        this.Logeado = false;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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