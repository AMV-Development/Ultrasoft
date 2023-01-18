create procedure sp_buscarProducto @aBuscar varchar(30)
as
begin 
select 
	p.ID_PRODUCTO CODIDO_PRODUCTO, 
	P.NOMBRE_PRODUCTO, P.UNIDADES, 
	M.SIMBOLO METRICA, P.PRECIO_COMPRA, 
	P.PRECIO_VENTA, P.FECHA_REGISTRO, 
	P.FECHA_ACTUALIZACION, 
	P.FECHA_ELIMINACION  
from PRODUCTO as p inner join METRICA as m 
on p.ID_METRICA= m.ID_METRICA
where
	p.ID_PRODUCTO Like '%'+@aBuscar+'%' or 
	p.NOMBRE_PRODUCTO LIKE '%'+@aBuscar+'%'
end
go

create or alter procedure sp_buscarClienteProveedor @aBuscar varchar(50),  @tipoEntidad char(1)
as
begin 
select 
	cP.NOMBRE_COMERCIAL,
	cP.RAZON_SOCIAL, 
	case cP.TIPO_IDENTIFICACION 
		WHEN 'R' then 'RUC'
		WHEN 'C' then 'Cédula'
		When 'P' then 'Pasaporte'
	END as TIPO_IDENTIFICACION,
	cP.IDENTIFICACION,
	cp.DIRECCION,
	cp.TELEFONO, 
	cp.EMAIL
from CLIENTE_PROVEEDOR as cP 
where 
	cP.TIPO_ENTIDAD = @tipoEntidad and
	cP.HABILITADO = 1 and 
	(cP.NOMBRE_COMERCIAL Like '%'+@aBuscar+'%' or 
	cP.RAZON_SOCIAL Like '%'+@aBuscar+'%' or 
	cP.IDENTIFICACION Like '%'+@aBuscar+'%')
end
go






