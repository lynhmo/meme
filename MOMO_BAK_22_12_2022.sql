USE [master]
GO
/****** Object:  Database [momo]    Script Date: 22/12/2022 02:09:11 AM ******/
CREATE DATABASE [momo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'momo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\momo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'momo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\momo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [momo] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [momo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [momo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [momo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [momo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [momo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [momo] SET ARITHABORT OFF 
GO
ALTER DATABASE [momo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [momo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [momo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [momo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [momo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [momo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [momo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [momo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [momo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [momo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [momo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [momo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [momo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [momo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [momo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [momo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [momo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [momo] SET RECOVERY FULL 
GO
ALTER DATABASE [momo] SET  MULTI_USER 
GO
ALTER DATABASE [momo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [momo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [momo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [momo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [momo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [momo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'momo', N'ON'
GO
ALTER DATABASE [momo] SET QUERY_STORE = ON
GO
ALTER DATABASE [momo] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [momo]
GO
/****** Object:  Table [dbo].[bank]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank](
	[id_bank] [int] IDENTITY(1,1) NOT NULL,
	[bankname] [varchar](255) NULL,
	[dautu_phantram] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bank] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bank_user]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_user](
	[id_bank] [int] NOT NULL,
	[id_user] [int] NOT NULL,
	[money_bank] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bank] ASC,
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lichsu]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lichsu](
	[id_lichsu] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[id_user_revice] [int] NOT NULL,
	[total_money] [bigint] NULL,
	[ngaygiaodich] [date] NULL,
	[id_uudai] [int] NULL,
	[thongdiep] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_lichsu] ASC,
	[id_user] ASC,
	[id_user_revice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fullname] [varchar](50) NULL,
	[money] [bigint] NOT NULL,
	[birth] [date] NULL,
	[cccd] [int] NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uudai]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uudai](
	[id_uudai] [int] IDENTITY(1,1) NOT NULL,
	[uudai_name] [varchar](255) NULL,
	[phantram] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_uudai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uudai_users]    Script Date: 22/12/2022 02:09:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uudai_users](
	[id_uudai] [int] NOT NULL,
	[id_user] [int] NOT NULL,
	[uudai_name] [varchar](255) NULL,
	[phantram] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_uudai] ASC,
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[lichsu] ON 

INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (1, 1, 2, 1, CAST(N'2022-12-20' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (2, 1, 2, 1, CAST(N'2022-12-29' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (3, 1, 2, 1, CAST(N'2022-02-12' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (4, 1, 2, 99, CAST(N'2022-02-13' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (8, 2, 1, 99, CAST(N'2022-12-22' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (9, 2, 1, 802, CAST(N'2022-12-22' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (10, 2, 1, 1, CAST(N'2022-12-22' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (11, 1, 2, 1, CAST(N'2022-12-30' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (12, 2, 1, 2, CAST(N'2022-12-22' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (13, 4, 3, 123, CAST(N'2022-12-22' AS Date), NULL, NULL)
INSERT [dbo].[lichsu] ([id_lichsu], [id_user], [id_user_revice], [total_money], [ngaygiaodich], [id_uudai], [thongdiep]) VALUES (14, 3, 4, 2, CAST(N'2022-12-22' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[lichsu] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [password], [fullname], [money], [birth], [cccd], [address]) VALUES (1, N'linh', N'1', N'linh tu do', 2001, NULL, NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [fullname], [money], [birth], [cccd], [address]) VALUES (2, N'long', N'1', N'lonh bui ha', 39998998, NULL, NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [fullname], [money], [birth], [cccd], [address]) VALUES (3, N'vu', N'1', N'bui anh vu', 2121, NULL, NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [fullname], [money], [birth], [cccd], [address]) VALUES (4, N'viet', N'1', N'tran quoc viet', 111110990, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_money]  DEFAULT ((0)) FOR [money]
GO
ALTER TABLE [dbo].[bank_user]  WITH CHECK ADD FOREIGN KEY([id_bank])
REFERENCES [dbo].[bank] ([id_bank])
GO
ALTER TABLE [dbo].[bank_user]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[lichsu]  WITH CHECK ADD FOREIGN KEY([id_user_revice])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[lichsu]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[lichsu]  WITH CHECK ADD FOREIGN KEY([id_uudai])
REFERENCES [dbo].[uudai] ([id_uudai])
GO
ALTER TABLE [dbo].[uudai_users]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[uudai_users]  WITH CHECK ADD FOREIGN KEY([id_uudai])
REFERENCES [dbo].[uudai] ([id_uudai])
GO
USE [master]
GO
ALTER DATABASE [momo] SET  READ_WRITE 
GO
