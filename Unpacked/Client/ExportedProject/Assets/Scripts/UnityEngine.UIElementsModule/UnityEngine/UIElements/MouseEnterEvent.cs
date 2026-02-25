namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x20001F1")]
public class MouseEnterEvent : MouseEventBase<MouseEnterEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001F2")]
	private sealed class <>c
	{
		[Token(Token = "0x400084F")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62820", Offset = "0x1C61A20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DEF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF0")]
		public <>c() { }

		[Address(RVA = "0x1C5FFC0", Offset = "0x1C5F1C0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000DF1")]
		internal MouseEnterEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C571D0", Offset = "0x1C563D0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DEA")]
	private static MouseEnterEvent() { }

	[Address(RVA = "0x1C572B0", Offset = "0x1C564B0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000DED")]
	public MouseEnterEvent() { }

	[Address(RVA = "0x1C57160", Offset = "0x1C56360", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToAssignedTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEE")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C57170", Offset = "0x1C56370", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000DEB")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C571C0", Offset = "0x1C563C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEC")]
	private void LocalInit() { }

}

