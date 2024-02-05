<Query Kind="Statements">
  <Output>DataGrids</Output>
  <Namespace>System.Data.SqlClient</Namespace>
</Query>

/*
LINQ is Language-Integrated Query
It brings a set of technologies based on of query capatilies into C# language.
Checking at compile time.
IntelliSense support.
You don't have to learn different query languages.
You can use same query expressin paterns to any data source.
**/

// Specify the data source.
int[] scores = [97, 92, 81, 60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81

//**********Overview****************************************************************************

//Query Expressions query and transform data from any Linq-enabeled data source. 
//A single query can retrieve(geri almak) data from database and produces an XML stream as output.


var query = from customer in GetCustomers(connectionString)
            where customer.City == "New York"
            select new XElement("Customer",
                   new XAttribute("ID", customer.CustomerID),
                   new XElement("Name", customer.CustomerName),
                   new XElement("City", customer.City));



//LINQ query expression with strong typing

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;
				  
//A query isn't executed until you iterate (yinelemek) over the quey variable.

 List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
 
 // LINQ query expression with deferred execution
var evenNumbersQuery = from num in numbers
                       where num % 2 == 0
                       select num;
					   
// The query is not executed at this point

// Iterating over the query triggers execution
foreach (var number in evenNumbersQuery)
{
    Console.WriteLine(number);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/