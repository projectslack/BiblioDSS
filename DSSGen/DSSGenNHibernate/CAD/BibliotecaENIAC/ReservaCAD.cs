
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
public partial class ReservaCAD : BasicCAD, IReservaCAD
{
public ReservaCAD() : base ()
{
}

public ReservaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReservaEN ReadOIDDefault (string idReserva)
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaEN), idReserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}


public string New_ (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (reserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reserva.IdReserva;
}

public void Modify (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaEN reservaEN = (ReservaEN)session.Load (typeof(ReservaEN), reserva.IdReserva);

                reservaEN.FechaVencimiento = reserva.FechaVencimiento;


                reservaEN.FechaInicio = reserva.FechaInicio;

                session.Update (reservaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string idReserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaEN reservaEN = (ReservaEN)session.Load (typeof(ReservaEN), idReserva);
                session.Delete (reservaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ReservaEN> ListaReservas (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReservaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                else
                        result = session.CreateCriteria (typeof(ReservaEN)).List<ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSSGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSSGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
