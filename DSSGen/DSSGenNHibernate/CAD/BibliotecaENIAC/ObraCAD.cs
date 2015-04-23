
using System;
using System.Text;
using DSSGenNHibernate.CEN.BibliotecaENIAC;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSSGenNHibernate.EN.BibliotecaENIAC;
using DSSGenNHibernate.Exceptions;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
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
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
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
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
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

                session.Update (obraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
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
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
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
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
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
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obraEN;
}
}
}
