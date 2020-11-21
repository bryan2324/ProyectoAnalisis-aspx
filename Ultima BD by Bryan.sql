create database BD_SIRESEP;
use BD_SIRESEP;


Create Table Rol(        -----------------Listo
idRol int identity(1,1) primary key,
nombreRol varchar(20),
idEstado int ,
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)

create table rol_bitacora(-----------------------------------------------Crear Trigger
idRolBitacora int identity (1,1)primary key ,
idRol int foreign key (idRol) references Rol(idRol),
nombreRol varchar(20),
idEstado int ,
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)


Create table Usuario( --------------------------------Listo
idUsuario int identity(1,1) primary key,
correoElectronico varchar(50),
cedula varchar(30),
contrasena varchar(100),
salt varchar(100),
fechaRegistro datetime,
idRol int foreign key(idRol) references Rol (idRol),
)

select *from usuario;

create table Rol_Usuario( -------------------------Listo
idRolUsuario int identity(1,1) primary key,
idUsuario int foreign key (idUsuario) references Usuario(idUsuario),
idRol int foreign key(idRol) references Rol(idRol),
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)

Create table Rol_Usuario_bitacora(   ----------------------------------------------Crear trigger
idRolUsuarioBitacora int identity (1,1),
idRolUsuario int foreign key (idRolUsuario) references Rol_Usuario (idRolUsuario),
idUsuario int,
idRol int ,
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)

create table InfoLaboral(				--------------Listo
idInfoLaboral int identity (1,1) primary key,
profesion varchar(25),
tiempoExperiencia int,
)

create table InfoGradoEstudio( ------------------LISTO
idGradoEstudio int identity (1,1) primary key,
descripcion varchar(200)
)

Create table InfoInstitucion(	------------------LISTO
idInstitucion int identity(1,1) primary key,
nombreInstitucion varchar(30),
ano date
)

Create table Carrera(    ----------------------------LISTO
idCarrera int identity(1,1) primary key,
carrera varchar(15)
)



create table InfoEstudios(-------------------------------------LISTO
idEstudios int identity (1,1) primary key,
idGradoEstudio int foreign key (idGradoEstudio) References InfoGradoEstudio(idGradoEstudio),
idInstitucion int foreign key (idInstitucion) References InfoInstitucion(idInstitucion),
idCarrera int foreign key (idCarrera) References Carrera(idCarrera)
)

create table InfoNacionalidad(					--------------LISTO
idNacionalidad int identity(1,1) primary key,
nacionalidad varchar(20),
)


create table InfoGenero(  ------------------LISTO
idGenero int identity (1,1) primary key,
genero varchar(12)
)

Create table InfoIdioma(------------------LISTO
idIdioma int identity(1,1) primary key,
idioma varchar(20),
 
)

create table InfoLicenciaConducir( -------------Listo
idLicenciaConducir int identity(1,1) primary key,
licencia varchar(8)
)

Create table InfoHabilidad(  ------------------Listo
idHabilidad int identity(1,1) primary key,
habilidad varchar(20)
)

create table InfoAdicional(   ----------------------Listo
idInfoAdicional int identity(1,1) primary key,
idIdioma int foreign key (idIdioma) references InfoIdioma(idIdioma),
nivelIdioma varchar(12),
idLicenciaConducir int foreign key (idLicenciaConducir) references InfoLicenciaConducir(idLicenciaConducir)
)

create table Certificaciones(  -------------------Listo
idCertificacion int identity(1,1) primary key,
nombre varchar(100),
ano date
)


create table PerfilPersona(					-------------------LISTO
idPerfilProfesional int identity (1,1) primary key,
idUsuario int foreign key (idUsuario) references Usuario(idUsuario),-------ASOACIE A LOS USUARIOS AQUI!, CADA USUARIO TIENE UN PERFIL UNICO!
nombre varchar(15),
apellidos varchar(30),
fechaNacimiento date,
telefono int,
direccion varchar(100),
idNacionalidad int foreign key (idNacionalidad) references InfoNacionalidad(idNacionalidad),
idGenero int foreign key (idGenero) references InfoGenero(idGenero),
idEstado int,
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
FechaModifica date
)

Create table perfilPersona_bitacora( -----------------------------------------------Crear trigger
idPerfilProfesionalBitacora int identity (1,1) primary key,
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional),
idUsuario int,
nombre varchar(15),
apellidos varchar(30),
fechaNacimiento date,
telefono int,
direccion varchar(100),
idNacionalidad int,
idGenero int ,
idEstado int,
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
FechaModifica date
)


