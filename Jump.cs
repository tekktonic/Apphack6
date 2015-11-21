using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JumpGame
{
    public class Jump : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch batch;
        
        public Jump()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            batch = new SpriteBatch(GraphicsDevice);
        }
        protected override void Update(GameTime gt)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            base.Update(gt);
        }

        protected override void Draw(GameTime gt)
        {
            GraphicsDevice.Clear(Color.HotPink);
            base.Draw(gt);
        }
        
        public static void Main()
        {
            System.Console.WriteLine("Test");
            try
            {
                using (Jump game = new Jump())
                    game.Run();
            }catch (EntryPointNotFoundException e)
            {
            }
        }
    }

    public class KeyboardStateEventArgs : EventArgs {
		public KeyboardStateEventArgs(KeyboardState state) : base()
		{
			keyState = state;
		}
		public KeyboardState keyState { get; set;}
	}
}