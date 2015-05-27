USE [fareManagment]
GO
SET IDENTITY_INSERT [dbo].[visitor] ON 

INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (1, N'Md. Yeasin Arafat', N'Yeasinmahi72@gmail.com', N'01676272718')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (2, N'Md. Tarik Rahman', N'Tarikrahman@gmail.com', N'01558965324')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (3, N'Farida Yeasmin', N'farida.Yeasmin@yahoo.com', N'01678178653')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (4, N'Ananna Rahman', N'ananna.rahman@gmail.com', N'01723654879')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (5, N'Arifa Yeasmin', N'arifa.yeasmin@yahoo.com', N'01726856478')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (6, N'foysal mahmud', N'f.mahmud@live.com', N'01726584756')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (7, N'Mahbubur Rahman', N'mahbub.rahman@gmail.com', N'01680861291')
INSERT [dbo].[visitor] ([vid], [name], [email], [contact]) VALUES (8, N'Kisor Kumar', N'k.kumar@hotmail.com', N'01556898756')
SET IDENTITY_INSERT [dbo].[visitor] OFF
SET IDENTITY_INSERT [dbo].[zone] ON 

INSERT [dbo].[zone] ([zid], [zoneName]) VALUES (5, N'Digital Bagladesh Zone')
INSERT [dbo].[zone] ([zid], [zoneName]) VALUES (1, N'Enterprise Application Zone')
INSERT [dbo].[zone] ([zid], [zoneName]) VALUES (3, N'Game & Multimedia Zone')
INSERT [dbo].[zone] ([zid], [zoneName]) VALUES (2, N'Mobile App Zone')
INSERT [dbo].[zone] ([zid], [zoneName]) VALUES (4, N'Telecom Software Zone')
SET IDENTITY_INSERT [dbo].[zone] OFF
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (1, 1)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (1, 5)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (1, 6)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (1, 7)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (1, 8)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (2, 1)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (2, 3)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (2, 7)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (3, 6)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (3, 7)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (4, 5)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (4, 7)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (4, 8)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (5, 5)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (5, 6)
INSERT [dbo].[visitorAndZone] ([zid], [vid]) VALUES (5, 7)
