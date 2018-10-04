SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderSelectList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderSelectList]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderSelectList]
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [ELOG_BLHeader].* ,
    [ELOG_Ports1].[Description] AS ELOG_Ports1_Description 
  FROM [ELOG_BLHeader] 
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]
    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]
  WHERE 1 = 1  
  ORDER BY
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_BLHeader].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_BLHeader].[BLID] END DESC,
     CASE @OrderBy WHEN 'BLNumber' THEN [ELOG_BLHeader].[BLNumber] END,
     CASE @OrderBy WHEN 'BLNumber DESC' THEN [ELOG_BLHeader].[BLNumber] END DESC,
     CASE @OrderBy WHEN 'BLDate' THEN [ELOG_BLHeader].[BLDate] END,
     CASE @OrderBy WHEN 'BLDate DESC' THEN [ELOG_BLHeader].[BLDate] END DESC,
     CASE @OrderBy WHEN 'PortOfLoading' THEN [ELOG_BLHeader].[PortOfLoading] END,
     CASE @OrderBy WHEN 'PortOfLoading DESC' THEN [ELOG_BLHeader].[PortOfLoading] END DESC,
     CASE @OrderBy WHEN 'VesselOrFlightNo' THEN [ELOG_BLHeader].[VesselOrFlightNo] END,
     CASE @OrderBy WHEN 'VesselOrFlightNo DESC' THEN [ELOG_BLHeader].[VesselOrFlightNo] END DESC,
     CASE @OrderBy WHEN 'VoyageNo' THEN [ELOG_BLHeader].[VoyageNo] END,
     CASE @OrderBy WHEN 'VoyageNo DESC' THEN [ELOG_BLHeader].[VoyageNo] END DESC,
     CASE @OrderBy WHEN 'TransShipmentPortID' THEN [ELOG_BLHeader].[TransShipmentPortID] END,
     CASE @OrderBy WHEN 'TransShipmentPortID DESC' THEN [ELOG_BLHeader].[TransShipmentPortID] END DESC,
     CASE @OrderBy WHEN 'PrepaidFlight' THEN [ELOG_BLHeader].[PrepaidFlight] END,
     CASE @OrderBy WHEN 'PrepaidFlight DESC' THEN [ELOG_BLHeader].[PrepaidFlight] END DESC,
     CASE @OrderBy WHEN 'ShippingLine' THEN [ELOG_BLHeader].[ShippingLine] END,
     CASE @OrderBy WHEN 'ShippingLine DESC' THEN [ELOG_BLHeader].[ShippingLine] END DESC,
     CASE @OrderBy WHEN 'SOBDate' THEN [ELOG_BLHeader].[SOBDate] END,
     CASE @OrderBy WHEN 'SOBDate DESC' THEN [ELOG_BLHeader].[SOBDate] END DESC,
     CASE @OrderBy WHEN 'MBLNo' THEN [ELOG_BLHeader].[MBLNo] END,
     CASE @OrderBy WHEN 'MBLNo DESC' THEN [ELOG_BLHeader].[MBLNo] END DESC,
     CASE @OrderBy WHEN 'PreCarriageBy' THEN [ELOG_BLHeader].[PreCarriageBy] END,
     CASE @OrderBy WHEN 'PreCarriageBy DESC' THEN [ELOG_BLHeader].[PreCarriageBy] END DESC,
     CASE @OrderBy WHEN 'PlaceOfReceiptBy' THEN [ELOG_BLHeader].[PlaceOfReceiptBy] END,
     CASE @OrderBy WHEN 'PlaceOfReceiptBy DESC' THEN [ELOG_BLHeader].[PlaceOfReceiptBy] END DESC,
     CASE @OrderBy WHEN 'Air1Freight' THEN [ELOG_BLHeader].[Air1Freight] END,
     CASE @OrderBy WHEN 'Air1Freight DESC' THEN [ELOG_BLHeader].[Air1Freight] END DESC,
     CASE @OrderBy WHEN 'Air2Freight' THEN [ELOG_BLHeader].[Air2Freight] END,
     CASE @OrderBy WHEN 'Air2Freight DESC' THEN [ELOG_BLHeader].[Air2Freight] END DESC,
     CASE @OrderBy WHEN 'Air3Freight' THEN [ELOG_BLHeader].[Air3Freight] END,
     CASE @OrderBy WHEN 'Air3Freight DESC' THEN [ELOG_BLHeader].[Air3Freight] END DESC,
     CASE @OrderBy WHEN 'Air4Freight' THEN [ELOG_BLHeader].[Air4Freight] END,
     CASE @OrderBy WHEN 'Air4Freight DESC' THEN [ELOG_BLHeader].[Air4Freight] END DESC,
     CASE @OrderBy WHEN 'ELOG_Ports1_Description' THEN [ELOG_Ports1].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Ports1_Description DESC' THEN [ELOG_Ports1].[Description] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderAutoCompleteList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderAutoCompleteList]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderAutoCompleteList]
  @LoginID NVarChar(8),
  @Prefix NVarChar(250),
  @Records Int,
  @ByCode Int 
  AS 
  BEGIN 
  DECLARE @Prefix1 VarChar(260)
  SET @Prefix1 = LOWER(@Prefix) + '%'
  DECLARE @LGSQL VarChar(8000)
  SET @LGSQL = 'SELECT TOP (' + STR(@Records) + ') ' 
  SET @LGSQL = @LGSQL + ' [ELOG_BLHeader].[BLNumber]' 
  SET @LGSQL = @LGSQL + ',[ELOG_BLHeader].[BLID]' 
  SET @LGSQL = @LGSQL + ' FROM [ELOG_BLHeader] ' 
  SET @LGSQL = @LGSQL + ' WHERE 1 = 1 ' 
  SET @LGSQL = @LGSQL + ' AND (LOWER(ISNULL([ELOG_BLHeader].[BLID],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ' OR LOWER(ISNULL([ELOG_BLHeader].[BLNumber],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ')' 
  
  EXEC (@LGSQL)
  END 
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderSelectByID]
  @LoginID NVarChar(8),
  @BLID NVarChar(9) 
  AS
  SELECT
    [ELOG_BLHeader].* ,
    [ELOG_Ports1].[Description] AS ELOG_Ports1_Description 
  FROM [ELOG_BLHeader] 
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]
    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]
  WHERE
  [ELOG_BLHeader].[BLID] = @BLID
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,BLID NVarChar(9) NOT NULL
  )
  INSERT INTO #PageIndex (BLID)
  SELECT [ELOG_BLHeader].[BLID] FROM [ELOG_BLHeader]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]
    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]
 WHERE  
   ( 
         LOWER(ISNULL([ELOG_BLHeader].[BLID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[BLNumber],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[PortOfLoading],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[VesselOrFlightNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[VoyageNo],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_BLHeader].[TransShipmentPortID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[ShippingLine],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[MBLNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[PreCarriageBy],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[PlaceOfReceiptBy],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[Air1Freight],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[Air2Freight],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[Air3Freight],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLHeader].[Air4Freight],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_BLHeader].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_BLHeader].[BLID] END DESC,
     CASE @OrderBy WHEN 'BLNumber' THEN [ELOG_BLHeader].[BLNumber] END,
     CASE @OrderBy WHEN 'BLNumber DESC' THEN [ELOG_BLHeader].[BLNumber] END DESC,
     CASE @OrderBy WHEN 'BLDate' THEN [ELOG_BLHeader].[BLDate] END,
     CASE @OrderBy WHEN 'BLDate DESC' THEN [ELOG_BLHeader].[BLDate] END DESC,
     CASE @OrderBy WHEN 'PortOfLoading' THEN [ELOG_BLHeader].[PortOfLoading] END,
     CASE @OrderBy WHEN 'PortOfLoading DESC' THEN [ELOG_BLHeader].[PortOfLoading] END DESC,
     CASE @OrderBy WHEN 'VesselOrFlightNo' THEN [ELOG_BLHeader].[VesselOrFlightNo] END,
     CASE @OrderBy WHEN 'VesselOrFlightNo DESC' THEN [ELOG_BLHeader].[VesselOrFlightNo] END DESC,
     CASE @OrderBy WHEN 'VoyageNo' THEN [ELOG_BLHeader].[VoyageNo] END,
     CASE @OrderBy WHEN 'VoyageNo DESC' THEN [ELOG_BLHeader].[VoyageNo] END DESC,
     CASE @OrderBy WHEN 'TransShipmentPortID' THEN [ELOG_BLHeader].[TransShipmentPortID] END,
     CASE @OrderBy WHEN 'TransShipmentPortID DESC' THEN [ELOG_BLHeader].[TransShipmentPortID] END DESC,
     CASE @OrderBy WHEN 'PrepaidFlight' THEN [ELOG_BLHeader].[PrepaidFlight] END,
     CASE @OrderBy WHEN 'PrepaidFlight DESC' THEN [ELOG_BLHeader].[PrepaidFlight] END DESC,
     CASE @OrderBy WHEN 'ShippingLine' THEN [ELOG_BLHeader].[ShippingLine] END,
     CASE @OrderBy WHEN 'ShippingLine DESC' THEN [ELOG_BLHeader].[ShippingLine] END DESC,
     CASE @OrderBy WHEN 'SOBDate' THEN [ELOG_BLHeader].[SOBDate] END,
     CASE @OrderBy WHEN 'SOBDate DESC' THEN [ELOG_BLHeader].[SOBDate] END DESC,
     CASE @OrderBy WHEN 'MBLNo' THEN [ELOG_BLHeader].[MBLNo] END,
     CASE @OrderBy WHEN 'MBLNo DESC' THEN [ELOG_BLHeader].[MBLNo] END DESC,
     CASE @OrderBy WHEN 'PreCarriageBy' THEN [ELOG_BLHeader].[PreCarriageBy] END,
     CASE @OrderBy WHEN 'PreCarriageBy DESC' THEN [ELOG_BLHeader].[PreCarriageBy] END DESC,
     CASE @OrderBy WHEN 'PlaceOfReceiptBy' THEN [ELOG_BLHeader].[PlaceOfReceiptBy] END,
     CASE @OrderBy WHEN 'PlaceOfReceiptBy DESC' THEN [ELOG_BLHeader].[PlaceOfReceiptBy] END DESC,
     CASE @OrderBy WHEN 'Air1Freight' THEN [ELOG_BLHeader].[Air1Freight] END,
     CASE @OrderBy WHEN 'Air1Freight DESC' THEN [ELOG_BLHeader].[Air1Freight] END DESC,
     CASE @OrderBy WHEN 'Air2Freight' THEN [ELOG_BLHeader].[Air2Freight] END,
     CASE @OrderBy WHEN 'Air2Freight DESC' THEN [ELOG_BLHeader].[Air2Freight] END DESC,
     CASE @OrderBy WHEN 'Air3Freight' THEN [ELOG_BLHeader].[Air3Freight] END,
     CASE @OrderBy WHEN 'Air3Freight DESC' THEN [ELOG_BLHeader].[Air3Freight] END DESC,
     CASE @OrderBy WHEN 'Air4Freight' THEN [ELOG_BLHeader].[Air4Freight] END,
     CASE @OrderBy WHEN 'Air4Freight DESC' THEN [ELOG_BLHeader].[Air4Freight] END DESC,
     CASE @OrderBy WHEN 'ELOG_Ports1_Description' THEN [ELOG_Ports1].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Ports1_Description DESC' THEN [ELOG_Ports1].[Description] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [ELOG_BLHeader].* ,
    [ELOG_Ports1].[Description] AS ELOG_Ports1_Description 
  FROM [ELOG_BLHeader] 
      INNER JOIN #PageIndex
          ON [ELOG_BLHeader].[BLID] = #PageIndex.BLID
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]
    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderSelectListFilteres]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,BLID NVarChar(9) NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'BLID'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[ELOG_BLHeader].[BLID]'
  SET @LGSQL = @LGSQL + ' FROM [ELOG_BLHeader] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'BLID' THEN '[ELOG_BLHeader].[BLID]'
                        WHEN 'BLID DESC' THEN '[ELOG_BLHeader].[BLID] DESC'
                        WHEN 'BLNumber' THEN '[ELOG_BLHeader].[BLNumber]'
                        WHEN 'BLNumber DESC' THEN '[ELOG_BLHeader].[BLNumber] DESC'
                        WHEN 'BLDate' THEN '[ELOG_BLHeader].[BLDate]'
                        WHEN 'BLDate DESC' THEN '[ELOG_BLHeader].[BLDate] DESC'
                        WHEN 'PortOfLoading' THEN '[ELOG_BLHeader].[PortOfLoading]'
                        WHEN 'PortOfLoading DESC' THEN '[ELOG_BLHeader].[PortOfLoading] DESC'
                        WHEN 'VesselOrFlightNo' THEN '[ELOG_BLHeader].[VesselOrFlightNo]'
                        WHEN 'VesselOrFlightNo DESC' THEN '[ELOG_BLHeader].[VesselOrFlightNo] DESC'
                        WHEN 'VoyageNo' THEN '[ELOG_BLHeader].[VoyageNo]'
                        WHEN 'VoyageNo DESC' THEN '[ELOG_BLHeader].[VoyageNo] DESC'
                        WHEN 'TransShipmentPortID' THEN '[ELOG_BLHeader].[TransShipmentPortID]'
                        WHEN 'TransShipmentPortID DESC' THEN '[ELOG_BLHeader].[TransShipmentPortID] DESC'
                        WHEN 'PrepaidFlight' THEN '[ELOG_BLHeader].[PrepaidFlight]'
                        WHEN 'PrepaidFlight DESC' THEN '[ELOG_BLHeader].[PrepaidFlight] DESC'
                        WHEN 'ShippingLine' THEN '[ELOG_BLHeader].[ShippingLine]'
                        WHEN 'ShippingLine DESC' THEN '[ELOG_BLHeader].[ShippingLine] DESC'
                        WHEN 'SOBDate' THEN '[ELOG_BLHeader].[SOBDate]'
                        WHEN 'SOBDate DESC' THEN '[ELOG_BLHeader].[SOBDate] DESC'
                        WHEN 'MBLNo' THEN '[ELOG_BLHeader].[MBLNo]'
                        WHEN 'MBLNo DESC' THEN '[ELOG_BLHeader].[MBLNo] DESC'
                        WHEN 'PreCarriageBy' THEN '[ELOG_BLHeader].[PreCarriageBy]'
                        WHEN 'PreCarriageBy DESC' THEN '[ELOG_BLHeader].[PreCarriageBy] DESC'
                        WHEN 'PlaceOfReceiptBy' THEN '[ELOG_BLHeader].[PlaceOfReceiptBy]'
                        WHEN 'PlaceOfReceiptBy DESC' THEN '[ELOG_BLHeader].[PlaceOfReceiptBy] DESC'
                        WHEN 'Air1Freight' THEN '[ELOG_BLHeader].[Air1Freight]'
                        WHEN 'Air1Freight DESC' THEN '[ELOG_BLHeader].[Air1Freight] DESC'
                        WHEN 'Air2Freight' THEN '[ELOG_BLHeader].[Air2Freight]'
                        WHEN 'Air2Freight DESC' THEN '[ELOG_BLHeader].[Air2Freight] DESC'
                        WHEN 'Air3Freight' THEN '[ELOG_BLHeader].[Air3Freight]'
                        WHEN 'Air3Freight DESC' THEN '[ELOG_BLHeader].[Air3Freight] DESC'
                        WHEN 'Air4Freight' THEN '[ELOG_BLHeader].[Air4Freight]'
                        WHEN 'Air4Freight DESC' THEN '[ELOG_BLHeader].[Air4Freight] DESC'
                        WHEN 'ELOG_Ports1_Description' THEN '[ELOG_Ports1].[Description]'
                        WHEN 'ELOG_Ports1_Description DESC' THEN '[ELOG_Ports1].[Description] DESC'
                        ELSE '[ELOG_BLHeader].[BLID]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [ELOG_BLHeader].* ,
    [ELOG_Ports1].[Description] AS ELOG_Ports1_Description 
  FROM [ELOG_BLHeader] 
      INNER JOIN #PageIndex
          ON [ELOG_BLHeader].[BLID] = #PageIndex.BLID
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports1]
    ON [ELOG_BLHeader].[TransShipmentPortID] = [ELOG_Ports1].[PortID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderInsert]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderInsert]
  @BLID NVarChar(9),
  @BLNumber NVarChar(50),
  @BLDate DateTime,
  @PortOfLoading NVarChar(100),
  @VesselOrFlightNo NVarChar(100),
  @VoyageNo NVarChar(100),
  @TransShipmentPortID Int,
  @PrepaidFlight Bit,
  @ShippingLine NVarChar(100),
  @SOBDate DateTime,
  @MBLNo NVarChar(50),
  @PreCarriageBy NVarChar(100),
  @PlaceOfReceiptBy NVarChar(100),
  @Air1Freight NVarChar(100),
  @Air2Freight NVarChar(100),
  @Air3Freight NVarChar(100),
  @Air4Freight NVarChar(100),
  @Return_BLID NVarChar(9) = null OUTPUT 
  AS
  INSERT [ELOG_BLHeader]
  (
   [BLID]
  ,[BLNumber]
  ,[BLDate]
  ,[PortOfLoading]
  ,[VesselOrFlightNo]
  ,[VoyageNo]
  ,[TransShipmentPortID]
  ,[PrepaidFlight]
  ,[ShippingLine]
  ,[SOBDate]
  ,[MBLNo]
  ,[PreCarriageBy]
  ,[PlaceOfReceiptBy]
  ,[Air1Freight]
  ,[Air2Freight]
  ,[Air3Freight]
  ,[Air4Freight]
  )
  VALUES
  (
   UPPER(@BLID)
  ,@BLNumber
  ,@BLDate
  ,@PortOfLoading
  ,@VesselOrFlightNo
  ,@VoyageNo
  ,@TransShipmentPortID
  ,@PrepaidFlight
  ,@ShippingLine
  ,@SOBDate
  ,@MBLNo
  ,@PreCarriageBy
  ,@PlaceOfReceiptBy
  ,@Air1Freight
  ,@Air2Freight
  ,@Air3Freight
  ,@Air4Freight
  )
  SET @Return_BLID = @BLID
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderUpdate]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderUpdate]
  @Original_BLID NVarChar(9), 
  @BLID NVarChar(9),
  @BLNumber NVarChar(50),
  @BLDate DateTime,
  @PortOfLoading NVarChar(100),
  @VesselOrFlightNo NVarChar(100),
  @VoyageNo NVarChar(100),
  @TransShipmentPortID Int,
  @PrepaidFlight Bit,
  @ShippingLine NVarChar(100),
  @SOBDate DateTime,
  @MBLNo NVarChar(50),
  @PreCarriageBy NVarChar(100),
  @PlaceOfReceiptBy NVarChar(100),
  @Air1Freight NVarChar(100),
  @Air2Freight NVarChar(100),
  @Air3Freight NVarChar(100),
  @Air4Freight NVarChar(100),
  @RowCount int = null OUTPUT
  AS
  UPDATE [ELOG_BLHeader] SET 
   [BLID] = @BLID
  ,[BLNumber] = @BLNumber
  ,[BLDate] = @BLDate
  ,[PortOfLoading] = @PortOfLoading
  ,[VesselOrFlightNo] = @VesselOrFlightNo
  ,[VoyageNo] = @VoyageNo
  ,[TransShipmentPortID] = @TransShipmentPortID
  ,[PrepaidFlight] = @PrepaidFlight
  ,[ShippingLine] = @ShippingLine
  ,[SOBDate] = @SOBDate
  ,[MBLNo] = @MBLNo
  ,[PreCarriageBy] = @PreCarriageBy
  ,[PlaceOfReceiptBy] = @PlaceOfReceiptBy
  ,[Air1Freight] = @Air1Freight
  ,[Air2Freight] = @Air2Freight
  ,[Air3Freight] = @Air3Freight
  ,[Air4Freight] = @Air4Freight
  WHERE
  [BLID] = @Original_BLID
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLHeaderDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLHeaderDelete]
GO
 
