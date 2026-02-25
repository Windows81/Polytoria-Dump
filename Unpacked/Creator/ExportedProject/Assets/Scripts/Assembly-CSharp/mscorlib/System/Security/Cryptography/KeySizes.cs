namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002E2")]
public sealed class KeySizes
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB0")]
	private int m_minSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CB1")]
	private int m_maxSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CB2")]
	private int m_skipSize; //Field offset: 0x18

	[Token(Token = "0x1700026B")]
	public int MaxSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600179E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700026A")]
	public int MinSize
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600179D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700026C")]
	public int SkipSize
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600179F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x132BFA0", Offset = "0x132B1A0", Length = "0x44")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A0")]
	public KeySizes(int minSize, int maxSize, int skipSize) { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600179E")]
	public int get_MaxSize() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600179D")]
	public int get_MinSize() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600179F")]
	public int get_SkipSize() { }

	[Address(RVA = "0x132BF70", Offset = "0x132B170", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017A1")]
	internal bool IsLegal(int keySize) { }

	[Address(RVA = "0x132BEE0", Offset = "0x132B0E0", Length = "0x83")]
	[CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RC2), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017A2")]
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

