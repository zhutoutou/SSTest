using System;
using System.Linq;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SSTest.NetHandler
{
    public class ADD : CommandBase<AppSession, StringRequestInfo>
    {
        public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
        {
            session.Send(requestInfo.Parameters.Select(p=>Convert.ToInt32(p)).Sum().ToString());
        }
    }
    
}