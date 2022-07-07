USE [Hotel_Kus]
GO

/****** Object:  Table [dbo].[Pokoje]    Script Date: 07.07.2022 21:16:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pokoje](
	[IDPokoju] [int] IDENTITY(1,1) NOT NULL Primary key,
	[NumerPokoju] [nchar](10) NOT NULL,
	[Pojemnosc] [int] NOT NULL,
	[Status] [int] NOT NULL,
 --CONSTRAINT [PK_Pokoje] PRIMARY KEY CLUSTERED,
 Constraint [FK_PokojeStatus] foreign key (Status) references StatusPokoju(ID) 
 )
 GO
INSERT INTO [dbo].[Pokoje]
           ([NumerPokoju]
           ,[Pojemnosc]
           ,[Status])
     VALUES
           (101, 5, 1),
           (102, 2, 1),
		   (103, 4, 1),
		   (104, 4, 2)
GO




