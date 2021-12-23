if not exists(select * from sys.databases where name = 'PortfolioData')
    create database [PortfolioData]
GO

USE [PortfolioData] 


IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'TS_DailyData')
    DROP TABLE [dbo].[TS_DailyData]
GO

	
	
/****** Object:  Table [dbo].[TS_DailyData]  ******/
SET ANSI_NULLS ON
GO


CREATE TABLE [dbo].[TS_DailyData]
(
	[Values_ID] [int]           NOT NULL IDENTITY(1,1),
	[Ticker_ID] [int]           NOT NULL,
	[Date]      [smalldatetime] NOT NULL,
	[Open]      [float]         NOT NULL,
	[Close]     [float]         NOT NULL,
    CONSTRAINT [PK_TS_DailyData_Values] PRIMARY KEY CLUSTERED ([Values_ID] ASC),
	CONSTRAINT [UK_TS_Values] UNIQUE ([Ticker_ID], [Date])
)  

GO

CREATE VIEW V_DailyData AS
SELECT [Values_ID], [Ticker_ID], [Date], [Open], [Close]  
FROM TS_DailyData

GO

CREATE TABLE [dbo].[TS_Transactions]
(
	[Values_ID] [int]           NOT NULL IDENTITY(1,1),
	[Ticker_ID] [int]           NOT NULL,
	[Date]      [smalldatetime] NOT NULL,
	[Price]     [float]         NOT NULL,
	[Quantity]  [float]         NOT NULL,
	CONSTRAINT [PK_TS_Transactions_Values] PRIMARY KEY CLUSTERED ([Values_ID] ASC)
)

GO

CREATE VIEW V_Transactions AS
SELECT [Values_ID], [Ticker_ID], [Date], [Price], [Quantity]  
FROM TS_Transactions

GO

CREATE TABLE [dbo].[TS_Ticker]
(
	[Values_ID]   [int]           NOT NULL IDENTITY(1,1),
	[Ticker_Name] [varchar](10)   NOT NULL,
	CONSTRAINT [PK_TS_Ticker_Values] PRIMARY KEY CLUSTERED ([Values_ID] ASC)
)

GO

CREATE VIEW V_DailyData AS
SELECT [Values_ID], [Ticker_Name]
FROM TS_Ticker

GO


