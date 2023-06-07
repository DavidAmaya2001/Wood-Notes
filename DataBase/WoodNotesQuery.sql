create database WoodNotesDB  /* Creación de la base de datos */

/* Alerta */
drop database WoodNotesDB   /* Eliminar la base de datos completa */

use WoodNotesDB /* Uso de la base de datos */

------------------------------------------------------------- CREACION DE TABLAS -------------------------------------------------------------------------------------

--Relación 1:N
-- Users 1 : N UserNotes

create table Users(
idUsers int identity(1,1),
nombre varchar(20) not null,
apellido varchar(20),
pais varchar(15) not null,
codigo varchar(6) not null,
telefono varchar(9) not null,
foto image,
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

-- Relación 1:1
-- Users 1 : 1 UserCredentials

create table UserCredentials(
idCredencial int identity(1,1),
nickname varchar(15) not null,
pPassword varbinary(1200) not null,
correo varchar(50) not null,
)

-- Agregando Llave Foranea relacionando UserNotes con Users
alter table UserNotes add constraint FK_UserNotes_Users
foreign key(idUsers) references Users(idUsers);

alter table UserCredentials add constraint FK_Credentials_Users
foreign key(idCredencial) references Users(idUsers);

-- hashKey para las Passwords Encriptadas
declare @hashkey varchar(25)
set @hashkey = 'wood-notes'
print @hashkey

--------------------------------------------------------------------------- PRUEBAS ------------------------------------------------------------------------------------

/* Alerta */
drop table Users
drop table UserCredentials    /* Eliminación de tablas */
drop table UserNotes   

--------------------------- Tabla Users y UserCredentials ------------------------------------------

/* Seleccion de tablas de Usuario */
select* from Users
select * from UserCredentials
select foto from Users where idUsers = 3
select UserCredentials.idCredencial, UserCredentials.nickname, UserCredentials.pPassword, Users.foto from Users JOIN UserCredentials ON Users.idUsers = UserCredentials.idCredencial where idCredencial = 3
select Users.foto from Users JOIN UserCredentials ON Users.idUsers = UserCredentials.idCredencial where nickname = 'WAZAAA'

/* Creacion de usuarios [Invitado] y pruebas para la base de datos */
declare @hashkey varchar(25)
set @hashkey = 'wood-pass'
insert into Users values('Invitado',null,'Default','Def','Default',null,'2023-02-26')
insert into UserCredentials values ('Invitado',ENCRYPTBYPASSPHRASE(@hashkey,'Invitado'),'example@gmail.com')

declare @hashkey varchar(25)
set @hashkey = 'wood-pass'
insert into Users values('Juan Francisco','Perez Muñoz','El Salvador','+(503)','2273-6000',null,'2023-02-23')
insert into UserCredentials values('El pepe',ENCRYPTBYPASSPHRASE(@hashkey,'87654321'),'elpepe@gmail.com')

declare @hashkey varchar(25)
set @hashkey = 'wood-pass'
insert into Users values('Pedro Melgar','Perez Bermudez','El Salvador','6163-1643',null,'2023-02-23')
insert into UserCredentials values('Tilin',ENCRYPTBYPASSPHRASE(@hashkey,'contrasenasecreta','tilinsupremo@gmail.com')

/* Eliminacion de usuarios de pruebas */
delete from UserCredentials where idCredencial = 2
delete from Users where idUsers = 2

-- Reset de Identity --
DBCC CHECKIDENT ('Users',RESEED,1)
DBCC CHECKIDENT ('UserCredentials',RESEED,1)

/* Seleccion de usuarios en base a Nickname y Password encriptada */

declare @hashkey varchar(25)
set @hashkey = 'wood-notes'
select idCredencial,nickname,pPassword from UserCredentials where nickname = 'El pepe' and CONVERT(varchar(max),DECRYPTBYPASSPHRASE(@hashkey,pPassword)) = '87654321'

---------------------------------------- Tabla UserNotes ------------------------------------------

select * from UserNotes where idUsers = 1
insert into UserNotes values('Wazaaaaa','Alerta presente que camaron que se duerme se lo lleva la corriente','2023-02-23','2023-02-23',66,null,2)
insert into UserNotes values('Nota secreta','Vamono de fiesta factory, pero lleva mucho botiquin','2023-02-23','2023-02-23',60,null,2)
insert into UserNotes values('Nota secreta pero del otro usuario','No llego tilin y tampoco ete sech','2023-02-23','2023-02-23',45,null,3)

IF EXISTS (SELECT * FROM Users WHERE idUsers = 1)
BEGIN
INSERT INTO UserNotes (titulo, contenido, fecha, modificacion, caracteres, peso, idUsers)
VALUES ('Wazaaaaa', 'Alerta presente que camaron que se duerme se lo lleva la corriente', '2023-02-23', '2023-02-23', 66, NULL, 1)
END

DBCC CHECKIDENT ('UserNotes',RESEED,1)


/* Reset de Tabla */
truncate table UserNotes

----------------------------------------- Actualizaciones ------------------------------------------

update UserNotes set titulo = 'El wazaaaa supremo', contenido = 'Alerta presente que camaron que se duerme se lo lleva la corriente vol.2 del batallon atlacatl', modificacion = '2023-02-24' where idNota=3 and idUsers = 1