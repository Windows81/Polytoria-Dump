namespace System;

[Token(Token = "0x2000192")]
internal sealed class SharedStatics
{
	[Token(Token = "0x4000606")]
	private static readonly SharedStatics _sharedStatics; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000607")]
	private StringMaker _maker; //Field offset: 0x10

	[Address(RVA = "0x14FE7E0", Offset = "0x14FD9E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E8D")]
	private static SharedStatics() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E8A")]
	private SharedStatics() { }

	[Address(RVA = "0x14FE550", Offset = "0x14FD750", Length = "0x170")]
	[CalledBy(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tokenizer), Member = "BasicInitialization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tokenizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1814EE580")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(StringMaker), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E8B")]
	public static StringMaker GetSharedStringMaker() { }

	[Address(RVA = "0x14FE6D0", Offset = "0x14FD8D0", Length = "0x10A")]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Tokenizer), Member = "Recycle", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1814EE580")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E8C")]
	public static void ReleaseSharedStringMaker(ref StringMaker maker) { }

}

