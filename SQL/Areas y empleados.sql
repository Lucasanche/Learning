/*DDL Data Definition Language*/
-- Create
-- Alter
-- Drop

/* DML Data Manipulation Language */
-- Insert
-- Update
-- Delete

Create Database ClaseDos
GO
Use ClaseDos
GO
Create Table Empleados(
    ID bigint not null primary key identity(1,1),
    Apellido Varchar(100) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Genero char,
    IDArea smallint
)

Alter table Empleados
ADD FechaNacimiento date null

Create Table Areas(
    id smallint NOT NULL,
    NOmbre varchar(40) NOT NULL,
    Presupuesto money not null,
    email varchar(120) not null unique
)
go

alter table Areas
add constraint PK_Areas PRIMARY key(ID)
alter table Areas
add constraint chk_presupuestoPositivo check(Presupuesto > 0)
go

Alter table Empleados
add constraint FK_Empleados_Areas Foreign KEY (IDAreas)
references Areas(ID)
go