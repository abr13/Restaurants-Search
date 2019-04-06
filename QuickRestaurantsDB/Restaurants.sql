CREATE TABLE [dbo].[Restaurants]
(
	[RestaurantID] INT NOT NULL IDENTITY , 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [Mobile] NVARCHAR(10) NOT NULL, 
    [Website] NVARCHAR(100) NOT NULL, 
    [Time] NVARCHAR(20) NOT NULL, 
    [Days] NVARCHAR(20) NOT NULL, 
    CONSTRAINT [PK_Restaurants] PRIMARY KEY ([RestaurantID])
)
