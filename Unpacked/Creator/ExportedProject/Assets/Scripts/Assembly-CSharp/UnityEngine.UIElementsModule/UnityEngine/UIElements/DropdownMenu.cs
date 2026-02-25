namespace UnityEngine.UIElements;

[Token(Token = "0x200019F")]
public class DropdownMenu
{
	[CompilerGenerated]
	[Token(Token = "0x20001A0")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007B5")]
		public Status status; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C18")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C19")]
		internal Status <AppendAction>b__0(DropdownMenuAction e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A1")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007B6")]
		public string subMenuPath; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C1A")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x1C61450", Offset = "0x1C60650", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C1B")]
		internal bool <AppendSeparator>b__0(DropdownMenuItem item) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B3")]
	private List<DropdownMenuItem> m_MenuItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B4")]
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; //Field offset: 0x18

	[Token(Token = "0x17000228")]
	internal int Count
	{
		[Address(RVA = "0x1C4AD00", Offset = "0x1C49F00", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C10")]
		internal get { } //Length: 60
	}

	[Address(RVA = "0x1C4AC80", Offset = "0x1C49E80", Length = "0x77")]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C17")]
	public DropdownMenu() { }

	[Address(RVA = "0x1C4A530", Offset = "0x1C49730", Length = "0x12F")]
	[CalledBy(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(Status)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "BuildContextualMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C12")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	[Address(RVA = "0x1C4A410", Offset = "0x1C49610", Length = "0x11B")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(System.Func`2<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction+Status>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C13")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Status status = 1) { }

	[Address(RVA = "0x1C4A660", Offset = "0x1C49860", Length = "0x264")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000C14")]
	public void AppendSeparator(string subMenuPath = null) { }

	[Address(RVA = "0x1C4AD00", Offset = "0x1C49F00", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C10")]
	internal int get_Count() { }

	[Address(RVA = "0x1C4A8D0", Offset = "0x1C49AD0", Length = "0x143")]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C15")]
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C11")]
	public List<DropdownMenuItem> MenuItems() { }

	[Address(RVA = "0x1C4AA20", Offset = "0x1C49C20", Length = "0x25B")]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DropdownMenuEventInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DropdownMenuAction), Member = "UpdateActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuEventInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000C16")]
	public void PrepareForDisplay(EventBase e) { }

}

