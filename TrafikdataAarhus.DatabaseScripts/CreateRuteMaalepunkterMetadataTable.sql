BEGIN TRANSACTION RuteMaalepunkterMetadataTable
	BEGIN TRY
		USE AarhusTrafikdata

		CREATE TABLE RuteMaalepunkterMetadata (
			Id int NOT NULL,
			ReportName nvarchar(50) NOT NULL,
			ReportId int NOT NULL,
			Organisation nvarchar(50) NOT NULL,
			RbaId int NOT NULL,
			Point1Name nvarchar(50) NOT NULL,
			Point1Latitude float NOT NULL, 
			Point1Longitude float NOT NULL,
			Point1Street nvarchar(50),
			Point1StreetNumber nvarchar(50),
			Point1PostalCode nvarchar(50),
			Point1Country nvarchar(50) NOT NULL,
			Point2Name nvarchar(50) NOT NULL,
			Point2Latitude float NOT NULL,
			Point2Longitude float NOT NULL,
			Point2StreetNumber nvarchar(50),
			Point2PostalCode nvarchar(50),
			Point2City nvarchar(50),
			Point2Country nvarchar(50) NOT NULL,
			DurationInSeconds int NOT NULL,
			DistanceInMeters int NOT NULL,
			NdtInKmh int NOT NULL,
			RoadType nvarchar(50) NOT NULL,
			Point1City nvarchar(50),
			Point2Street nvarchar(50) 
		);

		COMMIT TRANSACTION RuteMaalepunkterMetadataTable
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION RuteMaalepunkterMetadataTable
	END CATCH
GO