
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



public ObraEN ReadOIDDefault (int Isbn)
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


public int New_ (ObraEN obra)
{
        try
        {
                SessionInitializeTransaction ();

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


                obraEN.Ejemplares = obra.Ejemplares;


                obraEN.Autor = obra.Autor;


                obraEN.Tematica = obra.Tematica;


                obraEN.Paginas = obra.Paginas;


                obraEN.Prestado = obra.Prestado;


                obraEN.Reservado = obra.Reservado;

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
public void Destroy (int Isbn)
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

public System.Collections.Generic.IList<ObraEN> DameObras (int first, int size)
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

public ObraEN BuscaPorId (int Isbn)
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
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorNombreHQL");
                query.SetParameter ("nombre", nombre);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
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
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorAutor (string autor)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorAutorHQL");
                query.SetParameter ("autor", autor);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
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
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorTematica (string tema)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorTematicaHQL");
                query.SetParameter ("tema", tema);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
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
}
}
