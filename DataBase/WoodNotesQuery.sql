create database WoodNotesDB
drop database WoodNotesDB   /*Ojo a la linea*/

use WoodNotesDB

------------------- CREACION DE TABLAS -----------------------

--Relación 1:N
-- Users 1 : N UserNotes

create table Users(
idUsers int identity(1,1),
nombre varchar(30) not null,
apellido varchar(30),
pais varchar(20),
telefono varchar(15),
nickname varchar(15) not null,
fecha_union date not null,
--Llave primaria --
primary key(idUsers)
);

create table UserNotes(
idNota int identity(1,1),
titulo varchar(50) not null,
contenido varchar(2000) not null,
fecha date,
modificacion date,
caracteres int,
peso int,
idUsers int not null,
primary key(idNota)
);

alter table UserNotes add idUsers int not null;

-- Agregando Llave Foranea relacionando UserNotes con Users
alter table UserNotes add constraint FK_UserNotes_Users
foreign key(idUsers) references Users(idUsers);


---------------------------- PRUEBAS --------------------------------

drop table Users
drop table UserNotes   /*Ojo a la linea*/

---- Tabla Users----
select * from Users
insert into Users values('Juan Francisco','Perez Muñoz','El Salvador','2273-6000','Wazaaaa','2023-02-23')
insert into Users values('Pedro Melgar','Perez Bermudez','El Salvador','6163-1643','El Tilin','2023-02-23')

delete from Users where idUsers = 3
-- Reset de Identity --
DBCC CHECKIDENT ('Users',RESEED,0)

----Tabla UserNotes ----
select * from UserNotes
insert into UserNotes values('Wazaaaaa','Alerta presente que camaron que se duerme se lo lleva la corriente','2023-02-23','2023-02-23',66,null,1)
insert into UserNotes values('Nota secreta','Vamono de fiesta factory, pero lleva mucho botiquin','2023-02-23','2023-02-23',60,null,1)
insert into UserNotes values('Nota secreta pero del otro usuario','No llego tilin y tampoco ete sech','2023-02-23','2023-02-23',45,null,2)

select * from UserNotes where idUsers = 2

truncate table UserNotes

---- Actualizaciones ----
update UserNotes set titulo = 'El wazaaaa supremo', contenido = 'Alerta presente que camaron que se duerme se lo lleva la corriente vol.2 del batallon atlacatl', modificacion = '2023-02-24' where idNota=1 and idUsers = 1