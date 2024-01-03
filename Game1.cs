using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine;

namespace ActionRoguelite;

public class Game1 : Game {
    private GraphicsDeviceManager graphics;
    private SpriteRenderer spriteRenderer;
    private Texture2D texture;

    public Game1() {
        this.graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize () {
        this.spriteRenderer = new SpriteRenderer(this);

        base.Initialize();
    }

    protected override void LoadContent () {
        this.texture = this.Content.Load<Texture2D>("smiley");
    }

    protected override void Update (GameTime gameTime) {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
            Exit();
        }

        base.Update(gameTime);
    }

    protected override void Draw (GameTime gameTime) {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        Viewport vp = this.GraphicsDevice.Viewport;

        this.spriteRenderer.Begin(false);
        this.spriteRenderer.Draw(this.texture, null, new Rectangle(32,32,512,256), Color.White);
        this.spriteRenderer.End();

        base.Draw(gameTime);
    }
}
