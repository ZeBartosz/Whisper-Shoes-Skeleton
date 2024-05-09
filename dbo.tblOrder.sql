CREATE TABLE [dbo].[tblOrder] (
    [Order_id]          INT          IDENTITY (1, 1) NOT NULL,
    [Customer_id ]      VARCHAR(50)          NULL,
    [Item_id ]          INT          NULL,
    [Order_date ]       DATE         NULL,
    [Total_amount ]     FLOAT (53)   NULL,
    [Shipping_address ] VARCHAR (50) NULL,
    [Orde_completed ]   BIT          NULL,
    CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED ([Order_id] ASC)
);

