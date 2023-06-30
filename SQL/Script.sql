CREATE DATABASE Registros;
USE Registros;
CREATE TABLE Personas
(
	IdPersona INT IDENTITY(1,1) PRIMARY KEY,
	TipoIdentificacion VARCHAR(20) NOT NULL,
	NumeroIdentificacion VARCHAR(20) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Apellido VARCHAR(20) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Direccion VARCHAR(50),
	Direccion2 VARCHAR(50),
	Correo VARCHAR(50),
	Correo2 VARCHAR(50),
	Telefono VARCHAR(50),
	Telefono2 VARCHAR(50)
	CONSTRAINT UC_Persona UNIQUE (TipoIdentificacion, NumeroIdentificacion)
)