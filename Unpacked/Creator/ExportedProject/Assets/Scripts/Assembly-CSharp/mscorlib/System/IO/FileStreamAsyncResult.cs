namespace System.IO;

[Token(Token = "0x200065B")]
internal class FileStreamAsyncResult : IAsyncResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019D3")]
	private object state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019D4")]
	private bool completed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019D5")]
	private ManualResetEvent wh; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019D6")]
	private AsyncCallback cb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019D7")]
	private bool completedSynch; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40019D8")]
	public int Count; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019D9")]
	public int OriginalCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40019DA")]
	public int BytesRead; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019DB")]
	private AsyncCallback realcb; //Field offset: 0x40

	[Token(Token = "0x17000743")]
	public override object AsyncState
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002F2D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000745")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002F2F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000744")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002F2E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000746")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002F30")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x14707C0", Offset = "0x146F9C0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002F2B")]
	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	[Address(RVA = "0x1470730", Offset = "0x146F930", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002F2C")]
	private static void CBWrapper(IAsyncResult ares) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F2D")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F2F")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F2E")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F30")]
	public override bool get_IsCompleted() { }

}

