namespace Tic_Tac_Toe
{

using static Tic_Tac_Toe.Program;
using System;

    internal class Algo
    {


        public static int GetBestBotChoice()
        {
        int choice = 0;
        if (one == "X" && seven == "X" && nine == "X")
        {
            if (four != "X" && four != "O")
            {
                choice = 4;
                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && three == "X" && nine == "X")
        {
            if (two != "X" && two != "O")
            {
                choice = 2;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && seven == "X" && three == "X")
        {
            if (four != "X" && four != "O")
            {
                choice = 4;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (three == "X" && seven == "X" && nine == "X")
        {
            if (six != "X" && six != "O")
            {
                choice = 6;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && seven == "X" && five == "X")
        {
            if (nine != "X" && nine != "O")
            {
                choice = 9;

                isMultiChoice = 2;
                if (three == "O" && six == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && nine == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && six == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (three == "X" && five == "X" && nine == "X")
        {
            if (seven != "X" && seven != "O")
            {
                choice = 7;

                isMultiChoice = 2;
                if (one == "O" && four == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && seven == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && seven == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && five == "X" && three == "X")
        {
            if (nine != "X" && nine != "O")
            {
                choice = 9;

                isMultiChoice = 2;
                if (seven == "O" && eight == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && eight == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && seven == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (five == "X" && seven == "X" && nine == "X")
        {
            if (three != "X" && three != "O")
            {
                choice = 3;

                isMultiChoice = 2;
                if (three == "O" && two == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && one == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && one == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }


        if (three == "X" && two == "X" && six == "X")
        {
            if (one != "X" && one != "O")
            {
                choice = 1;

                isMultiChoice = 2;
                if (seven == "O" && eight == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && eight == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && seven == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && four == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && seven == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && seven == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && five == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && nine == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && nine == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (six == "X" && eight == "X" && nine == "X")
        {
            if (three != "X" && three != "O")
            {
                choice = 3;

                isMultiChoice = 2;
                if (one == "O" && four == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && seven == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && seven == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && two == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && one == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && one == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && seven == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && five == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (seven == "O" && five == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }

            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && two == "X" && four == "X")
        {
            if (three != "X" && three != "O")
            {
                choice = 3;

                isMultiChoice = 2;
                if (three == "O" && seven == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && five == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (seven == "O" && five == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
                if (seven == "O" && eight == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && eight == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && seven == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && six == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && nine == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && six == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (four == "X" && seven == "X" && eight == "X")
        {
            if (one != "X" && one != "O")
            {
                choice = 1;

                isMultiChoice = 2;
                if (three == "O" && six == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && nine == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && six == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && five == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && nine == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && nine == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }

                if (three == "O" && two == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && one == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && one == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (three == "X" && two == "X" && nine == "X")
        {
            if (six != "X" && six != "O")
            {
                choice = 6;

                isMultiChoice = 2;
                if (one == "O" && four == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && seven == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && seven == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }


        if (one == "X" && three == "X" && six == "X")
        {
            if (nine != "X" && nine != "O")
            {
                choice = 9;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (seven == "O" && eight == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && eight == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && seven == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (six == "X" && seven == "X" && nine == "X")
        {
            if (three != "X" && three != "O")
            {
                choice = 3;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && two == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && one == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && one == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (three == "X" && eight == "X" && nine == "X")
        {
            if (seven != "X" && seven != "O")
            {
                choice = 7;

                isMultiChoice = 2;
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && four == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && seven == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (one == "O" && seven == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && seven == "X" && eight == "X")
        {
            if (four != "X" && four != "O")
            {
                choice = 4;

                isMultiChoice = 2;
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && six == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && nine == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && six == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (four == "X" && seven == "X" && nine == "X")
        {
            if (eight != "X" && eight != "O")
            {
                choice = 8;

                isMultiChoice = 2;
                if (three == "O" && two == "O")
                {
                    if (one != "O" && one != "X")
                    {
                        choice = 1;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && one == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && one == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && three == "X" && four == "X")
        {
            if (seven != "X" && seven != "O")
            {
                choice = 7;

                isMultiChoice = 2;
                if (two == "O" && eight == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (two == "O" && five == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && eight == "O")
                {
                    if (two != "O" && two != "X")
                    {
                        choice = 2;
                        isMultiChoice = 2;
                    }
                }
                if (seven == "O" && eight == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && eight == "O")
                {
                    if (seven != "O" && seven != "X")
                    {
                        choice = 7;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && seven == "O")
                {
                    if (eight != "O" && eight != "X")
                    {
                        choice = 8;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }

        if (one == "X" && seven == "X" && two == "X")
        {
            if (three != "X" && three != "O")
            {
                choice = 3;

                isMultiChoice = 2;
                if (four == "O" && five == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (four == "O" && six == "O")
                {
                    if (five != "O" && five != "X")
                    {
                        choice = 5;
                        isMultiChoice = 2;
                    }
                }
                if (five == "O" && six == "O")
                {
                    if (four != "O" && four != "X")
                    {
                        choice = 4;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && six == "O")
                {
                    if (nine != "O" && nine != "X")
                    {
                        choice = 9;
                        isMultiChoice = 2;
                    }
                }
                if (three == "O" && nine == "O")
                {
                    if (six != "O" && six != "X")
                    {
                        choice = 6;
                        isMultiChoice = 2;
                    }
                }
                if (nine == "O" && six == "O")
                {
                    if (three != "O" && three != "X")
                    {
                        choice = 3;
                        isMultiChoice = 2;
                    }
                }
            }
            else
            {
                isMultiChoice = 0;
            }
        }


        if (isMultiChoice != 2)
        {
            if (one == "X" && two == "X")
            {
                if (three != "X" && three != "O")
                {
                    choice = 3;

                    isMultiChoice = 1;
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }


                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (one == "X" && three == "X")
            {
                if (two != "X" && two != "O")
                {
                    choice = 2;

                    isMultiChoice = 1;
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }
            }



            if (one == "X" && four == "X")
            {
                if (seven != "X" && seven != "O")
                {
                    choice = 7;

                    isMultiChoice = 1;
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }
            }



            if (one == "X" && five == "X")
            {
                if (nine != "X" && nine != "O")
                {
                    choice = 9;

                    isMultiChoice = 1;
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }
            }

            if (one == "X" && nine == "X")
            {
                if (five != "X" && five != "O")
                {
                    choice = 5;

                    isMultiChoice = 1;
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }

            }


            if (two == "X" && three == "X")
            {
                if (one != "X" && one != "O")
                {
                    choice = 1;

                    isMultiChoice = 1;
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }



            if (two == "X" && five == "X")
            {
                if (eight != "X" && eight != "O")
                {
                    choice = 8;

                    isMultiChoice = 1;
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (two == "X" && eight == "X")
            {
                if (five != "X" && five != "O")
                {
                    choice = 5;

                    isMultiChoice = 1;
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }
            }




            if (three == "X" && six == "X")
            {
                if (nine != "X" && nine != "O")
                {
                    choice = 9;

                    isMultiChoice = 1;
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }

                }
                else
                {
                    isMultiChoice = 0;
                }

            }


            if (three == "X" && five == "X")
            {
                if (seven != "X" && seven != "O")
                {
                    choice = 7;

                    isMultiChoice = 1;
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (four == "X" && five == "X")
            {
                if (six != "X" && six != "O")
                {
                    choice = 6;

                    isMultiChoice = 1;
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (four == "X" && six == "X")
            {
                if (five != "X" && five != "O")
                {
                    choice = 5;

                    isMultiChoice = 1;
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (four == "X" && seven == "X")
            {
                if (one != "X" && one != "O")
                {
                    choice = 1;

                    isMultiChoice = 1;
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }

            if (three == "X" && nine == "X")
            {
                if (six != "X" && six != "O")
                {
                    choice = 6;

                    isMultiChoice = 1;
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (five == "X" && six == "X")
            {
                if (four != "X" && four != "O")
                {
                    choice = 4;

                    isMultiChoice = 1;
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && eight == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && eight == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && nine == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }





            if (five == "X" && seven == "X")
            {
                if (three != "X" && three != "O")
                {
                    choice = 3;

                    isMultiChoice = 1;
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (five == "X" && nine == "X")
            {
                if (one != "X" && one != "O")
                {
                    choice = 1;

                    isMultiChoice = 1;
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (five == "X" && eight == "X")
            {
                if (two != "X" && two != "O")
                {
                    choice = 2;

                    isMultiChoice = 1;
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (six == "X" && nine == "X")
            {
                if (three != "X" && three != "O")
                {
                    choice = 3;

                    isMultiChoice = 1;
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }

            }


            if (seven == "X" && eight == "X")
            {
                if (nine != "X" && nine != "O")
                {
                    choice = 9;

                    isMultiChoice = 1;
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }


            if (three == "X" && seven == "X")
            {
                if (five != "X" && five != "O")
                {
                    choice = 5;

                    isMultiChoice = 1;
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && five == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && nine == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && nine == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }

            }


            if (eight == "X" && nine == "X")
            {
                if (seven != "X" && seven != "O")
                {
                    choice = 7;

                    isMultiChoice = 1;
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && one == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && seven == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && seven == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && five == "O")
                    {
                        if (seven != "O" && seven != "X")
                        {
                            choice = 7;
                            isMultiChoice = 3;
                        }
                    }
                    if (seven == "O" && five == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && seven == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }

            }

            if (one == "X" && seven == "X")
            {
                if (four != "X" && four != "O")
                {
                    choice = 4;

                    isMultiChoice = 1;
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && six == "O")
                    {
                        if (nine != "O" && nine != "X")
                        {
                            choice = 9;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && nine == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (nine == "O" && six == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }

            if (seven == "X" && nine == "X")
            {
                if (eight != "X" && eight != "O")
                {
                    choice = 8;

                    isMultiChoice = 1;
                    if (two == "O" && eight == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (two == "O" && five == "O")
                    {
                        if (eight != "O" && eight != "X")
                        {
                            choice = 8;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && eight == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && five == "O")
                    {
                        if (six != "O" && six != "X")
                        {
                            choice = 6;
                            isMultiChoice = 3;
                        }
                    }
                    if (four == "O" && six == "O")
                    {
                        if (five != "O" && five != "X")
                        {
                            choice = 5;
                            isMultiChoice = 3;
                        }
                    }
                    if (five == "O" && six == "O")
                    {
                        if (four != "O" && four != "X")
                        {
                            choice = 4;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && one == "O")
                    {
                        if (two != "O" && two != "X")
                        {
                            choice = 2;
                            isMultiChoice = 3;
                        }
                    }
                    if (three == "O" && two == "O")
                    {
                        if (one != "O" && one != "X")
                        {
                            choice = 1;
                            isMultiChoice = 3;
                        }
                    }
                    if (one == "O" && two == "O")
                    {
                        if (three != "O" && three != "X")
                        {
                            choice = 3;
                            isMultiChoice = 3;
                        }
                    }
                }
                else
                {
                    isMultiChoice = 0;
                }
            }

        }


        if (counter != 1 && isMultiChoice == 0)
        {
        A:
            Random r = new Random();
            choice = r.Next(1, 9);

            switch (choice)
            {
                case 1:
                    if (one == "X" || one == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 1;
                    }
                    break;
                case 2:
                    if (two == "X" || two == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 2;
                    }
                    break;
                case 3:
                    if (three == "X" || three == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 3;
                    }
                    break;
                case 4:
                    if (four == "X" || four == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 4;
                    }
                    break;
                case 5:
                    if (five == "X" || five == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 5;
                    }
                    break;
                case 6:
                    if (six == "X" || six == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 6;
                    }
                    break;
                case 7:
                    if (seven == "X" || seven == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 7;
                    }
                    break;
                case 8:
                    if (eight == "X" || eight == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 8;
                    }
                    break;
                case 9:
                    if (nine == "X" || nine == "O")
                    {
                        goto A;
                    }
                    else
                    {
                        choice = 9;
                    }
                    break;

            }
        }
        if (counter == 1 && five != "X")
        {
            choice = 5;
        }
        if (counter == 1 && five == "X")
        {
        B:
            Random r1 = new Random();
            choice = r1.Next(1, 9);
            if (choice == 2)
            {
                goto B;
            }
            if (choice == 4)
            {
                goto B;
            }
            if (choice == 6)
            {
                goto B;
            }
            if (choice == 8)
            {
                goto B;
            }
            if (choice == 5)
            {
                goto B;
            }
        }

        return choice;
    }
}
}
