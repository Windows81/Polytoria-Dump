namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000466")]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000467")]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400124B")]
		private readonly ValueTask _value; //Field offset: 0x0

		[Token(Token = "0x170003F3")]
		public bool IsCompleted
		{
			[Address(RVA = "0x13B6BC0", Offset = "0x13B5DC0", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813204F0")]
			[Token(Token = "0x6002012")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002011")]
		internal ConfiguredValueTaskAwaiter(ValueTask value) { }

		[Address(RVA = "0x13B6BC0", Offset = "0x13B5DC0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813204F0")]
		[Token(Token = "0x6002012")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x13B6900", Offset = "0x13B5B00", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813203E0")]
		[StackTraceHidden]
		[Token(Token = "0x6002013")]
		public void GetResult() { }

		[Address(RVA = "0x13B6950", Offset = "0x13B5B50", Length = "0x264")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002014")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124A")]
	private readonly ValueTask _value; //Field offset: 0x0

	[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600200F")]
	internal ConfiguredValueTaskAwaitable(ValueTask value) { }

	[Address(RVA = "0x13B68E0", Offset = "0x13B5AE0", Length = "0x1F")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002010")]
	public ConfiguredValueTaskAwaiter GetAwaiter() { }

}

