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
///     DataGrid output also allows for exporting of the grid to an Excel spreadsheet, if you're so inclined.
///     Just click the top-left most cell of the data and right click in the grid. You can see your options for opening and saving to Excel in the context menu.
/// </summary>

Employees.Select(x => new {x.FirstName, x.LastName, x.Title, TotalCustomers=x.SupportRepIdCustomers.Count})