namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[Token(Token = "0x2000321")]
public class GraphicsFormatUtility
{
	[Token(Token = "0x4000AAE")]
	private static readonly GraphicsFormat[] tableNoStencil; //Field offset: 0x0
	[Token(Token = "0x4000AAF")]
	private static readonly GraphicsFormat[] tableStencil; //Field offset: 0x8

	[Address(RVA = "0x1981960", Offset = "0x1980B60", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F03")]
	private static GraphicsFormatUtility() { }

	[Address(RVA = "0x1981030", Offset = "0x1980230", Length = "0x64")]
	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EFE")]
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[Address(RVA = "0x19810A0", Offset = "0x19802A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EFD")]
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	[Address(RVA = "0x19810E0", Offset = "0x19802E0", Length = "0x31")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EF5")]
	public static int GetDepthBits(GraphicsFormat format) { }

	[Address(RVA = "0x19811D0", Offset = "0x19803D0", Length = "0x28C")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EF6")]
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[Address(RVA = "0x1981160", Offset = "0x1980360", Length = "0x62")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EF4")]
	public static GraphicsFormat GetDepthStencilFormat(int depthBits) { }

	[Address(RVA = "0x1981120", Offset = "0x1980320", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EF3")]
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	[Address(RVA = "0x1981630", Offset = "0x1980830", Length = "0x71")]
	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EEE")]
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x19815B0", Offset = "0x19807B0", Length = "0x71")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.AmbientOcclusion"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EF0")]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x19814E0", Offset = "0x19806E0", Length = "0xC1")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "IsRenderTextureFormatSupportedForLinearFiltering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetLutFormat", ReturnType = typeof(RenderTextureFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "hasAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EF2")]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x1981460", Offset = "0x1980660", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = False)]
	[Token(Token = "0x6000EF1")]
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x19814A0", Offset = "0x19806A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EEF")]
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x19816B0", Offset = "0x19808B0", Length = "0x31")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EF9")]
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[Address(RVA = "0x19816F0", Offset = "0x19808F0", Length = "0x31")]
	[CalledBy(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EFA")]
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[Address(RVA = "0x1981730", Offset = "0x1980930", Length = "0x31")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EF8")]
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[Address(RVA = "0x1981770", Offset = "0x1980970", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "hasAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EFF")]
	public static bool HasAlphaChannel(GraphicsFormat format) { }

	[Address(RVA = "0x19817F0", Offset = "0x19809F0", Length = "0x62")]
	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EFC")]
	public static bool IsCompressedFormat(TextureFormat format) { }

	[Address(RVA = "0x19817B0", Offset = "0x19809B0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EFB")]
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	[Address(RVA = "0x1981860", Offset = "0x1980A60", Length = "0x31")]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	[Token(Token = "0x6000F02")]
	public static bool IsCrunchFormat(TextureFormat format) { }

	[Address(RVA = "0x19818A0", Offset = "0x1980AA0", Length = "0x31")]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000F00")]
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[Address(RVA = "0x19818E0", Offset = "0x1980AE0", Length = "0x31")]
	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000F01")]
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[Address(RVA = "0x1981920", Offset = "0x1980B20", Length = "0x31")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000EF7")]
	public static bool IsSRGBFormat(GraphicsFormat format) { }

}

