<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Collections.Concurrent.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.Tasks.dll</Reference>
</Query>

var firstNumber = Enumerable.Range(1,100).Select(i=>1).Aggregate(1,(p,c)=>p*c);
var secondNumber = Enumerable.Range(1,100).Select(i=>1).Aggregate(1,(p,c)=>p*c);

var finalNumber = firstNumber + secondNumber;

finalNumber.Dump();