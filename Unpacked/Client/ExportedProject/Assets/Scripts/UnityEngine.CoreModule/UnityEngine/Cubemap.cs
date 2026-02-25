namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[Token(Token = "0x20000E2")]
public sealed class Cubemap : Texture
{

	[Token(Token = "0x170000FC")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x1944FF0", Offset = "0x19441F0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005C6")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x1944840", Offset = "0x1943A40", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005C9")]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x19448E0", Offset = "0x1943AE0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x60005CA")]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x1944930", Offset = "0x1943B30", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x60005CB")]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x19449D0", Offset = "0x1943BD0", Length = "0x25D")]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cubemap), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60005CC")]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x1944D30", Offset = "0x1943F30", Length = "0x279")]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cubemap), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005CD")]
	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[Address(RVA = "0x1944C50", Offset = "0x1943E50", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005CE")]
	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x1944790", Offset = "0x1943990", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005CF")]
	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[Address(RVA = "0x1944C30", Offset = "0x1943E30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005D0")]
	public Cubemap(int width, TextureFormat format, int mipCount) { }

	[Address(RVA = "0x1944D00", Offset = "0x1943F00", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005D1")]
	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	[Address(RVA = "0x1944FF0", Offset = "0x19441F0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005C6")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x1944FB0", Offset = "0x19441B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005D3")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1944480", Offset = "0x1943680", Length = "0xC9")]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005C5")]
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x1944420", Offset = "0x1943620", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CubemapScripting::Create")]
	[Token(Token = "0x60005C4")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x1944550", Offset = "0x1943750", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005C7")]
	internal bool ValidateFormat(TextureFormat format, int width) { }

	[Address(RVA = "0x1944610", Offset = "0x1943810", Length = "0x114")]
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
	[Token(Token = "0x60005C8")]
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[Address(RVA = "0x1944730", Offset = "0x1943930", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005D2")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

