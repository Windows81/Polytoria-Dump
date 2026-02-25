namespace System.Xml;

[Token(Token = "0x200000A")]
internal class BitStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000010")]
	private UInt32[] bitStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000011")]
	private int stackPos; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000012")]
	private uint curr; //Field offset: 0x1C

	[Address(RVA = "0x162C5D0", Offset = "0x162B7D0", Length = "0x1D")]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public BitStack() { }

	[Address(RVA = "0x162C340", Offset = "0x162B540", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public bool PeekBit() { }

	[Address(RVA = "0x162C350", Offset = "0x162B550", Length = "0x56")]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000015")]
	public bool PopBit() { }

	[Address(RVA = "0x162C3B0", Offset = "0x162B5B0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000018")]
	private void PopCurr() { }

	[Address(RVA = "0x162C3F0", Offset = "0x162B5F0", Length = "0xFF")]
	[CalledBy(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueryOutputWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000014")]
	public void PushBit(bool bit) { }

	[Address(RVA = "0x162C4F0", Offset = "0x162B6F0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000017")]
	private void PushCurr() { }

}

