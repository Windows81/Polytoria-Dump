namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
[Token(Token = "0x20000A0")]
public static class CustomRenderTextureManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001D2")]
	private static Action<CustomRenderTexture> textureLoaded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001D3")]
	private static Action<CustomRenderTexture> textureUnloaded; //Field offset: 0x8

	[Address(RVA = "0x1924940", Offset = "0x1923B40", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000348")]
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[Address(RVA = "0x19249A0", Offset = "0x1923BA0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000349")]
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

