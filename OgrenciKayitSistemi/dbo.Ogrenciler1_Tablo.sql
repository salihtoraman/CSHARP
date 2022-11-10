CREATE TABLE [dbo].[Ogrenciler1_Tablo] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Isim]    NVARCHAR (50) NOT NULL,
    [Soyisim] NVARCHAR (50) NOT NULL,
    [Telefon] CHAR (15)     NOT NULL,
    [TC]      CHAR (11)     NOT NULL,
    [Resim]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Ogrenciler1_Tablo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

