﻿using System;
using System.Collections.Generic;

using System.Text;

/**
 * Autor: Cristian Daniel Garay Sosa
 * Fecha :  23/101/2012 (original)
 * Comentarios:
 *          lo que es una anotacion en Java, sirve para generar metadatos, en este caso relacionar
 *          una Clase con una Tabla
 * 
 * */

namespace CdgNetPersistenciaV3.Atributos
{
    /// <summary>
    /// Atributo de relacion OTD extendido - TABLA de SGBD
    /// </summary>
    /// <see cref="http://msdn.microsoft.com/es-es/library/sw480ze8%28v=vs.80%29.aspx"/>
    [System.AttributeUsage(System.AttributeTargets.Class
                            , AllowMultiple = false)
    ]
    public class Tabla : System.Attribute
    {
        
        #region CAMPOS(Fields)

        const string NOMBRE_CLASE = "Tabla";

        
        private string __cNombre;

        public enum SGBD { SQL_SERVER = 0, ORACLE, SQLITE };

        private SGBD __eTipo;


        #endregion



        #region CONSTRUCTORES

        /// <summary>
        /// Contructor de la Clase
        /// </summary>
        /// <param name="cNombreTabla">Nombre de la Tabla al que hace referencia la Clase</param>
        /// <param name="eNombreSGBD">Nombre del SGBD para establecer los tipos de consultas parametrizadas</param>
        public Tabla(string cNombreTabla, SGBD eNombreSGBD)
        {
            __cNombre = cNombreTabla;
            __eTipo = eNombreSGBD;
        }



        #endregion



        #region GETTERS Y SETTERS

        /// <summary>
        /// Devuelve el nombre del campo de la tabla
        /// </summary>
        public string Nombre
        {
            get {return __cNombre;}
        }

        /// <summary>
        /// Devuelve el tipo de SGBD donde se aloja la tabla
        /// </summary>
        public SGBD TipoSGBD
        {
            get { return __eTipo; }
        }



        #endregion 



        #region SOBREESCRITOS

        /// <summary>
        /// Devuelve la representacion de la instancia
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("<{0} - [{1}]>", NOMBRE_CLASE, __cNombre);
        }


        #endregion


    }
}
