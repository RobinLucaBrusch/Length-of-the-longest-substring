namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "abcabcbb";
            int length = LongestSubstring.LengthOfLongestSubstring(s);
            Assert.AreEqual(3, length);
        }
    }
}
