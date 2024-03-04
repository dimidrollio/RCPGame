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
				PossibleChoice.Choice_Scissors,
				PossibleChoice.Choice_Rock,
				PossibleChoice.Choice_Paper
			};
			PlayVM playVM = new()
			{
				PossibleChoices = new SelectList(listOfChoices)
				
			};
			return View(playVM);
		}
		[HttpPost]
		public IActionResult Index(PlayVM playWithAiVM)
		{		
			return RedirectToAction(nameof(Index));
		}
	}
}
