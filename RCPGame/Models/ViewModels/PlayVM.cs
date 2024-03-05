using Microsoft.AspNetCore.Mvc.Rendering;
using RCPGame.Logic;

namespace RCPGame.Models.ViewModels
{
	public class PlayVM
	{
        public IEnumerable<SelectListItem> PossibleChoices { get; set; }
		public IPlayer FirstPlayer { get; set; }
		public IPlayer SecondPlayer { get; set; }
		public IPlayer? Winner {  get; set; }

		public PlayVM()
		{
			FirstPlayer = new RealPlayer();
			SecondPlayer = new AiPlayer();
		}
	}
}
