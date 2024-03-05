using System.ComponentModel.DataAnnotations;

namespace RCPGame.Logic
{
	public static class PossibleChoices
	{
		public const string Choice_Scissors = "Scissors";
		public const string Choice_Rock = "Rock";
		public const string Choice_Paper = "Paper";

		public static List<string> GetAllChoices()
		{
			return new List<string>()
			{
			Choice_Scissors,
			Choice_Paper,
			Choice_Rock
			};
		}
	}
}
