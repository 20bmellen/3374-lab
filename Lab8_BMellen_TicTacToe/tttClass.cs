using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Brenna Mellen
//CIS 3374 Lab 8
//These are methods to perform unit tests on

namespace tttClassCore
{
    public class tttClass
    {
        public char[] playBoard = new char[9];
        public char cPlayer;
        public char play1 = 'X';
        public char play2 = 'O';

        //initializes playboard to have a length of 9, and returns the length of the int array
        public int createBoard()
        {
            playBoard = new char[9];
            return playBoard.Length;
        }

        //returns the character value of cPlayer
        public char currentPlayer()
        {
            return cPlayer;
        }

        //if the value of cPlayer is equal to play1, we now make the value of cPlayer equal to play2, else, we make cPlayer equal to play1
        public void changePlayer()
        {
            if(cPlayer == play1)
            {
                cPlayer = play2;
            }
            else
            {
                cPlayer = play1;
            }
        }

        public void makeMove(int space)
        {
            playBoard[space-1] = cPlayer;
        }

        public Boolean spaceInUse(int space)
        {
            if(playBoard[space-1].Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
     
}
