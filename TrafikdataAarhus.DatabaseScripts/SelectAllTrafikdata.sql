CREATE PROCEDURE [dbo].SelectAllTrafikdata   
AS
SELECT TOP 449
	RealtidsTrafikdata.Id, RealtidsTrafikdata.ReportId, [TimeStamp], [Status], AvgMeasuredTime, MedianMeasuredTime, VehicleCount, AvgSpeed, 
	ReportName, Organisation, RbaId, Point1Name, Point1Latitude, Point1Longitude, Point1Street, Point1StreetNumber, Point1PostalCode, Point1City, Point1Country, 
	Point2Name, Point2Latitude, Point2Longitude, Point2Street, Point2StreetNumber, Point2PostalCode, Point2City, Point2Country, DurationInSeconds, DistanceInMeters, NdtInKmh, RoadType
FROM RuteMaalepunkterMetadata INNER JOIN RealtidsTrafikdata ON RealtidsTrafikdata.Id = RuteMaalepunkterMetadata.Id
ORDER BY [TimeStamp] DESC
GO