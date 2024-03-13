create database dbStoreSystem;
use dbStoreSystem;
create table tblAdmin
(
AdminID nvarchar(50) primary key,
AdminPass nvarchar(50),
AdminFullName nvarchar(50)
)
select * from tblAdmin
create table tblSeller
(
SellerID int identity (1,1) primary key,
SellerName nvarchar(50) unique,
SellerAge int,
SellerPhone nvarchar(10),
SellerPass nvarchar(50)
)
select * from tblSeller

select top 1 SellerName, SellerPass from tblSeller where SellerName='Ravi' and SellerPass=12345 

create table tblCategory
(
CatID int identity(1,1) primary key not null,
CategoryName nvarchar(50),
CategoryDesc nvarchar(50)
)
select * from tblCategory
-----
create table tblCategory
(
CatID int identity (1,1) primary key not null,
CategoryName nvarchar(50),
CategoryDesc nvarchar(50),
)
insert into tblCategory(CategoryName, CategoryDesc) values (@CategoryName, @CategoryDesc)
-------
create procedure spCatInsert
(
@CategoryName nvarchar(50),
@CategoryDesc nvarchar(50)
)
as 
begin
insert into tblCategory (CategoryName, CategoryDesc) values (@CategoryName, @CategoryDesc)
end
---------------------------------------------
insert into tblCategory(CategoryName, CategoryDesc) values ('Veg', 'It is Pure Veg')

select CategoryName from tblCategory where CategoryName='Veg'

select * from tblCategory

select * from   tblSeller

select SellerID, SellerName, SellerPhone, SellerAge from tblSeller

insert into tblSeller(SellerName, SellerPass, SellerPhone, SellerAge) values ('Ramesh', '789', 998855, '25')

select * from tblAdmin

insert into tblAdmin(AdminID, AdminFullName, AdminPass) values ('kumar123','Manish Kumar',12345)

create table tblProduct
(
ProductID int identity(1,1) primary key not null,
ProductName nvarchar(50),
ProductCatID int,
ProductPrice decimal(10,2),
ProductQty int
)


select * from tblProduct

insert into tblProduct(ProductName, ProductCatID, ProductPrice, ProductQty) values ( 'ice-cream', 1, '100.2', 1)
----------
create procedure spInsertProduct
(
@ProdName nvarchar(50),
@ProdCatID int,
@ProdPrice decimal(10,2),
@ProdQty int
)
as
begin
 
Insert into tblProduct(ProductName,ProductCatID,ProductPrice,ProductQty) 
values(@ProdName,@ProdCatID,@ProdPrice,@ProdQty)
end
go
----------------------------------------------------------------
select tblProduct.ProductName ,tblCategory.CategoryName, tblProduct.ProductPrice,tblProduct.ProductQty 
from 
tblProduct  
inner join 
tblCategory on tblProduct.ProductCatID = tblCategory.CatID 
order by tblProduct.ProductName, tblCategory.CategoryName asc
------------------------
UPDATE tblProduct SET 
ProductName = 'Bendi', ProductCatID = 15, ProductPrice = '14.5', ProductQty = 1 WHERE ProductID = 9
--------------------
select tblProduct.ProductID, tblProduct.ProductName ,tblCategory.CategoryName, tblProduct.ProductCatID, tblProduct.ProductPrice,tblProduct.ProductQty from tblProduct  inner join tblCategory on tblProduct.ProductCatID = tblCategory.CatID order by tblProduct.ProductName, tblCategory.CategoryName asc


create procedure spUpdateProduct
(
@ProductID int,
@ProductName nvarchar(50),
@ProductCatID int,
@ProductPrice decimal(10,2),
@ProductQty int
)
as
begin 
update tblProduct set ProductName=@ProductName,ProductCatID=@ProductCatID,ProductPrice=@ProductPrice,ProductQty=@ProductQty where ProductID=@ProductID
end
go


-----------------

create procedure spGetCategory
as
begin
set nocount on;
select CatID,CategoryName from tblCategory order by CategoryName asc
end
go
-----
create procedure spCheckDuplicateProduct
(
@ProdName nvarchar(50),
@ProdCatID int
)
as
begin
set nocount on;
select ProductName from tblProduct 
where ProductName=@ProdName and ProductCatID=@ProdCatID
end
go
-----------------------
create procedure spDeleteProduct
(
@ProdID Int
)
as
begin
 
delete from tblProduct where ProductID=@ProdID
end
go


------------------------------

select * from tblProduct

create procedure spCheckDuplicateProduct1
(
@ProdName nvarchar(50),
@ProdCatID int
)
as
begin
set nocount on;
select ProdName from tblProduct 
where ProdName=@ProdName and ProdCatID=@ProdCatID
end
go
----


----


select * from tblCategory


select * from tblProduct

create procedure spGetAllProductList
as
begin
set nocount on;
select t1.ProdID,t1.ProdName,t2.CategoryName,t1.ProdCatID as CategoryID,t1.ProdPrice,t1.ProdQty from tblProduct as t1
inner join tblCategory as t2 on t1.ProdCatID=t2.CatID
order by t1.ProdName,t2.CategoryName asc
end
go

-------------

select * from tblProduct
-----------------
create procedure spGetAllProductList_SearchByCat
(
@ProdCatID int
)
as
begin
set nocount on;
select t1.ProdID,t1.ProdName,t2.CategoryName,t1.ProdCatID as CategoryID,t1.ProdPrice,t1.ProdQty from tblProduct as t1
inner join tblCategory as t2 on t1.ProdCatID=t2.CatID
where t1.ProdCatID=@ProdCatID
order by t1.ProdName,t2.CategoryName asc
end
go


select * from tblProduct

---------------------------
create table tblBill
(
Bill_ID int primary key,
SellerID nvarchar(50),
SellDate nvarchar(50),
TotalAmt decimal (18,2)
)
----------------------------


create procedure spInsertBill
(
@Bill_ID int,
@SellerID nvarchar(50),
@SellDate nvarchar(50),
@TotalAmt decimal(18,2)
)
as
begin
insert into tblBill (Bill_ID,SellerID,SellDate,TotalAmt) values(@Bill_ID,@SellerID,@SellDate,@TotalAmt)
end
go
----------

insert into tblBill (Bill_ID,SellerID,SellDate,TotalAmt) values(1,'1','2023-06-01','112.2')
-----------
select  *  from tblBill

-----------------
create procedure spGetBillList
as
begin
set nocount on;
select Bill_ID,SellerID,SellDate,TotalAmt from tblBill order by Bill_ID desc 
end
go
