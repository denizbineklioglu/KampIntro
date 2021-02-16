--select
select * from Customers;
select ContactName,City,Phone from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID =1 or CategoryID =3
select * from Products where CategoryID=1 and UnitPrice>=10 and
ReorderLevel = 25

select * from Products order by CategoryID,ProductName --sırala
select * from Products where CategoryID=1
order by UnitPrice --desc azalan

select count(*) from Products
--Hangi kategoride kaç farklı ürün var
select CategoryID,count(*) Adet from Products group by CategoryID
--Urun sayisi 10'dan az olan kategoriler
select CategoryID,count(*) Adet from Products where UnitPrice>20 
group by CategoryID having count(*)<10
--JOİN (birleştirmek)
select Products.ProductID,Products.ProductName,Products.UnitPrice,
Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10 

--DTO Data Transformation Object
select * from Products p inner join [Order Details] od
on P.ProductID = od.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null