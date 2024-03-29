USE [master]
GO
/****** Object:  Database [Production]    Script Date: 20/10/2019 3:46:52 ******/
CREATE DATABASE [Production]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Production', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Production.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Production_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Production_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Production] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Production].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Production] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Production] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Production] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Production] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Production] SET ARITHABORT OFF 
GO
ALTER DATABASE [Production] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Production] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Production] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Production] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Production] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Production] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Production] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Production] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Production] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Production] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Production] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Production] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Production] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Production] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Production] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Production] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Production] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Production] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Production] SET  MULTI_USER 
GO
ALTER DATABASE [Production] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Production] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Production] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Production] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Production] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Production]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20/10/2019 3:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ProductNumber] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[SafetyStockLevel] [int] NOT NULL,
	[ReorderPoint] [int] NOT NULL,
	[StandardCost] [decimal](18, 5) NOT NULL,
	[ListPrice] [decimal](18, 5) NOT NULL,
	[Size] [char](10) NULL,
	[DaysToManufacture] [int] NOT NULL,
	[SellStartDate] [varchar](50) NOT NULL,
	[rowguid] [varchar](50) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[Category] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [SafetyStockLevel], [ReorderPoint], [StandardCost], [ListPrice], [Size], [DaysToManufacture], [SellStartDate], [rowguid], [ModifiedDate], [Category]) VALUES (1, N'Product01', N'AA-0000', N'black', 10000, 700, CAST(121.00000 AS Decimal(18, 5)), CAST(233.00000 AS Decimal(18, 5)), N'S         ', 10, N'16/10/2019', N'1aaaaa-bbbbbb-cccc', CAST(N'2019-10-19 00:00:00.000' AS DateTime), N'Productos')
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [SafetyStockLevel], [ReorderPoint], [StandardCost], [ListPrice], [Size], [DaysToManufacture], [SellStartDate], [rowguid], [ModifiedDate], [Category]) VALUES (2, N'Product02', N'AA-0000', N'black', 10000, 700, CAST(121.00000 AS Decimal(18, 5)), CAST(233.00000 AS Decimal(18, 5)), N'S         ', 10, N'16/10/2019', N'1aaaaa-bbbbbb-cccc', CAST(N'2019-10-19 00:00:00.000' AS DateTime), N'Productos')
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [SafetyStockLevel], [ReorderPoint], [StandardCost], [ListPrice], [Size], [DaysToManufacture], [SellStartDate], [rowguid], [ModifiedDate], [Category]) VALUES (3, N'Electrodomestico01', N'AA-0000', N'black', 10000, 700, CAST(121.00000 AS Decimal(18, 5)), CAST(233.00000 AS Decimal(18, 5)), N'S         ', 10, N'16/10/2019', N'1aaaaa-bbbbbb-cccc', CAST(N'2019-10-20 00:00:00.000' AS DateTime), N'Muebles')
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [SafetyStockLevel], [ReorderPoint], [StandardCost], [ListPrice], [Size], [DaysToManufacture], [SellStartDate], [rowguid], [ModifiedDate], [Category]) VALUES (5, N'Comedor01', N'AA-0000', N'black', 10000, 700, CAST(121.00000 AS Decimal(18, 5)), CAST(233.00000 AS Decimal(18, 5)), N'S         ', 10, N'16/10/2019', N'1aaaaa-bbbbbb-cccc', CAST(N'2019-10-20 00:00:00.000' AS DateTime), N'Muebles')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [Production] SET  READ_WRITE 
GO
