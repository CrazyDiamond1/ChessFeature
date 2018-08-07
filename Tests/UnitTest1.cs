using System;
using Chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Chess.Logic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CheckKingBetweenCastles()
        {
              Logic l = new Logic();
        //    l.pieceArray = new piece[8, 8];
              bool actual = true;

        //    l.pieceArray[0, 0].job = Job.King;
        //    l.pieceArray[1, 0].job = Job.Bishop;
        //    l.pieceArray[2, 0].job = Job.Bishop;
            actual = l.checkKingBetweenCastles();
            actual = false;
            Assert.IsFalse(actual, "says king is between them... it's not.");
        }
    }
}
