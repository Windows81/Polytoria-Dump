namespace UnityEngine.UIElements;

[Token(Token = "0x200006E")]
public abstract class ContextualMenuManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000212")]
	private bool <displayMenuHandledOSX>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000089")]
	internal bool displayMenuHandledOSX
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003ED")]
		internal get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EE")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F4")]
	protected ContextualMenuManager() { }

	[Address(RVA = "0x1AC70A0", Offset = "0x1AC62A0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003F0")]
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	[Address(RVA = "0x1AC6E20", Offset = "0x1AC6020", Length = "0x27A")]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContextualMenuPopulateEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DropdownMenu), typeof(IEventHandler), typeof(ContextualMenuManager)}, ReturnType = typeof(ContextualMenuPopulateEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseAllButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F1")]
	internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu) { }

	[Token(Token = "0x60003EF")]
	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	[Token(Token = "0x60003F2")]
	protected private abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003ED")]
	internal bool get_displayMenuHandledOSX() { }

	[Address(RVA = "0x1AC7130", Offset = "0x1AC6330", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseAllButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003F3")]
	internal static void ResetPointerDown(int pointerId) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EE")]
	internal void set_displayMenuHandledOSX(bool value) { }

}

