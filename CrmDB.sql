/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [CrmDB]
GO
/****** Object:  Table [dbo].[AddressDetails]    Script Date: 12.11.2017 18:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [ntext] NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[CustomerID] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_AddressDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 12.11.2017 18:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[CustomerID] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12.11.2017 18:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[PhotoPath] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AddressDetails] ON 

INSERT [dbo].[AddressDetails] ([Id], [Address], [City], [Country], [CustomerID], [CreateDate]) VALUES (7, N'kl5', N'möç', N'lö', 5, CAST(N'2017-11-12T12:21:33.067' AS DateTime))
INSERT [dbo].[AddressDetails] ([Id], [Address], [City], [Country], [CustomerID], [CreateDate]) VALUES (8, N'ldföçc', N'ödç', N'öçs', 4, CAST(N'2017-11-12T17:54:53.627' AS DateTime))
SET IDENTITY_INSERT [dbo].[AddressDetails] OFF
SET IDENTITY_INSERT [dbo].[ContactDetails] ON 

INSERT [dbo].[ContactDetails] ([Id], [Mail], [Phone], [CustomerID], [CreateDate]) VALUES (5, N'k6536', N'( 54) 535-  -', 5, CAST(N'2017-11-12T12:34:03.873' AS DateTime))
INSERT [dbo].[ContactDetails] ([Id], [Mail], [Phone], [CustomerID], [CreateDate]) VALUES (6, N'kmdföc', N'(545)    -  -', 4, CAST(N'2017-11-12T17:49:57.490' AS DateTime))
SET IDENTITY_INSERT [dbo].[ContactDetails] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Gender], [PhotoPath], [CreateDate]) VALUES (4, N'yeni3', N'lösçx5', 1, NULL, CAST(N'2017-11-12T10:56:33.513' AS DateTime))
INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Gender], [PhotoPath], [CreateDate]) VALUES (5, N'mö5', N'ldöçx', 0, NULL, CAST(N'2017-11-12T11:07:05.403' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customers] OFF
ALTER TABLE [dbo].[AddressDetails] ADD  CONSTRAINT [DF_AddressDetails_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ContactDetails] ADD  CONSTRAINT [DF_ContactDetails_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[AddressDetails]  WITH CHECK ADD  CONSTRAINT [FK_AddressDetails_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[AddressDetails] CHECK CONSTRAINT [FK_AddressDetails_Customers]
GO
ALTER TABLE [dbo].[ContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_ContactDetails_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[ContactDetails] CHECK CONSTRAINT [FK_ContactDetails_Customers]
GO
