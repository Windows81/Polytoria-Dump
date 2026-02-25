namespace System.Xml;

[Token(Token = "0x2000005")]
internal abstract class Base64Encoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private Byte[] leftOverBytes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000007")]
	private int leftOverBytesCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	private Char[] charsLine; //Field offset: 0x20

	[Address(RVA = "0x162B690", Offset = "0x162A890", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	internal Base64Encoder() { }

	[Address(RVA = "0x162B200", Offset = "0x162A400", Length = "0x3B6")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000006")]
	internal void Encode(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x162B5C0", Offset = "0x162A7C0", Length = "0xC1")]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEndDocument", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlTextWriter+Token"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoCompleteAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "FlushEncoders", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	internal void Flush() { }

	[Token(Token = "0x6000005")]
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

}

