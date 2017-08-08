<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Collections.Concurrent.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.Tasks.dll</Reference>
</Query>

void Main()
{
	var numbers = new Numbers();
	
	numbers.FinalNumber.Dump();
}

// Define other methods and classes here
public class Numbers
{
	public int FinalNumber {get;}
	public Numbers()
	{
		var firstNumber = Enumerable.Range(1,100).Select(i=>1).Aggregate(1,(p,c)=>p*c);
		var secondNumber = Enumerable.Range(1,100).Select(i=>1).Aggregate(1,(p,c)=>p*c);
	
		FinalNumber = firstNumber + secondNumber;	
	}
}