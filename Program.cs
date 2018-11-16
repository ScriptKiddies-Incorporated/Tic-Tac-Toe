using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Speech.Synthesis;
// A console app that will play Tic-Tac-Toe with you.

namespace Tic_Tac_Toe
{
	class Program
	{
		static int GetBotChoice()
		{
			if (one == "X" && seven == "X" && nine == "X")
			{
				if (four != "X" && four != "O")
				{
					botChoice = 4;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (one == "X" && three == "X" && nine == "X")
			{
				if (two != "X" && two != "O")
				{
					botChoice = 2;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (one == "X" && seven == "X" && three == "X")
			{
				if (four != "X" && four != "O")
				{
					botChoice = 4;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (three == "X" && seven == "X" && nine == "X")
			{
				if (six != "X" && six != "O")
				{
					botChoice = 6;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (one == "X" && seven == "X" && five == "X")
			{
				if (nine != "X" && nine != "O")
				{
					botChoice = 9;
					isDefensive = true;
					isMultiChoice = 2;
					if (three == "O" && six == "O")
					{
						botChoice = 9;
					}
					if (three == "O" && nine == "O")
					{
						botChoice = 6;
					}
					if (nine == "O" && six == "O")
					{
						botChoice = 3;
					}
				}
			}

			if (three == "X" && five == "X" && nine == "X")
			{
				if (seven != "X" && seven != "O")
				{
					botChoice = 7;
					isDefensive = true;
					isMultiChoice = 2;
					if (one == "O" && four == "O")
					{
						botChoice = 7;
					}
					if (four == "O" && seven == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && seven == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (one == "X" && five == "X" && three == "X")
			{
				if (nine != "X" && nine != "O")
				{
					botChoice = 9;
					isDefensive = true;
					isMultiChoice = 2;
					if (seven == "O" && eight == "O")
					{
						botChoice = 9;
					}
					if (nine == "O" && eight == "O")
					{
						botChoice = 7;
					}
					if (nine == "O" && seven == "O")
					{
						botChoice = 8;
					}
				}
			}

			if (five == "X" && seven == "X" && nine == "X")
			{
				if (three != "X" && three != "O")
				{
					botChoice = 3;
					isDefensive = true;
					isMultiChoice = 2;
					if (three == "O" && two == "O")
					{
						botChoice = 1;
					}
					if (three == "O" && one == "O")
					{
						botChoice = 2;
					}
					if (two == "O" && one == "O")
					{
						botChoice = 3;
					}
				}
			}


			if (three == "X" && two == "X" && six == "X")
			{
				if (one != "X" && one != "O")
				{
					botChoice = 1;
					isDefensive = true;
					isMultiChoice = 2;
					if (seven == "O" && eight == "O")
					{
						botChoice = 9;
					}
					if (nine == "O" && eight == "O")
					{
						botChoice = 7;
					}
					if (nine == "O" && seven == "O")
					{
						botChoice = 8;
					}
					if (one == "O" && four == "O")
					{
						botChoice = 7;
					}
					if (four == "O" && seven == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && seven == "O")
					{
						botChoice = 4;
					}
					if (one == "O" && five == "O")
					{
						botChoice = 9;
					}
					if (five == "O" && nine == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && nine == "O")
					{
						botChoice = 5;
					}
				}
			}

			if (six == "X" && eight == "X" && nine == "X")
			{
				if (three != "X" && three != "O")
				{
					botChoice = 3;
					isDefensive = true;
					isMultiChoice = 2;
					if (one == "O" && four == "O")
					{
						botChoice = 7;
					}
					if (four == "O" && seven == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && seven == "O")
					{
						botChoice = 4;
					}
					if (three == "O" && two == "O")
					{
						botChoice = 1;
					}
					if (three == "O" && one == "O")
					{
						botChoice = 2;
					}
					if (two == "O" && one == "O")
					{
						botChoice = 3;
					}
					if (three == "O" && seven == "O")
					{
						botChoice = 5;
					}
					if (three == "O" && five == "O")
					{
						botChoice = 7;
					}
					if (seven == "O" && five == "O")
					{
						botChoice = 3;
					}

				}
			}

			if (one == "X" && two == "X" && four == "X")
			{
				if (three != "X" && three != "O")
				{
					botChoice = 3;
					isDefensive = true;
					isMultiChoice = 2;
					if (three == "O" && seven == "O")
					{
						botChoice = 5;
					}
					if (three == "O" && five == "O")
					{
						botChoice = 7;
					}
					if (seven == "O" && five == "O")
					{
						botChoice = 3;
					}
					if (seven == "O" && eight == "O")
					{
						botChoice = 9;
					}
					if (nine == "O" && eight == "O")
					{
						botChoice = 7;
					}
					if (nine == "O" && seven == "O")
					{
						botChoice = 8;
					}
					if (three == "O" && six == "O")
					{
						botChoice = 9;
					}
					if (three == "O" && nine == "O")
					{
						botChoice = 6;
					}
					if (nine == "O" && six == "O")
					{
						botChoice = 3;
					}
				}
			}

			if (four == "X" && seven == "X" && eight == "X")
			{
				if (one != "X" && one != "O")
				{
					botChoice = 1;
					isDefensive = true;
					isMultiChoice = 2;
					if (three == "O" && six == "O")
					{
						botChoice = 9;
					}
					if (three == "O" && nine == "O")
					{
						botChoice = 6;
					}
					if (nine == "O" && six == "O")
					{
						botChoice = 3;
					}
					if (one == "O" && five == "O")
					{
						botChoice = 9;
					}
					if (five == "O" && nine == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && nine == "O")
					{
						botChoice = 5;
					}
					if (three == "O" && two == "O")
					{
						botChoice = 1;
					}
					if (three == "O" && one == "O")
					{
						botChoice = 2;
					}
					if (two == "O" && one == "O")
					{
						botChoice = 3;
					}
				}
			}

			if (three == "X" && two == "X" && nine == "X")
			{
				if (six != "X" && six != "O")
				{
					botChoice = 6;
					isDefensive = true;
					isMultiChoice = 2;
					if (one == "O" && four == "O")
					{
						botChoice = 7;
					}
					if (four == "O" && seven == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && seven == "O")
					{
						botChoice = 4;
					}
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
				}
			}


			if (one == "X" && three == "X" && six == "X")
			{
				if (nine != "X" && nine != "O")
				{
					botChoice = 9;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (seven == "O" && eight == "O")
					{
						botChoice = 9;
					}
					if (nine == "O" && eight == "O")
					{
						botChoice = 7;
					}
					if (nine == "O" && seven == "O")
					{
						botChoice = 8;
					}
				}
			}

			if (six == "X" && seven == "X" && nine == "X")
			{
				if (three != "X" && three != "O")
				{
					botChoice = 3;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (three == "O" && two == "O")
					{
						botChoice = 1;
					}
					if (three == "O" && one == "O")
					{
						botChoice = 2;
					}
					if (two == "O" && one == "O")
					{
						botChoice = 3;
					}
				}
			}

			if (three == "X" && eight == "X" && nine == "X")
			{
				if (seven != "X" && seven != "O")
				{
					botChoice = 7;
					isDefensive = true;
					isMultiChoice = 2;
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
					if (one == "O" && four == "O")
					{
						botChoice = 7;
					}
					if (four == "O" && seven == "O")
					{
						botChoice = 1;
					}
					if (one == "O" && seven == "O")
					{
						botChoice = 4;
					}
				}
			}

			if (one == "X" && seven == "X" && eight == "X")
			{
				if (four != "X" && four != "O")
				{
					botChoice = 4;
					isDefensive = true;
					isMultiChoice = 2;
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
					if (three == "O" && six == "O")
					{
						botChoice = 9;
					}
					if (three == "O" && nine == "O")
					{
						botChoice = 6;
					}
					if (nine == "O" && six == "O")
					{
						botChoice = 3;
					}
				}
			}

			if (four == "X" && seven == "X" && nine == "X")
			{
				if (eight != "X" && eight != "O")
				{
					botChoice = 8;
					isDefensive = true;
					isMultiChoice = 2;
					if (three == "O" && two == "O")
					{
						botChoice = 1;
					}
					if (three == "O" && one == "O")
					{
						botChoice = 2;
					}
					if (two == "O" && one == "O")
					{
						botChoice = 3;
					}
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
				}
			}

			if (one == "X" && three == "X" && four == "X")
			{
				if (seven != "X" && seven != "O")
				{
					botChoice = 7;
					isDefensive = true;
					isMultiChoice = 2;
					if (two == "O" && eight == "O")
					{
						botChoice = 5;
					}
					if (two == "O" && five == "O")
					{
						botChoice = 8;
					}
					if (five == "O" && eight == "O")
					{
						botChoice = 2;
					}
					if (seven == "O" && eight == "O")
					{
						botChoice = 9;
					}
					if (nine == "O" && eight == "O")
					{
						botChoice = 7;
					}
					if (nine == "O" && seven == "O")
					{
						botChoice = 8;
					}
				}
			}

			if (one == "X" && seven == "X" && two == "X")
			{
				if (three != "X" && three != "O")
				{
					botChoice = 3;
					isDefensive = true;
					isMultiChoice = 2;
					if (four == "O" && five == "O")
					{
						botChoice = 6;
					}
					if (four == "O" && six == "O")
					{
						botChoice = 5;
					}
					if (five == "O" && six == "O")
					{
						botChoice = 4;
					}
					if (three == "O" && six == "O")
					{
						botChoice = 9;
					}
					if (three == "O" && nine == "O")
					{
						botChoice = 6;
					}
					if (nine == "O" && six == "O")
					{
						botChoice = 3;
					}
				}
			}


			if (isMultiChoice != 2)
			{
				if (one == "X" && two == "X")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}


					}
				}


				if (one == "X" && three == "X")
				{
					if (two != "X" && two != "O")
					{
						botChoice = 2;
						isDefensive = true;
						isMultiChoice = 1;
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}

					}
				}



				if (one == "X" && four == "X")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}

					}
				}



				if (one == "X" && five == "X")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;
						isDefensive = true;
						isMultiChoice = 1;
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}

					}
				}

				if (one == "X" && nine == "X")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}

					}

				}


