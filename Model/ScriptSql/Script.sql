CREATE DATABASE DB_Elecciones;
USE DB_Elecciones;
/*
CREATE TABLE Usuarios (
    IdUsuario INT primary key auto_increment,
    DocumentoIdentidad VARCHAR (50)  NULL,
    Nombres VARCHAR (100) NULL,
    Apellidos VARCHAR (100) NULL,
    Correo VARCHAR (100) NULL,
	LoginName VARCHAR (100) NULL,
    PassWord VARCHAR (100) NULL,
    Activo bit(1) default null,
    Rol VARCHAR (50) NULL,
    foto longblob not null
);

CREATE TABLE Elecciones (
    IdEleccion INT primary key auto_increment,
    Descripcion VARCHAR (100) NULL,
    Cargo VARCHAR (100) NULL,
    Activo bit(1) default null,
    FechaRegistro date NULL,
    FechaVotacion date NULL,
    IdUsuario INT NULL,
    Foto longblob null,
    foreign key (IdUsuario) references Usuarios(IdUsuario)
);

CREATE TABLE Candidatos (
    IdCandidato INT primary key auto_increment,
    Nombres VARCHAR (100) NULL,
    Apellidos VARCHAR (100) NULL,
    Mensaje VARCHAR (100) NULL,
    Foto longblob not null,
    Activo bit(1) default null,
    FechaRegistro date NULL,
    IdUsuario INT NOT NULL,
    IdEleccion INT NOT NULL,
    foreign key (IdUsuario) references Usuarios(IdUsuario),
	foreign key (IdEleccion) references Elecciones(IdEleccion)
);

CREATE TABLE Votantes (
    IdVotante INT primary key auto_increment,
    DocumentoIdentidad VARCHAR (50)  NULL,
    Nombres VARCHAR (100) NULL,
    Apellidos VARCHAR (100) NULL,
    Activo bit(1) default null,
    FechaRegistro DATETIME NULL,
    EmitioVotacion bit(1) default null,
    IdEleccion INT NULL,
    IdUsuario INT NULL,
    foreign key (IdEleccion) references Elecciones(IdEleccion),	
    foreign key (IdUsuario) references Usuarios(IdUsuario)
);

CREATE TABLE Votaciones (
    IdVotacion INT primary key auto_increment,
    FechaRegistro date NULL,
    IdEleccion INT NULL,
    IdVotante INT NULL,
    IdCandidato INT NULL,   
	foreign key (IdEleccion) references Elecciones(IdEleccion),
    foreign key (IdVotante) references Votantes(IdVotante),
	foreign key (IdCandidato) references Candidatos(IdCandidato)
);

CREATE TABLE RESULTADOS_CANDIDATOS (
	IdResultado_Candidatos int primary key auto_increment,
	IdCandidato int null,
	Porcentaje_votos int null,
	IdEleccion INT NULL,
	FechaRegistro DATETIME NULL,
	foreign key (IdEleccion) references Elecciones(IdEleccion),
	foreign key (IdCandidato) references Candidatos(IdCandidato)
);
/*PAra la vista, 
	- una lista con las elecciones minimizada con votones de mostrar resultados
    - una lista con los candidatos minimizada, y al lado los 3 primeros puestos con % de votos
    */

/*Procedimientos almacenados Usuarios*/

DELIMITER $$
CREATE PROCEDURE `sp_Login`
(
	IN pLoginName VARCHAR (100),
	iN pPassword VARCHAR (100)
)
BEGIN
	select *
    from Usuarios 
    where LoginName=pLoginName and Password=pPassword;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `spListarUsuarios`
(
	IN cTexto VARCHAR(225)
)
BEGIN
	SELECT *
	from usuarios u                
	WHERE   u.nombres LIKE CONCAT('%', cTexto , '%');
	END $$
DELIMITER ;

call listarUsuarios ("");

