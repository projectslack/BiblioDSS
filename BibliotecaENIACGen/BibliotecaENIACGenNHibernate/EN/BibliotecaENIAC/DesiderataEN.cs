
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class DesiderataEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string autor;

/**
 *
 */

private string titulo;

/**
 *
 */

private string editorial;

/**
 *
 */

private short año;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Autor {
        get { return autor; } set { autor = value;  }
}


public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}


public virtual string Editorial {
        get { return editorial; } set { editorial = value;  }
}


public virtual short Año {
        get { return año; } set { año = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public DesiderataEN()
{
}



public DesiderataEN(int id, string autor, string titulo, string editorial, short año, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario)
{
        this.init (id, autor, titulo, editorial, año, usuario);
}


public DesiderataEN(DesiderataEN desiderata)
{
        this.init (desiderata.Id, desiderata.Autor, desiderata.Titulo, desiderata.Editorial, desiderata.Año, desiderata.Usuario);
}

private void init (int id, string autor, string titulo, string editorial, short año, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario)
{
        this.Id = id;


        this.Autor = autor;

        this.Titulo = titulo;

        this.Editorial = editorial;

        this.Año = año;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DesiderataEN t = obj as DesiderataEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
