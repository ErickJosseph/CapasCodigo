using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class Conexion
    {


        //public static string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
        //"Initial Catalog=WICMonitoriaDBDev; " +
        //"User Id=userMonitoria; Pwd=123456;" +                                    
        //"trustservercertificate=True";

        public static string cadena = "Server=DESKTOP-7RC496P\\MSSQLSERVER01;Database=WICMonitoriaDBDev;Trusted_Connection=True;Application Name=CapasCodigo";

        /*
		------creacion de la tabla Regiones 

		CREATE TABLE REGIONES
		(
			RegionId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
			RegionName NVARCHAR(100) NOT NULL,
			[Enabled] bit NOT NULL  --- 1 : ACTIVO; 0: DESACTIVADO  
		)



		--==================== LISTA DE PROCEDIMIENTOS ===============--

		--REGISTRAR REGION 

		CREATE PROCEDURE SP_CrearRegion
			@RegionName NVARCHAR(100),
			@Enabled BIT

		AS 
		BEGIN

			INSERT INTO REGIONES(RegionName, [Enabled])
			VALUES (@RegionName, @Enabled)

		END

		--LEER REGION 

		CREATE PROCEDURE SP_ListarRegion
	
			@RegionId INT = 0

		AS 
		BEGIN

			IF(@RegionId = 0)
			BEGIN 
				SELECT RegionId, RegionName, [Enabled]
				FROM REGIONES
			END
			ELSE 
			BEGIN 
		
				SELECT RegionId, RegionName, [Enabled]
				FROM REGIONES
				WHERE RegionId = @RegionId
				AND [Enabled] = 1
 
			END

		END

		--ACTUALIZAR REGION 

		CREATE PROCEDURE SP_ActualizarRegion  --sp_helptext 'SP_ActualizarRegion' 
	
			@RegionId INT,
			@RegionName NVARCHAR(100),
			@Enabled BIT

		AS 
		BEGIN
		
				UPDATE R SET  
				RegionName =@RegionName, 
				[Enabled] = @Enabled --SELECT RegionId, RegionName, [Enabled]
				FROM REGIONES R
				WHERE RegionId = @RegionId

		END


		--ELIMINAR REGION 


		CREATE PROCEDURE SP_EliminarRegion
	
			@RegionId INT




		AS 
		BEGIN
		
				UPDATE R SET  
				[Enabled] = 0 --SELECT RegionId, RegionName, [Enabled]
				FROM REGIONES R
				WHERE RegionId = @RegionId

		END












         
         
         
         */
    }
}
