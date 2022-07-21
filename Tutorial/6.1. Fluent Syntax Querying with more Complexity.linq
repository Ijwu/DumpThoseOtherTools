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
</Query>

/// <summary>
///     You can write LINQ queries using fluent syntax as well. This gives you a good amount of flexibility to query what you need, how you need it.
/// </summary>

Customers
    .Join(Invoices, customer => customer.CustomerId, invoice => invoice.CustomerId, (customer,invoice) => new {Customer = customer, Invoice = invoice})
    .Select(anonObject => new { Customer = anonObject.Customer, Total = anonObject.Invoice.Total })
    .AsEnumerable() // Switch to client-side execution.
    .GroupBy(x => x.Customer)
    .Select(x => new { Customer=x.Key, TotalPurchases=x.Sum(y => y.Total)})