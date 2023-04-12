create database NotaEstudiante

use NotaEstudiante

create table Nota
(
IdNotas int primary key not null,
Materia varchar not null,
NombreEstudiante varchar,
Lab1 decimal,
Parcial1 decimal,
Lab2 decimal,
Parcial2 decimal,
Lab3 decimal,
Parcial3 decimal,
Resultado decimal

)