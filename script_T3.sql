USE [Financisto]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Currency] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
	[Limit] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[File]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[File](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Path] [nvarchar](max) NULL,
 CONSTRAINT [PK_File] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Document] [nvarchar](8) NOT NULL,
	[Gender] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutina]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina](
	[RutinaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
	[TipoRutinaId] [int] NOT NULL,
 CONSTRAINT [PK_Rutina] PRIMARY KEY CLUSTERED 
(
	[RutinaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RutinaEjercicio]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RutinaEjercicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[duracion] [decimal](18, 2) NOT NULL,
	[EjercicioId] [int] NOT NULL,
	[RutinaId] [int] NOT NULL,
 CONSTRAINT [PK_RutinaEjercicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoRutina]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRutina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Codigo] [int] NOT NULL,
	[CantidadSeleccion] [int] NOT NULL,
 CONSTRAINT [PK_TipoRutina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[Summary] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Type] [nvarchar](max) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 05/11/2020 11:39:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201106042902_InitialCreate', N'3.1.9')
GO
SET IDENTITY_INSERT [dbo].[Ejercicio] ON 

INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (1, N'Ejercicio 1', N'https://www.youtube.com/watch?v=FNjIUpYz4hs')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (2, N'Ejercicio 18', N'https://www.youtube.com/watch?v=EuEoM-17xHQ')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (3, N'Ejercicio 17', N'https://www.youtube.com/watch?v=u-EWpP5hQpc')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (4, N'Ejercicio 16', N'https://www.youtube.com/watch?v=4rNi8bQIdFY')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (5, N'Ejercicio 15', N'https://www.youtube.com/watch?v=5FRTNWPWSOA')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (6, N'Ejercicio 14', N'https://www.youtube.com/watch?v=bp5sGtLpP1s')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (7, N'Ejercicio 13', N'https://www.youtube.com/watch?v=mcjMSQCNkbQ')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (8, N'Ejercicio 12', N'https://www.youtube.com/watch?v=gMGEySHegj4')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (9, N'Ejercicio 11', N'https://www.youtube.com/watch?v=g0z0rqoSmxY')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (10, N'Ejercicio 10', N'https://www.youtube.com/watch?v=Ap4VyHSwmwg')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (11, N'Ejercicio 9', N'https://www.youtube.com/watch?v=tzfEOXrFEJs')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (12, N'Ejercicio 8', N'https://www.youtube.com/watch?v=QhuMeVnn_qU')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (13, N'Ejercicio 7', N'https://www.youtube.com/watch?v=diFjQVUL7wk')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (14, N'Ejercicio 6', N'https://www.youtube.com/watch?v=7qq9lwEWlP0')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (15, N'Ejercicio 5', N'https://www.youtube.com/watch?v=iQ3g-gqKe_A')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (16, N'Ejercicio 4', N'https://www.youtube.com/watch?v=KxfcndYWRx4')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (17, N'Ejercicio 3', N'https://www.youtube.com/watch?v=rgAM7bGtazU')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (18, N'Ejercicio 2', N'https://www.youtube.com/watch?v=MY_gyv3ZDLE')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (19, N'Ejercicio 19', N'https://www.youtube.com/watch?v=BkxBL5cEu-8')
INSERT [dbo].[Ejercicio] ([Id], [Nombre], [Link]) VALUES (20, N'Ejercicio 20', N'https://www.youtube.com/watch?v=nOGxuKwqzrM')
SET IDENTITY_INSERT [dbo].[Ejercicio] OFF
GO
SET IDENTITY_INSERT [dbo].[Rutina] ON 

INSERT [dbo].[Rutina] ([RutinaId], [Nombre], [UserId], [TipoRutinaId]) VALUES (1, N'SEMANA 1', 1, 3)
SET IDENTITY_INSERT [dbo].[Rutina] OFF
GO
SET IDENTITY_INSERT [dbo].[RutinaEjercicio] ON 

INSERT [dbo].[RutinaEjercicio] ([Id], [duracion], [EjercicioId], [RutinaId]) VALUES (1, CAST(105.00 AS Decimal(18, 2)), 16, 1)
INSERT [dbo].[RutinaEjercicio] ([Id], [duracion], [EjercicioId], [RutinaId]) VALUES (2, CAST(109.00 AS Decimal(18, 2)), 4, 1)
INSERT [dbo].[RutinaEjercicio] ([Id], [duracion], [EjercicioId], [RutinaId]) VALUES (3, CAST(102.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[RutinaEjercicio] ([Id], [duracion], [EjercicioId], [RutinaId]) VALUES (4, CAST(74.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[RutinaEjercicio] ([Id], [duracion], [EjercicioId], [RutinaId]) VALUES (5, CAST(82.00 AS Decimal(18, 2)), 6, 1)
SET IDENTITY_INSERT [dbo].[RutinaEjercicio] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoRutina] ON 

INSERT [dbo].[TipoRutina] ([Id], [Nombre], [Codigo], [CantidadSeleccion]) VALUES (1, N'Avanzado', 3, 15)
INSERT [dbo].[TipoRutina] ([Id], [Nombre], [Codigo], [CantidadSeleccion]) VALUES (2, N'Intermedio', 2, 10)
INSERT [dbo].[TipoRutina] ([Id], [Nombre], [Codigo], [CantidadSeleccion]) VALUES (3, N'Principiante', 1, 5)
SET IDENTITY_INSERT [dbo].[TipoRutina] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Username], [Password]) VALUES (1, N'osduar', N'CHtbWNm2i8zfYPYLFS2ru7rH69lVhShO0+A3uAYkaEA=')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Type_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Type_TypeId]
GO
ALTER TABLE [dbo].[Rutina]  WITH CHECK ADD  CONSTRAINT [FK_Rutina_TipoRutina_TipoRutinaId] FOREIGN KEY([TipoRutinaId])
REFERENCES [dbo].[TipoRutina] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rutina] CHECK CONSTRAINT [FK_Rutina_TipoRutina_TipoRutinaId]
GO
ALTER TABLE [dbo].[RutinaEjercicio]  WITH CHECK ADD  CONSTRAINT [FK_RutinaEjercicio_Ejercicio_EjercicioId] FOREIGN KEY([EjercicioId])
REFERENCES [dbo].[Ejercicio] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RutinaEjercicio] CHECK CONSTRAINT [FK_RutinaEjercicio_Ejercicio_EjercicioId]
GO
ALTER TABLE [dbo].[RutinaEjercicio]  WITH CHECK ADD  CONSTRAINT [FK_RutinaEjercicio_Rutina_RutinaId] FOREIGN KEY([RutinaId])
REFERENCES [dbo].[Rutina] ([RutinaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RutinaEjercicio] CHECK CONSTRAINT [FK_RutinaEjercicio_Rutina_RutinaId]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Account_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Account_AccountId]
GO
