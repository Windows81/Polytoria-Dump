namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000654")]
public class BinaryReader : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019AA")]
	private Stream m_stream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019AB")]
	private Byte[] m_buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019AC")]
	private Decoder m_decoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019AD")]
	private Byte[] m_charBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019AE")]
	private Char[] m_singleChar; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019AF")]
	private Char[] m_charBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019B0")]
	private int m_maxCharsSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40019B1")]
	private bool m_2BytesPerChar; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40019B2")]
	private bool m_isMemoryStream; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x40019B3")]
	private bool m_leaveOpen; //Field offset: 0x46

	[Token(Token = "0x1700073B")]
	public override Stream BaseStream
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002EB0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1452040", Offset = "0x1451240", Length = "0x74")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002EAD")]
	public BinaryReader(Stream input) { }

	[Address(RVA = "0x14520C0", Offset = "0x14512C0", Length = "0x1A")]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(__BinaryParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ObjectReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.VM.Processor", Member = "IsDumpStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002EAE")]
	public BinaryReader(Stream input, Encoding encoding) { }

	[Address(RVA = "0x1451D80", Offset = "0x1450F80", Length = "0x2BB")]
	[CalledBy(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002EAF")]
	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen) { }

	[Address(RVA = "0x14504C0", Offset = "0x144F6C0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EB1")]
	public override void Close() { }

	[Address(RVA = "0x14504E0", Offset = "0x144F6E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EB2")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x14504C0", Offset = "0x144F6C0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EB3")]
	public override void Dispose() { }

	[Address(RVA = "0x14505A0", Offset = "0x144F7A0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002EC8")]
	protected override void FillBuffer(int numBytes) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EB0")]
	public override Stream get_BaseStream() { }

	[Address(RVA = "0x1450710", Offset = "0x144F910", Length = "0x383")]
	[CalledBy(Type = typeof(BinaryReader), Member = "ReadChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = "InternalEmulateRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018F460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EC3")]
	private int InternalReadChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1450AA0", Offset = "0x144FCA0", Length = "0x2A1")]
	[CalledBy(Type = typeof(BinaryReader), Member = "Read", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187E10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002640")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002EC4")]
	private int InternalReadOneChar() { }

	[Address(RVA = "0x1451B70", Offset = "0x1450D70", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryReader), Member = "InternalReadOneChar", ReturnType = typeof(int))]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[Token(Token = "0x6002EB4")]
	public override int Read() { }

	[Address(RVA = "0x1451B90", Offset = "0x1450D90", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002EC6")]
	public override int Read(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1450D50", Offset = "0x144FF50", Length = "0xAB")]
	[CalledBy(Type = typeof(ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResourceReader), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EC9")]
	protected private int Read7BitEncodedInt() { }

	[Address(RVA = "0x1450E00", Offset = "0x1450000", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002EB5")]
	public override bool ReadBoolean() { }

	[Address(RVA = "0x1450E50", Offset = "0x1450050", Length = "0x3B")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = "ReadUInt32", ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EB6")]
	public override byte ReadByte() { }

	[Address(RVA = "0x1450E90", Offset = "0x1450090", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EC7")]
	public override Byte[] ReadBytes(int count) { }

	[Address(RVA = "0x1451040", Offset = "0x1450240", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EB8")]
	public override char ReadChar() { }

	[Address(RVA = "0x1451070", Offset = "0x1450270", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BinaryReader), Member = "InternalReadChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002EC5")]
	public override Char[] ReadChars(int count) { }

	[Address(RVA = "0x14511F0", Offset = "0x14503F0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EC1")]
	public override decimal ReadDecimal() { }

	[Address(RVA = "0x1451330", Offset = "0x1450530", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverterLE), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EC0")]
	public override double ReadDouble() { }

	[Address(RVA = "0x1451370", Offset = "0x1450570", Length = "0x56")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EB9")]
	public override short ReadInt16() { }

	[Address(RVA = "0x14513D0", Offset = "0x14505D0", Length = "0x214")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = "ReadInt32", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Error), Member = "GetEndOfFile", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002EBB")]
	public override int ReadInt32() { }

	[Address(RVA = "0x14515F0", Offset = "0x14507F0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EBD")]
	public override long ReadInt64() { }

	[Address(RVA = "0x1451710", Offset = "0x1450910", Length = "0x45")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = "ReadInt32", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6002EB7")]
	public override sbyte ReadSByte() { }

	[Address(RVA = "0x1451760", Offset = "0x1450960", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverterLE), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002EBF")]
	public override float ReadSingle() { }

	[Address(RVA = "0x14517A0", Offset = "0x14509A0", Length = "0x34C")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = "ReadString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002EC2")]
	public override string ReadString() { }

	[Address(RVA = "0x1451370", Offset = "0x1450570", Length = "0x56")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EBA")]
	public override ushort ReadUInt16() { }

	[Address(RVA = "0x1451AF0", Offset = "0x1450CF0", Length = "0x7E")]
	[CalledBy(Type = "MoonSharp.Interpreter.IO.BinDumpBinaryReader", Member = "ReadUInt32", ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6002EBC")]
	public override uint ReadUInt32() { }

	[Address(RVA = "0x14515F0", Offset = "0x14507F0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002EBE")]
	public override ulong ReadUInt64() { }

}

