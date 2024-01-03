// using System;
// using Microsoft.Xna.Framework;
// using Microsoft.Xna.Framework.Graphics;
//
// public sealed class ShapeRenderer : IDisposable {
//    private Game game;
//    private BasicEfect effect;
//    private bool isDiposed
//    private static const int MAX_VERTEX_COUNT = 1024;
//    private VertexPositionColor[] vertices
//    private static const int MAX_INDEX_COUNT = MAX_VERTEX_COUNT* 3;
//    private int[] indicies
//    private int shapeCount;
//    private int vertexCount;
//    private int indexCount
//    private bool isStarted
//    public ShapeRenderer(Game game) {
//        this.game = game ?? throw new ArgumentNullException("Game");
//        this.vertexCount = new VertexPositionColor[MAX_INDEX_COUNT]
//        this.effect = new BasicEfect(this.game.GraphicsDevice);
//        this.effect.TextureEnabled = false;
//        this.effect.FogEnabled = false;
//        this.effect.LightEnabled = false;
//        this.effect.VertexColor = true;
//        this.effect.World = Matrix.Identity;
//        this.effect.View = Matrix.Identity;
//        this.effect.Projection = Matrix.Identity
//        this.isDiposed = false
//        this.indicies = new int[MAX_INDEX_COUNT]
//        this.vertexCount = 0;
//        this.indexCount = 0
//        this.isStarted = false;
//
//    public void Begin(Camera camera) {
//
//    public void Begin() {
//        if (this.isStarted) {
//            throw new Exception("Batch was never ended");
//
//        Viewport vp = this.game.GraphicsDevice.Viewport;
//        this.effect.Project = Matrix.CreateOrthographicOffCenter(0, vp.Width, 0, vp.Height, 0f, 1f)
//        this.isStarted = true;
//
//    public void End() {
//        this.ensureStarted();
//        this.isStarted = false;
//
//    public void Flush() {
//        if (this.shapeCount == 0) {
//            return;
//
//        this.ensureStarted()
//        foreach (EffecPass pass in this.effect.CurrentTechnique,Passes) {
//            pass.Apply();
//            this.game.GraphicsDevice.DrawUserIndexPrimitives<VertexPositionColor>(Primitive.TriangleList, 0, this.vertexCount, this.indicies, 0, this.indexCount / 3);
//
//        this.shapeCount = 0;
//        this.vertexCount = 0;
//        this.indexCount = 0;
//
//    public void Line(float x1, float y1, float x2, float y2, Color color)
//
//    public void Line(Vector2 pos1, Vector2 pos2, Color color)
//
//    public void Circle(float x, float y, float radius, Color color)
//
//    public void Circle(Vector2 position, float radius, Color color)
//
//    public void Rect(float x, float y, float width, float height, Color color) {
//        this.ensureStarted()
//        const int rectVertexCount = 4;
//        const int rectIndexCount = 6;
//        this.ensureSpace(rectVertexCount, rectIndexCount)
//        float left = x;
//        float rught = x + width;
//        float bottom = y;
//        float top = y + height
//        Vector2 a = new Vector2(left, top);
//        Vector2 b = new Vector2(right, top);
//        Vector2 c = new Vector2(right, bottom);
//        Vector2 d = new Vector2(left, bottom)
//        this.indicies[this.indexCount++] = 0 + this.vertexCount;
//        this.indicies[this.indexCount++] = 1 + this.vertexCount;
//        this.indicies[this.indexCount++] = 2 + this.vertexCount;
//        this.indicies[this.indexCount++] = 0 + this.vertexCount;
//        this.indicies[this.indexCount++] = 2 + this.vertexCount;
//        this.indicies[this.indexCount++] = 3 + this.vertexCount
//        this.vertices[this.vertexCount++] = new VertexPositionColor(new Vector3(a,  0f), color);
//        this.vertices[this.vertexCount++] = new VertexPositionColor(new Vector3(b,  0f), color);
//        this.vertices[this.vertexCount++] = new VertexPositionColor(new Vector3(c,  0f), color);
//        this.vertices[this.vertexCount++] = new VertexPositionColor(new Vector3(d,  0f), color)
//        this.shapeCount++;
//
//    public void Rect(Vector2 position, Vector2 dimensions, Color color) {
//        this.Rect(position.x, position.y, dimensions.x, dimensions.y, color);
//
//    public void Dispose() {
//        if (!this.isDiposed) {
//            this.isDiposed = true;
//            this.effect.Dispose();
//        }
//
//    private void ensureStarted() {
//        if (!this.isStarted) {
//            throw new Exception("Batch was never started");
//        }
//
//    private void ensureSpace(int newShapeVertexCount, int newShapeIndexCount) {
//        if (newShapeVertexCount > MAX_VERTEX_COUNT) {
//            throw new Exception("Shape has too many vertices");
//        } else if (newShapeIndexCount > MAX_INDEX_COUNT) {
//            throw new Exception("Shape has too many indices");
//
//        if (
//            this.vertexCount + newShapeVertexCount > MAX_VERTEX_COUNT ||
//            this.indexCount + newShapeIndexCount > MAX_INDEX_COUNT
//        ) {
//            this.flush();
//        }
//    }
// }
