namespace UnityEngine.UIElements;

[Token(Token = "0x20001CF")]
public class FocusOutEvent : FocusEventBase<FocusOutEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001D0")]
	private sealed class <>c
	{
		[Token(Token = "0x400082E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62900", Offset = "0x1C61B00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D36")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D37")]
		public <>c() { }

		[Address(RVA = "0x1C5FD20", Offset = "0x1C5EF20", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000D38")]
		internal FocusOutEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C531B0", Offset = "0x1C523B0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D31")]
	private static FocusOutEvent() { }

	[Address(RVA = "0x1C53290", Offset = "0x1C52490", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000D34")]
	public FocusOutEvent() { }

	[Address(RVA = "0x1C530E0", Offset = "0x1C522E0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000D32")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BBF7E0", Offset = "0x1BBE9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D33")]
	private void LocalInit() { }

	[Address(RVA = "0x1C53130", Offset = "0x1C52330", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "ProcessPendingFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D35")]
	protected private virtual void PostDispatch(IPanel panel) { }

}

