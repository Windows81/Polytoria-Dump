namespace UnityEngine.UIElements;

[Token(Token = "0x20001FD")]
public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001FE")]
	private sealed class <>c
	{
		[Token(Token = "0x4000858")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C618D0", Offset = "0x1C60AD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E24")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E25")]
		public <>c() { }

		[Address(RVA = "0x1C60030", Offset = "0x1C5F230", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContextualMenuPopulateEvent), Member = "LocalInit", ReturnType = typeof(void))]
		[Token(Token = "0x6000E26")]
		internal ContextualMenuPopulateEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000855")]
	private DropdownMenu <menu>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000856")]
	private EventBase <triggerEvent>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000857")]
	private ContextualMenuManager m_ContextualMenuManager; //Field offset: 0xB0

	[Token(Token = "0x1700027A")]
	public private DropdownMenu menu
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1B")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700027B")]
	public private EventBase triggerEvent
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1D")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1E")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x1C49CC0", Offset = "0x1C48EC0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E1A")]
	private static ContextualMenuPopulateEvent() { }

	[Address(RVA = "0x1C49DA0", Offset = "0x1C48FA0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuPopulateEvent), Member = "LocalInit", ReturnType = typeof(void))]
	[Token(Token = "0x6000E22")]
	public ContextualMenuPopulateEvent() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1B")]
	public DropdownMenu get_menu() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1D")]
	public EventBase get_triggerEvent() { }

	[Address(RVA = "0x1C49720", Offset = "0x1C48920", Length = "0x3C9")]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E1F")]
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	[Address(RVA = "0x1C49AF0", Offset = "0x1C48CF0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000E20")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C49B40", Offset = "0x1C48D40", Length = "0x83")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__0_0", ReturnType = typeof(ContextualMenuPopulateEvent))]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E21")]
	private void LocalInit() { }

	[Address(RVA = "0x1C49BD0", Offset = "0x1C48DD0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DropdownMenu), Member = "PrepareForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E23")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1C")]
	private void set_menu(DropdownMenu value) { }

	[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1E")]
	private void set_triggerEvent(EventBase value) { }

}

