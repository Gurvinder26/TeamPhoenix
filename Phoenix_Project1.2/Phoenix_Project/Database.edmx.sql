
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2014 04:13:26
-- Generated from EDMX file: C:\Users\Gurvinder\documents\visual studio 2013\Projects\Phoenix_Project\Phoenix_Project\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LocalDB_Project];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InventoryInventoryItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InventoryItems] DROP CONSTRAINT [FK_InventoryInventoryItem];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuMenuItem_Menu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuMenuItem] DROP CONSTRAINT [FK_MenuMenuItem_Menu];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuMenuItem_MenuItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuMenuItem] DROP CONSTRAINT [FK_MenuMenuItem_MenuItem];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuProduct_Menu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuProduct] DROP CONSTRAINT [FK_MenuProduct_Menu];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuProduct_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuProduct] DROP CONSTRAINT [FK_MenuProduct_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderItemOrder_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItemOrder] DROP CONSTRAINT [FK_OrderItemOrder_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderItemOrder_OrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItemOrder] DROP CONSTRAINT [FK_OrderItemOrder_OrderItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductInventory_Inventory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductInventory] DROP CONSTRAINT [FK_ProductInventory_Inventory];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductInventory_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductInventory] DROP CONSTRAINT [FK_ProductInventory_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrder_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrder] DROP CONSTRAINT [FK_ProductOrder_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrder_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrder] DROP CONSTRAINT [FK_ProductOrder_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrder1_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrder1] DROP CONSTRAINT [FK_ProductOrder1_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrder1_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrder1] DROP CONSTRAINT [FK_ProductOrder1_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrderItem_OrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrderItem] DROP CONSTRAINT [FK_ProductOrderItem_OrderItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrderItem_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductOrderItem] DROP CONSTRAINT [FK_ProductOrderItem_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBooking_Booking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserBooking] DROP CONSTRAINT [FK_UserBooking_Booking];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBooking_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserBooking] DROP CONSTRAINT [FK_UserBooking_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserOrder_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserOrder] DROP CONSTRAINT [FK_UserOrder_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_UserOrder_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserOrder] DROP CONSTRAINT [FK_UserOrder_User];
GO
IF OBJECT_ID(N'[dbo].[FK_VendorInventoryItem_InventoryItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendorInventoryItem] DROP CONSTRAINT [FK_VendorInventoryItem_InventoryItem];
GO
IF OBJECT_ID(N'[dbo].[FK_VendorInventoryItem_Vendor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendorInventoryItem] DROP CONSTRAINT [FK_VendorInventoryItem_Vendor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[Galleries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Galleries];
GO
IF OBJECT_ID(N'[dbo].[Inventories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventories];
GO
IF OBJECT_ID(N'[dbo].[InventoryItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InventoryItems];
GO
IF OBJECT_ID(N'[dbo].[MenuItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItems];
GO
IF OBJECT_ID(N'[dbo].[MenuMenuItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuMenuItem];
GO
IF OBJECT_ID(N'[dbo].[MenuProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuProduct];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[OrderItemOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderItemOrder];
GO
IF OBJECT_ID(N'[dbo].[OrderItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderItems];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[ProductInventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductInventory];
GO
IF OBJECT_ID(N'[dbo].[ProductOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductOrder];
GO
IF OBJECT_ID(N'[dbo].[ProductOrder1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductOrder1];
GO
IF OBJECT_ID(N'[dbo].[ProductOrderItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductOrderItem];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[UserBooking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserBooking];
GO
IF OBJECT_ID(N'[dbo].[UserOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserOrder];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[VendorInventoryItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendorInventoryItem];
GO
IF OBJECT_ID(N'[dbo].[Vendors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendors];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bookings'
CREATE TABLE [dbo].[Bookings] (
    [BookingId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [PhoneNo] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Address1] nvarchar(max)  NOT NULL,
    [Address2] nvarchar(max)  NULL,
    [City] nvarchar(max)  NOT NULL,
    [Province] nvarchar(max)  NOT NULL,
    [Postal] nvarchar(max)  NOT NULL,
    [EventType] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [PrefferedDateOFContact1] datetime  NOT NULL,
    [PrefferedDateOFContact2] datetime  NOT NULL
);
GO

-- Creating table 'Galleries'
CREATE TABLE [dbo].[Galleries] (
    [FileId] int IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(max)  NOT NULL,
    [FileDesc] nvarchar(max)  NOT NULL,
    [FileType] nvarchar(max)  NOT NULL,
    [FileLocation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Inventories'
CREATE TABLE [dbo].[Inventories] (
    [InventoryId] int IDENTITY(1,1) NOT NULL,
    [InventoryItem] nvarchar(max)  NOT NULL,
    [InventoryDesc] nvarchar(max)  NOT NULL,
    [InventoryQty] nvarchar(max)  NOT NULL,
    [InventoryPrice] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InventoryItems'
CREATE TABLE [dbo].[InventoryItems] (
    [ItemId] int IDENTITY(1,1) NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [ItemDesc] nvarchar(max)  NOT NULL,
    [ItemQty] nvarchar(max)  NOT NULL,
    [ItemPurchaseDate] datetime  NOT NULL,
    [ItemExpirydate] datetime  NOT NULL,
    [Inventory_InventoryId] int  NOT NULL
);
GO

-- Creating table 'MenuItems'
CREATE TABLE [dbo].[MenuItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [ItemDesc] nvarchar(max)  NOT NULL,
    [ItemQty] nvarchar(max)  NOT NULL,
    [ItemPrice] float  NOT NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MenuProduct] nvarchar(max)  NOT NULL,
    [MenuType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderItems'
CREATE TABLE [dbo].[OrderItems] (
    [OrderItemId] int IDENTITY(1,1) NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [OrderDesc] nvarchar(max)  NOT NULL,
    [OrderQty] int  NOT NULL,
    [TotalPrice] float  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderNo] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [ProductDesc] nvarchar(max)  NOT NULL,
    [ProductQty] float  NOT NULL,
    [TotalPrice] float  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [ProductDesc] nvarchar(max)  NOT NULL,
    [ProductExpiryDate] datetime  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [UserEmail] nvarchar(max)  NOT NULL,
    [UserPhoneNo] nvarchar(max)  NOT NULL,
    [UserAddress1] nvarchar(max)  NOT NULL,
    [UserAddress2] nvarchar(max)  NULL,
    [UserCity] nvarchar(max)  NOT NULL,
    [UserProvince] nvarchar(max)  NOT NULL,
    [UserPostal] nvarchar(max)  NOT NULL,
    [Password] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Vendors'
CREATE TABLE [dbo].[Vendors] (
    [VendorId] int IDENTITY(1,1) NOT NULL,
    [VendorName] nvarchar(max)  NOT NULL,
    [VendorPhoneNo] nvarchar(max)  NOT NULL,
    [VendorEmail] nvarchar(max)  NOT NULL,
    [VendorAddress1] nvarchar(max)  NOT NULL,
    [VendorAddress2] nvarchar(max)  NULL,
    [VendorCity] nvarchar(max)  NOT NULL,
    [VendorProvince] nvarchar(max)  NOT NULL,
    [VendorPostal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MenuMenuItem'
CREATE TABLE [dbo].[MenuMenuItem] (
    [Menus_Id] int  NOT NULL,
    [MenuItems_Id] int  NOT NULL
);
GO

-- Creating table 'MenuProduct'
CREATE TABLE [dbo].[MenuProduct] (
    [Menus_Id] int  NOT NULL,
    [Products_ProductId] int  NOT NULL
);
GO

-- Creating table 'OrderItemOrder'
CREATE TABLE [dbo].[OrderItemOrder] (
    [Orders_OrderNo] int  NOT NULL,
    [OrderItems_OrderItemId] int  NOT NULL
);
GO

-- Creating table 'ProductInventory'
CREATE TABLE [dbo].[ProductInventory] (
    [Inventories_InventoryId] int  NOT NULL,
    [Products_ProductId] int  NOT NULL
);
GO

-- Creating table 'ProductOrder'
CREATE TABLE [dbo].[ProductOrder] (
    [Orders_OrderNo] int  NOT NULL,
    [Products_ProductId] int  NOT NULL
);
GO

-- Creating table 'ProductOrder1'
CREATE TABLE [dbo].[ProductOrder1] (
    [Orders1_OrderNo] int  NOT NULL,
    [Products1_ProductId] int  NOT NULL
);
GO

-- Creating table 'ProductOrderItem'
CREATE TABLE [dbo].[ProductOrderItem] (
    [OrderItems_OrderItemId] int  NOT NULL,
    [Products_ProductId] int  NOT NULL
);
GO

-- Creating table 'UserBooking'
CREATE TABLE [dbo].[UserBooking] (
    [Bookings_BookingId] int  NOT NULL,
    [Users_UserId] int  NOT NULL
);
GO

-- Creating table 'UserOrder'
CREATE TABLE [dbo].[UserOrder] (
    [Orders_OrderNo] int  NOT NULL,
    [Users_UserId] int  NOT NULL
);
GO

-- Creating table 'VendorInventoryItem'
CREATE TABLE [dbo].[VendorInventoryItem] (
    [InventoryItems_ItemId] int  NOT NULL,
    [Vendors_VendorId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BookingId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [PK_Bookings]
    PRIMARY KEY CLUSTERED ([BookingId] ASC);
GO

-- Creating primary key on [FileId] in table 'Galleries'
ALTER TABLE [dbo].[Galleries]
ADD CONSTRAINT [PK_Galleries]
    PRIMARY KEY CLUSTERED ([FileId] ASC);
GO

-- Creating primary key on [InventoryId] in table 'Inventories'
ALTER TABLE [dbo].[Inventories]
ADD CONSTRAINT [PK_Inventories]
    PRIMARY KEY CLUSTERED ([InventoryId] ASC);
GO

-- Creating primary key on [ItemId] in table 'InventoryItems'
ALTER TABLE [dbo].[InventoryItems]
ADD CONSTRAINT [PK_InventoryItems]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [Id] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [PK_MenuItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [OrderItemId] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [PK_OrderItems]
    PRIMARY KEY CLUSTERED ([OrderItemId] ASC);
GO

-- Creating primary key on [OrderNo] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderNo] ASC);
GO

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [VendorId] in table 'Vendors'
ALTER TABLE [dbo].[Vendors]
ADD CONSTRAINT [PK_Vendors]
    PRIMARY KEY CLUSTERED ([VendorId] ASC);
GO

-- Creating primary key on [Menus_Id], [MenuItems_Id] in table 'MenuMenuItem'
ALTER TABLE [dbo].[MenuMenuItem]
ADD CONSTRAINT [PK_MenuMenuItem]
    PRIMARY KEY CLUSTERED ([Menus_Id], [MenuItems_Id] ASC);
GO

-- Creating primary key on [Menus_Id], [Products_ProductId] in table 'MenuProduct'
ALTER TABLE [dbo].[MenuProduct]
ADD CONSTRAINT [PK_MenuProduct]
    PRIMARY KEY CLUSTERED ([Menus_Id], [Products_ProductId] ASC);
GO

-- Creating primary key on [Orders_OrderNo], [OrderItems_OrderItemId] in table 'OrderItemOrder'
ALTER TABLE [dbo].[OrderItemOrder]
ADD CONSTRAINT [PK_OrderItemOrder]
    PRIMARY KEY CLUSTERED ([Orders_OrderNo], [OrderItems_OrderItemId] ASC);
GO

-- Creating primary key on [Inventories_InventoryId], [Products_ProductId] in table 'ProductInventory'
ALTER TABLE [dbo].[ProductInventory]
ADD CONSTRAINT [PK_ProductInventory]
    PRIMARY KEY CLUSTERED ([Inventories_InventoryId], [Products_ProductId] ASC);
GO

-- Creating primary key on [Orders_OrderNo], [Products_ProductId] in table 'ProductOrder'
ALTER TABLE [dbo].[ProductOrder]
ADD CONSTRAINT [PK_ProductOrder]
    PRIMARY KEY CLUSTERED ([Orders_OrderNo], [Products_ProductId] ASC);
GO

-- Creating primary key on [Orders1_OrderNo], [Products1_ProductId] in table 'ProductOrder1'
ALTER TABLE [dbo].[ProductOrder1]
ADD CONSTRAINT [PK_ProductOrder1]
    PRIMARY KEY CLUSTERED ([Orders1_OrderNo], [Products1_ProductId] ASC);
GO

-- Creating primary key on [OrderItems_OrderItemId], [Products_ProductId] in table 'ProductOrderItem'
ALTER TABLE [dbo].[ProductOrderItem]
ADD CONSTRAINT [PK_ProductOrderItem]
    PRIMARY KEY CLUSTERED ([OrderItems_OrderItemId], [Products_ProductId] ASC);
GO

-- Creating primary key on [Bookings_BookingId], [Users_UserId] in table 'UserBooking'
ALTER TABLE [dbo].[UserBooking]
ADD CONSTRAINT [PK_UserBooking]
    PRIMARY KEY CLUSTERED ([Bookings_BookingId], [Users_UserId] ASC);
GO

-- Creating primary key on [Orders_OrderNo], [Users_UserId] in table 'UserOrder'
ALTER TABLE [dbo].[UserOrder]
ADD CONSTRAINT [PK_UserOrder]
    PRIMARY KEY CLUSTERED ([Orders_OrderNo], [Users_UserId] ASC);
GO

-- Creating primary key on [InventoryItems_ItemId], [Vendors_VendorId] in table 'VendorInventoryItem'
ALTER TABLE [dbo].[VendorInventoryItem]
ADD CONSTRAINT [PK_VendorInventoryItem]
    PRIMARY KEY CLUSTERED ([InventoryItems_ItemId], [Vendors_VendorId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Inventory_InventoryId] in table 'InventoryItems'
ALTER TABLE [dbo].[InventoryItems]
ADD CONSTRAINT [FK_InventoryInventoryItem]
    FOREIGN KEY ([Inventory_InventoryId])
    REFERENCES [dbo].[Inventories]
        ([InventoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InventoryInventoryItem'
CREATE INDEX [IX_FK_InventoryInventoryItem]
ON [dbo].[InventoryItems]
    ([Inventory_InventoryId]);
GO

-- Creating foreign key on [Menus_Id] in table 'MenuMenuItem'
ALTER TABLE [dbo].[MenuMenuItem]
ADD CONSTRAINT [FK_MenuMenuItem_Menus]
    FOREIGN KEY ([Menus_Id])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MenuItems_Id] in table 'MenuMenuItem'
ALTER TABLE [dbo].[MenuMenuItem]
ADD CONSTRAINT [FK_MenuMenuItem_MenuItems]
    FOREIGN KEY ([MenuItems_Id])
    REFERENCES [dbo].[MenuItems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuMenuItem_MenuItems'
CREATE INDEX [IX_FK_MenuMenuItem_MenuItems]
ON [dbo].[MenuMenuItem]
    ([MenuItems_Id]);
GO

-- Creating foreign key on [Menus_Id] in table 'MenuProduct'
ALTER TABLE [dbo].[MenuProduct]
ADD CONSTRAINT [FK_MenuProduct_Menus]
    FOREIGN KEY ([Menus_Id])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_ProductId] in table 'MenuProduct'
ALTER TABLE [dbo].[MenuProduct]
ADD CONSTRAINT [FK_MenuProduct_Products]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuProduct_Products'
CREATE INDEX [IX_FK_MenuProduct_Products]
ON [dbo].[MenuProduct]
    ([Products_ProductId]);
GO

-- Creating foreign key on [Orders_OrderNo] in table 'OrderItemOrder'
ALTER TABLE [dbo].[OrderItemOrder]
ADD CONSTRAINT [FK_OrderItemOrder_Orders]
    FOREIGN KEY ([Orders_OrderNo])
    REFERENCES [dbo].[Orders]
        ([OrderNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OrderItems_OrderItemId] in table 'OrderItemOrder'
ALTER TABLE [dbo].[OrderItemOrder]
ADD CONSTRAINT [FK_OrderItemOrder_OrderItems]
    FOREIGN KEY ([OrderItems_OrderItemId])
    REFERENCES [dbo].[OrderItems]
        ([OrderItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderItemOrder_OrderItems'
CREATE INDEX [IX_FK_OrderItemOrder_OrderItems]
ON [dbo].[OrderItemOrder]
    ([OrderItems_OrderItemId]);
GO

-- Creating foreign key on [Inventories_InventoryId] in table 'ProductInventory'
ALTER TABLE [dbo].[ProductInventory]
ADD CONSTRAINT [FK_ProductInventory_Inventories]
    FOREIGN KEY ([Inventories_InventoryId])
    REFERENCES [dbo].[Inventories]
        ([InventoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_ProductId] in table 'ProductInventory'
ALTER TABLE [dbo].[ProductInventory]
ADD CONSTRAINT [FK_ProductInventory_Products]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductInventory_Products'
CREATE INDEX [IX_FK_ProductInventory_Products]
ON [dbo].[ProductInventory]
    ([Products_ProductId]);
GO

-- Creating foreign key on [Orders_OrderNo] in table 'ProductOrder'
ALTER TABLE [dbo].[ProductOrder]
ADD CONSTRAINT [FK_ProductOrder_Orders]
    FOREIGN KEY ([Orders_OrderNo])
    REFERENCES [dbo].[Orders]
        ([OrderNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_ProductId] in table 'ProductOrder'
ALTER TABLE [dbo].[ProductOrder]
ADD CONSTRAINT [FK_ProductOrder_Products]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrder_Products'
CREATE INDEX [IX_FK_ProductOrder_Products]
ON [dbo].[ProductOrder]
    ([Products_ProductId]);
GO

-- Creating foreign key on [Orders1_OrderNo] in table 'ProductOrder1'
ALTER TABLE [dbo].[ProductOrder1]
ADD CONSTRAINT [FK_ProductOrder1_Orders]
    FOREIGN KEY ([Orders1_OrderNo])
    REFERENCES [dbo].[Orders]
        ([OrderNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products1_ProductId] in table 'ProductOrder1'
ALTER TABLE [dbo].[ProductOrder1]
ADD CONSTRAINT [FK_ProductOrder1_Products]
    FOREIGN KEY ([Products1_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrder1_Products'
CREATE INDEX [IX_FK_ProductOrder1_Products]
ON [dbo].[ProductOrder1]
    ([Products1_ProductId]);
GO

-- Creating foreign key on [OrderItems_OrderItemId] in table 'ProductOrderItem'
ALTER TABLE [dbo].[ProductOrderItem]
ADD CONSTRAINT [FK_ProductOrderItem_OrderItems]
    FOREIGN KEY ([OrderItems_OrderItemId])
    REFERENCES [dbo].[OrderItems]
        ([OrderItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_ProductId] in table 'ProductOrderItem'
ALTER TABLE [dbo].[ProductOrderItem]
ADD CONSTRAINT [FK_ProductOrderItem_Products]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrderItem_Products'
CREATE INDEX [IX_FK_ProductOrderItem_Products]
ON [dbo].[ProductOrderItem]
    ([Products_ProductId]);
GO

-- Creating foreign key on [Bookings_BookingId] in table 'UserBooking'
ALTER TABLE [dbo].[UserBooking]
ADD CONSTRAINT [FK_UserBooking_Bookings]
    FOREIGN KEY ([Bookings_BookingId])
    REFERENCES [dbo].[Bookings]
        ([BookingId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_UserId] in table 'UserBooking'
ALTER TABLE [dbo].[UserBooking]
ADD CONSTRAINT [FK_UserBooking_Users]
    FOREIGN KEY ([Users_UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBooking_Users'
CREATE INDEX [IX_FK_UserBooking_Users]
ON [dbo].[UserBooking]
    ([Users_UserId]);
GO

-- Creating foreign key on [Orders_OrderNo] in table 'UserOrder'
ALTER TABLE [dbo].[UserOrder]
ADD CONSTRAINT [FK_UserOrder_Orders]
    FOREIGN KEY ([Orders_OrderNo])
    REFERENCES [dbo].[Orders]
        ([OrderNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_UserId] in table 'UserOrder'
ALTER TABLE [dbo].[UserOrder]
ADD CONSTRAINT [FK_UserOrder_Users]
    FOREIGN KEY ([Users_UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOrder_Users'
CREATE INDEX [IX_FK_UserOrder_Users]
ON [dbo].[UserOrder]
    ([Users_UserId]);
GO

-- Creating foreign key on [InventoryItems_ItemId] in table 'VendorInventoryItem'
ALTER TABLE [dbo].[VendorInventoryItem]
ADD CONSTRAINT [FK_VendorInventoryItem_InventoryItems]
    FOREIGN KEY ([InventoryItems_ItemId])
    REFERENCES [dbo].[InventoryItems]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Vendors_VendorId] in table 'VendorInventoryItem'
ALTER TABLE [dbo].[VendorInventoryItem]
ADD CONSTRAINT [FK_VendorInventoryItem_Vendors]
    FOREIGN KEY ([Vendors_VendorId])
    REFERENCES [dbo].[Vendors]
        ([VendorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendorInventoryItem_Vendors'
CREATE INDEX [IX_FK_VendorInventoryItem_Vendors]
ON [dbo].[VendorInventoryItem]
    ([Vendors_VendorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------