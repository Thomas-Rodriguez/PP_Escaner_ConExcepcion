using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Documento;  //???

namespace Entidades
{
    public static class Informes
    {
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            StringBuilder text = new StringBuilder();

            extension = 0;
            cantidad = 0;
            resumen = "";

            foreach (Documento documento in e.ListaDocumentos)
            {
                if(documento.Estado == Documento.Paso.Distribuido)
                {
                    if(e.Tipo == Escaner.TipoDoc.libro)
                    {
                        extension += ((Libro)documento).NumPaginas;
                        text.AppendLine(((Libro)documento).ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa)
                    {
                        extension += ((Mapa)documento).Superficie;
                        text.AppendLine(((Mapa)documento).ToString());
                    }

                    cantidad++;
                }
            }

            resumen = text.ToString();
        }

        private static void MostrarDocumentoPorEstado(Escaner e, Paso estado, out int extension, out int cantidad, out string resumen)
        {
            StringBuilder text = new StringBuilder();

            extension = 0;
            cantidad = 0;
            resumen = "";

            foreach (Documento documento in e.ListaDocumentos)
            {
                if(documento.Estado == estado)
                {
                    if (e.Tipo == Escaner.TipoDoc.libro)
                    {
                        extension += ((Libro)documento).NumPaginas;
                        text.AppendLine(((Libro)documento).ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa)
                    {
                        extension += ((Mapa)documento).Superficie;
                        text.AppendLine(((Mapa)documento).ToString());
                    }

                    cantidad++;
                }
            } 
            resumen = text.ToString();
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            StringBuilder text = new StringBuilder();

            extension = 0;
            cantidad = 0;
            resumen = "";

            foreach (Documento documento in e.ListaDocumentos)
            {
                if (documento.Estado == Documento.Paso.EnEscaner)
                {
                    if (e.Tipo == Escaner.TipoDoc.libro)
                    {
                        extension += ((Libro)documento).NumPaginas;
                        text.AppendLine(((Libro)documento).ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa)
                    {
                        extension += ((Mapa)documento).Superficie;
                        text.AppendLine(((Mapa)documento).ToString());
                    }

                    cantidad++;
                }
            }

            resumen = text.ToString();
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            StringBuilder text = new StringBuilder();

            extension = 0;
            cantidad = 0;
            resumen = "";

            foreach (Documento documento in e.ListaDocumentos)
            {
                if (documento.Estado == Documento.Paso.EnRevision)
                {
                    if (e.Tipo == Escaner.TipoDoc.libro)
                    {
                        extension += ((Libro)documento).NumPaginas;
                        text.AppendLine(((Libro)documento).ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa)
                    {
                        extension += ((Mapa)documento).Superficie;
                        text.AppendLine(((Mapa)documento).ToString());
                    }

                    cantidad++;
                }
            }
            resumen = text.ToString();
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            StringBuilder text = new StringBuilder();

            extension = 0;
            cantidad = 0;
            resumen = "";

            foreach (Documento documento in e.ListaDocumentos)
            {
                if (documento.Estado == Documento.Paso.Terminado)
                {
                    if (e.Tipo == Escaner.TipoDoc.libro)
                    {
                        extension += ((Libro)documento).NumPaginas;
                        text.AppendLine(((Libro)documento).ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa)
                    {
                        extension += ((Mapa)documento).Superficie;
                        text.AppendLine(((Mapa)documento).ToString());
                    }

                    cantidad++;
                }
            }
            resumen = text.ToString();
        }
    }
}
