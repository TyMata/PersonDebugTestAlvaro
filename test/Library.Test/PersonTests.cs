using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        public string idValid;
        public Person personaVal;

        [SetUp]
        public void Setup()
        {
            string idValid = "4.919.878-9";
            personaVal = new Person("Alvaro Machado", idValid);
        }

        [Test]
        public void NotValidNameTest() // Cambiá el nombre para indicar qué estás probando
        {
            Person personaTes = new Person( null , "4.919.878-9");
            Assert.AreEqual(personaTes.Name, personaVal.Name);
        }

        [Test]
        public void NotValidIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            Person personaTes = new Person("Alvaro Machado", "4.919.878-1");
            Assert.AreEqual(idValid,personaTes.ID);
        }

        [Test]
        public void ValidIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            string idTes = "5.334.282-7";
            Person personaTes = new Person("Alvaro Machado", idTes);
            Assert.AreEqual(personaTes.ID, idTes);
        }
    }
}