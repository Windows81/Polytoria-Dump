namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory::PointerMove (2))]
[Token(Token = "0x2000621")]
public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000622")]
	private sealed class <>c
	{
		[Token(Token = "0x40016E7")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1BCD960", Offset = "0x1BCCB60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002B0E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B0F")]
		public <>c() { }

		[Address(RVA = "0x1BCD880", Offset = "0x1BCCA80", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002B10")]
		internal PointerMoveLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40016E5")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40016E6")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000AF3")]
	private string linkID
	{
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B08")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000AF4")]
	private string linkText
	{
		[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B09")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x1BBFA00", Offset = "0x1BBEC00", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B07")]
	private static PointerMoveLinkTagEvent() { }

	[Address(RVA = "0x1BBFAE0", Offset = "0x1BBECE0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6002B0D")]
	public PointerMoveLinkTagEvent() { }

	[Address(RVA = "0x1BBF920", Offset = "0x1BBEB20", Length = "0x8F")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B0C")]
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x1BBF9B0", Offset = "0x1BBEBB0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6002B0A")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BBF7E0", Offset = "0x1BBE9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B0B")]
	private void LocalInit() { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B08")]
	private void set_linkID(string value) { }

	[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B09")]
	private void set_linkText(string value) { }

}

