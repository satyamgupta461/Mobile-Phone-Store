USE [master]
GO
/****** Object:  Database [MobilePhoneSales]    Script Date: 02-09-2022 00:30:48 ******/
CREATE DATABASE [MobilePhoneSales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobilePhoneSales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MobilePhoneSales.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MobilePhoneSales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MobilePhoneSales_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MobilePhoneSales] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobilePhoneSales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobilePhoneSales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MobilePhoneSales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobilePhoneSales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobilePhoneSales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MobilePhoneSales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobilePhoneSales] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MobilePhoneSales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MobilePhoneSales] SET  MULTI_USER 
GO
ALTER DATABASE [MobilePhoneSales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobilePhoneSales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobilePhoneSales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobilePhoneSales] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MobilePhoneSales] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MobilePhoneSales] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MobilePhoneSales] SET QUERY_STORE = OFF
GO
USE [MobilePhoneSales]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02-09-2022 00:30:48 ******/
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
/****** Object:  Table [dbo].[Mobiles]    Script Date: 02-09-2022 00:30:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mobiles](
	[Id] [int] NOT NULL,
	[MobileName] [varchar](100) NOT NULL,
	[MobileBrand] [varchar](100) NOT NULL,
	[CostPrice] [int] NOT NULL,
	[MRP] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[SellingDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MobileStore] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MobilePhoneSales] SET  READ_WRITE 
GO
