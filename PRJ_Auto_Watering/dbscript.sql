USE [master]
GO
/****** Object:  Database [dbPlants]    Script Date: 9/23/2022 4:00:46 PM ******/
CREATE DATABASE [dbPlants]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbPlants', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbPlants.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbPlants_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbPlants_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbPlants] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPlants].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbPlants] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbPlants] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbPlants] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbPlants] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbPlants] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbPlants] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbPlants] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbPlants] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbPlants] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbPlants] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbPlants] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbPlants] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbPlants] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbPlants] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbPlants] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbPlants] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbPlants] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbPlants] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbPlants] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbPlants] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbPlants] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbPlants] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbPlants] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbPlants] SET  MULTI_USER 
GO
ALTER DATABASE [dbPlants] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbPlants] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbPlants] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbPlants] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbPlants] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbPlants] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbPlants] SET QUERY_STORE = OFF
GO
USE [dbPlants]
GO
/****** Object:  Table [dbo].[tblPData]    Script Date: 9/23/2022 4:00:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPData](
	[PlantId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[MoistureLvl] [int] NOT NULL,
	[Description] [varchar](max) NOT NULL,
        [Image] [varchar](max) NOT NULL,
 CONSTRAINT [PK_tblPData] PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPLevels]    Script Date: 9/23/2022 4:00:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPLevels](
	[PlantId] [int] IDENTITY(1,1) NOT NULL,
	[MoistureLvlPre] [int] NOT NULL,
	[MoistureLvlPost] [int] NOT NULL,
	[Date] [datetime] NOT NULL DEFAULT (GETDATE()),
 CONSTRAINT [PK_tblPLevels] PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [dbPlants] SET  READ_WRITE 
GO
