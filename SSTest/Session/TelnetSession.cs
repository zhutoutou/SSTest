﻿using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SSTest.Session
{
    public class TelnetSession:AppSession<TelnetSession>
    {
        protected override void OnSessionStarted()
        {
            this.Send("Welcome to SuperSocket Telnet Server");
        }

        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            this.Send("UnKonw request");
        }

        protected override void HandleException(Exception e)
        {
            this.Send($"Application error:{e.Message}");
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            //add you logic which will be executed after the session is closed
            base.OnSessionClosed(reason);
        }
    }
}