
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class PrestamoEN
{
/**
 *
 */

private string idPrestamo;

/**
 *
 */

private Nullable<DateTime> fechaVencimiento;

/**
 *
 */

private Nullable<DateTime> fechaInicio;

/**
 *
 */

private DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario;

/**
 *
 */

private DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN obra;





public virtual string IdPrestamo {
        get { return idPrestamo; } set { idPrestamo = value;  }
}


public virtual Nullable<DateTime> FechaVencimiento {
        get { return fechaVencimiento; } set { fechaVencimiento = value;  }
}


public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}


public virtual DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN Obra {
        get { return obra; } set { obra = value;  }
}





public PrestamoEN()
{
}



public PrestamoEN(string idPrestamo, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario, DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN obra)
{
        this.init (idPrestamo, fechaVencimiento, fechaInicio, usuario, obra);
}


public PrestamoEN(PrestamoEN prestamo)
{
        this.init (prestamo.IdPrestamo, prestamo.FechaVencimiento, prestamo.FechaInicio, prestamo.Usuario, prestamo.Obra);
}

private void init (string idPrestamo, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario, DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN obra)
{
        this.IdPrestamo = idPrestamo;


        this.FechaVencimiento = fechaVencimiento;

        this.FechaInicio = fechaInicio;

        this.Usuario = usuario;

        this.Obra = obra;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PrestamoEN t = obj as PrestamoEN;
        if (t == null)
                return false;
        if (IdPrestamo.Equals (t.IdPrestamo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPrestamo.GetHashCode ();
        return hash;
}
}
}
