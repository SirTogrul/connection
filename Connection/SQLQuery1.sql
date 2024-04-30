create database Steam
use Steam
create table Games
(
Id int primary key identity,
[Name]  nvarchar(50) not null,
Price decimal(18,2)
)
select * from Games