DELIMITER $$
CREATE PROCEDURE `spCrearUsuario`
(
	IN pDocumentoIdentidad varchar(50),
    IN pNombres varchar(100),
	IN pApellidos varchar(100),
    IN pCorreo varchar(100), 
    IN pLoginName varchar(100),
    IN pPassword varchar(100), 
    IN pActivo bit(1),
    IN pRol varchar(50),   
    IN pFoto longblob
)
BEGIN
    insert into usuarios
    (DocumentoIdentidad, Nombres, Apellidos, Correo, LoginName, Password, Activo,Rol,Foto)
    Values (pDocumentoIdentidad, pNombres, pApellidos, pCorreo, pLoginName, pPassword, pActivo,pRol,pFoto);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `spActualizarUsuario`
(
	IN pIdUsuario int,
	IN pDocumentoIdentidad varchar(50),
    IN pNombres varchar(100),
	IN pApellidos varchar(100),
    IN pCorreo varchar(100), 
    IN pLoginName varchar(100),
    IN pPassword varchar(100), 
    IN pActivo bit(1),
    IN pRol varchar(50),   
    IN pFoto longblob
)
BEGIN
    update usuarios set 
    DocumentoIdentidad=pDocumentoIdentidad,
    Nombres=pNombres,
    Apellidos=pApellidos,
    Correo=pCorreo,
    LoginName=pLoginName,
    Password=pPassword,
    Activo = pActivo,
    Rol=pRol,
    foto=pFoto
    where IdUsuario = pIdUsuario;
END $$
DELIMITER ;

Select * from usuarios;

DELIMITER $$
CREATE PROCEDURE `spEliminarUsuario`
(
    IN pIdUsuario int
)
BEGIN
    delete from usuarios 
    where IdUsuario=pIdUsuario; 
END $$
DELIMITER ;

call eliminarUsuario (7);
Select * from usuarios;

DELIMITER $$
CREATE PROCEDURE `spObtenerUsuario`
(
    IN pIdUsuario int
)
BEGIN
    Select * from usuarios
    where IdUsuario=pIdUsuario; 
END $$
DELIMITER ;

select * from usuarios


/*Procedimientos almacenados Elecciones */
DELIMITER $$
CREATE PROCEDURE `spListarElecciones`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	e.IdEleccion, e.Descripcion, e.Cargo, e.Activo, e.FechaRegistro, e.FechaVotacion,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, e.Foto, e.IdUsuario
	from elecciones e                
    Inner join usuarios u on e.IdUsuario=u.IdUsuario
WHERE   e.Cargo LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;
select * from elecciones;
call listarElecciones ("");

DELIMITER $$
CREATE PROCEDURE `spListarEleccionesOpcion`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	e.IdEleccion, e.Descripcion, e.Cargo, e.Activo, e.FechaRegistro, e.FechaVotacion,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, e.Foto, e.IdUsuario,"Mostrar" as op
	from elecciones e                
    Inner join usuarios u on e.IdUsuario=u.IdUsuario
WHERE   e.Cargo LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;
select * from elecciones;
call listarEleccionesOpcion ("");

DELIMITER $$
CREATE PROCEDURE `spCrearEleccion`
(
	IN pDescripcion varchar(100),
    IN pCargo varchar(100),	
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pFechaVotacion date,
    IN pIdUsuario int,   
    IN pFoto longblob
)
BEGIN
    insert into elecciones
    (Descripcion, Cargo, Activo, FechaRegistro, FechaVotacion, IdUsuario, Foto)
    Values (pDescripcion, pCargo, pActivo, pFechaRegistro, pFechaVotacion, pIdUsuario, pFoto);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `spActualizarEleccion`
