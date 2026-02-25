namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x2000623")]
public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000624")]
	private sealed class <>c
	{
		[Token(Token = "0x40016E8")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1BCDA40", Offset = "0x1BCCC40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002B16")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B17")]
		public <>c() { }

		[Address(RVA = "0x1BCD730", Offset = "0x1BCC930", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002B18")]
		internal PointerOutLinkTagEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1BBFBC0", Offset = "0x1BBEDC0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B11")]
	private static PointerOutLinkTagEvent() { }

	[Address(RVA = "0x1BBFCA0", Offset = "0x1BBEEA0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6002B15")]
	public PointerOutLinkTagEvent() { }

	[Address(RVA = "0x1BBFB30", Offset = "0x1BBED30", Length = "0x39")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerOutEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6002B14")]
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	[Address(RVA = "0x1BBFB70", Offset = "0x1BBED70", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6002B12")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BBF7E0", Offset = "0x1BBE9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B13")]
	private void LocalInit() { }

}

