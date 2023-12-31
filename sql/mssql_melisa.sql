USE [master]
GO
/****** Object:  Database [melisa]    Script Date: 12/7/2023 1:20:25 AM ******/
CREATE DATABASE [melisa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'melisa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\melisa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'melisa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\melisa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [melisa] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [melisa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [melisa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [melisa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [melisa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [melisa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [melisa] SET ARITHABORT OFF 
GO
ALTER DATABASE [melisa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [melisa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [melisa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [melisa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [melisa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [melisa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [melisa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [melisa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [melisa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [melisa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [melisa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [melisa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [melisa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [melisa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [melisa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [melisa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [melisa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [melisa] SET RECOVERY FULL 
GO
ALTER DATABASE [melisa] SET  MULTI_USER 
GO
ALTER DATABASE [melisa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [melisa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [melisa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [melisa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [melisa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [melisa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'melisa', N'ON'
GO
ALTER DATABASE [melisa] SET QUERY_STORE = ON
GO
ALTER DATABASE [melisa] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [melisa]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/7/2023 1:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[occupation] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[country] [varchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [melisa] SET  READ_WRITE 
GO
