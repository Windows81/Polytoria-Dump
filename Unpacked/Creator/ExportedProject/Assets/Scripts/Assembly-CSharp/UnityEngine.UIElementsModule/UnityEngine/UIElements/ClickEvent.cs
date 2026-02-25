namespace UnityEngine.UIElements;

[Token(Token = "0x2000226")]
public sealed class ClickEvent : PointerEventBase<ClickEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000227")]
	private sealed class <>c
	{
		[Token(Token = "0x40008B6")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61F60", Offset = "0x1C61160", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F25")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F26")]
		public <>c() { }

		[Address(RVA = "0x1C5FD90", Offset = "0x1C5EF90", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000F27")]
		internal ClickEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C49360", Offset = "0x1C48560", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F20")]
	private static ClickEvent() { }

	[Address(RVA = "0x1C49440", Offset = "0x1C48640", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F23")]
	public ClickEvent() { }

	[Address(RVA = "0x1C49290", Offset = "0x1C48490", Length = "0x61")]
	[CalledBy(Type = typeof(ClickDetector), Member = "SendClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F24")]
	internal static ClickEvent GetPooled(IPointerEvent pointerEvent, int clickCount) { }

	[Address(RVA = "0x1C49300", Offset = "0x1C48500", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000F21")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C49350", Offset = "0x1C48550", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000F22")]
	private void LocalInit() { }

}