CREATE PROCEDURE [dbo].[spelogBLHeaderDelete]
  @Original_BLID NVarChar(9),
  @RowCount int = null OUTPUT
  AS
  DELETE [ELOG_BLHeader]
  WHERE
  [ELOG_BLHeader].[BLID] = @Original_BLID
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsSelectByID]
  @LoginID NVarChar(8),
  @BLID NVarChar(9),
  @SerialNo Int 
  AS
  SELECT
    [ELOG_BLDetails].* ,
    [ELOG_BLHeader1].[BLNumber] AS ELOG_BLHeader1_BLNumber 
  FROM [ELOG_BLDetails] 
  INNER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader1]
    ON [ELOG_BLDetails].[BLID] = [ELOG_BLHeader1].[BLID]
  WHERE
  [ELOG_BLDetails].[BLID] = @BLID
  AND [ELOG_BLDetails].[SerialNo] = @SerialNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,BLID NVarChar(9) NOT NULL
 ,SerialNo Int NOT NULL
  )
  INSERT INTO #PageIndex (BLID, SerialNo)
  SELECT [ELOG_BLDetails].[BLID], [ELOG_BLDetails].[SerialNo] FROM [ELOG_BLDetails]
  INNER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader1]
    ON [ELOG_BLDetails].[BLID] = [ELOG_BLHeader1].[BLID]
 WHERE  
   ( 
         LOWER(ISNULL([ELOG_BLDetails].[BLID],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_BLDetails].[SerialNo], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLDetails].[SizeAndTypeOfContainer],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLDetails].[ContainerNumber],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_BLDetails].[Remarks],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_BLDetails].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_BLDetails].[BLID] END DESC,
     CASE @OrderBy WHEN 'SerialNo' THEN [ELOG_BLDetails].[SerialNo] END,
     CASE @OrderBy WHEN 'SerialNo DESC' THEN [ELOG_BLDetails].[SerialNo] END DESC,
     CASE @OrderBy WHEN 'SizeAndTypeOfContainer' THEN [ELOG_BLDetails].[SizeAndTypeOfContainer] END,
     CASE @OrderBy WHEN 'SizeAndTypeOfContainer DESC' THEN [ELOG_BLDetails].[SizeAndTypeOfContainer] END DESC,
     CASE @OrderBy WHEN 'ContainerNumber' THEN [ELOG_BLDetails].[ContainerNumber] END,
     CASE @OrderBy WHEN 'ContainerNumber DESC' THEN [ELOG_BLDetails].[ContainerNumber] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [ELOG_BLDetails].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [ELOG_BLDetails].[Remarks] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLHeader1_BLNumber' THEN [ELOG_BLHeader1].[BLNumber] END,
     CASE @OrderBy WHEN 'ELOG_BLHeader1_BLNumber DESC' THEN [ELOG_BLHeader1].[BLNumber] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [ELOG_BLDetails].* ,
    [ELOG_BLHeader1].[BLNumber] AS ELOG_BLHeader1_BLNumber 
  FROM [ELOG_BLDetails] 
      INNER JOIN #PageIndex
          ON [ELOG_BLDetails].[BLID] = #PageIndex.BLID
          AND [ELOG_BLDetails].[SerialNo] = #PageIndex.SerialNo
  INNER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader1]
    ON [ELOG_BLDetails].[BLID] = [ELOG_BLHeader1].[BLID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsSelectListFilteres]
  @Filter_BLID NVarChar(9),
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,BLID NVarChar(9) NOT NULL
 ,SerialNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'BLID'
  SET @LGSQL = @LGSQL + ', SerialNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[ELOG_BLDetails].[BLID]'
  SET @LGSQL = @LGSQL + ', [ELOG_BLDetails].[SerialNo]'
  SET @LGSQL = @LGSQL + ' FROM [ELOG_BLDetails] '
  SET @LGSQL = @LGSQL + '  INNER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader1]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_BLDetails].[BLID] = [ELOG_BLHeader1].[BLID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  IF (@Filter_BLID > '') 
    SET @LGSQL = @LGSQL + ' AND [ELOG_BLDetails].[BLID] = ''' + @Filter_BLID + ''''
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'BLID' THEN '[ELOG_BLDetails].[BLID]'
                        WHEN 'BLID DESC' THEN '[ELOG_BLDetails].[BLID] DESC'
                        WHEN 'SerialNo' THEN '[ELOG_BLDetails].[SerialNo]'
                        WHEN 'SerialNo DESC' THEN '[ELOG_BLDetails].[SerialNo] DESC'
                        WHEN 'SizeAndTypeOfContainer' THEN '[ELOG_BLDetails].[SizeAndTypeOfContainer]'
                        WHEN 'SizeAndTypeOfContainer DESC' THEN '[ELOG_BLDetails].[SizeAndTypeOfContainer] DESC'
                        WHEN 'ContainerNumber' THEN '[ELOG_BLDetails].[ContainerNumber]'
                        WHEN 'ContainerNumber DESC' THEN '[ELOG_BLDetails].[ContainerNumber] DESC'
                        WHEN 'Remarks' THEN '[ELOG_BLDetails].[Remarks]'
                        WHEN 'Remarks DESC' THEN '[ELOG_BLDetails].[Remarks] DESC'
                        WHEN 'ELOG_BLHeader1_BLNumber' THEN '[ELOG_BLHeader1].[BLNumber]'
                        WHEN 'ELOG_BLHeader1_BLNumber DESC' THEN '[ELOG_BLHeader1].[BLNumber] DESC'
                        ELSE '[ELOG_BLDetails].[BLID],[ELOG_BLDetails].[SerialNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [ELOG_BLDetails].* ,
    [ELOG_BLHeader1].[BLNumber] AS ELOG_BLHeader1_BLNumber 
  FROM [ELOG_BLDetails] 
      INNER JOIN #PageIndex
          ON [ELOG_BLDetails].[BLID] = #PageIndex.BLID
          AND [ELOG_BLDetails].[SerialNo] = #PageIndex.SerialNo
  INNER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader1]
    ON [ELOG_BLDetails].[BLID] = [ELOG_BLHeader1].[BLID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsInsert]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsInsert]
  @BLID NVarChar(9),
  @SerialNo Int,
  @SizeAndTypeOfContainer NVarChar(50),
  @ContainerNumber NVarChar(50),
  @Remarks NVarChar(100),
  @Return_BLID NVarChar(9) = null OUTPUT, 
  @Return_SerialNo Int = null OUTPUT 
  AS
  INSERT [ELOG_BLDetails]
  (
   [BLID]
  ,[SerialNo]
  ,[SizeAndTypeOfContainer]
  ,[ContainerNumber]
  ,[Remarks]
  )
  VALUES
  (
   UPPER(@BLID)
  ,@SerialNo
  ,@SizeAndTypeOfContainer
  ,@ContainerNumber
  ,@Remarks
  )
  SET @Return_BLID = @BLID
  SET @Return_SerialNo = @SerialNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsUpdate]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsUpdate]
  @Original_BLID NVarChar(9), 
  @Original_SerialNo Int, 
  @BLID NVarChar(9),
  @SerialNo Int,
  @SizeAndTypeOfContainer NVarChar(50),
  @ContainerNumber NVarChar(50),
  @Remarks NVarChar(100),
  @RowCount int = null OUTPUT
  AS
  UPDATE [ELOG_BLDetails] SET 
   [BLID] = @BLID
  ,[SerialNo] = @SerialNo
  ,[SizeAndTypeOfContainer] = @SizeAndTypeOfContainer
  ,[ContainerNumber] = @ContainerNumber
  ,[Remarks] = @Remarks
  WHERE
  [BLID] = @Original_BLID
  AND [SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogBLDetailsDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogBLDetailsDelete]
GO
 
CREATE PROCEDURE [dbo].[spelogBLDetailsDelete]
  @Original_BLID NVarChar(9),
  @Original_SerialNo Int,
  @RowCount int = null OUTPUT
  AS
  DELETE [ELOG_BLDetails]
  WHERE
  [ELOG_BLDetails].[BLID] = @Original_BLID
  AND [ELOG_BLDetails].[SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLSelectList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLSelectList]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLSelectList]
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [ELOG_IRBL].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [ELOG_BLHeader2].[BLNumber] AS ELOG_BLHeader2_BLNumber,
    [ELOG_BLTypes3].[Description] AS ELOG_BLTypes3_Description,
    [ELOG_CargoTypes4].[Description] AS ELOG_CargoTypes4_Description,
    [ELOG_Carriers5].[Description] AS ELOG_Carriers5_Description,
    [ELOG_LocationCountries6].[Description] AS ELOG_LocationCountries6_Description,
    [ELOG_Ports7].[Description] AS ELOG_Ports7_Description,
    [ELOG_ShipmentModes8].[Description] AS ELOG_ShipmentModes8_Description,
    [IDM_Projects9].[Description] AS IDM_Projects9_Description,
    [VR_BusinessPartner10].[BPName] AS VR_BusinessPartner10_BPName,
    [ELOG_IRBLStates11].[Description] AS ELOG_IRBLStates11_Description 
  FROM [ELOG_IRBL] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
  WHERE 1 = 1  
  ORDER BY
     CASE @OrderBy WHEN 'IRNo' THEN [ELOG_IRBL].[IRNo] END,
     CASE @OrderBy WHEN 'IRNo DESC' THEN [ELOG_IRBL].[IRNo] END DESC,
     CASE @OrderBy WHEN 'SupplierID' THEN [ELOG_IRBL].[SupplierID] END,
     CASE @OrderBy WHEN 'SupplierID DESC' THEN [ELOG_IRBL].[SupplierID] END DESC,
     CASE @OrderBy WHEN 'ProjectID' THEN [ELOG_IRBL].[ProjectID] END,
     CASE @OrderBy WHEN 'ProjectID DESC' THEN [ELOG_IRBL].[ProjectID] END DESC,
     CASE @OrderBy WHEN 'PONo' THEN [ELOG_IRBL].[PONo] END,
     CASE @OrderBy WHEN 'PONo DESC' THEN [ELOG_IRBL].[PONo] END DESC,
     CASE @OrderBy WHEN 'SupplierBillNo' THEN [ELOG_IRBL].[SupplierBillNo] END,
     CASE @OrderBy WHEN 'SupplierBillNo DESC' THEN [ELOG_IRBL].[SupplierBillNo] END DESC,
     CASE @OrderBy WHEN 'supplierBillDate' THEN [ELOG_IRBL].[supplierBillDate] END,
     CASE @OrderBy WHEN 'supplierBillDate DESC' THEN [ELOG_IRBL].[supplierBillDate] END DESC,
     CASE @OrderBy WHEN 'SupplierBillAmount' THEN [ELOG_IRBL].[SupplierBillAmount] END,
     CASE @OrderBy WHEN 'SupplierBillAmount DESC' THEN [ELOG_IRBL].[SupplierBillAmount] END DESC,
     CASE @OrderBy WHEN 'IRDate' THEN [ELOG_IRBL].[IRDate] END,
     CASE @OrderBy WHEN 'IRDate DESC' THEN [ELOG_IRBL].[IRDate] END DESC,
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_IRBL].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_IRBL].[BLID] END DESC,
     CASE @OrderBy WHEN 'BLType' THEN [ELOG_IRBL].[BLType] END,
     CASE @OrderBy WHEN 'BLType DESC' THEN [ELOG_IRBL].[BLType] END DESC,
     CASE @OrderBy WHEN 'MBLNo' THEN [ELOG_IRBL].[MBLNo] END,
     CASE @OrderBy WHEN 'MBLNo DESC' THEN [ELOG_IRBL].[MBLNo] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [ELOG_IRBL].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [ELOG_IRBL].[Remarks] END DESC,
     CASE @OrderBy WHEN 'ShipmentModeID' THEN [ELOG_IRBL].[ShipmentModeID] END,
     CASE @OrderBy WHEN 'ShipmentModeID DESC' THEN [ELOG_IRBL].[ShipmentModeID] END DESC,
     CASE @OrderBy WHEN 'CarrierID' THEN [ELOG_IRBL].[CarrierID] END,
     CASE @OrderBy WHEN 'CarrierID DESC' THEN [ELOG_IRBL].[CarrierID] END DESC,
     CASE @OrderBy WHEN 'OtherCarrier' THEN [ELOG_IRBL].[OtherCarrier] END,
     CASE @OrderBy WHEN 'OtherCarrier DESC' THEN [ELOG_IRBL].[OtherCarrier] END DESC,
     CASE @OrderBy WHEN 'LocationCountryID' THEN [ELOG_IRBL].[LocationCountryID] END,
     CASE @OrderBy WHEN 'LocationCountryID DESC' THEN [ELOG_IRBL].[LocationCountryID] END DESC,
     CASE @OrderBy WHEN 'OtherCountry' THEN [ELOG_IRBL].[OtherCountry] END,
     CASE @OrderBy WHEN 'OtherCountry DESC' THEN [ELOG_IRBL].[OtherCountry] END DESC,
     CASE @OrderBy WHEN 'CargoTypeID' THEN [ELOG_IRBL].[CargoTypeID] END,
     CASE @OrderBy WHEN 'CargoTypeID DESC' THEN [ELOG_IRBL].[CargoTypeID] END DESC,
     CASE @OrderBy WHEN 'PortID' THEN [ELOG_IRBL].[PortID] END,
     CASE @OrderBy WHEN 'PortID DESC' THEN [ELOG_IRBL].[PortID] END DESC,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin DESC' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [ELOG_IRBL].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [ELOG_IRBL].[StatusID] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [ELOG_IRBL].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [ELOG_IRBL].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [ELOG_IRBL].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [ELOG_IRBL].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber' THEN [ELOG_BLHeader2].[BLNumber] END,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber DESC' THEN [ELOG_BLHeader2].[BLNumber] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description' THEN [ELOG_BLTypes3].[Description] END,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description DESC' THEN [ELOG_BLTypes3].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description' THEN [ELOG_CargoTypes4].[Description] END,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description DESC' THEN [ELOG_CargoTypes4].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description' THEN [ELOG_Carriers5].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description DESC' THEN [ELOG_Carriers5].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description' THEN [ELOG_LocationCountries6].[Description] END,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description DESC' THEN [ELOG_LocationCountries6].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description' THEN [ELOG_Ports7].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description DESC' THEN [ELOG_Ports7].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description' THEN [ELOG_ShipmentModes8].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description DESC' THEN [ELOG_ShipmentModes8].[Description] END DESC,
     CASE @OrderBy WHEN 'IDM_Projects9_Description' THEN [IDM_Projects9].[Description] END,
     CASE @OrderBy WHEN 'IDM_Projects9_Description DESC' THEN [IDM_Projects9].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName' THEN [VR_BusinessPartner10].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName DESC' THEN [VR_BusinessPartner10].[BPName] END DESC,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description' THEN [ELOG_IRBLStates11].[Description] END,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description DESC' THEN [ELOG_IRBLStates11].[Description] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLAutoCompleteList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLAutoCompleteList]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLAutoCompleteList]
  @LoginID NVarChar(8),
  @Prefix NVarChar(250),
  @Records Int,
  @ByCode Int 
  AS 
  BEGIN 
  DECLARE @Prefix1 VarChar(260)
  SET @Prefix1 = LOWER(@Prefix) + '%'
  DECLARE @LGSQL VarChar(8000)
  SET @LGSQL = 'SELECT TOP (' + STR(@Records) + ') ' 
  SET @LGSQL = @LGSQL + ' [ELOG_IRBL].[SupplierBillNo]' 
  SET @LGSQL = @LGSQL + ',[ELOG_IRBL].[IRNo]' 
  SET @LGSQL = @LGSQL + ' FROM [ELOG_IRBL] ' 
  SET @LGSQL = @LGSQL + ' WHERE 1 = 1 ' 
  SET @LGSQL = @LGSQL + ' AND (LTRIM(STR(ISNULL([ELOG_IRBL].[IRNo],0))) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ' OR LOWER(ISNULL([ELOG_IRBL].[SupplierBillNo],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ')' 
  
  EXEC (@LGSQL)
  END 
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLSelectByID]
  @LoginID NVarChar(8),
  @IRNo Int 
  AS
  SELECT
    [ELOG_IRBL].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [ELOG_BLHeader2].[BLNumber] AS ELOG_BLHeader2_BLNumber,
    [ELOG_BLTypes3].[Description] AS ELOG_BLTypes3_Description,
    [ELOG_CargoTypes4].[Description] AS ELOG_CargoTypes4_Description,
    [ELOG_Carriers5].[Description] AS ELOG_Carriers5_Description,
    [ELOG_LocationCountries6].[Description] AS ELOG_LocationCountries6_Description,
    [ELOG_Ports7].[Description] AS ELOG_Ports7_Description,
    [ELOG_ShipmentModes8].[Description] AS ELOG_ShipmentModes8_Description,
    [IDM_Projects9].[Description] AS IDM_Projects9_Description,
    [VR_BusinessPartner10].[BPName] AS VR_BusinessPartner10_BPName,
    [ELOG_IRBLStates11].[Description] AS ELOG_IRBLStates11_Description 
  FROM [ELOG_IRBL] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
  WHERE
  [ELOG_IRBL].[IRNo] = @IRNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLSelectByBLID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLSelectByBLID]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLSelectByBLID]
  @BLID NVarChar(9),
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [ELOG_IRBL].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [ELOG_BLHeader2].[BLNumber] AS ELOG_BLHeader2_BLNumber,
    [ELOG_BLTypes3].[Description] AS ELOG_BLTypes3_Description,
    [ELOG_CargoTypes4].[Description] AS ELOG_CargoTypes4_Description,
    [ELOG_Carriers5].[Description] AS ELOG_Carriers5_Description,
    [ELOG_LocationCountries6].[Description] AS ELOG_LocationCountries6_Description,
    [ELOG_Ports7].[Description] AS ELOG_Ports7_Description,
    [ELOG_ShipmentModes8].[Description] AS ELOG_ShipmentModes8_Description,
    [IDM_Projects9].[Description] AS IDM_Projects9_Description,
    [VR_BusinessPartner10].[BPName] AS VR_BusinessPartner10_BPName,
    [ELOG_IRBLStates11].[Description] AS ELOG_IRBLStates11_Description 
  FROM [ELOG_IRBL] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
  WHERE
  [ELOG_IRBL].[BLID] = @BLID
  ORDER BY
     CASE @OrderBy WHEN 'IRNo' THEN [ELOG_IRBL].[IRNo] END,
     CASE @OrderBy WHEN 'IRNo DESC' THEN [ELOG_IRBL].[IRNo] END DESC,
     CASE @OrderBy WHEN 'SupplierID' THEN [ELOG_IRBL].[SupplierID] END,
     CASE @OrderBy WHEN 'SupplierID DESC' THEN [ELOG_IRBL].[SupplierID] END DESC,
     CASE @OrderBy WHEN 'ProjectID' THEN [ELOG_IRBL].[ProjectID] END,
     CASE @OrderBy WHEN 'ProjectID DESC' THEN [ELOG_IRBL].[ProjectID] END DESC,
     CASE @OrderBy WHEN 'PONo' THEN [ELOG_IRBL].[PONo] END,
     CASE @OrderBy WHEN 'PONo DESC' THEN [ELOG_IRBL].[PONo] END DESC,
     CASE @OrderBy WHEN 'SupplierBillNo' THEN [ELOG_IRBL].[SupplierBillNo] END,
     CASE @OrderBy WHEN 'SupplierBillNo DESC' THEN [ELOG_IRBL].[SupplierBillNo] END DESC,
     CASE @OrderBy WHEN 'supplierBillDate' THEN [ELOG_IRBL].[supplierBillDate] END,
     CASE @OrderBy WHEN 'supplierBillDate DESC' THEN [ELOG_IRBL].[supplierBillDate] END DESC,
     CASE @OrderBy WHEN 'SupplierBillAmount' THEN [ELOG_IRBL].[SupplierBillAmount] END,
     CASE @OrderBy WHEN 'SupplierBillAmount DESC' THEN [ELOG_IRBL].[SupplierBillAmount] END DESC,
     CASE @OrderBy WHEN 'IRDate' THEN [ELOG_IRBL].[IRDate] END,
     CASE @OrderBy WHEN 'IRDate DESC' THEN [ELOG_IRBL].[IRDate] END DESC,
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_IRBL].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_IRBL].[BLID] END DESC,
     CASE @OrderBy WHEN 'BLType' THEN [ELOG_IRBL].[BLType] END,
     CASE @OrderBy WHEN 'BLType DESC' THEN [ELOG_IRBL].[BLType] END DESC,
     CASE @OrderBy WHEN 'MBLNo' THEN [ELOG_IRBL].[MBLNo] END,
     CASE @OrderBy WHEN 'MBLNo DESC' THEN [ELOG_IRBL].[MBLNo] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [ELOG_IRBL].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [ELOG_IRBL].[Remarks] END DESC,
     CASE @OrderBy WHEN 'ShipmentModeID' THEN [ELOG_IRBL].[ShipmentModeID] END,
     CASE @OrderBy WHEN 'ShipmentModeID DESC' THEN [ELOG_IRBL].[ShipmentModeID] END DESC,
     CASE @OrderBy WHEN 'CarrierID' THEN [ELOG_IRBL].[CarrierID] END,
     CASE @OrderBy WHEN 'CarrierID DESC' THEN [ELOG_IRBL].[CarrierID] END DESC,
     CASE @OrderBy WHEN 'OtherCarrier' THEN [ELOG_IRBL].[OtherCarrier] END,
     CASE @OrderBy WHEN 'OtherCarrier DESC' THEN [ELOG_IRBL].[OtherCarrier] END DESC,
     CASE @OrderBy WHEN 'LocationCountryID' THEN [ELOG_IRBL].[LocationCountryID] END,
     CASE @OrderBy WHEN 'LocationCountryID DESC' THEN [ELOG_IRBL].[LocationCountryID] END DESC,
     CASE @OrderBy WHEN 'OtherCountry' THEN [ELOG_IRBL].[OtherCountry] END,
     CASE @OrderBy WHEN 'OtherCountry DESC' THEN [ELOG_IRBL].[OtherCountry] END DESC,
     CASE @OrderBy WHEN 'CargoTypeID' THEN [ELOG_IRBL].[CargoTypeID] END,
     CASE @OrderBy WHEN 'CargoTypeID DESC' THEN [ELOG_IRBL].[CargoTypeID] END DESC,
     CASE @OrderBy WHEN 'PortID' THEN [ELOG_IRBL].[PortID] END,
     CASE @OrderBy WHEN 'PortID DESC' THEN [ELOG_IRBL].[PortID] END DESC,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin DESC' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [ELOG_IRBL].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [ELOG_IRBL].[StatusID] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [ELOG_IRBL].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [ELOG_IRBL].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [ELOG_IRBL].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [ELOG_IRBL].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber' THEN [ELOG_BLHeader2].[BLNumber] END,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber DESC' THEN [ELOG_BLHeader2].[BLNumber] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description' THEN [ELOG_BLTypes3].[Description] END,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description DESC' THEN [ELOG_BLTypes3].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description' THEN [ELOG_CargoTypes4].[Description] END,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description DESC' THEN [ELOG_CargoTypes4].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description' THEN [ELOG_Carriers5].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description DESC' THEN [ELOG_Carriers5].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description' THEN [ELOG_LocationCountries6].[Description] END,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description DESC' THEN [ELOG_LocationCountries6].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description' THEN [ELOG_Ports7].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description DESC' THEN [ELOG_Ports7].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description' THEN [ELOG_ShipmentModes8].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description DESC' THEN [ELOG_ShipmentModes8].[Description] END DESC,
     CASE @OrderBy WHEN 'IDM_Projects9_Description' THEN [IDM_Projects9].[Description] END,
     CASE @OrderBy WHEN 'IDM_Projects9_Description DESC' THEN [IDM_Projects9].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName' THEN [VR_BusinessPartner10].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName DESC' THEN [VR_BusinessPartner10].[BPName] END DESC,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description' THEN [ELOG_IRBLStates11].[Description] END,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description DESC' THEN [ELOG_IRBLStates11].[Description] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,IRNo Int NOT NULL
  )
  INSERT INTO #PageIndex (IRNo)
  SELECT [ELOG_IRBL].[IRNo] FROM [ELOG_IRBL]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
 WHERE  
   ( 
         STR(ISNULL([ELOG_IRBL].[IRNo], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[SupplierID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[ProjectID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[PONo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[SupplierBillNo],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[SupplierBillAmount], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[BLID],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[BLType], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[MBLNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[Remarks],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[ShipmentModeID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[CarrierID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[OtherCarrier],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[LocationCountryID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[OtherCountry],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[CargoTypeID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[PortID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[OtherPortLoadingOrigin],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBL].[StatusID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBL].[CreatedBy],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'IRNo' THEN [ELOG_IRBL].[IRNo] END,
     CASE @OrderBy WHEN 'IRNo DESC' THEN [ELOG_IRBL].[IRNo] END DESC,
     CASE @OrderBy WHEN 'SupplierID' THEN [ELOG_IRBL].[SupplierID] END,
     CASE @OrderBy WHEN 'SupplierID DESC' THEN [ELOG_IRBL].[SupplierID] END DESC,
     CASE @OrderBy WHEN 'ProjectID' THEN [ELOG_IRBL].[ProjectID] END,
     CASE @OrderBy WHEN 'ProjectID DESC' THEN [ELOG_IRBL].[ProjectID] END DESC,
     CASE @OrderBy WHEN 'PONo' THEN [ELOG_IRBL].[PONo] END,
     CASE @OrderBy WHEN 'PONo DESC' THEN [ELOG_IRBL].[PONo] END DESC,
     CASE @OrderBy WHEN 'SupplierBillNo' THEN [ELOG_IRBL].[SupplierBillNo] END,
     CASE @OrderBy WHEN 'SupplierBillNo DESC' THEN [ELOG_IRBL].[SupplierBillNo] END DESC,
     CASE @OrderBy WHEN 'supplierBillDate' THEN [ELOG_IRBL].[supplierBillDate] END,
     CASE @OrderBy WHEN 'supplierBillDate DESC' THEN [ELOG_IRBL].[supplierBillDate] END DESC,
     CASE @OrderBy WHEN 'SupplierBillAmount' THEN [ELOG_IRBL].[SupplierBillAmount] END,
     CASE @OrderBy WHEN 'SupplierBillAmount DESC' THEN [ELOG_IRBL].[SupplierBillAmount] END DESC,
     CASE @OrderBy WHEN 'IRDate' THEN [ELOG_IRBL].[IRDate] END,
     CASE @OrderBy WHEN 'IRDate DESC' THEN [ELOG_IRBL].[IRDate] END DESC,
     CASE @OrderBy WHEN 'BLID' THEN [ELOG_IRBL].[BLID] END,
     CASE @OrderBy WHEN 'BLID DESC' THEN [ELOG_IRBL].[BLID] END DESC,
     CASE @OrderBy WHEN 'BLType' THEN [ELOG_IRBL].[BLType] END,
     CASE @OrderBy WHEN 'BLType DESC' THEN [ELOG_IRBL].[BLType] END DESC,
     CASE @OrderBy WHEN 'MBLNo' THEN [ELOG_IRBL].[MBLNo] END,
     CASE @OrderBy WHEN 'MBLNo DESC' THEN [ELOG_IRBL].[MBLNo] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [ELOG_IRBL].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [ELOG_IRBL].[Remarks] END DESC,
     CASE @OrderBy WHEN 'ShipmentModeID' THEN [ELOG_IRBL].[ShipmentModeID] END,
     CASE @OrderBy WHEN 'ShipmentModeID DESC' THEN [ELOG_IRBL].[ShipmentModeID] END DESC,
     CASE @OrderBy WHEN 'CarrierID' THEN [ELOG_IRBL].[CarrierID] END,
     CASE @OrderBy WHEN 'CarrierID DESC' THEN [ELOG_IRBL].[CarrierID] END DESC,
     CASE @OrderBy WHEN 'OtherCarrier' THEN [ELOG_IRBL].[OtherCarrier] END,
     CASE @OrderBy WHEN 'OtherCarrier DESC' THEN [ELOG_IRBL].[OtherCarrier] END DESC,
     CASE @OrderBy WHEN 'LocationCountryID' THEN [ELOG_IRBL].[LocationCountryID] END,
     CASE @OrderBy WHEN 'LocationCountryID DESC' THEN [ELOG_IRBL].[LocationCountryID] END DESC,
     CASE @OrderBy WHEN 'OtherCountry' THEN [ELOG_IRBL].[OtherCountry] END,
     CASE @OrderBy WHEN 'OtherCountry DESC' THEN [ELOG_IRBL].[OtherCountry] END DESC,
     CASE @OrderBy WHEN 'CargoTypeID' THEN [ELOG_IRBL].[CargoTypeID] END,
     CASE @OrderBy WHEN 'CargoTypeID DESC' THEN [ELOG_IRBL].[CargoTypeID] END DESC,
     CASE @OrderBy WHEN 'PortID' THEN [ELOG_IRBL].[PortID] END,
     CASE @OrderBy WHEN 'PortID DESC' THEN [ELOG_IRBL].[PortID] END DESC,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END,
     CASE @OrderBy WHEN 'OtherPortLoadingOrigin DESC' THEN [ELOG_IRBL].[OtherPortLoadingOrigin] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [ELOG_IRBL].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [ELOG_IRBL].[StatusID] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [ELOG_IRBL].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [ELOG_IRBL].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [ELOG_IRBL].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [ELOG_IRBL].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber' THEN [ELOG_BLHeader2].[BLNumber] END,
     CASE @OrderBy WHEN 'ELOG_BLHeader2_BLNumber DESC' THEN [ELOG_BLHeader2].[BLNumber] END DESC,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description' THEN [ELOG_BLTypes3].[Description] END,
     CASE @OrderBy WHEN 'ELOG_BLTypes3_Description DESC' THEN [ELOG_BLTypes3].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description' THEN [ELOG_CargoTypes4].[Description] END,
     CASE @OrderBy WHEN 'ELOG_CargoTypes4_Description DESC' THEN [ELOG_CargoTypes4].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description' THEN [ELOG_Carriers5].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Carriers5_Description DESC' THEN [ELOG_Carriers5].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description' THEN [ELOG_LocationCountries6].[Description] END,
     CASE @OrderBy WHEN 'ELOG_LocationCountries6_Description DESC' THEN [ELOG_LocationCountries6].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description' THEN [ELOG_Ports7].[Description] END,
     CASE @OrderBy WHEN 'ELOG_Ports7_Description DESC' THEN [ELOG_Ports7].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description' THEN [ELOG_ShipmentModes8].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ShipmentModes8_Description DESC' THEN [ELOG_ShipmentModes8].[Description] END DESC,
     CASE @OrderBy WHEN 'IDM_Projects9_Description' THEN [IDM_Projects9].[Description] END,
     CASE @OrderBy WHEN 'IDM_Projects9_Description DESC' THEN [IDM_Projects9].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName' THEN [VR_BusinessPartner10].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner10_BPName DESC' THEN [VR_BusinessPartner10].[BPName] END DESC,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description' THEN [ELOG_IRBLStates11].[Description] END,
     CASE @OrderBy WHEN 'ELOG_IRBLStates11_Description DESC' THEN [ELOG_IRBLStates11].[Description] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [ELOG_IRBL].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [ELOG_BLHeader2].[BLNumber] AS ELOG_BLHeader2_BLNumber,
    [ELOG_BLTypes3].[Description] AS ELOG_BLTypes3_Description,
    [ELOG_CargoTypes4].[Description] AS ELOG_CargoTypes4_Description,
    [ELOG_Carriers5].[Description] AS ELOG_Carriers5_Description,
    [ELOG_LocationCountries6].[Description] AS ELOG_LocationCountries6_Description,
    [ELOG_Ports7].[Description] AS ELOG_Ports7_Description,
    [ELOG_ShipmentModes8].[Description] AS ELOG_ShipmentModes8_Description,
    [IDM_Projects9].[Description] AS IDM_Projects9_Description,
    [VR_BusinessPartner10].[BPName] AS VR_BusinessPartner10_BPName,
    [ELOG_IRBLStates11].[Description] AS ELOG_IRBLStates11_Description 
  FROM [ELOG_IRBL] 
      INNER JOIN #PageIndex
          ON [ELOG_IRBL].[IRNo] = #PageIndex.IRNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLSelectListFilteres]
  @Filter_SupplierID NVarChar(9),
  @Filter_ProjectID NVarChar(6),
  @Filter_BLID NVarChar(9),
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,IRNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'IRNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[ELOG_IRBL].[IRNo]'
  SET @LGSQL = @LGSQL + ' FROM [ELOG_IRBL] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  IF (@Filter_SupplierID > '') 
    SET @LGSQL = @LGSQL + ' AND [ELOG_IRBL].[SupplierID] = ''' + @Filter_SupplierID + ''''
  IF (@Filter_ProjectID > '') 
    SET @LGSQL = @LGSQL + ' AND [ELOG_IRBL].[ProjectID] = ''' + @Filter_ProjectID + ''''
  IF (@Filter_BLID > '') 
    SET @LGSQL = @LGSQL + ' AND [ELOG_IRBL].[BLID] = ''' + @Filter_BLID + ''''
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'IRNo' THEN '[ELOG_IRBL].[IRNo]'
                        WHEN 'IRNo DESC' THEN '[ELOG_IRBL].[IRNo] DESC'
                        WHEN 'SupplierID' THEN '[ELOG_IRBL].[SupplierID]'
                        WHEN 'SupplierID DESC' THEN '[ELOG_IRBL].[SupplierID] DESC'
                        WHEN 'ProjectID' THEN '[ELOG_IRBL].[ProjectID]'
                        WHEN 'ProjectID DESC' THEN '[ELOG_IRBL].[ProjectID] DESC'
                        WHEN 'PONo' THEN '[ELOG_IRBL].[PONo]'
                        WHEN 'PONo DESC' THEN '[ELOG_IRBL].[PONo] DESC'
                        WHEN 'SupplierBillNo' THEN '[ELOG_IRBL].[SupplierBillNo]'
                        WHEN 'SupplierBillNo DESC' THEN '[ELOG_IRBL].[SupplierBillNo] DESC'
                        WHEN 'supplierBillDate' THEN '[ELOG_IRBL].[supplierBillDate]'
                        WHEN 'supplierBillDate DESC' THEN '[ELOG_IRBL].[supplierBillDate] DESC'
                        WHEN 'SupplierBillAmount' THEN '[ELOG_IRBL].[SupplierBillAmount]'
                        WHEN 'SupplierBillAmount DESC' THEN '[ELOG_IRBL].[SupplierBillAmount] DESC'
                        WHEN 'IRDate' THEN '[ELOG_IRBL].[IRDate]'
                        WHEN 'IRDate DESC' THEN '[ELOG_IRBL].[IRDate] DESC'
                        WHEN 'BLID' THEN '[ELOG_IRBL].[BLID]'
                        WHEN 'BLID DESC' THEN '[ELOG_IRBL].[BLID] DESC'
                        WHEN 'BLType' THEN '[ELOG_IRBL].[BLType]'
                        WHEN 'BLType DESC' THEN '[ELOG_IRBL].[BLType] DESC'
                        WHEN 'MBLNo' THEN '[ELOG_IRBL].[MBLNo]'
                        WHEN 'MBLNo DESC' THEN '[ELOG_IRBL].[MBLNo] DESC'
                        WHEN 'Remarks' THEN '[ELOG_IRBL].[Remarks]'
                        WHEN 'Remarks DESC' THEN '[ELOG_IRBL].[Remarks] DESC'
                        WHEN 'ShipmentModeID' THEN '[ELOG_IRBL].[ShipmentModeID]'
                        WHEN 'ShipmentModeID DESC' THEN '[ELOG_IRBL].[ShipmentModeID] DESC'
                        WHEN 'CarrierID' THEN '[ELOG_IRBL].[CarrierID]'
                        WHEN 'CarrierID DESC' THEN '[ELOG_IRBL].[CarrierID] DESC'
                        WHEN 'OtherCarrier' THEN '[ELOG_IRBL].[OtherCarrier]'
                        WHEN 'OtherCarrier DESC' THEN '[ELOG_IRBL].[OtherCarrier] DESC'
                        WHEN 'LocationCountryID' THEN '[ELOG_IRBL].[LocationCountryID]'
                        WHEN 'LocationCountryID DESC' THEN '[ELOG_IRBL].[LocationCountryID] DESC'
                        WHEN 'OtherCountry' THEN '[ELOG_IRBL].[OtherCountry]'
                        WHEN 'OtherCountry DESC' THEN '[ELOG_IRBL].[OtherCountry] DESC'
                        WHEN 'CargoTypeID' THEN '[ELOG_IRBL].[CargoTypeID]'
                        WHEN 'CargoTypeID DESC' THEN '[ELOG_IRBL].[CargoTypeID] DESC'
                        WHEN 'PortID' THEN '[ELOG_IRBL].[PortID]'
                        WHEN 'PortID DESC' THEN '[ELOG_IRBL].[PortID] DESC'
                        WHEN 'OtherPortLoadingOrigin' THEN '[ELOG_IRBL].[OtherPortLoadingOrigin]'
                        WHEN 'OtherPortLoadingOrigin DESC' THEN '[ELOG_IRBL].[OtherPortLoadingOrigin] DESC'
                        WHEN 'StatusID' THEN '[ELOG_IRBL].[StatusID]'
                        WHEN 'StatusID DESC' THEN '[ELOG_IRBL].[StatusID] DESC'
                        WHEN 'CreatedOn' THEN '[ELOG_IRBL].[CreatedOn]'
                        WHEN 'CreatedOn DESC' THEN '[ELOG_IRBL].[CreatedOn] DESC'
                        WHEN 'CreatedBy' THEN '[ELOG_IRBL].[CreatedBy]'
                        WHEN 'CreatedBy DESC' THEN '[ELOG_IRBL].[CreatedBy] DESC'
                        WHEN 'aspnet_Users1_UserFullName' THEN '[aspnet_Users1].[UserFullName]'
                        WHEN 'aspnet_Users1_UserFullName DESC' THEN '[aspnet_Users1].[UserFullName] DESC'
                        WHEN 'ELOG_BLHeader2_BLNumber' THEN '[ELOG_BLHeader2].[BLNumber]'
                        WHEN 'ELOG_BLHeader2_BLNumber DESC' THEN '[ELOG_BLHeader2].[BLNumber] DESC'
                        WHEN 'ELOG_BLTypes3_Description' THEN '[ELOG_BLTypes3].[Description]'
                        WHEN 'ELOG_BLTypes3_Description DESC' THEN '[ELOG_BLTypes3].[Description] DESC'
                        WHEN 'ELOG_CargoTypes4_Description' THEN '[ELOG_CargoTypes4].[Description]'
                        WHEN 'ELOG_CargoTypes4_Description DESC' THEN '[ELOG_CargoTypes4].[Description] DESC'
                        WHEN 'ELOG_Carriers5_Description' THEN '[ELOG_Carriers5].[Description]'
                        WHEN 'ELOG_Carriers5_Description DESC' THEN '[ELOG_Carriers5].[Description] DESC'
                        WHEN 'ELOG_LocationCountries6_Description' THEN '[ELOG_LocationCountries6].[Description]'
                        WHEN 'ELOG_LocationCountries6_Description DESC' THEN '[ELOG_LocationCountries6].[Description] DESC'
                        WHEN 'ELOG_Ports7_Description' THEN '[ELOG_Ports7].[Description]'
                        WHEN 'ELOG_Ports7_Description DESC' THEN '[ELOG_Ports7].[Description] DESC'
                        WHEN 'ELOG_ShipmentModes8_Description' THEN '[ELOG_ShipmentModes8].[Description]'
                        WHEN 'ELOG_ShipmentModes8_Description DESC' THEN '[ELOG_ShipmentModes8].[Description] DESC'
                        WHEN 'IDM_Projects9_Description' THEN '[IDM_Projects9].[Description]'
                        WHEN 'IDM_Projects9_Description DESC' THEN '[IDM_Projects9].[Description] DESC'
                        WHEN 'VR_BusinessPartner10_BPName' THEN '[VR_BusinessPartner10].[BPName]'
                        WHEN 'VR_BusinessPartner10_BPName DESC' THEN '[VR_BusinessPartner10].[BPName] DESC'
                        WHEN 'ELOG_IRBLStates11_Description' THEN '[ELOG_IRBLStates11].[Description]'
                        WHEN 'ELOG_IRBLStates11_Description DESC' THEN '[ELOG_IRBLStates11].[Description] DESC'
                        ELSE '[ELOG_IRBL].[IRNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [ELOG_IRBL].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [ELOG_BLHeader2].[BLNumber] AS ELOG_BLHeader2_BLNumber,
    [ELOG_BLTypes3].[Description] AS ELOG_BLTypes3_Description,
    [ELOG_CargoTypes4].[Description] AS ELOG_CargoTypes4_Description,
    [ELOG_Carriers5].[Description] AS ELOG_Carriers5_Description,
    [ELOG_LocationCountries6].[Description] AS ELOG_LocationCountries6_Description,
    [ELOG_Ports7].[Description] AS ELOG_Ports7_Description,
    [ELOG_ShipmentModes8].[Description] AS ELOG_ShipmentModes8_Description,
    [IDM_Projects9].[Description] AS IDM_Projects9_Description,
    [VR_BusinessPartner10].[BPName] AS VR_BusinessPartner10_BPName,
    [ELOG_IRBLStates11].[Description] AS ELOG_IRBLStates11_Description 
  FROM [ELOG_IRBL] 
      INNER JOIN #PageIndex
          ON [ELOG_IRBL].[IRNo] = #PageIndex.IRNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [ELOG_IRBL].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [ELOG_BLHeader] AS [ELOG_BLHeader2]
    ON [ELOG_IRBL].[BLID] = [ELOG_BLHeader2].[BLID]
  LEFT OUTER JOIN [ELOG_BLTypes] AS [ELOG_BLTypes3]
    ON [ELOG_IRBL].[BLType] = [ELOG_BLTypes3].[BLTypeID]
  LEFT OUTER JOIN [ELOG_CargoTypes] AS [ELOG_CargoTypes4]
    ON [ELOG_IRBL].[CargoTypeID] = [ELOG_CargoTypes4].[CargoTypeID]
  LEFT OUTER JOIN [ELOG_Carriers] AS [ELOG_Carriers5]
    ON [ELOG_IRBL].[CarrierID] = [ELOG_Carriers5].[CarrierID]
  LEFT OUTER JOIN [ELOG_LocationCountries] AS [ELOG_LocationCountries6]
    ON [ELOG_IRBL].[LocationCountryID] = [ELOG_LocationCountries6].[LocationCountryID]
  LEFT OUTER JOIN [ELOG_Ports] AS [ELOG_Ports7]
    ON [ELOG_IRBL].[PortID] = [ELOG_Ports7].[PortID]
  LEFT OUTER JOIN [ELOG_ShipmentModes] AS [ELOG_ShipmentModes8]
    ON [ELOG_IRBL].[ShipmentModeID] = [ELOG_ShipmentModes8].[ShipmentModeID]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects9]
    ON [ELOG_IRBL].[ProjectID] = [IDM_Projects9].[ProjectID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner10]
    ON [ELOG_IRBL].[SupplierID] = [VR_BusinessPartner10].[BPID]
  LEFT OUTER JOIN [ELOG_IRBLStates] AS [ELOG_IRBLStates11]
    ON [ELOG_IRBL].[StatusID] = [ELOG_IRBLStates11].[StatusID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLInsert]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLInsert]
  @IRNo Int,
  @SupplierID NVarChar(9),
  @ProjectID NVarChar(6),
  @PONo NVarChar(9),
  @SupplierBillNo NVarChar(50),
  @supplierBillDate DateTime,
  @SupplierBillAmount Decimal(18,2),
  @IRDate DateTime,
  @BLID NVarChar(9),
  @BLType Int,
  @MBLNo NVarChar(50),
  @Remarks NVarChar(500),
  @ShipmentModeID Int,
  @CarrierID Int,
  @OtherCarrier NVarChar(100),
  @LocationCountryID Int,
  @OtherCountry NVarChar(100),
  @CargoTypeID Int,
  @PortID Int,
  @OtherPortLoadingOrigin NVarChar(100),
  @StatusID Int,
  @CreatedOn DateTime,
  @CreatedBy NVarChar(8),
  @Return_IRNo Int = null OUTPUT 
  AS
  INSERT [ELOG_IRBL]
  (
   [IRNo]
  ,[SupplierID]
  ,[ProjectID]
  ,[PONo]
  ,[SupplierBillNo]
  ,[supplierBillDate]
  ,[SupplierBillAmount]
  ,[IRDate]
  ,[BLID]
  ,[BLType]
  ,[MBLNo]
  ,[Remarks]
  ,[ShipmentModeID]
  ,[CarrierID]
  ,[OtherCarrier]
  ,[LocationCountryID]
  ,[OtherCountry]
  ,[CargoTypeID]
  ,[PortID]
  ,[OtherPortLoadingOrigin]
  ,[StatusID]
  ,[CreatedOn]
  ,[CreatedBy]
  )
  VALUES
  (
   @IRNo
  ,@SupplierID
  ,@ProjectID
  ,@PONo
  ,@SupplierBillNo
  ,@supplierBillDate
  ,@SupplierBillAmount
  ,@IRDate
  ,@BLID
  ,@BLType
  ,@MBLNo
  ,@Remarks
  ,@ShipmentModeID
  ,@CarrierID
  ,@OtherCarrier
  ,@LocationCountryID
  ,@OtherCountry
  ,@CargoTypeID
  ,@PortID
  ,@OtherPortLoadingOrigin
  ,@StatusID
  ,@CreatedOn
  ,@CreatedBy
  )
  SET @Return_IRNo = @IRNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLUpdate]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLUpdate]
  @Original_IRNo Int, 
  @IRNo Int,
  @SupplierID NVarChar(9),
  @ProjectID NVarChar(6),
  @PONo NVarChar(9),
  @SupplierBillNo NVarChar(50),
  @supplierBillDate DateTime,
  @SupplierBillAmount Decimal(18,2),
  @IRDate DateTime,
  @BLID NVarChar(9),
  @BLType Int,
  @MBLNo NVarChar(50),
  @Remarks NVarChar(500),
  @ShipmentModeID Int,
  @CarrierID Int,
  @OtherCarrier NVarChar(100),
  @LocationCountryID Int,
  @OtherCountry NVarChar(100),
  @CargoTypeID Int,
  @PortID Int,
  @OtherPortLoadingOrigin NVarChar(100),
  @StatusID Int,
  @CreatedOn DateTime,
  @CreatedBy NVarChar(8),
  @RowCount int = null OUTPUT
  AS
  UPDATE [ELOG_IRBL] SET 
   [IRNo] = @IRNo
  ,[SupplierID] = @SupplierID
  ,[ProjectID] = @ProjectID
  ,[PONo] = @PONo
  ,[SupplierBillNo] = @SupplierBillNo
  ,[supplierBillDate] = @supplierBillDate
  ,[SupplierBillAmount] = @SupplierBillAmount
  ,[IRDate] = @IRDate
  ,[BLID] = @BLID
  ,[BLType] = @BLType
  ,[MBLNo] = @MBLNo
  ,[Remarks] = @Remarks
  ,[ShipmentModeID] = @ShipmentModeID
  ,[CarrierID] = @CarrierID
  ,[OtherCarrier] = @OtherCarrier
  ,[LocationCountryID] = @LocationCountryID
  ,[OtherCountry] = @OtherCountry
  ,[CargoTypeID] = @CargoTypeID
  ,[PortID] = @PortID
  ,[OtherPortLoadingOrigin] = @OtherPortLoadingOrigin
  ,[StatusID] = @StatusID
  ,[CreatedOn] = @CreatedOn
  ,[CreatedBy] = @CreatedBy
  WHERE
  [IRNo] = @Original_IRNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDelete]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDelete]
  @Original_IRNo Int,
  @RowCount int = null OUTPUT
  AS
  DELETE [ELOG_IRBL]
  WHERE
  [ELOG_IRBL].[IRNo] = @Original_IRNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsSelectByID]
  @LoginID NVarChar(8),
  @IRNo Int,
  @SerialNo Int 
  AS
  SELECT
    [ELOG_IRBLDetails].* ,
    [ELOG_BreakbulkTypes1].[Description] AS ELOG_BreakbulkTypes1_Description,
    [ELOG_ChargeCategories2].[Description] AS ELOG_ChargeCategories2_Description,
    [ELOG_ChargeCodes3].[Description] AS ELOG_ChargeCodes3_Description,
    [ELOG_ChargeTypes4].[Description] AS ELOG_ChargeTypes4_Description,
    [ELOG_ICDCFSs5].[Description] AS ELOG_ICDCFSs5_Description,
    [ELOG_IRBL6].[SupplierBillNo] AS ELOG_IRBL6_SupplierBillNo,
    [ELOG_StuffingPoints7].[Description] AS ELOG_StuffingPoints7_Description,
    [ELOG_StuffingTypes8].[Description] AS ELOG_StuffingTypes8_Description 
  FROM [ELOG_IRBLDetails] 
  LEFT OUTER JOIN [ELOG_BreakbulkTypes] AS [ELOG_BreakbulkTypes1]
    ON [ELOG_IRBLDetails].[BreakBulkID] = [ELOG_BreakbulkTypes1].[BreakbulkTypeID]
  LEFT OUTER JOIN [ELOG_ChargeCategories] AS [ELOG_ChargeCategories2]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCategories2].[ChargeCategoryID]
  LEFT OUTER JOIN [ELOG_ChargeCodes] AS [ELOG_ChargeCodes3]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCodes3].[ChargeCategoryID]
    AND [ELOG_IRBLDetails].[ChargeCodeID] = [ELOG_ChargeCodes3].[ChargeCodeID]
  LEFT OUTER JOIN [ELOG_ChargeTypes] AS [ELOG_ChargeTypes4]
    ON [ELOG_IRBLDetails].[ChargeTypeID] = [ELOG_ChargeTypes4].[ChargeTypeID]
  LEFT OUTER JOIN [ELOG_ICDCFSs] AS [ELOG_ICDCFSs5]
    ON [ELOG_IRBLDetails].[ICDCFSID] = [ELOG_ICDCFSs5].[ICDCFSID]
  INNER JOIN [ELOG_IRBL] AS [ELOG_IRBL6]
    ON [ELOG_IRBLDetails].[IRNo] = [ELOG_IRBL6].[IRNo]
  LEFT OUTER JOIN [ELOG_StuffingPoints] AS [ELOG_StuffingPoints7]
    ON [ELOG_IRBLDetails].[StuffingPointID] = [ELOG_StuffingPoints7].[StuffingPointID]
  LEFT OUTER JOIN [ELOG_StuffingTypes] AS [ELOG_StuffingTypes8]
    ON [ELOG_IRBLDetails].[StuffingTypeID] = [ELOG_StuffingTypes8].[StuffingTypeID]
  WHERE
  [ELOG_IRBLDetails].[IRNo] = @IRNo
  AND [ELOG_IRBLDetails].[SerialNo] = @SerialNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,IRNo Int NOT NULL
 ,SerialNo Int NOT NULL
  )
  INSERT INTO #PageIndex (IRNo, SerialNo)
  SELECT [ELOG_IRBLDetails].[IRNo], [ELOG_IRBLDetails].[SerialNo] FROM [ELOG_IRBLDetails]
  LEFT OUTER JOIN [ELOG_BreakbulkTypes] AS [ELOG_BreakbulkTypes1]
    ON [ELOG_IRBLDetails].[BreakBulkID] = [ELOG_BreakbulkTypes1].[BreakbulkTypeID]
  LEFT OUTER JOIN [ELOG_ChargeCategories] AS [ELOG_ChargeCategories2]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCategories2].[ChargeCategoryID]
  LEFT OUTER JOIN [ELOG_ChargeCodes] AS [ELOG_ChargeCodes3]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCodes3].[ChargeCategoryID]
    AND [ELOG_IRBLDetails].[ChargeCodeID] = [ELOG_ChargeCodes3].[ChargeCodeID]
  LEFT OUTER JOIN [ELOG_ChargeTypes] AS [ELOG_ChargeTypes4]
    ON [ELOG_IRBLDetails].[ChargeTypeID] = [ELOG_ChargeTypes4].[ChargeTypeID]
  LEFT OUTER JOIN [ELOG_ICDCFSs] AS [ELOG_ICDCFSs5]
    ON [ELOG_IRBLDetails].[ICDCFSID] = [ELOG_ICDCFSs5].[ICDCFSID]
  INNER JOIN [ELOG_IRBL] AS [ELOG_IRBL6]
    ON [ELOG_IRBLDetails].[IRNo] = [ELOG_IRBL6].[IRNo]
  LEFT OUTER JOIN [ELOG_StuffingPoints] AS [ELOG_StuffingPoints7]
    ON [ELOG_IRBLDetails].[StuffingPointID] = [ELOG_StuffingPoints7].[StuffingPointID]
  LEFT OUTER JOIN [ELOG_StuffingTypes] AS [ELOG_StuffingTypes8]
    ON [ELOG_IRBLDetails].[StuffingTypeID] = [ELOG_StuffingTypes8].[StuffingTypeID]
 WHERE  
   ( 
         STR(ISNULL([ELOG_IRBLDetails].[IRNo], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[SerialNo], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[StuffingTypeID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[StuffingPointID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[ICDCFSID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBLDetails].[OtherICDCFS],'')) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[BreakBulkID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[ChargeTypeID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[ChargeCategoryID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[ChargeCodeID], 0)) LIKE @KeyWord1
     OR STR(ISNULL([ELOG_IRBLDetails].[Amount], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([ELOG_IRBLDetails].[Remarks],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'IRNo' THEN [ELOG_IRBLDetails].[IRNo] END,
     CASE @OrderBy WHEN 'IRNo DESC' THEN [ELOG_IRBLDetails].[IRNo] END DESC,
     CASE @OrderBy WHEN 'SerialNo' THEN [ELOG_IRBLDetails].[SerialNo] END,
     CASE @OrderBy WHEN 'SerialNo DESC' THEN [ELOG_IRBLDetails].[SerialNo] END DESC,
     CASE @OrderBy WHEN 'StuffingTypeID' THEN [ELOG_IRBLDetails].[StuffingTypeID] END,
     CASE @OrderBy WHEN 'StuffingTypeID DESC' THEN [ELOG_IRBLDetails].[StuffingTypeID] END DESC,
     CASE @OrderBy WHEN 'StuffingPointID' THEN [ELOG_IRBLDetails].[StuffingPointID] END,
     CASE @OrderBy WHEN 'StuffingPointID DESC' THEN [ELOG_IRBLDetails].[StuffingPointID] END DESC,
     CASE @OrderBy WHEN 'ICDCFSID' THEN [ELOG_IRBLDetails].[ICDCFSID] END,
     CASE @OrderBy WHEN 'ICDCFSID DESC' THEN [ELOG_IRBLDetails].[ICDCFSID] END DESC,
     CASE @OrderBy WHEN 'OtherICDCFS' THEN [ELOG_IRBLDetails].[OtherICDCFS] END,
     CASE @OrderBy WHEN 'OtherICDCFS DESC' THEN [ELOG_IRBLDetails].[OtherICDCFS] END DESC,
     CASE @OrderBy WHEN 'BreakBulkID' THEN [ELOG_IRBLDetails].[BreakBulkID] END,
     CASE @OrderBy WHEN 'BreakBulkID DESC' THEN [ELOG_IRBLDetails].[BreakBulkID] END DESC,
     CASE @OrderBy WHEN 'ChargeTypeID' THEN [ELOG_IRBLDetails].[ChargeTypeID] END,
     CASE @OrderBy WHEN 'ChargeTypeID DESC' THEN [ELOG_IRBLDetails].[ChargeTypeID] END DESC,
     CASE @OrderBy WHEN 'ChargeCategoryID' THEN [ELOG_IRBLDetails].[ChargeCategoryID] END,
     CASE @OrderBy WHEN 'ChargeCategoryID DESC' THEN [ELOG_IRBLDetails].[ChargeCategoryID] END DESC,
     CASE @OrderBy WHEN 'ChargeCodeID' THEN [ELOG_IRBLDetails].[ChargeCodeID] END,
     CASE @OrderBy WHEN 'ChargeCodeID DESC' THEN [ELOG_IRBLDetails].[ChargeCodeID] END DESC,
     CASE @OrderBy WHEN 'Amount' THEN [ELOG_IRBLDetails].[Amount] END,
     CASE @OrderBy WHEN 'Amount DESC' THEN [ELOG_IRBLDetails].[Amount] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [ELOG_IRBLDetails].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [ELOG_IRBLDetails].[Remarks] END DESC,
     CASE @OrderBy WHEN 'ELOG_BreakbulkTypes1_Description' THEN [ELOG_BreakbulkTypes1].[Description] END,
     CASE @OrderBy WHEN 'ELOG_BreakbulkTypes1_Description DESC' THEN [ELOG_BreakbulkTypes1].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ChargeCategories2_Description' THEN [ELOG_ChargeCategories2].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ChargeCategories2_Description DESC' THEN [ELOG_ChargeCategories2].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ChargeCodes3_Description' THEN [ELOG_ChargeCodes3].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ChargeCodes3_Description DESC' THEN [ELOG_ChargeCodes3].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ChargeTypes4_Description' THEN [ELOG_ChargeTypes4].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ChargeTypes4_Description DESC' THEN [ELOG_ChargeTypes4].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_ICDCFSs5_Description' THEN [ELOG_ICDCFSs5].[Description] END,
     CASE @OrderBy WHEN 'ELOG_ICDCFSs5_Description DESC' THEN [ELOG_ICDCFSs5].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_IRBL6_SupplierBillNo' THEN [ELOG_IRBL6].[SupplierBillNo] END,
     CASE @OrderBy WHEN 'ELOG_IRBL6_SupplierBillNo DESC' THEN [ELOG_IRBL6].[SupplierBillNo] END DESC,
     CASE @OrderBy WHEN 'ELOG_StuffingPoints7_Description' THEN [ELOG_StuffingPoints7].[Description] END,
     CASE @OrderBy WHEN 'ELOG_StuffingPoints7_Description DESC' THEN [ELOG_StuffingPoints7].[Description] END DESC,
     CASE @OrderBy WHEN 'ELOG_StuffingTypes8_Description' THEN [ELOG_StuffingTypes8].[Description] END,
     CASE @OrderBy WHEN 'ELOG_StuffingTypes8_Description DESC' THEN [ELOG_StuffingTypes8].[Description] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [ELOG_IRBLDetails].* ,
    [ELOG_BreakbulkTypes1].[Description] AS ELOG_BreakbulkTypes1_Description,
    [ELOG_ChargeCategories2].[Description] AS ELOG_ChargeCategories2_Description,
    [ELOG_ChargeCodes3].[Description] AS ELOG_ChargeCodes3_Description,
    [ELOG_ChargeTypes4].[Description] AS ELOG_ChargeTypes4_Description,
    [ELOG_ICDCFSs5].[Description] AS ELOG_ICDCFSs5_Description,
    [ELOG_IRBL6].[SupplierBillNo] AS ELOG_IRBL6_SupplierBillNo,
    [ELOG_StuffingPoints7].[Description] AS ELOG_StuffingPoints7_Description,
    [ELOG_StuffingTypes8].[Description] AS ELOG_StuffingTypes8_Description 
  FROM [ELOG_IRBLDetails] 
      INNER JOIN #PageIndex
          ON [ELOG_IRBLDetails].[IRNo] = #PageIndex.IRNo
          AND [ELOG_IRBLDetails].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [ELOG_BreakbulkTypes] AS [ELOG_BreakbulkTypes1]
    ON [ELOG_IRBLDetails].[BreakBulkID] = [ELOG_BreakbulkTypes1].[BreakbulkTypeID]
  LEFT OUTER JOIN [ELOG_ChargeCategories] AS [ELOG_ChargeCategories2]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCategories2].[ChargeCategoryID]
  LEFT OUTER JOIN [ELOG_ChargeCodes] AS [ELOG_ChargeCodes3]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCodes3].[ChargeCategoryID]
    AND [ELOG_IRBLDetails].[ChargeCodeID] = [ELOG_ChargeCodes3].[ChargeCodeID]
  LEFT OUTER JOIN [ELOG_ChargeTypes] AS [ELOG_ChargeTypes4]
    ON [ELOG_IRBLDetails].[ChargeTypeID] = [ELOG_ChargeTypes4].[ChargeTypeID]
  LEFT OUTER JOIN [ELOG_ICDCFSs] AS [ELOG_ICDCFSs5]
    ON [ELOG_IRBLDetails].[ICDCFSID] = [ELOG_ICDCFSs5].[ICDCFSID]
  INNER JOIN [ELOG_IRBL] AS [ELOG_IRBL6]
    ON [ELOG_IRBLDetails].[IRNo] = [ELOG_IRBL6].[IRNo]
  LEFT OUTER JOIN [ELOG_StuffingPoints] AS [ELOG_StuffingPoints7]
    ON [ELOG_IRBLDetails].[StuffingPointID] = [ELOG_StuffingPoints7].[StuffingPointID]
  LEFT OUTER JOIN [ELOG_StuffingTypes] AS [ELOG_StuffingTypes8]
    ON [ELOG_IRBLDetails].[StuffingTypeID] = [ELOG_StuffingTypes8].[StuffingTypeID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsSelectListFilteres]
  @Filter_IRNo Int,
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,IRNo Int NOT NULL
 ,SerialNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'IRNo'
  SET @LGSQL = @LGSQL + ', SerialNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[ELOG_IRBLDetails].[IRNo]'
  SET @LGSQL = @LGSQL + ', [ELOG_IRBLDetails].[SerialNo]'
  SET @LGSQL = @LGSQL + ' FROM [ELOG_IRBLDetails] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_BreakbulkTypes] AS [ELOG_BreakbulkTypes1]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[BreakBulkID] = [ELOG_BreakbulkTypes1].[BreakbulkTypeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_ChargeCategories] AS [ELOG_ChargeCategories2]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCategories2].[ChargeCategoryID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_ChargeCodes] AS [ELOG_ChargeCodes3]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCodes3].[ChargeCategoryID]'
  SET @LGSQL = @LGSQL + '    AND [ELOG_IRBLDetails].[ChargeCodeID] = [ELOG_ChargeCodes3].[ChargeCodeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_ChargeTypes] AS [ELOG_ChargeTypes4]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[ChargeTypeID] = [ELOG_ChargeTypes4].[ChargeTypeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_ICDCFSs] AS [ELOG_ICDCFSs5]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[ICDCFSID] = [ELOG_ICDCFSs5].[ICDCFSID]'
  SET @LGSQL = @LGSQL + '  INNER JOIN [ELOG_IRBL] AS [ELOG_IRBL6]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[IRNo] = [ELOG_IRBL6].[IRNo]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_StuffingPoints] AS [ELOG_StuffingPoints7]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[StuffingPointID] = [ELOG_StuffingPoints7].[StuffingPointID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [ELOG_StuffingTypes] AS [ELOG_StuffingTypes8]'
  SET @LGSQL = @LGSQL + '    ON [ELOG_IRBLDetails].[StuffingTypeID] = [ELOG_StuffingTypes8].[StuffingTypeID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  IF (@Filter_IRNo > 0) 
    SET @LGSQL = @LGSQL + ' AND [ELOG_IRBLDetails].[IRNo] = ' + STR(@Filter_IRNo)
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'IRNo' THEN '[ELOG_IRBLDetails].[IRNo]'
                        WHEN 'IRNo DESC' THEN '[ELOG_IRBLDetails].[IRNo] DESC'
                        WHEN 'SerialNo' THEN '[ELOG_IRBLDetails].[SerialNo]'
                        WHEN 'SerialNo DESC' THEN '[ELOG_IRBLDetails].[SerialNo] DESC'
                        WHEN 'StuffingTypeID' THEN '[ELOG_IRBLDetails].[StuffingTypeID]'
                        WHEN 'StuffingTypeID DESC' THEN '[ELOG_IRBLDetails].[StuffingTypeID] DESC'
                        WHEN 'StuffingPointID' THEN '[ELOG_IRBLDetails].[StuffingPointID]'
                        WHEN 'StuffingPointID DESC' THEN '[ELOG_IRBLDetails].[StuffingPointID] DESC'
                        WHEN 'ICDCFSID' THEN '[ELOG_IRBLDetails].[ICDCFSID]'
                        WHEN 'ICDCFSID DESC' THEN '[ELOG_IRBLDetails].[ICDCFSID] DESC'
                        WHEN 'OtherICDCFS' THEN '[ELOG_IRBLDetails].[OtherICDCFS]'
                        WHEN 'OtherICDCFS DESC' THEN '[ELOG_IRBLDetails].[OtherICDCFS] DESC'
                        WHEN 'BreakBulkID' THEN '[ELOG_IRBLDetails].[BreakBulkID]'
                        WHEN 'BreakBulkID DESC' THEN '[ELOG_IRBLDetails].[BreakBulkID] DESC'
                        WHEN 'ChargeTypeID' THEN '[ELOG_IRBLDetails].[ChargeTypeID]'
                        WHEN 'ChargeTypeID DESC' THEN '[ELOG_IRBLDetails].[ChargeTypeID] DESC'
                        WHEN 'ChargeCategoryID' THEN '[ELOG_IRBLDetails].[ChargeCategoryID]'
                        WHEN 'ChargeCategoryID DESC' THEN '[ELOG_IRBLDetails].[ChargeCategoryID] DESC'
                        WHEN 'ChargeCodeID' THEN '[ELOG_IRBLDetails].[ChargeCodeID]'
                        WHEN 'ChargeCodeID DESC' THEN '[ELOG_IRBLDetails].[ChargeCodeID] DESC'
                        WHEN 'Amount' THEN '[ELOG_IRBLDetails].[Amount]'
                        WHEN 'Amount DESC' THEN '[ELOG_IRBLDetails].[Amount] DESC'
                        WHEN 'Remarks' THEN '[ELOG_IRBLDetails].[Remarks]'
                        WHEN 'Remarks DESC' THEN '[ELOG_IRBLDetails].[Remarks] DESC'
                        WHEN 'ELOG_BreakbulkTypes1_Description' THEN '[ELOG_BreakbulkTypes1].[Description]'
                        WHEN 'ELOG_BreakbulkTypes1_Description DESC' THEN '[ELOG_BreakbulkTypes1].[Description] DESC'
                        WHEN 'ELOG_ChargeCategories2_Description' THEN '[ELOG_ChargeCategories2].[Description]'
                        WHEN 'ELOG_ChargeCategories2_Description DESC' THEN '[ELOG_ChargeCategories2].[Description] DESC'
                        WHEN 'ELOG_ChargeCodes3_Description' THEN '[ELOG_ChargeCodes3].[Description]'
                        WHEN 'ELOG_ChargeCodes3_Description DESC' THEN '[ELOG_ChargeCodes3].[Description] DESC'
                        WHEN 'ELOG_ChargeTypes4_Description' THEN '[ELOG_ChargeTypes4].[Description]'
                        WHEN 'ELOG_ChargeTypes4_Description DESC' THEN '[ELOG_ChargeTypes4].[Description] DESC'
                        WHEN 'ELOG_ICDCFSs5_Description' THEN '[ELOG_ICDCFSs5].[Description]'
                        WHEN 'ELOG_ICDCFSs5_Description DESC' THEN '[ELOG_ICDCFSs5].[Description] DESC'
                        WHEN 'ELOG_IRBL6_SupplierBillNo' THEN '[ELOG_IRBL6].[SupplierBillNo]'
                        WHEN 'ELOG_IRBL6_SupplierBillNo DESC' THEN '[ELOG_IRBL6].[SupplierBillNo] DESC'
                        WHEN 'ELOG_StuffingPoints7_Description' THEN '[ELOG_StuffingPoints7].[Description]'
                        WHEN 'ELOG_StuffingPoints7_Description DESC' THEN '[ELOG_StuffingPoints7].[Description] DESC'
                        WHEN 'ELOG_StuffingTypes8_Description' THEN '[ELOG_StuffingTypes8].[Description]'
                        WHEN 'ELOG_StuffingTypes8_Description DESC' THEN '[ELOG_StuffingTypes8].[Description] DESC'
                        ELSE '[ELOG_IRBLDetails].[IRNo],[ELOG_IRBLDetails].[SerialNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [ELOG_IRBLDetails].* ,
    [ELOG_BreakbulkTypes1].[Description] AS ELOG_BreakbulkTypes1_Description,
    [ELOG_ChargeCategories2].[Description] AS ELOG_ChargeCategories2_Description,
    [ELOG_ChargeCodes3].[Description] AS ELOG_ChargeCodes3_Description,
    [ELOG_ChargeTypes4].[Description] AS ELOG_ChargeTypes4_Description,
    [ELOG_ICDCFSs5].[Description] AS ELOG_ICDCFSs5_Description,
    [ELOG_IRBL6].[SupplierBillNo] AS ELOG_IRBL6_SupplierBillNo,
    [ELOG_StuffingPoints7].[Description] AS ELOG_StuffingPoints7_Description,
    [ELOG_StuffingTypes8].[Description] AS ELOG_StuffingTypes8_Description 
  FROM [ELOG_IRBLDetails] 
      INNER JOIN #PageIndex
          ON [ELOG_IRBLDetails].[IRNo] = #PageIndex.IRNo
          AND [ELOG_IRBLDetails].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [ELOG_BreakbulkTypes] AS [ELOG_BreakbulkTypes1]
    ON [ELOG_IRBLDetails].[BreakBulkID] = [ELOG_BreakbulkTypes1].[BreakbulkTypeID]
  LEFT OUTER JOIN [ELOG_ChargeCategories] AS [ELOG_ChargeCategories2]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCategories2].[ChargeCategoryID]
  LEFT OUTER JOIN [ELOG_ChargeCodes] AS [ELOG_ChargeCodes3]
    ON [ELOG_IRBLDetails].[ChargeCategoryID] = [ELOG_ChargeCodes3].[ChargeCategoryID]
    AND [ELOG_IRBLDetails].[ChargeCodeID] = [ELOG_ChargeCodes3].[ChargeCodeID]
  LEFT OUTER JOIN [ELOG_ChargeTypes] AS [ELOG_ChargeTypes4]
    ON [ELOG_IRBLDetails].[ChargeTypeID] = [ELOG_ChargeTypes4].[ChargeTypeID]
  LEFT OUTER JOIN [ELOG_ICDCFSs] AS [ELOG_ICDCFSs5]
    ON [ELOG_IRBLDetails].[ICDCFSID] = [ELOG_ICDCFSs5].[ICDCFSID]
  INNER JOIN [ELOG_IRBL] AS [ELOG_IRBL6]
    ON [ELOG_IRBLDetails].[IRNo] = [ELOG_IRBL6].[IRNo]
  LEFT OUTER JOIN [ELOG_StuffingPoints] AS [ELOG_StuffingPoints7]
    ON [ELOG_IRBLDetails].[StuffingPointID] = [ELOG_StuffingPoints7].[StuffingPointID]
  LEFT OUTER JOIN [ELOG_StuffingTypes] AS [ELOG_StuffingTypes8]
    ON [ELOG_IRBLDetails].[StuffingTypeID] = [ELOG_StuffingTypes8].[StuffingTypeID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsInsert]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsInsert]
  @IRNo Int,
  @StuffingTypeID Int,
  @StuffingPointID Int,
  @ICDCFSID Int,
  @OtherICDCFS NVarChar(100),
  @BreakBulkID Int,
  @ChargeTypeID Int,
  @ChargeCategoryID Int,
  @ChargeCodeID Int,
  @Amount Decimal(18,2),
  @Remarks NVarChar(500),
  @Return_IRNo Int = null OUTPUT, 
  @Return_SerialNo Int = null OUTPUT 
  AS
  INSERT [ELOG_IRBLDetails]
  (
   [IRNo]
  ,[StuffingTypeID]
  ,[StuffingPointID]
  ,[ICDCFSID]
  ,[OtherICDCFS]
  ,[BreakBulkID]
  ,[ChargeTypeID]
  ,[ChargeCategoryID]
  ,[ChargeCodeID]
  ,[Amount]
  ,[Remarks]
  )
  VALUES
  (
   @IRNo
  ,@StuffingTypeID
  ,@StuffingPointID
  ,@ICDCFSID
  ,@OtherICDCFS
  ,@BreakBulkID
  ,@ChargeTypeID
  ,@ChargeCategoryID
  ,@ChargeCodeID
  ,@Amount
  ,@Remarks
  )
  SET @Return_IRNo = @IRNo
  SET @Return_SerialNo = Scope_Identity()
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsUpdate]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsUpdate]
  @Original_IRNo Int, 
  @Original_SerialNo Int, 
  @IRNo Int,
  @StuffingTypeID Int,
  @StuffingPointID Int,
  @ICDCFSID Int,
  @OtherICDCFS NVarChar(100),
  @BreakBulkID Int,
  @ChargeTypeID Int,
  @ChargeCategoryID Int,
  @ChargeCodeID Int,
  @Amount Decimal(18,2),
  @Remarks NVarChar(500),
  @RowCount int = null OUTPUT
  AS
  UPDATE [ELOG_IRBLDetails] SET 
   [IRNo] = @IRNo
  ,[StuffingTypeID] = @StuffingTypeID
  ,[StuffingPointID] = @StuffingPointID
  ,[ICDCFSID] = @ICDCFSID
  ,[OtherICDCFS] = @OtherICDCFS
  ,[BreakBulkID] = @BreakBulkID
  ,[ChargeTypeID] = @ChargeTypeID
  ,[ChargeCategoryID] = @ChargeCategoryID
  ,[ChargeCodeID] = @ChargeCodeID
  ,[Amount] = @Amount
  ,[Remarks] = @Remarks
  WHERE
  [IRNo] = @Original_IRNo
  AND [SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spelogIRBLDetailsDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spelogIRBLDetailsDelete]
GO
 
CREATE PROCEDURE [dbo].[spelogIRBLDetailsDelete]
  @Original_IRNo Int,
  @Original_SerialNo Int,
  @RowCount int = null OUTPUT
  AS
  DELETE [ELOG_IRBLDetails]
  WHERE
  [ELOG_IRBLDetails].[IRNo] = @Original_IRNo
  AND [ELOG_IRBLDetails].[SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
