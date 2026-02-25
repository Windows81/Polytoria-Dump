namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x200022C")]
public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200022D")]
	private sealed class <>c
	{
		[Token(Token = "0x40008B9")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62890", Offset = "0x1C61A90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F3D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3E")]
		public <>c() { }

		[Address(RVA = "0x1C610D0", Offset = "0x1C602D0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000F3F")]
		internal PointerOverEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C5C6F0", Offset = "0x1C5B8F0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F3A")]
	private static PointerOverEvent() { }

	[Address(RVA = "0x1C5C7D0", Offset = "0x1C5B9D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F3C")]
	public PointerOverEvent() { }

	[Address(RVA = "0x1C57160", Offset = "0x1C56360", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToAssignedTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F3B")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

}

