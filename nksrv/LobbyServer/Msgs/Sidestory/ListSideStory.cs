﻿using Google.Protobuf.WellKnownTypes;
using nksrv.Net;
using nksrv.Utils;

namespace nksrv.LobbyServer.Msgs.Sidestory
{
    [PacketPath("/sidestory/list")]
    public class ListSideStory : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqListSideStory>();
            var user = GetUser();

            var response = new ResListSideStory();

            foreach (var item in user.CompletedSideStoryStages)
            {
                // TODO cleared at
                response.SideStoryStageDataList.Add(new NetSideStoryStageData() { SideStoryStageId = item, ClearedAt = Timestamp.FromDateTime(DateTime.UtcNow) });
            }

            await WriteDataAsync(response);
        }
    }
}
