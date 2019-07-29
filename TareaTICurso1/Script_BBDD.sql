USE [dbPruebaCurso]
GO

/****** Object:  Table [dbo].[DCBanco]    Script Date: 24/06/2019 10:24:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DCBanco](
	[IdBanco] [int] NOT NULL,
	[TasaInteres] [numeric](18, 2) NULL,
	[Cantidad] [numeric](18, 2) NULL,
	[UsuarioInserto] [nvarchar](50) NULL,
	[FechaInserto] [datetime] NULL,
	[UsuarioModifico] [nvarchar](50) NULL,
	[FechaModifico] [datetime] NULL,
 CONSTRAINT [PK_DCBanco] PRIMARY KEY CLUSTERED 
(
	[IdBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [dbPruebaCurso]
GO

/****** Object:  Table [dbo].[DCCarro]    Script Date: 24/06/2019 10:24:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DCCarro](
	[FinanciadoPor] [int] NOT NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Año] [int] NULL,
	[UsuarioInserto] [nvarchar](50) NULL,
	[FechaInserto] [datetime] NULL,
	[UsuarioModifico] [nvarchar](50) NULL,
	[FechaModifico] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DCCarro]  WITH CHECK ADD  CONSTRAINT [FK_DCCarro_DCBanco] FOREIGN KEY([FinanciadoPor])
REFERENCES [dbo].[DCBanco] ([IdBanco])
GO

ALTER TABLE [dbo].[DCCarro] CHECK CONSTRAINT [FK_DCCarro_DCBanco]
GO


