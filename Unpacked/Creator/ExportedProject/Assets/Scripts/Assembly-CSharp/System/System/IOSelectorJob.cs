namespace System;

[Token(Token = "0x20000D4")]
internal class IOSelectorJob : IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000342")]
	private IOOperation operation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000343")]
	private IOAsyncCallback callback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000344")]
	private IOAsyncResult state; //Field offset: 0x20

	[Address(RVA = "0xAE0D40", Offset = "0xADFF40", Length = "0x5D")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000456")]
	public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	[Address(RVA = "0x5C4850", Offset = "0x5C3A50", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000459")]
	public void MarkDisposed() { }

	[Address(RVA = "0x1756490", Offset = "0x1755690", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000457")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000458")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

