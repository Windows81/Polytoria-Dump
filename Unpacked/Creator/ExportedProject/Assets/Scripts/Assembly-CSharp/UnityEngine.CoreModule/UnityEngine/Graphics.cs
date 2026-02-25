namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[Token(Token = "0x20000A8")]
public class Graphics
{
	[Token(Token = "0x40001E8")]
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	[Token(Token = "0x40001E9")]
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x8

	[Address(RVA = "0x192C3F0", Offset = "0x192B5F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000377")]
	private static Graphics() { }

	[Address(RVA = "0x192B5A0", Offset = "0x192A7A0", Length = "0x104")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnRenderImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000375")]
	public static void Blit(Texture source, RenderTexture dest) { }

	[Address(RVA = "0x192B4C0", Offset = "0x192A6C0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GraphicsScripting::Blit")]
	[Token(Token = "0x600036F")]
	private static void Blit2(Texture source, RenderTexture dest) { }

	[Address(RVA = "0x192B470", Offset = "0x192A670", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600037A")]
	private static void Blit2_Injected(IntPtr source, IntPtr dest) { }

	[Address(RVA = "0x192B6B0", Offset = "0x192A8B0", Length = "0x1D0")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000374")]
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	[Address(RVA = "0x192B890", Offset = "0x192AA90", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000373")]
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	[Address(RVA = "0x192BA90", Offset = "0x192AC90", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	[Token(Token = "0x600036D")]
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[Address(RVA = "0x192BA40", Offset = "0x192AC40", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000379")]
	private static void Internal_DrawMeshNow2_Injected(IntPtr mesh, int subsetIndex, in Matrix4x4 matrix) { }

	[Address(RVA = "0x192BB70", Offset = "0x192AD70", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.GUI", Member = "DrawTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Texture), "UnityEngine.ScaleMode", typeof(bool), typeof(float), typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Vector4), typeof(Vector4), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GraphicsScripting::DrawTexture")]
	[Token(Token = "0x600036E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[Address(RVA = "0x192BBB0", Offset = "0x192ADB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	[Token(Token = "0x600036A")]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[Address(RVA = "0x192BBE0", Offset = "0x192ADE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GraphicsScripting::SetNullRT")]
	[Token(Token = "0x600036B")]
	private static void Internal_SetNullRT() { }

	[Address(RVA = "0x192BC80", Offset = "0x192AE80", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600036C")]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x192BC10", Offset = "0x192AE10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000378")]
	private static void Internal_SetRTSimple_Injected(in RenderBuffer color, in RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x192BFE0", Offset = "0x192B1E0", Length = "0x208")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "EndBlit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000376")]
	public static void SetRenderTarget(RenderTexture rt) { }

	[Address(RVA = "0x192C1F0", Offset = "0x192B3F0", Length = "0x1F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000372")]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x192BEF0", Offset = "0x192B0F0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000370")]
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x192BD20", Offset = "0x192AF20", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000371")]
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

}

