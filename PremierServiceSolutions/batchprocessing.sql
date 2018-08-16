-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_BatchProcessing 
	-- Add the parameters for the stored procedure here
@contractIdentifier VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
DECLARE mycur Cursor
FOR (SELECT [Contract].ContractType, [Contract].ServiceAvailable
,[Service].ServiceName, [Service].ServiceLevel
FROM [Contract] INNER JOIN [service]
ON [Contract].ServiceID = [Service].ServiceID
WHERE [Contract].ContractIdentifier = @contractIdentifier)

DECLARE @type VARCHAR(50), @available VARCHAR(50), @serviceName VARCHAR(50)
,@serviceLevel VARCHAR(50)

OPEN mycur
FETCH NEXT FROM mycur INTO @type, @available, @serviceName
WHILE @@FETCH_STATUS = 0
BEGIN
	IF @contractIdentifier = null
	BEGIN
		PRINT 'ContractExpired'
	END

FETCH NEXT FROM mycur INTO @type, @available, @serviceName
END

CLOSE mycur

DEALLOCATE mycur
END
GO
