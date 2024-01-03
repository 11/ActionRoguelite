// namespace engine {
//     public sealed class Engine {
//         public static Camera camera;
//         public static ScreenManager screenManager;
//         public static SpriteBatch spriteBatch;
//         public static ShapeRenderer shapeRenderer;
//         public static GraphicsDeviceManager gfx;
//
//         public Engine() {
//             camera = new Camera();
//             screenManager = ScreenManager.Create();
//             spriteBatch = new SpriteBatch();
//             shapeRenderer = new ShapeRenderer();
//             // gfx = new GraphicsDeviceManager();
//         }
//
//         public void Initialize() {
//             screenManager.Initialize();
//         }
//
//         public void LoadContent() {
//             screenManager.LoadContent();
//         }
//
//         public void Update(GameTime gameTime) {
//             screenManager.Update(deltaTime);
//         }
//
//         public void Draw(GameTime gameTime) {
//             screenManager.Update(spriteBatch);
//         }
//
//         public void Resize() {
//
//         }
//     }
//
// }
