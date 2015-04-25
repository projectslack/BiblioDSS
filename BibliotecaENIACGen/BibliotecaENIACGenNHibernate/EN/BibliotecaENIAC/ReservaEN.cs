
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class ReservaEN
{
/**
 *
 */

private string idReserva;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN pAS;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra;

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

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario;





public virtual string IdReserva {
        get { return idReserva; } set { idReserva = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN PAS {
        get { return pAS; } set { pAS = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> Obra {
        get { return obra; } set { obra = value;  }
}


public virtual Nullable<DateTime> FechaVencimiento {
        get { return fechaVencimiento; } set { fechaVencimiento = value;  }
}


public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReservaEN()
{
        obra = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
}



public ReservaEN(string idReserva, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN pAS, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario)
{
        this.init (idReserva, pAS, obra, fechaVencimiento, fechaInicio, usuario);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (reserva.IdReserva, reserva.PAS, reserva.Obra, reserva.FechaVencimiento, reserva.FechaInicio, reserva.Usuario);
}

private void init (string idReserva, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN pAS, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario)
{
        this.IdReserva = idReserva;


        this.PAS = pAS;

        this.Obra = obra;

        this.FechaVencimiento = fechaVencimiento;

        this.FechaInicio = fechaInicio;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
        if (t == null)
                return false;
        if (IdReserva.Equals (t.IdReserva))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdReserva.GetHashCode ();
        return hash;
}
}
}
