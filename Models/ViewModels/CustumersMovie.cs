using Microsoft.AspNetCore.Mvc;

namespace firstApp.Models.ViewModels
{
	public class CustumersMovie 
	{
		public CustumersMovie() { }	
		public Movie Movie { get; set; }
		public List<Custumer> Custumers { get; set;}
	}
}