Create table InfoPuesto(
idPuesto int identity (1,1) primary key,
puesto varchar(20)
)

create table InfoRequisitos(
idInfoRequisitos int identity (1,1) primary key,
idIdioma int foreign key (idIdioma) references InfoIdioma(idIdioma),
idGradoEstudio int foreign key (idGradoEstudio) references InfoGradoEstudio(idGradoEstudio),
idHabilidad int foreign key (idHabilidad) references InfoHabilidad(idHabilidad),
idCarrera int foreign key (idCarrera) references Carrera(idCarrera)
)


create table PerfilDelConcurso(
idConcurso int identity(1,1) primary key,
idPuesto int foreign key (idPuesto) references InfoPuesto(idPuesto),
idInfoRequisitos int foreign key (idInfoRequisitos) references InfoRequisitos(idInfoRequisitos),
idEstado int,
codConcurso varchar(50),
fechaInicio date,
fechaCierre date,
descripcionConcurso varchar(150),
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)

create table perfilDelConcurso_bitacora(
idConcursoBitacora int identity(1,1) primary key,
idConcurso int foreign key (idConcurso) references PerfilDelConcurso(idConcurso),
idPuesto int ,
idInfoRequisitos int ,
idEstado int,
codConcurso varchar(50),
fechaInicio date,
fechaCierre date,
descripcionConcurso varchar(150),
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
) 

create table aplicaciones( -----------------------------Tabla nueva!!!
idAplicacion int identity(1,1) primary key,
idConcurso int foreign key (idConcurso) references PerfilDelConcurso(idConcurso),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional)
)

create table perfilProfesional_PerfilConcurso(
idMatch int identity(1,1) primary key,
idConcurso int foreign key (idConcurso) references PerfilDelConcurso(idConcurso),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional),
porcentajeMatch decimal,    ---------------------------Atributo Nuevo
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)


create table perfilProfesional_PerfilConcurso_bitacora(
idMatchBitacora int identity(1,1) primary key,
idMatch int foreign key (idMatch) references perfilProfesional_PerfilConcurso(idMatch),
idConcurso int ,
idPerfilProfesional int ,
porcentajeMatch decimal,    ---------------------------Atributo Nuevo
usuarioCrea varchar(30),
fechaCreacion date,
usuarioModifica varchar(30),
fechaModifica date
)




create table certificaciones_perfilProfesional(    -----------Listo
idCertificacionProfesional int primary key identity(1,1),
idCertificacion int foreign key(idCertificacion) references Certificaciones(idCertificacion),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional)
)

create table infoEstudios_perfilProfesional(-------------Listo
idEstudiosProfesional int primary key identity(1,1),
idEstudios int foreign key (idEstudios) references infoEstudios(idEstudios),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional)
)

create table habilidades_perfilProfesional( --------------Listo
idHabilidadProfesional int primary key identity(1,1),
idHabilidad int foreign key (idHabilidad) references InfoHabilidad(idHabilidad),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional)
)


Create table infoAdicional_perfilProfesional(
idInfoAdicionalProfesional int identity(1,1) primary key,
idInfoAdicional int foreign key (idInfoAdicional) references infoAdicional (idInfoAdicional),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional)
)


create table infoLaboral_perfilProfesional(
idInfoLaboralProfesional int primary key identity(1,1),
idInfoLaboral int foreign key (idInfoLaboral) references infoLaboral(idInfoLaboral),
idPerfilProfesional int foreign key (idPerfilProfesional) references PerfilPersona (idPerfilProfesional))	



create table requisitos_perfilConcurso(
requisitosConcurso int identity(1,1) primary key,
idInfoRequisitos int foreign key (idInfoRequisitos) references InfoRequisitos (idInfoRequisitos),
idConcurso int foreign key (idConcurso) references PerfilDelConcurso(idConcurso)
)


--- Insert's Iniciales------------------------------------------------------------------------------------------------

Insert into Rol(nombreRol,idEstado,usuarioCrea,fechaCreacion,usuarioModifica,fechaModifica) values('Administrador',1,'Admin',GETDATE(),'Admin',GETDATE());
Insert into Rol(nombreRol,idEstado,usuarioCrea,fechaCreacion,usuarioModifica,fechaModifica) values('Usuario Normal',1,'Admin',GETDATE(),'Admin',GETDATE());



GO
USE [BD_SIRESEP]
GO


