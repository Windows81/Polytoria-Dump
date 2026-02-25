namespace System.Xml;

[Token(Token = "0x20000A5")]
internal class XmlRegisteredNonCachedStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000408")]
	protected Stream stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000409")]
	private XmlDownloadManager downloadManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400040A")]
	private string host; //Field offset: 0x38

	[Token(Token = "0x170001BD")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001BE")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001BF")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C0")]
	public virtual long Length
	{
		[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C1")]
	public virtual long Position
	{
		[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007BA")]
		 get { } //Length: 42
		[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007BB")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x16BA330", Offset = "0x16B9530", Length = "0x9F")]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDownloadManager), Member = "GetNonFileStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007A8")]
	internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host) { }

	[Address(RVA = "0x32EEB0", Offset = "0x32E0B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AB")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x32EEF0", Offset = "0x32E0F0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AC")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x16BA180", Offset = "0x16B9380", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDownloadManager), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AA")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x32EF30", Offset = "0x32E130", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AD")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x32EF60", Offset = "0x32E160", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AE")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x16BA2A0", Offset = "0x16B94A0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDownloadManager), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007A9")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x32EFC0", Offset = "0x32E1C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AF")]
	public virtual void Flush() { }

	[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B6")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B7")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B8")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B9")]
	public virtual long get_Length() { }

	[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BA")]
	public virtual long get_Position() { }

	[Address(RVA = "0x32F050", Offset = "0x32E250", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B0")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F020", Offset = "0x32E220", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B1")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x32F080", Offset = "0x32E280", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B2")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BB")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x32F0B0", Offset = "0x32E2B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B3")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x32F140", Offset = "0x32E340", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B4")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F110", Offset = "0x32E310", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B5")]
	public virtual void WriteByte(byte value) { }

}

