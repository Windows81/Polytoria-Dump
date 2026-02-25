namespace UnityEngine.UIElements;

[Token(Token = "0x20001D3")]
public class FocusInEvent : FocusEventBase<FocusInEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001D4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000830")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61D30", Offset = "0x1C60F30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D43")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D44")]
		public <>c() { }

		[Address(RVA = "0x1C60BE0", Offset = "0x1C5FDE0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000D45")]
		internal FocusInEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C52FB0", Offset = "0x1C521B0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D3E")]
	private static FocusInEvent() { }

	[Address(RVA = "0x1C53090", Offset = "0x1C52290", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000D41")]
	public FocusInEvent() { }

	[Address(RVA = "0x1C52EF0", Offset = "0x1C520F0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000D3F")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BBF7E0", Offset = "0x1BBE9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D40")]
	private void LocalInit() { }

	[Address(RVA = "0x1C52F40", Offset = "0x1C52140", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "ProcessPendingFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D42")]
	protected private virtual void PostDispatch(IPanel panel) { }

}

