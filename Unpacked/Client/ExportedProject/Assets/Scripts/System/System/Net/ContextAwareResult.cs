namespace System.Net;

[Token(Token = "0x20001FE")]
internal class ContextAwareResult : LazyAsyncResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000200")]
	private sealed class <>c
	{
		[Token(Token = "0x4000797")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000798")]
		public static ContextCallback <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x17CC910", Offset = "0x17CBB10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CC5")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC6")]
		public <>c() { }

		[Address(RVA = "0x17CC560", Offset = "0x17CB760", Length = "0x14A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CC7")]
		internal void <Complete>b__17_0(object s) { }

	}

	[Flags]
	[Token(Token = "0x20001FF")]
	private enum StateFlags
	{
		None = 0,
		CaptureIdentity = 1,
		CaptureContext = 2,
		ThreadSafeContextCopy = 4,
		PostBlockStarted = 8,
		PostBlockFinished = 16,
	}

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400078D")]
	private ExecutionContext _context; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400078E")]
	private object _lock; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400078F")]
	private StateFlags _flags; //Field offset: 0x50

	[Address(RVA = "0x17B40E0", Offset = "0x17B32E0", Length = "0x17")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CBB")]
	internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x17B4080", Offset = "0x17B3280", Length = "0x58")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CBC")]
	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x17B4010", Offset = "0x17B3210", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CBD")]
	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x17B3400", Offset = "0x17B2600", Length = "0x4E9")]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "FinishPostingAsyncOp", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyAsyncResult), Member = "get_CompletedSynchronously", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CC2")]
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	[Address(RVA = "0x17B38F0", Offset = "0x17B2AF0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000CC1")]
	protected virtual void Cleanup() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBA")]
	private void CleanupInternal() { }

	[Address(RVA = "0x17B3AC0", Offset = "0x17B2CC0", Length = "0x350")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "get_CompletedSynchronously", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CC3")]
	protected virtual void Complete(IntPtr userToken) { }

	[Address(RVA = "0x17B39D0", Offset = "0x17B2BD0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CC4")]
	private void CompleteCallback() { }

	[Address(RVA = "0x17B3E20", Offset = "0x17B3020", Length = "0x37")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000CC0")]
	internal bool FinishPostingAsyncOp() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB9")]
	private void SafeCaptureIdentity() { }

	[Address(RVA = "0x17B3F40", Offset = "0x17B3140", Length = "0xCF")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CBE")]
	internal object StartPostingAsyncOp() { }

	[Address(RVA = "0x17B3E60", Offset = "0x17B3060", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CBF")]
	internal object StartPostingAsyncOp(bool lockCapture) { }

}

