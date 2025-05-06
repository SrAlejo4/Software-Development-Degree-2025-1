use master;
go
create database Empresa;
go
use Empresa;
go


create table programadores 
(
	cedula int primary key,
	nombre nvarchar(50) not null,
	area_fase nvarchar(50) not null,
	salario real
);
go

create table aplicacion
(
	codigo varchar(10) primary key,
	tipo nvarchar(30) not null,
	tiempo_dias int not null,
	programador int foreign key references programadores(cedula)
);
go

create table usuarios
(
	clave int primary key,
	nombre nvarchar(50) not null,
	pregunta nvarchar(50),
	respuesta nvarchar(50)
);
go

insert into programadores values
(1, 'Julian', 'Desarrollador Junior', 2500000),
(2, 'Andres', 'Desarrollar FrontEnd', 3000000),
(3, 'Julian', 'Desarrollador BackEnd', 5000000),
(4, 'Julian', 'Desarrollador FullStack', 7500000);
go

insert into aplicacion values
(1, 'Escritorio', 160, 4),
(2, 'Web', 200, 3),
(3, 'Movil', 150, 2),
(4, 'Web', 160, 1),
(5, 'Escritorio', 110, 2),
(6, 'Web', 90, 3),
(7, 'Web', 60, 2),
(8, 'Movil', 30, 4),
(9, 'Escritorio', 120, 3),
(10, 'Web', 130, 2);
go

insert into usuarios values
(12345, 'admin', 'capital colombia', 'bogota'),
(1020304050, 'jefe', 'animal favorito', 'perro');
go

select * from programadores
select * from aplicacion
select * from usuarios