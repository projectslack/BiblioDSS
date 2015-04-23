
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class ObraEN
{
/**
 *
 */

private int isbn;

/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> tieneobras;

/**
 *
 */

private string nombre;

/**
 *
 */

private short ejemplares;

/**
 *
 */

private string autor;

/**
 *
 */

private string tematica;

/**
 *
 */

private short paginas;

/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva;

/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo;





public virtual int Isbn {
        get { return isbn; } set { isbn = value;  }
}


public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> Tieneobras {
        get { return tieneobras; } set { tieneobras = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual short Ejemplares {
        get { return ejemplares; } set { ejemplares = value;  }
}


public virtual string Autor {
        get { return autor; } set { autor = value;  }
}


public virtual string Tematica {
        get { return tematica; } set { tematica = value;  }
}


public virtual short Paginas {
        get { return paginas; } set { paginas = value;  }
}


public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> Prestamo {
        get { return prestamo; } set { prestamo = value;  }
}





public ObraEN()
{
        tieneobras = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN>();
        reserva = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
        prestamo = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN>();
}



public ObraEN(int isbn, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> tieneobras, string nombre, short ejemplares, string autor, string tematica, short paginas, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.init (isbn, tieneobras, nombre, ejemplares, autor, tematica, paginas, reserva, prestamo);
}


public ObraEN(ObraEN obra)
{
        this.init (obra.Isbn, obra.Tieneobras, obra.Nombre, obra.Ejemplares, obra.Autor, obra.Tematica, obra.Paginas, obra.Reserva, obra.Prestamo);
}

private void init (int isbn, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> tieneobras, string nombre, short ejemplares, string autor, string tematica, short paginas, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.Isbn = Isbn;


        this.Tieneobras = tieneobras;

        this.Nombre = nombre;

        this.Ejemplares = ejemplares;

        this.Autor = autor;

        this.Tematica = tematica;

        this.Paginas = paginas;

        this.Reserva = reserva;

        this.Prestamo = prestamo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ObraEN t = obj as ObraEN;
        if (t == null)
                return false;
        if (Isbn.Equals (t.Isbn))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Isbn.GetHashCode ();
        return hash;
}
}
}
