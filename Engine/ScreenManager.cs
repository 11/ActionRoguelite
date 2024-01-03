// namespace Engine {
//     public class ScreenManager {
//         private static ScreenManager self = null;
//
//         private IScreen currentScreen = null;
//
//         public static Create(IScreen firstScreen) {
//             if (currentScreen == null) {
//                 currentScreen = firstScreen;
//             }
//
//             if (self == null) {
//                 this.self = new ScreenManager();
//             }
//
//             return self;
//         }
//
//         public static Destroy() {
//             this.currentScreen = null;
//             self = null;
//         }
//
//         public void Initialize() {
//             if (currentScreen == null) {
//                 return;
//             }
//
//             currentScreen.Initialize();
//         }
//
//         public void LoadContent() {
//             if (currentScreen == null) {
//                 return;
//             }
//
//             currentScreen.LoadContent();
//         }
//
//         public void Update(float deltaTime) {
//             if (currentScreen == null) {
//                 return;
//             }
//
//             currentScreen.Update(deltaTime);
//         }
//
//         public void Draw() {
//             if (currentScreen == null) {
//                 return;
//             }
//
//             currentScreen.Draw();
//         }
//     }
// }
