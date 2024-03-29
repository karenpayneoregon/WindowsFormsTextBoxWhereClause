USE [ForumExamples]
GO
/****** Object:  Table [dbo].[WhereInSimple]    Script Date: 9/12/2019 5:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhereInSimple](
	[supplier_id] [int] IDENTITY(100,100) NOT NULL,
	[supplier_name] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[some_date] [datetime2](7) NULL,
 CONSTRAINT [PK_WhereInSimple] PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[WhereInSimple] ON 

GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (100, N'Microsoft', N'Redmond', N'Washington', CAST(N'2017-06-01 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (200, N'Google', N'Mountain View', N'California', CAST(N'2017-06-02 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (300, N'Oracle', N'Redwood City', N'California', CAST(N'2017-06-03 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (400, N'Kimberly-Clark', N'Irving', N'Texas', CAST(N'2017-06-04 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (500, N'Tyson Foods', N'Springdale', N'Arkansas', CAST(N'2017-06-05 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (600, N'SC Johnson', N'Racine', N'Wisconsin', CAST(N'2017-06-01 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (700, N'Dole Food Company', N'Westlake Village', N'California', CAST(N'2017-06-01 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (800, N'Flowers Foods', N'Thomasville', N'Georgia', CAST(N'2017-06-05 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (900, N'Electronic Arts', N'Redwood City', N'California', CAST(N'2017-06-05 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (1000, N'Dutch Bros Coffee', N'Grants Pass', N'Oregon', CAST(N'2017-07-01 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (1100, N'Nike, Inc.', N'Beaverton', N'Oregon', CAST(N'2017-06-03 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (1200, N'InFocus', N'Tigard', N'Oregon', CAST(N'2017-06-02 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (1300, N'Dell', N'Austin', N'Texas', CAST(N'2017-08-20 06:27:56.8903722' AS DateTime2))
GO
INSERT [dbo].[WhereInSimple] ([supplier_id], [supplier_name], [city], [state], [some_date]) VALUES (1400, NULL, NULL, NULL, CAST(N'2017-06-21 06:27:56.8903722' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[WhereInSimple] OFF
GO
