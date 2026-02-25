namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
[Token(Token = "0x200024F")]
public struct ValueTask : IEquatable<ValueTask>
{
	[Token(Token = "0x2000250")]
	private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000251")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AB1")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x153AAD0", Offset = "0x1539CD0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001335")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001336")]
			public <>c() { }

			[Address(RVA = "0x153A700", Offset = "0x1539900", Length = "0x1A0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
			[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001337")]
			internal void <.cctor>b__4_0(object state) { }

		}

		[Token(Token = "0x4000AAE")]
		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AAF")]
		private IValueTaskSource _source; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AB0")]
		private readonly short _token; //Field offset: 0x60

		[Address(RVA = "0x153ABB0", Offset = "0x1539DB0", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001334")]
		private static ValueTaskSourceAsTask() { }

		[Address(RVA = "0x153AC80", Offset = "0x1539E80", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001333")]
		public ValueTaskSourceAsTask(IValueTaskSource source, short token) { }

	}

	[Token(Token = "0x4000AAA")]
	private static readonly Task s_canceledTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AAB")]
	internal readonly object _obj; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AAC")]
	internal readonly short _token; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000AAD")]
	internal readonly bool _continueOnCapturedContext; //Field offset: 0xA

	[Token(Token = "0x170001CF")]
	internal static Task CompletedTask
	{
		[Address(RVA = "0x153B560", Offset = "0x153A760", Length = "0x8A")]
		[CalledBy(Type = typeof(ValueTask), Member = "AsTask", ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueTaskSource)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueTaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001325")]
		internal get { } //Length: 138
	}

	[Token(Token = "0x170001D0")]
	public bool IsCompleted
	{
		[Address(RVA = "0x153B5F0", Offset = "0x153A7F0", Length = "0xED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600132E")]
		 get { } //Length: 237
	}

	[Address(RVA = "0x153B3B0", Offset = "0x153A5B0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001332")]
	private static ValueTask() { }

	[Address(RVA = "0x153B510", Offset = "0x153A710", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001326")]
	public ValueTask(Task task) { }

	[Address(RVA = "0x153B480", Offset = "0x153A680", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001327")]
	public ValueTask(IValueTaskSource source, short token) { }

	[Address(RVA = "0x153B4D0", Offset = "0x153A6D0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001328")]
	private ValueTask(object obj, short token, bool continueOnCapturedContext) { }

	[Address(RVA = "0x153ADE0", Offset = "0x1539FE0", Length = "0xC8")]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
	[Calls(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueTaskSource)}, ReturnType = typeof(Task))]
	[Token(Token = "0x600132C")]
	public Task AsTask() { }

	[Address(RVA = "0x153AEB0", Offset = "0x153A0B0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001331")]
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x153AF20", Offset = "0x153A120", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600132A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x153AFD0", Offset = "0x153A1D0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600132B")]
	public override bool Equals(ValueTask other) { }

	[Address(RVA = "0x153B560", Offset = "0x153A760", Length = "0x8A")]
	[CalledBy(Type = typeof(ValueTask), Member = "AsTask", ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueTaskSource)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001325")]
	internal static Task get_CompletedTask() { }

	[Address(RVA = "0x153B5F0", Offset = "0x153A7F0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600132E")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x13B68E0", Offset = "0x13B5AE0", Length = "0x1F")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001330")]
	public ValueTaskAwaiter GetAwaiter() { }

	[Address(RVA = "0x153AFF0", Offset = "0x153A1F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001329")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x153B010", Offset = "0x153A210", Length = "0x2FE")]
	[CalledBy(Type = typeof(ValueTask), Member = "AsTask", ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600132D")]
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	[Address(RVA = "0x153B310", Offset = "0x153A510", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[StackTraceHidden]
	[Token(Token = "0x600132F")]
	internal void ThrowIfCompletedUnsuccessfully() { }

}

