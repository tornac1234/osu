// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Graphics.Sprites;
using osu.Game.Tournament.Screens.Ladder.Components;

namespace osu.Game.Tournament.Screens.Ladder
{
    public class DrawableTournamentGrouping : CompositeDrawable
    {
        public DrawableTournamentGrouping(TournamentGrouping grouping, bool losers = false)
        {
            AutoSizeAxes = Axes.Both;
            InternalChild = new FillFlowContainer
            {
                Direction = FillDirection.Vertical,
                AutoSizeAxes = Axes.Both,
                Children = new Drawable[]
                {
                    new OsuSpriteText
                    {
                        Text = grouping.Description.ToUpper(),
                        Origin = Anchor.TopCentre,
                        Anchor = Anchor.TopCentre
                    },
                    new OsuSpriteText
                    {
                        Text = ((losers ? "Losers " : "") + grouping.Name).ToUpper(),
                        Font = "Exo2.0-Bold",
                        Origin = Anchor.TopCentre,
                        Anchor = Anchor.TopCentre
                    },
                }
            };
        }
    }
}
