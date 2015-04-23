

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using DSSGenNHibernate.EN.BibliotecaENIAC;
using DSSGenNHibernate.CAD.BibliotecaENIAC;

namespace DSSGenNHibernate.CEN.BibliotecaENIAC
{
public partial class DirectorCEN
{
private IDirectorCAD _IDirectorCAD;

public DirectorCEN()
{
        this._IDirectorCAD = new DirectorCAD ();
}

public DirectorCEN(IDirectorCAD _IDirectorCAD)
{
        this._IDirectorCAD = _IDirectorCAD;
}

public IDirectorCAD get_IDirectorCAD ()
{
        return this._IDirectorCAD;
}

public System.Collections.Generic.IList<DirectorEN> Listadirectores (int first, int size)
{
        System.Collections.Generic.IList<DirectorEN> list = null;

        list = _IDirectorCAD.Listadirectores (first, size);
        return list;
}
public string New_ (string p_DNI, string p_nombre, string p_apellidos, long p_telefono, string p_correo, int p_penalizacion)
{
        DirectorEN directorEN = null;
        string oid;

        //Initialized DirectorEN
        directorEN = new DirectorEN ();
        directorEN.DNI = p_DNI;

        directorEN.Nombre = p_nombre;

        directorEN.Apellidos = p_apellidos;

        directorEN.Telefono = p_telefono;

        directorEN.Correo = p_correo;

        directorEN.Penalizacion = p_penalizacion;

        //Call to DirectorCAD

        oid = _IDirectorCAD.New_ (directorEN);
        return oid;
}
}
}
