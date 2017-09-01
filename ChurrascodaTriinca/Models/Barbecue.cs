using System;
namespace ChurrascodaTriinca.Models
{
	//classe contendo o evento do churrasco
	public class Barbecue
    {
            public int id{ get;set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public double CostWithDrink { get; set; }
            public double CostWhithoutDrink{ get; set; }
    }
}