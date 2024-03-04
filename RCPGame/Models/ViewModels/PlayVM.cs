using Microsoft.AspNetCore.Mvc.Rendering;

namespace RCPGame.Models.ViewModels
{
	public class PlayVM
	{
		public IEnumerable<SelectListItem> PossibleChoices { get; set; }
		public Choice FirstPlayerChoice { get; set; }
		public Choice SecondPlayerChoice { get; set; }
		public 
	}
}
