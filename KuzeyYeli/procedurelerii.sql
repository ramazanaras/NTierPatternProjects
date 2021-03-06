USE [KuzeyYeli]
GO
/****** Object:  StoredProcedure [dbo].[prc_KategoriEkle]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_KategoriEkle]
@adi nvarchar(50),
@tanim nvarchar(150)
as
begin

insert into Kategoriler(KategoriAdi,Tanimi) values(@adi,@tanim)

end

GO
/****** Object:  StoredProcedure [dbo].[prc_KategoriGuncelle]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_KategoriGuncelle]
@id int,
@adi nvarchar(50),
@tanim nvarchar(100)
as
begin

update Kategoriler set KategoriAdi=@adi,Tanimi=@tanim where KategoriID=@id

end

GO
/****** Object:  StoredProcedure [dbo].[prc_KategoriListele]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_KategoriListele]
as
begin

select*from Kategoriler



end
GO
/****** Object:  StoredProcedure [dbo].[prc_KategoriSil]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_KategoriSil]
@kategoriId int
as
begin

delete from Kategoriler where KategoriID=@kategoriId
end

GO
/****** Object:  StoredProcedure [dbo].[prc_TedarikciListele]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_TedarikciListele]
as
begin

select*from Tedarikciler

end
GO
/****** Object:  StoredProcedure [dbo].[UrunEkle]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UrunEkle]
@urunAdi nvarchar(50),
@fiyat money,
@stok smallint,
@kId int,
@tId int
as
begin
declare @trimli nvarchar(50)=ltrim(rtrim(@urunAdi))--sağdan ve soldan boşluğu al
if(exists(select*from Urunler where UrunAdi=@trimli))--sorgu true ve ya false döndürür.
begin
print 'Bu ürün zaten eklidir'
end

else
begin
insert into Urunler(UrunAdi,Fiyat,Stok,KategoriID,TedarikciID) values(@trimli,@fiyat,@stok,@kId,@tId)
end

end
GO
/****** Object:  StoredProcedure [dbo].[UrunListele]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UrunListele] 
as
begin

select *from Urunler

end
GO
/****** Object:  StoredProcedure [dbo].[UrunSil]    Script Date: 24.9.2016 02:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UrunSil]
@urunId int
as
begin
delete from Urunler where UrunID=@urunId
end
GO
