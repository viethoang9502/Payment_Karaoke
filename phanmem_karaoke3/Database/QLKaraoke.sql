USE [master]
GO
/****** Object:  Database [QLKaraoke]    Script Date: 12/19/2018 9:49:34 PM ******/
CREATE DATABASE [QLKaraoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKaraoke', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLKaraoke.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKaraoke_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLKaraoke_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLKaraoke] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKaraoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKaraoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKaraoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKaraoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKaraoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKaraoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKaraoke] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKaraoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKaraoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKaraoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKaraoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKaraoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKaraoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKaraoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKaraoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKaraoke] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKaraoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKaraoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKaraoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKaraoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKaraoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKaraoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKaraoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKaraoke] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKaraoke] SET  MULTI_USER 
GO
ALTER DATABASE [QLKaraoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKaraoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKaraoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKaraoke] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKaraoke] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKaraoke] SET QUERY_STORE = OFF
GO
USE [QLKaraoke]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beer](
	[MaBeer] [varchar](5) NOT NULL,
	[TenBeer] [nvarchar](10) NULL,
	[GiaTien] [float] NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_Beer] PRIMARY KEY CLUSTERED 
(
	[MaBeer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dn] [varchar](20) NULL,
	[pass] [varchar](20) NULL,
 CONSTRAINT [PK_dangnhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoAn](
	[MaDA] [varchar](5) NOT NULL,
	[TenDA] [nvarchar](10) NULL,
	[GiaTien] [float] NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_DoAn] PRIMARY KEY CLUSTERED 
(
	[MaDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](5) NOT NULL,
	[MaPH] [varchar](30) NULL,
	[MaKH] [varchar](5) NULL,
	[MaDA] [varchar](5) NULL,
	[MaBeer] [varchar](5) NULL,
	[MaNuoc] [varchar](5) NULL,
	[MaTrai] [varchar](5) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonND]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonND](
	[MaHDND] [varchar](5) NOT NULL,
	[TenPH] [nvarchar](30) NULL,
	[LoaiDV] [nvarchar](30) NULL,
 CONSTRAINT [PK_HoaDonND] PRIMARY KEY CLUSTERED 
(
	[MaHDND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NuocNgot]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NuocNgot](
	[MaNuoc] [varchar](5) NOT NULL,
	[TenNuoc] [nvarchar](10) NULL,
	[GiaTien] [float] NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_NuocNgot] PRIMARY KEY CLUSTERED 
(
	[MaNuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tam]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tam](
	[tenmon] [nvarchar](50) NULL,
	[sl] [int] NULL,
	[giatien] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraiCay]    Script Date: 12/19/2018 9:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraiCay](
	[MaTrai] [varchar](5) NOT NULL,
	[TenTrai] [nvarchar](10) NULL,
	[GiaTien] [float] NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_TraiCay] PRIMARY KEY CLUSTERED 
(
	[MaTrai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Beer] ([MaBeer], [TenBeer], [GiaTien], [SL]) VALUES (N'1', N'Tiger', 20000, 20)
INSERT [dbo].[Beer] ([MaBeer], [TenBeer], [GiaTien], [SL]) VALUES (N'2', N'Saigon', 20000, 20)
INSERT [dbo].[Beer] ([MaBeer], [TenBeer], [GiaTien], [SL]) VALUES (N'3', N'Heiniken', 20000, 20)
SET IDENTITY_INSERT [dbo].[dangnhap] ON 

INSERT [dbo].[dangnhap] ([id], [dn], [pass]) VALUES (1, N'admin', N'123')
INSERT [dbo].[dangnhap] ([id], [dn], [pass]) VALUES (2, N'thuy', N'123')
SET IDENTITY_INSERT [dbo].[dangnhap] OFF
INSERT [dbo].[DoAn] ([MaDA], [TenDA], [GiaTien], [SL]) VALUES (N'1', N'BapXao', 20000, 20)
INSERT [dbo].[DoAn] ([MaDA], [TenDA], [GiaTien], [SL]) VALUES (N'2', N'ChaGio', 35000, 20)
INSERT [dbo].[DoAn] ([MaDA], [TenDA], [GiaTien], [SL]) VALUES (N'3', N'GoiTom', 30000, 20)
INSERT [dbo].[DoAn] ([MaDA], [TenDA], [GiaTien], [SL]) VALUES (N'4', N'My y', 50000, 20)
INSERT [dbo].[DoAn] ([MaDA], [TenDA], [GiaTien], [SL]) VALUES (N'5', N'VitLon', 30000, 20)
INSERT [dbo].[NuocNgot] ([MaNuoc], [TenNuoc], [GiaTien], [SL]) VALUES (N'1', N'Sting', 15000, 30)
INSERT [dbo].[NuocNgot] ([MaNuoc], [TenNuoc], [GiaTien], [SL]) VALUES (N'2', N'mirinda', 10000, 50)
INSERT [dbo].[NuocNgot] ([MaNuoc], [TenNuoc], [GiaTien], [SL]) VALUES (N'3', N'cocacola', 15000, 40)
INSERT [dbo].[NuocNgot] ([MaNuoc], [TenNuoc], [GiaTien], [SL]) VALUES (N'4', N'nuoc suoi', 12000, 50)
INSERT [dbo].[NuocNgot] ([MaNuoc], [TenNuoc], [GiaTien], [SL]) VALUES (N'5', N'dasani', 10000, 50)
INSERT [dbo].[TraiCay] ([MaTrai], [TenTrai], [GiaTien], [SL]) VALUES (N'1', N'traicay1', 80000, 20)
INSERT [dbo].[TraiCay] ([MaTrai], [TenTrai], [GiaTien], [SL]) VALUES (N'2', N'traicay2', 150000, 20)
INSERT [dbo].[TraiCay] ([MaTrai], [TenTrai], [GiaTien], [SL]) VALUES (N'3', N'traicay3', 120000, 20)
USE [master]
GO
ALTER DATABASE [QLKaraoke] SET  READ_WRITE 
GO
