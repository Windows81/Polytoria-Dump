namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000463")]
public struct AsyncValueTaskMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001246")]
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001247")]
	private TResult _result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001248")]
	private bool _haveResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001249")]
	private bool _useBuilder; //Field offset: 0x0

	[Token(Token = "0x170003F2")]
	public ValueTask<TResult> Task
	{
		[Address(RVA = "0xF36EF0", Offset = "0xF360F0", Length = "0x11B")]
		[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(Byte[]), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600200B")]
		 get { } //Length: 283
	}

	[Address(RVA = "0x6045E0", Offset = "0x6037E0", Length = "0x9F")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600200C")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xF364F0", Offset = "0xF356F0", Length = "0xE")]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(Byte[]), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002006")]
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }

	[Address(RVA = "0xF36EF0", Offset = "0xF360F0", Length = "0x11B")]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(Byte[]), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600200B")]
	public ValueTask<TResult> get_Task() { }

	[Address(RVA = "0xF36600", Offset = "0xF35800", Length = "0x94")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600200A")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0xF366A0", Offset = "0xF358A0", Length = "0xAF")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002009")]
	public void SetResult(TResult result) { }

	[Address(RVA = "0xF36B10", Offset = "0xF35D10", Length = "0x94")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002008")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x604890", Offset = "0x603A90", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002007")]
	public void Start(ref TStateMachine stateMachine) { }

}

