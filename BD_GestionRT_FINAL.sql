USE [master]
GO
/****** Object:  Database [BD_GestionRecursosTecnologicos]    Script Date: 16/6/2022 15:35:47 ******/
CREATE DATABASE [BD_GestionRecursosTecnologicos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_GestionRecursosTecnologicos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_GestionRecursosTecnologicos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_GestionRecursosTecnologicos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_GestionRecursosTecnologicos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_GestionRecursosTecnologicos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET  MULTI_USER 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET QUERY_STORE = OFF
GO
USE [BD_GestionRecursosTecnologicos]
GO
/****** Object:  Table [dbo].[AsignacionCientificoDelCI]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignacionCientificoDelCI](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idAsignacionCientifico] [int] IDENTITY(1,1) NOT NULL,
	[idPersonalCientifico] [int] NULL,
 CONSTRAINT [PK_AsignacionCientificoDelCI] PRIMARY KEY CLUSTERED 
(
	[idAsignacionCientifico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsignacionResponsableTecnicoRT]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignacionResponsableTecnicoRT](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idAsignacionRTRT] [int] IDENTITY(1,1) NOT NULL,
	[idPersonalCientifico] [int] NOT NULL,
 CONSTRAINT [PK_AsignacionResponsableTecnicoRT] PRIMARY KEY CLUSTERED 
(
	[idAsignacionRTRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstadoRT]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstadoRT](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idEstado] [int] NOT NULL,
	[idCambioEstadoRT] [int] IDENTITY(1,1) NOT NULL,
	[numeroRT] [int] NULL,
 CONSTRAINT [PK_CambioEstadoRT] PRIMARY KEY CLUSTERED 
(
	[idCambioEstadoRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstadoTurno]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstadoTurno](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idEstado] [int] NOT NULL,
	[idCET] [int] IDENTITY(1,1) NOT NULL,
	[idTurno] [int] NOT NULL,
 CONSTRAINT [PK_CambioEstadoTurno] PRIMARY KEY CLUSTERED 
(
	[idCET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[nombre] [varchar](50) NULL,
	[ambito] [varchar](50) NULL,
	[esCancelable] [bit] NOT NULL,
	[esReservable] [bit] NOT NULL,
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimiento]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimiento](
	[fechaHoraFin] [datetime] NULL,
	[fechaHoraInicio] [datetime] NULL,
	[motivoMantenimiento] [varchar](50) NULL,
	[idMantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[numeroRT] [int] NOT NULL,
 CONSTRAINT [PK_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	[idMantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[nombre] [varchar](50) NULL,
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[idModelo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[idMarca] [int] NOT NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[idModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalCientifico]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalCientifico](
	[idPersonalCientifico] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[correoElectronico] [varchar](50) NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_PersonalCientifico] PRIMARY KEY CLUSTERED 
(
	[idPersonalCientifico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecursoTecnologico]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecursoTecnologico](
	[numeroRT] [int] IDENTITY(1,1) NOT NULL,
	[fechaAlta] [datetime] NULL,
	[idtipoRecurso] [int] NOT NULL,
	[idModelo] [int] NOT NULL,
	[idAsignacionResponsableRT] [int] NOT NULL,
 CONSTRAINT [PK_RecursoTecnologico] PRIMARY KEY CLUSTERED 
(
	[numeroRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idUsuario] [int] NULL,
	[idSesion] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Sesion] PRIMARY KEY CLUSTERED 
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoRecursoTecnologico]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRecursoTecnologico](
	[idTipoRecurso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoRercursoTecnologico] PRIMARY KEY CLUSTERED 
(
	[idTipoRecurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[fechaHoraFin] [datetime] NULL,
	[fechaHoraInicio] [datetime] NULL,
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[numeroRT] [int] NOT NULL,
	[idAsignacionCientifico] [int] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/6/2022 15:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nombre] [varchar](50) NULL,
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AsignacionCientificoDelCI] ON 

INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2020-04-10T16:00:00.000' AS DateTime), NULL, 8, 1)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2020-04-10T16:00:00.000' AS DateTime), NULL, 9, 2)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2010-04-10T16:00:00.000' AS DateTime), NULL, 10, 3)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2018-04-10T16:00:00.000' AS DateTime), NULL, 11, 4)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2014-04-10T16:00:00.000' AS DateTime), NULL, 12, 5)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2011-04-10T16:00:00.000' AS DateTime), NULL, 13, 6)
INSERT [dbo].[AsignacionCientificoDelCI] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionCientifico], [idPersonalCientifico]) VALUES (CAST(N'2016-04-10T16:00:00.000' AS DateTime), NULL, 14, 10)
SET IDENTITY_INSERT [dbo].[AsignacionCientificoDelCI] OFF
GO
SET IDENTITY_INSERT [dbo].[AsignacionResponsableTecnicoRT] ON 

INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-10T00:00:20.000' AS DateTime), CAST(N'2022-06-10T00:02:00.000' AS DateTime), 1, 1)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-11T00:00:20.000' AS DateTime), NULL, 2, 1)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-12T00:00:20.000' AS DateTime), CAST(N'2022-04-12T00:02:00.000' AS DateTime), 3, 2)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-13T00:00:20.000' AS DateTime), NULL, 4, 2)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-16T00:00:20.000' AS DateTime), CAST(N'2022-08-16T00:00:40.000' AS DateTime), 5, 3)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-16T00:00:40.000' AS DateTime), NULL, 6, 3)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-16T10:00:45.000' AS DateTime), CAST(N'2022-03-17T00:00:40.000' AS DateTime), 18, 4)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-02-22T12:00:00.000' AS DateTime), NULL, 19, 4)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T11:00:00.000' AS DateTime), CAST(N'2022-05-10T11:00:00.000' AS DateTime), 20, 5)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T16:00:00.000' AS DateTime), NULL, 21, 5)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T16:00:00.000' AS DateTime), CAST(N'2022-11-10T16:00:00.000' AS DateTime), 23, 6)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T16:00:00.000' AS DateTime), NULL, 24, 6)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T16:00:00.000' AS DateTime), CAST(N'2022-12-10T16:00:00.000' AS DateTime), 25, 10)
INSERT [dbo].[AsignacionResponsableTecnicoRT] ([fechaHoraDesde], [fechaHoraHasta], [idAsignacionRTRT], [idPersonalCientifico]) VALUES (CAST(N'2022-04-10T16:00:00.000' AS DateTime), NULL, 26, 10)
SET IDENTITY_INSERT [dbo].[AsignacionResponsableTecnicoRT] OFF
GO
SET IDENTITY_INSERT [dbo].[CambioEstadoRT] ON 

INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-13T00:00:00.000' AS DateTime), CAST(N'2022-05-13T03:00:00.000' AS DateTime), 24, 1, 1)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T00:00:00.000' AS DateTime), NULL, 24, 2, 1)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-16T00:00:00.000' AS DateTime), CAST(N'2022-03-13T00:00:00.000' AS DateTime), 24, 3, 2)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-16T00:00:00.000' AS DateTime), NULL, 24, 4, 2)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2021-10-09T20:00:00.000' AS DateTime), CAST(N'2022-11-13T00:00:00.000' AS DateTime), 24, 5, 3)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2021-10-09T20:00:00.000' AS DateTime), NULL, 24, 6, 3)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2021-10-10T20:00:00.000' AS DateTime), CAST(N'2022-01-13T00:00:00.000' AS DateTime), 24, 7, 4)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2021-10-10T20:00:00.000' AS DateTime), NULL, 24, 9, 4)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2021-10-10T20:00:00.000' AS DateTime), CAST(N'2022-11-13T00:00:00.000' AS DateTime), 24, 10, 5)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-06-15T22:58:31.730' AS DateTime), NULL, 24, 11, 5)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-06-13T00:00:00.000' AS DateTime), 24, 12, 6)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 16, 6)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-05-15T23:09:38.593' AS DateTime), 24, 19, 7)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 20, 7)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-03-15T23:09:38.593' AS DateTime), 24, 21, 8)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 22, 8)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-08-15T23:09:38.593' AS DateTime), 24, 23, 9)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 24, 9)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2023-03-15T23:09:38.593' AS DateTime), 24, 29, 11)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 30, 11)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-11-15T23:09:38.593' AS DateTime), 24, 31, 12)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 32, 12)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-12-15T23:09:38.593' AS DateTime), 24, 33, 13)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 34, 13)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), CAST(N'2022-11-15T23:09:38.593' AS DateTime), 24, 38, 14)
INSERT [dbo].[CambioEstadoRT] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCambioEstadoRT], [numeroRT]) VALUES (CAST(N'2022-03-15T23:09:38.593' AS DateTime), NULL, 24, 39, 14)
SET IDENTITY_INSERT [dbo].[CambioEstadoRT] OFF
GO
SET IDENTITY_INSERT [dbo].[CambioEstadoTurno] ON 

INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-03-13T00:00:00.000' AS DateTime), NULL, 27, 9, 2)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-03-15T00:00:00.000' AS DateTime), NULL, 27, 13, 5)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-03-16T00:00:00.000' AS DateTime), NULL, 27, 15, 7)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-03-13T00:00:00.000' AS DateTime), NULL, 27, 20, 9)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-03-13T00:00:00.000' AS DateTime), NULL, 27, 21, 15)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T22:58:31.730' AS DateTime), NULL, 25, 22, 16)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 23, 17)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 25, 19)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 26, 20)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 27, 21)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 28, 22)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 29, 23)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 30, 24)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 31, 25)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 32, 26)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 33, 27)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 34, 28)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 35, 29)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 36, 30)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 37, 31)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 38, 32)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 39, 33)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 40, 35)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 41, 36)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 42, 37)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 43, 38)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 44, 39)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 46, 40)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 47, 41)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 27, 48, 42)
INSERT [dbo].[CambioEstadoTurno] ([fechaHoraDesde], [fechaHoraHasta], [idEstado], [idCET], [idTurno]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), NULL, 25, 49, 43)
SET IDENTITY_INSERT [dbo].[CambioEstadoTurno] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([nombre], [ambito], [esCancelable], [esReservable], [idEstado], [descripcion]) VALUES (N'Ingresado a Mantenimiento Correctivo', N'Recurso Tecnologico', 1, 0, 8, NULL)
INSERT [dbo].[Estado] ([nombre], [ambito], [esCancelable], [esReservable], [idEstado], [descripcion]) VALUES (N'Disponible', N'Recurso Tecnologico', 1, 1, 24, N'estadort')
INSERT [dbo].[Estado] ([nombre], [ambito], [esCancelable], [esReservable], [idEstado], [descripcion]) VALUES (N'Pendiente de confirmacion', N'Turno', 1, 1, 25, N'desrip')
INSERT [dbo].[Estado] ([nombre], [ambito], [esCancelable], [esReservable], [idEstado], [descripcion]) VALUES (N'Cancelado', N'Turno', 1, 0, 26, N'os')
INSERT [dbo].[Estado] ([nombre], [ambito], [esCancelable], [esReservable], [idEstado], [descripcion]) VALUES (N'Confirmado', N'Turno', 1, 0, 27, N'null')
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO
SET IDENTITY_INSERT [dbo].[Mantenimiento] ON 

INSERT [dbo].[Mantenimiento] ([fechaHoraFin], [fechaHoraInicio], [motivoMantenimiento], [idMantenimiento], [numeroRT]) VALUES (CAST(N'2022-03-13T03:00:00.000' AS DateTime), CAST(N'2022-03-13T00:00:00.000' AS DateTime), N'se rompio', 3, 7)
INSERT [dbo].[Mantenimiento] ([fechaHoraFin], [fechaHoraInicio], [motivoMantenimiento], [idMantenimiento], [numeroRT]) VALUES (CAST(N'2022-03-15T03:00:00.000' AS DateTime), CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'no se', 7, 3)
INSERT [dbo].[Mantenimiento] ([fechaHoraFin], [fechaHoraInicio], [motivoMantenimiento], [idMantenimiento], [numeroRT]) VALUES (CAST(N'2022-06-15T23:09:38.593' AS DateTime), CAST(N'2022-03-16T00:00:00.000' AS DateTime), N'tiene un agujero', 8, 2)
INSERT [dbo].[Mantenimiento] ([fechaHoraFin], [fechaHoraInicio], [motivoMantenimiento], [idMantenimiento], [numeroRT]) VALUES (CAST(N'2022-10-24T00:00:00.000' AS DateTime), CAST(N'2022-06-15T22:58:31.730' AS DateTime), N'exploto ', 9, 13)
INSERT [dbo].[Mantenimiento] ([fechaHoraFin], [fechaHoraInicio], [motivoMantenimiento], [idMantenimiento], [numeroRT]) VALUES (CAST(N'2022-10-26T00:00:00.000' AS DateTime), CAST(N'2022-06-15T23:09:38.593' AS DateTime), N'se quemo', 10, 11)
SET IDENTITY_INSERT [dbo].[Mantenimiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Leica', 1)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Noblex', 2)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Panasonic', 3)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'LG', 4)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Philips', 5)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Lenovo', 6)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'DELL', 7)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'SONY', 8)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'Zeis', 9)
INSERT [dbo].[Marca] ([nombre], [idMarca]) VALUES (N'NIKON', 10)
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelo] ON 

INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (1, N'K51S', 4)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (2, N'K61', 4)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (3, N'N14Z25', 2)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (4, N'PK423', 2)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (5, N'LK327 2008', 3)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (6, N'UPF423', 3)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (8, N'Modelo C', 1)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (9, N'Modelo B', 1)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (10, N'KPI 2020', 8)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (11, N'XPERIA', 8)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (12, N'Inspiron', 7)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (13, N'Latitude', 7)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (14, N'BRI9', 5)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (15, N'MG57', 5)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (16, N'XNP83', 6)
INSERT [dbo].[Modelo] ([idModelo], [nombre], [idMarca]) VALUES (17, N'LPK32', 6)
SET IDENTITY_INSERT [dbo].[Modelo] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonalCientifico] ON 

INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (1, N'Succar', N'Agustin', N'succar@gmail.com', 1)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (2, N'Cesar', N'Fidel', N'fidel@hotmail.com', 2)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (3, N'Garcia', N'Francisco', N'frangarcia@gmail.com', 3)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (4, N'Paris', N'Tomas', N'tomiParis@gmail.com', 4)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (5, N'Ebner', N'Nahuel', N'nahuel@gmailc', 5)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (6, N'Ormeño', N'Gerardo', N'geraormeno@gmail.com', 6)
INSERT [dbo].[PersonalCientifico] ([idPersonalCientifico], [apellido], [nombre], [correoElectronico], [idUsuario]) VALUES (10, N'García', N'Martín', N'sargentogarcia@hotmail.com', 7)
SET IDENTITY_INSERT [dbo].[PersonalCientifico] OFF
GO
SET IDENTITY_INSERT [dbo].[RecursoTecnologico] ON 

INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (1, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 1, 1, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (2, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 1, 2, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (3, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 2, 3, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (4, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 2, 4, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (5, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 3, 5, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (6, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 3, 6, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (7, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 4, 8, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (8, CAST(N'2021-10-09T15:00:00.000' AS DateTime), 4, 9, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (9, CAST(N'2021-10-09T19:00:00.000' AS DateTime), 5, 10, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (11, CAST(N'2021-10-09T20:00:00.000' AS DateTime), 5, 11, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (12, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 6, 12, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (13, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 6, 13, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (14, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 7, 14, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (16, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 7, 15, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (17, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 8, 16, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (18, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 8, 17, 26)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [idtipoRecurso], [idModelo], [idAsignacionResponsableRT]) VALUES (19, CAST(N'2021-10-10T20:00:00.000' AS DateTime), 8, 17, 6)
SET IDENTITY_INSERT [dbo].[RecursoTecnologico] OFF
GO
SET IDENTITY_INSERT [dbo].[Sesion] ON 

INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-02-13T00:00:00.000' AS DateTime), CAST(N'2022-02-13T03:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-02-14T13:00:00.000' AS DateTime), CAST(N'2022-02-14T19:35:00.000' AS DateTime), 2, 2)
INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-03-25T18:25:00.000' AS DateTime), CAST(N'2022-03-25T20:30:00.000' AS DateTime), 3, 3)
INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-03-29T16:25:00.000' AS DateTime), CAST(N'2022-03-29T21:00:00.000' AS DateTime), 4, 4)
INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-03-29T16:02:00.000' AS DateTime), CAST(N'2022-03-29T21:00:00.000' AS DateTime), 5, 5)
INSERT [dbo].[Sesion] ([fechaHoraDesde], [fechaHoraHasta], [idUsuario], [idSesion]) VALUES (CAST(N'2022-03-29T16:12:00.000' AS DateTime), NULL, 7, 6)
SET IDENTITY_INSERT [dbo].[Sesion] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoRecursoTecnologico] ON 

INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (1, N'Balanza de Medicion')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (2, N'Microscopio de Medicion')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (3, N'Notebook')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (4, N'Impresora Laser')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (5, N'Camara Digital')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (6, N'Brazo Electrico')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (7, N'Montacarga')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (8, N'Mezcaldora')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (9, N'Celular')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (10, N'Destornillador Electrico')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (11, N'Monitor')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (12, N'Televisor')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (13, N'Calorimetro')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (14, N'Calibre')
INSERT [dbo].[TipoRecursoTecnologico] ([idTipoRecurso], [nombre]) VALUES (15, N'Electroscopio')
SET IDENTITY_INSERT [dbo].[TipoRecursoTecnologico] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T08:00:00.000' AS DateTime), CAST(N'2022-06-17T07:00:00.000' AS DateTime), 2, 1, 8)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T09:00:00.000' AS DateTime), CAST(N'2022-06-17T08:00:00.000' AS DateTime), 5, 1, 9)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T10:00:00.000' AS DateTime), CAST(N'2022-06-17T09:00:00.000' AS DateTime), 7, 1, 10)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T11:00:00.000' AS DateTime), CAST(N'2022-06-17T10:00:00.000' AS DateTime), 9, 2, 11)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T12:00:00.000' AS DateTime), CAST(N'2022-06-17T11:00:00.000' AS DateTime), 15, 2, 12)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T13:00:00.000' AS DateTime), CAST(N'2022-06-17T12:00:00.000' AS DateTime), 16, 2, 13)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T14:00:00.000' AS DateTime), CAST(N'2022-06-17T13:00:00.000' AS DateTime), 17, 3, 14)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T15:00:00.000' AS DateTime), CAST(N'2022-06-17T14:00:00.000' AS DateTime), 19, 3, 8)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T16:00:00.000' AS DateTime), CAST(N'2022-06-17T15:00:00.000' AS DateTime), 20, 4, 9)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-20T17:00:00.000' AS DateTime), CAST(N'2022-06-20T16:00:00.000' AS DateTime), 21, 4, 10)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T18:00:00.000' AS DateTime), CAST(N'2022-06-17T17:00:00.000' AS DateTime), 22, 4, 11)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T19:00:00.000' AS DateTime), CAST(N'2022-06-17T18:00:00.000' AS DateTime), 23, 4, 12)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-20T20:00:00.000' AS DateTime), CAST(N'2022-06-20T19:00:00.000' AS DateTime), 24, 4, 13)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T21:00:00.000' AS DateTime), CAST(N'2022-06-17T20:00:00.000' AS DateTime), 25, 6, 14)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T22:00:00.000' AS DateTime), CAST(N'2022-06-17T21:00:00.000' AS DateTime), 26, 6, 8)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T08:30:00.000' AS DateTime), CAST(N'2022-06-17T22:00:00.000' AS DateTime), 27, 7, 9)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T09:30:00.000' AS DateTime), CAST(N'2022-06-17T08:30:00.000' AS DateTime), 28, 7, 10)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T10:30:00.000' AS DateTime), CAST(N'2022-06-17T09:30:00.000' AS DateTime), 29, 7, 11)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T11:30:00.000' AS DateTime), CAST(N'2022-06-17T10:30:00.000' AS DateTime), 30, 8, 12)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T12:30:00.000' AS DateTime), CAST(N'2022-06-17T11:30:00.000' AS DateTime), 31, 9, 13)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T13:30:00.000' AS DateTime), CAST(N'2022-06-17T12:30:00.000' AS DateTime), 32, 9, 14)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T14:30:00.000' AS DateTime), CAST(N'2022-06-17T13:30:00.000' AS DateTime), 33, 11, 8)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T15:30:00.000' AS DateTime), CAST(N'2022-06-17T14:30:00.000' AS DateTime), 35, 11, 9)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T16:30:00.000' AS DateTime), CAST(N'2022-06-17T15:30:00.000' AS DateTime), 36, 12, 10)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T17:30:00.000' AS DateTime), CAST(N'2022-06-17T16:30:00.000' AS DateTime), 37, 12, 11)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T18:30:00.000' AS DateTime), CAST(N'2022-06-17T17:30:00.000' AS DateTime), 38, 12, 12)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T19:30:00.000' AS DateTime), CAST(N'2022-06-17T18:30:00.000' AS DateTime), 39, 12, 13)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T20:30:00.000' AS DateTime), CAST(N'2022-06-17T19:30:00.000' AS DateTime), 40, 13, 14)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T21:30:00.000' AS DateTime), CAST(N'2022-06-17T20:30:00.000' AS DateTime), 41, 14, 8)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T22:30:00.000' AS DateTime), CAST(N'2022-06-17T21:30:00.000' AS DateTime), 42, 14, 9)
INSERT [dbo].[Turno] ([fechaHoraFin], [fechaHoraInicio], [idTurno], [numeroRT], [idAsignacionCientifico]) VALUES (CAST(N'2022-06-17T23:30:00.000' AS DateTime), CAST(N'2022-06-17T22:30:00.000' AS DateTime), 43, 14, 10)
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Agustin', 1, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Fidel', 2, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Fran', 3, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Tomas', 4, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Nahuel', 5, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Gerardo', 6, N'123456')
INSERT [dbo].[Usuario] ([nombre], [idUsuario], [password]) VALUES (N'Andres', 7, N'123456')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionCientificoDelCI_PersonalCientifico] FOREIGN KEY([idPersonalCientifico])
REFERENCES [dbo].[PersonalCientifico] ([idPersonalCientifico])
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI] CHECK CONSTRAINT [FK_AsignacionCientificoDelCI_PersonalCientifico]
GO
ALTER TABLE [dbo].[AsignacionResponsableTecnicoRT]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionResponsableTecnicoRT_PersonalCientifico] FOREIGN KEY([idPersonalCientifico])
REFERENCES [dbo].[PersonalCientifico] ([idPersonalCientifico])
GO
ALTER TABLE [dbo].[AsignacionResponsableTecnicoRT] CHECK CONSTRAINT [FK_AsignacionResponsableTecnicoRT_PersonalCientifico]
GO
ALTER TABLE [dbo].[CambioEstadoRT]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoRT_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[CambioEstadoRT] CHECK CONSTRAINT [FK_CambioEstadoRT_RecursoTecnologico]
GO
ALTER TABLE [dbo].[CambioEstadoTurno]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoTurno_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[CambioEstadoTurno] CHECK CONSTRAINT [FK_CambioEstadoTurno_Estado]
GO
ALTER TABLE [dbo].[CambioEstadoTurno]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoTurno_Turno] FOREIGN KEY([idTurno])
REFERENCES [dbo].[Turno] ([idTurno])
GO
ALTER TABLE [dbo].[CambioEstadoTurno] CHECK CONSTRAINT [FK_CambioEstadoTurno_Turno]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [FK_Modelo_Modelo] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marca] ([idMarca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [FK_Modelo_Modelo]
GO
ALTER TABLE [dbo].[PersonalCientifico]  WITH CHECK ADD  CONSTRAINT [FK_PersonalCientifico_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[PersonalCientifico] CHECK CONSTRAINT [FK_PersonalCientifico_Usuario]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_AsignacionResponsableTecnicoRT] FOREIGN KEY([idAsignacionResponsableRT])
REFERENCES [dbo].[AsignacionResponsableTecnicoRT] ([idAsignacionRTRT])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_AsignacionResponsableTecnicoRT]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_Modelo] FOREIGN KEY([idModelo])
REFERENCES [dbo].[Modelo] ([idModelo])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_Modelo]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_TipoRercursoTecnologico] FOREIGN KEY([idtipoRecurso])
REFERENCES [dbo].[TipoRecursoTecnologico] ([idTipoRecurso])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_TipoRercursoTecnologico]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_Usuario]
GO
USE [master]
GO
ALTER DATABASE [BD_GestionRecursosTecnologicos] SET  READ_WRITE 
GO
