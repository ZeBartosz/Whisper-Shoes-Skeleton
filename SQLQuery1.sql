USE [p2726086]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sporc_tblOrder_SelectALL]

SELECT	@return_value as 'Return Value'

GO
