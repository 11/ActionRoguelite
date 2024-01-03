using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine {
    public sealed class SpriteRenderer : IDisposable {
        private bool isDisposed;

        private Game game;
        private SpriteBatch spriteBatch;
        private BasicEffect effect;

        public SpriteRenderer (Game game) {
            this.isDisposed = false;

            this.game = game;
            this.spriteBatch = new SpriteBatch(this.game.GraphicsDevice);
            this.effect = new BasicEffect(this.game.GraphicsDevice);
            this.effect.FogEnabled = false;
            this.effect.TextureEnabled = true;
            this.effect.LightingEnabled = false;
            this.effect.VertexColorEnabled = true;
            this.effect.World = Matrix.Identity;
            this.effect.Projection = Matrix.Identity;
            this.effect.View = Matrix.Identity;
        }

        public void Dispose () {
            if (this.isDisposed) {
                return;
            }

            this.effect.Dispose();
            this.spriteBatch?.Dispose();
            this.isDisposed = true;
        }

        public void Begin (bool isTextureFilteringEnabled) {
            SamplerState sampler = SamplerState.PointClamp;
            if (isTextureFilteringEnabled) {
                sampler = SamplerState.LinearClamp;
            }

            Viewport vp = this.game.GraphicsDevice.Viewport;
            this.effect.Projection = Matrix.CreateOrthographicOffCenter(0, vp.Width, 0, vp.Height, 0f, 1f);

            this.spriteBatch.Begin(blendState: BlendState.AlphaBlend, samplerState: sampler, rasterizerState: RasterizerState.CullNone, effect: this.effect);
        }

        public void End () {
            this.spriteBatch.End();
        }

        public void Draw (Texture2D texture, Vector2 origin, Vector2 position, Color color) {
            this.spriteBatch.Draw(texture, position, null, color, 0f, origin, 1f, SpriteEffects.FlipVertically, 0f);
        }
        public void Draw (Texture2D texture, Rectangle? srcRect, Vector2 origin, Vector2 position, float rotation, Vector2 scale, Color color) {
            this.spriteBatch.Draw(texture, position, srcRect, color, rotation, origin, scale, SpriteEffects.FlipVertically, 0f);
        }

        public void Draw (Texture2D texture, Rectangle? srcRect, Rectangle dstRect, Color color) {
            this.spriteBatch.Draw(texture, dstRect, srcRect, color, 0f, Vector2.Zero, SpriteEffects.FlipVertically, 0f);
        }
    }
}
