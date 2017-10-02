using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moyenne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyenne.Tests
{
    [TestClass()]
    public class NoteTests
    {

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

        [TestMethod()]
        public void CalculMoyenneTest()
        {
            //preparation des données
            ListBox lstNote = new ListBox();
            Note note1 = new Note(50);
            lstNote.Items.Add(note1);
            Note note2 = new Note(55);
            lstNote.Items.Add(note2);
            Note note3 = new Note(45);
            lstNote.Items.Add(note3);
            Note note4 = new Note(47);
            lstNote.Items.Add(note4);

            float moyenneAttendue = 4.93F;

            //execution du code à tester
            float moyenneCalcule = Note.CalculMoyenne(lstNote);

            //test
            Assert.AreEqual(moyenneCalcule, moyenneAttendue);
        }

        
    }
}