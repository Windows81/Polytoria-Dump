namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
[Token(Token = "0x20000E5")]
public sealed class CubemapArray : Texture
{

	[Token(Token = "0x17000101")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x19443A0", Offset = "0x19435A0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000601")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x1943DB0", Offset = "0x1942FB0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000604")]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x19441C0", Offset = "0x19433C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000605")]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x1944210", Offset = "0x1943410", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000606")]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x1943BE0", Offset = "0x1942DE0", Length = "0x197")]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CubemapArray), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CubemapArray), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000607")]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x1943E60", Offset = "0x1943060", Length = "0x1DD")]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CubemapArray), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CubemapArray), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000608")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x1943D80", Offset = "0x1942F80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000609")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	[Address(RVA = "0x1944040", Offset = "0x1943240", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600060A")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x1944100", Offset = "0x1943300", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x600060B")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[Address(RVA = "0x19442B0", Offset = "0x19434B0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600060C")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x19443A0", Offset = "0x19435A0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000601")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x1944360", Offset = "0x1943560", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600060E")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1943AB0", Offset = "0x1942CB0", Length = "0xC9")]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000603")]
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[Address(RVA = "0x1943A50", Offset = "0x1942C50", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CubemapArrayScripting::Create")]
	[Token(Token = "0x6000602")]
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[Address(RVA = "0x1943B80", Offset = "0x1942D80", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600060D")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

