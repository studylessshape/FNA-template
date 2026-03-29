using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace FNAStart
{
    internal class MainGame : Game
    {
        KeyboardState _keyboardPrev;
        FontSystem fontSystem;
        SpriteBatch spriteBatch;

        public MainGame()
        {
            new GraphicsDeviceManager(this);
            _keyboardPrev = new KeyboardState();
        }

        protected override void Initialize()
        {
            base.Initialize();

            spriteBatch = new SpriteBatch(GraphicsDevice);

            fontSystem = new();
            //fontSystem.AddFont(System.IO.File.ReadAllBytes(@"Content\Font.ttf"));
        }

        protected override void LoadContent()
        {

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardCur = Keyboard.GetState();

            if (_keyboardPrev.IsKeyUp(Keys.Space) && keyboardCur.IsKeyDown(Keys.Space))
            {
                Console.WriteLine("Space bar was pressed!");
            }

            _keyboardPrev = keyboardCur;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //SpriteFontBase font18 = fontSystem.GetFont(18);

            //spriteBatch.Begin();
            //spriteBatch.DrawString(font18, "Some Text", Vector2.One, Color.White);
            //spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
