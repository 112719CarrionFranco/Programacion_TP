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
DETALLE_NRO INT IDENTITY(1,1),
ID_CARGA INT,
ID_TIPO_CARGA INT,
CANTIDAD INT
CONSTRAINT PK_DETALLE_NRO PRIMARY KEY (DETALLE_NRO)
CONSTRAINT FK_ID_CARGA FOREIGN KEY (ID_CARGA)
REFERENCES CARGAS(ID_CARGA),
CONSTRAINT FK_ID_TIPO_CARGA FOREIGN KEY (ID_TIPO_CARGA)
REFERENCES TIPO_CARGA(ID_TIPO_CARGA))

CREATE TABLE USUARIOS(
ID_USUARIO INT IDENTITY,
USUARIO VARCHAR(50),
CONTRASEŅA VARCHAR(50)
CONSTRAINT PK_USUARIOS PRIMARY KEY(ID_USUARIO))


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CARGAS] 
	@fecha_desde Date,
	@fecha_hasta Date,
	@patente varchar(7),
	@datos_baja varchar(1)
AS
BEGIN
	SELECT * FROM CARGAS
	WHERE 
	 ((@fecha_desde is null and @fecha_hasta is  null) OR (fecha between @fecha_desde and @fecha_hasta))
	 AND(@patente is null OR (@patente like '%' + @patente + '%'))
	 
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
	@PESO DECIMAL(4,2)
AS
BEGIN
	INSERT INTO DETALLE_CARGAS(DETALLE_NRO,ID_CARGA, ID_TIPO_CARGA, CANTIDAD,PESO)
    VALUES (@DETALLE_NRO, @ID_CARGA, @ID_TIPO_CARGA, @CANTIDAD,@PESO);
  
END
--
ALTER PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@PATENTE varchar(7), 
	@TOTAL_KG DECIMAL(4,2),
	@ID_CARGA int OUTPUT
AS
BEGIN
	INSERT INTO CARGAS(FECHA, PATENTE, TOTAL_KG)
    VALUES (GETDATE(), @PATENTE, @TOTAL_KG);
    SET @ID_CARGA = SCOPE_IDENTITY();

END
--
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(ID_CARGA)+1  FROM CARGAS);
END
--
ALTER procedure [dbo].[SP_ELIMINAR_CARGA]
@id_Carga int
AS
	BEGIN
		DELETE CARGAS WHERE ID_CARGA = @ID_CARGA
	END


ALTER procedure [dbo].[SP_ELIMINAR_DETALLE_CARGA]
@id_Carga int
AS
	BEGIN
		DELETE DETALLE_CARGAS WHERE ID_CARGA = @ID_CARGA
	END


alter PROCEDURE SP_CONSULTAR_CARGA_POR_ID
@carga_nro INT
AS	
	BEGIN
		SELECT
			@carga_nro AS 'carga_nro',
			TC.NOMBRE as 'nombreTC',
			TC.ID_TIPO_CARGA as 'id_tipoCarga',
			C.TOTAL_KG as 'peso',
			c.FECHA as 'fecha',
			DC.CANTIDAD as 'cantidad',
			C.PATENTE AS 'patente'

		FROM DETALLE_CARGAS DC
		INNER JOIN TIPO_CARGA TC ON DC.ID_TIPO_CARGA = TC.ID_TIPO_CARGA
		INNER JOIN CARGAS C ON DC.ID_CARGA = C.ID_CARGA
		WHERE DC.ID_CARGA = @carga_nro
	END

CREATE PROCEDURE SP_UPDATE_CARGAS
@id_carga INT,
@patente varchar(7),
@total_kg decimal(4,2)
AS
	BEGIN
		UPDATE CARGAS
			SET fecha = GETDATE(),
			PATENTE = @patente,
			TOTAL_KG = @total_kg
		WHERE ID_CARGA = @id_carga
	END


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
ALTER COLUMN ESTADO VARCHAR(10)


ALTER TABLE CARGAS	
ALTER COLUMN TOTAL_KG INT


ALTER TABLE DETALLE_CARGAS	
ALTER COLUMN PESO INT

ALTER TABLE TIPO_CARGA	
ALTER COLUMN PESO INT

CREATE PROCEDURE SP_CONSULTAR_CAMIONES
@patente varchar(7),
@estado varchar(10)
AS
	SELECT * FROM CAMIONES WHERE (PATENTE LIKE '%' + @patente + '%')  OR (ESTADO LIKE '%' + @estado + '%')

