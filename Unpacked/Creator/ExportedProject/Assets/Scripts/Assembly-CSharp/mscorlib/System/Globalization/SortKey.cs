namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000562")]
public class SortKey
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016BE")]
	private readonly string source; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016BF")]
	private readonly Byte[] key; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016C0")]
	private readonly CompareOptions options; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40016C1")]
	private readonly int lcid; //Field offset: 0x24

	[Token(Token = "0x170005D7")]
	public override Byte[] KeyData
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002774")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005D6")]
	public override string OriginalString
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002773")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1438C10", Offset = "0x1437E10", Length = "0xDA")]
	[CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002770")]
	internal SortKey(int lcid, string source, CompareOptions opt) { }

	[Address(RVA = "0x1438B50", Offset = "0x1437D50", Length = "0x65")]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002771")]
	internal SortKey(int lcid, string source, Byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	[Address(RVA = "0x1438BC0", Offset = "0x1437DC0", Length = "0x45")]
	[CalledBy(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002772")]
	internal SortKey(string localeName, string str, CompareOptions options, Byte[] keyData) { }

	[Address(RVA = "0x1438CF0", Offset = "0x1437EF0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6002778")]
	internal SortKey() { }

	[Address(RVA = "0x14386C0", Offset = "0x14378C0", Length = "0x216")]
	[CalledBy(Type = typeof(SortKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600276F")]
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	[Address(RVA = "0x14388E0", Offset = "0x1437AE0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SortKey), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortKey), typeof(SortKey)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002775")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002774")]
	public override Byte[] get_KeyData() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002773")]
	public override string get_OriginalString() { }

	[Address(RVA = "0x1438980", Offset = "0x1437B80", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002776")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14389F0", Offset = "0x1437BF0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002777")]
	public virtual string ToString() { }

}

