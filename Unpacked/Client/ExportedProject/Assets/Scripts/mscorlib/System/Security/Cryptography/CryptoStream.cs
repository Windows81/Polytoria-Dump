namespace System.Security.Cryptography;

[Token(Token = "0x20002D3")]
public class CryptoStream : Stream, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20002D8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C97")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000C98")]
		public static Func<SemaphoreSlim> <>9__54_0; //Field offset: 0x8

		[Address(RVA = "0x1335740", Offset = "0x1334940", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001775")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001776")]
		public <>c() { }

		[Address(RVA = "0x13356F0", Offset = "0x13348F0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001777")]
		internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D5")]
	private struct <ReadAsyncCore>d__42 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C71")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C72")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C73")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C74")]
		public int offset; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C75")]
		public CryptoStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C76")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C77")]
		public bool useAsync; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C78")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C79")]
		private int <bytesToDeliver>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000C7A")]
		private int <currentOutputIndex>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C7B")]
		private int <numWholeBlocksInBytes>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C7C")]
		private Byte[] <tempInputBuffer>5__5; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C7D")]
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C7E")]
		private ValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x68

		[Address(RVA = "0x1334160", Offset = "0x1333360", Length = "0xFA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ValueTaskAwaiter`1<System.Int32>), typeof(<ReadAsyncCore>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter`1<Int32>&), typeof(<ReadAsyncCore>d__42&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FDE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180186A60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036C50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CryptographicOperations), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600176F")]
		private override void MoveNext() { }

		[Address(RVA = "0x1335110", Offset = "0x1334310", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001770")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D4")]
	private struct <ReadAsyncInternal>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C67")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C68")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C69")]
		public CryptoStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C6A")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C6B")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C6C")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C6D")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C6E")]
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C6F")]
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C70")]
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1335180", Offset = "0x1334380", Length = "0x4F6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CryptoStream), Member = "ReadAsyncCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FDA0")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Int32>), typeof(<ReadAsyncInternal>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Int32>&), typeof(<ReadAsyncInternal>d__37&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForceAsyncAwaiter), typeof(<ReadAsyncInternal>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForceAsyncAwaiter&), typeof(<ReadAsyncInternal>d__37&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ForceAsyncAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(SemaphoreSlim))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x600176D")]
		private override void MoveNext() { }

		[Address(RVA = "0x1335680", Offset = "0x1334880", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600176E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D7")]
	private struct <WriteAsyncCore>d__49 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C89")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C8A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C8B")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C8C")]
		public int offset; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C8D")]
		public CryptoStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C8E")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C8F")]
		public bool useAsync; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C90")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C91")]
		private int <bytesToWrite>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000C92")]
		private int <currentInputIndex>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C93")]
		private int <numOutputBytes>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C94")]
		private ValueTaskAwaiter <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C95")]
		private int <numWholeBlocksInBytes>5__5; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000C96")]
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x70

		[Address(RVA = "0x13357B0", Offset = "0x13349B0", Length = "0xE22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter), typeof(<WriteAsyncCore>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter&), typeof(<WriteAsyncCore>d__49&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FC30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180186A60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813201D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181320310")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001773")]
		private override void MoveNext() { }

		[Address(RVA = "0x13365E0", Offset = "0x13357E0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001774")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D6")]
	private struct <WriteAsyncInternal>d__46 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C7F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C80")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C81")]
		public CryptoStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C82")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C83")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C84")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C85")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C86")]
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C87")]
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C88")]
		private TaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1336640", Offset = "0x1335840", Length = "0x48C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForceAsyncAwaiter), typeof(<WriteAsyncInternal>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForceAsyncAwaiter&), typeof(<WriteAsyncInternal>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FDA0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(CryptoStream), Member = "WriteAsyncCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ForceAsyncAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(SemaphoreSlim))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x6001771")]
		private override void MoveNext() { }

		[Address(RVA = "0x1336AD0", Offset = "0x1335CD0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001772")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C59")]
	private readonly Stream _stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C5A")]
	private readonly ICryptoTransform _transform; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C5B")]
	private readonly CryptoStreamMode _transformMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C5C")]
	private Byte[] _inputBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C5D")]
	private int _inputBufferIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000C5E")]
	private int _inputBlockSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C5F")]
	private Byte[] _outputBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C60")]
	private int _outputBufferIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000C61")]
	private int _outputBlockSize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C62")]
	private bool _canRead; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000C63")]
	private bool _canWrite; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000C64")]
	private bool _finalBlockTransformed; //Field offset: 0x62
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C65")]
	private SemaphoreSlim _lazyAsyncActiveSemaphore; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C66")]
	private readonly bool _leaveOpen; //Field offset: 0x70

	[Token(Token = "0x17000263")]
	private SemaphoreSlim AsyncActiveSemaphore
	{
		[Address(RVA = "0x1322230", Offset = "0x1321430", Length = "0x10E")]
		[CalledBy(Type = typeof(<ReadAsyncInternal>d__37), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<WriteAsyncInternal>d__46), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600176C")]
		private get { } //Length: 270
	}

	[Token(Token = "0x1700025D")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600174E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700025E")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600174F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700025F")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001750")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000262")]
	public bool HasFlushedFinalBlock
	{
		[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001754")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000260")]
	public virtual long Length
	{
		[Address(RVA = "0x1322340", Offset = "0x1321540", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001751")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000261")]
	public virtual long Position
	{
		[Address(RVA = "0x1322390", Offset = "0x1321590", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001752")]
		 get { } //Length: 78
		[Address(RVA = "0x13223E0", Offset = "0x13215E0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001753")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x1322210", Offset = "0x1321410", Length = "0x1C")]
	[CalledBy(Type = typeof(MACTripleDES), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ICryptoTransform), typeof(CryptoStreamMode), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600174C")]
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	[Address(RVA = "0x1321F10", Offset = "0x1321110", Length = "0x2F5")]
	[CalledBy(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ICryptoTransform), typeof(CryptoStreamMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600174D")]
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	[Address(RVA = "0x1320BE0", Offset = "0x131FDE0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskToApm), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600175A")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1320C90", Offset = "0x131FE90", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskToApm), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001763")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1320D40", Offset = "0x131FF40", Length = "0x1AA")]
	[CalledBy(Type = typeof(CryptoStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(CryptoStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001760")]
	private void CheckReadArguments(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1320EF0", Offset = "0x13200F0", Length = "0x1AA")]
	[CalledBy(Type = typeof(CryptoStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(CryptoStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001767")]
	private void CheckWriteArguments(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x327780", Offset = "0x326980", Length = "0x14")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001769")]
	public void Clear() { }

	[Address(RVA = "0x13210A0", Offset = "0x13202A0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FF90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600176A")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1321130", Offset = "0x1320330", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TaskToApm), Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "TResult")]
	[Token(Token = "0x600175B")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1321170", Offset = "0x1320370", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskToApm), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001764")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001756")]
	public virtual void Flush() { }

	[Address(RVA = "0x1321180", Offset = "0x1320380", Length = "0x1E6")]
	[CalledBy(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001755")]
	public void FlushFinalBlock() { }

	[Address(RVA = "0x1322230", Offset = "0x1321430", Length = "0x10E")]
	[CalledBy(Type = typeof(<ReadAsyncInternal>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteAsyncInternal>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600176C")]
	private SemaphoreSlim get_AsyncActiveSemaphore() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600174E")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600174F")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001750")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001754")]
	public bool get_HasFlushedFinalBlock() { }

	[Address(RVA = "0x1322340", Offset = "0x1321540", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001751")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1322390", Offset = "0x1321590", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001752")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1321370", Offset = "0x1320570", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600176B")]
	private void InitializeBuffer() { }

	[Address(RVA = "0x13218C0", Offset = "0x1320AC0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptoStream), Member = "CheckReadArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptoStream), Member = "ReadAsyncCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600175F")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x13216E0", Offset = "0x13208E0", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptoStream), Member = "CheckReadArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncInternal>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncInternal>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001759")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1321430", Offset = "0x1320630", Length = "0x15D")]
	[AsyncStateMachine(typeof(<ReadAsyncCore>d__42))]
	[CalledBy(Type = typeof(<ReadAsyncInternal>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncCore>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncCore>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001761")]
	private Task<Int32> ReadAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[Address(RVA = "0x1321590", Offset = "0x1320790", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ReadAsyncInternal>d__37))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncInternal>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsyncInternal>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600175C")]
	private Task<Int32> ReadAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1321840", Offset = "0x1320A40", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "ReadByte", ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600175D")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x13219A0", Offset = "0x1320BA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001757")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x13223E0", Offset = "0x13215E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001753")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x13219F0", Offset = "0x1320BF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001758")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x1321E70", Offset = "0x1321070", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptoStream), Member = "CheckWriteArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptoStream), Member = "WriteAsyncCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken), typeof(bool)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001766")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1321CC0", Offset = "0x1320EC0", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptoStream), Member = "CheckWriteArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInternal>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInternal>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001762")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1321A40", Offset = "0x1320C40", Length = "0x13A")]
	[AsyncStateMachine(typeof(<WriteAsyncCore>d__49))]
	[CalledBy(Type = typeof(<WriteAsyncInternal>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncCore>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncCore>d__49&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001768")]
	private Task WriteAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[Address(RVA = "0x1321B80", Offset = "0x1320D80", Length = "0x13C")]
	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__46))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInternal>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAsyncInternal>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001765")]
	private Task WriteAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1321E20", Offset = "0x1321020", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600175E")]
	public virtual void WriteByte(byte value) { }

}

