﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using osu.Game.Rulesets.Replays;
using osu.Game.Utils;

namespace osu.Game.Replays
{
    public class Replay : IDeepCloneable<Replay>
    {
        /// <summary>
        /// Whether all frames for this replay have been received.
        /// If false, gameplay would be paused to wait for further data, for instance.
        /// </summary>
        public bool HasReceivedAllFrames = true;

        public List<ReplayFrame> Frames = new List<ReplayFrame>();

        public Replay DeepClone()
        {
            return new Replay
            {
                HasReceivedAllFrames = HasReceivedAllFrames,
                // individual frames are mutable for now but hopefully this will not be a thing in the future.
                Frames = Frames.ToList(),
            };
        }
    }
}
