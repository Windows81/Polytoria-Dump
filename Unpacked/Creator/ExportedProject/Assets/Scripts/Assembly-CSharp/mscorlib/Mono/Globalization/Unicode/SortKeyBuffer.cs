namespace Mono.Globalization.Unicode;

[Token(Token = "0x200005D")]
internal class SortKeyBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A7")]
	private Byte[] l1b; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A8")]
	private Byte[] l2b; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A9")]
	private Byte[] l3b; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AA")]
	private Byte[] l4sb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AB")]
	private Byte[] l4tb; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001AC")]
	private Byte[] l4kb; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001AD")]
	private Byte[] l4wb; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AE")]
	private Byte[] l5b; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001AF")]
	private string source; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001B0")]
	private int l1; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001B1")]
	private int l2; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001B2")]
	private int l3; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001B3")]
	private int l4s; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001B4")]
	private int l4t; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40001B5")]
	private int l4k; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001B6")]
	private int l4w; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001B7")]
	private int l5; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001B8")]
	private int lcid; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40001B9")]
	private CompareOptions options; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001BA")]
	private bool processLevel2; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x40001BB")]
	private bool frenchSort; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x40001BC")]
	private bool frenchSorted; //Field offset: 0x82

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	public SortKeyBuffer(int lcid) { }

	[Address(RVA = "0x12E6FC0", Offset = "0x12E61C0", Length = "0xB5")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendCJKExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool), typeof(byte), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendLevel5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000116")]
	private void AppendBufferPrimitive(byte value, ref Byte[] buf, ref int bidx) { }

	[Address(RVA = "0x12E7080", Offset = "0x12E6280", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000112")]
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	[Address(RVA = "0x12E7150", Offset = "0x12E6350", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000113")]
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	[Address(RVA = "0x12E7220", Offset = "0x12E6420", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000115")]
	private void AppendLevel5(byte category, byte lv1) { }

	[Address(RVA = "0x12E7300", Offset = "0x12E6500", Length = "0x1E6")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSurrogateSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortKeyBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool), typeof(byte), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000114")]
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	[Address(RVA = "0x12E74F0", Offset = "0x12E66F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000118")]
	private int GetOptimizedLength(Byte[] data, int len, byte defaultValue) { }

	[Address(RVA = "0x12E7570", Offset = "0x12E6770", Length = "0x692")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "GetResultAndReset", ReturnType = typeof(SortKey))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Byte[]), typeof(CompareOptions), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000119")]
	public SortKey GetResult() { }

	[Address(RVA = "0x12E7540", Offset = "0x12E6740", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[Token(Token = "0x6000117")]
	public SortKey GetResultAndReset() { }

	[Address(RVA = "0x12E7C10", Offset = "0x12E6E10", Length = "0x1F4")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000111")]
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	[Address(RVA = "0x12E7E10", Offset = "0x12E7010", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000110")]
	public void Reset() { }

}

