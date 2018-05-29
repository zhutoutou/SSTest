using System.Text;
using SSTest.Server.RequestInfo;
using SSTest.Session;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SSTest.Server
{
    public class TestAppServer:AppServer<TestSession,TestRequestInfo>
    {
        public TestAppServer() : base(
            new TestRece)
        {

        }
    }
}