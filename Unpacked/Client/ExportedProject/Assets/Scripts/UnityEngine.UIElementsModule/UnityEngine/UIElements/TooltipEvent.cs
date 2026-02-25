namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Tooltip (16))]
[Token(Token = "0x2000234")]
public class TooltipEvent : EventBase<TooltipEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000235")]
	private sealed class <>c
	{
		[Token(Token = "0x40008C2")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62120", Offset = "0x1C61320", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F59")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5A")]
		public <>c() { }

		[Address(RVA = "0x1C5FF00", Offset = "0x1C5F100", Length = "0xB2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000F5B")]
		internal TooltipEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008C0")]
	private string <tooltip>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008C1")]
	private Rect <rect>k__BackingField; //Field offset: 0x70

	[Token(Token = "0x170002CA")]
	public Rect rect
	{
		[Address(RVA = "0x1C5DB60", Offset = "0x1C5CD60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000F55")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002C9")]
	public string tooltip
	{
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F54")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1C5D9F0", Offset = "0x1C5CBF0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F53")]
	private static TooltipEvent() { }

	[Address(RVA = "0x1C5DAD0", Offset = "0x1C5CCD0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F58")]
	public TooltipEvent() { }

	[Address(RVA = "0x1C5D950", Offset = "0x1C5CB50", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F56")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C5D9C0", Offset = "0x1C5CBC0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F57")]
	private void LocalInit() { }

	[Address(RVA = "0x1C5DB60", Offset = "0x1C5CD60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000F55")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F54")]
	public void set_tooltip(string value) { }

}

