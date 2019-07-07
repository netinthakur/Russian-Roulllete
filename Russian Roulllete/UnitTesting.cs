using Russian_Roulllete;

namespace Rouelette
{
    [TestFixture]
    class UnitTesting
    {
        public object Assert { get; private set; }

        [TestCase]
        public void Shot_Positive()
        {
            Play Shot_pos = new Play();
            Assert.AreEqual(10, Shot_pos.Shotbullet(1, 1));
        }

        [TestCase]
        public void Spin()
        {
            russian spin = new russian();
            Assert.AreEqual(6,
                            spin.Spin_chamber(5));

            spin.Spin_chamber(5);
        }
    }
}
