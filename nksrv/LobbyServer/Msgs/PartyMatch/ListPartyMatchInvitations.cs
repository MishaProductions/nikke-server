﻿using nksrv.Utils;

namespace nksrv.LobbyServer.Msgs.PartyMatch
{
    [PacketPath("/partymatch/listinvitation")]
    public class ListPartyMatchInvitations : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqListInvitation>();
            var user = GetUser();

            var response = new ResListInvitation();
            // TODO
            WriteData(response);
        }
    }
}
