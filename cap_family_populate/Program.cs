using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_family_populate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*spInsertarDatos 'SolicitudID~108966~NumeroParte~00600-69~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~DescripcionTecnica~~Presentacion~PIEZA~TipoAcabado~~Funcion~H-1 Hardener produces a relatively flexible ink film and is suitable for most Marabu inks. H1 has a slower hardening time when compared to H2 film and does not yellow upon UV exposure~Material~~Composicion~~Voltaje~~Potencia~~Capacidad~~DondeSeUtiliza~en el proceso productivo de cateters de hemodialisis~Marca~~Modelo~~Serie~~TipoMaquinaria~~Industria~Medica~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleGeneralID~1','DetalleSolicitudClasificacionGeneral'*/

            /**/
            
            /*SolicitudID~108966~NumeroParte~06001-74~DescripcionEspanol~SOLVENTE THINNER~DescripcionIngles~MARBU TPV2 THINNER FOR TPR INK~DescripcionTecnica~~Presentacion~LITRO~TipoAcabado~~Funcion~Pad printing auxiliary~Material~~Composicion~~Voltaje~~Potencia~~Capacidad~~DondeSeUtiliza~en el proceso productivo de cateters de hemodialisis~Marca~~Modelo~~Serie~~TipoMaquinaria~~Industria~Medica~Link~https://aaprintsupplyco.com/products/tpv-ink-thinner~DetalleGeneralID~2*/
            
            /**/
            
            
            string sql_one = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~AA0610~NoParte~00600-68~DescripcionEspañol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~SolicitudID~108959~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_two = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~AA0610~NoParte~06001-73~DescripcionEspañol~SOLVENTE THINNER~DescripcionIngles~MARBU TPV2 THINNER FOR TPR INK~SolicitudID~108959~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_three_0500 = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~0500~NoParte~00600-69~DescripcionEspañol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~SolicitudID~108966~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_four_0500 = @"RegimenID~1~OperacionIE~I~TipoMercanciaID~1~FamiliaID~5~CustomerID~0500~NoParte~06001-74~DescripcionEspañol~SOLVENTE THINNER~DescripcionIngles~MARBU TPV2 THINNER FOR TPR INK~SolicitudID~108966~Industria~Medica~Justificacion~Clasificacion Inicial";

            string sql_general_one = @"SolicitudID~108961~NumeroParte~00600-69~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~DescripcionTecnica~~Presentacion~PIEZA~TipoAcabado~~Funcion~H-1 Hardener produces a relatively flexible ink film and is suitable for most Marabu inks. H1 has a slower hardening time when compared to H2 film and does not yellow upon UV exposure~Material~~Composicion~~Voltaje~~Potencia~~Capacidad~~DondeSeUtiliza~en el proceso productivo de cateters de hemodialisis~Marca~~Modelo~~Serie~~TipoMaquinaria~~Industria~Medica~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleGeneralID~1";

            string sql_food_one = @"SolicitudID~108962~NumeroParte~00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~EstadoMercancia~~Presentacion~PIEZA~UnidadMedida~~Industria~~PesoNetoContenedor~~Ingredientes~~TipoConservativos~~PaisID~~Marca~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleFoodID~1";

            string sql_metal_one = @"SolicitudID~108963~NumeroParte~MTL00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~DescripcionTenica~~Presentacion~PIEZA~Material~~TipoAcabado~~AleadoInoxidable~~RoladosFrioCaliente~~Anchura~~Espesor~~Diametro~~Funcion~~Composicion~~Funcionamiento~~Uso~~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleMetales~1";

            string sql_quimico_one = @"SolicitudID~108964~NumeroParte~00600-80~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~Sinonimo~~NombreComercial~~Ingredientes~~Uso~~Presentacion~PIEZA~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleQuimicoID~1";

            string sql_textil_one = @"SolicitudID~108965~NumeroParte~TXL00600-69~DescripcionEspanol~ENDURECEDOR PARA TINTA~DescripcionIngles~HARDNER MARABU H1~PorcentajeInsumos~~TipoTela~~TerminadoTela~~PesoxPie2~~FibraContinuaDescontinua~~Presentacion~PIEZA~TipoTejido~~Industria~~Link~https://screenprintsupply.com/products/h-1-slow-ink-hardener-100ml-tube~DetalleTextilID~1";

            //var objGeneral = new DetalleSolicitudClasificacionGeneral(sql_general_one);

            //ResultInserted objGeneralResult = objGeneral.Save();

            var objClasificacion = new ClasificacionMercancia(sql_four_0500);

            ResultInserted objClasificacionResult = objClasificacion.Save();

            DetalleSolicitudClasificacionFood objFood = new DetalleSolicitudClasificacionFood(sql_food_one);

            ResultInserted objFoodResult = objFood.Save();

            DetalleSolicitudClasificacionQuimico objQuimico = new DetalleSolicitudClasificacionQuimico(sql_quimico_one);

            ResultInserted objQuimicoResult = objQuimico.Save();

            DetalleSolicitudClasificacionTextil objTextil = new DetalleSolicitudClasificacionTextil(sql_textil_one);

            ResultInserted objTextilResult = objTextil.Save();

            DetalleSolicitudClasificacionMetales objMetal = new DetalleSolicitudClasificacionMetales(sql_metal_one);

            ResultInserted objMetalResult = objMetal.Save();

        }
    }
    public class ClasificacionMercancia
    {
        public ClasificacionMercancia(string sql)
        {
            string[] array = sql.Split('~');

            CustomerID = array[9];
            NoParte = array[11];
            UserClasifico = null;
            FraccionMX = null;
            FraccionUS = null;
            DescripcionEspañol = TryParseString(array[13]);
            DescripcionIngles = TryParseString(array[15]);
            CasoNo = null;
            ADV = null;
            TLCAN = null;
            PROSECXIV = null;
            Notas = null;
            Requisitos = null;
            Permisos = null;
            Restricciones = null;
            Anexos = null;
            FechaEnvio = null;
            Clasificado = null;
            OperacionIE = char.Parse(array[3]);
            RegimenID = int.Parse(array[1]);
            TipoMercanciaID = int.Parse(array[5]);
            FamiliaID = int.Parse(array[7]);
            SolicitudID = int.Parse(array[17]);
            Justificacion = TryParseString(array[21]);
            Industria = TryParseString(array[19]);
            Enviada = null;
            FechaClasifico = null; 
            NICO = null;
        }
        public string CustomerID { get; set; }//NOT NULL
        public string NoParte { get; set; }//NOT NULL
        public int? UserClasifico { get; set; }//NULL
        public string FraccionMX { get; set; }//NULL
        public string FraccionUS { get; set; }//NULL
        public string DescripcionEspañol { get; set; }//NULL
        public string DescripcionIngles { get; set; }//NULL
        public string CasoNo { get; set; }//NULL
        public string ADV { get; set; }//NULL
        public string TLCAN { get; set; }//NULL
        public string PROSECXIV { get; set; }//NULL
        public string Notas { get; set; }//NULL
        public string Requisitos { get; set; }//NULL
        public string Permisos { get; set; }//NULL
        public string Restricciones { get; set; }//NULL
        public string Anexos { get; set; }//NULL
        public DateTime? FechaEnvio { get; set; }//NULL
        public bool? Clasificado { get; set; }//NULL
        public char OperacionIE { get; set; }//NOT NULL
        public int RegimenID { get; set; }//NOT NULL
        public int TipoMercanciaID { get; set; }//NOT NULL
        public int FamiliaID { get; set; }//NOT NULL
        public int? SolicitudID { get; set; }//NULL
        public string Justificacion { get; set; }//NULL
        public bool? Enviada { get; set; }//NULL
        public string Industria { get; set; }//NULL
        public DateTime? FechaClasifico { get; set; }//NULL
        public string NICO { get; set; }//NULL
        public ResultInserted Save()
        {
            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

            int result = 0;

            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try
                {
                    conn.Open();
                    string sql =
        @"
Insert into 
SILA.dbo.ClasificacionMercancia 
(
    CustomerID
    , NoParte
    , UserClasifico
    , FraccionMX
    , FraccionUS
    , DescripcionEspañol
    , DescripcionIngles
    , CasoNo
    , ADV
    , TLCAN
    , PROSECXIV
    , Notas
    , Requisitos
    , Permisos
    , Restricciones
    , Anexos
    , FechaEnvio
    , Clasificado
    , OperacionIE
    , RegimenID
    , TipoMercanciaID
    , FamiliaID
    , SolicitudID
    , Justificacion
    , Enviada
    , FechaClasifico
    , NICO
) 
values 
(
    @CustomerID--<--
    , @NoParte--<--
    , @UserClasifico
    , @FraccionMX
    , @FraccionUS
    , @DescripcionEspañol--<--
    , @DescripcionIngles--<--
    , @CasoNo
    , @ADV
    , @TLCAN
    , @PROSECXIV
    , @Notas
    , @Requisitos
    , @Permisos
    , @Restricciones
    , @Anexos
    , @FechaEnvio
    , @Clasificado
    , @OperacionIE
    , @RegimenID--<--
    , @TipoMercanciaID--<--
    , @FamiliaID--<--
    , @SolicitudID
    , @Justificacion--<--
    , @Enviada
    , @FechaClasifico
    , @NICO
)
;
";
                   
                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@NoParte", NoParte);
                    if (UserClasifico == null) command.Parameters.AddWithValue("@UserClasifico", DBNull.Value); else command.Parameters.AddWithValue("@UserClasifico", UserClasifico);
                    if (FraccionMX == null) command.Parameters.AddWithValue("@FraccionMX", DBNull.Value); else command.Parameters.AddWithValue("@FraccionMX", FraccionMX);
                    if (FraccionUS == null) command.Parameters.AddWithValue("@FraccionUS", DBNull.Value); else command.Parameters.AddWithValue("@FraccionUS", FraccionUS);
                    if (DescripcionEspañol == null) command.Parameters.AddWithValue("@DescripcionEspañol", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionEspañol", DescripcionEspañol);
                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);
                    if (CasoNo == null) command.Parameters.AddWithValue("@CasoNo", DBNull.Value); else command.Parameters.AddWithValue("@CasoNo", CasoNo);
                    if (ADV == null) command.Parameters.AddWithValue("@ADV", DBNull.Value); else command.Parameters.AddWithValue("@ADV", ADV);
                    if (TLCAN == null) command.Parameters.AddWithValue("@TLCAN", DBNull.Value); else command.Parameters.AddWithValue("@TLCAN", TLCAN);
                    if (PROSECXIV == null) command.Parameters.AddWithValue("@PROSECXIV", DBNull.Value); else command.Parameters.AddWithValue("@PROSECXIV", PROSECXIV);
                    if (Notas == null) command.Parameters.AddWithValue("@Notas", DBNull.Value); else command.Parameters.AddWithValue("@Notas", Notas);
                    if (Requisitos == null) command.Parameters.AddWithValue("@Requisitos", DBNull.Value); else command.Parameters.AddWithValue("@Requisitos", Requisitos);
                    if (Permisos == null) command.Parameters.AddWithValue("@Permisos", DBNull.Value); else command.Parameters.AddWithValue("@Permisos", Permisos);
                    if (Restricciones == null) command.Parameters.AddWithValue("@Restricciones", DBNull.Value); else command.Parameters.AddWithValue("@Restricciones", Restricciones);
                    if (Anexos == null) command.Parameters.AddWithValue("@Anexos", DBNull.Value); else command.Parameters.AddWithValue("@Anexos", Anexos);
                    if (FechaEnvio == null) command.Parameters.AddWithValue("@FechaEnvio", DBNull.Value); else command.Parameters.AddWithValue("@FechaEnvio", FechaEnvio);
                    if (Clasificado == null) command.Parameters.AddWithValue("@Clasificado", DBNull.Value); else command.Parameters.AddWithValue("@Clasificado", Clasificado);
                    command.Parameters.AddWithValue("@OperacionIE", OperacionIE);
                    command.Parameters.AddWithValue("@RegimenID", RegimenID);
                    command.Parameters.AddWithValue("@TipoMercanciaID", TipoMercanciaID);
                    command.Parameters.AddWithValue("@FamiliaID", FamiliaID);
                    if (SolicitudID == null) command.Parameters.AddWithValue("@SolicitudID", DBNull.Value); else command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    if (Enviada == null) command.Parameters.AddWithValue("@Enviada", DBNull.Value); else command.Parameters.AddWithValue("@Enviada", Enviada);
                    
                    if (Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", Industria);
                    
                    if (Justificacion == null) command.Parameters.AddWithValue("@Justificacion", DBNull.Value); else command.Parameters.AddWithValue("@Justificacion", Justificacion);
                    if (FechaClasifico == null) command.Parameters.AddWithValue("@FechaClasifico", DBNull.Value); else command.Parameters.AddWithValue("@FechaClasifico", FechaClasifico);
                    if (NICO == null) command.Parameters.AddWithValue("@NICO", DBNull.Value); else command.Parameters.AddWithValue("@NICO", NICO);
                    

                    result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[ClasificacionMercancia].";
                    }
                    else
                    {

                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[ClasificacionMercancia]. result: " + result;

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
    public class DetalleFamiliasMaster
    { 

    }
    public class DetalleSolicitudClasificacionGeneral
    {
        public DetalleSolicitudClasificacionGeneral(string value) 
        {
            Populate(value);
        }
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
        public ResultInserted Save()
        {

            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;
            
            int result = 0;
            
            using (SqlConnection conn = new SqlConnection(_STRING_CONNECTION))
            {
                try {
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

                    command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    command.Parameters.AddWithValue("@DetalleGeneralID", DetalleGeneralID);
                    command.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", DescripcionEspanol);

                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);
                    if (DescripcionTecnica == null) command.Parameters.AddWithValue("@DescripcionTecnica", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionTecnica", DescripcionTecnica);
                    if (Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", Presentacion);
                    if (TipoAcabado == null) command.Parameters.AddWithValue("@TipoAcabado", DBNull.Value); else command.Parameters.AddWithValue("@TipoAcabado", TipoAcabado);
                    if (Function == null) command.Parameters.AddWithValue("@Funcion", DBNull.Value); else command.Parameters.AddWithValue("@Funcion", Function);
                    if (Material == null) command.Parameters.AddWithValue("@Material", DBNull.Value); else command.Parameters.AddWithValue("@Material", Material);
                    if (Composicion == null) command.Parameters.AddWithValue("@Composicion", DBNull.Value); else command.Parameters.AddWithValue("@Composicion", Composicion);
                    if (Voltaje == null) command.Parameters.AddWithValue("@Voltaje", DBNull.Value); else command.Parameters.AddWithValue("@Voltaje", Voltaje);
                    if (Potencia == null) command.Parameters.AddWithValue("@Potencia", DBNull.Value); else command.Parameters.AddWithValue("@Potencia", Potencia);
                    if (Capacidad == null) command.Parameters.AddWithValue("@Capacidad", DBNull.Value); else command.Parameters.AddWithValue("@Capacidad", Capacidad);
                    if (DondeSeUtiliza == null) command.Parameters.AddWithValue("@DondeSeUtiliza", DBNull.Value); else command.Parameters.AddWithValue("@DondeSeUtiliza", DondeSeUtiliza);
                    if (Marca == null) command.Parameters.AddWithValue("@Marca", DBNull.Value); else command.Parameters.AddWithValue("@Marca", Marca);
                    if (Modelo == null) command.Parameters.AddWithValue("@Modelo", DBNull.Value); else command.Parameters.AddWithValue("@Modelo", Modelo);
                    if (Serie == null) command.Parameters.AddWithValue("@Serie", DBNull.Value); else command.Parameters.AddWithValue("@Serie", Serie);
                    if (TipoMaquinaria == null) command.Parameters.AddWithValue("@TipoMaquinaria", DBNull.Value); else command.Parameters.AddWithValue("@TipoMaquinaria", TipoMaquinaria);
                    if (Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", Link);
                    if (Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", Industria);

                    result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        oResult.IsInserted = true;

                        oResult.Response.StatusCode = 200;

                        oResult.Response.Description = "Se insertó registro exitosamente en Tabla [SILA].[dbo].[DetalleSolicitudClasificacionGeneral].";
                    }
                    else
                    {

                        oResult.Response.StatusCode = 401;

                        oResult.Response.Description = "Hubo un error inesperado y el registro no se insertó en la Tabla [SILA].[dbo].[DetalleSolicitudClasificacionGeneral]. result: " + result;

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
        private void Populate(string sql)
        {

            string[] array = sql.Split('~');

            SolicitudID = int.Parse(array[1]);
            DetalleGeneralID = int.Parse(array[41]);
            NumeroParte = array[3];
            DescripcionEspanol = array[5];
            DescripcionIngles = TryParseString(array[7]);
            DescripcionTecnica = TryParseString(array[9]);
            Presentacion = TryParseString(array[11]);
            TipoAcabado = TryParseString(array[13]);
            Function = TryParseString(array[15]);
            Material = TryParseString(array[17]);
            Composicion = TryParseString(array[19]);
            Voltaje = TryParseString(array[21]);
            Potencia = TryParseString(array[23]);
            Capacidad = TryParseString(array[25]);
            DondeSeUtiliza = TryParseString(array[27]);
            Marca = TryParseString(array[29]);
            Modelo = TryParseString(array[31]);
            Serie = TryParseString(array[33]);
            TipoMaquinaria = TryParseString(array[35]);
            Link = TryParseString(array[39]);
            Industria = TryParseString(array[37]);

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
        public DetalleSolicitudClasificacionFood(string sql) 
        {
            string[] array = sql.Split('~');

            SolicitudID = int.Parse(array[1]);
            DetalleFoodID = int.Parse(array[29]);
            NumeroParte = TryParseString(array[3]);
            DescripcionEspanol = TryParseString(array[5]);
            DescripcionIngles = TryParseString(array[7]);
            EstadoMercancia = TryParseString(array[9]);
            Presentacion = TryParseString(array[11]);
            UnidadMedida = TryParseString(array[13]);
            PesoNetoContenedor = TryParseDecimal(array[17]);
            Ingredientes = TryParseString(array[19]);
            TipoConservativos = TryParseString(array[21]);
            PaisID = TryParseChar(array[23]);
            Marca = TryParseString(array[25]);
            Link = TryParseString(array[27]);
            Industria = TryParseString(array[15]);
        }
        public ResultInserted Save()
        {

            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

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

                    command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    command.Parameters.AddWithValue("@DetalleFoodID", DetalleFoodID);
                    command.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", DescripcionEspanol);

                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);

                    if (EstadoMercancia == null) command.Parameters.AddWithValue("@EstadoMercancia", DBNull.Value); else command.Parameters.AddWithValue("@EstadoMercancia", EstadoMercancia);

                    if (Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", Presentacion);

                    if (UnidadMedida == null) command.Parameters.AddWithValue("@UnidadMedida", DBNull.Value); else command.Parameters.AddWithValue("@UnidadMedida", UnidadMedida);

                    if (PesoNetoContenedor == null) command.Parameters.AddWithValue("@PesoNetoContenedor", DBNull.Value); else command.Parameters.AddWithValue("@PesoNetoContenedor", PesoNetoContenedor);

                    if (Ingredientes == null) command.Parameters.AddWithValue("@Ingredientes", DBNull.Value); else command.Parameters.AddWithValue("@Ingredientes", Ingredientes);

                    if (TipoConservativos == null) command.Parameters.AddWithValue("@TipoConservativos", DBNull.Value); else command.Parameters.AddWithValue("@TipoConservativos", TipoConservativos);

                    if (PaisID == null) command.Parameters.AddWithValue("@PaisID", DBNull.Value); else command.Parameters.AddWithValue("@PaisID", PaisID);

                    if (Marca == null) command.Parameters.AddWithValue("@Marca", DBNull.Value); else command.Parameters.AddWithValue("@Marca", Marca);

                    if (Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", Link);

                    if (Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", Industria);

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
        public DetalleSolicitudClasificacionQuimico(string sql)
        {
            string[] array = sql.Split('~');

            SolicitudID = int.Parse(array[1]);
            DetalleQuimicoID = int.Parse(array[23]);
            NumeroParte = array[3];
            DescripcionEspanol = array[5];
            DescripcionIngles = TryParseString(array[7]);
            Sinonimo = TryParseString(array[9]);
            NombreComercial = TryParseString(array[11]);
            Ingredientes = TryParseString(array[13]);
            Uso = TryParseString(array[15]);
            Presentacion = TryParseString(array[17]);
            Link = TryParseString(array[21]);
            Industria = TryParseString(array[19]);
        }
        #endregion
        public ResultInserted Save()
        {
            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

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

                    command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    command.Parameters.AddWithValue("@DetalleQuimicoID", DetalleQuimicoID);
                    command.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", DescripcionEspanol);


                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);

                    if (Sinonimo == null) command.Parameters.AddWithValue("@Sinonimo", DBNull.Value); else command.Parameters.AddWithValue("@Sinonimo", Sinonimo);

                    if (NombreComercial == null) command.Parameters.AddWithValue("@NombreComercial", DBNull.Value); else command.Parameters.AddWithValue("@NombreComercial", NombreComercial);

                    if (Ingredientes == null) command.Parameters.AddWithValue("@Ingredientes", DBNull.Value); else command.Parameters.AddWithValue("@Ingredientes", Ingredientes);

                    if (Uso == null) command.Parameters.AddWithValue("@Uso", DBNull.Value); else command.Parameters.AddWithValue("@Uso", Uso);

                    if (Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", Presentacion);

                    if (Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", Link);

                    if (Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", Industria);

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
        public DetalleSolicitudClasificacionTextil(string sql) 
        {
            string[] array = sql.Split('~');

            SolicitudID = int.Parse(array[1]);
            DetalleTextilID = int.Parse(array[27]);
            NumeroParte = array[3];
            DescripcionEspanol = array[5];
            DescripcionIngles = TryParseString(array[7]);
            PorcentajeInsumos = TryParseDecimal(array[9]);
            TipoTela = TryParseString(array[11]);
            TerminadoTela = TryParseString(array[13]);
            PesoxPie2 = TryParseDecimal(array[15]);
            FibraContinuaDescontinua = TryParseString(array[17]);
            Presentacion = TryParseString(array[19]);
            TipoTejido = TryParseString(array[21]);
            Link = TryParseString(array[25]);
            Industria = TryParseString(array[23]);
        }
        #endregion
        public ResultInserted Save()
        {
            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;

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

                    command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    command.Parameters.AddWithValue("@DetalleTextilID", DetalleTextilID);
                    command.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", DescripcionEspanol);


                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);

                    if (PorcentajeInsumos == null) command.Parameters.AddWithValue("@PorcentajeInsumos", DBNull.Value); else command.Parameters.AddWithValue("@PorcentajeInsumos", PorcentajeInsumos);

                    if (TipoTela == null) command.Parameters.AddWithValue("@TipoTela", DBNull.Value); else command.Parameters.AddWithValue("@TipoTela", TipoTela);

                    if (TerminadoTela == null) command.Parameters.AddWithValue("@TerminadoTela", DBNull.Value); else command.Parameters.AddWithValue("@TerminadoTela", TerminadoTela);

                    if (PesoxPie2 == null) command.Parameters.AddWithValue("@PesoxPie2", DBNull.Value); else command.Parameters.AddWithValue("@PesoxPie2", PesoxPie2);

                    if (FibraContinuaDescontinua == null) command.Parameters.AddWithValue("@FibraContinuaDescontinua", DBNull.Value); else command.Parameters.AddWithValue("@FibraContinuaDescontinua", FibraContinuaDescontinua);

                    if (Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", Presentacion);

                    if (TipoTejido == null) command.Parameters.AddWithValue("@TipoTejido", DBNull.Value); else command.Parameters.AddWithValue("@TipoTejido",TipoTejido);

                    if (Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", Link);

                    if (Industria == null) command.Parameters.AddWithValue("@Industria", DBNull.Value); else command.Parameters.AddWithValue("@Industria", Industria);

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
        public DetalleSolicitudClasificacionMetales(string sql) 
        {
            string[] array = sql.Split('~');

            SolicitudID = int.Parse(array[1]);
            DetalleMetalesID = int.Parse(array[39]);
            NumeroParte = array[3];
            DescripcionEspanol = array[5];
            DescripcionIngles = TryParseString(array[7]);
            DescripcionTecnica = TryParseString(array[9]);
            Presentacion = TryParseString(array[11]);
            Material = TryParseString(array[13]);
            TipoAcabado = TryParseString(array[15]);
            AleadoInoxidable = TryParseString(array[17]);
            RoladosFrioCaliente = TryParseString(array[19]);
            Anchura = TryParseDecimal(array[21]);
            Espesor = TryParseDecimal(array[23]);
            Diametro = TryParseDecimal(array[25]);
            Function = TryParseString(array[27]);
            Composicion = TryParseString(array[29]);
            Funcionamiento = TryParseString(array[31]);
            Uso = TryParseString(array[33]);
            Link = TryParseString(array[37]);
            Industria = TryParseString(array[35]);
        }
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
        public ResultInserted Save()
        {

            ResultInserted oResult = new ResultInserted();

            oResult.Response = new Message();

            string _STRING_CONNECTION = ConfigurationManager.ConnectionStrings["SILAConnectionString"].ConnectionString;


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

                    command.Parameters.AddWithValue("@SolicitudID", SolicitudID);
                    command.Parameters.AddWithValue("@DetalleMetalesID", DetalleMetalesID);
                    command.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                    command.Parameters.AddWithValue("@DescripcionEspanol", DescripcionEspanol);


                    if (DescripcionIngles == null) command.Parameters.AddWithValue("@DescripcionIngles", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionIngles", DescripcionIngles);

                    if (DescripcionTecnica == null) command.Parameters.AddWithValue("@DescripcionTecnica", DBNull.Value); else command.Parameters.AddWithValue("@DescripcionTecnica", DescripcionTecnica);

                    if (Presentacion == null) command.Parameters.AddWithValue("@Presentacion", DBNull.Value); else command.Parameters.AddWithValue("@Presentacion", Presentacion);

                    if (Material == null) command.Parameters.AddWithValue("@Material", DBNull.Value); else command.Parameters.AddWithValue("@Material", Material);

                    if (TipoAcabado == null) command.Parameters.AddWithValue("@TipoAcabado", DBNull.Value); else command.Parameters.AddWithValue("@TipoAcabado", TipoAcabado);

                    if (AleadoInoxidable == null) command.Parameters.AddWithValue("@AleadoInoxidable", DBNull.Value); else command.Parameters.AddWithValue("@AleadoInoxidable", AleadoInoxidable);

                    if (RoladosFrioCaliente == null) command.Parameters.AddWithValue("@RoladosFrioCaliente", DBNull.Value); else command.Parameters.AddWithValue("@RoladosFrioCaliente", RoladosFrioCaliente);

                    if (Anchura == null) command.Parameters.AddWithValue("@Anchura", DBNull.Value); else command.Parameters.AddWithValue("@Anchura", Anchura);

                    if (Espesor == null) command.Parameters.AddWithValue("@Espesor", DBNull.Value); else command.Parameters.AddWithValue("@Espesor", Espesor);

                    if (Diametro == null) command.Parameters.AddWithValue("@Diametro", DBNull.Value); else command.Parameters.AddWithValue("@Diametro", Diametro);

                    if (Function == null) command.Parameters.AddWithValue("@Function", DBNull.Value); else command.Parameters.AddWithValue("@Function", Function);

                    if (Composicion == null) command.Parameters.AddWithValue("@Composicion", DBNull.Value); else command.Parameters.AddWithValue("@Composicion", Composicion);

                    if (Funcionamiento == null) command.Parameters.AddWithValue("@Funcionamiento", DBNull.Value); else command.Parameters.AddWithValue("@Funcionamiento", Funcionamiento);

                    if (Uso == null) command.Parameters.AddWithValue("@Uso", DBNull.Value); else command.Parameters.AddWithValue("@Uso", Uso);

                    if (Link == null) command.Parameters.AddWithValue("@Link", DBNull.Value); else command.Parameters.AddWithValue("@Link", Link);

                    if (Industria == null) command.Parameters.AddWithValue("@objMetales", DBNull.Value); else command.Parameters.AddWithValue("@objMetales", Industria);

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
