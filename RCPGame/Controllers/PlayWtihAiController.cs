using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RCPGame.Logic;
using RCPGame.Models.ViewModels;

namespace RCPGame.Controllers
{
	public class PlayWithAiController : Controller
	{
        public IActionResult Index()
		{
			var listOfChoices = new List<string>
			{
				PossibleChoices.Choice_Scissors,
				PossibleChoices.Choice_Rock,
				PossibleChoices.Choice_Paper
			};
			PlayVM playVM = new()
			{
				PossibleChoices = new SelectList(listOfChoices),
				FirstPlayer = new RealPlayer(),
				SecondPlayer = new AiPlayer()
			};
			return View(playVM);
		}
		[HttpPost]
		public IActionResult Index(PlayVM playVM)
		{
			if (playVM.FirstPlayer == null)
			{
				return RedirectToAction(nameof(Index));
			}
			
			return RedirectToAction(nameof(Result), new {fp=playVM.FirstPlayer.Choice});
		}

		public IActionResult Result(string fp)
		{
			Random rnd = new();
			int rndVal = rnd.Next(PossibleChoices.GetAllChoices().Count()); //get random value to get 
			string aiChoice = PossibleChoices.GetAllChoices()[rndVal];

			PlayVM playVM = new() 
			{
				FirstPlayer = new RealPlayer() { Choice = fp },
				SecondPlayer = new AiPlayer() {Choice = aiChoice }
			};

			Game game = new(playVM.FirstPlayer, playVM.SecondPlayer);
			playVM.Winner = game.ChooseWinner(); //add winner to vm

			return View(playVM);
		}
	}
}
