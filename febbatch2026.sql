create database febbatch2026;

create table emp
(
    id int primary key identity,
    name varchar(100),
    salary decimal(9,2),
    pf decimal(9,2),
    netsal decimal(9,2)
);



alter proc sp_SaveEmp
    @name varchar(100),
    @salary decimal(9,2)
as
begin
    declare @pfamt decimal(9,2);
    declare @NetSal decimal(9,2);
    set @pfamt= @salary *0.1;
    set @NetSal=@salary-@pfamt;
    insert into emp values (@name ,@salary ,@pfamt ,@NetSal);
end




create proc sp_fetchEmpList
as
begin
    select * from emp;
end

select * from emp;