create database actividad_1_3
go

use actividad_1_3

create table categoriasDeProducto(
    ID smallint PRIMARY KEY,
    descripcion varchar(100) not null
)
go

create table productos(
    ID SMALLINT primary KEY,
    IDcategoria smallint FOREIGN KEY REFERENCES categoriasDeProducto(ID),
    descripcion varchar(100) not null,
    precioMinorista money not null,
    precioMayorista money check(precioMinorista > precioMayorista),
    cantidadMayorista smallint,
    diasRequeridos tinyint not null
)
go
create table clientes(
    ID smallint primary key,
    apellidos varchar(50) not null,
    nombres varchar(50) not null,
    fechaNacimiento date check(fechaNacimiento <= getDate()),
    mail varchar(100),
    telefono varchar(16),
    celular varchar(16),
    registroWeb bit
)
go

create table pedidos(
    ID smallint primary key IDENTITY (1,1),
    IDproducto smallint FOREIGN KEY REFERENCES productos(ID) not null,
    IDcliente smallint FOREIGN KEY REFERENCES clientes(ID) not null,
    unidades smallint not null,
    fechaSolicitud date not null,
    fechaPreparado date,
    importeTotal money not null,
    abonado bit not null
)
go

create table colaboradores(
    legajo smallint primary key,
    nombres varchar(50) not null,
    apellidos varchar(50) not null,
    fechaNacimiento date not null,
    edad tinyint not null,
    anyoIngreso smallint check (anyoIngreso > 1990 and anyoIngreso <= getDate()) not null,
    antiguedad tinyint not null,
    sueldo money not null,
    modalidad char not null
)
