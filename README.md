# TrafikdataAarhus
Trafikdata Aarhus is a jobinterview project case made by ATEA made for testing my skills as a software developer.

## Pupose of the project
The purpose of this project was to to receive data from a api (https://portal.opendata.dk/dataset/realtids-trafikdata), model it, use the data to bring insight/visualize it to the user and update the data every 5 min. I have used: .Net Framework, Dapper, MSSQL, Windows Form and a library called GMap. 

## My work
The backend-code, databasescript and design in Windows Forms is made by myself. The coordinates and map is a library called GMap for .NET Framework.

## How to use the program
1. Start by running the database script in the following order: 
  1. CreateAarhusTrafikdataDatabase.sql.
  2. CreateRealtidsTrafikdataTable.sql.
  3. CreateRuteMaalepunkterMetadataTable.sql.
  4. InsertRealtidsTrafikdata.sql.
  5. InsertRuteMaalepunkterMetadata.sql.
  6. SelectAllTrafikdata.sql.

2. Open the program.
3. In the RuteMaalepunkterMetadataDataProvider class and in the methode called "InsertRuteMaalepunkterMetadata" change the input parameter "new SqlConnetion("")" to your database connectionstring.
4. In the RealtidsTrafikdataDataProvider class and in the methode called "InsertRealtidsTrafikdata" change the input parameter "new SqlConnetion("")" to your database connectionstring.
5. Run the methode "GetruteMaalepunkterMetadataAarhus" to insert data in the database. 
6. Run the program and click in the DataGriedView to see the data's coordinates. 
