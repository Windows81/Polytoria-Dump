namespace System.Xml;

[Token(Token = "0x2000006")]
internal class XmlRawWriterBase64Encoder : Base64Encoder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000009")]
	private XmlRawWriter rawWriter; //Field offset: 0x28

	[Address(RVA = "0x163A9C0", Offset = "0x1639BC0", Length = "0x71")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter) { }

	[Address(RVA = "0x163A990", Offset = "0x1639B90", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

