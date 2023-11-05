use CSharp_project
go

CREATE PROCEDURE UpdateProduct
    @IdProduct INT,
    @NameProduct NVARCHAR(MAX) = null,
    @KindOfProduct NVARCHAR(MAX) = null,
    @ColorOfProduct NVARCHAR(50) = null,
	@ProductPrice float = 0
AS
BEGIN
    UPDATE ProductsInfomation
    SET
        NameProduct = CASE WHEN @NameProduct = '' THEN NameProduct ELSE @NameProduct END,
        KindOfProduct = CASE WHEN @KindOfProduct = '' THEN KindOfProduct ELSE @KindOfProduct END,
        ColorOfProduct = CASE WHEN @ColorOfProduct = '' THEN ColorOfProduct ELSE @ColorOfProduct END,
		ProductPrice = CASE WHEN @ProductPrice = '' THEN @ProductPrice ELSE @ProductPrice END
    WHERE IdProduct = @IdProduct;
END

DROP PROCEDURE IF EXISTS UpdateProduct;

UPDATE ProductsInfomation
SET VolumeOfProduct = 100
WHERE IdProduct = 1

-- Loại bỏ tính năng "Allow Null" cho cột "ColumnName"
ALTER TABLE ProductsInfomation
add ProductPrice float default 0

select VolumeOfProduct from ProductsInfomation where IdProduct = 1

ALTER TABLE BillInformation
ALTER COLUMN IdBill VARCHAR(255) not null;

ALTER TABLE DataBill
ALTER COLUMN IdBill VARCHAR(255) not null;
