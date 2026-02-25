namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000481")]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion
{
	[CompilerGenerated]
	[Token(Token = "0x2000482")]
	private sealed class <>c
	{
		[Token(Token = "0x400125B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x13CE600", Offset = "0x13CD800", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002047")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002048")]
		public <>c() { }

		[Address(RVA = "0x13CE340", Offset = "0x13CD540", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002049")]
		internal void <.cctor>b__9_0(object state) { }

	}

	[Token(Token = "0x4001259")]
	internal static readonly Action<Object> s_invokeActionDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400125A")]
	private readonly ValueTask _value; //Field offset: 0x0

	[Token(Token = "0x17000402")]
	public bool IsCompleted
	{
		[Address(RVA = "0x13CEE90", Offset = "0x13CE090", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813204F0")]
		[Token(Token = "0x6002043")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x13CEDC0", Offset = "0x13CDFC0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002046")]
	private static ValueTaskAwaiter() { }

	[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002042")]
	internal ValueTaskAwaiter(ValueTask value) { }

	[Address(RVA = "0x13CEE90", Offset = "0x13CE090", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813204F0")]
	[Token(Token = "0x6002043")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x13CEB40", Offset = "0x13CDD40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813203E0")]
	[StackTraceHidden]
	[Token(Token = "0x6002044")]
	public void GetResult() { }

	[Address(RVA = "0x13CEB90", Offset = "0x13CDD90", Length = "0x220")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
	[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002045")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

