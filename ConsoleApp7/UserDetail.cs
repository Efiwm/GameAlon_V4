using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTelegramBotApi.Types;

namespace GameAlon
{
    public class Person
    {
        internal string Name = null;
        internal string UserName = null;
        internal long ID;
        internal short Score;
        internal string ComputerGuessNumber = null;
        internal byte Counter = 0;
        //internal bool UserPlayedGuessGame = false;
        public Person(string Name, string UserName, long ID)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.ID = ID;
            Score = 0;
        }
    }

    //public class ProfileGuessGame
    //{
    //    private short PlusScore = 0;
    //    public string ComputerGuessNumber = null;
    //    public byte Counter = 0;
    //    
    //    
    //    
    //    
    //    
    //    
    //    public ProfileGuessGame(short PlusScore) //When Our User Win The Game 
    //    {
    //        this.PlusScore = PlusScore;
    //        Counter = 0;
    //        ComputerGuessNumber = null;
    //    }
    //    public ProfileGuessGame() //When Our User Lose The Game
    //    {
    //        if (PlusScore > 0)
    //        {PlusScore--;}
    //        Counter = 0;
    //        ComputerGuessNumber = null;
    //    }
    //    public ProfileGuessGame(string ComputerGuessNumber) //When Our User Start The Game
    //    {
    //        PlusScore = 0;
    //        Counter = 0;
            //  this.ComputerGuessNumber = ComputerGuessNumber;
    //}   }
//}
    //public ProfileGuessGame(byte Counter) //When Our User Say Wrong Answer 
    //{
    //    this.Counter -= Counter;
    //}
}