CREATE PROCEDURE [insertarUsuarios] 
@correoElectronico varchar(30),
@cedula varchar(30),
@contrasena varchar(100),
@salt varchar(100),
@idRol int


AS
BEGIN
	
INSERT INTO Usuario(correoElectronico,cedula,contrasena,salt,fechaRegistro,idRol)
values(@correoElectronico,@cedula,@contrasena,@salt,GETDATE(),@idRol);


END

GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

------ActualizarContra-- Procedimiento #2-------------------------------------
CREATE PROCEDURE [ActualizarContra] 
	
	--@idUsuario int,
	@contrasena varchar(100),
	@salt varchar(100),
	@cedula varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Usuario 
	set contrasena = @contrasena, salt = @salt
	where cedula = @cedula
END
GO


---------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [ActualizarRol] 
	
	--@idUsuario int,
	@idUsuario int,
	@idRol int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Usuario set idRol=@idRol where idUsuario=@idUsuario;


	--set contrasena = @contrasena, salt = @salt
	--where cedula = @cedula
END
GO




-------Mostrar Usuarios---Procedimiento 3------------------

CREATE PROCEDURE [MostrarUsuario]

AS
BEGIN


    select * from [dbo].[Usuario]
	
END

GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






------------Trigger----------Tabla Intermedia--------------
CREATE TRIGGER tr1 ON Usuario
AFTER Insert
AS
	declare @PidUsuario int;
	declare @PidRol int;

	

	select @PidUsuario=i.idUsuario from inserted i;	
	select @PidRol=i.idRol from inserted i;

	

	insert into Rol_Usuario
(idRol,idUsuario,usuarioCrea,usuarioModifica,fechaCreacion,fechaModifica) 
	values(@PidRol,@PidUsuario,CURRENT_USER,CURRENT_USER,getdate(),GETDATE());

	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-------------------------------------






-----------------------------------------------------------
--Con este Trigger Llena todas las tablas intermedias que son del tipo: "xxxxxx_perfilProfesional" 
CREATE TRIGGER tr2 ON PerfilPersona
AFTER Insert
AS
	Declare @PidUsuario int;
	Declare @PidCertificacion int;
	Declare @PidEstudios int;
	Declare @PidHabilidades int;
	Declare @PidInfoAdicional int;
	Declare @PidInfoLaboral int;
	



	select @PidUsuario=i.idPerfilProfesional from inserted i;	
	select @PidCertificacion= (Select MAX(idCertificacion) from Certificaciones);	
	select @PidEstudios= (Select MAX(idEstudios) from InfoEstudios);	
	select @PidHabilidades= (Select MAX(idHabilidad) from InfoHabilidad);	
	select @PidInfoAdicional= (Select MAX(idInfoAdicional) from InfoAdicional);	
	select @PidInfoLaboral= (Select MAX(idInfoLaboral) from InfoLaboral);	
	

	insert into certificaciones_perfilProfesional (idCertificacion,idPerfilProfesional) values(@PidCertificacion,@PidUsuario);
	insert into infoEstudios_perfilProfesional(idEstudios,idPerfilProfesional) values(@PidEstudios,@PidUsuario);
	insert into habilidades_perfilProfesional(idHabilidad,idPerfilProfesional) values(@PidHabilidades,@PidUsuario);
	insert into infoAdicional_perfilProfesional(idInfoAdicional,idPerfilProfesional) values(@PidInfoAdicional,@PidUsuario);
	insert into infoLaboral_perfilProfesional (idInfoLaboral,idPerfilProfesional) values(@PidInfoLaboral,@PidUsuario);

	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--Con este Trigger se actualizan todas las tablas intermedias que son del tipo: "xxxxxx_perfilProfesional" 
