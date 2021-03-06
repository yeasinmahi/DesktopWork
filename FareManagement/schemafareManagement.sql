USE [master]
GO
/****** Object:  Database [fareManagment]    Script Date: 28-May-15 2:22:44 AM ******/
CREATE DATABASE [fareManagment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'fareManagment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\fareManagment.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'fareManagment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\fareManagment_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [fareManagment] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [fareManagment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [fareManagment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [fareManagment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [fareManagment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [fareManagment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [fareManagment] SET ARITHABORT OFF 
GO
ALTER DATABASE [fareManagment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [fareManagment] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [fareManagment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [fareManagment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [fareManagment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [fareManagment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [fareManagment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [fareManagment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [fareManagment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [fareManagment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [fareManagment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [fareManagment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [fareManagment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [fareManagment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [fareManagment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [fareManagment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [fareManagment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [fareManagment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [fareManagment] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [fareManagment] SET  MULTI_USER 
GO
ALTER DATABASE [fareManagment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [fareManagment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [fareManagment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [fareManagment] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [fareManagment]
GO
/****** Object:  StoredProcedure [dbo].[visitorListByZoneId]    Script Date: 28-May-15 2:22:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[visitorListByZoneId] (@zid as int) as
select v.name, v.email, v.contact, z.zoneName 
from visitor as v left join visitorAndZone as vz on v.vid= vz.vid 
left join zone as z on vz.zid=z.zid where vz.zid=@zid
GO
/****** Object:  Table [dbo].[visitor]    Script Date: 28-May-15 2:22:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visitor](
	[vid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[contact] [varchar](50) NOT NULL,
 CONSTRAINT [PK_visitor] PRIMARY KEY CLUSTERED 
(
	[vid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[visitorAndZone]    Script Date: 28-May-15 2:22:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitorAndZone](
	[zid] [int] NOT NULL,
	[vid] [int] NOT NULL,
 CONSTRAINT [PK_visitorAndZone] PRIMARY KEY CLUSTERED 
(
	[zid] ASC,
	[vid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[zone]    Script Date: 28-May-15 2:22:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[zone](
	[zid] [int] IDENTITY(1,1) NOT NULL,
	[zoneName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_zone] PRIMARY KEY CLUSTERED 
(
	[zid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ZoneWiseVisitor]    Script Date: 28-May-15 2:22:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ZoneWiseVisitor] 
as
select z.zoneName as 'Zone Name', COUNT(vz.vid) as 'Total Visitor' from visitorAndZone as vz join zone as z on z.zid= vz.zid group by z.zoneName

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_visitor]    Script Date: 28-May-15 2:22:44 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_visitor] ON [dbo].[visitor]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_zone]    Script Date: 28-May-15 2:22:44 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_zone] ON [dbo].[zone]
(
	[zoneName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[visitorAndZone]  WITH CHECK ADD  CONSTRAINT [FK_visitorAndZone_visitor] FOREIGN KEY([vid])
REFERENCES [dbo].[visitor] ([vid])
GO
ALTER TABLE [dbo].[visitorAndZone] CHECK CONSTRAINT [FK_visitorAndZone_visitor]
GO
ALTER TABLE [dbo].[visitorAndZone]  WITH CHECK ADD  CONSTRAINT [FK_visitorAndZone_zone] FOREIGN KEY([zid])
REFERENCES [dbo].[zone] ([zid])
GO
ALTER TABLE [dbo].[visitorAndZone] CHECK CONSTRAINT [FK_visitorAndZone_zone]
GO
USE [master]
GO
ALTER DATABASE [fareManagment] SET  READ_WRITE 
GO
