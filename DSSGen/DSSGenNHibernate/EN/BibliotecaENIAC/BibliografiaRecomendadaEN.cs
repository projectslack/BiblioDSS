
using System;

namespace DSSGenNHibernate.EN.BibliotecaENIAC
{
public partial class BibliografiaRecomendadaEN
{
/**
 *
 */

private int idSocioObras;

/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra;

/**
 *
 */

private System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario;





public virtual int IdSocioObras {
        get { return idSocioObras; } set { idSocioObras = value;  }
}


public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN> Obra {
        get { return obra; } set { obra = value;  }
}


public virtual System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public BibliografiaRecomendadaEN()
{
        obra = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
        usuario = new System.Collections.Generic.List<DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN>();
}



public BibliografiaRecomendadaEN(int idSocioObras, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario)
{
        this.init (idSocioObras, obra, usuario);
}


public BibliografiaRecomendadaEN(BibliografiaRecomendadaEN bibliografiaRecomendada)
{
        this.init (bibliografiaRecomendada.IdSocioObras, bibliografiaRecomendada.Obra, bibliografiaRecomendada.Usuario);
}

private void init (int idSocioObras, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, System.Collections.Generic.IList<DSSGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario)
{
        this.IdSocioObras = idSocioObras;


        this.Obra = obra;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BibliografiaRecomendadaEN t = obj as BibliografiaRecomendadaEN;
        if (t == null)
                return false;
        if (IdSocioObras.Equals (t.IdSocioObras))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdSocioObras.GetHashCode ();
        return hash;
}
}
}