CREATE TRIGGER tr3 ON PerfilPersona
AFTER update
AS
	Declare @PidUsuario int;
	Declare @PidCertificacion int;
	Declare @PidEstudios int;
	Declare @PidHabilidades int;
	Declare @PidInfoAdicional int;
	Declare @PidInfoLaboral int;
	-----------------------------
	declare @certip int;
	---
	select @PidUsuario=i.idPerfilProfesional from inserted i;


	delete certificaciones_perfilProfesional where idPerfilProfesional=@PidUsuario;
	delete infoEstudios_perfilProfesional where idPerfilProfesional=@PidUsuario;
	delete habilidades_perfilProfesional where idPerfilProfesional=@PidUsuario;
	delete infoAdicional_perfilProfesional where idPerfilProfesional=@PidUsuario;
	delete infoLaboral_perfilProfesional where idPerfilProfesional=@PidUsuario;
		
	select @PidCertificacion= (Select MAX(idCertificacion) from Certificaciones);	
	select @PidEstudios= (Select MAX(idEstudios) from InfoEstudios);	
	select @PidHabilidades= (Select MAX(idHabilidad) from InfoHabilidad);	
	select @PidInfoAdicional= (Select MAX(idInfoAdicional) from InfoAdicional);	
	select @PidInfoLaboral= (Select MAX(idInfoLaboral) from InfoLaboral);	
	

	insert into certificaciones_perfilProfesional (idCertificacion,idPerfilProfesional) values(@PidCertificacion,@PidUsuario);
	insert into infoEstudios_perfilProfesional(idEstudios,idPerfilProfesional) values(@PidEstudios,@PidUsuario);
	insert into habilidades_perfilProfesional(idHabilidad,idPerfilProfesional) values(@PidHabilidades,@PidUsuario);
	insert into infoAdicional_perfilProfesional(idInfoAdicional,idPerfilProfesional) values(@PidInfoAdicional,@PidUsuario);
	insert into infoLaboral_perfilProfesional (idInfoLaboral,idPerfilProfesional) values(@PidInfoLaboral,@PidUsuario);

	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





------------------
--Con este Trigger se actualizan todas la tabla intermedia PerfilConcurso" 
CREATE TRIGGER tr6 ON PerfilDelConcurso
AFTER update
AS
	Declare @PidConcurso int;
	declare @idReq int;


	select @PidConcurso=i.idConcurso from inserted i;
	select @idReq=i.idInfoRequisitos from inserted i;

	delete requisitos_perfilConcurso where idConcurso=@PidConcurso;
	
	insert into requisitos_perfilConcurso (idConcurso,idInfoRequisitos)values(@PidConcurso,@idReq);

	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







-----------------------------------------------------------
--Con este Trigger Llena la tabla intermedia de CONCURSOS" 
CREATE TRIGGER tr5 ON PerfilDelConcurso
AFTER Insert 
AS
	Declare @PidConcurso int;
	Declare @PidReq int;




	select @PidConcurso=i.idConcurso from inserted i;	
	select @PidReq= i.idInfoRequisitos from inserted i;	
	
	

	insert into requisitos_perfilConcurso (idConcurso,idInfoRequisitos)values(@PidConcurso,@PidReq);

	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

----------Store Procedure 2-----------------------------------------------------
CREATE PROCEDURE [EliminarPerfil]
@id int
AS
BEGIN

update PerfilPersona set idEstado = 0 where idPerfilProfesional=@id;

/*
Delete from certificaciones_perfilProfesional where idPerfilProfesional=@id;
Delete from infoEstudios_perfilProfesional where idPerfilProfesional=@id;
Delete from habilidades_perfilProfesional where idPerfilProfesional=@id;
Delete from infoAdicional_perfilProfesional where idPerfilProfesional=@id;
Delete from infoLaboral_perfilProfesional where idPerfilProfesional=@id;
Delete from infoLaboral_perfilProfesional where idPerfilProfesional=@id;
delete from aplicaciones where idPerfilProfesional=@id;
delete from perfilProfesional_PerfilConcurso where idPerfilProfesional=@id;
Delete from PerfilPersona where idPerfilProfesional=@id;	
*/
END

GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
----------------Store Procedure 4------------------------


CREATE PROCEDURE [EliminarPerfilDelConcurso]
@id int
AS
BEGIN

UPDATE PerfilDelConcurso SET idEstado = 0 where idConcurso=@id;

/*delete from requisitos_perfilConcurso where idConcurso=@id;
delete from perfilProfesional_PerfilConcurso where idConcurso=@id;
delete from aplicaciones where idConcurso=@id;
Delete from PerfilDelConcurso where idConcurso=@id;	
*/
END
GO
USE [BD_SIRESEP]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--------------------------------------------Select de verficacion(Solo para nosotros y de ayuda)
select *from Usuario;
select*from PerfilPersona;
select* from InfoGradoEstudio;
select* from InfoInstitucion;
select* from Carrera;
select* from InfoEstudios;
select* from InfoNacionalidad;
select * from InfoLaboral;
select *from Certificaciones;
select *from InfoAdicional;
select *from Certificaciones;
select *from aplicaciones;
select *from InfoRequisitos;
select *from PerfilDelConcurso;

