namespace UnityEngine;

[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[Token(Token = "0x20000E0")]
[UsedByNativeCode]
public class Texture : object
{
	[Token(Token = "0x400030F")]
	public static readonly int GenerateAllMips; //Field offset: 0x0

	[Token(Token = "0x170000F8")]
	internal ColorSpace activeTextureColorSpace
	{
		[Address(RVA = "0x1956240", Offset = "0x1955440", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000570")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
		internal get { } //Length: 172
	}

	[Token(Token = "0x170000F6")]
	public int anisoLevel
	{
		[Address(RVA = "0x19566D0", Offset = "0x19558D0", Length = "0xA4")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetLutStrip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ChromaticAberrationRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfImportBase", Member = "CreateEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.Image", typeof(int), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056D")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000F0")]
	public override TextureDimension dimension
	{
		[Address(RVA = "0x1955D10", Offset = "0x1954F10", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000564")]
		 get { } //Length: 151
		[Address(RVA = "0x1956780", Offset = "0x1955980", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000565")]
		 set { } //Length: 62
	}

	[Token(Token = "0x170000F5")]
	public FilterMode filterMode
	{
		[Address(RVA = "0x1956330", Offset = "0x1955530", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056B")]
		 get { } //Length: 151
		[Address(RVA = "0x1956800", Offset = "0x1955A00", Length = "0xA4")]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056C")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000EF")]
	public override int height
	{
		[Address(RVA = "0x1955B50", Offset = "0x1954D50", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000562")]
		 get { } //Length: 151
		[Address(RVA = "0x19568B0", Offset = "0x1955AB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000563")]
		 set { } //Length: 62
	}

	[Token(Token = "0x170000F1")]
	public override bool isReadable
	{
		[Address(RVA = "0x1956410", Offset = "0x1955610", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000566")]
		 get { } //Length: 151
	}

	[Token(Token = "0x170000F7")]
	public Vector2 texelSize
	{
		[Address(RVA = "0x1956500", Offset = "0x1955700", Length = "0xA8")]
		[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetTexelSize")]
		[Token(Token = "0x600056E")]
		 get { } //Length: 168
	}

	[Token(Token = "0x170000EE")]
	public override int width
	{
		[Address(RVA = "0x1955C30", Offset = "0x1954E30", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000560")]
		 get { } //Length: 151
		[Address(RVA = "0x19568F0", Offset = "0x1955AF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000561")]
		 set { } //Length: 62
	}

	[Token(Token = "0x170000F2")]
	public TextureWrapMode wrapMode
	{
		[Address(RVA = "0x19565F0", Offset = "0x19557F0", Length = "0x97")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetWrapModeU")]
		[Token(Token = "0x6000567")]
		 get { } //Length: 151
		[Address(RVA = "0x1956B50", Offset = "0x1955D50", Length = "0xA4")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "RegenerateSVTexture", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetLutStrip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ChromaticAberrationRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.AppearanceController+<>c__DisplayClass8_0", Member = "<ProcessPlayerAppearance>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "<set_FaceID>b__169_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<set_FaceID>b__85_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000568")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000F3")]
	public TextureWrapMode wrapModeU
	{
		[Address(RVA = "0x1956970", Offset = "0x1955B70", Length = "0xA4")]
		[CalledBy(Type = "GLTFast.Schema.Sampler", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), "GLTFast.Schema.Sampler+MinFilterMode", "GLTFast.Schema.Sampler+MagFilterMode"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000569")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170000F4")]
	public TextureWrapMode wrapModeV
	{
		[Address(RVA = "0x1956A60", Offset = "0x1955C60", Length = "0xA4")]
		[CalledBy(Type = "GLTFast.Schema.Sampler", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), "GLTFast.Schema.Sampler+MinFilterMode", "GLTFast.Schema.Sampler+MagFilterMode"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056A")]
		 set { } //Length: 164
	}

	[Address(RVA = "0x19561B0", Offset = "0x19553B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000577")]
	private static Texture() { }

	[Address(RVA = "0x19561F0", Offset = "0x19553F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600055C")]
	protected Texture() { }

	[Address(RVA = "0x1955A20", Offset = "0x1954C20", Length = "0x58")]
	[CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000576")]
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	[Address(RVA = "0x1955A80", Offset = "0x1954C80", Length = "0x8A")]
	[CalledBy(Type = typeof(Texture2D), Member = "ReadPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "GetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(Texture2D), Member = "LoadRawTextureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = "ReadPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Token(Token = "0x6000575")]
	internal UnityException CreateNonReadableException(Texture t) { }

	[Address(RVA = "0x1956240", Offset = "0x1955440", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000570")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
	internal ColorSpace get_activeTextureColorSpace() { }

	[Address(RVA = "0x1955D10", Offset = "0x1954F10", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000564")]
	public override TextureDimension get_dimension() { }

	[Address(RVA = "0x1956330", Offset = "0x1955530", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056B")]
	public FilterMode get_filterMode() { }

	[Address(RVA = "0x19562F0", Offset = "0x19554F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000580")]
	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1955B50", Offset = "0x1954D50", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000562")]
	public override int get_height() { }

	[Address(RVA = "0x1956410", Offset = "0x1955610", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000566")]
	public override bool get_isReadable() { }

	[Address(RVA = "0x19563D0", Offset = "0x19555D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057B")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1956500", Offset = "0x1955700", Length = "0xA8")]
	[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetTexelSize")]
	[Token(Token = "0x600056E")]
	public Vector2 get_texelSize() { }

	[Address(RVA = "0x19564B0", Offset = "0x19556B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000583")]
	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x1955C30", Offset = "0x1954E30", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000560")]
	public override int get_width() { }

	[Address(RVA = "0x19565F0", Offset = "0x19557F0", Length = "0x97")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetWrapModeU")]
	[Token(Token = "0x6000567")]
	public TextureWrapMode get_wrapMode() { }

	[Address(RVA = "0x19565B0", Offset = "0x19557B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057C")]
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1955B50", Offset = "0x1954D50", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ThreadSafe]
	[Token(Token = "0x600055E")]
	private int GetDataHeight() { }

	[Address(RVA = "0x1955B10", Offset = "0x1954D10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000579")]
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1955C30", Offset = "0x1954E30", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ThreadSafe]
	[Token(Token = "0x600055D")]
	private int GetDataWidth() { }

	[Address(RVA = "0x1955BF0", Offset = "0x1954DF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000578")]
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1955D10", Offset = "0x1954F10", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ThreadSafe]
	[Token(Token = "0x600055F")]
	private TextureDimension GetDimension() { }

	[Address(RVA = "0x1955CD0", Offset = "0x1954ED0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057A")]
	private static TextureDimension GetDimension_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1955E00", Offset = "0x1955000", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000571")]
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	[Address(RVA = "0x1955DB0", Offset = "0x1954FB0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000572")]
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	[Address(RVA = "0x1955E50", Offset = "0x1955050", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetActiveTextureColorSpace")]
	[Token(Token = "0x600056F")]
	private int Internal_GetActiveTextureColorSpace() { }

	[Address(RVA = "0x1955E10", Offset = "0x1955010", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000584")]
	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19566D0", Offset = "0x19558D0", Length = "0xA4")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ChromaticAberrationRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "CreateEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.Image", typeof(int), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetLutStrip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056D")]
	public void set_anisoLevel(int value) { }

	[Address(RVA = "0x1956690", Offset = "0x1955890", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000582")]
	private static void set_anisoLevel_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1956780", Offset = "0x1955980", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000565")]
	public override void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x1956800", Offset = "0x1955A00", Length = "0xA4")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056C")]
	public void set_filterMode(FilterMode value) { }

	[Address(RVA = "0x19567C0", Offset = "0x19559C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000581")]
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	[Address(RVA = "0x19568B0", Offset = "0x1955AB0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000563")]
	public override void set_height(int value) { }

	[Address(RVA = "0x19568F0", Offset = "0x1955AF0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000561")]
	public override void set_width(int value) { }

	[Address(RVA = "0x1956B50", Offset = "0x1955D50", Length = "0xA4")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalLogLut", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<set_FaceID>b__85_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceController+<>c__DisplayClass8_0", Member = "<ProcessPlayerAppearance>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ChromaticAberrationRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "<set_FaceID>b__169_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer", Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.PostProcessing.PropertySheet", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetLutStrip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "RegenerateSVTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Monitor", Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "CheckInternalStripLut", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000568")]
	public void set_wrapMode(TextureWrapMode value) { }

	[Address(RVA = "0x1956B10", Offset = "0x1955D10", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057D")]
	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x1956970", Offset = "0x1955B70", Length = "0xA4")]
	[CalledBy(Type = "GLTFast.Schema.Sampler", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), "GLTFast.Schema.Sampler+MinFilterMode", "GLTFast.Schema.Sampler+MagFilterMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000569")]
	public void set_wrapModeU(TextureWrapMode value) { }

	[Address(RVA = "0x1956930", Offset = "0x1955B30", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057E")]
	private static void set_wrapModeU_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x1956A60", Offset = "0x1955C60", Length = "0xA4")]
	[CalledBy(Type = "GLTFast.Schema.Sampler", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), "GLTFast.Schema.Sampler+MinFilterMode", "GLTFast.Schema.Sampler+MagFilterMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056A")]
	public void set_wrapModeV(TextureWrapMode value) { }

	[Address(RVA = "0x1956A20", Offset = "0x1955C20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057F")]
	private static void set_wrapModeV_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x1955EF0", Offset = "0x19550F0", Length = "0x194")]
	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "CanDecompressFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCompressedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000573")]
	internal bool ValidateFormat(TextureFormat format) { }

	[Address(RVA = "0x1956090", Offset = "0x1955290", Length = "0x117")]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000574")]
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

}

