use CSharp_project
go

CREATE PROCEDURE UpdateProduct
    @IdProduct INT,
    @TypeProduct VARCHAR(50) = null,
    @NameProduct NVARCHAR(MAX) = null,
    @ColorProduct NVARCHAR(50) = null,
	@PriceProduct float = 0
AS
BEGIN
    UPDATE ProductInfor
    SET
        NameProduct = CASE WHEN @NameProduct = '' THEN NameProduct ELSE @NameProduct END,
        TypeProduct = CASE WHEN @TypeProduct = '' THEN TypeProduct ELSE @TypeProduct END,
        ColorProduct = CASE WHEN @ColorProduct = '' THEN ColorProduct ELSE @ColorProduct END,
		PriceProduct = CASE WHEN @PriceProduct = '' THEN PriceProduct ELSE @PriceProduct END
    WHERE IdProduct = @IdProduct;
END

DROP PROCEDURE IF EXISTS UpdateProduct;

CREATE PROCEDURE UpdateCustomer
	@CustomerPhoneNumber VARCHAR(50),
    @CustomerName NVARCHAR(MAX) = null,
    @CustomerAddress NVARCHAR(MAX) = null,
    @CustomerPurchases INT = 0
AS
BEGIN
    UPDATE CustomerInformation
    SET
        CustomerName = CASE WHEN @CustomerName = '' THEN CustomerName ELSE @CustomerName END,
        CustomerAddress = CASE WHEN @CustomerAddress = '' THEN CustomerAddress ELSE @CustomerAddress END,
		CustomerPurchases = CASE WHEN @CustomerPurchases = '' THEN CustomerPurchases ELSE @CustomerPurchases END
    WHERE CustomerPhoneNumber = @CustomerPhoneNumber;
END

DROP PROCEDURE IF EXISTS UpdateCustomer;

SELECT TOP 10 D.IdProduct, SUM(D.Weight) AS TotalWeight
FROM BillInformation B
JOIN DataBill D ON B.IdBill = D.IdBill
WHERE MONTH(B.DayOut) = '11' AND YEAR(B.DayOut) = '2023'
GROUP BY D.IdProduct
ORDER BY TotalWeight DESC;

ALTER TABLE ProductsInfomation
ADD TypeProduct varchar(50) Null;

select IdTypeProduct, NameTypeProduct
from ProductInfor, ProductTypeInfor
where IdTypeProduct = TypeProduct and IdProduct = 10

declare @myWeight float set @myWeight = 100

SELECT  TypeProduct, IdProduct, @myWeight as MyWeight,
    @myWeight * PriceProduct AS totalValue
FROM
    ProductInfor
WHERE
    IdProduct = '3'

	WITH TopProducts AS (
    SELECT DB.IdProduct, PIF.IdTypeProduct, SUM(DB.Weight) AS TotalWeight, ROW_NUMBER() OVER (PARTITION BY PIF.IdTypeProduct ORDER BY SUM(DB.Weight) DESC) AS RowNum
    FROM DataBill AS DB INNER JOIN BillInformation AS BI ON DB.IdBill = BI.IdBill INNER JOIN ProductTypeInfor AS PIF ON DB.IdTypeProduct = PIF.IdTypeProduct
    WHERE MONTH(BI.DayOut) = 11 AND YEAR(BI.DayOut) = 2023
    GROUP BY DB.IdProduct, PIF.IdTypeProduct)
SELECT DISTINCT TP.IdTypeProduct, PTI.NameTypeProduct
FROM TopProducts AS TP INNER JOIN ProductTypeInfor AS PTI ON TP.IdTypeProduct = PTI.IdTypeProduct
WHERE TP.RowNum = 1;
