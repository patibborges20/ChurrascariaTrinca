using System;
namespace ChurrascodaTriinca.Models
{
	//As informacoes dos participantes que participarao do churrasco
	public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ValueToPay { get; set; }
        public bool Payment { get; set; }
        bool withDrink { get; set; }
    }
}
