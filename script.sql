USE [YurtDb]
GO
/****** Object:  Table [dbo].[Gıderler]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gıderler](
	[gıderID] [int] IDENTITY(1,1) NOT NULL,
	[giderTuru] [nvarchar](50) NOT NULL,
	[giderTutar] [int] NULL,
 CONSTRAINT [PK_Gıderler] PRIMARY KEY CLUSTERED 
(
	[gıderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izınler]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izınler](
	[IzınID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciID] [int] NULL,
	[OgrenciTC] [nvarchar](50) NULL,
	[gidisTarihi] [datetime] NULL,
	[donusTarihi] [datetime] NULL,
	[gidecegiKisiTel] [nvarchar](50) NOT NULL,
	[gşdecegiAdres] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Izınler_1] PRIMARY KEY CLUSTERED 
(
	[IzınID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[OdaID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciID] [int] NULL,
	[OgrenciTC] [nvarchar](50) NOT NULL,
	[OdaNo] [int] NULL,
	[OdaKatNo] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[OdaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odemeler]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odemeler](
	[OdemeID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciID] [int] NULL,
	[OgrenciTC] [nvarchar](50) NULL,
	[KalanTaksit] [int] NULL,
	[odenenTutar] [int] NOT NULL,
	[odemeTarihi] [datetime] NULL,
 CONSTRAINT [PK_Odemeler] PRIMARY KEY CLUSTERED 
(
	[OdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAdi] [nvarchar](50) NOT NULL,
	[OgrenciSoyadi] [nvarchar](50) NOT NULL,
	[OgrenciTC] [nvarchar](50) NOT NULL,
	[OgrenciOkul] [nvarchar](50) NOT NULL,
	[OgrenciBolum] [nvarchar](50) NOT NULL,
	[OgrenciSınıf] [nvarchar](50) NULL,
	[OgrenciKayitTarihi] [datetime] NULL,
	[KalacagiOda] [int] NULL,
	[OgrenciTelefon] [nvarchar](50) NOT NULL,
	[VeliAdi] [nvarchar](50) NOT NULL,
	[VeliTelefon] [nvarchar](50) NOT NULL,
	[OgrenciAdresi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 22.11.2019 17:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[YoneticiID] [int] IDENTITY(1,1) NOT NULL,
	[YoneticiAdi] [nvarchar](50) NOT NULL,
	[YoneticiSifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yonetici] PRIMARY KEY CLUSTERED 
(
	[YoneticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gıderler] ON 

INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (1, N'Mutfak', 1500)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (2, N'Temizlik', 250)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (3, N'Muhasebe', 2000)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (7, N'Diğer', 500)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (8, N'Mutfak', 500)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (11, N'Temizlik', 850)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (12, N'Muhasebe', 960)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (13, N'Temizlik', 500)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (16, N'Personel Maaş', 2500)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (17, N'Temizlik', 250)
INSERT [dbo].[Gıderler] ([gıderID], [giderTuru], [giderTutar]) VALUES (19, N'Personel Maaş', 2500)
SET IDENTITY_INSERT [dbo].[Gıderler] OFF
SET IDENTITY_INSERT [dbo].[Izınler] ON 

INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (1, 3, N'54124720498', CAST(N'2019-11-18T00:00:00.000' AS DateTime), CAST(N'2019-11-25T00:00:00.000' AS DateTime), N'5436985487', N'Bursa')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (2, 5, N'65465465462', CAST(N'2019-10-11T00:00:00.000' AS DateTime), CAST(N'2019-11-11T00:00:00.000' AS DateTime), N'5456596565', N'Karaman')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (4, 3, N'54124720498', CAST(N'2019-11-18T18:05:41.297' AS DateTime), CAST(N'2019-11-18T18:05:41.297' AS DateTime), N'(544) 444-4444', N'Ankara')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (6, 5, N'65465465462', CAST(N'2019-11-18T18:13:54.303' AS DateTime), CAST(N'2019-11-18T18:13:54.290' AS DateTime), N'(544) 444-4444', N'Van')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (10, 8, N'11111111111', CAST(N'2019-11-18T18:40:35.330' AS DateTime), CAST(N'2019-11-18T18:40:35.327' AS DateTime), N'(555) 555-5555', N'Yalova')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (14, NULL, N'25252525252', CAST(N'2019-11-20T00:33:57.860' AS DateTime), CAST(N'2019-11-20T00:33:57.847' AS DateTime), N'(   )    -', N'')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (18, NULL, N'54124720498', CAST(N'2019-11-20T00:42:18.097' AS DateTime), CAST(N'2019-11-20T00:42:18.067' AS DateTime), N'(533) 333-3333', N'Yalova')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (19, NULL, N'96325874123', CAST(N'2019-11-20T00:46:06.650' AS DateTime), CAST(N'2019-11-20T00:46:06.650' AS DateTime), N'(546) 666-6666', N'Kırşehir')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (20, NULL, N'98765432198', CAST(N'2019-11-20T15:57:55.120' AS DateTime), CAST(N'2019-12-02T15:57:55.000' AS DateTime), N'(544) 444-4444', N'Rize')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (62, NULL, N'85521132165', CAST(N'2019-11-22T01:34:44.793' AS DateTime), CAST(N'2019-11-22T01:34:44.767' AS DateTime), N'(537) 777-7777', N'Niğde')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (63, NULL, N'85521132165', CAST(N'2019-11-22T01:40:31.193' AS DateTime), CAST(N'2019-11-22T01:40:31.167' AS DateTime), N'(547) 777-9666', N'Kayseri')
INSERT [dbo].[Izınler] ([IzınID], [OgrenciID], [OgrenciTC], [gidisTarihi], [donusTarihi], [gidecegiKisiTel], [gşdecegiAdres]) VALUES (65, NULL, N'25252525252', CAST(N'2019-11-22T17:31:08.643' AS DateTime), CAST(N'2019-11-22T17:31:08.627' AS DateTime), N'(542) 222-2222', N'Adana')
SET IDENTITY_INSERT [dbo].[Izınler] OFF
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (1, 3, N'54124720498', 1, 1)
INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (4, 5, N'65465465462', 40, 1)
INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (5, 6, N'55555555555', 20, 2)
INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (6, 7, N'66666666666', 20, 2)
INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (7, 8, N'11111111111', 40, 3)
INSERT [dbo].[Odalar] ([OdaID], [OgrenciID], [OgrenciTC], [OdaNo], [OdaKatNo]) VALUES (8, 9, N'22222222222', 2, 3)
SET IDENTITY_INSERT [dbo].[Odalar] OFF
SET IDENTITY_INSERT [dbo].[Odemeler] ON 

INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (6, NULL, N'54124720498', 7000, 250, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (7, NULL, N'96325874123', 6000, 1000, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (9, NULL, N'98765432198', 8500, 750, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (11, NULL, N'85521132165', 9500, 250, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (12, NULL, N'11111111111', 2500, 350, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (14, NULL, N'25252525252', 9500, 500, NULL)
INSERT [dbo].[Odemeler] ([OdemeID], [OgrenciID], [OgrenciTC], [KalanTaksit], [odenenTutar], [odemeTarihi]) VALUES (15, NULL, N'25252525252', 9000, 500, NULL)
SET IDENTITY_INSERT [dbo].[Odemeler] OFF
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 

INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (3, N'Fatma', N'Küpeli', N'54124720498', N'Boğaziçi Üniversitesi', N'Bilgsayar Mühendisliği', N'1', CAST(N'2019-11-17T22:56:50.640' AS DateTime), 1, N'(541) 211-1111', N'Hakan', N'(542) 111-1111', N'Manisa')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (5, N'Ali', N'Demir', N'65465465462', N'İstanbul Teknik Üniversitesi', N'Uçak Mühendisliği', N'3', CAST(N'2019-11-18T12:46:50.090' AS DateTime), 40, N'(555) 555-5555', N'Rıza', N'(555) 555-5555', N'Ordu')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (6, N'Merve', N'Akar', N'55555555555', N'İstanbul Üniversitesi', N'İşletme', N'4', CAST(N'2019-11-18T12:53:55.067' AS DateTime), 20, N'(555) 555-5555', N'Veli', N'(533) 333-3333', N'Samsun')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (7, N'Özlem', N'Özdemir', N'66666666666', N'Bahçeşehir Üniversitesi', N'İnsan Kaynakları', N'2', CAST(N'2019-11-18T12:58:58.957' AS DateTime), 20, N'(544) 444-4444', N'Sedat', N'(544) 444-4443', N'Çanakkale')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (8, N'Zekeriyya', N'Ballı', N'11111111111', N'Boğaziçi', N'Mekatronik', N'2', CAST(N'2019-11-18T13:12:07.807' AS DateTime), 40, N'(544) 444-4444', N'Mehmet', N'(544) 444-4444', N'Bursa')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (9, N'Buse', N'Ada', N'22222222222', N'Marmara', N'Ekonomi', N'1', CAST(N'2019-11-18T13:14:19.753' AS DateTime), 2, N'(544) 444-4444', N'Ahmet', N'(544) 444-4444', N'Tekirdağ')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (10, N'Hakan', N'Yıldırım', N'25252525252', N'Boğaziçi Üniversitesi', N'Bilgisayar Mühendisliği', N'5', CAST(N'2019-11-21T17:25:44.633' AS DateTime), 37, N'(544) 444-4444', N'Hasan', N'(532) 222-2222', N'Muğla')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (12, N'Nil', N'Acar', N'55555555555', N'Galatasaray Üniversitesi', N'Halkla İlişkiler', N'5', CAST(N'2019-11-18T20:15:51.143' AS DateTime), 18, N'(544) 444-4444', N'Ahmet', N'(538) 888-8888', N'Gaziantep')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (14, N'Ayşe', N'Yılmaz', N'55555555555', N'İTÜ', N'Endüstri Mühendisliği', N'2', CAST(N'2019-11-18T23:46:35.033' AS DateTime), 18, N'(547) 777-7777', N'Fatma', N'(547) 777-7784', N'Kırklareli')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (15, N'Elif', N'Yılmaz', N'57444444444', N'Boğaziçi Üniversitesi', N'Elektrik Elektronik Mühendisliği', N'4', CAST(N'2019-11-19T16:00:59.603' AS DateTime), 3, N'(532) 222-2222', N'Arzu', N'(532) 474-4444', N'Yalova')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (18, N'Hilal ', N'Demirdere', N'96325874123', N'İstanbul Kültür Üniversitesi', N'Yazılım Mühendisliği', N'4', CAST(N'2019-11-19T17:54:53.067' AS DateTime), 11, N'(547) 899-999', N'Gülçin', N'(547) 777-7777', N'Kütahya')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (19, N'Neslihan', N'Yıldırım', N'55555555555', N'YTÜ', N'Endüstri', N'2', CAST(N'2019-11-18T00:00:00.000' AS DateTime), 9, N'5477777777', N'Veli', N'5444444444', N'Van')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (21, N'Burcu', N'Burcu', N'55555555555', N'YTü', N'Endüstri', N'2', CAST(N'2019-11-11T00:00:00.000' AS DateTime), 8, N'5454444444', N'Veli', N'5444444444', N'Antalya')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (22, N'Aslı', N'Yıldız', N'55555555555', N'YTÜ', N'Endüstri', N'2', CAST(N'2019-11-11T00:00:00.000' AS DateTime), 5, N'5444444444', N'Veli', N'5444444444', N'Antalya')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (24, N'Fatma', N'Küpeli', N'54124720498', N'Boğaziçi Üniversitesi', N'Bilgsayar Mühendisliği', N'1', CAST(N'2019-11-20T00:04:37.570' AS DateTime), 9, N'(541) 211-1111', N'Hakan', N'(542) 111-1111', N'Manisa')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (25, N'Berkay', N'Çalış', N'12345678912', N'İstanbul Aydın Üniversitesi', N'Sağlık Bilimleri', N'1', CAST(N'2019-11-20T00:06:31.000' AS DateTime), 33, N'(544) 444-4444', N'Gökay', N'(544) 444-4444', N'Manisa')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (26, N'İpek', N'Dinçer', N'65498732165', N'Galatasaray Üniversitesi', N'İşletme', N'5', CAST(N'2019-11-20T00:08:11.590' AS DateTime), 18, N'(544) 444-4444', N'Ayşe', N'(544) 444-4444', N'İstanbul')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (28, N'Ahmet', N'Kara', N'54133720106', N'İTÜ', N'Bilgisayar Mühendisliği', N'4', CAST(N'2019-11-20T16:04:29.877' AS DateTime), 34, N'(544) 444-4444', N'Ali', N'(534) 444-4444', N'Artvin')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (30, N'Ali Rıza', N'Yılmaz', N'54133720106', N'İTÜ', N'Endüstri Mühendisliği', N'3', CAST(N'2019-11-21T16:52:28.347' AS DateTime), 35, N'(542) 222-2222', N'Buse', N'(532) 222-2222', N'Bursa')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (32, N'Yıldız', N'Sarıoğlu', N'85521132165', N'YTÜ', N'', N'3', CAST(N'2019-11-22T01:57:32.877' AS DateTime), 13, N'(547) 788-8888', N'Halit', N'(536) 666-6666', N'Hatay')
INSERT [dbo].[Ogrenciler] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciTC], [OgrenciOkul], [OgrenciBolum], [OgrenciSınıf], [OgrenciKayitTarihi], [KalacagiOda], [OgrenciTelefon], [VeliAdi], [VeliTelefon], [OgrenciAdresi]) VALUES (33, N'Merve ', N'Dere', N'65498732121', N'Sabancı Üniversitesi', N'YBS', N'5', CAST(N'2019-11-22T02:14:22.373' AS DateTime), 11, N'(547) 788-8888', N'Mehdi', N'(546) 666-6666', N'Zonguldak')
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
SET IDENTITY_INSERT [dbo].[Yonetici] ON 

INSERT [dbo].[Yonetici] ([YoneticiID], [YoneticiAdi], [YoneticiSifre]) VALUES (1, N'admin', N'123456')
INSERT [dbo].[Yonetici] ([YoneticiID], [YoneticiAdi], [YoneticiSifre]) VALUES (2, N'nagihan', N'010101')
INSERT [dbo].[Yonetici] ([YoneticiID], [YoneticiAdi], [YoneticiSifre]) VALUES (3, N'calisan', N'012345')
SET IDENTITY_INSERT [dbo].[Yonetici] OFF
ALTER TABLE [dbo].[Izınler]  WITH CHECK ADD  CONSTRAINT [FK_Izınler_Ogrenciler] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenciler] ([OgrenciID])
GO
ALTER TABLE [dbo].[Izınler] CHECK CONSTRAINT [FK_Izınler_Ogrenciler]
GO
ALTER TABLE [dbo].[Odalar]  WITH CHECK ADD  CONSTRAINT [FK_Odalar_Ogrenciler] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenciler] ([OgrenciID])
GO
ALTER TABLE [dbo].[Odalar] CHECK CONSTRAINT [FK_Odalar_Ogrenciler]
GO
ALTER TABLE [dbo].[Odemeler]  WITH CHECK ADD  CONSTRAINT [FK_Odemeler_Ogrenciler] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenciler] ([OgrenciID])
GO
ALTER TABLE [dbo].[Odemeler] CHECK CONSTRAINT [FK_Odemeler_Ogrenciler]
GO
