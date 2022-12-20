create database WoodNotesDB
drop database WoodNotesDB   /*Ojo a la linea*/

use WoodNotesDB

create table UserNotes(
IdNota int identity,
Titulo varchar(80),
Contenido varchar(2000),
Fecha date,
)
drop table UserNotes   /*Ojo a la linea*/

insert into UserNotes([Titulo],[Contenido],[Fecha]) values ('WAZAAA','eso tilin, vaya tilin','2022-12-19')
select * from UserNotes