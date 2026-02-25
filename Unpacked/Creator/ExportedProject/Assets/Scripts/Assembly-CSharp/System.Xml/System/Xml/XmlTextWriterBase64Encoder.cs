namespace System.Xml;

[Token(Token = "0x2000007")]
internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x28

	[Address(RVA = "0x163A9C0", Offset = "0x1639BC0", Length = "0x71")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	[Address(RVA = "0x163BCC0", Offset = "0x163AEC0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000B")]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

