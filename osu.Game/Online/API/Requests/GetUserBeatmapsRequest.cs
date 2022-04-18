﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using Humanizer;
using System.Collections.Generic;
using osu.Game.Online.API.Requests.Responses;

namespace osu.Game.Online.API.Requests
{
    public class GetUserBeatmapsRequest : PaginatedAPIRequest<List<APIBeatmapSet>>
    {
        private readonly long userId;

        private readonly BeatmapSetType type;

        public GetUserBeatmapsRequest(long userId, BeatmapSetType type, Pagination pagination)
            : base(pagination)
        {
            this.userId = userId;
            this.type = type;
        }

        protected override string Target => $@"users/{userId}/beatmapsets/{type.ToString().Underscore()}";
    }

    public enum BeatmapSetType
    {
        Favourite,
        Ranked,
        Loved,
        Pending,
        Graveyard
    }
}
