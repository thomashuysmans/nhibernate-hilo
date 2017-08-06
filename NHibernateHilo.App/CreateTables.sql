USE [NHibernateHilo]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 06/08/2017 15:26:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Person](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[PersonHilo](
	[NextHi] [int] NOT NULL
) ON [PRIMARY]

GO

INSERT INTO [dbo].[PersonHilo] ([NextHi]) VALUES(1)

GO

SET ANSI_PADDING OFF
GO


