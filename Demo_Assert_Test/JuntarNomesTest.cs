using Demo_Assert;
using NUnit.Framework;

namespace Demo_Assert_Test
{
    public class JuntarNomesTest
    {
        public JuntarNomes _juntarNomes;
        [SetUp]
        public void Setup()
        {
            _juntarNomes = new JuntarNomes();
        }

        [Test]
        public void DevoJuntarNomes()
        {
            var nomeCompleto = _juntarNomes.Juntar("Gabriel", "Ribeiro");

            Assert.AreEqual(nomeCompleto, "Gabriel Ribeiro");
        }

        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var nomeCompleto = _juntarNomes.Juntar("gabriel", "ribeiro");

            //Assert.AreEqual(nomeCompleto, "Gabriel Ribeiro");
            StringAssert.AreEqualIgnoringCase(nomeCompleto, "GabRiel RiBeIro");
        }

        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var nomeCompleto = _juntarNomes.Juntar("Gabriel", "Bibeiro");

            Assert.AreNotEqual(nomeCompleto, "Cecilia Ribeiro");
        }
    }
}