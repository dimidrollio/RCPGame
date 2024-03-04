using RCPGame.Models;

namespace RCPGame.Logic
{
	public class Game
	{
		private IPlayer _firstPlayer;
		private IPlayer _secondPlayer;

		public Game(IPlayer firstPlayer, IPlayer secondPlayer) 
		{
			_firstPlayer = firstPlayer;
			_secondPlayer = secondPlayer;
		}

		public IPlayer? ChooseWinner()
		{
			var firstPlayerChoice = _firstPlayer.MakeChoice();
			var secondPlayerChoice = _secondPlayer.MakeChoice();


			if(firstPlayerChoice != null && secondPlayerChoice != null)
			{

				//draw option
				if (firstPlayerChoice == secondPlayerChoice)
				{
					return null;
				}

				else
				{
					//if first player chooses rock
					if (firstPlayerChoice == PossibleChoice.Choice_Rock) 
					{
						if (secondPlayerChoice == PossibleChoice.Choice_Paper)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
					// if first player chooses paper
					else if (firstPlayerChoice == PossibleChoice.Choice_Paper)
					{
						if (secondPlayerChoice == PossibleChoice.Choice_Scissors)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
					//if first player chooses scissors
					if (firstPlayerChoice == PossibleChoice.Choice_Scissors)
					{
						if (secondPlayerChoice == PossibleChoice.Choice_Rock)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
				}
			}
		}
	}
}