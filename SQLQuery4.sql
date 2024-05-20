USE [p2726086]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrder_FilterByOrderId]
		@OrderId = 2

SELECT	@return_value as 'Return Value'

GO
