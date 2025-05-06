
USE master;
GO
create database Restaurante;
go
use Restaurante;
go
create table chef (
codigo int primary key not null,
nombre nvarchar(80) not null,
telefono int not null default 0,
experiencia int
);

go
create table platos (
id int primary key not null,
nombre nvarchar(50) not null,
valor money not null default 0,
codigo_chef int foreign key references chef(codigo)
);
go


create table ingredientes
(
	codigo int primary key not null,
	nombre nvarchar(50) not null,
	cantidad int not null,
	valor_unidad real,
	cod_plato int foreign key references platos(id)
)
go

create table usuarios
(
	usuario nvarchar(50) primary key not null,
	clave nvarchar(50),
	pregunta nvarchar(50),
	respuesta nvarchar(50),
)
go

insert into chef values 
(1, 'Juan', 22222, 5),
(2, 'Ana', 333333, 2),
(3, 'Gabriel', 444444, 10),
(4, 'Eulises', 55555, 3);
go

insert into platos values 
(1, 'Sancocho', 18500, 1),
(2, 'Frijoles', 5000, 2),
(3, 'Ajiaco', 12000, 3),
(4, 'Mondongo', 15000, 2),
(5, 'Mazamorra', 2000, 4),
(6, 'Lentejas', 6000, 3);
go

insert into ingredientes values 
(1, 'Papa', 20, 500, 1),
(2, 'Zanahoria', 10, 700, 2),
(3, 'Yuca', 30, 1200, 1),
(4, 'Maiz', 30, 200, 5),
(5, 'Carne de Res', 40, 16000, 3),
(6, 'Carne de Cerdo', 30, 10000, 6);
go

insert into usuarios values
('Pepe', 'A1B2', 'Mascota', 'Luna'),
('Juan', 'C3E5', 'Conyugue', 'Ana'),
('Lucia', 'T8R6', 'Equipo', 'Nacional'),
('PeterParker', '1234', 'SuperHeroe', 'SpiderMan');
go



