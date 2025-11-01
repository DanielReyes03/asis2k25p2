﻿// =============================================================
// Capa_Controlador_Creacion_Nomina
// Clase: Cls_Controlador_Creacion_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 20250000
// Fecha: 29/10/2025
// Descripción: Controlador encargado de manejar la lógica de negocio
//              para la creación y administración de nóminas,
//              aplicando las reglas de estandarización V2.1
//              y adaptado a la estructura actual de Tbl_Nomina.
// =============================================================

using System;
using System.Data;
using Capa_Modelo_Creacion_Nomina; // Referencia a la capa modelo

namespace Capa_Controlador_Creacion_Nomina
{
    public class Cls_Controlador_Creacion_Nomina
    {
        // Instancia del modelo DAO
        private Cls_Dao_Creacion_Nomina clsDaoNomina = new Cls_Dao_Creacion_Nomina();

        // ==========================================================
        // MÉTODOS DE CREACIÓN
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public void proInsertarNomina(DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
        {
            try
            {
                bool bExiste = clsDaoNomina.funExistePeriodoNomina(dPeriodoInicio, dPeriodoFin);

                if (bExiste)
                {
                    Console.WriteLine("Ya existe una nómina en el periodo seleccionado.");
                    throw new Exception("Ya existe una nómina generada para este periodo o un rango de fechas que se cruza.");
                }

                clsDaoNomina.proInsertarNomina(dPeriodoInicio, dPeriodoFin, dFechaGeneracion, sTipo, sEstado);
                Console.WriteLine("Nómina creada con estado: " + sEstado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la nómina: " + ex.Message);
                throw; // Propaga el error para mostrarlo en la vista
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // ==========================================================
        // MÉTODOS DE MODIFICACIÓN
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public void proActualizarNomina(int iIdNomina, DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
        {
            try
            {
                clsDaoNomina.proActualizarNomina(iIdNomina, dPeriodoInicio, dPeriodoFin, dFechaGeneracion, sTipo, sEstado);
                Console.WriteLine("Nómina actualizada correctamente. Estado: " + sEstado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la nómina: " + ex.Message);
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // ==========================================================
        // MÉTODOS DE ELIMINACIÓN
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public void proEliminarNomina(int iIdNomina)
        {
            try
            {
                clsDaoNomina.proEliminarNomina(iIdNomina);
                Console.WriteLine("Nómina eliminada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la nómina: " + ex.Message);
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // ==========================================================
        // MÉTODOS DE CONSULTA
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public DataTable funObtenerNominaPorId(int iIdNomina)
        {
            try
            {
                return clsDaoNomina.funObtenerNominaPorId(iIdNomina);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la nómina: " + ex.Message);
                return null;
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public DataTable funObtenerTodasLasNominas()
        {
            try
            {
                return clsDaoNomina.funObtenerTodasLasNominas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener todas las nóminas: " + ex.Message);
                return null;
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // ==========================================================
        // MÉTODOS DE VERIFICACIÓN
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        public bool funExisteNomina(int iIdNomina)
        {
            try
            {
                int iExiste = clsDaoNomina.funVerificarExistenciaNomina(iIdNomina);
                return iExiste == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar la existencia de la nómina: " + ex.Message);
                return false;
            }
        }
        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


    }
}
