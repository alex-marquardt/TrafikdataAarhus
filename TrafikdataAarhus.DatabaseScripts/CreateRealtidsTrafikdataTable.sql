BEGIN TRANSACTION RealtidsTrafikdataTable
	BEGIN TRY
		USE AarhusTrafikdata

		CREATE TABLE RealtidsTrafikdata (
			Id int NOT NULL,
			ReportId int NOT NULL,
			TimeStamp datetime NOT NULL,
			Status nvarchar(50) NOT NULL,
			AvgMeasuredTime int NOT NULL,
			MedianMeasuredTime int NULL,
			VehicleCount int NOT NULL,
			AvgSpeed int NOT NULL
		);

		COMMIT TRANSACTION RealtidsTrafikdataTable
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION RealtidsTrafikdataTable
	END CATCH
GO