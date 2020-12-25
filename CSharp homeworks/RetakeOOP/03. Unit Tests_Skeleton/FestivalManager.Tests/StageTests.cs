// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 



namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System; 
    
    

    [TestFixture]
	public class StageTests
    {
        private Performer performer;
        private Stage stage;

        [SetUp]
        public void SetUp()
        {
            performer = new Performer("Pesho", "Peshov", 40);
            stage = new Stage();
           
        }

        [Test]
	    public void AddPerformerShouldThrowExceptionIfPermormerIsNull()
        {
            Performer performernull = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performernull));
        }

        [Test]
        public void CannotAddPerformersUnder18()
        {
            performer = new Performer("Pesh","Koo",15);

            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerIsAddingProperly()
        {
            stage.AddPerformer(performer);

            int expected = 1;
            int actual = stage.Performers.Count;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void AddSongCannotTakeNullSongs()
        {
            Song song = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddSong(song));
        }

        [Test]
        public void CannotAddSongWithLessThan1Minute()
        {
            TimeSpan sp = new TimeSpan(0,0,2);
            Song song = new Song("Opa",sp);

            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void AddSongIsAddingProperly()
        {
            TimeSpan sp = new TimeSpan(0,5,25);
            Song song = new Song("Opa", sp);


            Assert.DoesNotThrow(()=>stage.AddSong(song));
        }

        [Test]
        public void AddSongToPerformerCannotAcceptNullSongNameAndNullPerformerName()
        {
            string song = null;
            string perf = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(song, "perf"));
            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer("song", perf));
        }

        [Test]
        public void AddSongToPerformerIsWorkingProperly()
        {
            TimeSpan sp = new TimeSpan(0, 5, 25);
            Song song = new Song("Opa", sp);

            stage.AddPerformer(performer);
            stage.AddSong(song);

            string expected = $"{song} will be performed by {performer}";
            string actual = stage.AddSongToPerformer("Opa", "Pesho Peshov");

            int expectedSongs = 1;
            int actualSongs = performer.SongList.Count;

            Assert.AreEqual(expectedSongs,actualSongs);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void PlayIsWorkingProperly()
        {
            TimeSpan sp = new TimeSpan(0, 5, 25);
            Song song = new Song("Opa", sp);

            stage.AddPerformer(performer);
            stage.AddSong(song);
            stage.AddSongToPerformer("Opa", "Pesho Peshov");

            string expected = "1 performers played 1 songs";
            string actual = stage.Play();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CannotGetNullPerformerAndSong()
        {
            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Asd", "423423"));
            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Asd", "Pesho Peshov"));


        }
    }
}