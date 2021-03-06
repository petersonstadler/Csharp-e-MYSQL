using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_e_MYSQL.Classes;

namespace Csharp_e_MYSQL_testes
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        [DataRow("Pe")]
        [DataRow("P")]
        [DataRow("")]
        public void TestarValidadorCampoNome_LetrasMenorQue3(string nome)
        {
            Validador validar = new Validador();
            string msg = "";
            bool result = validar.CampoNome(nome, ref msg);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("Peterson")]
        [DataRow("Thiago")]
        [DataRow("Fred Flingstone")]
        public void TestarValidadorCampoNome_CasoAceitavel(string nome)
        {
            Validador validar = new Validador();
            string msg = "";
            bool result = validar.CampoNome(nome, ref msg);
            Assert.IsTrue(result);
        }
    }
}
