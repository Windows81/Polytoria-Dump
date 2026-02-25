namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000656")]
public class StringReader : TextReader
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019BC")]
	private string _s; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019BD")]
	private int _pos; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40019BE")]
	private int _length; //Field offset: 0x24

	[Address(RVA = "0x147E130", Offset = "0x147D330", Length = "0xB9")]
	[CalledBy(Type = typeof(SecurityParser), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkParser", Member = "ReadTrailer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(Int32&), typeof(int)}, ReturnType = "System.Net.MonoChunkParser+State")]
	[CalledBy(Type = "System.Xml.XmlDocument", Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002EE3")]
	public StringReader(string s) { }

	[Address(RVA = "0x1354D40", Offset = "0x1353F40", Length = "0x16")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EE4")]
	public virtual void Close() { }

	[Address(RVA = "0x147DCA0", Offset = "0x147CEA0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002EE5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x147DCF0", Offset = "0x147CEF0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002EE6")]
	public virtual int Peek() { }

	[Address(RVA = "0x147E0D0", Offset = "0x147D2D0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002EE7")]
	public virtual int Read() { }

	[Address(RVA = "0x147DE90", Offset = "0x147D090", Length = "0x23F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002EE8")]
	public virtual int Read(out Char[] buffer, int index, int count) { }

	[Address(RVA = "0x147DD40", Offset = "0x147CF40", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002EEA")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x147DE30", Offset = "0x147D030", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002EE9")]
	public virtual string ReadToEnd() { }

}

