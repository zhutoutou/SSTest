using SuperSocket.SocketBase;

namespace SSTest.Session
{
    public class PlaySession:AppSession<PlaySession>
    {
        public int GameHallId { get; internal set; }

        public int RoomId { get; internal set; }
    }
}