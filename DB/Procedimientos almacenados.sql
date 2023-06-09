USE [Deportivas_TEST]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_administradores_consulta]
@id_usuario INT
AS
BEGIN
	SELECT id_usuario, nombre, apellido_paterno, apellido_materno, cargo, activo
	FROM administradores
	WHERE id_usuario = @id_usuario
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_administradores_valida]
@usuario VARCHAR(16),
@password VARCHAR(16)
AS
BEGIN
	DECLARE @resultado VARCHAR(10)
	DECLARE @mensaje VARCHAR(100)
	SET @mensaje = ''

	DECLARE @id_usuario INT

	IF EXISTS(SELECT * FROM administradores WHERE usuario = @usuario)
	BEGIN
		IF EXISTS(SELECT * FROM administradores WHERE usuario = @usuario AND activo = 1)
		BEGIN
			IF EXISTS(SELECT * FROM administradores WHERE usuario = @usuario AND [password] = @password)
			BEGIN
				SELECT @id_usuario = id_usuario FROM administradores WHERE usuario = @usuario AND [password] = @password
				SET @resultado = '1'
				SET @mensaje = @id_usuario		
			END
			ELSE
			BEGIN
				SET @resultado = '0'
				SET @mensaje = 'El nombre de usuario/password incorrectos.'
			END
		END
		ELSE
		BEGIN
			SET @resultado = '0'
			SET @mensaje = 'El usuario esta inactivo.'
		END
	END
	ELSE
	BEGIN
		SET @resultado = '0'
		SET @mensaje = 'El nombre de usuario no existe.'
	END	
	SELECT @resultado AS Resultado, @mensaje AS Mensaje
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_calendario_drop] 
	@id_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM calendario
	WHERE(id_calendario = @id_calendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_calendario_get] 
	@id_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_calendario, calendario_nombre_evento, calendario_descripcion_evento, calendario_fecha_evento, calendario_fecha_registro, id_calendario_deporte
	FROM calendario
	WHERE(id_calendario = @id_calendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_calendario_post] 
	@calendario_nombre_evento nvarchar(50),
	@calendario_descripcion_evento nvarchar(MAx),
	@calendario_fecha_evento DATETIME,
	@id_calendario_deporte int 
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO calendario(calendario_nombre_evento, calendario_descripcion_evento, calendario_fecha_evento, calendario_fecha_registro, id_calendario_deporte)
	VALUES(@calendario_nombre_evento,@calendario_descripcion_evento,@calendario_fecha_evento,GETDATE(),@id_calendario_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_calendario_update] 
	@id_calendario int,
	@calendario_nombre_evento nvarchar(50),
	@calendario_descripcion_evento nvarchar(MAx),
	@calendario_fecha_evento DATETIME,
	@id_calendario_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE calendario
	SET calendario_nombre_evento = @calendario_nombre_evento, 
	calendario_descripcion_evento = @calendario_descripcion_evento, 
	calendario_fecha_evento = @calendario_fecha_evento,
	id_calendario_deporte = @id_calendario_deporte
	WHERE(id_calendario = @id_calendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_calendarios_get] 
	@id_calendario_deporte int

AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_calendario, calendario_nombre_evento, calendario_descripcion_evento, calendario_fecha_evento, calendario_fecha_registro
	FROM calendario
	WHERE(id_calendario_deporte = @id_calendario_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_carrera_drop]
	@id_carrera int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM carreras
	WHERE(id_carrera = @id_carrera)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_carrera_get]
	@id_carrera int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_carrera, carrera_nombre, carrera_fecha_registro
	FROM carreras
	WHERE(id_carrera = @id_carrera)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_carrera_post]
	@carrera_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO carreras (carrera_nombre, carrera_fecha_registro)
	VALUES (@carrera_nombre, GETDATE())
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_carrera_update]
	@id_carrera int,
	@carrera_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE carreras
	SET carrera_nombre = @carrera_nombre
	WHERE(id_carrera = @id_carrera)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_carreras_get]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_carrera, carrera_nombre, carrera_fecha_registro
	FROM carreras
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_coach_drop]
	@id_coach int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM coaches
	WHERE(id_coach = @id_coach)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_coach_get]
	@id_coach int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	coa.id_coach, coa.coach_nombre, coa.coach_apaterno, coa.coach_amaterno, coa.coach_cv, 
			coa.id_coach_genero, gen.genero_nombre, 
			coa.id_coach_turno, tur.turno_nombre, 
			coa.id_coach_deporte, act.deporte_nombre, 
			coa.coach_fecha_registro
	FROM coaches coa
	INNER JOIN deportes act ON coa.id_coach_deporte = act.id_deporte
	INNER JOIN generos gen ON coa.id_coach_genero = gen.id_genero
	INNER JOIN turnos tur ON coa.id_coach_turno = tur.id_turno
	WHERE(id_coach = @id_coach)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_coach_post]
	@coach_nombre nvarchar(50),
	@coach_apaterno nvarchar(50),
	@coach_amaterno nvarchar(50),
	@coach_cv nvarchar(MAX),
	@id_coach_deporte int,
	@id_coach_genero int,
	@id_coach_turno int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO coaches (coach_nombre, coach_apaterno, coach_amaterno, coach_cv, coach_fecha_registro, id_coach_deporte, id_coach_genero, id_coach_turno)
	VALUES (@coach_nombre,@coach_apaterno,@coach_amaterno,@coach_cv, GETDATE() ,@id_coach_deporte,@id_coach_genero,@id_coach_turno)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_coach_update]
	@id_coach int,
	@coach_nombre nvarchar(50),
	@coach_apaterno nvarchar(50),
	@coach_amaterno nvarchar(50),
	@coach_cv nvarchar(MAX),
	@id_coach_deporte int,
	@id_coach_genero int,
	@id_coach_turno int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE coaches
	SET coach_nombre = @coach_nombre, 
	coach_apaterno = @coach_apaterno, 
	coach_amaterno = @coach_amaterno, 
	coach_cv = @coach_cv,
	id_coach_deporte = @id_coach_deporte, 
	id_coach_genero = @id_coach_genero, 
	id_coach_turno = @id_coach_turno
	WHERE(id_coach = @id_coach)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_coaches_get]
	@id_coach_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT coa.id_coach,
	CONCAT(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) AS coach_nombre,
	coa.coach_cv, gen.genero_nombre, tur.turno_nombre, coa.coach_fecha_registro
	FROM coaches coa
	INNER JOIN deportes act ON coa.id_coach_deporte = act.id_deporte
	INNER JOIN generos gen ON coa.id_coach_genero = gen.id_genero
	INNER JOIN turnos tur ON coa.id_coach_turno = tur.id_turno
	WHERE(coa.id_coach_deporte = @id_coach_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deporte_drop]
	@id_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM deportes
	WHERE(id_deporte = @id_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deporte_get]
	@id_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_deporte, deporte_nombre, deporte_objetivo, deporte_descripcion, deporte_fecha_registro
	FROM deportes
	WHERE(id_deporte = @id_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deporte_post]
	@deporte_nombre nvarchar(50),
	@deporte_objetivo nvarchar(MAX),
	@deporte_descripcion nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO deportes (deporte_nombre, deporte_objetivo, deporte_descripcion, deporte_fecha_registro)
	VALUES(@deporte_nombre,@deporte_objetivo,@deporte_descripcion,GETDATE())
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deporte_update]
	@id_deporte int,
	@deporte_nombre nvarchar(50),
	@deporte_objetivo nvarchar(MAX),
	@deporte_descripcion nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE deportes
	SET deporte_nombre = @deporte_nombre, 
	deporte_objetivo = @deporte_objetivo, 
	deporte_descripcion = @deporte_descripcion
	WHERE(id_deporte = @id_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deportes_get]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_deporte, deporte_nombre, deporte_objetivo, deporte_descripcion, deporte_fecha_registro
	FROM deportes
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_deportista_drop] 
	@id_deportista int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM deportistas
	WHERE(id_deportista = @id_deportista)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deportista_get]
	@id_deportista int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	dep.id_deportista, dep.deportista_matricula, 
			dep.deportista_nombre, dep.deportista_apaterno, dep.deportista_amaterno,
			dep.id_deportista_genero, gen.genero_nombre,
			dep.id_deportista_carrera, car.carrera_nombre,
			dep.deportista_fecha_registro
	FROM deportistas dep
	INNER JOIN generos gen ON dep.id_deportista_genero = gen.id_genero
	INNER JOIN carreras car ON dep.id_deportista_carrera = car.id_carrera
	WHERE(id_deportista = @id_deportista)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deportista_post] 
	@deportista_nombre nvarchar(50),
	@deportista_apaterno nvarchar(50),
	@deportista_amaterno nvarchar(50),
	@deportista_matricula int,
	@id_deportista_genero int,
	@id_deportista_carrera int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO deportistas (deportista_nombre, deportista_apaterno, deportista_amaterno, deportista_matricula, deportista_fecha_registro, id_deportista_genero, id_deportista_carrera)
	VALUES(@deportista_nombre,@deportista_apaterno,@deportista_amaterno,@deportista_matricula,GETDATE(),@id_deportista_genero,@id_deportista_carrera)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deportista_update] 
	@id_deportista int,
	@deportista_nombre nvarchar(50),
	@deportista_apaterno nvarchar(50),
	@deportista_amaterno nvarchar(50),
	@deportista_matricula int,
	@id_deportista_genero int,
	@id_deportista_carrera int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE deportistas
	SET deportista_nombre = @deportista_nombre, 
	deportista_apaterno = @deportista_apaterno, 
	deportista_amaterno = @deportista_amaterno, 
	deportista_matricula = @deportista_matricula,  
	id_deportista_genero = @id_deportista_genero, 
	id_deportista_carrera = @id_deportista_carrera
	WHERE(id_deportista = @id_deportista)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deportistas_get]
	@id_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @tbl_tem TABLE ( id_dep_tem int )
	INSERT INTO @tbl_tem (id_dep_tem)
	SELECT ins.id_inscripcion_deportista
	FROM inscripciones ins
	WHERE ins.id_inscripcion_grupo = @id_grupo
	SELECT DISTINCT	dep.id_deportista, dep.deportista_matricula,
			CONCAT(dep.deportista_nombre,' ',dep.deportista_apaterno,' ',dep.deportista_amaterno) AS deportista_nombre,
			gen.genero_nombre, car.carrera_nombre, dep.deportista_fecha_registro
	FROM inscripciones ins
	LEFT JOIN @tbl_tem tem ON ins.id_inscripcion_deportista = tem.id_dep_tem
	RIGHT JOIN deportistas dep ON ins.id_inscripcion_deportista = dep.id_deportista
	INNER JOIN carreras car ON dep.id_deportista_carrera = car.id_carrera
	INNER JOIN Generos gen On dep.id_deportista_genero = gen.id_genero
	WHERE(tem.id_dep_tem is null)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_calendario_drop] 
	@id_dcalendario int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM documentos_calendario
	WHERE(id_dcalendario = @id_dcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_calendario_get] 
	@id_dcalendario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_dcalendario, dcalendario_nombre, dcalendario_descripcion, dcalendario_fecha_registro, id_dcalendario_calendario
	FROM documentos_calendario
	WHERE(id_dcalendario = @id_dcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_calendario_post] 
	@extension as nvarchar(50),
	@tipo_archivo as nvarchar(50),
	@dcalendario_nombre nvarchar(50),
	@dcalendario_descripcion nvarchar(50),
	@id_dcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	IF not exists (SELECT        extension_documento
		FROM            extensiones_documento
	WHERE        (extension_documento = @extension))
	begin
		select 'Error: La extension para este archivo no esta configurada' as 'msg', '001' as 'code_error'
		return(-1)
	end
	IF not exists (SELECT        tipo_archivo
		FROM            politicas_archivos
		WHERE        (tipo_archivo = @tipo_archivo))
	begin
		select 'Error: El tipo de archivo no esta configurado' as 'msg', '002' as 'code_error'
		return(-1)
	end
	declare @id_registrado as integer
	declare @nombre_archivo_final as nvarchar(50)
	INSERT INTO documentos_calendario (dcalendario_descripcion, dcalendario_fecha_registro, id_dcalendario_calendario, dcalendario_tipo_archivo)
	VALUES(@dcalendario_descripcion, GETDATE(),@id_dcalendario_calendario,@tipo_archivo); SELECT @id_registrado = @@IDENTITY
	SET @nombre_archivo_final = cast(@id_registrado as nvarchar(50)) + '-' + @dcalendario_nombre + '.' + @extension
	IF exists (SELECT        dcalendario_nombre
		FROM            documentos_calendario
	WHERE        (dcalendario_nombre = @nombre_archivo_final))
		begin
		select 'Error: El nombre del archivo ya existe' as 'msg', '003' as 'code_error'
		return(-1)
	end
	UPDATE documentos_calendario
	SET dcalendario_nombre = @nombre_archivo_final
	WHERE(id_dcalendario = @id_registrado)
	SELECT	politicas_archivos.ruta_virtual + documentos_calendario.dcalendario_nombre AS ruta_virtual, 
			politicas_archivos.ruta_fisica + documentos_calendario.dcalendario_nombre AS ruta_fisica, 
			'Se registro correctamente' as 'msg', '0' as 'codigo'
	FROM documentos_calendario
	INNER JOIN politicas_archivos ON documentos_calendario.dcalendario_tipo_archivo = politicas_archivos.tipo_archivo
	WHERE(politicas_archivos.estatus = 1) AND (politicas_archivos.tipo_archivo = @tipo_archivo) AND (documentos_calendario.id_dcalendario = @id_registrado)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_calendario_update]
	@id_dcalendario int,
	@dcalendario_nombre nvarchar(50),
	@dcalendario_descripcion nvarchar(50),
	@id_dcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE documentos_calendario
	SET dcalendario_nombre = @dcalendario_nombre, 
		dcalendario_descripcion = @dcalendario_descripcion, 
		id_dcalendario_calendario = @id_dcalendario_calendario
	WHERE(id_dcalendario = @id_dcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_nota_drop] 
	@id_dnota int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM documentos_nota
	WHERE(id_dnota = @id_dnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_nota_get] 
	@id_dnota int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_dnota, dnota_nombre, dnota_descripcion, dnota_fecha_registro, id_dnota_nota
	FROM documentos_nota
	WHERE(id_dnota = @id_dnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documento_nota_post] 
	@extension as nvarchar(50),
	@tipo_archivo as nvarchar(50),
	@dnota_nombre nvarchar(50),
	@dnota_descripcion nvarchar(MAX),
	@id_dnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
		IF not exists (SELECT        extension_documento
		FROM            extensiones_documento
	WHERE        (extension_documento = @extension))
	begin
		select 'Error: La extension para este archivo no esta configurada' as 'msg', '001' as 'code_error'
		return(-1)
	end
	IF not exists (SELECT        tipo_archivo
		FROM            politicas_archivos
		WHERE        (tipo_archivo = @tipo_archivo))
	begin
		select 'Error: El tipo de archivo no esta configurado' as 'msg', '002' as 'code_error'
		return(-1)
	end
	declare @id_registrado as integer
	declare @nombre_archivo_final as nvarchar(50)
	INSERT INTO documentos_nota (dnota_descripcion, dnota_fecha_registro, id_dnota_nota, dnota_tipo_archivo)
	VALUES(@dnota_descripcion,GETDATE(),@id_dnota_nota,@tipo_archivo); SELECT @id_registrado = @@IDENTITY
	SET @nombre_archivo_final = cast(@id_registrado as nvarchar(50)) + '-' + @dnota_nombre + '.' + @extension
	IF exists (SELECT        dnota_nombre
		FROM            documentos_nota
	WHERE        (dnota_nombre = @nombre_archivo_final))
		begin
		select 'Error: El nombre del archivo ya existe' as 'msg', '003' as 'code_error'
		return(-1)
	end
	UPDATE documentos_nota
	SET dnota_nombre = @nombre_archivo_final
	WHERE(id_dnota = @id_registrado)
	SELECT	politicas_archivos.ruta_virtual + documentos_nota.dnota_nombre AS ruta_virtual, 
			politicas_archivos.ruta_fisica + documentos_nota.dnota_nombre AS ruta_fisica, 
			'Se registro correctamente' as 'msg', '0' as 'codigo'
	FROM documentos_nota
	INNER JOIN politicas_archivos ON documentos_nota.dnota_tipo_archivo = politicas_archivos.tipo_archivo
	WHERE(politicas_archivos.estatus = 1) AND (politicas_archivos.tipo_archivo = @tipo_archivo) AND (documentos_nota.id_dnota = @id_registrado)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_documento_nota_update] 
	@id_dnota int,
	@dnota_nombre nvarchar(50),
	@dnota_descripcion nvarchar(MAX),
	@id_dnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE documentos_nota
	SET dnota_nombre = @dnota_nombre, 
	dnota_descripcion = @dnota_descripcion, 
	id_dnota_nota = @id_dnota_nota
	WHERE(id_dnota = @id_dnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documentos_calendario_get] 
	@id_dcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_dcalendario, dcalendario_nombre, dcalendario_descripcion, dcalendario_fecha_registro
	FROM documentos_calendario
	WHERE(id_dcalendario_calendario = @id_dcalendario_calendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_documentos_nota_get]
	@id_dnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_dnota, dnota_nombre, dnota_descripcion, dnota_fecha_registro
	FROM documentos_nota dnota
	INNER JOIN notas ON dnota.id_dnota_nota = notas.id_nota
	WHERE(id_dnota_nota = @id_dnota_nota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_calendario_drop]
	@id_fcalendario int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM fotos_calendario
	WHERE(id_fcalendario = @id_fcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_calendario_get]
	@id_fcalendario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_fcalendario, fcalendario_nombre, fcalendario_descripcion, fcalendario_fecha_registro, id_fcalendario_calendario
	FROM fotos_calendario
	WHERE(id_fcalendario = @id_fcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_calendario_post]
	@extension as nvarchar(50),
	@tipo_archivo as nvarchar(50),
	@fcalendario_nombre nvarchar(50),
	@fcalendario_descripcion nvarchar(MAX),
	@id_fcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	IF not exists (SELECT        extension_foto
		FROM            extensiones_foto
	WHERE        (extension_foto = @extension))
	begin
		select 'Error: La extension para este archivo no esta configurada' as 'msg', '001' as 'code_error'
		return(-1)
	end
	IF not exists (SELECT        tipo_archivo
		FROM            politicas_archivos
		WHERE        (tipo_archivo = @tipo_archivo))
	begin
		select 'Error: El tipo de archivo no esta configurado' as 'msg', '002' as 'code_error'
		return(-1)
	end
	declare @id_registrado as integer
	declare @nombre_archivo_final as nvarchar(50)
	INSERT INTO fotos_calendario (fcalendario_descripcion, fcalendario_fecha_registro, id_fcalendario_calendario, fcalendario_tipo_archivo)
	VALUES(@fcalendario_descripcion, GETDATE(),@id_fcalendario_calendario,@tipo_archivo); SELECT @id_registrado = @@IDENTITY
	SET @nombre_archivo_final = cast(@id_registrado as nvarchar(50)) + '-' + @fcalendario_nombre + '.' + @extension
	IF exists (SELECT        fcalendario_nombre
		FROM            fotos_calendario
	WHERE        (fcalendario_nombre = @nombre_archivo_final))
		begin
		select 'Error: El nombre del archivo ya existe' as 'msg', '003' as 'code_error'
		return(-1)
	end
	UPDATE fotos_calendario
	SET fcalendario_nombre = @nombre_archivo_final
	WHERE(id_fcalendario = @id_registrado)
	SELECT	politicas_archivos.ruta_virtual + fotos_calendario.fcalendario_nombre AS ruta_virtual, 
			politicas_archivos.ruta_fisica + fotos_calendario.fcalendario_nombre AS ruta_fisica, 
			'Se registro correctamente' as 'msg', '0' as 'codigo'
	FROM fotos_calendario
	INNER JOIN politicas_archivos ON fotos_calendario.fcalendario_tipo_archivo = politicas_archivos.tipo_archivo
	WHERE(politicas_archivos.estatus = 1) AND (politicas_archivos.tipo_archivo = @tipo_archivo) AND (fotos_calendario.id_fcalendario = @id_registrado)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_calendario_update]
	@id_fcalendario int,
	@fcalendario_nombre nvarchar(50),
	@fcalendario_descripcion nvarchar(MAX),
	@id_fcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE fotos_calendario
	SET	fcalendario_nombre = @fcalendario_nombre, 
		fcalendario_descripcion = @fcalendario_descripcion, 
		id_fcalendario_calendario = @id_fcalendario_calendario
	WHERE(id_fcalendario = @id_fcalendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_deporte_drop]
	@id_fdeporte int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM fotos_deporte
	WHERE(id_fdeporte = @id_fdeporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_deporte_get] 
	@id_fdeporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT fdep.id_fdeporte_deporte, fdep.id_fdeporte, fdep.fdeporte_nombre, fdep.fdeporte_descripcion, dep.deporte_nombre, fdep.fdeporte_fecha_registro
	FROM fotos_deporte fdep
	INNER JOIN deportes dep ON fdep.id_fdeporte_deporte = dep.id_deporte
	WHERE(id_fdeporte = @id_fdeporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_deporte_post] 
	@extension as nvarchar(50),
	@tipo_archivo as nvarchar(50),
	@fdeporte_nombre nvarchar(50),
	@fdeporte_descripcion nvarchar(MAX),
	@id_fdeporte_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	IF not exists (SELECT        extension_foto
		FROM            extensiones_foto
	WHERE        (extension_foto = @extension))
	begin
		select 'Error: La extension para este archivo no esta configurada' as 'msg', '001' as 'code_error'
		return(-1)
	end
	IF not exists (SELECT        tipo_archivo
		FROM            politicas_archivos
		WHERE        (tipo_archivo = @tipo_archivo))
	begin
		select 'Error: El tipo de archivo no esta configurado' as 'msg', '002' as 'code_error'
		return(-1)
	end
	declare @id_registrado as integer
	declare @nombre_archivo_final as nvarchar(50)
	INSERT INTO fotos_deporte(fdeporte_descripcion, fdeporte_fecha_registro, fdeporte_tipo_archivo, id_fdeporte_deporte)
	VALUES(@fdeporte_descripcion,GETDATE(),@tipo_archivo,@id_fdeporte_deporte); SELECT @id_registrado = @@IDENTITY
	SET @nombre_archivo_final = cast(@id_registrado as nvarchar(50)) + '-' + @fdeporte_nombre + '.' + @extension
	IF exists (SELECT        fdeporte_nombre
		FROM            fotos_deporte
	WHERE        (fdeporte_nombre = @nombre_archivo_final))
		begin
		select 'Error: El nombre del archivo ya existe' as 'msg', '003' as 'code_error'
		return(-1)
	end
	UPDATE fotos_deporte
	SET fdeporte_nombre = @nombre_archivo_final
	WHERE(id_fdeporte = @id_registrado)
	SELECT	politicas_archivos.ruta_virtual + fotos_deporte.fdeporte_nombre AS ruta_virtual, 
			politicas_archivos.ruta_fisica + fotos_deporte.fdeporte_nombre AS ruta_fisica, 
			'Se registro correctamente' as 'msg', '0' as 'codigo'
	FROM fotos_deporte
	INNER JOIN politicas_archivos ON fotos_deporte.fdeporte_tipo_archivo = politicas_archivos.tipo_archivo
	WHERE(politicas_archivos.estatus = 1) AND (politicas_archivos.tipo_archivo = @tipo_archivo) AND (fotos_deporte.id_fdeporte = @id_registrado)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_deporte_update]
	@id_fdeporte int,
	@fdeporte_nombre nvarchar(50),
	@fdeporte_descripcion nvarchar(MAX),
	@id_fdeporte_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE fotos_deporte
	SET fdeporte_nombre = @fdeporte_nombre, 
	fdeporte_descripcion = @fdeporte_descripcion, 
	id_fdeporte_deporte = @id_fdeporte_deporte
	WHERE(id_fdeporte = @id_fdeporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_nota_drop]
	@id_fnota int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM fotos_nota
	WHERE (id_fnota = @id_fnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_nota_get]
	@id_fnota int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_fnota, fnota_nombre, fnota_descripcion, fnota_fecha_registro, id_fnota_nota
	FROM fotos_nota
	WHERE(id_fnota = @id_fnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_nota_post] 
	@extension as nvarchar(50),
	@tipo_archivo as nvarchar(50),
	@fnota_nombre nvarchar(50),
	@fnota_descripcion nvarchar(MAX),
	@id_fnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
	IF not exists (SELECT        extension_foto
		FROM            extensiones_foto
	WHERE        (extension_foto = @extension))
	begin
		select 'Error: La extension para este archivo no esta configurada' as 'msg', '001' as 'code_error'
		return(-1)
	end
	IF not exists (SELECT        tipo_archivo
		FROM            politicas_archivos
		WHERE        (tipo_archivo = @tipo_archivo))
	begin
		select 'Error: El tipo de archivo no esta configurado' as 'msg', '002' as 'code_error'
		return(-1)
	end
	declare @id_registrado as integer
	declare @nombre_archivo_final as nvarchar(50)
	INSERT INTO fotos_nota (fnota_descripcion, fnota_fecha_registro, id_fnota_nota, fnota_tipo_archivo)
	VALUES(@fnota_descripcion, GETDATE(),@id_fnota_nota,@tipo_archivo); SELECT @id_registrado = @@IDENTITY
	SET @nombre_archivo_final = cast(@id_registrado as nvarchar(50)) + '-' + @fnota_nombre + '.' + @extension
	IF exists (SELECT        fnota_nombre
		FROM            fotos_nota
	WHERE        (fnota_nombre = @nombre_archivo_final))
		begin
		select 'Error: El nombre del archivo ya existe' as 'msg', '003' as 'code_error'
		return(-1)
	end
	UPDATE fotos_nota
	SET fnota_nombre = @nombre_archivo_final
	WHERE(id_fnota = @id_registrado)
	SELECT	politicas_archivos.ruta_virtual + fotos_nota.fnota_nombre AS ruta_virtual, 
			politicas_archivos.ruta_fisica + fotos_nota.fnota_nombre AS ruta_fisica, 
			'Se registro correctamente' as 'msg', '0' as 'codigo'
	FROM fotos_nota
	INNER JOIN politicas_archivos ON fotos_nota.fnota_tipo_archivo = politicas_archivos.tipo_archivo
	WHERE(politicas_archivos.estatus = 1) AND (politicas_archivos.tipo_archivo = @tipo_archivo) AND (fotos_nota.id_fnota = @id_registrado)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_foto_nota_update]
	@id_fnota int,
	@fnota_nombre nvarchar(50),
	@fnota_descripcion nvarchar(MAX),
	@id_fnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE fotos_nota
	SET fnota_nombre = @fnota_nombre, 
	fnota_descripcion = @fnota_descripcion, 
	id_fnota_nota = @id_fnota_nota
	WHERE(id_fnota = @id_fnota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_fotos_calendario_get]
	@id_fcalendario_calendario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_fcalendario, fcalendario_nombre, fcalendario_descripcion, fcalendario_fecha_registro
	FROM fotos_calendario
	WHERE(id_fcalendario_calendario = @id_fcalendario_calendario)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_fotos_deporte_get]
	@id_fdeporte_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT fdep.id_fdeporte, fdep.fdeporte_nombre, fdep.fdeporte_descripcion, fdep.fdeporte_fecha_registro
	FROM fotos_deporte fdep
	INNER JOIN deportes dep ON fdep.id_fdeporte_deporte = dep.id_deporte
	WHERE(id_fdeporte_deporte = @id_fdeporte_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_fotos_nota_get]
	@id_fnota_nota int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_fnota, fnota_nombre, fnota_descripcion, fnota_fecha_registro
	FROM fotos_nota fnota
	INNER JOIN notas ON fnota.id_fnota_nota = notas.id_nota
	WHERE(id_fnota_nota = @id_fnota_nota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_genero_drop]
	@id_genero int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM generos
	WHERE(id_genero = @id_genero)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_genero_get]
	@id_genero int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_genero, genero_nombre, genero_fecha_registro
	FROM generos
	WHERE(id_genero = @id_genero)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_genero_post]
	@genero_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO generos (genero_nombre, genero_fecha_registro)
	VALUES(@genero_nombre,GETDATE())
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_genero_update]
	@id_genero int,
	@genero_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE generos
	SET genero_nombre = @genero_nombre
	WHERE(id_genero = @id_genero)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_generos_get] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_genero, genero_nombre, genero_fecha_registro
	FROM generos
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_coach_get]
	@id_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT coa.id_coach, 
	concat(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) As nombre_coach,
	gen.genero_nombre, tur.turno_nombre, coa.coach_fecha_registro
	FROM grupos gru
	INNER JOIN coaches coa ON gru.id_grupo_coach = coa.id_coach
	INNER JOIN generos gen ON coa.id_coach_genero = gen.id_genero
	INNER JOIN turnos tur ON coa.id_coach_turno = tur.id_turno
	WHERE(gru.id_grupo = @id_grupo)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_coaches_get] 
	@id_grupo int,
	@id_grupo_deporte int,
	@id_grupo_turno int
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @id_coach_tem int = (	SELECT gru.id_grupo_coach
									FROM grupos gru
									WHERE(gru.id_grupo = @id_grupo))
	IF(@id_coach_tem is null)
		BEGIN
			SELECT	coa.id_coach, 
					concat(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) As nombre_coach,
					gen.genero_nombre, tur.turno_nombre, coa.coach_fecha_registro
			FROM coaches coa
			LEFT JOIN grupos gru ON coa.id_coach = gru.id_grupo_coach
			LEFT JOIN deportes act ON coa.id_coach_deporte = act.id_deporte
			INNER JOIN generos gen ON coa.id_coach_genero = gen.id_genero
			INNER JOIN turnos tur ON coa.id_coach_turno = tur.id_turno
			WHERE(coa.id_coach_deporte = @id_grupo_deporte)  AND (coa.id_coach_turno = @id_grupo_turno)
		END
	ELSE
		BEGIN
			SELECT	coa.id_coach, 
					concat(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) As nombre_coach,
					gen.genero_nombre, tur.turno_nombre, coa.coach_fecha_registro
			FROM coaches coa
			LEFT JOIN grupos gru ON coa.id_coach = gru.id_grupo_coach
			LEFT JOIN deportes act ON coa.id_coach_deporte = act.id_deporte
			INNER JOIN generos gen ON coa.id_coach_genero = gen.id_genero
			INNER JOIN turnos tur ON coa.id_coach_turno = tur.id_turno
			WHERE(coa.id_coach_deporte = @id_grupo_deporte)  AND (coa.id_coach_turno = @id_grupo_turno) AND (coa.id_coach != @id_grupo)
		END
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_drop]
	@id_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM grupos
	WHERE(id_grupo = @id_grupo)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_get]
	@id_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	gru.id_grupo, gru.grupo_nombre, 
			gru.id_grupo_coach, CONCAT(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) AS grupo_coach,
			gru.id_grupo_turno, tur.turno_nombre, 
			gru.id_grupo_deporte, act.deporte_nombre, 
			gru.grupo_fecha_registro
	FROM grupos gru
	LEFT JOIN coaches coa ON gru.id_grupo_coach = coa.id_coach
	INNER JOIN deportes act ON gru.id_grupo_deporte = act.id_deporte
	INNER JOIN turnos tur ON gru.id_grupo_turno = tur.id_turno
	WHERE(gru.id_grupo = @id_grupo)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_post]
	@grupo_nombre nvarchar(50),
	@id_grupo_coach int,
	@id_grupo_deporte int,
	@id_grupo_turno int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO grupos (grupo_nombre, grupo_fecha_registro, id_grupo_coach, id_grupo_deporte, id_grupo_turno)
	VALUES(@grupo_nombre, GETDATE(),@id_grupo_coach,@id_grupo_deporte,@id_grupo_turno)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupo_update]
	@id_grupo int,
	@grupo_nombre nvarchar(50),
	@id_grupo_coach int,
	@id_grupo_deporte int,
	@id_grupo_turno int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE grupos
	SET grupo_nombre = @grupo_nombre, 
	id_grupo_coach = @id_grupo_coach, 
	id_grupo_deporte = @id_grupo_deporte, 
	id_grupo_turno = @id_grupo_turno
	WHERE(id_grupo = @id_grupo)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupos_get]
	@id_grupo_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	gru.id_grupo, gru.grupo_nombre,
			CONCAT(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) AS grupo_coach,
			tur.turno_nombre, gru.grupo_fecha_registro
	FROM grupos gru
	INNER JOIN coaches coa ON gru.id_grupo_coach = coa.id_coach
	INNER JOIN deportes act ON gru.id_grupo_deporte = act.id_deporte
	INNER JOIN turnos tur ON gru.id_grupo_turno = tur.id_turno
	WHERE(gru.id_grupo_deporte = @id_grupo_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupos_matutino_get] 
	@id_grupo_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT gru.id_grupo_turno, gru.id_grupo, gru.grupo_nombre,
	CONCAT(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) AS grupo_coach,
	tur.turno_nombre, gru.grupo_fecha_registro
	FROM grupos gru
	INNER JOIN coaches coa ON gru.id_grupo_coach = coa.id_coach
	INNER JOIN deportes act ON gru.id_grupo_deporte = act.id_deporte
	INNER JOIN turnos tur ON gru.id_grupo_turno = tur.id_turno
	WHERE(gru.id_grupo_deporte = @id_grupo_deporte) AND (gru.id_grupo_turno = 1)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[sp_grupos_pendientes_get]
	@id_grupo_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT gru.id_grupo_turno, gru.id_grupo, gru.grupo_nombre, gru.id_grupo_coach,
	tur.turno_nombre, gru.grupo_fecha_registro
	FROM grupos gru
	INNER JOIN deportes act ON gru.id_grupo_deporte = act.id_deporte
	INNER JOIN turnos tur ON gru.id_grupo_turno = tur.id_turno
	WHERE(gru.id_grupo_deporte = @id_grupo_deporte) AND (id_grupo_coach is null)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_grupos_vespertino_get]
	@id_grupo_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT gru.id_grupo_turno, gru.id_grupo, gru.grupo_nombre,
	CONCAT(coa.coach_nombre,' ',coa.coach_apaterno,' ',coa.coach_amaterno) AS grupo_coach,
	tur.turno_nombre, gru.grupo_fecha_registro
	FROM grupos gru
	INNER JOIN coaches coa ON gru.id_grupo_coach = coa.id_coach
	INNER JOIN deportes act ON gru.id_grupo_deporte = act.id_deporte
	INNER JOIN turnos tur ON gru.id_grupo_turno = tur.id_turno
	WHERE(gru.id_grupo_deporte = @id_grupo_deporte) AND (gru.id_grupo_turno = 2)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripcion_drop]
	@id_inscripcion int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM inscripciones
	WHERE(id_inscripcion = @id_inscripcion)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripcion_get]
	@id_inscripcion int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_inscripcion, id_inscripcion_deportista, id_inscripcion_grupo, inscripcion_rooster, inscripcion_fecha_registro
	FROM inscripciones
	WHERE (id_inscripcion = @id_inscripcion)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripcion_post]
	@id_inscripcion_deportista int,
	@id_inscripcion_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO inscripciones (id_inscripcion_deportista, id_inscripcion_grupo, inscripcion_rooster, inscripcion_fecha_registro)
	VALUES(@id_inscripcion_deportista,@id_inscripcion_grupo, 0, GETDATE())
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripcion_update]
	@id_inscripcion int,
	@id_inscripcion_deportista int,
	@id_inscripcion_grupo int,
	@inscripcion_rooster bit
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE inscripciones
	SET id_inscripcion_deportista = @id_inscripcion_deportista, 
		id_inscripcion_grupo = @id_inscripcion_grupo, 
		inscripcion_rooster = @inscripcion_rooster
	WHERE (id_inscripcion = @id_inscripcion)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripciones_get]
	@id_inscripcion_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT ins.id_inscripcion, dep.id_deportista, dep.deportista_matricula,
		CONCAT(dep.deportista_nombre,' ',dep.deportista_apaterno,' ',dep.deportista_amaterno) AS deportista_nombre,
		car.carrera_nombre, dep.deportista_fecha_registro
	FROM inscripciones ins
	INNER JOIN grupos gru ON ins.id_inscripcion_grupo = gru.id_grupo
	INNER JOIN deportistas dep ON ins.id_inscripcion_deportista = dep.id_deportista
	INNER JOIN carreras car ON dep.id_deportista_carrera = car.id_carrera
	WHERE(ins.id_inscripcion_grupo = @id_inscripcion_grupo)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_inscripciones_rooster_get]
	@id_inscripcion_grupo int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	ins.id_inscripcion, dep.id_deportista, dep.deportista_matricula,
			CONCAT(dep.deportista_nombre,' ',dep.deportista_apaterno,' ',dep.deportista_amaterno) AS deportista_nombre,
			car.carrera_nombre, dep.deportista_fecha_registro
	FROM inscripciones ins
	INNER JOIN grupos gru ON ins.id_inscripcion_grupo = gru.id_grupo
	INNER JOIN deportistas dep ON ins.id_inscripcion_deportista = dep.id_deportista
	INNER JOIN carreras car ON dep.id_deportista_carrera = car.id_carrera
	WHERE(ins.id_inscripcion_grupo = @id_inscripcion_grupo) AND (ins.inscripcion_rooster = 1)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nota_drop]
	@id_nota int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM notas
	WHERE(id_nota = @id_nota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nota_get]
	@id_nota int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_nota, nota_titulo, nota_subtitulo, nota_texto, nota_fecha_registro, id_nota_deporte
	FROM notas
	WHERE(id_nota = @id_nota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nota_post]
	@nota_titulo nvarchar(50),
	@nota_subtitulo nvarchar(50),
	@nota_texto nvarchar(MAX),
	@id_nota_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO notas (nota_titulo, nota_subtitulo, nota_texto, nota_fecha_registro, id_nota_deporte)
	VALUES(@nota_titulo,@nota_subtitulo,@nota_texto,GETDATE(),@id_nota_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nota_update]
	@id_nota int,
	@nota_titulo nvarchar(50),
	@nota_subtitulo nvarchar(50),
	@nota_texto nvarchar(MAX),
	@id_nota_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE notas
	SET nota_titulo = @nota_titulo, 
	nota_subtitulo = @nota_subtitulo, 
	nota_texto = @nota_texto,
	id_nota_deporte = @id_nota_deporte
	WHERE(id_nota = @id_nota)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_notas_get]
	@id_nota_deporte int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_nota, nota_titulo, nota_subtitulo, nota_texto, nota_fecha_registro
	FROM notas 
	INNER JOIN deportes act ON notas.id_nota_deporte = act.id_deporte
	WHERE(notas.id_nota_deporte = @id_nota_deporte)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_turno_drop]
	@id_turno int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM turnos
	WHERE(id_turno = @id_turno)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_turno_get] 
	@id_turno int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_turno, turno_nombre, turno_fecha_registro
	FROM turnos
	WHERE(id_turno = @id_turno)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_turno_post]
	@turno_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO turnos (turno_nombre, turno_fecha_registro)
	VALUES(@turno_nombre, GETDATE())
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_turno_update]
	@id_turno int,
	@turno_nombre nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE turnos
	SET turno_nombre = @turno_nombre
	WHERE (id_turno = @id_turno)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_turnos_get] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_turno, turno_nombre, turno_fecha_registro
	FROM turnos
END
GO
