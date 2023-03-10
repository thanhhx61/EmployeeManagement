USE [EmployeeDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Avatar] [nvarchar](300) NULL,
	[EmaillUser] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Photo] [nvarchar](300) NOT NULL,
	[EmployeeName] [nvarchar](500) NOT NULL,
	[Dob] [datetime2](7) NOT NULL,
	[Street] [nvarchar](500) NOT NULL,
	[Workingday] [datetime2](7) NOT NULL,
	[Skill] [nvarchar](500) NOT NULL,
	[Introduce] [nvarchar](500) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[OfficeId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offices]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offices](
	[OfficeId] [int] IDENTITY(1,1) NOT NULL,
	[OfficeName] [nvarchar](300) NOT NULL,
	[Street] [nvarchar](300) NOT NULL,
	[Amount] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Offices] PRIMARY KEY CLUSTERED 
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211102012624_CreatDb', N'5.0.11')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'32ffd287-205f-43a2-9f0d-80bc5309fb47', N'Customer', N'Customer', N'2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c0c6661b-0964-4e62-8083-3cac6a6741ec', N'SystemAdmin', N'SystemAdmin', N'1')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f785f8b2-06e6-4868-9abf-a8961e83eb9f', N'32ffd287-205f-43a2-9f0d-80bc5309fb47')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb50c746-246f-44f7-a212-bf94c5830b33', N'32ffd287-205f-43a2-9f0d-80bc5309fb47')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c0fca4e-9376-4a70-bcc6-35bebe497866', N'c0c6661b-0964-4e62-8083-3cac6a6741ec')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Avatar], [EmaillUser], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2c0fca4e-9376-4a70-bcc6-35bebe497866', N'/Images/hello.jpg', N'xuanthanh6198@gmail.com', N'Xuân Thanh', N'xuanthanh6198@gmail.com', NULL, N'xuanthanh6198@gmail.com', 0, N'AQAAAAEAACcQAAAAEF18bu5Af7+vuB9MkuvDaBeWShB/hN3TsvrbmP6Mnvf0iAV2W92Jvs7VycM6t4IN4A==', N'71a3acda-6806-4e39-b674-385a58d1ac92', N'0206efc9-58eb-45ae-a691-11eec9afbd03', N'0814262547', 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Avatar], [EmaillUser], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f785f8b2-06e6-4868-9abf-a8961e83eb9f', N'/Images/avatars/no_avatar.png', NULL, N'hothanh6198@gmail.com', N'HOTHANH6198@GMAIL.COM', N'hothanh6198@gmail.com', N'HOTHANH6198@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEB/6bRCy37ty+JxtjXw40498S2JhK7vDbqGTtMuYM0nu/guEQEPGPIHQpeR+9UGuiw==', N'K2LE5JEVHTF7U3CO53YSDEIBDGMOTPHN', N'9b5482af-3c19-4a1a-a906-d27fc1c99532', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Avatar], [EmaillUser], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb50c746-246f-44f7-a212-bf94c5830b33', N'/Images/avatars/no_avatar.png', NULL, N'thanh123@gmail.com', N'THANH123@GMAIL.COM', N'thanh123@gmail.com', N'THANH123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJISxlLB+enNW4SGlPANZOt9fFHPVIUuwNQzNMpLJD7Z2E8nKuMlq+wW9yRFTf4E5w==', N'XANXTZNAR4CZYNVQWN5JEP3LXSBPZDW3', N'fbbdfdba-ad31-40d4-84fa-8e684e7622ff', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (82, N'/Images/04112021090008_01112021045250_01112021084239_avatar4.jfif', N'Trần Lê Quốc Toàn', CAST(N'1997-06-10T00:00:00.0000000' AS DateTime2), N'24 đường số 2, khu Hưng Gia 5, Phường Tân Phong, Quận 7, Thành phố Hồ Chí Minh ', CAST(N'2021-02-09T00:00:00.0000000' AS DateTime2), N'.Net Angular Html5', N'thể thao , nghe nhạc ', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (83, N'/Images/04112021090121_avatar1.jfif', N'Bùi	Hoàng Việt Anh', CAST(N'1990-02-01T00:00:00.0000000' AS DateTime2), N' Ấp 5, Xã Xuân Thới Thượng, Huyện Hóc Môn, Thành phố Hồ Chí Minh   ', CAST(N'2021-11-26T00:00:00.0000000' AS DateTime2), N'Java React Ajax Html5', N'nghe nhạc đọc sách', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (84, N'/Images/04112021090304_02112021043950_avatar5.jfif', N'Trương Văn Thái Quý', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2), N' 56 Nguyễn Đình Chiểu, Phường Đa Kao, Quận 1, Thành phố Hồ Chí Minh', CAST(N'2021-11-15T00:00:00.0000000' AS DateTime2), N'.Net Ajax C# SqlServer', N'chơi game , xem phim', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (85, N'/Images/04112021090410_03112021024211_avatar3.jfif', N'Trần Hữu Đông Triều', CAST(N'1996-06-12T00:00:00.0000000' AS DateTime2), N'115/17G Đường XTT20, Ấp 5, Xã Xuân Thới Thượng, Huyện Hóc Môn, Thành phố Hồ Chí Minh   ', CAST(N'2020-11-04T00:00:00.0000000' AS DateTime2), N'Java React Ajax Html5', N'đọc sách chơi game nghe nhạc', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (86, N'/Images/04112021090710_01112021084622_avatar2.jfif', N'Đỗ Tuấn Anh', CAST(N'1999-02-17T00:00:00.0000000' AS DateTime2), N'Phường Tân Phong, Quận 7, Thành phố Hồ Chí Minh ', CAST(N'2021-10-07T00:00:00.0000000' AS DateTime2), N'.Net Angular Html5', N'chạy bộ nghe nhạc đọc truyện', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (87, N'/Images/04112021091827_thjtuy.jpeg', N'Đỗ Hùng Dũng', CAST(N'2000-12-05T00:00:00.0000000' AS DateTime2), N'68 Trương Vĩnh Ký, Phường Tân Thành, Quận Tân Phú, Thành phố Hồ Chí Minh  ', CAST(N'2019-06-04T00:00:00.0000000' AS DateTime2), N'.Net Angular Html5 Java', N'chơi game , xem phim, nghe nhạc', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (88, N'/Images/04112021092044_imagessdsdew.jfif', N'Nguyễn Trọng Hoàng', CAST(N'1994-06-08T00:00:00.0000000' AS DateTime2), N'139 Bến Vân Đồn, Phường 06, Quận 4, Thành phố Hồ Chí Minh  ', CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2), N'.Net Angular Html5 Css Bootstrap', N'đá bóng, chạy bộ , đọc sách', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (89, N'/Images/04112021092242_dfgdfgdfgd.jpeg', N'Phan Văn Đức', CAST(N'1998-01-02T00:00:00.0000000' AS DateTime2), N'số 60 Nguyễn Văn Thủ, Phường Đa Kao, Quận 1, Thành phố Hồ Chí Minh  ', CAST(N'2021-02-10T00:00:00.0000000' AS DateTime2), N'Java Anular MySql Ajax ', N'nghe nhạc, xem phim đọc sách', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (90, N'/Images/04112021_imasdadages.jfif', N'Đoàn Văn An', CAST(N'1994-06-07T00:00:00.0000000' AS DateTime2), N'đường HT17, Phường Hiệp Thành, Quận 12, Thành phố Hồ Chí Minh  ', CAST(N'2021-11-30T00:00:00.0000000' AS DateTime2), N'.Net Ajax C# SqlServer ', N'chơi game nghe nhac xem phim', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (91, N'/Images/04112021092720_downloadasad.jfif', N'Lương Vũ Quang', CAST(N'1995-06-07T00:00:00.0000000' AS DateTime2), N'Phường Hiệp Bình Chánh, Thành phố Thủ Đức, Thành phố Hồ Chí Minh  ', CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), N'Java Anular MySql Ajax ', N'đọc sách nghe nhạc', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (94, N'/Images/No-Image.png', N'Nina Travis', CAST(N'1999-11-13T00:00:00.0000000' AS DateTime2), N'Qui quibusdam duis dolor nesciunt dolores deserunt duis', CAST(N'2021-08-27T00:00:00.0000000' AS DateTime2), N'Et excepturi in sunt similique rerum iure voluptate', N'Cumque sed ut quaerat explicabo Veniam porro esse quae molestiae qui', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (95, N'/Images/04112021_01112021111053_06082021121552_1-small.png', N'Kennedy Solis', CAST(N'1984-06-19T00:00:00.0000000' AS DateTime2), N'Id totam doloribus soluta deserunt quos aliquam dolor asperiores', CAST(N'2017-05-02T00:00:00.0000000' AS DateTime2), N'Corrupti quas commodo unde quisquam ut anim officiis omnis', N'Voluptates eius expedita aliquam harum quod veniam minim nihil repudiandae nostrum rerum dolor ut minus alias', 0, 1)
INSERT [dbo].[Employees] ([EmployeeId], [Photo], [EmployeeName], [Dob], [Street], [Workingday], [Skill], [Introduce], [IsDeleted], [OfficeId]) VALUES (96, N'/Images/04112021_03112021015958_01112021045250_01112021084239_avatar4.jfif', N'Dale Hatfield', CAST(N'1984-05-27T00:00:00.0000000' AS DateTime2), N'In id accusamus iusto provident deleniti fugiat pariatur Consequatur Dolorem ullamco nostrud tempor a id', CAST(N'2004-04-16T00:00:00.0000000' AS DateTime2), N'Voluptate magni quia temporibus voluptatibus labore ut sint', N'Dolore corporis nisi molestiae quia cupidatat nihil anim aperiam eligendi beatae quibusdam omnis elit rerum', 0, 1)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Offices] ON 