select InfoHabilidad.habilidad from InfoHabilidad
inner join habilidades_perfilProfesional on InfoHabilidad.idHabilidad=habilidades_perfilProfesional.idHabilidad where idPerfilProfesional=2;
----------------------------Con estos Select pueden verificar que las tablas intermedias se estan llenando bien. (Solo para nosotros y de ayuda)
Select *from certificaciones_perfilProfesional
Select *from infoEstudios_perfilProfesional
Select *from habilidades_perfilProfesional
Select *from infoAdicional_perfilProfesional
Select *from infoLaboral_perfilProfesional

select *from requisitos_perfilConcurso;
------------------------------------------------------------

select*from perfilProfesional_PerfilConcurso;
select *from requisitos_perfilConcurso;

select * from Usuario; 

insert into InfoNacionalidad Values('EstadoUnidense');
insert into InfoNacionalidad Values('Costarricense');
insert into InfoNacionalidad Values('Colombiano');

insert into InfoGenero values('Masculino');
insert into InfoGenero values ('Femenino');
insert into infoGenero values('Reservado');

insert into InfoInstitucion values('Fidelitas',getdate())
insert into InfoInstitucion values('UCR',getdate())
insert into InfoInstitucion values('TEC',GETDATE())
insert into InfoInstitucion values('ULatina',GETDATE())

Insert into Carrera values('Ing.Sistemas');
Insert into Carrera values('Ing.Civil');
Insert into Carrera values('Ing.Industrial');
Insert into Carrera values('Administrador');

insert into InfoGradoEstudio values('Lic');
insert into InfoGradoEstudio values('Master');
insert into InfoGradoEstudio values('Bachiller');
insert into InfoGradoEstudio values('Tecnico');

insert into InfoIdioma values('Ingles');
insert into InfoIdioma values('Frances');
insert into InfoIdioma values('Aleman');
insert into InfoIdioma values('Portugues');

insert into InfoLicenciaConducir values('B1');
insert into InfoLicenciaConducir values('B2');
insert into InfoLicenciaConducir values('B3');
insert into InfoLicenciaConducir values('D1');
insert into InfoLicenciaConducir values('A1');
insert into InfoLicenciaConducir values('A2');
insert into InfoLicenciaConducir values('A3');

----------------------------------------------------------------------------------------------------------------------------
---triggers de bitacora-----------------------------------------------------------------------------------------------------

CREATE TRIGGER tr1Bitacora ON Rol
after Insert
AS
declare @maxId int;
declare @insertid int;
	
	select @maxId=(select max(idRol) from Rol);
	select @insertid= @maxId-1;

	insert into rol_bitacora SELECT  * FRom Rol where idRol=@insertid;
	
	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-------------------------------------------
CREATE TRIGGER tr2Bitacora ON Rol_Usuario
after Insert
AS

declare @maxId int;
declare @insertid int;
	
	select @maxId=(select max(idRolUsuario) from Rol_Usuario);
	select @insertid= @maxId-1;


	insert into Rol_Usuario_bitacora select * FRom Rol_Usuario where idRolUsuario=@insertid;
	
	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------
CREATE TRIGGER tr3Bitacora ON PerfilPersona
AFTER Insert
AS
declare @maxId int;
declare @insertid int;
	
	select @maxId=(select max(idPerfilProfesional) from PerfilPersona);
	select @insertid= @maxId-1;
	 
	insert into perfilPersona_bitacora select * from PerfilPersona where idPerfilProfesional=@insertid;
	
	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


------------------------------------------------
CREATE TRIGGER tr4Bitacora ON PerfilDelConcurso
AFTER Insert
AS
declare @maxId int;
declare @insertid int;
	
	select @maxId=(select max(idConcurso) from PerfilDelConcurso);
	select @insertid= @maxId-1;
	 
	insert into perfilDelConcurso_bitacora select * from PerfilDelConcurso where idConcurso=@insertid;
	
	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------------------------
CREATE TRIGGER tr5Bitacora ON perfilProfesional_PerfilConcurso
AFTER Insert
AS
declare @maxId int;
declare @insertid int;
	
	select @maxId=(select max(idMatch) from perfilProfesional_PerfilConcurso);
	select @insertid= @maxId-1;
	 
	insert into perfilProfesional_PerfilConcurso_bitacora select * from perfilProfesional_PerfilConcurso where idMatch=@insertid;
	
	


GO
USE [BD_SIRESEP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