(
	IN pIdEleccion int,
	IN pDescripcion varchar(100),
    IN pCargo varchar(100),	
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pFechaVotacion date,
    IN pIdUsuario int,   
    IN pFoto longblob
)
BEGIN
    update elecciones set     
    Descripcion=pDescripcion,
    Cargo=pCargo,
    Activo=pActivo,
    FechaRegistro=pFechaRegistro,
    FechaVotacion=pFechaVotacion,
    IdUsuario = pIdUsuario,    
    foto=pFoto
    where IdEleccion = pIdEleccion;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spEliminarEleccion`
(
    IN pIdEleccion int
)
BEGIN
    delete from elecciones 
    where IdEleccion=pIdEleccion; 
END $$
DELIMITER ; 

DELIMITER $$
CREATE PROCEDURE `spObtenerEleccion`
(
    IN pIdEleccion int
)
BEGIN
    Select * from elecciones
    where IdEleccion=pIdEleccion; 
END $$
DELIMITER ;

/*Procedimientos Almacenados para  Candidato */
DELIMITER $$
CREATE PROCEDURE `spListarCandidatos`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	c.IdCandidato, c.Nombres, c.Apellidos, c.Mensaje, c.Activo, c.FechaRegistro,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, c.Foto,c.IdUsuario, c.IdEleccion
	from candidatos c                
    Inner join usuarios u on c.IdUsuario=u.IdUsuario
WHERE   c.Nombres LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spListarCandidatosPorEleccion`
(
    IN pIdEleccion INT
)
BEGIN
    SELECT 	c.IdCandidato, c.Nombres, c.Apellidos, c.Mensaje, c.Activo, c.FechaRegistro,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, c.Foto,c.IdUsuario, c.IdEleccion
	from candidatos c                
    Inner join usuarios u on c.IdUsuario=u.IdUsuario
WHERE   c.IdEleccion=pIdEleccion;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spListarCandidatosPorEleccionParaVotante`
(
    IN pIdEleccion INT
)
BEGIN
    SELECT 	c.IdCandidato, c.Nombres, c.Apellidos, c.Mensaje, c.Foto,"Elegir" as op, c.IdUsuario, c.IdEleccion
	from candidatos c                
    Inner join usuarios u on c.IdUsuario=u.IdUsuario
WHERE   c.IdEleccion=pIdEleccion;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spCrearCandidato`
(
	IN pNombres varchar(100),
    IN pApellidos VARCHAR (100),
    IN pMensaje VARCHAR (100),
    IN pFoto longblob,
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pIdUsuario INT,
    IN pIdEleccion INT
)
BEGIN
    insert into candidatos
    (Nombres, Apellidos, Mensaje, Foto, Activo, FechaRegistro, IdUsuario,IdEleccion)
    Values (pNombres, pApellidos, pMensaje, pFoto, pActivo, pFechaRegistro, pIdUsuario,pIdEleccion);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spActualizarCandidato`
(
	IN pIdCandidato int,
	IN pNombres varchar(100),
    IN pApellidos VARCHAR (100),
    IN pMensaje VARCHAR (100),
    IN pFoto longblob,
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pIdUsuario INT,
    IN pIdEleccion INT
)
BEGIN
    update candidatos set     
    Nombres=pNombres,
    Apellidos=pApellidos,
    Mensaje=pMensaje,
    Foto=pFoto,
    Activo=pActivo,
    FechaRegistro=pFechaRegistro,
    IdUsuario = pIdUsuario,    
    IdEleccion=pIdEleccion
    where IdCandidato = pIdCandidato;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spEliminarCandidato`
(
    IN pIdCandidato int
)
BEGIN
    delete from candidatos 
    where IdCandidato=pIdCandidato; 
END $$
DELIMITER ; 

DELIMITER $$
CREATE PROCEDURE `spObtenerCandidato`
(
    IN pIdCandidato int
)
BEGIN
    Select * from candidatos
    where IdCandidato=pIdCandidato; 
END $$
DELIMITER ;

/*-------------------------------------------------------*/

/*Procedimientos almacenados para Votante */
DELIMITER $$
CREATE PROCEDURE `sp_LoginVotante`
(
	IN pDocumentoIdentidad VARCHAR (50)
)
BEGIN
	select *
    from votantes 
    where DocumentoIdentidad=pDocumentoIdentidad;
END $$
DELIMITER ;
-- call sp_LoginVotante(23480173864);

