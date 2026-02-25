namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E4")]
internal sealed class ExclusiveReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400036A")]
	private RegexRunner _ref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400036B")]
	private RegexRunner _obj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400036C")]
	private int _locked; //Field offset: 0x20

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DB")]
	public ExclusiveReference() { }

	[Address(RVA = "0x174FA70", Offset = "0x174EC70", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004D9")]
	public RegexRunner Get() { }

	[Address(RVA = "0x174FAE0", Offset = "0x174ECE0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004DA")]
	public void Release(RegexRunner obj) { }

}

