namespace Mirror.BouncyCastle.Utilities.IO;

[Token(Token = "0x200000E")]
public abstract class BaseInputStream : Stream
{

	[Token(Token = "0x17000002")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000046")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000003")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000047")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000004")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000048")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000005")]
	public virtual long Length
	{
		[Address(RVA = "0x10AB8D0", Offset = "0x10AAAD0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000006")]
	public virtual long Position
	{
		[Address(RVA = "0x10AB910", Offset = "0x10AAB10", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600004C")]
		 get { } //Length: 62
		[Address(RVA = "0x10AB950", Offset = "0x10AAB50", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600004D")]
		 set { } //Length: 62
	}

	[Address(RVA = "0x10AB880", Offset = "0x10AAA80", Length = "0x49")]
	[CalledBy(Type = typeof(BerBitStringParser), Member = "GetBitStream", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(BerBitStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerBitString))]
	[CalledBy(Type = typeof(BerOctetStringParser), Member = "GetOctetStream", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(BerOctetStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerOctetString))]
	[CalledBy(Type = typeof(ConstructedBitStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstructedOctetStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LimitedInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	protected BaseInputStream() { }

	[Address(RVA = "0x10AB560", Offset = "0x10AA760", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Streams), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Token(Token = "0x6000049")]
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public virtual void Flush() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000047")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x10AB8D0", Offset = "0x10AAAD0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600004B")]
	public virtual long get_Length() { }

	[Address(RVA = "0x10AB910", Offset = "0x10AAB10", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600004C")]
	public virtual long get_Position() { }

	[Address(RVA = "0x10AB5E0", Offset = "0x10AA7E0", Length = "0x1D1")]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x10AB7C0", Offset = "0x10AA9C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600004F")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x10AB950", Offset = "0x10AAB50", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600004D")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x10AB800", Offset = "0x10AAA00", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000050")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x10AB840", Offset = "0x10AAA40", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000051")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