DELIMITER $$
CREATE PROCEDURE `spListarVotantes`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	v.IdVotante, v.DocumentoIdentidad, v.Nombres, v.Apellidos, v.Activo, v.FechaRegistro,v.EmitioVotacion,
			e.Cargo as CargoDeEleccion, CONCAT(u.Nombres," ",u.Apellidos) as NombreUsuario, v.IdEleccion, v.IdUsuario 
	from votantes v                
    Inner join elecciones e on v.IdEleccion = e.IdEleccion
    Inner Join usuarios u on v.IdUsuario = u.IdUsuario
WHERE   v.Nombres LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;
-- select * from votantes;
-- call listarVotantes ("");

DELIMITER $$
CREATE PROCEDURE `spListarVotantesPorEleccion`
(
    IN pIdEleccion INT
)
BEGIN
    SELECT 	v.IdVotante, v.DocumentoIdentidad, v.Nombres, v.Apellidos, v.Activo, v.FechaRegistro,v.EmitioVotacion,
			e.Cargo as CargoDeEleccion, CONCAT(u.Nombres," ",u.Apellidos) as NombreUsuario, v.IdEleccion, v.IdUsuario 
	from votantes v    
    Inner join elecciones e on v.IdEleccion = e.IdEleccion
    Inner join usuarios u on v.IdUsuario=u.IdUsuario
WHERE   v.IdEleccion=pIdEleccion;
END $$
DELIMITER ;

-- call listarVotantesPorEleccion(1);

DELIMITER $$
CREATE PROCEDURE `spCrearVotante`
(
	IN pDocumentoIdentidad varchar(50),
	IN pNombres varchar(100),
    IN pApellidos VARCHAR (100),
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pEmitioVotacion bit(1),
    IN pIdEleccion INT,
    IN pIdUsuario INT    
)
BEGIN
    insert into votantes
    (DocumentoIdentidad, Nombres, Apellidos, Activo, FechaRegistro, EmitioVotacion,IdEleccion, IdUsuario)
    Values (pDocumentoIdentidad, pNombres, pApellidos, pActivo, pFechaRegistro, pEmitioVotacion,pIdEleccion, pIdUsuario);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spCrearVotanteDesdeLista`
(
	IN pDocumentoIdentidad varchar(50),
	IN pNombres varchar(100),
    IN pApellidos VARCHAR (100),
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pEmitioVotacion bit(1),
    IN pIdEleccion INT,
    IN pIdUsuario INT      
)
BEGIN
    insert into votantes
    (DocumentoIdentidad, Nombres, Apellidos,Activo,FechaRegistro,EmitioVotacion,IdEleccion,IdUsuario)
    Values (pDocumentoIdentidad, pNombres, pApellidos,pActivo,pFechaRegistro,pEmitioVotacion,pIdEleccion,pIdUsuario);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spActualizarVotante`
(
	IN pIdVotante int,
	IN pDocumentoIdentidad varchar(50),
	IN pNombres varchar(100),
    IN pApellidos VARCHAR (100),
    IN pActivo bit(1),
    IN pFechaRegistro date,
    IN pEmitioVotacion bit(1),
    IN pIdEleccion INT,
    IN pIdUsuario INT 
)
BEGIN
    update votantes set     
    DocumentoIdentidad=pDocumentoIdentidad,
    Nombres=pNombres,
    Apellidos=pApellidos,    
    Activo=pActivo,
    FechaRegistro=pFechaRegistro,
    EmitioVotacion=pEmitioVotacion,
    IdEleccion=pIdEleccion,
    IdUsuario = pIdUsuario    
    where IdVotante = pIdVotante;
END $$
DELIMITER ;

-- Select * from elecciones;

DELIMITER $$
CREATE PROCEDURE `spEliminarVotante`
(
    IN pIdVotante int
)
BEGIN
    delete from votantes 
    where IdVotante=pIdVotante; 
END $$
DELIMITER ; 

-- call eliminarUsuario (7);
-- Select * from usuarios;

DELIMITER $$
CREATE PROCEDURE `spObtenerVotante`
(
    IN pIdVotante int
)
BEGIN
    Select * from votantes
    where IdVotante=pIdVotante; 
