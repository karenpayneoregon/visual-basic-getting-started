USE [EntityFrameworkDatabase]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 3/18/2020 5:09:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[Url] [nvarchar](max) NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Post]    Script Date: 3/18/2020 5:09:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[BlogId] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Contents] [nvarchar](max) NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Blog] ON 

INSERT [dbo].[Blog] ([BlogId], [Url]) VALUES (1, N'http://blogs.msdn.com/adonet')
INSERT [dbo].[Blog] ([BlogId], [Url]) VALUES (2, N'https://devblogs.microsoft.com/dotnet/tag/entity-framework/')
INSERT [dbo].[Blog] ([BlogId], [Url]) VALUES (3, N'https://devblogs.microsoft.com/vbteam/')
SET IDENTITY_INSERT [dbo].[Blog] OFF
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (1, 1, N'Hello world', N'First post')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (2, 1, N'Welcome', N'Second post')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (3, 2, N'Announcing Entity Framework Core 5.0 Preview 1', N'Today we are excited to announce the first preview release of EF Core 5.0.')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (4, 2, N'Announcing Entity Framework Core 3.1 and Entity Framework 6.4', N'We are excited to announce the general availability of EF Core 3.1 and EF 6.4 on nuget.org.')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (5, 2, N'Announcing Entity Framework Core 3.0 and Entity Framework 6.3 General Availability', N'We are extremely excited to announce the general availability of EF Core 3.0and EF 6.3 on nuget.org.')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (6, 2, N'Announcing Entity Framework Core 3.0 Preview 4', N'Today, we are making the fourth preview of Entity Framework Core 3.0 available on NuGet')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (7, 3, N'Visual Basic support planned for .NET 5.0', N'We’ve heard your feedback that you want Visual Basic on .NET Core. Visual Basic in .NET 5 will support additional application types.')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (8, 3, N'Visual Basic in .NET Core 3.0', N'This strategy described in this 2018 post has been replaced with the one in this post.')
INSERT [dbo].[Post] ([PostId], [BlogId], [Title], [Contents]) VALUES (9, 3, N'New for Visual Basic: .NET Standard Class Libraries and the dotnet CLI!', N'Visual Studio 2017 15.3 Preview 1 included templates for VB class libraries targeting .NET Standard class libraries and for .NET Core console apps. With the release of .NET Core 2.0 today those templates go-live.')
SET IDENTITY_INSERT [dbo].[Post] OFF
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK_Post_Blog] FOREIGN KEY([BlogId])
REFERENCES [dbo].[Blog] ([BlogId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK_Post_Blog]
GO
