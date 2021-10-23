Create database GestionDemandaTI
go
USE [GestionDemandaTI]
GO
/****** Object:  Table [dbo].[Candidatos]    Script Date: 22/10/2021 02:42:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidatos](
	[Candidatos_Id] [int] IDENTITY(1,1) NOT NULL,
	[Candidatos_Cedula] [varchar](60) NOT NULL,
	[Candidatos_Nombre] [varchar](50) NOT NULL,
	[Candidatos_Apellido] [varchar](50) NOT NULL,
	[Candidatos_FechaNacimiento] [date] NOT NULL,
	[Candidatos_TrabajoActual] [varchar](30) NULL,
	[Candidatos_ExpectativaSalarial] [decimal](10, 2) NULL,
	[Candidatos_Observaciones] [text] NULL,
 CONSTRAINT [PK__Candidat__0A477E9D490006C0] PRIMARY KEY CLUSTERED 
(
	[Candidatos_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidatos] ON 
GO
INSERT [dbo].[Candidatos] ([Candidatos_Id], [Candidatos_Cedula], [Candidatos_Nombre], [Candidatos_Apellido], [Candidatos_FechaNacimiento], [Candidatos_TrabajoActual], [Candidatos_ExpectativaSalarial], [Candidatos_Observaciones]) VALUES (24, N'52354', N'edw', N'das', CAST(N'2021-09-30' AS Date), N'as', CAST(123.00 AS Decimal(10, 2)), N'sad')
GO
SET IDENTITY_INSERT [dbo].[Candidatos] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Candidat__EA39375327B657DD]    Script Date: 22/10/2021 02:42:02 p. m. ******/
ALTER TABLE [dbo].[Candidatos] ADD  CONSTRAINT [UQ__Candidat__EA39375327B657DD] UNIQUE NONCLUSTERED 
(
	[Candidatos_Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,  IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO