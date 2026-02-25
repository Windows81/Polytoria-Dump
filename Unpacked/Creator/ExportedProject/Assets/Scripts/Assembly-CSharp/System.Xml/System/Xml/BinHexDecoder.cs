namespace System.Xml;

[Token(Token = "0x2000008")]
internal class BinHexDecoder : IncrementalReadDecoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private Byte[] buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000C")]
	private int curIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000D")]
	private int endIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000E")]
	private bool hasHalfByteCached; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400000F")]
	private byte cachedHalfByte; //Field offset: 0x21

	[Token(Token = "0x17000001")]
	internal virtual bool IsFull
	{
		[Address(RVA = "0x162BDA0", Offset = "0x162AFA0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000C")]
		internal get { } //Length: 10
	}

	[Address(RVA = "0x162BB80", Offset = "0x162AD80", Length = "0x21C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinHexDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Byte*), typeof(Byte*), typeof(Boolean&), typeof(Byte&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000D")]
	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	[Address(RVA = "0x162B6F0", Offset = "0x162A8F0", Length = "0x30B")]
	[CalledBy(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002640")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x600000E")]
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	[Address(RVA = "0x162BA00", Offset = "0x162AC00", Length = "0x179")]
	[CalledBy(Type = typeof(BinHexDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002640")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600000F")]
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

	[Address(RVA = "0x162BDA0", Offset = "0x162AFA0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	internal virtual bool get_IsFull() { }

}

