create database sharanya;

use sharanya;

create table emp
(
    id int primary key identity,
    name varchar(100),
    salary decimal(9,2),
    pf decimal(9,2),
    netsal decimal(9,2)
);


CREATE procedure sp_SaveEmp
@name VARCHAR(100),
@salary decimal(9,2)

AS

BEGIN
DECLARE @pfamt decimal(9,2);
DECLARE @NetSal decimal(9,2);

SET @pfamt = @salary * 0.10;
SET @NetSal = @salary - @pfamt;


INSERT INTO emp(name, salary, pf, netsal)
VALUES(@name, @salary, @pfamt,@NetSal);

END


create procedure sp_fetchEmpList
as
begin
    select * from emp;
end

select * from emp;
