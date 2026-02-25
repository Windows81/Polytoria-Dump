namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000468")]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000469")]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400124D")]
		private readonly ValueTask<TResult> _value; //Field offset: 0x0

		[Token(Token = "0x170003F4")]
		public bool IsCompleted
		{
			[Address(RVA = "0x86FC90", Offset = "0x86EE90", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036E40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002018")]
			 get { } //Length: 54
		}

		[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002017")]
		internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value) { }

		[Address(RVA = "0x86FC90", Offset = "0x86EE90", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036E40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002018")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x865B70", Offset = "0x864D70", Length = "0x36")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036F40")]
		[DeduplicatedMethod]
		[StackTraceHidden]
		[Token(Token = "0x6002019")]
		public TResult GetResult() { }

		[Address(RVA = "0x9DE840", Offset = "0x9DDA40", Length = "0x248")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
		[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600201A")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124C")]
	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002015")]
	internal ConfiguredValueTaskAwaitable`1(ValueTask<TResult> value) { }

	[Address(RVA = "0x870E10", Offset = "0x870010", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002016")]
	public ConfiguredValueTaskAwaiter<TResult> GetAwaiter() { }

}

