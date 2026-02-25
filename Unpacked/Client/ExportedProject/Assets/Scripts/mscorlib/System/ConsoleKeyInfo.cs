namespace System;

[IsReadOnly]
[Token(Token = "0x2000160")]
public struct ConsoleKeyInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000562")]
	private readonly char _keyChar; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000563")]
	private readonly ConsoleKey _key; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000564")]
	private readonly ConsoleModifiers _mods; //Field offset: 0x8

	[Token(Token = "0x17000107")]
	public ConsoleKey Key
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000106")]
	public char KeyChar
	{
		[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x14B9A80", Offset = "0x14B8C80", Length = "0xB0")]
	[CalledBy(Type = typeof(NullConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000BFA")]
	public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	[Address(RVA = "0x14B99B0", Offset = "0x14B8BB0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BFD")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x14B9990", Offset = "0x14B8B90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BFE")]
	public bool Equals(ConsoleKeyInfo obj) { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFC")]
	public ConsoleKey get_Key() { }

	[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFB")]
	public char get_KeyChar() { }

	[Address(RVA = "0x14B9A60", Offset = "0x14B8C60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BFF")]
	public virtual int GetHashCode() { }

}