				if (two == "X" && three == "X")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;
						isDefensive = true;
						isMultiChoice = 1;
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
					}
				}



				if (two == "X" && five == "X")
				{
					if (eight != "X" && eight != "O")
					{
						botChoice = 8;
						isDefensive = true;
						isMultiChoice = 1;
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
					}
				}


				if (two == "X" && eight == "X")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}

					}
				}




				if (three == "X" && six == "X")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;
						isDefensive = true;
						isMultiChoice = 1;
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}

					}

				}


				if (three == "X" && five == "X")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;
						isDefensive = true;
						isMultiChoice = 1;
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
					}
				}


				if (four == "X" && five == "X")
				{
					if (six != "X" && six != "O")
					{
						botChoice = 6;
						isDefensive = true;
						isMultiChoice = 1;
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
					}
				}


				if (four == "X" && six == "X")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
					}
				}


				if (four == "X" && seven == "X")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;
						isDefensive = true;
						isMultiChoice = 1;
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
					}
				}

				if (three == "X" && nine == "X")
				{
					if (six != "X" && six != "O")
					{
						botChoice = 6;
						isDefensive = true;
						isMultiChoice = 1;
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
					}
				}


				if (five == "X" && six == "X")
				{
					if (four != "X" && four != "O")
					{
						botChoice = 4;
						isDefensive = true;
						isMultiChoice = 1;
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (seven == "O" && eight == "O")
						{
							botChoice = 9;
						}
						if (nine == "O" && eight == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && nine == "O")
						{
							botChoice = 8;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
					}
				}





				if (five == "X" && seven == "X")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
					}
				}


				if (five == "X" && nine == "X")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
					}
				}


				if (five == "X" && eight == "X")
				{
					if (two != "X" && two != "O")
					{
						botChoice = 2;
						isDefensive = true;
						isMultiChoice = 1;
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
					}
				}


				if (six == "X" && nine == "X")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;
						isDefensive = true;
						isMultiChoice = 1;
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
					}

				}


				if (seven == "X" && eight == "X")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;
						isDefensive = true;
						isMultiChoice = 1;
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
					}
				}


				if (three == "X" && seven == "X")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;
						isDefensive = true;
						isMultiChoice = 1;
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (one == "O" && five == "O")
						{
							botChoice = 9;
						}
						if (five == "O" && nine == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && nine == "O")
						{
							botChoice = 5;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
					}

				}


				if (eight == "X" && nine == "X")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;
						isDefensive = true;
						isMultiChoice = 1;
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
						if (four == "O" && one == "O")
						{
							botChoice = 7;
						}
						if (four == "O" && seven == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && seven == "O")
						{
							botChoice = 4;
						}
						if (three == "O" && five == "O")
						{
							botChoice = 7;
						}
						if (seven == "O" && five == "O")
						{
							botChoice = 3;
						}
						if (three == "O" && seven == "O")
						{
							botChoice = 5;
						}
					}

				}

				if (one == "X" && seven == "X")
				{
					if (four != "X" && four != "O")
					{
						botChoice = 4;
						isDefensive = true;
						isMultiChoice = 1;
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && six == "O")
						{
							botChoice = 9;
						}
						if (three == "O" && nine == "O")
						{
							botChoice = 6;
						}
						if (nine == "O" && six == "O")
						{
							botChoice = 3;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
					}
				}

				if (seven == "X" && nine == "X")
				{
					if (eight != "X" && eight != "O")
					{
						botChoice = 8;
						isDefensive = true;
						isMultiChoice = 1;
						if (two == "O" && eight == "O")
						{
							botChoice = 5;
						}
						if (two == "O" && five == "O")
						{
							botChoice = 8;
						}
						if (five == "O" && eight == "O")
						{
							botChoice = 2;
						}
						if (four == "O" && five == "O")
						{
							botChoice = 6;
						}
						if (four == "O" && six == "O")
						{
							botChoice = 5;
						}
						if (five == "O" && six == "O")
						{
							botChoice = 4;
						}
						if (three == "O" && one == "O")
						{
							botChoice = 2;
						}
						if (three == "O" && two == "O")
						{
							botChoice = 1;
						}
						if (one == "O" && two == "O")
						{
							botChoice = 3;
						}
					}
				}

			}


			if (counter == 1 || isMultiChoice == 0)
			{
				A:
				Random r = new Random();
				botChoice = r.Next(1, 9);
				isDefensive = true;
				switch (botChoice)
				{
					case 1:
						if (one == "X" || one == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 1;
						}
						break;
					case 2:
						if (two == "X" || two == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 2;
						}
						break;
					case 3:
						if (three == "X" || three == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 3;
						}
						break;
					case 4:
						if (four == "X" || four == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 4;
						}
						break;
					case 5:
						if (five == "X" || five == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 5;
						}
						break;
					case 6:
						if (six == "X" || six == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 6;
						}
						break;
					case 7:
						if (seven == "X" || seven == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 7;
						}
						break;
					case 8:
						if (eight == "X" || eight == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 8;
						}
						break;
					case 9:
						if (nine == "X" || nine == "O")
						{
							goto A;
						}
						else
						{
							botChoice = 9;
						}
						break;

				}

			}
			if (isDefensive == false)
			{
				if (one == "O" && two == "O")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;

					}
				}


				if (one == "O" && three == "O")
				{
					if (two != "X" && two != "O")
					{
						botChoice = 2;

					}
				}



				if (one == "O" && four == "O")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;

					}
				}



				if (one == "O" && five == "O")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;

					}
				}

				if (one == "O" && nine == "O")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;

					}

				}


				if (two == "O" && three == "O")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;

					}
				}



				if (two == "O" && five == "O")
				{
					if (eight != "X" && eight != "O")
					{
						botChoice = 8;

					}
				}


				if (two == "O" && eight == "O")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;

					}
				}




				if (three == "O" && six == "O")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;

					}

				}


				if (three == "O" && five == "O")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;

					}
				}


				if (four == "O" && five == "O")
				{
					if (six != "X" && six != "O")
					{
						botChoice = 6;

					}
				}


				if (four == "O" && six == "O")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;

					}
				}


				if (four == "O" && seven == "O")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;

					}
				}

				if (three == "O" && nine == "O")
				{
					if (six != "X" && six != "O")
					{
						botChoice = 6;
					}
				}


				if (five == "O" && six == "O")
				{
					if (four != "X" && four != "O")
					{
						botChoice = 4;

					}
				}





				if (five == "O" && seven == "O")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;

					}
				}


				if (five == "O" && nine == "O")
				{
					if (one != "X" && one != "O")
					{
						botChoice = 1;

					}
				}


				if (five == "O" && eight == "O")
				{
					if (two != "X" && two != "O")
					{
						botChoice = 2;

					}
				}


				if (six == "O" && nine == "O")
				{
					if (three != "X" && three != "O")
					{
						botChoice = 3;

					}

				}


				if (seven == "O" && eight == "O")
				{
					if (nine != "X" && nine != "O")
					{
						botChoice = 9;

					}
				}


				if (three == "O" && seven == "O")
				{
					if (five != "X" && five != "O")
					{
						botChoice = 5;

					}

				}


				if (eight == "O" && nine == "O")
				{
					if (seven != "X" && seven != "O")
					{
						botChoice = 7;

					}

				}

				if (one == "O" && seven == "O")
				{
					if (four != "X" && four != "O")
					{
						botChoice = 4;
					}
				}

				if (seven == "O" && nine == "O")
				{
					if (eight != "X" && eight != "O")
					{
						botChoice = 8;
					}
				}

			}
			return botChoice;
		}


		//variables
		static string one = "1";
		static string two = "2";
		static string three = "3";
		static string four = "4";
		static string five = "5";
		static string six = "6";
		static string seven = "7";
		static string eight = "8";
		static string nine = "9";
		static bool gameResult = false;
		static bool multiGameResult = false;
		static bool UserOrPc = false; // false = User wins. true = PC wins.
		static int wins;
		static int totalGames;
		static int userChoice;
		static int multiUserChoice;
		static int multiUser2Choice;
		static int player1Wins;
		static int player2Wins;
		static int totalMultiGames;
		static int botChoice;
		static int counter;
		static int multiCounter;
	    static int vs;
		static int isMultiChoice;
		static bool isDefensive = false;
		static bool XorO = true; // true = X`s turn; false = O`s turn;
		static bool isMultiModeOn = false;

		static SpeechSynthesizer synth = new SpeechSynthesizer();
		static SoundPlayer MusicPlayer = new SoundPlayer((Properties.Resources.TheFatRat___Epic));

		static void PlayMulti()
		{
			// this function will handle the multi-player option of the game...
			Console.Clear();

			one = "1";
			two = "2";
			three = "3";
			four = "4";
			five = "5";
			six = "6";
			seven = "7";
			eight = "8";
			nine = "9";
			vs = 1;
			multiGameResult = false;
			XorO = true;
			multiCounter = 0;
			multiUserChoice = 0;
			multiUser2Choice = 0;

			DrawMultiUI();

			MultiUser1sTurn:
			{
				Console.Clear();
				DrawMultiUI();
				try
				{
					multiUserChoice = int.Parse(Console.ReadLine());

					if (multiUserChoice < 1 || multiUserChoice > 9)
					{
						multiUserChoice = 0;
						Console.Clear();
						Console.WriteLine("Wrong.You must enter a number between 1 and 9");
						Thread.Sleep(4000);
						Console.Clear();
						goto MultiUser1sTurn;

					}
					switch (multiUserChoice)
					{

						case 1:

							if (one == "X" || one == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							one = "X";
							break;
						case 2:
							if (two == "X" || two == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							two = "X";
							break;
						case 3:
							if (three == "X" || three == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							three = "X";
							break;
						case 4:
							if (four == "X" || four == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							four = "X";
							break;
						case 5:
							if (five == "X" || five == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							five = "X";
							break;
						case 6:
							if (six == "X" || six == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							six = "X";
							break;
						case 7:
							if (seven == "X" || seven == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							seven = "X";
							break;
						case 8:
							if (eight == "X" || eight == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							eight = "X";
							break;
						case 9:
							if (nine == "X" || nine == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUserChoice = 0;
								Console.Clear();
								goto MultiUser1sTurn;
							}
							nine = "X";
							break;
					}

				}
				catch/* em all */(Exception)
				{
					Console.Clear();
					Console.WriteLine("That`s not a number!");
					Thread.Sleep(2000);
					multiUserChoice = 0;
					Console.Clear();
					goto MultiUser1sTurn;


				}
				XorO = false;
				CheckForWin();
				if (multiGameResult == true)
				{
					Console.Clear();
					DrawMultiUI();
					Thread.Sleep(2000);
					if (UserOrPc == true)
					{
						//Player 2 {O} wins
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Player 2 {O} wins! Press any key to play again!");
						synth.Speak("Player 2 wins!");
						totalMultiGames++;
						player2Wins++;
						Console.ReadKey();
						Console.Clear();
						PlayMulti();
					}
					else
					{
						//Player 1 {X} wins
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Player 1 {O} wins! Press any key to play again!");
						synth.Speak("Player 1 wins!");
						totalMultiGames++;
						player1Wins++;
						Console.ReadKey();
						Console.Clear();
						PlayMulti();
					}

				}

				if (multiCounter == 4)
				{  //draw. No one has won.
					CheckForWin();
					if (multiGameResult == false)
					{
						Console.Clear();
						DrawMultiUI();
						Console.Clear();
						Console.WriteLine("Draw. Press any key to play again");
						Console.ReadKey();
						Console.Clear();
						totalMultiGames++;
						PlayMulti();
					}
					goto MultiUser1sTurn;
				}
			
			}

			MultiUser2sTurn:
			{
				Console.Clear();
				DrawMultiUI();
				try
				{
					multiUser2Choice = int.Parse(Console.ReadLine());

					if (multiUser2Choice < 1 || multiUser2Choice > 9)
					{
						multiUser2Choice = 0;
						Console.Clear();
						Console.WriteLine("Wrong.You must enter a number between 1 and 9");
						Thread.Sleep(4000);
						Console.Clear();
						goto MultiUser1sTurn;

					}
					switch (multiUser2Choice)
					{

						case 1:

							if (one == "X" || one == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							one = "O";
							break;
						case 2:
							if (two == "X" || two == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							two = "O";
							break;
						case 3:
							if (three == "X" || three == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							three = "O";
							break;
						case 4:
							if (four == "X" || four == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							four = "O";
							break;
						case 5:
							if (five == "X" || five == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							five = "O";
							break;
						case 6:
							if (six == "X" || six == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							six = "O";
							break;
						case 7:
							if (seven == "X" || seven == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							seven = "O";
							break;
						case 8:
							if (eight == "X" || eight == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							eight = "O";
							break;
						case 9:
							if (nine == "X" || nine == "O")
							{
								Console.Clear();
								Console.WriteLine("This slot is already taken. Choose another one.");
								Thread.Sleep(4000);
								multiUser2Choice = 0;
								Console.Clear();
								goto MultiUser2sTurn;
							}
							nine = "O";
							break;
					}

				}
				catch/* em all */(Exception)
				{
					Console.Clear();
					Console.WriteLine("That`s not a number!");
					Thread.Sleep(2000);
					multiUser2Choice = 0;
					Console.Clear();
					goto MultiUser2sTurn;


				}
				multiCounter++;
				CheckForWin();
				XorO = true;

			}

			CheckForWin();

			if (multiGameResult == true)
			{
				if (UserOrPc == true)
				{
					//Player 2 {O} wins
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Player 2 {O} wins! Press any key to play again!");
					synth.Speak("Player 2 wins!");
					totalMultiGames++;
					player2Wins++;
					Console.ReadKey();
					Console.Clear();
					PlayMulti();
				}
				else
				{
					//Player 1 {X} wins
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Player 1 {O} wins! Press any key to play again!");
					synth.Speak("Player 1 wins!");
					totalMultiGames++;
					player1Wins++;
					Console.ReadKey();
					Console.Clear();
					PlayMulti();
				}

			}

			if (multiCounter == 4)
			{  //draw. No one has won.
				CheckForWin();
				if (multiGameResult == false)
				{
					Thread.Sleep(2000);
					Console.Clear();
					Console.WriteLine("Draw. Press any key to play again");
					Console.ReadKey();
					Console.Clear();
					totalMultiGames++;
					PlayMulti();
				}
			}
			goto MultiUser1sTurn;
		}
			

		static void PlayMusic()
		{
			//a function that will handle the music playback

				MusicPlayer.PlayLooping();
		}


		static void CheckForWin()
		{
			//this function checks each turn if the user or the computer has won.

			//checks if the user has won
			if (one == "X" && two == "X" && three == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (four == "X" && five == "X" && six == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (seven == "X" && eight == "X" && nine == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (one == "X" && four == "X" && seven == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (two == "X" && five == "X" && eight == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (three == "X" && six == "X" && nine == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (one == "X" && five == "X" && nine == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}
			if (seven == "X" && five == "X" && three == "X")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = true;
			}

			if (gameResult == true)
			{
				return;
			}

			//checks if the computer has won
			if (one == "O" && two == "O" && three == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (four == "O" && five == "O" && six == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (seven == "O" && eight == "O" && nine == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				XorO = false;
				UserOrPc = true;
			}
			if (one == "O" && four == "O" && seven == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (two == "O" && five == "O" && eight == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (three == "O" && six == "O" && nine == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (one == "O" && five == "O" && nine == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			if (seven == "O" && five == "O" && three == "O")
			{
				var color = Console.ForegroundColor;
				if (!isMultiModeOn) gameResult = true;
				else multiGameResult = true;
				UserOrPc = true;
				XorO = false;
			}
			
		}

		static void DrawMultiUI()
		{
			//this function draws the multiplayer playing board and instructs the user on how to play

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Games Played:" + totalMultiGames);
			Console.WriteLine("Player 1 {X} has:" + player1Wins + " wins");
			Console.WriteLine("Player 2 {O} has:" + player2Wins + " wins");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("                    ┌─────┐");
			Console.WriteLine("                    │" + one + "│" + two + "│" + three + "│");
			Console.WriteLine("                    │" + four + "│" + five + "│" + six + "│");
			Console.WriteLine("                    │" + seven + "│" + eight + "│" + nine + "│");
			Console.WriteLine("                    └─────┘");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Magenta;
			if(XorO == true)
			{
				Console.WriteLine("To play type the number you want to change to X and hit enter.");
			}
			else
			{
				Console.WriteLine("To play type the number you want to change to O and hit enter.");
			}

		}

		static void DrawUI()
		{
			//this function draws the board and instructs the user on how to play
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Games Played:" + totalGames);
			Console.WriteLine("        " + "Wins:" + wins);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("                    ┌─────┐");
			Console.WriteLine("                    │" + one + "│" + two + "│" + three + "│");
			Console.WriteLine("                    │" + four + "│" + five + "│" + six +  "│");
			Console.WriteLine("                    │" + seven + "│" + eight + "│" + nine + "│");
			Console.WriteLine("                    └─────┘");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("To play type the number you want to change to X and hit enter.");
		}
		static void Main()
		{
			Console.Title = "Tic Tac Toe";
			Random r = new Random();
			Thread MusicWorker = new Thread(PlayMusic);
			MusicWorker.Start();

			/*	for (int i = 1; i < 56; i++)
				{
					Console.SetWindowSize(i, i);
					Thread.Sleep(6);
				}*/
			Console.SetWindowSize(65, 20);

			Main:
			{
				//reseting vars
				one = "1";
				two = "2";
				three = "3";
				four = "4";
				five = "5";
				six = "6";
				seven = "7";
				eight = "8";
				nine = "9";
			    vs = 0;
				userChoice = 0;
				counter = 0;
				isMultiChoice = 0;
				isDefensive = false;
				gameResult = false;
				UserOrPc = false;

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Tic Tac Toe v1.1 by Kalin Lalov and Miro K.");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("-------------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.Green;
				Thread.Sleep(150);
				Console.WriteLine("Press any key to start the game!");
				Console.ReadKey();
				Console.Clear();
		     	Console.WriteLine("");
				Console.WriteLine("Type 0 to play vs the computer or 1 to play vs another player...");
				     try
					 {
						 vs = int.Parse(Console.ReadLine());
						 if (vs < 0 || vs > 1)
						 {
							 vs = 0;
							 Console.Clear();
							 Console.WriteLine("The specified value is incorrect. Type either 0 or 1");
							 Thread.Sleep(2500);
							 Console.Clear();
							 goto Main;

						 }
					 }
					 catch (Exception)
					 {
						 Console.Clear();
						 Console.WriteLine("That`s not a number!");
						 Thread.Sleep(2000);
						 vs = 0;
						 goto Main;
					 }

				Console.Clear();

				if(vs == 1)
				{
					isMultiModeOn = true;
					PlayMulti();
				}
				else
				{
					isMultiModeOn = false;
				}

				UsersTurn:
				{
					Console.Clear();
					DrawUI();
					try
					{
						userChoice = int.Parse(Console.ReadLine());

						if (userChoice < 1 || userChoice > 9)
						{
							userChoice = 0;
							Console.Clear();
							Console.WriteLine("Wrong.You must enter a number between 1 and 9");
							Thread.Sleep(4000);
							Console.Clear();
							goto UsersTurn;

						}
						switch (userChoice)
						{

							case 1:

								if (one == "X" || one == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								one = "X";
								break;
							case 2:
								if (two == "X" || two == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								two = "X";
								break;
							case 3:
								if (three == "X" || three == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								three = "X";
								break;
							case 4:
								if (four == "X" || four == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								four = "X";
								break;
							case 5:
								if (five == "X" || five == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								five = "X";
								break;
							case 6:
								if (six == "X" || six == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								six = "X";
								break;
							case 7:
								if (seven == "X" || seven == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								seven = "X";
								break;
							case 8:
								if (eight == "X" || eight == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								eight = "X";
								break;
							case 9:
								if (nine == "X" || nine == "O")
								{
									Console.Clear();
									Console.WriteLine("This slot is already taken. Choose another one.");
									Thread.Sleep(4000);
									userChoice = 0;
									Console.Clear();
									goto UsersTurn;
								}
								nine = "X";
								break;
						}

					}
					catch/* em all */(Exception)
					{
						Console.Clear();
						Console.WriteLine("That`s not a number!");
						Thread.Sleep(2000);
						userChoice = 0;
						Console.Clear();
						goto UsersTurn;


					}
					counter++;
					botChoice = GetBotChoice();

					switch (botChoice)
					{
						case 1:
							one = "O";
							break;
						case 2:
							two = "O";
							break;
						case 3:
							three = "O";
							break;
						case 4:
							four = "O";
							break;
						case 5:
							five = "O";
							break;
						case 6:
							six = "O";
							break;
						case 7:
							seven = "O";
							break;
						case 8:
							eight = "O";
							break;
						case 9:
							nine = "O";
							break;
					}

					Console.Clear();
					DrawUI();
					CheckForWin();

					if (gameResult == true)
					{

						Thread.Sleep(2000);
						if (UserOrPc == true)
						{
							//PC wins
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("You lost! Press any key to try again");
							synth.Speak("You lost! Press any key to try again");
							totalGames++;
							Console.ReadKey();
							Console.Clear();
							goto Main;
						}
						else
						{
							//User wins
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("You won! Press any key to play again");
							synth.Speak("You won!!! Press any key to play again");
							totalGames++;
							wins++;
							Console.ReadKey();
							Console.Clear();
							goto Main;
						}

					}

					if (counter == 4)
					{  //draw. No one has won.
						CheckForWin();
						if (gameResult == false)
						{
							Thread.Sleep(2000);
							Console.Clear();
							Console.WriteLine("Draw. Press any key to play again");
							Console.ReadKey();
							Console.Clear();
							totalGames++;
							goto Main;
						}
					}
					goto UsersTurn;
				}
			}
		}
	}
}

 

	


