namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerDown (3))]
[Token(Token = "0x20001E7")]
public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001E8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000849")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61630", Offset = "0x1C60830", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DC0")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DC1")]
		public <>c() { }

		[Address(RVA = "0x1C5FC90", Offset = "0x1C5EE90", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000DC2")]
		internal MouseDownEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C57010", Offset = "0x1C56210", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB9")]
	private static MouseDownEvent() { }

	[Address(RVA = "0x1C570F0", Offset = "0x1C562F0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000DBC")]
	public MouseDownEvent() { }

	[Address(RVA = "0x1C56E30", Offset = "0x1C56030", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000DBE")]
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	[Address(RVA = "0x1C56EA0", Offset = "0x1C560A0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000DBF")]
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

	[Address(RVA = "0x1C56F10", Offset = "0x1C56110", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000DBA")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C56F80", Offset = "0x1C56180", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DBB")]
	private void LocalInit() { }

	[Address(RVA = "0x1C56FD0", Offset = "0x1C561D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000DBD")]
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

