--1.Lista los nombres de los productos ordenados en primer lugar 
--por el nombre de forma ascendente y en segundo lugar por el precio
--de forma descendente.

SELECT nombre, precio from producto
ORDER BY nombre ASC, precio DESC;

--2.Lista todos los productos que tengan un precio entre 60€ y 200€

SELECT * FROM PRODUCTO
WHERE PRECIO BETWEEN 60 AND 200;

--3.Lista los nombres de los fabricantes cuyo nombre sea de 4 caracteres.

SELECT Nombre from fabricante
WHERE NOMBRE LIKE '____';

--4.Devuelve una lista con el nombre del producto, precio y nombre de fabricante 
--de todos los productos de la base de datos.

SELECT p.nombre, p.precio, f.nombre
from producto p
inner join fabricante f on p.codigo_fabricante=f.codigo;

--5.Devuelve un listado con todos los productos de los fabricantes Asus,
--Hewlett-Packard y Seagate
SELECT producto.nombre, fabricante.nombre FROM producto
inner join fabricante on fabricante.codigo = producto.codigo_fabricante
WHERE fabricante.nombre IN ('Asus', 'Hewlett-Packard', 'Seagate');

--6. Lista los nombres de los fabricantes ordenados de forma ascendente

SELECT Nombre from fabricante order by nombre asc;

--7. Calcula el número total de productos que hay en la tabla productos.

select count (codigo) as total_productos
from producto;

--8. Devuelve un listado con los nombres de los fabricantes donde la suma del precio
--de todos sus productos es superior a 1000 €.

SELECT f.Nombre, SUM(p.precio) AS SUMA from fabricante f
inner join producto p on f.codigo = p.codigo_fabricante
group by f.Nombre
having SUM(p.precio) > 1000;

--9. Devuelve un listado donde sólo aparezcan aquellos fabricantes que no tienen
--ningún producto asociado.

SELECT f.Nombre from fabricante f
left join producto p on f.codigo = p.codigo_fabricante
where p.codigo_fabricante is null;

--10. Devuelve un listado con los nombres de los fabricantes y el número de productos
--que tiene cada uno con un precio superior o igual a 220 €.
--El listado debe mostrar el nombre de todos los fabricantes, es decir, si hay algún
--fabricante que no tiene productos con un precio superior o igual a 220€ deberá aparecer
--en el listado con un valor igual a 0 en el número de productos.

SELECT distinct f.Nombre, COUNT(p.codigo) as num_productos
from fabricante f
inner join producto p on f.codigo = p.codigo_fabricante
where p.codigo IN (select codigo from producto where precio >= 220)
group by f.nombre;

