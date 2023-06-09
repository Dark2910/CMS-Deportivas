USE [Deportivas_TEST]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administradores](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](16) NULL,
	[password] [nvarchar](16) NULL,
	[cargo] [nvarchar](200) NULL,
	[nombre] [nvarchar](30) NULL,
	[apellido_paterno] [nvarchar](20) NULL,
	[apellido_materno] [nvarchar](20) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED ([id_usuario] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calendario](
	[id_calendario] [int] IDENTITY(1,1) NOT NULL,
	[calendario_nombre_evento] [nvarchar](50) NOT NULL,
	[calendario_descripcion_evento] [nvarchar](max) NOT NULL,
	[calendario_fecha_evento] [datetime] NOT NULL,
	[calendario_fecha_registro] [datetime] NOT NULL,
	[id_calendario_deporte] [int] NULL,
 CONSTRAINT [PK_calendario] PRIMARY KEY CLUSTERED ([id_calendario] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carreras](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[carrera_nombre] [nvarchar](50) NOT NULL,
	[carrera_fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_carreras] PRIMARY KEY CLUSTERED ([id_carrera] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coaches](
	[id_coach] [int] IDENTITY(1,1) NOT NULL,
	[coach_nombre] [nvarchar](50) NOT NULL,
	[coach_apaterno] [nvarchar](50) NOT NULL,
	[coach_amaterno] [nvarchar](50) NOT NULL,
	[coach_cv] [nvarchar](max) NOT NULL,
	[coach_fecha_registro] [datetime] NOT NULL,
	[id_coach_deporte] [int] NULL,
	[id_coach_genero] [int] NULL,
	[id_coach_turno] [int] NULL,
 CONSTRAINT [PK_coaches] PRIMARY KEY CLUSTERED ([id_coach] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deportes](
	[id_deporte] [int] IDENTITY(1,1) NOT NULL,
	[deporte_nombre] [nvarchar](50) NOT NULL,
	[deporte_objetivo] [nvarchar](max) NOT NULL,
	[deporte_descripcion] [nvarchar](max) NOT NULL,
	[deporte_fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_deportes] PRIMARY KEY CLUSTERED ([id_deporte] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deportistas](
	[id_deportista] [int] IDENTITY(1,1) NOT NULL,
	[deportista_nombre] [nvarchar](50) NOT NULL,
	[deportista_apaterno] [nvarchar](50) NOT NULL,
	[deportista_amaterno] [nvarchar](50) NOT NULL,
	[deportista_matricula] [int] NOT NULL,
	[deportista_fecha_registro] [datetime] NOT NULL,
	[id_deportista_genero] [int] NULL,
	[id_deportista_carrera] [int] NULL,
 CONSTRAINT [PK_deportistas] PRIMARY KEY CLUSTERED ([id_deportista] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documentos_calendario](
	[id_dcalendario] [int] IDENTITY(1,1) NOT NULL,
	[dcalendario_nombre] [nvarchar](50) NULL,
	[dcalendario_descripcion] [nvarchar](max) NULL,
	[dcalendario_fecha_registro] [datetime] NOT NULL,
	[id_dcalendario_calendario] [int] NULL,
	[dcalendario_tipo_archivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_documentos_calendario] PRIMARY KEY CLUSTERED ([id_dcalendario] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documentos_nota](
	[id_dnota] [int] IDENTITY(1,1) NOT NULL,
	[dnota_nombre] [nvarchar](50) NULL,
	[dnota_descripcion] [nvarchar](50) NULL,
	[dnota_fecha_registro] [datetime] NOT NULL,
	[id_dnota_nota] [int] NULL,
	[dnota_tipo_archivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_documentos_nota] PRIMARY KEY CLUSTERED ([id_dnota] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extensiones_documento](
	[id_extension_documento] [int] IDENTITY(1,1) NOT NULL,
	[extension_documento] [nvarchar](50) NULL,
 CONSTRAINT [PK_extensiones_documento] PRIMARY KEY CLUSTERED ([id_extension_documento] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extensiones_foto](
	[id_extension_foto] [int] IDENTITY(1,1) NOT NULL,
	[extension_foto] [nvarchar](50) NULL,
 CONSTRAINT [PK_extensiones_foto] PRIMARY KEY CLUSTERED ([id_extension_foto] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fotos_calendario](
	[id_fcalendario] [int] IDENTITY(1,1) NOT NULL,
	[fcalendario_nombre] [nvarchar](50) NULL,
	[fcalendario_descripcion] [nvarchar](max) NULL,
	[fcalendario_fecha_registro] [datetime] NOT NULL,
	[id_fcalendario_calendario] [int] NULL,
	[fcalendario_tipo_archivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_fotos_calendario] PRIMARY KEY CLUSTERED ([id_fcalendario] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fotos_deporte](
	[id_fdeporte] [int] IDENTITY(1,1) NOT NULL,
	[fdeporte_nombre] [nvarchar](50) NULL,
	[fdeporte_descripcion] [nvarchar](max) NULL,
	[fdeporte_fecha_registro] [datetime] NOT NULL,
	[id_fdeporte_deporte] [int] NULL,
	[fdeporte_tipo_archivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_galeria_deporte] PRIMARY KEY CLUSTERED ([id_fdeporte] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fotos_nota](
	[id_fnota] [int] IDENTITY(1,1) NOT NULL,
	[fnota_nombre] [nvarchar](50) NULL,
	[fnota_descripcion] [nvarchar](max) NULL,
	[fnota_fecha_registro] [datetime] NOT NULL,
	[id_fnota_nota] [int] NULL,
	[fnota_tipo_archivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_galeria_notas] PRIMARY KEY CLUSTERED ([id_fnota] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[generos](
	[id_genero] [int] IDENTITY(1,1) NOT NULL,
	[genero_nombre] [nvarchar](50) NOT NULL,
	[genero_fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_generos] PRIMARY KEY CLUSTERED ([id_genero] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos](
	[id_grupo] [int] IDENTITY(1,1) NOT NULL,
	[grupo_nombre] [nvarchar](50) NOT NULL,
	[grupo_fecha_registro] [datetime] NOT NULL,
	[id_grupo_coach] [int] NULL,
	[id_grupo_deporte] [int] NULL,
	[id_grupo_turno] [int] NULL,
 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED ([id_grupo] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inscripciones](
	[id_inscripcion] [int] IDENTITY(1,1) NOT NULL,
	[id_inscripcion_deportista] [int] NULL,
	[id_inscripcion_grupo] [int] NULL,
	[inscripcion_fecha_registro] [datetime] NOT NULL,
	[inscripcion_rooster] [bit] NOT NULL,
 CONSTRAINT [PK_inscripciones] PRIMARY KEY CLUSTERED ([id_inscripcion] ASC)
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notas](
	[id_nota] [int] IDENTITY(1,1) NOT NULL,
	[nota_titulo] [nvarchar](50) NOT NULL,
	[nota_subtitulo] [nvarchar](max) NOT NULL,
	[nota_texto] [nvarchar](max) NOT NULL,
	[nota_fecha_registro] [datetime] NOT NULL,
	[id_nota_deporte] [int] NULL,
 CONSTRAINT [PK_notas] PRIMARY KEY CLUSTERED ([id_nota] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[politicas_archivos](
	[id_politica] [int] IDENTITY(1,1) NOT NULL,
	[estatus] [int] NULL,
	[peso] [int] NULL,
	[alto] [int] NULL,
	[ancho] [int] NULL,
	[tipo_archivo] [nvarchar](50) NULL,
	[ruta_virtual] [nvarchar](max) NULL,
	[ruta_fisica] [nvarchar](max) NULL,
 CONSTRAINT [PK_politicas_archivos] PRIMARY KEY CLUSTERED ([id_politica] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turnos](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[turno_nombre] [nvarchar](50) NOT NULL,
	[turno_fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_turnos] PRIMARY KEY CLUSTERED ([id_turno] ASC)
) ON [PRIMARY]
GO



ALTER TABLE [dbo].[calendario]  WITH CHECK ADD  CONSTRAINT [id_calendario_deporte] FOREIGN KEY([id_calendario_deporte])
REFERENCES [dbo].[deportes] ([id_deporte])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[calendario] CHECK CONSTRAINT [id_calendario_deporte]
GO

ALTER TABLE [dbo].[coaches]  WITH CHECK ADD  CONSTRAINT [id_coach_deporte] FOREIGN KEY([id_coach_deporte])
REFERENCES [dbo].[deportes] ([id_deporte])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[coaches] CHECK CONSTRAINT [id_coach_deporte]
GO

ALTER TABLE [dbo].[coaches]  WITH CHECK ADD  CONSTRAINT [id_coach_genero] FOREIGN KEY([id_coach_genero])
REFERENCES [dbo].[generos] ([id_genero])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[coaches] CHECK CONSTRAINT [id_coach_genero]
GO

ALTER TABLE [dbo].[coaches]  WITH CHECK ADD  CONSTRAINT [id_coach_turno] FOREIGN KEY([id_coach_turno])
REFERENCES [dbo].[turnos] ([id_turno])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[coaches] CHECK CONSTRAINT [id_coach_turno]
GO

ALTER TABLE [dbo].[deportistas]  WITH CHECK ADD  CONSTRAINT [id_deportista_carrera] FOREIGN KEY([id_deportista_carrera])
REFERENCES [dbo].[carreras] ([id_carrera])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[deportistas] CHECK CONSTRAINT [id_deportista_carrera]
GO

ALTER TABLE [dbo].[deportistas]  WITH CHECK ADD  CONSTRAINT [id_deportista_genero] FOREIGN KEY([id_deportista_genero])
REFERENCES [dbo].[generos] ([id_genero])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[deportistas] CHECK CONSTRAINT [id_deportista_genero]
GO

ALTER TABLE [dbo].[documentos_calendario]  WITH CHECK ADD  CONSTRAINT [id_dcalendario_calendario] FOREIGN KEY([id_dcalendario_calendario])
REFERENCES [dbo].[calendario] ([id_calendario])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[documentos_calendario] CHECK CONSTRAINT [id_dcalendario_calendario]
GO

ALTER TABLE [dbo].[documentos_nota]  WITH CHECK ADD  CONSTRAINT [id_dnota_nota] FOREIGN KEY([id_dnota_nota])
REFERENCES [dbo].[notas] ([id_nota])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[documentos_nota] CHECK CONSTRAINT [id_dnota_nota]
GO

ALTER TABLE [dbo].[fotos_calendario]  WITH CHECK ADD  CONSTRAINT [id_fcalendario_calendario] FOREIGN KEY([id_fcalendario_calendario])
REFERENCES [dbo].[calendario] ([id_calendario])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[fotos_calendario] CHECK CONSTRAINT [id_fcalendario_calendario]
GO

ALTER TABLE [dbo].[fotos_deporte]  WITH CHECK ADD  CONSTRAINT [id_fdeporte_deporte] FOREIGN KEY([id_fdeporte_deporte])
REFERENCES [dbo].[deportes] ([id_deporte])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[fotos_deporte] CHECK CONSTRAINT [id_fdeporte_deporte]
GO

ALTER TABLE [dbo].[fotos_nota]  WITH CHECK ADD  CONSTRAINT [id_fnota_nota] FOREIGN KEY([id_fnota_nota])
REFERENCES [dbo].[notas] ([id_nota])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[fotos_nota] CHECK CONSTRAINT [id_fnota_nota]
GO

ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [id_grupo_coach] FOREIGN KEY([id_grupo_coach])
REFERENCES [dbo].[coaches] ([id_coach])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [id_grupo_coach]
GO

ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [id_grupo_deporte] FOREIGN KEY([id_grupo_deporte])
REFERENCES [dbo].[deportes] ([id_deporte])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [id_grupo_deporte]
GO

ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [id_grupo_turno] FOREIGN KEY([id_grupo_turno])
REFERENCES [dbo].[turnos] ([id_turno])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [id_grupo_turno]
GO

ALTER TABLE [dbo].[inscripciones]  WITH CHECK ADD  CONSTRAINT [id_inscripcion_deportista] FOREIGN KEY([id_inscripcion_deportista])
REFERENCES [dbo].[deportistas] ([id_deportista])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[inscripciones] CHECK CONSTRAINT [id_inscripcion_deportista]
GO

ALTER TABLE [dbo].[inscripciones]  WITH CHECK ADD  CONSTRAINT [id_inscripcion_grupo] FOREIGN KEY([id_inscripcion_grupo])
REFERENCES [dbo].[grupos] ([id_grupo])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[inscripciones] CHECK CONSTRAINT [id_inscripcion_grupo]
GO

ALTER TABLE [dbo].[notas]  WITH CHECK ADD  CONSTRAINT [id_nota_deporte] FOREIGN KEY([id_nota_deporte])
REFERENCES [dbo].[deportes] ([id_deporte])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[notas] CHECK CONSTRAINT [id_nota_deporte]
GO
