using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moyenne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne.Tests
{
    [TestClass()]
    public class NoteTests
    {
        [TestMethod()]
        public void CalculMoyenneTest()
        {

        }

        [TestMethod()]
        public void NoteTest()
        {
            //preparation des données
            Note note = new Note(50);
            int noteAttendu = 50;

            //execution du code à tester
            int noteCalcule = note.ValeurDizieme;

            //test
            Assert.AreEqual(noteCalcule, noteAttendu);
        }
    }
}