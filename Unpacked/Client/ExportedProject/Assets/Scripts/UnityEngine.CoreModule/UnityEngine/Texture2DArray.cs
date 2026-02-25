namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
[Token(Token = "0x20000E4")]
public sealed class Texture2DArray : Texture
{

	[Token(Token = "0x170000FF")]
	public static int allSlices
	{
		[Address(RVA = "0x1951D10", Offset = "0x1950F10", Length = "0x2A")]
		[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetAllTextureLayersIdentifier")]
		[Token(Token = "0x60005EC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000100")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x1951D80", Offset = "0x1950F80", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x19516F0", Offset = "0x19508F0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005F6")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x19510E0", Offset = "0x19502E0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005FD")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x19517A0", Offset = "0x19509A0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005FC")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[Address(RVA = "0x1951880", Offset = "0x1950A80", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005FB")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x1951740", Offset = "0x1950940", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005FA")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	[Address(RVA = "0x1951250", Offset = "0x1950450", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005F9")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x1951C30", Offset = "0x1950E30", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005F2")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x19511C0", Offset = "0x19503C0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005F3")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x19512B0", Offset = "0x19504B0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005F4")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x1951350", Offset = "0x1950550", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x60005F5")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x1951960", Offset = "0x1950B60", Length = "0x2CC")]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2DArray), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F8")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x1951420", Offset = "0x1950620", Length = "0x2C6")]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2DArray), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60005F7")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x1951D10", Offset = "0x1950F10", Length = "0x2A")]
	[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetAllTextureLayersIdentifier")]
	[Token(Token = "0x60005EC")]
	public static int get_allSlices() { }

	[Address(RVA = "0x1951D80", Offset = "0x1950F80", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005ED")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x1951D40", Offset = "0x1950F40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005FF")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1950DB0", Offset = "0x194FFB0", Length = "0xB2")]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2DArray), Member = "Internal_CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2DArray), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005EF")]
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x1950B90", Offset = "0x194FD90", Length = "0x215")]
	[CalledBy(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2DArray), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Texture2DArrayScripting::Create")]
	[Token(Token = "0x60005EE")]
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x1950B10", Offset = "0x194FD10", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000600")]
	private static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	[Address(RVA = "0x1950E70", Offset = "0x1950070", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005F1")]
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[Address(RVA = "0x1950FA0", Offset = "0x19501A0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005F0")]
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	[Address(RVA = "0x1951080", Offset = "0x1950280", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005FE")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

