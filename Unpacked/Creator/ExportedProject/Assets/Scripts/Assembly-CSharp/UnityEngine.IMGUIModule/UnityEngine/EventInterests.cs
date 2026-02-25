namespace UnityEngine;

[Token(Token = "0x2000007")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct EventInterests
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003A")]
	private bool <wantsMouseMove>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400003B")]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400003C")]
	private bool <wantsLessLayoutEvents>k__BackingField; //Field offset: 0x2

	[Token(Token = "0x17000020")]
	public bool wantsLessLayoutEvents
	{
		[Address(RVA = "0x15105A0", Offset = "0x150F7A0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001F")]
	public bool wantsMouseEnterLeaveWindow
	{
		[Address(RVA = "0xE30490", Offset = "0xE2F690", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005C")]
		 get { } //Length: 5
		[Address(RVA = "0x198FB80", Offset = "0x198ED80", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public bool wantsMouseMove
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005A")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x15105A0", Offset = "0x150F7A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005E")]
	public bool get_wantsLessLayoutEvents() { }

	[Address(RVA = "0xE30490", Offset = "0xE2F690", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005C")]
	public bool get_wantsMouseEnterLeaveWindow() { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005A")]
	public bool get_wantsMouseMove() { }

	[Address(RVA = "0x198FB80", Offset = "0x198ED80", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public void set_wantsMouseMove(bool value) { }

	[Address(RVA = "0x199CE60", Offset = "0x199C060", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600005F")]
	public bool WantsEvent(EventType type) { }

	[Address(RVA = "0x199CE80", Offset = "0x199C080", Length = "0xB4")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_textFieldInput", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	public bool WantsLayoutPass(EventType type) { }

}

