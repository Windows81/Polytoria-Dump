namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerMove (2))]
[Token(Token = "0x20001EB")]
public class MouseMoveEvent : MouseEventBase<MouseMoveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001EC")]
	private sealed class <>c
	{
		[Token(Token = "0x400084B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61940", Offset = "0x1C60B40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DD3")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD4")]
		public <>c() { }

		[Address(RVA = "0x1C601F0", Offset = "0x1C5F3F0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000DD5")]
		internal MouseMoveEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C57F40", Offset = "0x1C57140", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DCE")]
	private static MouseMoveEvent() { }

	[Address(RVA = "0x1C58020", Offset = "0x1C57220", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000DD1")]
	public MouseMoveEvent() { }

	[Address(RVA = "0x1C57E40", Offset = "0x1C57040", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000DD2")]
	internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) { }

	[Address(RVA = "0x1C57E80", Offset = "0x1C57080", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000DCF")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C57EF0", Offset = "0x1C570F0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DD0")]
	private void LocalInit() { }

}

