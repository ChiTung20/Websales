USE [master]
GO
/****** Object:  Database [webbanhang]    Script Date: 14/01/2023 13:34:45 ******/
CREATE DATABASE [webbanhang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'webbanhang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\webbanhang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'webbanhang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\webbanhang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [webbanhang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [webbanhang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [webbanhang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [webbanhang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [webbanhang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [webbanhang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [webbanhang] SET ARITHABORT OFF 
GO
ALTER DATABASE [webbanhang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [webbanhang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [webbanhang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [webbanhang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [webbanhang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [webbanhang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [webbanhang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [webbanhang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [webbanhang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [webbanhang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [webbanhang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [webbanhang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [webbanhang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [webbanhang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [webbanhang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [webbanhang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [webbanhang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [webbanhang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [webbanhang] SET  MULTI_USER 
GO
ALTER DATABASE [webbanhang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [webbanhang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [webbanhang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [webbanhang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [webbanhang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [webbanhang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [webbanhang] SET QUERY_STORE = OFF
GO
USE [webbanhang]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [nchar](10) NULL,
	[Email] [nvarchar](250) NULL,
	[Password] [nvarchar](50) NULL,
	[Salt] [nchar](10) NULL,
	[Active] [bit] NOT NULL,
	[Fullname] [nvarchar](250) NULL,
	[RoleID] [int] NULL,
	[LastLogin] [datetime] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NULL,
	[Birthday] [datetime] NULL,
	[Avatar] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [nchar](10) NULL,
	[LocationID] [int] NULL,
	[Distrist] [int] NULL,
	[Ward] [int] NULL,
	[CreateDate] [datetime] NULL,
	[Password] [nvarchar](50) NULL,
	[Salt] [nchar](8) NULL,
	[LastLogin] [datetime] NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](20) NULL,
	[Slug] [nvarchar](250) NULL,
	[NameWithType] [nvarchar](250) NULL,
	[PathWithType] [nvarchar](250) NULL,
	[ParentCode] [int] NULL,
	[Levels] [int] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[OrderNumber] [int] NULL,
	[Quaitity] [int] NULL,
	[Discount] [int] NULL,
	[Total] [int] NULL,
	[ShipDate] [datetime] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CusromerID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShipDate] [datetime] NULL,
	[TransactionStatusID] [int] NULL,
	[Dateled] [bit] NULL,
	[Paid] [bit] NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentID] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pages]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pages](
	[PageID] [int] IDENTITY(1,1) NOT NULL,
	[PageName] [nvarchar](250) NULL,
	[Contents] [nvarchar](250) NULL,
	[Published] [bit] NOT NULL,
	[Thumb] [nvarchar](250) NULL,
	[Title] [nvarchar](250) NULL,
	[MateDesc] [nvarchar](250) NULL,
	[MetaKey] [nvarchar](250) NULL,
	[Alias] [nvarchar](250) NULL,
	[CreatedAt] [datetime] NULL,
	[Ordering] [int] NULL,
 CONSTRAINT [PK_Pages] PRIMARY KEY CLUSTERED 
(
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategorys]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategorys](
	[CateID] [int] IDENTITY(1,1) NOT NULL,
	[CateName] [nchar](10) NULL,
	[Description] [nvarchar](max) NULL,
	[ParentID] [int] NULL,
	[Levels] [int] NULL,
	[Ordering] [int] NULL,
	[Published] [bit] NOT NULL,
	[Thumb] [nvarchar](250) NULL,
	[Title] [nvarchar](250) NULL,
	[Asas] [nvarchar](250) NULL,
	[MetaDesc] [nvarchar](250) NULL,
	[MetaKey] [nvarchar](250) NULL,
	[Cover] [nvarchar](250) NULL,
	[SchemaMarkup] [nvarchar](250) NULL,
 CONSTRAINT [PK_ProductCategorys] PRIMARY KEY CLUSTERED 
(
	[CateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductCategorys] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[Products]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NOT NULL,
	[ShortDesc] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[CateID] [int] NULL,
	[Price] [int] NULL,
	[Discount] [int] NULL,
	[Thumb] [nvarchar](250) NULL,
	[Video] [nvarchar](250) NULL,
	[DateCreate] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[BestSalers] [nchar](10) NULL,
	[HomeFlag] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
	[Tags] [bit] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Alias] [nvarchar](250) NULL,
	[MetaDesc] [nvarchar](250) NULL,
	[MetaKey] [nvarchar](250) NULL,
	[UnitslnStock] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipers]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipers](
	[ShiperID] [int] IDENTITY(1,1) NOT NULL,
	[ShiperName] [nvarchar](250) NULL,
	[Phone] [nchar](10) NULL,
	[Company] [nvarchar](250) NULL,
 CONSTRAINT [PK_Shipers] PRIMARY KEY CLUSTERED 
(
	[ShiperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionStatus]    Script Date: 14/01/2023 13:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionStatus](
	[TransactionStatusID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_TransactionStatus] PRIMARY KEY CLUSTERED 
(
	[TransactionStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Roles]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CusromerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_TransactionStatus] FOREIGN KEY([TransactionStatusID])
REFERENCES [dbo].[TransactionStatus] ([TransactionStatusID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_TransactionStatus]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategorys] FOREIGN KEY([CateID])
REFERENCES [dbo].[ProductCategorys] ([CateID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategorys]
GO
USE [master]
GO
ALTER DATABASE [webbanhang] SET  READ_WRITE 
GO
