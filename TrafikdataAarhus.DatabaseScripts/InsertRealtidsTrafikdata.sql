CREATE PROCEDURE [dbo].[InsertRealtidsTrafikdata] 
	@Id int,
	@ReportId int,
	@TimeStamp datetime,
	@Status nvarchar(50),
	@AvgMeasuredTime int,
	@MedianMeasuredTime int,
	@VehicleCount int,
	@AvgSpeed int
AS
	INSERT INTO [dbo].[RealtidsTrafikdata] ([Id], [ReportId], [TimeStamp], [Status], [AvgMeasuredTime], [MedianMeasuredTime], [VehicleCount], [AvgSpeed])
	VALUES (@Id, @ReportId, @TimeStamp, @Status, @AvgMeasuredTime, @MedianMeasuredTime, @VehicleCount, @AvgSpeed);
GO