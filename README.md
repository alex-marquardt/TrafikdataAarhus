# TrafikdataAarhus
Trafikdata Aarhus is a jobinterview project made by ATEA to test my skills as a software developer.

## Pupose of the project
The purpose of this project is to to receive data from the api: https://portal.opendata.dk/dataset/realtids-trafikdata (2 datasets), model the data, use the data to bring insight and visualize it to the enduser and update the received data every 5 min. In the project there is used: .Net Framework, Dapper, MSSQL, Windows Form and a library called GMap. 

## My work
The backend-code, databasescript and design made in Windows Forms is donw by myself. The coordinates and map is a external library called GMap.

## How to use the program
1. Start by running the database scripts in the following order: 
    - CreateAarhusTrafikdataDatabase.sql (modify the database path to your own path).
    - CreateRealtidsTrafikdataTable.sql.
    - CreateRuteMaalepunkterMetadataTable.sql.
    - InsertRealtidsTrafikdata.sql.
    - InsertRuteMaalepunkterMetadata.sql.
    - SelectAllTrafikdata.sql.

2. Open the solution.
3. In the RuteMaalepunkterMetadataDataProvider class, in the methode called "InsertRuteMaalepunkterMetadata" change the input parameter "new SqlConnetion("your database connectionstring")" to your database connectionstring.
4. In the RealtidsTrafikdataDataProvider class, in the methode called "InsertRealtidsTrafikdata" change the input parameter "new SqlConnetion("your database connectionstring")" to your database connectionstring.
5. Run the methode "GetruteMaalepunkterMetadataAarhus" to insert data for route measurement in the database. 
6. Run the program and click on a row in the DataGriedView to see the route's data and coordinates on the map.
