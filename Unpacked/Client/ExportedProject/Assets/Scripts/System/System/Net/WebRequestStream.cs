namespace System.Net;

[Token(Token = "0x20002B7")]
internal class WebRequestStream : WebConnectionStream
{
	[CompilerGenerated]
	[Token(Token = "0x20002B8")]
	private struct <FinishWriting>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BDE")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BDF")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE0")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE1")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x17049F0", Offset = "0x1703BF0", Length = "0x30C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebRequestStream), Member = "WriteChunkTrailer_inner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60011C9")]
		private override void MoveNext() { }

		[Address(RVA = "0x1704D00", Offset = "0x1703F00", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011CA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BB")]
	private struct <Initialize>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BF5")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BF6")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BF7")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BF8")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BF9")]
		private TaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x1705F70", Offset = "0x1705170", Length = "0x43F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequestStream+<WriteRequestAsync>d__38"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteRequestAsync>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<Initialize>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<Initialize>d__36&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebRequestStream), Member = "SetHeadersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60011CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x17063C0", Offset = "0x17055C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BA")]
	private struct <ProcessWrite>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BED")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BEE")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BEF")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BF0")]
		public int size; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BF1")]
		public Byte[] buffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BF2")]
		public int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BF3")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x1707290", Offset = "0x1706490", Length = "0x5BB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(WebRequestStream), Member = "KillBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x60011CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x1707850", Offset = "0x1706A50", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BC")]
	private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BFB")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BFC")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BFD")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BFE")]
		public bool setInternalLength; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BFF")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x170BEB0", Offset = "0x170B0B0", Length = "0x668")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(WebExceptionInternalStatus), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60011D1")]
		private override void MoveNext() { }

		[Address(RVA = "0x170C520", Offset = "0x170B720", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011D2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002B9")]
	private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BE3")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE4")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE5")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE6")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BE7")]
		public int size; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BE8")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BE9")]
		public WebCompletionSource completion; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BEA")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BEB")]
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x170CF10", Offset = "0x170C110", Length = "0x5D4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A8300")]
		[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
		[Calls(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(WebRequestStream), Member = "KillBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebRequestStream), Member = "FinishWriting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequestStream+<ProcessWrite>d__34"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessWrite>d__34&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60011CB")]
		private override void MoveNext() { }

		[Address(RVA = "0x170D4F0", Offset = "0x170C6F0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011CC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BE")]
	private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C07")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C08")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C09")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C0A")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C0B")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x170DD80", Offset = "0x170CF80", Length = "0x24B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60011D5")]
		private override void MoveNext() { }

		[Address(RVA = "0x170DFD0", Offset = "0x170D1D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011D6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BF")]
	private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C0D")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C0E")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C0F")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C10")]
		private Task <timeoutTask>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C11")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C12")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x170D550", Offset = "0x170C750", Length = "0x7C5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816FCD60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebRequestStream), Member = "WriteChunkTrailer_inner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(WebCompletionSource`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60011D7")]
		private override void MoveNext() { }

		[Address(RVA = "0x170DD20", Offset = "0x170CF20", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011D8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002BD")]
	private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C00")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C01")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C02")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C03")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C04")]
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C05")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C06")]
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x170E030", Offset = "0x170D230", Length = "0x66A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<WriteRequestAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<WriteRequestAsync>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebRequestStream), Member = "FinishWriting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<WriteRequestAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<WriteRequestAsync>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebRequestStream), Member = "SetHeadersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60011D3")]
		private override void MoveNext() { }

		[Address(RVA = "0x170E6A0", Offset = "0x170D8A0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011D4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000BD0")]
	private static Byte[] crlf; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BD1")]
	private MemoryStream writeBuffer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BD2")]
	private bool requestWritten; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000BD3")]
	private bool allowBuffering; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000BD4")]
	private bool sendChunked; //Field offset: 0x62
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BD5")]
	private WebCompletionSource pendingWrite; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BD6")]
	private long totalWritten; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BD7")]
	private Byte[] headers; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BD8")]
	private bool headersSent; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000BD9")]
	private int completeRequestWritten; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000BDA")]
	private int chunkTrailerWritten; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000BDB")]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000BDC")]
	private readonly bool <KeepAlive>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x170003C5")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003C6")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003C7")]
	internal bool HasWriteBuffer
	{
		[Address(RVA = "0x1714290", Offset = "0x1713490", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011B7")]
		internal get { } //Length: 45
	}

	[Token(Token = "0x170003C3")]
	internal Stream InnerStream
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B3")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003C4")]
	public bool KeepAlive
	{
		[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003C8")]
	internal int WriteBufferLength
	{
		[Address(RVA = "0x17142C0", Offset = "0x17134C0", Length = "0x5C")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60011B8")]
		internal get { } //Length: 92
	}

	[Address(RVA = "0x1714070", Offset = "0x1713270", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60011C8")]
	private static WebRequestStream() { }

	[Address(RVA = "0x1714100", Offset = "0x1713300", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_InternalAllowBuffering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011B2")]
	public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[Address(RVA = "0x1712E80", Offset = "0x1712080", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebRequestStream), Member = "KillBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011BE")]
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[Address(RVA = "0x1712F30", Offset = "0x1712130", Length = "0x291")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(WebExceptionInternalStatus), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011C7")]
	protected virtual void Close_internal(ref bool disposed) { }

	[Address(RVA = "0x17131D0", Offset = "0x17123D0", Length = "0xFC")]
	[AsyncStateMachine(typeof(<FinishWriting>d__31))]
	[CalledBy(Type = typeof(<WriteAsyncInner>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteRequestAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriting>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriting>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011BA")]
	private Task FinishWriting(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B5")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B6")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1714290", Offset = "0x1713490", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011B7")]
	internal bool get_HasWriteBuffer() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B3")]
	internal Stream get_InnerStream() { }

	[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B4")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x17142C0", Offset = "0x17134C0", Length = "0x5C")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011B8")]
	internal int get_WriteBufferLength() { }

	[Address(RVA = "0x17132D0", Offset = "0x17124D0", Length = "0x11C")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60011B9")]
	internal BufferOffsetSize GetWriteBuffer() { }

	[Address(RVA = "0x17133F0", Offset = "0x17125F0", Length = "0x104")]
	[AsyncStateMachine(typeof(<Initialize>d__36))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Initialize>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Initialize>d__36&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011BF")]
	internal Task Initialize(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713500", Offset = "0x1712700", Length = "0x13")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteAsyncInner>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ProcessWrite>d__34), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "CheckWriteOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60011C4")]
	internal void KillBuffer() { }

	[Address(RVA = "0x1713520", Offset = "0x1712720", Length = "0x13F")]
	[AsyncStateMachine(typeof(<ProcessWrite>d__34))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessWrite>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessWrite>d__34&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011BD")]
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713660", Offset = "0x1712860", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Token(Token = "0x60011C5")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17136F0", Offset = "0x17128F0", Length = "0x115")]
	[AsyncStateMachine(typeof(<SetHeadersAsync>d__37))]
	[CalledBy(Type = typeof(<Initialize>d__36), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteRequestAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetHeadersAsync>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetHeadersAsync>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011C0")]
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713810", Offset = "0x1712A10", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011C6")]
	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[Address(RVA = "0x1713990", Offset = "0x1712B90", Length = "0x3D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInner>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInner>d__33&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011BB")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713850", Offset = "0x1712A50", Length = "0x13A")]
	[AsyncStateMachine(typeof(<WriteAsyncInner>d__33))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInner>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInner>d__33&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011BC")]
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713E70", Offset = "0x1713070", Length = "0xE2")]
	[AsyncStateMachine(typeof(<WriteChunkTrailer>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011C3")]
	private Task WriteChunkTrailer() { }

	[Address(RVA = "0x1713D70", Offset = "0x1712F70", Length = "0xFC")]
	[AsyncStateMachine(typeof(<WriteChunkTrailer_inner>d__39))]
	[CalledBy(Type = typeof(<FinishWriting>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteChunkTrailer>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer_inner>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteChunkTrailer_inner>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011C2")]
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1713F60", Offset = "0x1713160", Length = "0x105")]
	[AsyncStateMachine(typeof(<WriteRequestAsync>d__38))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteRequestAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteRequestAsync>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011C1")]
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

}

