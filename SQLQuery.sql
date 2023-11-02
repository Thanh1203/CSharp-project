use CSharp_project
go

CREATE PROCEDURE UpdateProduct
    @IdProduct INT,
    @NameProduct NVARCHAR(MAX) = null,
    @KindOfProduct NVARCHAR(MAX) = null,
    @ColorOfProduct NVARCHAR(50) = null
AS
BEGIN
    UPDATE ProductsInfomation
    SET
        NameProduct = CASE WHEN @NameProduct = '' THEN NameProduct ELSE @NameProduct END,
        KindOfProduct = CASE WHEN @KindOfProduct = '' THEN KindOfProduct ELSE @KindOfProduct END,
        ColorOfProduct = CASE WHEN @ColorOfProduct = '' THEN ColorOfProduct ELSE @ColorOfProduct END
    WHERE IdProduct = @IdProduct;
END

DROP PROCEDURE IF EXISTS UpdateProduct;
