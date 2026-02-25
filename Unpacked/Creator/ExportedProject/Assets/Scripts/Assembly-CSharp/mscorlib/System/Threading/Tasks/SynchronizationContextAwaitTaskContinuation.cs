namespace System.Threading.Tasks;

[Token(Token = "0x2000276")]
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	[Token(Token = "0x2000277")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B32")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x153A910", Offset = "0x1539B10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001446")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001447")]
		public <>c() { }

		[Address(RVA = "0x153A8A0", Offset = "0x1539AA0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001448")]
		internal void <.cctor>b__7_0(object state) { }

	}

	[Token(Token = "0x4000B2F")]
	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	[Token(Token = "0x4000B30")]
	private static ContextCallback s_postActionCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B31")]
	private readonly SynchronizationContext m_syncContext; //Field offset: 0x20

	[Address(RVA = "0x152D640", Offset = "0x152C840", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001445")]
	private static SynchronizationContextAwaitTaskContinuation() { }

	[Address(RVA = "0x152D710", Offset = "0x152C910", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001441")]
	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x152D300", Offset = "0x152C500", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001444")]
	private static ContextCallback GetPostActionCallback() { }

	[Address(RVA = "0x152D3E0", Offset = "0x152C5E0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001443")]
	private static void PostAction(object state) { }

	[Address(RVA = "0x152D490", Offset = "0x152C690", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001442")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

