﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water.Graphics;
using Water.Graphics.Containers;
using Water.Graphics.Controls;
using Water.Graphics.Screens;

namespace FrivoloCo.Screens.Menu
{
    public class OptionsScreen : Screen
    {
        public override void Deinitialize()
        {
            rc.Dispose();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {

        }

        private RenderContainer rc;

        public override void Initialize()
        {
            rc = new RenderContainer(Game.GraphicsDevice)
            {
                Layout = Water.Graphics.Layout.Fill
            };

            var co = new Container()
            {
                RelativePosition = new(0, 0, 1920, 1080)
            };
            rc.AddChild(co);

            var sp = new Sprite("Assets/FrivoloCoBackground.png")
            {
                RelativePosition = new(0, 0, 1920, 1080)
            };
            co.AddChild(Game.AddObject(sp));
            AddChild(rc);

            var tb = new TextBlock(new(0, 0, 0, 0), Game.Fonts.Get("Assets/IBMPLEXSANS-MEDIUM.TTF", 40), "", Color.Black)
            {
                Layout = Water.Graphics.Layout.Fill,
                HorizontalTextAlignment = HorizontalTextAlignment.Left,
                VerticalTextAlignment = VerticalTextAlignment.Top,
                Margin = 10
            };
            tb.Text = "options coming soon :)";
            var box = new Box()
            {
                Layout = Water.Graphics.Layout.Fill,
                Margin = 10,
                Color = Color.White * 0.5f
            };
            co.AddChild(Game.AddObject(box));
            box.AddChild(Game.AddObject(tb));

            var button = new SpriteButton("Assets/back.png", "Assets/backA.png", () => { ScreenManager.ChangeScreen(new MenuScreen()); })
            {
                Layout = Water.Graphics.Layout.AnchorBottomLeft,
                RelativePosition = new(0, 0, 250, 100),
                Margin = 10
            };
            co.AddChild(Game.AddObject(button));
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
