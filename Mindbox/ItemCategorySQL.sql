select Items.Name ItemName, Categories.Name CategoryName
from [dbo].[Items] left join [dbo].[ItemCategory] on [dbo].[Items].Id = [dbo].[ItemCategory].ItemId
     left join [dbo].[Categories] on [dbo].[ItemCategory].CategoryId = [dbo].[Categories].Id;