Create database Ejemplo_PK_Compuesta
go
use Ejemplo_PK_Compuesta
go
create table Examenes(
    Legajo varchar(10) not null,
    IDMateria varchar(5) not null,
    Fecha date not null,
    Nota decimal(4, 2) null
)
go
Alter Table Examenes
Add Constraint PK_Examenes primary key (Legajo, IDMateria, Fecha)
go
Alter Table Examenes
Add CONSTRAINT CHK_Nota Check (Nota >= 0 AND Nota <= 10)