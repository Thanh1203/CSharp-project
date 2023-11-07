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