namespace System.Linq.Expressions;

[Token(Token = "0x20000A8")]
internal sealed class StackGuard
{
	[CompilerGenerated]
	[Token(Token = "0x20000A9")]
	private sealed class <>c__3
	{
		[Token(Token = "0x400016C")]
		public static readonly <>c__3<T1, T2> <>9; //Field offset: 0x0
		[Token(Token = "0x400016D")]
		public static Func<Object, Object> <>9__3_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040B")]
		private static <>c__3`2() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040C")]
		public <>c__3`2() { }

		[Address(RVA = "0x7FD450", Offset = "0x7FC650", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040D")]
		internal object <RunOnEmptyStack>b__3_0(object s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016B")]
	private int _executionStackCount; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040A")]
	public StackGuard() { }

	[Address(RVA = "0x7608C0", Offset = "0x75FAC0", Length = "0x1CC")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`3<System.Object, System.Object, System.Object>))]
	[Calls(Type = typeof(StackGuard), Member = "RunOnEmptyStackCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"R"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, R>", typeof(object)}, ReturnType = "R")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000408")]
	public void RunOnEmptyStack(Action<T1, T2> action, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x760380", Offset = "0x75F580", Length = "0x274")]
	[CalledBy(Type = typeof(StackGuard), Member = "RunOnEmptyStack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<T1, T2>", "T1", "T2"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000409")]
	private R RunOnEmptyStackCore(Func<Object, R> action, object state) { }

	[Address(RVA = "0x15A8800", Offset = "0x15A7A00", Length = "0x63")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InsufficientExecutionStackException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000407")]
	public bool TryEnterOnCurrentStack() { }

}

