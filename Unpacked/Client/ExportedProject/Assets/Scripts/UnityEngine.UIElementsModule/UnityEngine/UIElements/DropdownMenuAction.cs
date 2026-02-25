namespace UnityEngine.UIElements;

[Token(Token = "0x200019D")]
public class DropdownMenuAction : DropdownMenuItem
{
	[Flags]
	[Token(Token = "0x200019E")]
	internal enum Status
	{
		None = 0,
		Normal = 1,
		Disabled = 2,
		Checked = 4,
		Hidden = 8,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A7")]
	private readonly string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007A8")]
	private Status <status>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007A9")]
	private DropdownMenuEventInfo <eventInfo>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007AA")]
	private object <userData>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007AB")]
	private readonly Action<DropdownMenuAction> actionCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007AC")]
	private readonly Func<DropdownMenuAction, Status> actionStatusCallback; //Field offset: 0x38

	[Token(Token = "0x17000226")]
	private DropdownMenuEventInfo eventInfo
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000224")]
	public string name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C08")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000225")]
	private Status status
	{
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C09")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000227")]
	private object userData
	{
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0B")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1C4A0E0", Offset = "0x1C492E0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C0E")]
	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	[Address(RVA = "0x1C4A070", Offset = "0x1C49270", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C0D")]
	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	[Address(RVA = "0x1C4A080", Offset = "0x1C49280", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C0C")]
	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C08")]
	public string get_name() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0A")]
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C09")]
	private void set_status(Status value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0B")]
	private void set_userData(object value) { }

	[Address(RVA = "0x1C4A090", Offset = "0x1C49290", Length = "0x46")]
	[CalledBy(Type = typeof(DropdownMenu), Member = "PrepareForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C0F")]
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

