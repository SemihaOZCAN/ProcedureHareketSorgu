USE [DbHareket]
GO
/****** Object:  StoredProcedure [dbo].[Hareket]    Script Date: 29.08.2024 12:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Hareket]
as
select TblUrunler.AD as 'Ürün Ad', TblMusteriler.ADSOYAD as 'Müşteri',TblPersonel.AD as 'Personel',FIYAT as 'Fiyat' from TblHareket inner join TblUrunler
on
TblHareket.URUN=TblUrunler.ID
inner join TblMusteriler
on
TblHareket.MUSTERI=TblMusteriler.ID
inner join TblPersonel
on
TblHareket.PERSONEL=TblPersonel.ID
