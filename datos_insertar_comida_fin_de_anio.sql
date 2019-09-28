select * from Empleados
select * from Lugares
select * from OpcionesComida
select * from Votaciones

-- LUGARES
update Lugares set Imagen = 'assets/images/lugares/asado_argentino.jpg' where IdLugar = 2
update Lugares set Imagen = 'assets/images/lugares/la_casa_de_tono.png' where IdLugar = 3
insert into Lugares (NombreLugar, DireccionLugar, FechaLugar, FechaLugarModificacion, Imagen)
VALUES ('Wingstop', 'En Algún lugar del mundo', GETDATE(), GETDATE(), 'assets/images/lugares/wingstop.jpg');
insert into Lugares (NombreLugar, DireccionLugar, FechaLugar, FechaLugarModificacion, Imagen)
VALUES ('McCarthys', 'En otro lugar del planeta', GETDATE(), GETDATE(), 'assets/images/lugares/mccarthys.jpg');
insert into Lugares (NombreLugar, DireccionLugar, FechaLugar, FechaLugarModificacion, Imagen)
VALUES ('Tacos de pollo', 'Por el Seven de San Fernando', GETDATE(), GETDATE(), 'assets/images/lugares/tacos_de_pollo.png');

-- OPCIONES COMIDA
-- Lugar 2
update OpcionesComida set Imagen = 'assets/images/lugares/opciones_comida/comida13.jpg' where IdOpcion = 1;
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 2', 'Una bonita descripción de nuevo', '123.23', '2', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida14.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 3', 'Una bonita descripción de nuevo', '123.23', '2', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida15.jpg');

-- Lugar 3
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 1', 'Una bonita descripción', '123.23', '3', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida1.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 2', 'Una bonita descripción', '123.23', '3', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida2.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 3', 'Una bonita descripción', '123.23', '3', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida3.jpg');

-- Lugar 4
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 1', 'Una bonita descripción', '123.23', '4', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida4.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 2', 'Una bonita descripción', '123.23', '4', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida5.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 3', 'Una bonita descripción', '123.23', '4', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida6.jpg');

-- Lugar 5
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 1', 'Una bonita descripción', '123.23', '5', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida7.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 2', 'Una bonita descripción', '123.23', '5', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida8.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 3', 'Una bonita descripción', '123.23', '5', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida9.jpg');

-- Lugar 6
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 1', 'Una bonita descripción', '123.23', '6', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida10.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 2', 'Una bonita descripción', '123.23', '6', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida11.jpg');
insert into OpcionesComida (Nombre, Descripcion, Costo, LugarId, FechaOpcion, FechaOpcionModificacion, Imagen)
VALUES ('Comida 3', 'Una bonita descripción', '123.23', '6', GETDATE(), GETDATE(), 'assets/images/lugares/opciones_comida/comida12.jpg');
