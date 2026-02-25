namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Camera/CameraUtil.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000A9")]
public sealed class GL
{

	[Token(Token = "0x1700009C")]
	public static Matrix4x4 modelview
	{
		[Address(RVA = "0x192A200", Offset = "0x1929400", Length = "0x52")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000382")]
		 set { } //Length: 82
	}

	[Address(RVA = "0x1929A30", Offset = "0x1928C30", Length = "0x31")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLBegin", ThrowsException = True)]
	[Token(Token = "0x600038B")]
	public static void Begin(int mode) { }

	[Address(RVA = "0x1929AE0", Offset = "0x1928CE0", Length = "0x59")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038F")]
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Address(RVA = "0x1929A70", Offset = "0x1928C70", Length = "0x61")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderRootTree", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038E")]
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x1929B40", Offset = "0x1928D40", Length = "0x43")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<BlitInfo>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawLinesGLLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000380")]
	public static void Color(Color c) { }

	[Address(RVA = "0x1929B90", Offset = "0x1928D90", Length = "0x2A")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLEnd")]
	[Token(Token = "0x600038C")]
	public static void End() { }

	[Address(RVA = "0x1929D80", Offset = "0x1928F80", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLGetGPUProjectionMatrix")]
	[Token(Token = "0x6000388")]
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[Address(RVA = "0x1929D20", Offset = "0x1928F20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000393")]
	private static void GetGPUProjectionMatrix_Injected(in Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	[Address(RVA = "0x1929C30", Offset = "0x1928E30", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x600038D")]
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x1929BC0", Offset = "0x1928DC0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000394")]
	private static void GLClear_Injected(bool clearDepth, bool clearColor, in Color backgroundColor, float depth) { }

	[Address(RVA = "0x1929CA0", Offset = "0x1928EA0", Length = "0x72")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction]
	[Token(Token = "0x6000389")]
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	[Address(RVA = "0x1929DF0", Offset = "0x1928FF0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("ImmediateColor")]
	[Token(Token = "0x600037F")]
	private static void ImmediateColor(float r, float g, float b, float a) { }

	[Address(RVA = "0x1929E70", Offset = "0x1929070", Length = "0x2A")]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawQuads2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLLoadOrthoScript")]
	[Token(Token = "0x6000385")]
	public static void LoadOrtho() { }

	[Address(RVA = "0x1929CA0", Offset = "0x1928EA0", Length = "0x72")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038A")]
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[Address(RVA = "0x1929EA0", Offset = "0x19290A0", Length = "0x2A")]
	[CalledBy(Type = "LTSpline", Member = "drawLinesGLLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLLoadPixelMatrixScript")]
	[Token(Token = "0x6000386")]
	public static void LoadPixelMatrix() { }

	[Address(RVA = "0x1929F10", Offset = "0x1929110", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLLoadProjectionMatrixScript")]
	[Token(Token = "0x6000387")]
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[Address(RVA = "0x1929ED0", Offset = "0x19290D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000392")]
	private static void LoadProjectionMatrix_Injected(in Matrix4x4 mat) { }

	[Address(RVA = "0x1929F50", Offset = "0x1929150", Length = "0x2A")]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawQuads2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawLinesGLLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLPopMatrixScript")]
	[Token(Token = "0x6000384")]
	public static void PopMatrix() { }

	[Address(RVA = "0x1929F80", Offset = "0x1929180", Length = "0x2A")]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawQuads2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawLinesGLLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GLPushMatrixScript")]
	[Token(Token = "0x6000383")]
	public static void PushMatrix() { }

	[Address(RVA = "0x192A200", Offset = "0x1929400", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000382")]
	public static void set_modelview(Matrix4x4 value) { }

	[Address(RVA = "0x1929FF0", Offset = "0x19291F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000381")]
	private static void SetViewMatrix(Matrix4x4 m) { }

	[Address(RVA = "0x1929FB0", Offset = "0x19291B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000391")]
	private static void SetViewMatrix_Injected(in Matrix4x4 m) { }

	[Address(RVA = "0x192A030", Offset = "0x1929230", Length = "0x4D")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600037E")]
	public static void TexCoord2(float x, float y) { }

	[Address(RVA = "0x192A080", Offset = "0x1929280", Length = "0x5E")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<BlitInfo>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("ImmediateTexCoordAll")]
	[Token(Token = "0x600037D")]
	public static void TexCoord3(float x, float y, float z) { }

	[Address(RVA = "0x192A140", Offset = "0x1929340", Length = "0x3E")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600037C")]
	public static void Vertex(Vector3 v) { }

	[Address(RVA = "0x192A0E0", Offset = "0x19292E0", Length = "0x5E")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<BlitInfo>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("ImmediateVertex")]
	[Token(Token = "0x600037B")]
	public static void Vertex3(float x, float y, float z) { }

	[Address(RVA = "0x192A1C0", Offset = "0x19293C0", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "EndBlit", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SetGLViewport")]
	[Token(Token = "0x6000390")]
	public static void Viewport(Rect pixelRect) { }

	[Address(RVA = "0x192A180", Offset = "0x1929380", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000395")]
	private static void Viewport_Injected(in Rect pixelRect) { }

}

