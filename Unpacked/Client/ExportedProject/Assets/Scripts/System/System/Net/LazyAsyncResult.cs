namespace System.Net;

[Token(Token = "0x200024E")]
internal class LazyAsyncResult : IAsyncResult
{
	[Token(Token = "0x200024F")]
	private class ThreadContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000989")]
		internal int m_NestedIOCount; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECF")]
		public ThreadContext() { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000980")]
	private static ThreadContext t_ThreadContext; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000981")]
	private object m_AsyncObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000982")]
	private object m_AsyncState; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000983")]
	private AsyncCallback m_AsyncCallback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000984")]
	private object m_Result; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000985")]
	private int m_IntCompleted; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000986")]
	private bool m_EndCalled; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4000987")]
	private bool m_UserEvent; //Field offset: 0x35
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000988")]
	private object m_Event; //Field offset: 0x38

	[Token(Token = "0x170002F0")]
	protected AsyncCallback AsyncCallback
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002EE")]
	internal object AsyncObject
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBD")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002EF")]
	public override object AsyncState
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002F1")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x17DE5C0", Offset = "0x17DD7C0", Length = "0x91")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LazyAsyncResult), Member = "LazilyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManualResetEvent&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000EC0")]
		 get { } //Length: 145
	}

	[Token(Token = "0x170002F2")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x17DE660", Offset = "0x17DD860", Length = "0x29")]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EC2")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170002ED")]
	private static ThreadContext CurrentThreadContext
	{
		[Address(RVA = "0x17DE690", Offset = "0x17DD890", Length = "0x91")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EBB")]
		private get { } //Length: 145
	}

	[Token(Token = "0x170002F5")]
	internal bool EndCalled
	{
		[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC5")]
		internal get { } //Length: 5
		[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC6")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F4")]
	internal bool InternalPeekCompleted
	{
		[Address(RVA = "0x17DE730", Offset = "0x17DD930", Length = "0xB")]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EC4")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170002F3")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x17DE740", Offset = "0x17DD940", Length = "0x2C")]
		[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EC3")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x17DE500", Offset = "0x17DD700", Length = "0xC0")]
	[CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EBC")]
	internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECC")]
	protected override void Cleanup() { }

	[Address(RVA = "0x17DDD70", Offset = "0x17DCF70", Length = "0x1EF")]
	[CalledBy(Type = "System.Net.ContextAwareResult+<>c", Member = "<Complete>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817CD170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000ECA")]
	protected override void Complete(IntPtr userToken) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBF")]
	protected AsyncCallback get_AsyncCallback() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBD")]
	internal object get_AsyncObject() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBE")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x17DE5C0", Offset = "0x17DD7C0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "LazilyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManualResetEvent&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000EC0")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x17DE660", Offset = "0x17DD860", Length = "0x29")]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC2")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x17DE690", Offset = "0x17DD890", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EBB")]
	private static ThreadContext get_CurrentThreadContext() { }

	[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC5")]
	internal bool get_EndCalled() { }

	[Address(RVA = "0x17DE730", Offset = "0x17DD930", Length = "0xB")]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC4")]
	internal bool get_InternalPeekCompleted() { }

	[Address(RVA = "0x17DE740", Offset = "0x17DD940", Length = "0x2C")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC3")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x17DDF60", Offset = "0x17DD160", Length = "0xA")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000ECD")]
	internal object InternalWaitForCompletion() { }

	[Address(RVA = "0x17DDF80", Offset = "0x17DD180", Length = "0xB")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EC8")]
	internal void InvokeCallback(object result) { }

	[Address(RVA = "0x17DDF70", Offset = "0x17DD170", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EC9")]
	internal void InvokeCallback() { }

	[Address(RVA = "0x17DDF90", Offset = "0x17DD190", Length = "0x17A")]
	[CalledBy(Type = typeof(LazyAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EC1")]
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	[Address(RVA = "0x17DE110", Offset = "0x17DD310", Length = "0x189")]
	[CalledBy(Type = typeof(WaitForChangedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "AsyncReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC7")]
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC6")]
	internal void set_EndCalled(bool value) { }

	[Address(RVA = "0x17DE2A0", Offset = "0x17DD4A0", Length = "0x1CB")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CloseExState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(WaitForChangedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "LazilyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManualResetEvent&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817CCDD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ECE")]
	private object WaitForCompletion(bool snap) { }

	[Address(RVA = "0x17DE470", Offset = "0x17DD670", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000ECB")]
	private void WorkerThreadComplete(object state) { }

}

