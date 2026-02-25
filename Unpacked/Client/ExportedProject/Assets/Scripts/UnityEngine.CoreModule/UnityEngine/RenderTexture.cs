namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[Token(Token = "0x20000E6")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	[Token(Token = "0x1700010D")]
	public static RenderTexture active
	{
		[Address(RVA = "0x194C160", Offset = "0x194B360", Length = "0x54")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000625")]
		 get { } //Length: 84
		[Address(RVA = "0x194DF40", Offset = "0x194D140", Length = "0x6B")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000626")]
		 set { } //Length: 107
	}

	[Token(Token = "0x17000109")]
	public bool autoGenerateMips
	{
		[Address(RVA = "0x19503D0", Offset = "0x194F5D0", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600061C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700010E")]
	public RenderBuffer colorBuffer
	{
		[Address(RVA = "0x194FA90", Offset = "0x194EC90", Length = "0xA0")]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTargetImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600062B")]
		 get { } //Length: 160
	}

	[Token(Token = "0x1700010F")]
	public RenderBuffer depthBuffer
	{
		[Address(RVA = "0x194FB40", Offset = "0x194ED40", Length = "0xA0")]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTargetImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600062C")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000108")]
	public GraphicsFormat depthStencilFormat
	{
		[Address(RVA = "0x19504A0", Offset = "0x194F6A0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600061B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000110")]
	public RenderTextureDescriptor descriptor
	{
		[Address(RVA = "0x194FBF0", Offset = "0x194EDF0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000648")]
		 get { } //Length: 213
	}

	[Token(Token = "0x17000104")]
	public virtual TextureDimension dimension
	{
		[Address(RVA = "0x194FD10", Offset = "0x194EF10", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000613")]
		 get { } //Length: 118
		[Address(RVA = "0x1950570", Offset = "0x194F770", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000614")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700010B")]
	public bool enableRandomWrite
	{
		[Address(RVA = "0x194FDD0", Offset = "0x194EFD0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600061F")]
		 get { } //Length: 118
		[Address(RVA = "0x1950650", Offset = "0x194F850", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000620")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000107")]
	public RenderTextureFormat format
	{
		[Address(RVA = "0x194FE50", Offset = "0x194F050", Length = "0x1A1")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureFormatUtilities", Member = "GetUncompressedRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTextureFormat))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureFormat))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600061A")]
		 get { } //Length: 417
	}

	[Token(Token = "0x17000105")]
	public GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0x1950000", Offset = "0x194F200", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000617")]
		 get { } //Length: 120
		[Address(RVA = "0x194DFF0", Offset = "0x194D1F0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000618")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000103")]
	public virtual int height
	{
		[Address(RVA = "0x19500C0", Offset = "0x194F2C0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000611")]
		 get { } //Length: 118
		[Address(RVA = "0x1950720", Offset = "0x194F920", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000612")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700010C")]
	public bool useDynamicScale
	{
		[Address(RVA = "0x1950180", Offset = "0x194F380", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000621")]
		 get { } //Length: 118
		[Address(RVA = "0x1950800", Offset = "0x194FA00", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000622")]
		 set { } //Length: 134
	}

	[NativeProperty("MipMap")]
	[Token(Token = "0x17000106")]
	public bool useMipMap
	{
		[Address(RVA = "0x19508E0", Offset = "0x194FAE0", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000619")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700010A")]
	public int volumeDepth
	{
		[Address(RVA = "0x1950240", Offset = "0x194F440", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600061D")]
		 get { } //Length: 118
		[Address(RVA = "0x19509B0", Offset = "0x194FBB0", Length = "0x83")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600061E")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000102")]
	public virtual int width
	{
		[Address(RVA = "0x1950300", Offset = "0x194F500", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600060F")]
		 get { } //Length: 118
		[Address(RVA = "0x1950A80", Offset = "0x194FC80", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000610")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x194F760", Offset = "0x194E960", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x600063D")]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x194F0C0", Offset = "0x194E2C0", Length = "0x2ED")]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ExcludeFromDocs]
	[Token(Token = "0x600063B")]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[Address(RVA = "0x194F690", Offset = "0x194E890", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000641")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	[Address(RVA = "0x194E9D0", Offset = "0x194DBD0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x600063A")]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	[Address(RVA = "0x194F490", Offset = "0x194E690", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000639")]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[Address(RVA = "0x194F800", Offset = "0x194EA00", Length = "0x28B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000638")]
	public RenderTexture(RenderTexture textureToCopy) { }

	[Address(RVA = "0x194EE80", Offset = "0x194E080", Length = "0x116")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000640")]
	public RenderTexture(int width, int height, int depth) { }

	[Address(RVA = "0x194EA70", Offset = "0x194DC70", Length = "0x2C4")]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ExcludeFromDocs]
	[Token(Token = "0x600063C")]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[Address(RVA = "0x194EFA0", Offset = "0x194E1A0", Length = "0x116")]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlasPage", Member = "CreateAtlasTexture", ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600063F")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	[Address(RVA = "0x194F3B0", Offset = "0x194E5B0", Length = "0xDD")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600063E")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x194ED40", Offset = "0x194DF40", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000637")]
	public RenderTexture(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194F610", Offset = "0x194E810", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000636")]
	protected private RenderTexture() { }

	[Address(RVA = "0x194C0B0", Offset = "0x194B2B0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "DoLazyInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062D")]
	public bool Create() { }

	[Address(RVA = "0x194C070", Offset = "0x194B270", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000670")]
	private static bool Create_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194C160", Offset = "0x194B360", Length = "0x54")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000625")]
	public static RenderTexture get_active() { }

	[Address(RVA = "0x194FA90", Offset = "0x194EC90", Length = "0xA0")]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTargetImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062B")]
	public RenderBuffer get_colorBuffer() { }

	[Address(RVA = "0x194FB40", Offset = "0x194ED40", Length = "0xA0")]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTargetImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062C")]
	public RenderBuffer get_depthBuffer() { }

	[Address(RVA = "0x194FBF0", Offset = "0x194EDF0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000648")]
	public RenderTextureDescriptor get_descriptor() { }

	[Address(RVA = "0x194FD10", Offset = "0x194EF10", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000613")]
	public virtual TextureDimension get_dimension() { }

	[Address(RVA = "0x194FCD0", Offset = "0x194EED0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065D")]
	private static TextureDimension get_dimension_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194FDD0", Offset = "0x194EFD0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061F")]
	public bool get_enableRandomWrite() { }

	[Address(RVA = "0x194FD90", Offset = "0x194EF90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000666")]
	private static bool get_enableRandomWrite_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194FE50", Offset = "0x194F050", Length = "0x1A1")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureFormatUtilities", Member = "GetUncompressedRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTextureFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600061A")]
	public RenderTextureFormat get_format() { }

	[Address(RVA = "0x1950000", Offset = "0x194F200", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000617")]
	public GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x19500C0", Offset = "0x194F2C0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000611")]
	public virtual int get_height() { }

	[Address(RVA = "0x1950080", Offset = "0x194F280", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065B")]
	private static int get_height_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1950180", Offset = "0x194F380", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000621")]
	public bool get_useDynamicScale() { }

	[Address(RVA = "0x1950140", Offset = "0x194F340", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000668")]
	private static bool get_useDynamicScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1950240", Offset = "0x194F440", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061D")]
	public int get_volumeDepth() { }

	[Address(RVA = "0x1950200", Offset = "0x194F400", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000664")]
	private static int get_volumeDepth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1950300", Offset = "0x194F500", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600060F")]
	public virtual int get_width() { }

	[Address(RVA = "0x19502C0", Offset = "0x194F4C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000659")]
	private static int get_width_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194C160", Offset = "0x194B360", Length = "0x54")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("RenderTexture::GetActiveAsRenderTexture")]
	[Token(Token = "0x6000623")]
	private static RenderTexture GetActive() { }

	[Address(RVA = "0x194C130", Offset = "0x194B330", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066A")]
	private static IntPtr GetActive_Injected() { }

	[Address(RVA = "0x194C210", Offset = "0x194B410", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6000627")]
	private RenderBuffer GetColorBuffer() { }

	[Address(RVA = "0x194C1C0", Offset = "0x194B3C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066C")]
	private static void GetColorBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	[Address(RVA = "0x194C2F0", Offset = "0x194B4F0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetColorFormat")]
	[Token(Token = "0x6000615")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	[Address(RVA = "0x194C2A0", Offset = "0x194B4A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065F")]
	private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings) { }

	[Address(RVA = "0x194C380", Offset = "0x194B580", Length = "0x128")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemInfo), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600064F")]
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x194C4B0", Offset = "0x194B6B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Token(Token = "0x600064A")]
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	[Address(RVA = "0x194C4D0", Offset = "0x194B6D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064B")]
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[Address(RVA = "0x194C550", Offset = "0x194B750", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6000628")]
	private RenderBuffer GetDepthBuffer() { }

	[Address(RVA = "0x194C500", Offset = "0x194B700", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066D")]
	private static void GetDepthBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	[Address(RVA = "0x194C630", Offset = "0x194B830", Length = "0xFD")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_depthBufferBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDefaultDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat), typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ShadowSamplingMode)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000647")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	[Address(RVA = "0x194C5E0", Offset = "0x194B7E0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000646")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode) { }

	[Address(RVA = "0x194C740", Offset = "0x194B940", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000645")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	[Address(RVA = "0x194C5F0", Offset = "0x194B7F0", Length = "0x3D")]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000644")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = false) { }

	[Address(RVA = "0x194C730", Offset = "0x194B930", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Token(Token = "0x6000643")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	[Address(RVA = "0x194C7A0", Offset = "0x194B9A0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetRenderTextureDesc")]
	[Token(Token = "0x6000633")]
	private RenderTextureDescriptor GetDescriptor() { }

	[Address(RVA = "0x194C750", Offset = "0x194B950", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000675")]
	private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret) { }

	[Address(RVA = "0x194C840", Offset = "0x194BA40", Length = "0x10")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064D")]
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	[Address(RVA = "0x194C840", Offset = "0x194BA40", Length = "0x10")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064C")]
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	[Address(RVA = "0x194CC90", Offset = "0x194BE90", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000654")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[Address(RVA = "0x194D770", Offset = "0x194C970", Length = "0x217")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000652")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[Address(RVA = "0x194D4D0", Offset = "0x194C6D0", Length = "0x8C")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000650")]
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194D0B0", Offset = "0x194C2B0", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000655")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[Address(RVA = "0x194D2C0", Offset = "0x194C4C0", Length = "0x205")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000656")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x194D560", Offset = "0x194C760", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000657")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[Address(RVA = "0x194CEA0", Offset = "0x194C0A0", Length = "0x20B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000653")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[Address(RVA = "0x194CAB0", Offset = "0x194BCB0", Length = "0x1D4")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x6000658")]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[Address(RVA = "0x194CA50", Offset = "0x194BC50", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	[Token(Token = "0x6000634")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194CA10", Offset = "0x194BC10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000676")]
	private static IntPtr GetTemporary_Internal_Injected(in RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194C850", Offset = "0x194BA50", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000651")]
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false, ShadowSamplingMode shadowSamplingMode = 2) { }

	[Address(RVA = "0x194D990", Offset = "0x194CB90", Length = "0x2FA")]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000642")]
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[Address(RVA = "0x194DC90", Offset = "0x194CE90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("RenderTextureScripting::Create")]
	[Token(Token = "0x6000631")]
	private static void Internal_Create(RenderTexture rt) { }

	[Address(RVA = "0x194DD10", Offset = "0x194CF10", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "DoLazyInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062F")]
	public bool IsCreated() { }

	[Address(RVA = "0x194DCD0", Offset = "0x194CED0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000672")]
	private static bool IsCreated_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194DE80", Offset = "0x194D080", Length = "0x76")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "EndGenSession", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "DoLazyInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062E")]
	public void Release() { }

	[Address(RVA = "0x194DE40", Offset = "0x194D040", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000671")]
	private static void Release_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x194DDD0", Offset = "0x194CFD0", Length = "0x6B")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	[Token(Token = "0x6000635")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	[Address(RVA = "0x194DD90", Offset = "0x194CF90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000677")]
	private static void ReleaseTemporary_Injected(IntPtr temp) { }

	[Address(RVA = "0x194DF40", Offset = "0x194D140", Length = "0x6B")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000626")]
	public static void set_active(RenderTexture value) { }

	[Address(RVA = "0x19503D0", Offset = "0x194F5D0", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061C")]
	public void set_autoGenerateMips(bool value) { }

	[Address(RVA = "0x1950380", Offset = "0x194F580", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000663")]
	private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19504A0", Offset = "0x194F6A0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061B")]
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[Address(RVA = "0x1950460", Offset = "0x194F660", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000662")]
	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	[Address(RVA = "0x1950570", Offset = "0x194F770", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000614")]
	public virtual void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x1950530", Offset = "0x194F730", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065E")]
	private static void set_dimension_Injected(IntPtr _unity_self, TextureDimension value) { }

	[Address(RVA = "0x1950650", Offset = "0x194F850", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000620")]
	public void set_enableRandomWrite(bool value) { }

	[Address(RVA = "0x1950600", Offset = "0x194F800", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000667")]
	private static void set_enableRandomWrite_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x194DFF0", Offset = "0x194D1F0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000618")]
	public void set_graphicsFormat(GraphicsFormat value) { }

	[Address(RVA = "0x1950720", Offset = "0x194F920", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000612")]
	public virtual void set_height(int value) { }

	[Address(RVA = "0x19506E0", Offset = "0x194F8E0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065C")]
	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1950800", Offset = "0x194FA00", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CheckAOTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000622")]
	public void set_useDynamicScale(bool value) { }

	[Address(RVA = "0x19507B0", Offset = "0x194F9B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000669")]
	private static void set_useDynamicScale_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19508E0", Offset = "0x194FAE0", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "CheckRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&), typeof(int), typeof(int), typeof(FilterMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000619")]
	public void set_useMipMap(bool value) { }

	[Address(RVA = "0x1950890", Offset = "0x194FA90", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000661")]
	private static void set_useMipMap_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19509B0", Offset = "0x194FBB0", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061E")]
	public void set_volumeDepth(int value) { }

	[Address(RVA = "0x1950970", Offset = "0x194FB70", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000665")]
	private static void set_volumeDepth_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1950A80", Offset = "0x194FC80", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000610")]
	public virtual void set_width(int value) { }

	[Address(RVA = "0x1950A40", Offset = "0x194FC40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065A")]
	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x194DF40", Offset = "0x194D140", Length = "0x6B")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("RenderTextureScripting::SetActive")]
	[Token(Token = "0x6000624")]
	private static void SetActive(RenderTexture rt) { }

	[Address(RVA = "0x194DF00", Offset = "0x194D100", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066B")]
	private static void SetActive_Injected(IntPtr rt) { }

	[Address(RVA = "0x194DFF0", Offset = "0x194D1F0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("SetColorFormat")]
	[Token(Token = "0x6000616")]
	private void SetColorFormat(GraphicsFormat format) { }

	[Address(RVA = "0x194DFB0", Offset = "0x194D1B0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000660")]
	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	[Address(RVA = "0x194E0C0", Offset = "0x194D2C0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000629")]
	private void SetMipMapCount(int count) { }

	[Address(RVA = "0x194E080", Offset = "0x194D280", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066E")]
	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	[Address(RVA = "0x194E1A0", Offset = "0x194D3A0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetRenderTextureDescFromScript")]
	[Token(Token = "0x6000632")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194E150", Offset = "0x194D350", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000674")]
	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, in RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194E350", Offset = "0x194D550", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062A")]
	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	[Address(RVA = "0x194E310", Offset = "0x194D510", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066F")]
	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	[Address(RVA = "0x194E280", Offset = "0x194D480", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000630")]
	internal void SetSRGBReadWrite(bool srgb) { }

	[Address(RVA = "0x194E230", Offset = "0x194D430", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000673")]
	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	[Address(RVA = "0x194E3E0", Offset = "0x194D5E0", Length = "0x55D")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporaryImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(bool), typeof(ShadowSamplingMode)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000649")]
	private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x194E940", Offset = "0x194DB40", Length = "0x8B")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless), typeof(VRTextureUsage)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600064E")]
	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

}

