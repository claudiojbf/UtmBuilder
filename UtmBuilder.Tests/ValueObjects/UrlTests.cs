using UtmBuilder.Domain.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
    {
    
        new Url("banana");
    }

    [TestMethod]
    public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
    {
        try
        {
            var url = new Url("https://www.google.com/");
            Assert.IsTrue(true);
        }
        catch(InvalidUrlException)
        {
            Assert.Fail();
        }
    }
}