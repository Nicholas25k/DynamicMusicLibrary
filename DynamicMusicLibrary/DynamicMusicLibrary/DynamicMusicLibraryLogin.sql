create database DynamicMusicLibraryLoginDb
go
use DynamicMusicLibraryLoginDb
go
create table [User]
(
	Id UNIQUEIDENTIFIER primary Key default NEWID(),
	Username nvarchar (50) unique not null,
	[Password] nvarchar (100) not null,
	[Name] nvarchar (50) not null,
	LastName nvarchar (50) not null,
	Email nvarchar (50) unique not null
)

go
insert into [User] values (NEWID(), 'admin', 'admin', 'Nick', 'Kleiner', 'nklei25@gmail.com')
go

select *from [User]