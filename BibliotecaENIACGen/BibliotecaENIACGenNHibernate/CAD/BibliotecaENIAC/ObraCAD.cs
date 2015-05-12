
using System;
using System.Text;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.Exceptions;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial class ObraCAD : BasicCAD, IObraCAD
{
public ObraCAD() : base ()
{
}

public ObraCAD(ISession sessionAux) : base (sessionAux)
{
}


public ObraEN ReadOIDDefault (string Isbn)
{
        ObraEN obraEN = null;

        try
        {
                SessionInitializeTransaction ();
                obraEN = (ObraEN)session.Get (typeof(ObraEN), Isbn);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obraEN;
}


public string New_ (ObraEN obra)
{
        try
        {
                SessionInitializeTransaction ();
                if (obra.Escrita != null) {
                        for (int i = 0; i < obra.Escrita.Count; i++) {
                                obra.Escrita [i] = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN), obra.Escrita [i].Nombre);
                                obra.Escrita [i].Escribe.Add (obra);
                        }
                }
                if (obra.Tematica != null) {
                        for (int i = 0; i < obra.Tematica.Count; i++) {
                                obra.Tematica [i] = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN), obra.Tematica [i].Nombre);
                                obra.Tematica [i].Obra.Add (obra);
                        }
                }

                session.Save (obra);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obra.Isbn;
}

public void Modify (ObraEN obra)
{
        try
        {
                SessionInitializeTransaction ();
                ObraEN obraEN = (ObraEN)session.Load (typeof(ObraEN), obra.Isbn);

                obraEN.Nombre = obra.Nombre;


                obraEN.Paginas = obra.Paginas;


                obraEN.Anyo = obra.Anyo;


                obraEN.Imagen = obra.Imagen;

                session.Update (obraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string Isbn)
{
        try
        {
                SessionInitializeTransaction ();
                ObraEN obraEN = (ObraEN)session.Load (typeof(ObraEN), Isbn);
                session.Delete (obraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ObraEN> ListarObras (int first, int size)
{
        System.Collections.Generic.IList<ObraEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ObraEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ObraEN>();
                else
                        result = session.CreateCriteria (typeof(ObraEN)).List<ObraEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ObraEN BuscaPorId (string Isbn)
{
        ObraEN obraEN = null;

        try
        {
                SessionInitializeTransaction ();
                obraEN = (ObraEN)session.Get (typeof(ObraEN), Isbn);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obraEN;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorNombre (string nombre)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
            SessionInitializeTransaction();
            String sql = @"FROM ObraEN where nombre like'%" + nombre + "%'";
            //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
            IQuery query = session.CreateQuery(sql);
            //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
            //query.SetParameter("autor", autor);

            result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
            SessionCommit();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorAutor (string autor)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> autores;
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> tematicas;
    int i = 0;
    int j = 0;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM ObraEN o as o inner join o.Isbn as i with i.nombre like '%Cer%'";
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
        for (i = 0; i < result.Count; i++)
        {
            
            //bloque de insertar los actores en las obras
            
            sql = @"FROM AutorEN a as a inner join a.nombre as i with i.Isbn ='" + result[i].Isbn + "'";
            IQuery queryAutores = session.CreateQuery(sql);
            autores = queryAutores.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();

            //bloque de insertar la tematica en las obras
            sql = @"FROM TematicaEN t as t inner join t.nombre as i with i.Isbn =" + result[i].Isbn + "";
            IQuery queryTematicas = session.CreateQuery(sql);
            tematicas = queryTematicas.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();

            result[0].Escrita = autores;
            result[i].Tematica = tematicas;
        }
            
        
        SessionCommit();
    }

    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error in ObraCAD.", ex);
    }


    finally
    {
        SessionClose();
    }

    return result;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorTematica (string tema)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM ObraEN o as o inner join o.Isbn as i with i.nombre like'%" + tema + "%'";
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
        SessionCommit();
    }

    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error in ObraCAD.", ex);
    }


    finally
    {
        SessionClose();
    }

    return result;
}
}
}
