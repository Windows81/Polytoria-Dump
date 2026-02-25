namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x20001F3")]
public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001F4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000850")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61C50", Offset = "0x1C60E50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DF7")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF8")]
		public <>c() { }

		[Address(RVA = "0x1C60C50", Offset = "0x1C5FE50", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000DF9")]
		internal MouseLeaveEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C57840", Offset = "0x1C56A40", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF2")]
	private static MouseLeaveEvent() { }

	[Address(RVA = "0x1C57920", Offset = "0x1C56B20", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000DF5")]
	public MouseLeaveEvent() { }

	[Address(RVA = "0x1C57160", Offset = "0x1C56360", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToAssignedTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF6")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C577F0", Offset = "0x1C569F0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000DF3")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C571C0", Offset = "0x1C563C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF4")]
	private void LocalInit() { }

}

