namespace System.IO;

[Token(Token = "0x2000649")]
public abstract class Stream : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000652")]
	private struct <<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40019A4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40019A5")]
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40019A6")]
		public Task<Int32> readTask; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40019A7")]
		public Byte[] localBuffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40019A8")]
		public Memory<Byte> localDestination; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40019A9")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x146AB00", Offset = "0x1469D00", Length = "0x317")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FF20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
		[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002EA5")]
		private override void MoveNext() { }

		[Address(RVA = "0x146AE20", Offset = "0x146A020", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002EA6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200064F")]
	private sealed class <>c
	{
		[Token(Token = "0x400198D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400198E")]
		public static Func<SemaphoreSlim> <>9__4_0; //Field offset: 0x8
		[Token(Token = "0x400198F")]
		public static Func<Object, Int32> <>9__40_0; //Field offset: 0x10
		[Token(Token = "0x4001990")]
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__45_0; //Field offset: 0x18
		[Token(Token = "0x4001991")]
		public static Func<Stream, IAsyncResult, Int32> <>9__45_1; //Field offset: 0x20
		[Token(Token = "0x4001992")]
		public static Func<Object, Int32> <>9__48_0; //Field offset: 0x28
		[Token(Token = "0x4001993")]
		public static Action<Task, Object> <>9__49_0; //Field offset: 0x30
		[Token(Token = "0x4001994")]
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__58_0; //Field offset: 0x38
		[Token(Token = "0x4001995")]
		public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1; //Field offset: 0x40

		[Address(RVA = "0x146B310", Offset = "0x146A510", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E97")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E98")]
		public <>c() { }

		[Address(RVA = "0x146AE70", Offset = "0x146A070", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E9B")]
		internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[Address(RVA = "0x146AED0", Offset = "0x146A0D0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E9C")]
		internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

		[Address(RVA = "0x146AF10", Offset = "0x146A110", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E9F")]
		internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[Address(RVA = "0x146AF70", Offset = "0x146A170", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002EA0")]
		internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }

		[Address(RVA = "0x146AFB0", Offset = "0x146A1B0", Length = "0x12B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FE20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E9A")]
		internal int <BeginReadInternal>b__40_0(object <p0>) { }

		[Address(RVA = "0x146B0E0", Offset = "0x146A2E0", Length = "0x11F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FE20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E9D")]
		internal int <BeginWriteInternal>b__48_0(object <p0>) { }

		[Address(RVA = "0x146B200", Offset = "0x146A400", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002E99")]
		internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

		[Address(RVA = "0x146B250", Offset = "0x146A450", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Stream+ReadWriteTask"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6002E9E")]
		internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000650")]
	private struct <CopyToAsyncInternal>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001996")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001997")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001998")]
		public int bufferSize; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001999")]
		public Stream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400199A")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400199B")]
		public Stream destination; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400199C")]
		private Byte[] <buffer>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400199D")]
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400199E")]
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x1469DB0", Offset = "0x1468FB0", Length = "0xA32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter<System.Int32>), typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter<Int32>&), typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter), typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter&), typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002EA1")]
		private override void MoveNext() { }

		[Address(RVA = "0x146A7F0", Offset = "0x14699F0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002EA2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000651")]
	private struct <FinishWriteAsync>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400199F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40019A0")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40019A1")]
		public Task writeTask; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40019A2")]
		public Byte[] localBuffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40019A3")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x146A850", Offset = "0x1469A50", Length = "0x246")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FCC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002EA3")]
		private override void MoveNext() { }

		[Address(RVA = "0x146AAA0", Offset = "0x1469CA0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002EA4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200064C")]
	private sealed class NullStream : Stream
	{
		[Token(Token = "0x4001984")]
		private static readonly Task<Int32> s_zeroTask; //Field offset: 0x0

		[Token(Token = "0x17000732")]
		public virtual bool CanRead
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E6F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000734")]
		public virtual bool CanSeek
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E71")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000733")]
		public virtual bool CanWrite
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E70")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000735")]
		public virtual long Length
		{
			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E72")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000736")]
		public virtual long Position
		{
			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E73")]
			 get { } //Length: 3
			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E74")]
			 set { } //Length: 3
		}

		[Address(RVA = "0x145E4B0", Offset = "0x145D6B0", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002E89")]
		private static NullStream() { }

		[Address(RVA = "0x145E540", Offset = "0x145D740", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E6E")]
		internal NullStream() { }

		[Address(RVA = "0x145DCE0", Offset = "0x145CEE0", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E79")]
		public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[Address(RVA = "0x145DD70", Offset = "0x145CF70", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E7B")]
		public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[Address(RVA = "0x145DF10", Offset = "0x145D110", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002E75")]
		public virtual void CopyTo(Stream destination, int bufferSize) { }

		[Address(RVA = "0x145DE00", Offset = "0x145D000", Length = "0x110")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Token(Token = "0x6002E76")]
		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E77")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x145DF20", Offset = "0x145D120", Length = "0x187")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002E7A")]
		public virtual int EndRead(IAsyncResult asyncResult) { }

		[Address(RVA = "0x145E0B0", Offset = "0x145D2B0", Length = "0x17F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002E7C")]
		public virtual void EndWrite(IAsyncResult asyncResult) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E78")]
		public virtual void Flush() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E6F")]
		public virtual bool get_CanRead() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E71")]
		public virtual bool get_CanSeek() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E70")]
		public virtual bool get_CanWrite() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E72")]
		public virtual long get_Length() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E73")]
		public virtual long get_Position() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E7D")]
		public virtual int Read(Byte[] buffer, int offset, int count) { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E7E")]
		public virtual int Read(Span<Byte> buffer) { }

		[Address(RVA = "0x145E230", Offset = "0x145D430", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002E7F")]
		public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x145E280", Offset = "0x145D480", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002E80")]
		public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E81")]
		public virtual int ReadByte() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E87")]
		public virtual long Seek(long offset, SeekOrigin origin) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E74")]
		public virtual void set_Position(long value) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E88")]
		public virtual void SetLength(long length) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E82")]
		public virtual void Write(Byte[] buffer, int offset, int count) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E83")]
		public virtual void Write(ReadOnlySpan<Byte> buffer) { }

		[Address(RVA = "0x145E3D0", Offset = "0x145D5D0", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Token(Token = "0x6002E84")]
		public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x145E2E0", Offset = "0x145D4E0", Length = "0xED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002E85")]
		public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E86")]
		public virtual void WriteByte(byte value) { }

	}

	[Token(Token = "0x200064A")]
	private struct ReadWriteParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001978")]
		internal Byte[] Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001979")]
		internal int Offset; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400197A")]
		internal int Count; //Field offset: 0xC

	}

	[Token(Token = "0x200064B")]
	private sealed class ReadWriteTask : Task<Int32>, ITaskCompletionAction
	{
		[Token(Token = "0x4001983")]
		private static ContextCallback s_invokeAsyncCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400197B")]
		internal readonly bool _isRead; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x400197C")]
		internal readonly bool _apm; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400197D")]
		internal Stream _stream; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400197E")]
		internal Byte[] _buffer; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400197F")]
		internal readonly int _offset; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4001980")]
		internal readonly int _count; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001981")]
		private AsyncCallback _callback; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4001982")]
		private ExecutionContext _context; //Field offset: 0x80

		[Token(Token = "0x17000731")]
		private override bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E6D")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x1461240", Offset = "0x1460440", Length = "0x144")]
		[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E6A")]
		public ReadWriteTask(bool isRead, bool apm, Func<Object, Int32> function, object state, Stream stream, Byte[] buffer, int offset, int count, AsyncCallback callback) { }

		[Address(RVA = "0x1461020", Offset = "0x1460220", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002E69")]
		internal void ClearBeginState() { }

		[Address(RVA = "0x1461060", Offset = "0x1460260", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E6B")]
		private static void InvokeAsyncCallback(object completedTask) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E6D")]
		private override bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x14610F0", Offset = "0x14602F0", Length = "0x14C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002E6C")]
		private override void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	}

	[Token(Token = "0x200064D")]
	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		[CompilerGenerated]
		[Token(Token = "0x200064E")]
		private sealed class <>c
		{
			[Token(Token = "0x400198B")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400198C")]
			public static Func<ManualResetEvent> <>9__12_0; //Field offset: 0x8

			[Address(RVA = "0x146B380", Offset = "0x146A580", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6002E94")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E95")]
			public <>c() { }

			[Address(RVA = "0x146B2C0", Offset = "0x146A4C0", Length = "0x47")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Token(Token = "0x6002E96")]
			internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001985")]
		private readonly object _stateObject; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001986")]
		private readonly bool _isWrite; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001987")]
		private ManualResetEvent _waitHandle; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001988")]
		private ExceptionDispatchInfo _exceptionInfo; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001989")]
		private bool _endXxxCalled; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400198A")]
		private int _bytesRead; //Field offset: 0x34

		[Token(Token = "0x17000739")]
		public override object AsyncState
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E8F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000738")]
		public override WaitHandle AsyncWaitHandle
		{
			[Address(RVA = "0x1468C00", Offset = "0x1467E00", Length = "0x10E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6002E8E")]
			 get { } //Length: 270
		}

		[Token(Token = "0x1700073A")]
		public override bool CompletedSynchronously
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E90")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000737")]
		public override bool IsCompleted
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002E8D")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x1468B80", Offset = "0x1467D80", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E8A")]
		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject) { }

		[Address(RVA = "0x1468BC0", Offset = "0x1467DC0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E8B")]
		internal SynchronousAsyncResult(object asyncStateObject) { }

		[Address(RVA = "0x1468B10", Offset = "0x1467D10", Length = "0x6B")]
		[CalledBy(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E8C")]
		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite) { }

		[Address(RVA = "0x1466360", Offset = "0x1465560", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E92")]
		internal static int EndRead(IAsyncResult asyncResult) { }

		[Address(RVA = "0x1466470", Offset = "0x1465670", Length = "0xFD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E93")]
		internal static void EndWrite(IAsyncResult asyncResult) { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E8F")]
		public override object get_AsyncState() { }

		[Address(RVA = "0x1468C00", Offset = "0x1467E00", Length = "0x10E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002E8E")]
		public override WaitHandle get_AsyncWaitHandle() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E90")]
		public override bool get_CompletedSynchronously() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E8D")]
		public override bool get_IsCompleted() { }

		[Address(RVA = "0x1468AF0", Offset = "0x1467CF0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Token(Token = "0x6002E91")]
		internal void ThrowIfError() { }

	}

	[Token(Token = "0x4001975")]
	public static readonly Stream Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001976")]
	private ReadWriteTask _activeReadWriteTask; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001977")]
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x20

	[Token(Token = "0x17000729")]
	public abstract bool CanRead
	{
		[Token(Token = "0x6002E30")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700072A")]
	public abstract bool CanSeek
	{
		[Token(Token = "0x6002E31")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700072B")]
	public override bool CanTimeout
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E32")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700072C")]
	public abstract bool CanWrite
	{
		[Token(Token = "0x6002E33")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700072D")]
	public abstract long Length
	{
		[Token(Token = "0x6002E34")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700072E")]
	public abstract long Position
	{
		[Token(Token = "0x6002E35")]
		 get { } //Length: 0
		[Token(Token = "0x6002E36")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700072F")]
	public override int ReadTimeout
	{
		[Address(RVA = "0x1468610", Offset = "0x1467810", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002E37")]
		 get { } //Length: 78
		[Address(RVA = "0x14686B0", Offset = "0x14678B0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002E38")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000730")]
	public override int WriteTimeout
	{
		[Address(RVA = "0x1468660", Offset = "0x1467860", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002E39")]
		 get { } //Length: 78
		[Address(RVA = "0x1468700", Offset = "0x1467900", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002E3A")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x1468560", Offset = "0x1467760", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E67")]
	private static Stream() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E66")]
	protected Stream() { }

	[Address(RVA = "0x1467D10", Offset = "0x1466F10", Length = "0x18B")]
	[AsyncStateMachine(typeof(<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.ValueTask`1<TResult>")]
	[CompilerGenerated]
	[Token(Token = "0x6002E68")]
	internal static ValueTask<Int32> <ReadAsync>g__FinishReadAsync|44_0(Task<Int32> readTask, Byte[] localBuffer, Memory<Byte> localDestination) { }

	[Address(RVA = "0x14657C0", Offset = "0x14649C0", Length = "0x24C")]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`3<System.Object, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs", "System.Func`5<TInstance, TArgs, AsyncCallback, Object, IAsyncResult>", "System.Func`3<TInstance, IAsyncResult, TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002E4C")]
	private Task<Int32> BeginEndReadAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1465A10", Offset = "0x1464C10", Length = "0x24C")]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ReadWriteParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ReadWriteParameters), typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`3<System.Object, System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002E57")]
	private Task BeginEndWriteAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1465EA0", Offset = "0x14650A0", Length = "0x3B")]
	[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[Token(Token = "0x6002E46")]
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1465C60", Offset = "0x1464E60", Length = "0x238")]
	[CalledBy(Type = typeof(Stream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadWriteTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E47")]
	internal IAsyncResult BeginReadInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[Address(RVA = "0x1466120", Offset = "0x1465320", Length = "0x3B")]
	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[Token(Token = "0x6002E4D")]
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1465EE0", Offset = "0x14650E0", Length = "0x238")]
	[CalledBy(Type = typeof(Stream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadWriteTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E4E")]
	internal IAsyncResult BeginWriteInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[Address(RVA = "0x1466160", Offset = "0x1465360", Length = "0xFF")]
	[CalledBy(Type = typeof(NullStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SynchronousAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002E60")]
	internal IAsyncResult BlockingBeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1466260", Offset = "0x1465460", Length = "0xFD")]
	[CalledBy(Type = typeof(NullStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SynchronousAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002E62")]
	internal IAsyncResult BlockingBeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1466360", Offset = "0x1465560", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E61")]
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1466470", Offset = "0x1465670", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E63")]
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1466570", Offset = "0x1465770", Length = "0x61")]
	[CalledBy(Type = "System.Net.TlsStream", Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E42")]
	public override void Close() { }

	[Address(RVA = "0x1466AE0", Offset = "0x1465CE0", Length = "0x3E")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "DecompressString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E3F")]
	public void CopyTo(Stream destination) { }

	[Address(RVA = "0x1466980", Offset = "0x1465B80", Length = "0x15A")]
	[CalledBy(Type = typeof(MemoryStream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002E40")]
	public override void CopyTo(Stream destination, int bufferSize) { }

	[Address(RVA = "0x1466860", Offset = "0x1465A60", Length = "0x8B")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpContent", Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.Http.HttpContent", Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.Net.TransportContext"}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E3B")]
	public Task CopyToAsync(Stream destination) { }

	[Address(RVA = "0x1466720", Offset = "0x1465920", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E3D")]
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x14668F0", Offset = "0x1465AF0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E3C")]
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[Address(RVA = "0x14665E0", Offset = "0x14657E0", Length = "0x135")]
	[AsyncStateMachine(typeof(<CopyToAsyncInternal>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E3E")]
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x327780", Offset = "0x326980", Length = "0x14")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E43")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E44")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1466B20", Offset = "0x1465D20", Length = "0x21D")]
	[CalledBy(Type = typeof(FileStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FDE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E48")]
	public override int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1466D40", Offset = "0x1465F40", Length = "0x214")]
	[CalledBy(Type = typeof(FileStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FDE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E52")]
	public override void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1466F60", Offset = "0x1466160", Length = "0x10E")]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E2F")]
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	[Address(RVA = "0x1467070", Offset = "0x1466270", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002E51")]
	private void FinishTrackingAsyncOperation() { }

	[Address(RVA = "0x14670B0", Offset = "0x14662B0", Length = "0xFD")]
	[AsyncStateMachine(typeof(<FinishWriteAsync>d__57))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002E56")]
	private Task FinishWriteAsync(Task writeTask, Byte[] localBuffer) { }

	[Token(Token = "0x6002E45")]
	public abstract void Flush() { }

	[Token(Token = "0x6002E30")]
	public abstract bool get_CanRead() { }

	[Token(Token = "0x6002E31")]
	public abstract bool get_CanSeek() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E32")]
	public override bool get_CanTimeout() { }

	[Token(Token = "0x6002E33")]
	public abstract bool get_CanWrite() { }

	[Token(Token = "0x6002E34")]
	public abstract long get_Length() { }

	[Token(Token = "0x6002E35")]
	public abstract long get_Position() { }

	[Address(RVA = "0x1468610", Offset = "0x1467810", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002E37")]
	public override int get_ReadTimeout() { }

	[Address(RVA = "0x1468660", Offset = "0x1467860", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002E39")]
	public override int get_WriteTimeout() { }

	[Address(RVA = "0x14671B0", Offset = "0x14663B0", Length = "0xDF")]
	[CalledBy(Type = typeof(Stream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002E41")]
	private int GetCopyBufferSize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E64")]
	private bool HasOverriddenBeginEndRead() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E65")]
	private bool HasOverriddenBeginEndWrite() { }

	[Address(RVA = "0x1467860", Offset = "0x1466A60", Length = "0x20E")]
	[CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002E5B")]
	public override int Read(Span<Byte> buffer) { }

	[Token(Token = "0x6002E5A")]
	public abstract int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1467370", Offset = "0x1466570", Length = "0x3AA")]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadAsyncMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.ValueTask`1<TResult>")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002E4B")]
	public override ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1467290", Offset = "0x1466490", Length = "0xD3")]
	[CalledBy(Type = typeof(FileStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Stream), Member = "BeginEndReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Token(Token = "0x6002E4A")]
	public override Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1467720", Offset = "0x1466920", Length = "0x97")]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E49")]
	public Task<Int32> ReadAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x14677C0", Offset = "0x14669C0", Length = "0x9E")]
	[CalledBy(Type = typeof(CryptoStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E5C")]
	public override int ReadByte() { }

	[Address(RVA = "0x1467C40", Offset = "0x1466E40", Length = "0xC1")]
	[CalledBy(Type = typeof(<>c), Member = "<RunReadWriteTaskWhenReady>b__49_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002E50")]
	private void RunReadWriteTask(ReadWriteTask readWriteTask) { }

	[Address(RVA = "0x1467A70", Offset = "0x1466C70", Length = "0x1C7")]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002E4F")]
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask) { }

	[Token(Token = "0x6002E58")]
	public abstract long Seek(long offset, SeekOrigin origin) { }

	[Token(Token = "0x6002E36")]
	public abstract void set_Position(long value) { }

	[Address(RVA = "0x14686B0", Offset = "0x14678B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002E38")]
	public override void set_ReadTimeout(int value) { }

	[Address(RVA = "0x1468700", Offset = "0x1467900", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002E3A")]
	public override void set_WriteTimeout(int value) { }

	[Token(Token = "0x6002E59")]
	public abstract void SetLength(long value) { }

	[Token(Token = "0x6002E5D")]
	public abstract void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1468410", Offset = "0x1467610", Length = "0x14C")]
	[CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002E5E")]
	public override void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x14682B0", Offset = "0x14674B0", Length = "0xC2")]
	[CalledBy(Type = typeof(FileStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Stream), Member = "BeginEndWriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
	[Token(Token = "0x6002E54")]
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1468210", Offset = "0x1467410", Length = "0x97")]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E53")]
	public Task WriteAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1467EA0", Offset = "0x14670A0", Length = "0x36B")]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteAsyncMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002E55")]
	public override ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1468380", Offset = "0x1467580", Length = "0x8A")]
	[CalledBy(Type = typeof(CryptoStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002E5F")]
	public override void WriteByte(byte value) { }

}

