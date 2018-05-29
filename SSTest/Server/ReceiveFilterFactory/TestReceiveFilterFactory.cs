using System.Net;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SSTest.Server.ReceiveFilterFactory
{
    public class TestReceiveFilterFactory<TRequestInfo> : IReceiveFilterFactory<TRequestInfo>
    where TRequestInfo:IRequestInfo
    {
        public IReceiveFilter<TRequestInfo> CreateFilter(IAppServer appServer, IAppSession appSession, IPEndPoint remoteEndPoint)
        {
            throw new System.NotImplementedException();
        }
    }
}