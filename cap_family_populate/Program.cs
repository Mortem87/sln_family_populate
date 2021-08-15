using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_family_populate
{
    class Program
    {
        static void Main(string[] args)
        {

            string sql_one = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~AA0610~NoParte~00600-68~DescripcionEspañol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~SolicitudID~108959~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_two = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~AA0610~NoParte~06001-73~DescripcionEspañol~SOLVENTE THINNER~DescripcionIngles~MARBU TPV2 THINNER FOR TPR INK~SolicitudID~108959~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_general_one = @"SolicitudID~108961~NumeroParte~00600-69~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~DescripcionTecnica~~Presentacion~PIEZA~TipoAcabado~~Funcion~H-1 Hardener produces a relatively flexible ink film and is suitable for most Marabu inks. H1 has a slower hardening time when compared to H2 film and does not yellow upon UV exposure~Material~~Composicion~~Voltaje~~Potencia~~Capacidad~~DondeSeUtiliza~en el proceso productivo de cateters de hemodialisis~Marca~~Modelo~~Serie~~TipoMaquinaria~~Industria~Medica~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleGeneralID~1";

            string sql_food_one = @"SolicitudID~108962~NumeroParte~00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~EstadoMercancia~~Presentacion~PIEZA~UnidadMedida~~Industria~~PesoNetoContenedor~~Ingredientes~~TipoConservativos~~PaisID~~Marca~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleFoodID~1";

            string sql_metal_one = @"SolicitudID~108963~NumeroParte~MTL00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~DescripcionTenica~~Presentacion~PIEZA~Material~~TipoAcabado~~AleadoInoxidable~~RoladosFrioCaliente~~Anchura~~Espesor~~Diametro~~Funcion~~Composicion~~Funcionamiento~~Uso~~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleMetales~1";

            string sql_quimico_one = @"SolicitudID~108964~NumeroParte~00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~Sinonimo~~NombreComercial~~Ingredientes~~Uso~~Presentacion~PIEZA~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleQuimicoID~1";

            string sql_textil_one = @"SolicitudID~108965~NumeroParte~TXL00600-69~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~PorcentajeInsumos~~TipoTela~~TerminadoTela~~PesoxPie2~~FibraContinuaDescontinua~~Presentacion~PIEZA~TipoTejido~~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleTextilID~1";

            //DetalleSolicitudClasificacionGeneral.Populate(sql_general_one);

            //DetalleSolicitudClasificacionFood.Populate(sql_food_one);

            //DetalleSolicitudClasificacionQuimico.Populate(sql_quimico_one);

            //DetalleSolicitudClasificacionTextil.Populate(sql_textil_one);

            //DetalleSolicitudClasificacionMetales.Populate(sql_metal_one);

        }
    }
    public class DetalleSolicitudClasificacionGeneral
    {
        #region Properties
        public int SolicitudID { get; set; }//1
        public int DetalleGeneralID { get; set; }//41
        public string NumeroParte { get; set; }//3
        public string DescripcionEspanol { get; set; }//5
        public string DescripcionIngles { get; set; }//7
        public string DescripcionTecnica { get; set; }//9
        public string Presentacion { get; set; }//11
        public string TipoAcabado { get; set; }//13
        public string Function { get; set; }//15
        public string Material { get; set; }//17
        public string Composicion { get; set; }//19
        public string Voltaje { get; set; }//21
        public string Potencia { get; set; }//23
        public string Capacidad { get; set; }//25
        public string DondeSeUtiliza { get; set; }//27
        public string Marca { get; set; }//29
        public string Modelo { get; set; }//31
        public string Serie { get; set; }//33
        public string TipoMaquinaria { get; set; }//35
        public string Link { get; set; }//39
        public string Industria { get; set; }//37
        #endregion
        public static int Save(DetalleSolicitudClasificacionGeneral objGeneral)
        {

            string conexionSila = "";// ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;
            int result = 0;
            using (SqlConnection conn = new SqlConnection(conexionSila))
            {

                conn.Open();

                #region string sql
                string sql =
    @"
INSERT INTO [dbo].[DetalleSolicitudClasificacionGeneral]
           ([SolicitudID]
           ,[DetalleGeneralID]
           ,[NumeroParte]
           ,[DescripcionEspanol]
           ,[DescripcionIngles]
           ,[DescripcionTecnica]
           ,[Presentacion]
           ,[TipoAcabado]
           ,[Funcion]
           ,[Material]
           ,[Composicion]
           ,[Voltaje]
           ,[Potencia]
           ,[Capacidad]
           ,[DondeSeUtiliza]
           ,[Marca]
           ,[Modelo]
           ,[Serie]
           ,[TipoMaquinaria]
           ,[Link]
           ,[Industria])
     VALUES
           (@SolicitudID
           ,@DetalleGeneralID
           ,@NumeroParte
           ,@DescripcionEspanol
           ,@DescripcionIngles
           ,@DescripcionTecnica
           ,@Presentacion
           ,@TipoAcabado
           ,@Funcion
           ,@Material
           ,@Composicion
           ,@Voltaje
           ,@Potencia
           ,@Capacidad
           ,@DondeSeUtiliza
           ,@Marca
           ,@Modelo
           ,@Serie
           ,@TipoMaquinaria
           ,@Link
           ,@Industria);
";
                #endregion

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@SolicitudID", objGeneral.SolicitudID);
                command.Parameters.AddWithValue("@DetalleGeneralID", objGeneral.DetalleGeneralID);
                command.Parameters.AddWithValue("@NumeroParte", objGeneral.NumeroParte);
                command.Parameters.AddWithValue("@DescripcionEspanol", objGeneral.DescripcionEspanol);

                if (objGeneral.DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", objGeneral.DescripcionIngles);
                if (objGeneral.DescripcionTecnica == null) command.Parameters.AddWithValue("@DescripcionTecnica", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionTecnica", objGeneral.DescripcionTecnica);
                if (objGeneral.Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", objGeneral.Presentacion);
                if (objGeneral.TipoAcabado == null) command.Parameters.AddWithValue("@TipoAcabado", DBNull.Value); else command.Parameters.AddWithValue("@TipoAcabado", objGeneral.TipoAcabado);
                if (objGeneral.Function == null) command.Parameters.AddWithValue("@Funcion", DBNull.Value); else command.Parameters.AddWithValue("@Funcion", objGeneral.Function);
                if (objGeneral.Material == null) command.Parameters.AddWithValue("@Material", DBNull.Value); else command.Parameters.AddWithValue("@Material", objGeneral.Material);
                if (objGeneral.Composicion == null) command.Parameters.AddWithValue("@Composicion", DBNull.Value); else command.Parameters.AddWithValue("@Composicion", objGeneral.Composicion);
                if (objGeneral.Voltaje == null) command.Parameters.AddWithValue("@Voltaje", DBNull.Value); else command.Parameters.AddWithValue("@Voltaje", objGeneral.Voltaje);
                if (objGeneral.Potencia == null) command.Parameters.AddWithValue("@Potencia", DBNull.Value); else command.Parameters.AddWithValue("@Potencia", objGeneral.Potencia);
                if (objGeneral.Capacidad == null) command.Parameters.AddWithValue("@Capacidad", DBNull.Value); else command.Parameters.AddWithValue("@Capacidad", objGeneral.Capacidad);
                if (objGeneral.DondeSeUtiliza == null) command.Parameters.AddWithValue("@DondeSeUtiliza", DBNull.Value); else command.Parameters.AddWithValue("@DondeSeUtiliza", objGeneral.DondeSeUtiliza);
                if (objGeneral.Marca == null) command.Parameters.AddWithValue("@Marca", DBNull.Value); else command.Parameters.AddWithValue("@Marca", objGeneral.Marca);
                if (objGeneral.Modelo == null) command.Parameters.AddWithValue("@Modelo", DBNull.Value); else command.Parameters.AddWithValue("@Modelo", objGeneral.Modelo);
                if (objGeneral.Serie == null) command.Parameters.AddWithValue("@Serie", DBNull.Value); else command.Parameters.AddWithValue("@Serie", objGeneral.Serie);
                if (objGeneral.TipoMaquinaria == null) command.Parameters.AddWithValue("@TipoMaquinaria", DBNull.Value); else command.Parameters.AddWithValue("@TipoMaquinaria", objGeneral.TipoMaquinaria);
                if (objGeneral.Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", objGeneral.Link);
                if (objGeneral.Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", objGeneral.Industria);

                result = command.ExecuteNonQuery();

            }

            return result;
        }
        public static DetalleSolicitudClasificacionGeneral Populate(string sql)
        {
            DetalleSolicitudClasificacionGeneral objGeneral = new DetalleSolicitudClasificacionGeneral();

            string[] array = sql.Split('~');

            objGeneral.SolicitudID = int.Parse(array[1]);
            objGeneral.DetalleGeneralID = int.Parse(array[41]);
            objGeneral.NumeroParte = array[3];
            objGeneral.DescripcionEspanol = array[5];
            objGeneral.DescripcionIngles = TryParseString(array[7]);
            objGeneral.DescripcionTecnica = TryParseString(array[9]);
            objGeneral.Presentacion = TryParseString(array[11]);
            objGeneral.TipoAcabado = TryParseString(array[13]);
            objGeneral.Function = TryParseString(array[15]);
            objGeneral.Material = TryParseString(array[17]);
            objGeneral.Composicion = TryParseString(array[19]);
            objGeneral.Voltaje = TryParseString(array[21]);
            objGeneral.Potencia = TryParseString(array[23]);
            objGeneral.Capacidad = TryParseString(array[25]);
            objGeneral.DondeSeUtiliza = TryParseString(array[27]);
            objGeneral.Marca = TryParseString(array[29]);
            objGeneral.Modelo = TryParseString(array[31]);
            objGeneral.Serie = TryParseString(array[33]);
            objGeneral.TipoMaquinaria = TryParseString(array[35]);
            objGeneral.Link = TryParseString(array[39]);
            objGeneral.Industria = TryParseString(array[37]);

            return objGeneral;
        }
        private static string TryParseString(string value)
        {
            string value_result = "";
            try
            {//null
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = value;
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
    }
    public class DetalleSolicitudClasificacionFood
    {
        #region Properties
        public int SolicitudID { get; set; }
        public int DetalleFoodID { get; set; }
        public string NumeroParte { get; set; }
        public string DescripcionEspanol { get; set; }
        public string DescripcionIngles { get; set; }
        public string EstadoMercancia { get; set; }
        public string Presentacion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal? PesoNetoContenedor { get; set; }
        public string Ingredientes { get; set; }
        public string TipoConservativos { get; set; }
        public char? PaisID { get; set; }
        public string Marca { get; set; }
        public string Link { get; set; }
        public string Industria { get; set; }
        #endregion
        public static ResultInserted Save(DetalleSolicitudClasificacionFood objFood)
        {

            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = "";//ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

            int result = 0;

            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try
                {
                    conn.Open();

                    #region string sql
                    string sql =
        @"
INSERT INTO [dbo].[DetalleSolicitudClasifiacionFood]
           ([SolicitudID]
           ,[DetalleFoodID]
           ,[NumeroParte]
           ,[DescripcionEspanol]
           ,[DescripcionIngles]
           ,[EstadoMercancia]
           ,[Presentacion]
           ,[UnidadMedida]
           ,[PesoNetoContenedor]
           ,[Ingredientes]
           ,[TipoConservativos]
           ,[PaisID]
           ,[Marca]
           ,[Link]
           ,[Industria])
     VALUES
           (@SolicitudID
           ,@DetalleFoodID
           ,@NumeroParte
           ,@DescripcionEspanol
           ,@DescripcionIngles
           ,@EstadoMercancia
           ,@Presentacion
           ,@UnidadMedida
           ,@PesoNetoContenedor
           ,@Ingredientes
           ,@TipoConservativos
           ,@PaisID
           ,@Marca
           ,@Link
           ,@Industria);
";
                    #endregion

                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@SolicitudID", objFood.SolicitudID);
                    command.Parameters.AddWithValue("@DetalleFoodID", objFood.DetalleFoodID);
                    command.Parameters.AddWithValue("@NumeroParte", objFood.NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", objFood.DescripcionEspanol);

                    if (objFood.DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", objFood.DescripcionIngles);

                    if (objFood.EstadoMercancia == null) command.Parameters.AddWithValue("@EstadoMercancia", DBNull.Value); else command.Parameters.AddWithValue("@EstadoMercancia", objFood.EstadoMercancia);

                    if (objFood.Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", objFood.Presentacion);

                    if (objFood.UnidadMedida == null) command.Parameters.AddWithValue("@UnidadMedida", DBNull.Value); else command.Parameters.AddWithValue("@UnidadMedida", objFood.UnidadMedida);

                    if (objFood.PesoNetoContenedor == null) command.Parameters.AddWithValue("@PesoNetoContenedor", DBNull.Value); else command.Parameters.AddWithValue("@PesoNetoContenedor", objFood.PesoNetoContenedor);

                    if (objFood.Ingredientes == null) command.Parameters.AddWithValue("@Ingredientes", DBNull.Value); else command.Parameters.AddWithValue("@Ingredientes", objFood.Ingredientes);

                    if (objFood.TipoConservativos == null) command.Parameters.AddWithValue("@TipoConservativos", DBNull.Value); else command.Parameters.AddWithValue("@TipoConservativos", objFood.TipoConservativos);

                    if (objFood.PaisID == null) command.Parameters.AddWithValue("@PaisID", DBNull.Value); else command.Parameters.AddWithValue("@PaisID", objFood.PaisID);

                    if (objFood.Marca == null) command.Parameters.AddWithValue("@Marca", DBNull.Value); else command.Parameters.AddWithValue("@Marca", objFood.Marca);

                    if (objFood.Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", objFood.Link);

                    if (objFood.Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", objFood.Industria);

                    result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[DetalleSolicitudClasificacionFood].";
                    }
                    else
                    {

                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[DetalleSolicitudClasificacionFood]. result: " + result;

                        oResult.IsInserted = false;

                    }
                }
                catch (Exception e)
                {
                    oResult.Response.StatusCode = 501;

                    oResult.Response.Description = e.Message;

                    oResult.IsInserted = false;

                }
            }

            return oResult;
        }
        public static DetalleSolicitudClasificacionFood Populate(string sql)
        {
            DetalleSolicitudClasificacionFood objFood = new DetalleSolicitudClasificacionFood();

            string[] array = sql.Split('~');

            objFood.SolicitudID = int.Parse(array[1]);
            objFood.DetalleFoodID = int.Parse(array[29]);
            objFood.NumeroParte = TryParseString(array[3]);
            objFood.DescripcionEspanol = TryParseString(array[5]);
            objFood.DescripcionIngles = TryParseString(array[7]);
            objFood.EstadoMercancia = TryParseString(array[9]);
            objFood.Presentacion = TryParseString(array[11]);
            objFood.UnidadMedida = TryParseString(array[13]);
            objFood.PesoNetoContenedor = TryParseDecimal(array[17]);
            objFood.Ingredientes = TryParseString(array[19]);
            objFood.TipoConservativos = TryParseString(array[21]);
            objFood.PaisID = TryParseChar(array[23]);
            objFood.Marca = TryParseString(array[25]);
            objFood.Link = TryParseString(array[27]);
            objFood.Industria = TryParseString(array[15]);

            return objFood;
        }
        private static string TryParseString(string value)
        {
            string value_result = "";
            try
            {//null
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = value;
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
        private static char? TryParseChar(string value)
        {
            char? value_result = null;


            try
            {
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = char.Parse(value);
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;

        }
        private static decimal? TryParseDecimal(string value)
        {
            decimal? value_result = null;

            try
            {
                value_result = int.Parse(value);
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
    }

    public class DetalleSolicitudClasificacionQuimico
    {
        #region Properties
        public int SolicitudID { get; set; }
        public int DetalleQuimicoID { get; set; }
        public string NumeroParte { get; set; }
        public string DescripcionEspanol { get; set; }
        public string DescripcionIngles { get; set; }
        public string Sinonimo { get; set; }
        public string NombreComercial { get; set; }
        public string Ingredientes { get; set; }
        public string Uso { get; set; }
        public string Presentacion { get; set; }
        public string Link { get; set; }
        public string Industria { get; set; }
        #endregion
        public static ResultInserted Save(DetalleSolicitudClasificacionQuimico objQuimico)
        {
            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = "";//ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

            int result = 0;
            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try
                { 
                    conn.Open();

                    #region string sql
                    string sql =
        @"
    INSERT INTO [dbo].[DetalleSolicitudClasifiacionQuimico]
               ([SolicitudID]
               ,[DetalleQuimicoID]
               ,[NumeroParte]
               ,[DescripcionEspanol]
               ,[DescripcionIngles]
               ,[Sinonimo]
               ,[NombreComercial]
               ,[Ingredientes]
               ,[Uso]
               ,[Presentacion]
               ,[Link]
               ,[Industria])
         VALUES
               (@SolicitudID
               ,@DetalleQuimicoID
               ,@NumeroParte
               ,@DescripcionEspanol
               ,@DescripcionIngles
               ,@Sinonimo
               ,@NombreComercial
               ,@Ingredientes
               ,@Uso
               ,@Presentacion
               ,@Link
               ,@Industria);
    ";
                    #endregion

                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@SolicitudID", objQuimico.SolicitudID);
                    command.Parameters.AddWithValue("@DetalleQuimicoID", objQuimico.DetalleQuimicoID);
                    command.Parameters.AddWithValue("@NumeroParte", objQuimico.NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", objQuimico.DescripcionEspanol);


                    if (objQuimico.DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", objQuimico.DescripcionIngles);

                    if (objQuimico.Sinonimo == null) command.Parameters.AddWithValue("@Sinonimo", DBNull.Value); else command.Parameters.AddWithValue("@Sinonimo", objQuimico.Sinonimo);

                    if (objQuimico.NombreComercial == null) command.Parameters.AddWithValue("@NombreComercial", DBNull.Value); else command.Parameters.AddWithValue("@NombreComercial", objQuimico.NombreComercial);

                    if (objQuimico.Ingredientes == null) command.Parameters.AddWithValue("@Ingredientes", DBNull.Value); else command.Parameters.AddWithValue("@Ingredientes", objQuimico.Ingredientes);

                    if (objQuimico.Uso == null) command.Parameters.AddWithValue("@Uso", DBNull.Value); else command.Parameters.AddWithValue("@Uso", objQuimico.Uso);

                    if (objQuimico.Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", objQuimico.Presentacion);

                    if (objQuimico.Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", objQuimico.Link);

                    if (objQuimico.Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", objQuimico.Industria);

                    result = command.ExecuteNonQuery();

                    if (result == 1)
                    {

                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[DetalleSolicitudClasificacionQuimico].";

                    }
                    else 
                    {
                        
                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[DetalleSolicitudClasificacionQuimico].";
                        
                        oResult.IsInserted = false;

                    }


                }
                catch(Exception e)
                {
                    oResult.Response.StatusCode = 501;

                    oResult.Response.Description = e.Message;
                    
                    oResult.IsInserted = false;
                    

                }
            }

            return oResult;
        }
        public static DetalleSolicitudClasificacionQuimico Populate(string sql)
        {
            DetalleSolicitudClasificacionQuimico objQuimico = new DetalleSolicitudClasificacionQuimico();

            string[] array = sql.Split('~');

            objQuimico.SolicitudID = int.Parse(array[1]);
            objQuimico.DetalleQuimicoID = int.Parse(array[23]);
            objQuimico.NumeroParte = array[3];
            objQuimico.DescripcionEspanol = array[5];
            objQuimico.DescripcionIngles = TryParseString(array[7]);
            objQuimico.Sinonimo = TryParseString(array[9]);
            objQuimico.NombreComercial = TryParseString(array[11]);
            objQuimico.Ingredientes = TryParseString(array[13]);
            objQuimico.Uso = TryParseString(array[15]);
            objQuimico.Presentacion = TryParseString(array[17]);
            objQuimico.Link = TryParseString(array[21]);
            objQuimico.Industria = TryParseString(array[19]);

            return objQuimico;
        }
        private static string TryParseString(string value)
        {
            string value_result = "";
            try
            {//null
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = value;
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
    }

    public class DetalleSolicitudClasificacionTextil
    {
        #region Properties
        public int SolicitudID { get; set; }
        public int DetalleTextilID { get; set; }
        public string NumeroParte { get; set; }
        public string DescripcionEspanol { get; set; }
        public string DescripcionIngles { get; set; }
        public decimal? PorcentajeInsumos { get; set; }
        public string TipoTela { get; set; }
        public string TerminadoTela { get; set; }
        public decimal? PesoxPie2 { get; set; }
        public string FibraContinuaDescontinua { get; set; }
        public string Presentacion { get; set; }
        public string TipoTejido { get; set; }
        public string Link { get; set; }
        public string Industria { get; set; }
        #endregion
        public static ResultInserted Save(DetalleSolicitudClasificacionTextil objTextil)
        {
            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = "";//ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

            int result = 0;

            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try
                {
                    conn.Open();
                    #region sql string
                    string sql =
        @"
INSERT INTO [dbo].[DetalleSolicitudClasifiacionTextil]
        ([SolicitudID]
        ,[DetalleTextilID]
        ,[NumeroParte]
        ,[DescripcionEspanol]
        ,[DescripcionIngles]
        ,[PorcentajeInsumos]
        ,[TipoTela]
        ,[TerminadoTela]
        ,[PesoxPie2]
        ,[FibraContinuaDescontinua]
        ,[Presentacion]
        ,[TipoTejido]
        ,[Link]
        ,[Industria])
    VALUES
        (@SolicitudID
        ,@DetalleTextilID
        ,@NumeroParte
        ,@DescripcionEspanol
        ,@DescripcionIngles
        ,@PorcentajeInsumos
        ,@TipoTela
        ,@TerminadoTela
        ,@PesoxPie2
        ,@FibraContinuaDescontinua
        ,@Presentacion
        ,@TipoTejido
        ,@Link
        ,@Industria);
";
                    #endregion

                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@SolicitudID", objTextil.SolicitudID);
                    command.Parameters.AddWithValue("@DetalleTextilID", objTextil.DetalleTextilID);
                    command.Parameters.AddWithValue("@NumeroParte", objTextil.NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", objTextil.DescripcionEspanol);


                    if (objTextil.DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", objTextil.DescripcionIngles);

                    if (objTextil.PorcentajeInsumos == null) command.Parameters.AddWithValue("@PorcentajeInsumos", DBNull.Value); else command.Parameters.AddWithValue("@PorcentajeInsumos", objTextil.PorcentajeInsumos);

                    if (objTextil.TipoTela == null) command.Parameters.AddWithValue("@TipoTela", DBNull.Value); else command.Parameters.AddWithValue("@TipoTela", objTextil.TipoTela);

                    if (objTextil.TerminadoTela == null) command.Parameters.AddWithValue("@TerminadoTela", DBNull.Value); else command.Parameters.AddWithValue("@TerminadoTela", objTextil.TerminadoTela);

                    if (objTextil.PesoxPie2 == null) command.Parameters.AddWithValue("@PesoxPie2", DBNull.Value); else command.Parameters.AddWithValue("@PesoxPie2", objTextil.PesoxPie2);

                    if (objTextil.FibraContinuaDescontinua == null) command.Parameters.AddWithValue("@FibraContinuaDescontinua", DBNull.Value); else command.Parameters.AddWithValue("@FibraContinuaDescontinua", objTextil.FibraContinuaDescontinua);

                    if (objTextil.Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", objTextil.Presentacion);

                    if (objTextil.TipoTejido == null) command.Parameters.AddWithValue("@TipoTejido", DBNull.Value); else command.Parameters.AddWithValue("@TipoTejido", objTextil.TipoTejido);

                    if (objTextil.Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", objTextil.Link);

                    if (objTextil.Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", objTextil.Industria);

                    result = command.ExecuteNonQuery();

                    if (result == 1)
                    {

                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[DetalleSolicitudClasificacionTextil].";

                    }
                    else
                    {

                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[DetalleSolicitudClasificacionTextil]. result: " + result;

                        oResult.IsInserted = false;

                    }
                }
                catch (Exception e)
                {

                    oResult.Response.StatusCode = 501;

                    oResult.Response.Description = e.Message;

                    oResult.IsInserted = false;

                }
            }

            return oResult;
        }
        public static DetalleSolicitudClasificacionTextil Populate(string sql)
        {
            DetalleSolicitudClasificacionTextil objTextil = new DetalleSolicitudClasificacionTextil();

            string[] array = sql.Split('~');

            objTextil.SolicitudID = int.Parse(array[1]);
            objTextil.DetalleTextilID = int.Parse(array[27]);
            objTextil.NumeroParte = array[3];
            objTextil.DescripcionEspanol = array[5];
            objTextil.DescripcionIngles = TryParseString(array[7]);
            objTextil.PorcentajeInsumos = TryParseDecimal(array[9]);
            objTextil.TipoTela = TryParseString(array[11]);
            objTextil.TerminadoTela = TryParseString(array[13]);
            objTextil.PesoxPie2 = TryParseDecimal(array[15]);
            objTextil.FibraContinuaDescontinua = TryParseString(array[17]);
            objTextil.Presentacion = TryParseString(array[19]);
            objTextil.TipoTejido = TryParseString(array[21]);
            objTextil.Link = TryParseString(array[25]);
            objTextil.Industria = TryParseString(array[23]);

            return objTextil;
        }
        private static string TryParseString(string value)
        {
            string value_result = "";
            try
            {//null
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = value;
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
        private static decimal? TryParseDecimal(string value)
        {
            decimal? value_result = null;

            try
            {
                value_result = int.Parse(value);
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
    }
    public class DetalleSolicitudClasificacionMetales
    {
        #region Properties
        public int SolicitudID { get; set; }
        public int DetalleMetalesID { get; set; }
        public string NumeroParte { get; set; }
        public string DescripcionEspanol { get; set; }
        public string DescripcionIngles { get; set; }
        public string DescripcionTecnica { get; set; }
        public string Presentacion { get; set; }
        public string Material { get; set; }
        public string TipoAcabado { get; set; }
        public string AleadoInoxidable { get; set; }
        public string RoladosFrioCaliente { get; set; }
        public decimal? Anchura { get; set; }
        public decimal? Espesor { get; set; }
        public decimal? Diametro { get; set; }
        public string Function { get; set; }
        public string Composicion { get; set; }
        public string Funcionamiento { get; set; }
        public string Uso { get; set; }
        public string Link { get; set; }
        public string Industria { get; set; }
        #endregion
        public static ResultInserted Save(DetalleSolicitudClasificacionMetales objMetales)
        {

            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = "";//ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;


            int result = 0;

            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try
                {
                    conn.Open();

                    #region sql string
                    string sql =
        @"
INSERT INTO [dbo].[DetalleSolicitudClasificacionMetales]
           ([SolicitudID]
           ,[DetalleMetales]
           ,[NumeroParte]
           ,[DescripcionEspanol]
           ,[DescripcionIngles]
           ,[DescripcionTenica]
           ,[Presentacion]
           ,[Material]
           ,[TipoAcabado]
           ,[AleadoInoxidable]
           ,[RoladosFrioCaliente]
           ,[Anchura]
           ,[Espesor]
           ,[Diametro]
           ,[Funcion]
           ,[Composicion]
           ,[Funcionamiento]
           ,[Uso]
           ,[Link]
           ,[Industria])
     VALUES
           (@SolicitudID
           ,@DetalleMetalesID
           ,@NumeroParte
           ,@DescripcionEspanol
           ,@DescripcionIngles
           ,@DescripcionTecnica
           ,@Presentacion
           ,@Material
           ,@TipoAcabado
           ,@AleadoInoxidable
           ,@RoladosFrioCaliente
           ,@Anchura
           ,@Espesor
           ,@Diametro
           ,@Function
           ,@Composicion
           ,@Funcionamiento
           ,@Uso
           ,@Link
           ,@Industria);
";
                    #endregion

                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@SolicitudID", objMetales.SolicitudID);
                    command.Parameters.AddWithValue("@DetalleMetalesID", objMetales.DetalleMetalesID);
                    command.Parameters.AddWithValue("@NumeroParte", objMetales.NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", objMetales.DescripcionEspanol);


                    if (objMetales.DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", objMetales.DescripcionIngles);

                    if (objMetales.DescripcionTecnica == null) command.Parameters.AddWithValue("@DescripcionTecnica", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionTecnica", objMetales.DescripcionTecnica);

                    if (objMetales.Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", objMetales.Presentacion);

                    if (objMetales.Material == null) command.Parameters.AddWithValue("@Material", DBNull.Value); else command.Parameters.AddWithValue("@Material", objMetales.Material);

                    if (objMetales.TipoAcabado == null) command.Parameters.AddWithValue("@TipoAcabado", DBNull.Value); else command.Parameters.AddWithValue("@TipoAcabado", objMetales.TipoAcabado);

                    if (objMetales.AleadoInoxidable == null) command.Parameters.AddWithValue("@AleadoInoxidable", DBNull.Value); else command.Parameters.AddWithValue("@AleadoInoxidable", objMetales.AleadoInoxidable);

                    if (objMetales.RoladosFrioCaliente == null) command.Parameters.AddWithValue("@RoladosFrioCaliente", DBNull.Value); else command.Parameters.AddWithValue("@RoladosFrioCaliente", objMetales.RoladosFrioCaliente);

                    if (objMetales.Anchura == null) command.Parameters.AddWithValue("@Anchura", DBNull.Value); else command.Parameters.AddWithValue("@Anchura", objMetales.Anchura);

                    if (objMetales.Espesor == null) command.Parameters.AddWithValue("@Espesor", DBNull.Value); else command.Parameters.AddWithValue("@Espesor", objMetales.Espesor);

                    if (objMetales.Diametro == null) command.Parameters.AddWithValue("@Diametro", DBNull.Value); else command.Parameters.AddWithValue("@Diametro", objMetales.Diametro);

                    if (objMetales.Function == null) command.Parameters.AddWithValue("@Function", DBNull.Value); else command.Parameters.AddWithValue("@Function", objMetales.Function);

                    if (objMetales.Composicion == null) command.Parameters.AddWithValue("@Composicion", DBNull.Value); else command.Parameters.AddWithValue("@Composicion", objMetales.Composicion);

                    if (objMetales.Funcionamiento == null) command.Parameters.AddWithValue("@Funcionamiento", DBNull.Value); else command.Parameters.AddWithValue("@Funcionamiento", objMetales.Funcionamiento);

                    if (objMetales.Uso == null) command.Parameters.AddWithValue("@Uso", DBNull.Value); else command.Parameters.AddWithValue("@Uso", objMetales.Uso);

                    if (objMetales.Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", objMetales.Link);

                    if (objMetales.Industria == null) command.Parameters.AddWithValue("@objMetales", DBNull.Value); else command.Parameters.AddWithValue("@objMetales", objMetales.Industria);

                    result = command.ExecuteNonQuery();

                    if (result == 1)
                    {

                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[DetalleSolicitudClasificacionMetales].";

                    }
                    else
                    {

                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[DetalleSolicitudClasificacionMetales]. result: " + result;

                        oResult.IsInserted = false;

                    }
                }
                catch (Exception e)
                {
                    oResult.Response.StatusCode = 501;

                    oResult.Response.Description = e.Message;

                    oResult.IsInserted = false;

                }
            }

            return oResult;
        }
        public static DetalleSolicitudClasificacionMetales Populate(string sql)
        {
            DetalleSolicitudClasificacionMetales objMetales = new DetalleSolicitudClasificacionMetales();

            string[] array = sql.Split('~');

            objMetales.SolicitudID = int.Parse(array[1]);
            objMetales.DetalleMetalesID = int.Parse(array[39]);
            objMetales.NumeroParte = array[3];
            objMetales.DescripcionEspanol = array[5];
            objMetales.DescripcionIngles = TryParseString(array[7]);
            objMetales.DescripcionTecnica = TryParseString(array[9]);
            objMetales.Presentacion = TryParseString(array[11]);
            objMetales.Material = TryParseString(array[13]);
            objMetales.TipoAcabado = TryParseString(array[15]);
            objMetales.AleadoInoxidable = TryParseString(array[17]);
            objMetales.RoladosFrioCaliente = TryParseString(array[19]);
            objMetales.Anchura = TryParseDecimal(array[21]);
            objMetales.Espesor = TryParseDecimal(array[23]);
            objMetales.Diametro = TryParseDecimal(array[25]);
            objMetales.Function = TryParseString(array[27]);
            objMetales.Composicion = TryParseString(array[29]);
            objMetales.Funcionamiento = TryParseString(array[31]);
            objMetales.Uso = TryParseString(array[33]);
            objMetales.Link = TryParseString(array[37]);
            objMetales.Industria = TryParseString(array[35]);

            return objMetales;
        }
        private static string TryParseString(string value)
        {
            string value_result = "";
            try
            {//null
                if (value == "")
                {
                    value_result = null;
                }
                else
                {
                    value_result = value;
                }
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
        private static decimal? TryParseDecimal(string value)
        {
            decimal? value_result = null;

            try
            {
                value_result = int.Parse(value);
            }
            catch (FormatException)
            {
                value_result = null;
            };

            return value_result;
        }
    }
    public class ResultInserted
    {
        public bool IsInserted { get; set; }

        public Message Response { get; set; }

    }
    public class Message
    {
        public int StatusCode { get; set; }
        public string Description { get; set; }
    }
}
