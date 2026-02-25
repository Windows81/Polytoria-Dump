namespace System.Net;

[Token(Token = "0x200027C")]
internal class ContentDecodeStream : WebReadStream
{
	[Token(Token = "0x200027D")]
	public enum Mode
	{
		GZip = 0,
		Deflate = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A3A")]
	private readonly Stream <OriginalInnerStream>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000339")]
	private Stream OriginalInnerStream
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FD8")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x17E9B70", Offset = "0x17E8D70", Length = "0x32")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FD9")]
	private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	[Address(RVA = "0x17E9CA0", Offset = "0x17E8EA0", Length = "0xDF")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FD7")]
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	[Address(RVA = "0x17E9D80", Offset = "0x17E8F80", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FDB")]
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FD8")]
	private Stream get_OriginalInnerStream() { }

	[Address(RVA = "0x17DF4F0", Offset = "0x17DE6F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FDA")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

