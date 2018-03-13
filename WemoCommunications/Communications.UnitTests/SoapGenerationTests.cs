using Microsoft.VisualStudio.TestTools.UnitTesting;
using WemoNet.Utilities;

namespace Communications.UnitTests
{
    [TestClass]
    public class SoapGenerationTests
    {
        [TestMethod]
        public void GenerateSetBinaryStateRequest_()
        {
            var soap = Soap.GenerateSetBinaryStateRequest(Soap.WemoSetBinaryStateCommands.BinaryState.ToString(), "1");
        }
    }
}