END $$
DELIMITER ;

--  Procedimientos Almacenados para Votaciones --
DELIMITER $$
CREATE PROCEDURE `spListarVotaciones`
(
	IN cTexto VARCHAR(225)
)
BEGIN
	SELECT v.IdVotacion, v.FechaRegistro, e.Descripcion, concat(c.Nombres,' ', c.Apellidos) as Candidato
	from votaciones v
    Inner join elecciones e on v.IdEleccion = e.IdEleccion
    Inner join candidatos c on v.IdEleccion = c.IdCandidato
	WHERE   e.Descripcion LIKE CONCAT('%', cTexto , '%');
	END $$
DELIMITER ;

-- call listarVotaciones("");
-- select * from votaciones
DELIMITER $$
CREATE PROCEDURE `spCrearVotacion`
(
	IN pFechaRegistro date,
    IN pIdEleccion INT,
	IN pIdVotante INT,
    IN pIdCandidato INT
)
BEGIN
    insert into votaciones
    (FechaRegistro, IdEleccion, IdVotante, IdCandidato)
    Values (pFechaRegistro, pIdEleccion, pIdVotante, pIdCandidato);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `spActualizarVotacion`
(
	IN pIdVotacion INT,
	IN pFechaRegistro date,
    IN pIdEleccion INT,
	IN pIdVotante INT,
    IN pIdCandidato INT
)
BEGIN
    update votaciones set     
    FechaRegistro=pFechaRegistro,
    IdEleccion=pIdEleccion,
    IdVotante=pIdVotante,
    IdCandidato=pIdCandidato
    where IdVotacion = pIdVotacion;
END $$
DELIMITER ;

-- Select * from usuarios;

DELIMITER $$
CREATE PROCEDURE `spEliminarVotacion`
(
    IN pIdVotacion int
)
BEGIN
    delete from votaciones 
    where IdVotacion=pIdVotacion; 
END $$
DELIMITER ;

-- call eliminarVotacion (5);
-- Select * from votaciones;

DELIMITER $$
CREATE PROCEDURE `spObtenerVotacion`
(
    IN pIdVotacion int
)
BEGIN
    Select * from votaciones
    where IdVotacion=pIdVotacion; 
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `spActualizarVotanteEmitioVotacion`
(
	IN pIdVotante INT,
	IN pEmitioVotacion bool
)
BEGIN
    update votantes set     
    EmitioVotacion=pEmitioVotacion
    where IdVotante = pIdVotante;
END $$
DELIMITER ;

-- Resultados

/*Para la vista, 
	- una lista con las elecciones minimizada con votones de mostrar resultados
    - una lista con los candidatos minimizada, y al lado los 3 primeros puestos con % de votos
    */
DELIMITER $$
CREATE PROCEDURE `spListarResultados_Candidatos`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	r.IdResultado_Candidatos, r.FechaRegistro,
    e.IdEleccion, e.Descripcion, e.Cargo, e.Activo, e.FechaRegistro, e.FechaVotacion,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, e.Foto, e.IdUsuario
	from resultados_candidatos r 
    Inner join elecciones e on r.IdEleccion = e.IdEleccion
    Inner join candidatos c on r.IdCandidato =c.IdCandidato    
WHERE   e.Descripcion LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;
-- select * from elecciones;
-- call listarElecciones ("");

DELIMITER $$
CREATE PROCEDURE `spListarEleccionesOpcion`
(
    IN cTexto VARCHAR(225)
)
BEGIN
    SELECT 	e.IdEleccion, e.Descripcion, e.Cargo, e.Activo, e.FechaRegistro, e.FechaVotacion,
			concat(u.nombres," ",u.apellidos) as NombreUsuario, e.Foto, e.IdUsuario,"Mostrar" as op
	from elecciones e                
    Inner join usuarios u on e.IdUsuario=u.IdUsuario
WHERE   e.Cargo LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;
-- select * from elecciones;






















