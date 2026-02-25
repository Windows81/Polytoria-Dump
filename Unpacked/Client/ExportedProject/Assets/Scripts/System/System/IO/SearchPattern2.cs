namespace System.IO;

[Token(Token = "0x20001F1")]
internal class SearchPattern2
{
	[Token(Token = "0x20001F2")]
	private class Op
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400076A")]
		public OpCode Code; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400076B")]
		public string Argument; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400076C")]
		public Op Next; //Field offset: 0x20

		[Address(RVA = "0x17C9640", Offset = "0x17C8840", Length = "0x43")]
		[CalledBy(Type = typeof(SearchPattern2), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C60")]
		public Op(OpCode code) { }

	}

	[Token(Token = "0x20001F3")]
	private enum OpCode
	{
		ExactString = 0,
		AnyChar = 1,
		AnyString = 2,
		End = 3,
		True = 4,
	}

	[Token(Token = "0x4000768")]
	internal static readonly Char[] WildcardChars; //Field offset: 0x0
	[Token(Token = "0x4000769")]
	internal static readonly Char[] InvalidChars; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000764")]
	private Op ops; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000765")]
	private bool ignore; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000766")]
	private bool hasWildcard; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000767")]
	private string pattern; //Field offset: 0x20

	[Token(Token = "0x17000266")]
	public bool HasWildcard
	{
		[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C5D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17CB9B0", Offset = "0x17CABB0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5F")]
	private static SearchPattern2() { }

	[Address(RVA = "0x17CBB50", Offset = "0x17CAD50", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SearchPattern2), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C5B")]
	public SearchPattern2(string pattern) { }

	[Address(RVA = "0x17CBB00", Offset = "0x17CAD00", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SearchPattern2), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C5C")]
	public SearchPattern2(string pattern, bool ignore) { }

	[Address(RVA = "0x17CB630", Offset = "0x17CA830", Length = "0x372")]
	[CalledBy(Type = typeof(DefaultWatcher), Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "get_Pattern", ReturnType = typeof(SearchPattern2))]
	[CalledBy(Type = typeof(SearchPattern2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SearchPattern2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Op), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000C5E")]
	private void Compile(string pattern) { }

	[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5D")]
	public bool get_HasWildcard() { }

}