INSERT [dbo].[Offices] ([OfficeId], [OfficeName], [Street], [Amount], [IsDeleted]) VALUES (1, N'Văn Phòng Hồ Chí Minh', N'Số 9 Đinh Tiên Hoàng, P.Đakao, Q1,TP.HCM', 0, 0)
INSERT [dbo].[Offices] ([OfficeId], [OfficeName], [Street], [Amount], [IsDeleted]) VALUES (2, N'Văn Phòng Huế', N'Số 2 Lê Quý Đôn, P.Phú Hội, TP. Huế, Tỉnh Thừa Thiên Huế', 0, 0)
SET IDENTITY_INSERT [dbo].[Offices] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Offices_OfficeId] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([OfficeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Offices_OfficeId]
GO
/****** Object:  StoredProcedure [dbo].[GET_COUNT_EMPLOYEE]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_COUNT_EMPLOYEE]
	AS   
    SET NOCOUNT ON;  
    SELECT count(*) demo
    FROM Employees
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_EMPLOYEE]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_LIST_EMPLOYEE]
	AS   
    SET NOCOUNT ON;  
    SELECT *
    FROM Employees
GO
/****** Object:  StoredProcedure [dbo].[GET_LIST_EMPLOYEE_DK]    Script Date: 11/16/2022 10:46:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_LIST_EMPLOYEE_DK]
	@code int
	AS
	SELECT * 
	FROM Employees
	WHERE EmployeeId = @code
GO
