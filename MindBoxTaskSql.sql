SELECT Products.Name, Category.Name
FROM Products 
LEFT OUTER JOIN ProductsCategory ON Products.Id=ProductsCategory.ProductsId 
LEFT OUTER JOIN ON ProductsCategory.CategoryId=Category.Id