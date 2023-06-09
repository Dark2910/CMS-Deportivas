USE [Deportivas_TEST]
GO
SET IDENTITY_INSERT [dbo].[carreras] ON 
GO
INSERT [dbo].[carreras] ([id_carrera], [carrera_nombre], [carrera_fecha_registro]) VALUES (1, N'Sistemas', CAST(N'2023-03-20T16:31:03.933' AS DateTime))
GO
INSERT [dbo].[carreras] ([id_carrera], [carrera_nombre], [carrera_fecha_registro]) VALUES (2, N'Contaduria', CAST(N'2023-03-20T16:31:19.943' AS DateTime))
GO
INSERT [dbo].[carreras] ([id_carrera], [carrera_nombre], [carrera_fecha_registro]) VALUES (3, N'Electrónica', CAST(N'2023-03-20T16:31:54.297' AS DateTime))
GO
INSERT [dbo].[carreras] ([id_carrera], [carrera_nombre], [carrera_fecha_registro]) VALUES (4, N'Mecatrónica', CAST(N'2023-03-20T16:32:17.487' AS DateTime))
GO
INSERT [dbo].[carreras] ([id_carrera], [carrera_nombre], [carrera_fecha_registro]) VALUES (5, N'Química', CAST(N'2023-03-20T16:32:36.210' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[carreras] OFF
GO
SET IDENTITY_INSERT [dbo].[generos] ON 
GO
INSERT [dbo].[generos] ([id_genero], [genero_nombre], [genero_fecha_registro]) VALUES (1, N'masculino', CAST(N'2023-03-20T16:25:34.143' AS DateTime))
GO
INSERT [dbo].[generos] ([id_genero], [genero_nombre], [genero_fecha_registro]) VALUES (2, N'femenino', CAST(N'2023-03-20T16:25:34.153' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[generos] OFF
GO
SET IDENTITY_INSERT [dbo].[deportistas] ON 
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (2, N'laura', N'hernandez', N'dias', 999999999, CAST(N'2023-03-22T08:24:36.323' AS DateTime), 2, 1)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (3, N'Miguel', N'Bautista', N'Rosas', 999999999, CAST(N'2023-03-22T08:25:05.463' AS DateTime), 1, 2)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (4, N'Paulina', N'Ayala', N'Rojas', 999999999, CAST(N'2023-03-22T08:25:32.417' AS DateTime), 2, 2)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (5, N'Emiliano', N'Lopez', N'Colin', 999999999, CAST(N'2023-03-22T08:26:02.090' AS DateTime), 1, 3)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (6, N'Brenda', N'Alcanla', N'Roa', 999999999, CAST(N'2023-03-22T08:26:29.550' AS DateTime), 2, 3)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (7, N'Manuel', N'Diaz', N'Pacheco', 999999999, CAST(N'2023-03-22T08:27:11.570' AS DateTime), 1, 4)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (8, N'Vanesa', N'Alondra', N'Gonzales', 999999999, CAST(N'2023-03-22T08:27:50.963' AS DateTime), 2, 4)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (9, N'Axel', N'Salgado', N'Lopez', 999999999, CAST(N'2023-03-22T08:28:50.830' AS DateTime), 1, 5)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (10, N'Sharon', N'Diaz', N'Muñoz', 999999999, CAST(N'2023-03-22T08:29:18.113' AS DateTime), 2, 5)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (11, N'test - 1', N' test - 1', N'test -1', 987654321, CAST(N'2023-03-23T15:58:11.293' AS DateTime), 1, 5)
GO
INSERT [dbo].[deportistas] ([id_deportista], [deportista_nombre], [deportista_apaterno], [deportista_amaterno], [deportista_matricula], [deportista_fecha_registro], [id_deportista_genero], [id_deportista_carrera]) VALUES (16, N'Deportista-Test', N'Deportista-Test', N'Deportista-Test', 123456789, CAST(N'2023-05-24T21:59:24.370' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[deportistas] OFF
GO
SET IDENTITY_INSERT [dbo].[deportes] ON 
GO
INSERT [dbo].[deportes] ([id_deporte], [deporte_nombre], [deporte_objetivo], [deporte_descripcion], [deporte_fecha_registro]) VALUES (1, N'Gimnasio', N'Mejorar la salud física y mental a través del ejercicio físico.', N'Ir al gimnasio es una actividad física que implica la realización de diferentes ejercicios para mejorar la condición física, la salud y el bienestar general. Al ir al gimnasio, las personas tienen acceso a una amplia variedad de equipos y herramientas de entrenamiento que les permiten realizar una gran variedad de ejercicios, adaptados a sus necesidades y objetivos.', CAST(N'2023-02-26T20:13:52.827' AS DateTime))
GO
INSERT [dbo].[deportes] ([id_deporte], [deporte_nombre], [deporte_objetivo], [deporte_descripcion], [deporte_fecha_registro]) VALUES (2, N'Basketball', N'Disfrutar de una actividad física divertida y desafiante, mientras desarrollas tus habilidades sociales y de trabajo en equipo.', N'El basketball es un deporte de equipo que se juega con una pelota y dos canastas ubicadas en cada extremo de la cancha. El objetivo del juego es anotar la mayor cantidad de puntos posible al introducir la pelota en la canasta del equipo contrario, mientras se defiende la propia canasta.', CAST(N'2023-02-26T20:21:13.440' AS DateTime))
GO
INSERT [dbo].[deportes] ([id_deporte], [deporte_nombre], [deporte_objetivo], [deporte_descripcion], [deporte_fecha_registro]) VALUES (3, N'Fútbol soccer', N'El fútbol soccer es un deporte que posee el objetivo de desarrollar habilidades físicas como velocidad, agilidad, coordinación, equilibrio y resistencia, tambien fomentar la competencia sana y la superación personal, el desarrollo de la comunicación, la colaboración y la empatía.', N'El fútbol soccer es un deporte de equipo que se juega con una pelota en un campo rectangular con dos porterías en los extremos opuestos. El objetivo del juego es anotar más goles que el equipo contrario al introducir la pelota en la portería del equipo contrario, mientras se defiende la propia portería.', CAST(N'2023-02-26T20:30:24.050' AS DateTime))
GO
INSERT [dbo].[deportes] ([id_deporte], [deporte_nombre], [deporte_objetivo], [deporte_descripcion], [deporte_fecha_registro]) VALUES (4, N'Atletismo', N'El atletismo es un deporte que requiere una variedad de habilidades físicas, como velocidad, resistencia, fuerza, agilidad y coordinación. El objetivo del atletismo es ayudar a desarrollar estas habilidades físicas a través del entrenamiento y la práctica. También es una actividad física que puede ayudar a mejorar la salud cardiovascular, aumentar la resistencia, reducir el riesgo de enfermedades crónicas y promover la salud.', N'El atletismo es un deporte que involucra una variedad de disciplinas, incluyendo carreras de velocidad, carreras de fondo, saltos, lanzamientos y eventos combinados. El objetivo de cada disciplina es completar la tarea lo más rápido, lejos o alto posible, dependiendo de la disciplina específica.', CAST(N'2023-02-26T20:36:03.050' AS DateTime))
GO
INSERT [dbo].[deportes] ([id_deporte], [deporte_nombre], [deporte_objetivo], [deporte_descripcion], [deporte_fecha_registro]) VALUES (6, N'TEST-DEPORTE-Modificar', N'TEST-DEPORTE-Modificar', N'TEST-DEPORTE-Modificar', CAST(N'2023-05-10T22:49:13.240' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[deportes] OFF
GO
SET IDENTITY_INSERT [dbo].[turnos] ON 
GO
INSERT [dbo].[turnos] ([id_turno], [turno_nombre], [turno_fecha_registro]) VALUES (1, N'matutino', CAST(N'2023-03-20T16:27:34.867' AS DateTime))
GO
INSERT [dbo].[turnos] ([id_turno], [turno_nombre], [turno_fecha_registro]) VALUES (2, N'vespertino', CAST(N'2023-03-20T16:27:34.870' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[turnos] OFF
GO
SET IDENTITY_INSERT [dbo].[coaches] ON 
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (1, N'Juan', N'Martin', N'Gomez', N'...', CAST(N'2023-03-21T15:14:49.203' AS DateTime), 1, 1, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (2, N'Maria', N'Flores', N'Hernandez', N'...', CAST(N'2023-03-21T15:15:20.037' AS DateTime), 1, 2, 2)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (3, N'Laura', N'Ayala', N'Diaz', N'...', CAST(N'2023-03-21T15:16:12.577' AS DateTime), 1, 2, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (4, N'Luis', N'Lopez', N'Pacheco', N'...', CAST(N'2023-03-21T15:16:39.123' AS DateTime), 1, 1, 2)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (5, N'uwu', N'uwu', N'uwu', N'<3', CAST(N'2023-03-22T05:10:44.237' AS DateTime), 2, 1, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (7, N'lorem', N'lorem', N'lorem', N'lorem', CAST(N'2023-03-22T12:33:05.803' AS DateTime), 1, 2, 2)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (8, N'test-M', N'test', N'tes', N'uwu', CAST(N'2023-03-23T19:37:15.127' AS DateTime), 1, 2, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (9, N'test', N'test', N'tes', N'test', CAST(N'2023-03-26T11:33:21.170' AS DateTime), NULL, 1, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (11, N'TEST-COACH-MATUTINO', N'TEST', N'TEST', N'TEST', CAST(N'2023-05-10T22:55:40.163' AS DateTime), 6, 1, 1)
GO
INSERT [dbo].[coaches] ([id_coach], [coach_nombre], [coach_apaterno], [coach_amaterno], [coach_cv], [coach_fecha_registro], [id_coach_deporte], [id_coach_genero], [id_coach_turno]) VALUES (12, N'TEST-COACH-VESPERTINO', N'TEST', N'TEST', N'TEST', CAST(N'2023-05-10T22:57:42.980' AS DateTime), 6, 2, 2)
GO
SET IDENTITY_INSERT [dbo].[coaches] OFF
GO
SET IDENTITY_INSERT [dbo].[grupos] ON 
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (2, N'Test1', CAST(N'2023-03-21T15:17:38.897' AS DateTime), 8, 1, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (3, N'Test2', CAST(N'2023-03-21T15:18:05.847' AS DateTime), 3, 1, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (4, N'Test3', CAST(N'2023-03-21T15:18:22.850' AS DateTime), 2, 1, 2)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (5, N'Test4', CAST(N'2023-03-21T15:18:27.097' AS DateTime), 4, 1, 2)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (6, N'TEST-NULL1', CAST(N'2023-03-22T06:03:55.900' AS DateTime), NULL, 1, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (9, N'test', CAST(N'2023-03-26T11:31:56.817' AS DateTime), 9, NULL, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (10, N'tes', CAST(N'2023-03-26T11:32:07.343' AS DateTime), NULL, NULL, 2)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (12, N'drfgdsfg', CAST(N'2023-03-26T13:30:24.383' AS DateTime), NULL, NULL, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (14, N'TEST-MATUTINO', CAST(N'2023-05-10T22:51:55.710' AS DateTime), 11, 6, 1)
GO
INSERT [dbo].[grupos] ([id_grupo], [grupo_nombre], [grupo_fecha_registro], [id_grupo_coach], [id_grupo_deporte], [id_grupo_turno]) VALUES (15, N'TEST-VESPERTINO', CAST(N'2023-05-10T22:52:24.887' AS DateTime), NULL, 6, 2)
GO
SET IDENTITY_INSERT [dbo].[grupos] OFF
GO
SET IDENTITY_INSERT [dbo].[fotos_deporte] ON 
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (1, N'1-Test-1.jpg', N'...', CAST(N'2023-03-22T01:52:59.043' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (2, N'2-Test-2.jpg', N'...', CAST(N'2023-03-22T01:53:10.477' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (3, N'3-Test-3.jpg', N'...', CAST(N'2023-03-22T01:58:15.357' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (4, N'4-xD.png', N'...', CAST(N'2023-03-22T02:47:14.830' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (5, N'5-xD.png', N'...', CAST(N'2023-03-22T02:52:53.060' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (6, N'6-xD.png', N'...', CAST(N'2023-03-22T02:55:34.607' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (7, N'7-xD.png', N'...', CAST(N'2023-03-22T03:01:49.403' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (8, N'8-OP.png', N'...', CAST(N'2023-03-22T03:13:20.840' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (9, N'9-jaja.png', N'...', CAST(N'2023-03-22T03:17:46.103' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (14, N'14-vrert.jpg', N'asd', CAST(N'2023-03-22T12:19:26.647' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (15, N'15-rodo.jpg', N'qwerty', CAST(N'2023-03-22T12:27:23.840' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (16, N'16-kl.jpg', N'xD', CAST(N'2023-03-23T15:19:14.340' AS DateTime), 1, N'imagenes')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (17, N'17-NEW-TEST_deporte.jpg', N'uwu', CAST(N'2023-03-28T12:55:15.823' AS DateTime), 1, N'imagenes_deporte')
GO
INSERT [dbo].[fotos_deporte] ([id_fdeporte], [fdeporte_nombre], [fdeporte_descripcion], [fdeporte_fecha_registro], [id_fdeporte_deporte], [fdeporte_tipo_archivo]) VALUES (18, N'18-TEST.png', N'TEST', CAST(N'2023-05-11T00:37:43.117' AS DateTime), 6, N'imagenes_deporte')
GO
SET IDENTITY_INSERT [dbo].[fotos_deporte] OFF
GO
SET IDENTITY_INSERT [dbo].[notas] ON 
GO
INSERT [dbo].[notas] ([id_nota], [nota_titulo], [nota_subtitulo], [nota_texto], [nota_fecha_registro], [id_nota_deporte]) VALUES (1, N'Nota-Test1', N'Sub-Test', N'H
O
L
A

M
U
N
D
O', CAST(N'2023-03-21T16:55:27.463' AS DateTime), 1)
GO
INSERT [dbo].[notas] ([id_nota], [nota_titulo], [nota_subtitulo], [nota_texto], [nota_fecha_registro], [id_nota_deporte]) VALUES (3, N'New-Test', N'New-Test', N'New-Test', CAST(N'2023-03-22T12:31:04.487' AS DateTime), 1)
GO
INSERT [dbo].[notas] ([id_nota], [nota_titulo], [nota_subtitulo], [nota_texto], [nota_fecha_registro], [id_nota_deporte]) VALUES (5, N'TEST', N'TEST', N'TEST', CAST(N'2023-05-10T23:30:32.263' AS DateTime), 6)
GO
SET IDENTITY_INSERT [dbo].[notas] OFF
GO
SET IDENTITY_INSERT [dbo].[calendario] ON 
GO
INSERT [dbo].[calendario] ([id_calendario], [calendario_nombre_evento], [calendario_descripcion_evento], [calendario_fecha_evento], [calendario_fecha_registro], [id_calendario_deporte]) VALUES (1, N'test', N'uwu', CAST(N'2023-10-08T00:00:00.000' AS DateTime), CAST(N'2023-03-29T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[calendario] ([id_calendario], [calendario_nombre_evento], [calendario_descripcion_evento], [calendario_fecha_evento], [calendario_fecha_registro], [id_calendario_deporte]) VALUES (3, N'test2', N'test2', CAST(N'2023-05-19T00:00:00.000' AS DateTime), CAST(N'2023-05-03T23:04:48.310' AS DateTime), 1)
GO
INSERT [dbo].[calendario] ([id_calendario], [calendario_nombre_evento], [calendario_descripcion_evento], [calendario_fecha_evento], [calendario_fecha_registro], [id_calendario_deporte]) VALUES (4, N'TEST3', N'TEST3', CAST(N'2023-05-25T00:00:00.000' AS DateTime), CAST(N'2023-05-03T23:05:18.237' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[calendario] OFF
GO
SET IDENTITY_INSERT [dbo].[inscripciones] ON 
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (4, 8, 2, CAST(N'2023-03-22T08:32:35.630' AS DateTime), 0)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (5, 9, 2, CAST(N'2023-03-22T08:32:59.183' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (6, 2, 2, CAST(N'2023-03-23T16:57:53.093' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (10, 10, 4, CAST(N'2023-03-23T18:15:37.163' AS DateTime), 0)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (11, NULL, 4, CAST(N'2023-03-23T18:15:41.930' AS DateTime), 0)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (12, 5, 4, CAST(N'2023-03-23T18:15:45.570' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (16, 3, 2, CAST(N'2023-03-25T19:13:11.910' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (17, 11, 4, CAST(N'2023-03-25T21:09:02.690' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (20, 11, NULL, CAST(N'2023-03-25T21:28:50.797' AS DateTime), 1)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (22, 11, 9, CAST(N'2023-03-26T11:34:20.603' AS DateTime), 0)
GO
INSERT [dbo].[inscripciones] ([id_inscripcion], [id_inscripcion_deportista], [id_inscripcion_grupo], [inscripcion_fecha_registro], [inscripcion_rooster]) VALUES (23, 10, 9, CAST(N'2023-03-26T11:34:26.263' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[inscripciones] OFF
GO
SET IDENTITY_INSERT [dbo].[fotos_nota] ON 
GO
INSERT [dbo].[fotos_nota] ([id_fnota], [fnota_nombre], [fnota_descripcion], [fnota_fecha_registro], [id_fnota_nota], [fnota_tipo_archivo]) VALUES (1, N'1-fotonota1.jpg', N'uwu', CAST(N'2023-03-26T17:23:27.600' AS DateTime), 3, N'imagenes')
GO
INSERT [dbo].[fotos_nota] ([id_fnota], [fnota_nombre], [fnota_descripcion], [fnota_fecha_registro], [id_fnota_nota], [fnota_tipo_archivo]) VALUES (2, N'2-fotonota2.png', N'7u7', CAST(N'2023-03-26T17:26:46.567' AS DateTime), 3, N'imagenes')
GO
INSERT [dbo].[fotos_nota] ([id_fnota], [fnota_nombre], [fnota_descripcion], [fnota_fecha_registro], [id_fnota_nota], [fnota_tipo_archivo]) VALUES (4, N'4-NEW-TEST_NOTA.png', N'uwu', CAST(N'2023-03-28T12:56:08.133' AS DateTime), 1, N'imagenes_nota')
GO
INSERT [dbo].[fotos_nota] ([id_fnota], [fnota_nombre], [fnota_descripcion], [fnota_fecha_registro], [id_fnota_nota], [fnota_tipo_archivo]) VALUES (5, N'5-TEST.png', N'TEST', CAST(N'2023-05-10T23:38:35.070' AS DateTime), 5, N'imagenes_nota')
GO
SET IDENTITY_INSERT [dbo].[fotos_nota] OFF
GO
SET IDENTITY_INSERT [dbo].[documentos_nota] ON 
GO
INSERT [dbo].[documentos_nota] ([id_dnota], [dnota_nombre], [dnota_descripcion], [dnota_fecha_registro], [id_dnota_nota], [dnota_tipo_archivo]) VALUES (2, N'2-test-file.txt', N'uwu', CAST(N'2023-03-26T21:14:34.347' AS DateTime), 3, N'documentos')
GO
INSERT [dbo].[documentos_nota] ([id_dnota], [dnota_nombre], [dnota_descripcion], [dnota_fecha_registro], [id_dnota_nota], [dnota_tipo_archivo]) VALUES (3, N'3-NEW-TEST_DOC_NOTA.txt', N'nota-test', CAST(N'2023-03-28T12:58:03.327' AS DateTime), 1, N'documentos_nota')
GO
INSERT [dbo].[documentos_nota] ([id_dnota], [dnota_nombre], [dnota_descripcion], [dnota_fecha_registro], [id_dnota_nota], [dnota_tipo_archivo]) VALUES (4, N'4-TEST.txt', N'TEST', CAST(N'2023-05-10T23:34:04.897' AS DateTime), 5, N'documentos_nota')
GO
SET IDENTITY_INSERT [dbo].[documentos_nota] OFF
GO
SET IDENTITY_INSERT [dbo].[fotos_calendario] ON 
GO
INSERT [dbo].[fotos_calendario] ([id_fcalendario], [fcalendario_nombre], [fcalendario_descripcion], [fcalendario_fecha_registro], [id_fcalendario_calendario], [fcalendario_tipo_archivo]) VALUES (1, N'1-calendario_test1.jpg', N'calendario_test1', CAST(N'2023-03-29T17:59:39.177' AS DateTime), 1, N'imagenes_calendario')
GO
INSERT [dbo].[fotos_calendario] ([id_fcalendario], [fcalendario_nombre], [fcalendario_descripcion], [fcalendario_fecha_registro], [id_fcalendario_calendario], [fcalendario_tipo_archivo]) VALUES (3, N'3-TEST.png', N'TEST', CAST(N'2023-05-11T00:30:27.087' AS DateTime), NULL, N'imagenes_calendario')
GO
SET IDENTITY_INSERT [dbo].[fotos_calendario] OFF
GO
SET IDENTITY_INSERT [dbo].[documentos_calendario] ON 
GO
INSERT [dbo].[documentos_calendario] ([id_dcalendario], [dcalendario_nombre], [dcalendario_descripcion], [dcalendario_fecha_registro], [id_dcalendario_calendario], [dcalendario_tipo_archivo]) VALUES (1, N'1-test_doc1.txt', N'test_doc1', CAST(N'2023-03-29T19:23:09.020' AS DateTime), 1, N'documentos_calendario')
GO
INSERT [dbo].[documentos_calendario] ([id_dcalendario], [dcalendario_nombre], [dcalendario_descripcion], [dcalendario_fecha_registro], [id_dcalendario_calendario], [dcalendario_tipo_archivo]) VALUES (3, N'3-TEST2.txt', N'test2', CAST(N'2023-05-03T23:11:07.663' AS DateTime), 1, N'documentos_calendario')
GO
INSERT [dbo].[documentos_calendario] ([id_dcalendario], [dcalendario_nombre], [dcalendario_descripcion], [dcalendario_fecha_registro], [id_dcalendario_calendario], [dcalendario_tipo_archivo]) VALUES (4, N'4-why.txt', N'test3', CAST(N'2023-05-03T23:11:23.237' AS DateTime), 1, N'documentos_calendario')
GO
INSERT [dbo].[documentos_calendario] ([id_dcalendario], [dcalendario_nombre], [dcalendario_descripcion], [dcalendario_fecha_registro], [id_dcalendario_calendario], [dcalendario_tipo_archivo]) VALUES (5, N'5-TEST.txt', N'TEST', CAST(N'2023-05-11T00:26:17.660' AS DateTime), NULL, N'documentos_calendario')
GO
SET IDENTITY_INSERT [dbo].[documentos_calendario] OFF
GO
SET IDENTITY_INSERT [dbo].[administradores] ON 
GO
INSERT [dbo].[administradores] ([id_usuario], [usuario], [password], [cargo], [nombre], [apellido_paterno], [apellido_materno], [activo]) VALUES (1, N'admin', N'test', N'admin', N'Eduardo', N'Espindola', N'Alcantara', 1)
GO
SET IDENTITY_INSERT [dbo].[administradores] OFF
GO
SET IDENTITY_INSERT [dbo].[extensiones_documento] ON 
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (1, N'doc')
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (2, N'docx')
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (3, N'xls')
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (4, N'xlsx')
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (5, N'pdf')
GO
INSERT [dbo].[extensiones_documento] ([id_extension_documento], [extension_documento]) VALUES (6, N'txt')
GO
SET IDENTITY_INSERT [dbo].[extensiones_documento] OFF
GO
SET IDENTITY_INSERT [dbo].[extensiones_foto] ON 
GO
INSERT [dbo].[extensiones_foto] ([id_extension_foto], [extension_foto]) VALUES (1, N'png')
GO
INSERT [dbo].[extensiones_foto] ([id_extension_foto], [extension_foto]) VALUES (2, N'jpg')
GO
INSERT [dbo].[extensiones_foto] ([id_extension_foto], [extension_foto]) VALUES (3, N'gif')
GO
SET IDENTITY_INSERT [dbo].[extensiones_foto] OFF
GO
SET IDENTITY_INSERT [dbo].[politicas_archivos] ON 
GO
INSERT [dbo].[politicas_archivos] ([id_politica], [estatus], [peso], [alto], [ancho], [tipo_archivo], [ruta_virtual], [ruta_fisica]) VALUES (1, 1, 5000, 600, 1600, N'imagenes_deporte', N'http://localhost//files_imagenes/', N'D:\Usuario\Pictures\img_upload\')
GO
INSERT [dbo].[politicas_archivos] ([id_politica], [estatus], [peso], [alto], [ancho], [tipo_archivo], [ruta_virtual], [ruta_fisica]) VALUES (2, 1, 10000, 0, 0, N'documentos_nota', N'http://localhost//files_documentos/', N'D:\Usuario\Pictures\img_upload\')
GO
INSERT [dbo].[politicas_archivos] ([id_politica], [estatus], [peso], [alto], [ancho], [tipo_archivo], [ruta_virtual], [ruta_fisica]) VALUES (3, 1, 5000, 600, 1600, N'imagenes_nota', N'http://localhost//files_imagenes/', N'D:\Usuario\Pictures\img_upload\')
GO
INSERT [dbo].[politicas_archivos] ([id_politica], [estatus], [peso], [alto], [ancho], [tipo_archivo], [ruta_virtual], [ruta_fisica]) VALUES (4, 1, 10000, 0, 0, N'documentos_calendario', N'http://localhost//files_documentos/', N'D:\Usuario\Pictures\img_upload\')
GO
INSERT [dbo].[politicas_archivos] ([id_politica], [estatus], [peso], [alto], [ancho], [tipo_archivo], [ruta_virtual], [ruta_fisica]) VALUES (5, 1, 5000, 600, 1600, N'imagenes_calendario', N'http://localhost//files_imagenes/', N'D:\Usuario\Pictures\img_upload\')
GO
SET IDENTITY_INSERT [dbo].[politicas_archivos] OFF
GO
