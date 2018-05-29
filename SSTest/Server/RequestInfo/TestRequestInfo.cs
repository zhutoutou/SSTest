namespace SSTest.Server.RequestInfo
{
    public class TestRequestInfo : IRequestInfo, SuperSocket.SocketBase.Protocol.IRequestInfo
    {
        public string Key { get; set; }

        public int DeviceId { get; set; }

        /*
         * other properties
         */
    }
}