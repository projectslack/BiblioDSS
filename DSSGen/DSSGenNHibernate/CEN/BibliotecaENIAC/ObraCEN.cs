

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
public partial class ObraCEN
{
private IObraCAD _IObraCAD;

public ObraCEN()
{
        this._IObraCAD = new ObraCAD ();
}

public ObraCEN(IObraCAD _IObraCAD)
{
        this._IObraCAD = _IObraCAD;
}

public IObraCAD get_IObraCAD ()
{
        return this._IObraCAD;
}

public int New_ (string p_nombre, short p_ejemplares, string p_autor, string p_tematica, short p_paginas)
{
        ObraEN obraEN = null;
        int oid;

        //Initialized ObraEN
        obraEN = new ObraEN ();
        obraEN.Nombre = p_nombre;

        obraEN.Ejemplares = p_ejemplares;

        obraEN.Autor = p_autor;

        obraEN.Tematica = p_tematica;

        obraEN.Paginas = p_paginas;

        //Call to ObraCAD

        oid = _IObraCAD.New_ (obraEN);
        return oid;
}

public void Modify (int p_Obra_OID, string p_nombre, short p_ejemplares, string p_autor, string p_tematica, short p_paginas)
{
        ObraEN obraEN = null;

        //Initialized ObraEN
        obraEN = new ObraEN ();
        obraEN.Isbn = p_Obra_OID;
        obraEN.Nombre = p_nombre;
        obraEN.Ejemplares = p_ejemplares;
        obraEN.Autor = p_autor;
        obraEN.Tematica = p_tematica;
        obraEN.Paginas = p_paginas;
        //Call to ObraCAD

        _IObraCAD.Modify (obraEN);
}

public void Destroy (int Isbn)
{
        _IObraCAD.Destroy (Isbn);
}

public System.Collections.Generic.IList<ObraEN> DameObras (int first, int size)
{
        System.Collections.Generic.IList<ObraEN> list = null;

        list = _IObraCAD.DameObras (first, size);
        return list;
}
public ObraEN BuscaPorId (int Isbn)
{
        ObraEN obraEN = null;

        obraEN = _IObraCAD.BuscaPorId (Isbn);
        return obraEN;
}
}
}
