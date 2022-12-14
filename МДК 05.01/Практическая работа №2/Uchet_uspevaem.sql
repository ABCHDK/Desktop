USE [master]
GO
/****** Object:  Database [Uchet_uspevaem]    Script Date: 03.05.2022 12:52:27 ******/
CREATE DATABASE [Uchet_uspevaem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Uchet_uspevaem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Uchet_uspevaem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Uchet_uspevaem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Uchet_uspevaem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Uchet_uspevaem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Uchet_uspevaem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Uchet_uspevaem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET ARITHABORT OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Uchet_uspevaem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Uchet_uspevaem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Uchet_uspevaem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Uchet_uspevaem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET RECOVERY FULL 
GO
ALTER DATABASE [Uchet_uspevaem] SET  MULTI_USER 
GO
ALTER DATABASE [Uchet_uspevaem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Uchet_uspevaem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Uchet_uspevaem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Uchet_uspevaem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Uchet_uspevaem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Uchet_uspevaem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Uchet_uspevaem', N'ON'
GO
ALTER DATABASE [Uchet_uspevaem] SET QUERY_STORE = OFF
GO
USE [Uchet_uspevaem]
GO
/****** Object:  Table [dbo].[Discipliny]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipliny](
	[ID_discipl] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Discipliny_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gruppa]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gruppa](
	[ID_grup] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Gruppa_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[ID_kurs] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Kurs_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialnost]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialnost](
	[ID_special] [int] NOT NULL,
	[Name] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Specialnost_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID_stud] [int] NOT NULL,
	[Familiya] [nchar](15) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Otchestvo] [nchar](20) NOT NULL,
	[Special_ID] [int] NOT NULL,
	[Kurs_ID] [int] NOT NULL,
	[Discipl_ID] [int] NOT NULL,
	[Grup_ID] [int] NOT NULL,
	[Uch_god_ID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID_stud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucheb_god]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucheb_god](
	[ID_uch_god] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Ucheb_god_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03.05.2022 12:52:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[login] [nvarchar](20) NOT NULL,
	[password] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (10, N'Английский язык')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (8, N'Астрономия')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (2, N'История')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (3, N'Литература')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (5, N'Математика')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (6, N'Русский язык')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (7, N'Физика')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (4, N'Физ-ра')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (1, N'Философия')
INSERT [dbo].[Discipliny] ([ID_discipl], [Name]) VALUES (9, N'Химия')
GO
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (1, N'18-А      ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (2, N'18-МиТОМ  ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (4, N'19-Ис     ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (3, N'19-ТМ     ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (5, N'19-Э      ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (9, N'20-Б      ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (6, N'20-МОСиДР ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (7, N'20-Сл     ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (10, N'20-ТМ     ')
INSERT [dbo].[Gruppa] ([ID_grup], [Name]) VALUES (8, N'20-Эл     ')
GO
INSERT [dbo].[Kurs] ([ID_kurs], [Name]) VALUES (1, N'1 курс    ')
INSERT [dbo].[Kurs] ([ID_kurs], [Name]) VALUES (2, N'2 курс    ')
INSERT [dbo].[Kurs] ([ID_kurs], [Name]) VALUES (3, N'3 курс    ')
INSERT [dbo].[Kurs] ([ID_kurs], [Name]) VALUES (4, N'4 курс    ')
GO
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (1, N'08.01.25 Мастер отделочных строительных и декоративных работ                                        ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (2, N'08.02.01 Строительство и эксплуатация зданий и сооружений                                           ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (3, N'08.02.09 Монтаж, наладка и эксплуатация электрооборудования промышленных и гражданских зданий       ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (4, N'09.02.07 Информационные системы и программирование                                                  ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (5, N'13.01.10 Электромонтер по ремонту и обслуживанию электрооборудования                                ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (6, N'15.01.05 Сварщик                                                                                    ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (7, N'15.01.30 Слесарь                                                                                    ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (8, N'15.02.08 Технология машиностроения                                                                  ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (9, N'22.01.08 Оператор прокатного производства                                                           ')
INSERT [dbo].[Specialnost] ([ID_special], [Name]) VALUES (10, N'22.02.01 Металлургия черных металлов                                                                ')
GO
INSERT [dbo].[Student] ([ID_stud], [Familiya], [Name], [Otchestvo], [Special_ID], [Kurs_ID], [Discipl_ID], [Grup_ID], [Uch_god_ID]) VALUES (1, N'Владимирова    ', N'Дианна    ', N'Романновна          ', 2, 3, 2, 2, 1)
INSERT [dbo].[Student] ([ID_stud], [Familiya], [Name], [Otchestvo], [Special_ID], [Kurs_ID], [Discipl_ID], [Grup_ID], [Uch_god_ID]) VALUES (2, N'Будыин         ', N'Сергей    ', N'Михайлович          ', 3, 1, 2, 3, 1)
INSERT [dbo].[Student] ([ID_stud], [Familiya], [Name], [Otchestvo], [Special_ID], [Kurs_ID], [Discipl_ID], [Grup_ID], [Uch_god_ID]) VALUES (3, N'Глеков         ', N'Дмитрий   ', N'Алексеевич          ', 4, 3, 4, 5, 2)
GO
INSERT [dbo].[Ucheb_god] ([ID_uch_god], [Name]) VALUES (3, N'2018-2022 ')
INSERT [dbo].[Ucheb_god] ([ID_uch_god], [Name]) VALUES (2, N'2019-2023 ')
INSERT [dbo].[Ucheb_god] ([ID_uch_god], [Name]) VALUES (4, N'2020-2024 ')
INSERT [dbo].[Ucheb_god] ([ID_uch_god], [Name]) VALUES (1, N'2021-2022 ')
INSERT [dbo].[Ucheb_god] ([ID_uch_god], [Name]) VALUES (5, N'2021-2025 ')
GO
INSERT [dbo].[Users] ([ID], [login], [password]) VALUES (1, N'Student', N'baba')
INSERT [dbo].[Users] ([ID], [login], [password]) VALUES (2, N'Prepod', N'dada')
GO
USE [master]
GO
ALTER DATABASE [Uchet_uspevaem] SET  READ_WRITE 
GO
