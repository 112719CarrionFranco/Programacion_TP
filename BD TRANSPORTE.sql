Create Database Transporte_Cargas

Create table TIPO_CARGA(
ID_TIPO_CARGA int identity(1,1),
NOMBRE varchar(50),
PESO DECIMAL(4,2)
constraint PK_CODIGO PRIMARY KEY(ID_TIPO_CARGA))

CREATE TABLE CARGAS(
ID_CARGA INT IDENTITY(1,1),
FECHA DATETIME,
PESO DECIMAL(4,2),
PATENTE VARCHAR(7),
TOTAL_KG DECIMAL(4,2)
CONSTRAINT PK_ID_CARGA PRIMARY KEY(ID_CARGA)
CONSTRAINT FK_PATENTE FOREIGN KEY(PATENTE)
REFERENCES CAMIONES(PATENTE))

CREATE TABLE CAMIONES(
PATENTE VARCHAR(7),
ESTADO BIT,
PESO_MAXIMO DECIMAL(4,2)
CONSTRAINT PK_PATENTE PRIMARY KEY (PATENTE))

CREATE TABLE DETALLE_CARGAS(
DETALLE_NRO INT,
ID_CARGA INT,
ID_TIPO_CARGA INT,
CANTIDAD INT,
PESO INT
CONSTRAINT PK_DETALLE_NRO PRIMARY KEY (DETALLE_NRO)
CONSTRAINT FK_ID_CARGA FOREIGN KEY (ID_CARGA)
REFERENCES CARGAS(ID_CARGA),
CONSTRAINT FK_ID_TIPO_CARGA FOREIGN KEY (ID_TIPO_CARGA)
REFERENCES TIPO_CARGA(ID_TIPO_CARGA))

SET IDENTITY_INSERT  DETALLE_CARGAS OFF
	

CREATE TABLE USUARIOS(
ID_USUARIO INT IDENTITY,
USUARIO VARCHAR(50),
CONTRASEŅA VARCHAR(50)
CONSTRAINT PK_USUARIOS PRIMARY KEY(ID_USUARIO))

set dateformat dmy
ALTER PROCEDURE [dbo].SP_CONSULTAR_CARGAS
	@fecha_desde Date,
	@fecha_hasta Date,
	@patente varchar(7)
AS

BEGIN
	SELECT * FROM CARGAS
	WHERE 
	 ( FECHA BETWEEN @fecha_desde AND @fecha_hasta )
			OR PATENTE LIKE '%' + @patente + '%'
	 
END
--
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPO_CARGAS]
AS
BEGIN
	
	SELECT * from TIPO_CARGA;
END
--
ALTER PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@ID_CARGA int,
	@DETALLE_NRO int, 
	@ID_TIPO_CARGA int, 
	@CANTIDAD int,
	@PESO int
AS
BEGIN
	INSERT INTO DETALLE_CARGAS(DETALLE_NRO,ID_CARGA, ID_TIPO_CARGA, CANTIDAD,PESO)
    VALUES (@DETALLE_NRO, @ID_CARGA, @ID_TIPO_CARGA, @CANTIDAD,@PESO);
  
END
--
ALTER PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@PATENTE varchar(7), 
	@TOTAL_KG int,
	@next int output,
	@ID_CARGA int OUTPUT
AS
BEGIN
	INSERT INTO CARGAS(FECHA, PATENTE, TOTAL_KG)
    VALUES (GETDATE(), @PATENTE, @TOTAL_KG);
    SET @ID_CARGA = SCOPE_IDENTITY();
	SET @next = (SELECT MAX(DETALLE_NRO)+1  FROM DETALLE_CARGAS);

END

INSERT INTO CARGAS(FECHA, PATENTE, TOTAL_KG)
    VALUES (GETDATE(), 'AE567PO', 12500);


--
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(ID_CARGA)+1  FROM CARGAS);
END
--
ALTER procedure [dbo].[SP_ELIMINAR_CARGA] 26
@id_Carga int
AS
	BEGIN
		DELETE CARGAS WHERE ID_CARGA = @ID_CARGA
	END


