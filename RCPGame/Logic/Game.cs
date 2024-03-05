
namespace RCPGame.Logic
{
	public class Game
	{
		private readonly IPlayer _firstPlayer;
		private readonly IPlayer _secondPlayer;

		public Game(IPlayer firstPlayer, IPlayer secondPlayer) 
		{
			_firstPlayer = firstPlayer;
			_secondPlayer = secondPlayer;
		}

		public IPlayer? ChooseWinner()
		{
			var firstPlayerChoice = _firstPlayer.Choice;
			var secondPlayerChoice = _secondPlayer.Choice;
			//if not null
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
					if (firstPlayerChoice == PossibleChoices.Choice_Rock) 
					{
						if (secondPlayerChoice == PossibleChoices.Choice_Paper)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
					// if first player chooses paper
					else if (firstPlayerChoice == PossibleChoices.Choice_Paper)
					{
						if (secondPlayerChoice == PossibleChoices.Choice_Scissors)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
					//if first player chooses scissors
					else
					{
						if (secondPlayerChoice == PossibleChoices.Choice_Rock)
						{
							return _secondPlayer;
						}
						else return _firstPlayer;
					}
				}
			}
			else
			{
				throw new NotImplementedException();
			}
		}
	}
}