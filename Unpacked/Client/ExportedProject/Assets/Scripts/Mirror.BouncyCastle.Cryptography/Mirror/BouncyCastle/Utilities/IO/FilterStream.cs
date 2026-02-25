namespace Mirror.BouncyCastle.Utilities.IO;

[Token(Token = "0x200000F")]
public class FilterStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	protected readonly Stream s; //Field offset: 0x28

	[Token(Token = "0x17000007")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000054")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000008")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000055")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000009")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700000A")]
	public virtual long Length
	{
		[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000059")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700000B")]
	public virtual long Position
	{
		[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005A")]
		 get { } //Length: 42
		[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x10BBDE0", Offset = "0x10BAFE0", Length = "0xBD")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool), typeof(Byte[][])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Asn1Object), Member = "InternalGetEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Asn1OutputStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(string)}, ReturnType = typeof(Asn1OutputStream))]
	[CalledBy(Type = typeof(Asn1OutputStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(string), typeof(bool)}, ReturnType = typeof(Asn1OutputStream))]
	[CalledBy(Type = typeof(Asn1OutputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public FilterStream(Stream s) { }

	[Address(RVA = "0x10BBCF0", Offset = "0x10BAEF0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Streams), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Token(Token = "0x6000057")]
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x10BBD80", Offset = "0x10BAF80", Length = "0x8")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	protected void Detach(bool disposing) { }

	[Address(RVA = "0x10BBD90", Offset = "0x10BAF90", Length = "0x42")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000063")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x32EFC0", Offset = "0x32E1C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public virtual void Flush() { }

	[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	public virtual long get_Length() { }

	[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public virtual long get_Position() { }

	[Address(RVA = "0x32F050", Offset = "0x32E250", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005C")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F020", Offset = "0x32E220", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x32F080", Offset = "0x32E280", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x32F0B0", Offset = "0x32E2B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x32F140", Offset = "0x32E340", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F110", Offset = "0x32E310", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public virtual void WriteByte(byte value) { }

}

