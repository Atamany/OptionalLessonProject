USE [OptionalLessonDb]
GO
/****** Object:  Table [dbo].[TblLesson]    Script Date: 1.12.2024 19:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLesson](
	[LessonId] [int] IDENTITY(1,1) NOT NULL,
	[LessonName] [nvarchar](30) NULL,
	[TeacherName] [nvarchar](30) NULL,
	[TeacherSurname] [nvarchar](30) NULL,
 CONSTRAINT [PK_TblLesson] PRIMARY KEY CLUSTERED 
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudent]    Script Date: 1.12.2024 19:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudent](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](30) NULL,
	[StudentSurname] [nvarchar](30) NULL,
	[LessonId] [int] NULL,
 CONSTRAINT [PK_TblStudent] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblLesson] ON 

INSERT [dbo].[TblLesson] ([LessonId], [LessonName], [TeacherName], [TeacherSurname]) VALUES (1, N'Java101', N'Gökay', N'Mutlu')
INSERT [dbo].[TblLesson] ([LessonId], [LessonName], [TeacherName], [TeacherSurname]) VALUES (3, N'C#', N'Murat', N'Yücedağ')
INSERT [dbo].[TblLesson] ([LessonId], [LessonName], [TeacherName], [TeacherSurname]) VALUES (4, N'WEB101', N'Emre', N'Süngü')
INSERT [dbo].[TblLesson] ([LessonId], [LessonName], [TeacherName], [TeacherSurname]) VALUES (5, N'Python201', N'Yusuf', N'Yavuz')
SET IDENTITY_INSERT [dbo].[TblLesson] OFF
GO
SET IDENTITY_INSERT [dbo].[TblStudent] ON 

INSERT [dbo].[TblStudent] ([StudentId], [StudentName], [StudentSurname], [LessonId]) VALUES (8, N'Mahmut', N'Yıldırım', 1)
INSERT [dbo].[TblStudent] ([StudentId], [StudentName], [StudentSurname], [LessonId]) VALUES (10, N'Yusuf', N'Yavuz', 5)
SET IDENTITY_INSERT [dbo].[TblStudent] OFF
GO
ALTER TABLE [dbo].[TblStudent]  WITH CHECK ADD  CONSTRAINT [FK_TblStudent_TblLesson] FOREIGN KEY([LessonId])
REFERENCES [dbo].[TblLesson] ([LessonId])
GO
ALTER TABLE [dbo].[TblStudent] CHECK CONSTRAINT [FK_TblStudent_TblLesson]
GO
