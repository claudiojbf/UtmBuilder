using UtmBuilder.Domain;

namespace UtmBuilder.Tests;

[TestClass]
public class UtmTests
{
    private const string _result = "https://www.google.com/"+
        "?utm_source=src"+
        "&utm_medium=med&"+
        "utm_campaign=nam&"+
        "utm_id=id&"+
        "utm_term=term&"+
        "utm_content=cont";
    private readonly Url _url = new ("https://www.google.com/");
    private readonly Campaign _campaign = new (
        "src",
        "med",
        "nam",
        "id",
        "term",
        "cont"
    );
    [TestMethod]
    public void Deve_retornar_uma_url_do_utm()
    {
        var utm = new Utm(_url, _campaign);
        Assert.AreEqual(_result, (string)utm);
    }

    [TestMethod]
    public void Deve_retornar_uma_utm_do_url()
    {
        Utm utm = _result;
        Assert.AreEqual("https://www.google.com/", utm.Url.Address);
        Assert.AreEqual("src", utm.Campaign.Source);
        Assert.AreEqual("med", utm.Campaign.Medium);
        Assert.AreEqual("nam", utm.Campaign.Name);
        Assert.AreEqual("id", utm.Campaign.Id);
        Assert.AreEqual("term", utm.Campaign.Term);
        Assert.AreEqual("cont", utm.Campaign.Content);
    }
}