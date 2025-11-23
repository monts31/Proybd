create database LosTresBombones;
use LosTresBombones;

create table Empleados (
id_Empleado int primary key auto_increment not null,
nombre varchar(50) not null,
telefono varchar(10) not null, 
rol enum('Administrador','Empleado') not null,
horas int not null,
sueldo decimal(10,4) not null,
fecha_Contrato datetime not null default current_timestamp
);

create table Usuarios (
id_Usuario int primary key auto_increment not null,
usuario varchar(50) not null,
correo varchar(30) unique not null, 
password varchar(40),
id_Empleado int,
foreign key (id_Empleado) references Empleados(id_Empleado)
);

create table Productos(
id_Producto int primary key auto_increment not null,
nombre varchar(20) not null,
descripcion varchar(50) not null,
precio decimal (10,4) not null,
stock int not null,
foto longblob not null
);

create table Ordenes(
id_Orden int primary key auto_increment not null,
id_Usuario int not null,
fecha datetime not null default current_timestamp,
foreign key (id_Usuario) references Usuarios(id_Usuario)
);

create table dOrdenes(
id_Orden int primary key auto_increment not null,
id_Producto int not null,
precio decimal(10,4) not null,
cantidad int not null,
foreign key (id_Producto) references Productos(id_Producto)
);

create table auditorias(
id_Auditorias int primary key auto_increment,
id_Usuario int not null,
tipo_Cambio enum('Insert','Delete','Update')not null,
valor_Anterior decimal(10,4) not null,
valor_Nuevo decimal(10,4) not null,
fecha datetime not null default current_timestamp
);
