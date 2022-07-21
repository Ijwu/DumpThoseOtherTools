<Query Kind="Expression">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
  <Output>DataGrids</Output>
</Query>

/// <summary>
///     Introducing the DataGrid output format. Outputting database queries to the DataGrid enables a more ordered view of large amounts of output.
///     With paid editions of LINQPad you may also perform CRUD operations on the data right within the grid and save it back to the database.
/// 
///     Try exploring the DataGrid output and clicking through various navigation properties. If you have a high enough paid edition of LINQPad, try clicking
///     on "Edit Data" in the top left and see what it's like to edit existing data.
/// 
///     Try editing a playlist name, or adding a new track to one, or deleting a track from a playlist. Make a new playlist if you feel adventurous.
/// 
/// 	Another thing which is made clear here is the automated navigation properties generated behind the scenes by LINQPad's LINQ-to-SQL driver.
/// </summary>

Playlists