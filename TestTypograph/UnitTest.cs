using TypographZhoskyStyle;

namespace TestTypograph
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFirstRuleTest()
        {
            string test = ClassOfRules.FirstRule("\"Каждый в цирке думает, что знает в цирке , но не каждый , что в цирке знает , что в цирке не каждый знает думает\"");
            string right = "\"Каждый в цирке думает, что знает в цирке, но не каждый, что в цирке знает, что в цирке не каждый знает думает\"";
            Assert.AreEqual(right, test);
        }
        [TestMethod]
        public void TestSecondRule()
        {
            string test = ClassOfRules.SecondRule("Если за двумя зайцами погонишься -   рыбку из пруда не выловишь, делу время,  а отмеришь семь раз");
            string right = "Если за двумя зайцами погонишься - рыбку из пруда не выловишь, делу время, а отмеришь семь раз";
            Assert.AreEqual(right, test);
        }
        [TestMethod]
        public void NinthRuleTest()
        {
            string test = ClassOfRules.NinthRule("(+,−) и мы опять играем в любимых");
            string right = "± и мы опять играем в любимых";
            Assert.AreEqual(right, test);
        }
        [TestMethod]
        public void ThirteenthRuleTest()
        {
            string test = ClassOfRules.ThirteenthRule("У батареек есть один минус... И один плюс");
            string right = "У батареек есть один минус… И один плюс";
            Assert.AreEqual(right, test);
        }
        [TestMethod]
        public void TestSalamRule()
        {
            string test = ClassOfRules.SalamRule("Привет! Только татарин может выжать апельсиновый сок и из мандарина!");
            string right = "салам, брат! Только татарин может выжать апельсиновый сок и из мандарина!";
            Assert.AreEqual(right, test);
        }
        [TestMethod]
        public void TestTheBestRule()
        {
            string test = ClassOfRules.TheBestRule("сделал дело - дело сделано.");
            string right = "сделал дело - дело сделано, а и камиля лучше всех.";
            Assert.AreEqual(right, test);
        }

    }
}