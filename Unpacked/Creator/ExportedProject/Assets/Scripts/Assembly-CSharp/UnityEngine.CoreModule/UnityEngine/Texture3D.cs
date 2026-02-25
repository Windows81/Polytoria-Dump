namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
[Token(Token = "0x20000E3")]
public sealed class Texture3D : Texture
{

	[Token(Token = "0x170000FD")]
	public int depth
	{
		[Address(RVA = "0x19558E0", Offset = "0x1954AE0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetTextureLayerCount")]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000FE")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x19559A0", Offset = "0x1954BA0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x1955860", Offset = "0x1954A60", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005DF")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	[Address(RVA = "0x1955750", Offset = "0x1954950", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005E4")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	[Address(RVA = "0x1955320", Offset = "0x1954520", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005E3")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[Address(RVA = "0x1955050", Offset = "0x1954250", Length = "0xB8")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_whiteTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_blackTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_transparentTexture3D", ReturnType = typeof(Texture3D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005E2")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x1955690", Offset = "0x1954890", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005DB")]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x1955110", Offset = "0x1954310", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsInvalidInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60005DC")]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x19555E0", Offset = "0x19547E0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x60005DD")]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x1955170", Offset = "0x1954370", Length = "0x1AC")]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture3D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60005DE")]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x1955820", Offset = "0x1954A20", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005E0")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	[Address(RVA = "0x19553E0", Offset = "0x19545E0", Length = "0x1F2")]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture3D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005E1")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[Address(RVA = "0x1954A80", Offset = "0x1953C80", Length = "0xB0")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_whiteTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_blackTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_transparentTexture3D", ReturnType = typeof(Texture3D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	[Token(Token = "0x60005E6")]
	public void Apply() { }

	[Address(RVA = "0x1954B40", Offset = "0x1953D40", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005E5")]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x19549E0", Offset = "0x1953BE0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	[Token(Token = "0x60005D8")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x1954980", Offset = "0x1953B80", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005EA")]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x19558E0", Offset = "0x1954AE0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetTextureLayerCount")]
	[Token(Token = "0x60005D4")]
	public int get_depth() { }

	[Address(RVA = "0x19558A0", Offset = "0x1954AA0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005E8")]
	private static int get_depth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19559A0", Offset = "0x1954BA0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005D5")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x1955960", Offset = "0x1954B60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005E9")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1954C70", Offset = "0x1953E70", Length = "0xE5")]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005D7")]
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x1954C10", Offset = "0x1953E10", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Texture3DScripting::Create")]
	[Token(Token = "0x60005D6")]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x1954DC0", Offset = "0x1953FC0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60005D9")]
	public void SetPixels(Color[] colors, int miplevel) { }

	[Address(RVA = "0x1954EE0", Offset = "0x19540E0", Length = "0x108")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_whiteTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_blackTexture3D", ReturnType = typeof(Texture3D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_transparentTexture3D", ReturnType = typeof(Texture3D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005DA")]
	public void SetPixels(Color[] colors) { }

	[Address(RVA = "0x1954D60", Offset = "0x1953F60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005EB")]
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	[Address(RVA = "0x1954FF0", Offset = "0x19541F0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005E7")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

