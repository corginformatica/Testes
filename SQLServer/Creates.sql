/****** tbCliente ******/
DROP TABLE [dbo].[tbCliente]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbCliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[UF] [varchar](2) NOT NULL,
	[Celular] [varchar](15) NOT NULL
) ON [PRIMARY]
GO

/****** tbFinanciamento ******/
DROP TABLE [dbo].[tbFinanciamento]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFinanciamento](
	[IdFinanciamento] [int] IDENTITY(1,1) NOT NULL,
	[TipoFinanciamento] [varchar](50) NOT NULL,
	[Taxa] [float] NOT NULL,
	[Periodo] [varchar](3) NOT NULL,
	[TipoPessoa] [varchar](2) NOT NULL
) ON [PRIMARY]
GO

/****** tbClienteFinanciamento ******/

ALTER TABLE [dbo].[tbFinanciamentoParcela] DROP CONSTRAINT [FK_tbFinanciamentoParcela_tbClienteFinanciamento]
GO

DROP TABLE [dbo].[tbClienteFinanciamento]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbClienteFinanciamento](
	[IdClienteFinanciamento] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdFinanciamento] [int] NOT NULL,
	[ParcelasTotal] [int] NOT NULL,
	[ValorTotal] [float] NOT NULL,
	[DataVencimento] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tbClienteFinanciamento] PRIMARY KEY CLUSTERED 
(
	[IdClienteFinanciamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** tbFinanciamentoParcela] ******/

DROP TABLE [dbo].[tbFinanciamentoParcela]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFinanciamentoParcela](
	[IdClienteFinanciamento] [int] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[ValorParcela] [float] NOT NULL,
	[DtVencimentoParcela] [smalldatetime] NOT NULL,
	[DtPagamentoParcela] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClienteFinanciamento] ASC,
	[NumeroParcela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbFinanciamentoParcela]  WITH CHECK ADD  CONSTRAINT [FK_tbFinanciamentoParcela_tbClienteFinanciamento] FOREIGN KEY([IdClienteFinanciamento])
REFERENCES [dbo].[tbClienteFinanciamento] ([IdClienteFinanciamento])
GO

ALTER TABLE [dbo].[tbFinanciamentoParcela] CHECK CONSTRAINT [FK_tbFinanciamentoParcela_tbClienteFinanciamento]
GO
