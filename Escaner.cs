using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        public enum Departamento { nulo, mapoteca, procesosTecnicos }
        public enum TipoDoc { libro, mapa }

        private List<Documento> listaDocumentos;
        private Departamento location;
        private string marca;
        private TipoDoc tipo;


        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.listaDocumentos = new List<Documento>();
            if (this.tipo == TipoDoc.mapa)
            {
                this.location = Departamento.mapoteca;
            }
            else if (this.tipo == TipoDoc.libro)
            {
                this.location = Departamento.procesosTecnicos;
            }
        }

        public List<Documento> ListaDocumentos { get { return listaDocumentos; } }
        public Departamento Location { get { return location; } }
        public string Marca { get { return marca; } }
        public TipoDoc Tipo { get { return tipo; } }

        public static bool operator ==(Escaner e, Documento d)
        {
            foreach (Documento documento in e.listaDocumentos)
            {
                if (d == documento)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            foreach (Documento documento in e.listaDocumentos)
            {
                if (d == documento)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator +(Escaner e, Documento d)
        {
            if (IsValidDocument(e.tipo, d.GetType()))
            {
                throw new CastException($"No se puede agregar un tipo distinto a un Escaner {e.tipo}.");
            }
            //else if (e.tipo == TipoDoc.mapa && d.GetType() != typeof(Mapa))
            //{
            //    throw new CastException();
            //}

            if (e != d && d.Estado != Documento.Paso.Inicio)
            {
                return false;
            }

            d.AvanzarEstado();
            e.listaDocumentos.Add(d);
            return true;


            //    switch (e.tipo)
            //    {
            //        case TipoDoc.libro:
            //            if (d.GetType() != typeof(Libro) || e != d && d.Estado != Documento.Paso.Inicio)
            //            {
            //                return false;
            //            }
            //            break;
            //        case TipoDoc.mapa:
            //            if (d.GetType() != typeof(Mapa) || e != d && d.Estado != Documento.Paso.Inicio)
            //            {
            //                return false;
            //            }
            //            break;
            //        default:
            //            return false;
            //    }
            //    d.AvanzarEstado();
            //    e.listaDocumentos.Add(d);
            //    return true;
        }


        private static bool IsValidDocument(Escaner.TipoDoc tipo, Type pepe)
        {
            switch (tipo)
            {
                case TipoDoc.libro:
                    if (pepe != typeof(Libro))
                    {
                        return false;
                    }
                    break;
                case TipoDoc.mapa:
                    if(pepe != typeof(Mapa))
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }

            return true;
        }


        public bool CambiarEstadoDocumento(Documento d)
        {
            foreach (Documento documento in listaDocumentos)
            {
                if (documento == d)
                {
                    return documento.AvanzarEstado();
                }
            }
            return false;
        }
    }
}
