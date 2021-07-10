----------------------------------------------------------CLIENTE
create or replace procedure add_cliente (   
--idclientee cliente.idcliente%type,
nombre cliente.nomcliente%type,
direccion cliente.dircliente%type,
celular cliente.celcliente%type,
usuario cliente.userc%type,
contras cliente.contra%type)  
is  
begin  
insert into cliente (idcliente,nomcliente,dircliente,celcliente,userc,contra) values(DEMO.nextval,nombre,direccion,celular,usuario,contras);
end;

create or replace procedure delete_cliente(idp in number)
is 
    vid number :=idp;
begin
    delete from cliente where idcliente=vid;
end;

create or replace procedure list_cliente(c_cursor out sys_refcursor)
is 
begin
open c_cursor for
select*from cliente;
end;

create or replace procedure update_cliente(idclientee cliente.idcliente%type,
nombre cliente.nomcliente%type,
direccion cliente.dircliente%type,
celular cliente.celcliente%type,
usuario cliente.userc%type,
contras cliente.contra%type)
is
begin
update cliente set nomcliente=nombre,dircliente=direccion,celcliente=celular,userc=usuario,contra=contras where idcliente=idclientee;
commit;
end;
----------------------------------------------------------PRENDA
create or replace procedure add_prenda(   
ide prenda.idprenda%type,
nombre prenda.nomprenda%type,
precio prenda.precioprenda%type,
color prenda.colorprenda%type,
stock prenda.stockprenda%type,
talla prenda.tallaprenda%type,
idtipo prenda.idtipop%type
)  
is  
begin  
insert into prenda (idprenda,nomprenda,precioprenda,colorprenda,stockprenda,tallaprenda,idtipop) values(DEMO.nextval,nombre,precio,color,stock,talla,idtipo);
end;

create or replace procedure delete_prenda(idp in number)
is 
    vid number :=idp;
begin
    delete from prenda where idprenda=vid;
end;

create or replace procedure list_prenda(c_cursor out sys_refcursor)
is
begin
open c_cursor for
select p.idprenda, p.nomprenda, p.precioprenda ,p.colorprenda, p.stockprenda,p.tallaprenda, p.idtipop, t.nomtipop 
from prenda p, tipo_prenda t
where p.idtipop=t.idtipop;
end;

create or replace procedure update_prenda(   
ide prenda.idprenda%type,
nombre prenda.nomprenda%type,
precio prenda.precioprenda%type,
color prenda.colorprenda%type,
stock prenda.stockprenda%type,
talla prenda.tallaprenda%type,
idtipo prenda.idtipop%type
)  
is  
begin  
update prenda set nomprenda=nombre,precioprenda=precio,colorprenda=color,stockprenda=stock,tallaprenda=talla,idtipop=idtipo where idprenda=ide;
commit;
end;

----------------------------------------------------TIPO DE PRENDA

create or replace procedure add_tipo_prenda (   
idee tipo_prenda.idtipop%type,
tipo tipo_prenda.nomtipop%type,
descrip tipo_prenda.desctipop%type)  
is  
begin  
insert into tipo_prenda (idtipop,nomtipop,desctipop) values(DEMO.nextval,tipo,descrip);
end;

create or replace procedure delete_tipo_prenda(idt in number)
is 
    vid number :=idt;
begin
    delete from tipo_prenda where idtipop=vid;
end;

create or replace procedure list_tipo_prenda(c_cursor out sys_refcursor)
is 
begin
open c_cursor for
select*from tipo_prenda;
end;

create or replace procedure update_tipo_prenda(
idee tipo_prenda.idtipop%type,
tipo tipo_prenda.nomtipop%type,
descrip tipo_prenda.desctipop%type)
is
begin
update tipo_prenda set nomtipop=tipo, desctipop=descrip where idtipop=idee;
commit;
end;