USE [master]
GO
/****** Object:  Database [employeeInformation]    Script Date: 5/14/2015 5:19:28 PM ******/
CREATE DATABASE [employeeInformation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'employeeInformation', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\employeeInformation.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'employeeInformation_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\employeeInformation_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [employeeInformation] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [employeeInformation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [employeeInformation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [employeeInformation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [employeeInformation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [employeeInformation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [employeeInformation] SET ARITHABORT OFF 
GO
ALTER DATABASE [employeeInformation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [employeeInformation] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [employeeInformation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [employeeInformation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [employeeInformation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [employeeInformation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [employeeInformation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [employeeInformation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [employeeInformation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [employeeInformation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [employeeInformation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [employeeInformation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [employeeInformation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [employeeInformation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [employeeInformation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [employeeInformation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [employeeInformation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [employeeInformation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [employeeInformation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [employeeInformation] SET  MULTI_USER 
GO
ALTER DATABASE [employeeInformation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [employeeInformation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [employeeInformation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [employeeInformation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [employeeInformation]
GO
/****** Object:  Table [dbo].[designation]    Script Date: 5/14/2015 5:19:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[designation](
	[desId] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NULL,
	[title] [varchar](50) NULL,
 CONSTRAINT [PK_designation] PRIMARY KEY CLUSTERED 
(
	[desId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee]    Script Date: 5/14/2015 5:19:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[empId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[desId] [int] NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[empId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_designation]    Script Date: 5/14/2015 5:19:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_designation] ON [dbo].[designation]
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_designation] FOREIGN KEY([desId])
REFERENCES [dbo].[designation] ([desId])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_designation]
GO
USE [master]
GO
ALTER DATABASE [employeeInformation] SET  READ_WRITE 
GO