ALTER procedure [dbo].[SP_ELIMINAR_DETALLE_CARGA] 26
@id_Carga int
AS
	BEGIN
		DELETE DETALLE_CARGAS WHERE ID_CARGA = @ID_CARGA
	END


ALTER PROCEDURE [dbo].[SP_CONSULTAR_CARGA_POR_ID] 24
@carga_nro INT
AS	
	BEGIN
		SELECT
			C.ID_CARGA AS 'carga_nro',
			TC.NOMBRE as 'nombreTC',
			TC.ID_TIPO_CARGA as 'id_tipoCarga',
			TC.PESO AS 'peso',
			c.FECHA as 'fecha',
			DC.CANTIDAD as 'cantidad',
			C.PATENTE AS 'patente'

		FROM DETALLE_CARGAS DC
		INNER JOIN TIPO_CARGA TC ON DC.ID_TIPO_CARGA = TC.ID_TIPO_CARGA
		INNER JOIN CARGAS C ON DC.ID_CARGA = C.ID_CARGA
		WHERE DC.ID_CARGA = @carga_nro
	END

alter PROCEDURE SP_UPDATE_CARGAS
@id_carga INT,
@patente varchar(7),
@total_kg int,
@next int output
AS
	BEGIN
		UPDATE CARGAS
			SET fecha = GETDATE(),
			PATENTE = @patente,
			TOTAL_KG = @total_kg
		WHERE ID_CARGA = @id_carga
		SET @next = (SELECT MAX(DETALLE_NRO)+1  FROM DETALLE_CARGAS);
	END

CREATE PROCEDURE SP_CARGA_MAX 
@patente varchar(7),
@peso_max int output
	as
		begin
			SET @peso_max = (SELECT PESO_MAXIMO FROM CAMIONES WHERE @patente = PATENTE)
END

declare @peso_max int
exec SP_CARGA_MAX 'fgh456', @peso_max output

select @peso_max




ALTER PROCEDURE SP_CONTROL_USUARIO 
@usuario varchar(50),
@pass varchar(50)

AS
	BEGIN
		Select  * FROM USUARIOS WHERE USUARIO = @usuario AND CONTRASEŅA = @pass
	END
			
alter PROCEDURE SP_INSERTAR_CAMIONES
@patente varchar(7),
@estado VARCHAR(10),
@peso_max int,
@marca varchar(50),
@modelo varchar(50)
	AS
		BEGIN
			INSERT INTO CAMIONES(PATENTE,ESTADO,PESO_MAXIMO,MARCA,MODELO)
			VALUES(@patente,@estado,@peso_max,@marca,@modelo)
		END


ALTER TABLE CAMIONES	
ALTER COLUMN PESO_MAXIMO INT

ALTER TABLE CAMIONES	
ALTER COLUMN ESTADO VARCHAR(20)


ALTER TABLE CARGAS	
ALTER COLUMN TOTAL_KG INT


ALTER TABLE DETALLE_CARGAS	
ALTER COLUMN PESO INT

ALTER TABLE TIPO_CARGA	
ALTER COLUMN PESO INT

alter PROCEDURE SP_CONSULTAR_CAMIONES 
@patente varchar(7),
@estado varchar(20)
AS
	SELECT * FROM CAMIONES WHERE (PATENTE LIKE '%' + @patente + '%')  OR (ESTADO LIKE '%' + @estado + '%')






alter procedure [dbo].[SP_ELIMINAR_CAMION] 'fgh567'
@patente varchar(7)
AS
	BEGIN
		DELETE CAMIONES WHERE PATENTE = @patente
	END


create PROCEDURE [dbo].[SP_CONSULTAR_CAMIONES_SINP] 
AS
	SELECT * FROM CAMIONES 
	


ALTER PROCEDURE SP_ESTADO_CAMION 
@patente varchar(7),
@estado int output
as


	IF((SELECT ESTADO FROM CAMIONES where @patente = PATENTE) = 'DISPONIBLE')
		SET @estado = 1
	ELSE
		SET @estado = 0



declare @estado int
exec SP_ESTADO_CAMION 'JFK582', @estado output 

select @estado

