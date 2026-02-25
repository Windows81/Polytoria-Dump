namespace UnityEngine.InputForUI;

[Token(Token = "0x200002C")]
internal struct PointerState
{
	[Token(Token = "0x40000E0")]
	private static readonly DiscreteTime kClickDelay; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D9")]
	private Button <LastPressedButton>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000DA")]
	private ButtonsState _buttonsState; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DB")]
	private DiscreteTime <NextPressTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DC")]
	private int <ClickCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000DD")]
	private Vector2 <LastPosition>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000DE")]
	private int <LastDisplayIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DF")]
	private bool <LastPositionValid>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000044")]
	public ButtonsState ButtonsState
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public private int ClickCount
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DB")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	public private int LastDisplayIndex
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DF")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000047")]
	public private Vector2 LastPosition
	{
		[Address(RVA = "0xB1EE40", Offset = "0xB1E040", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 19
		[Address(RVA = "0x19D8BF0", Offset = "0x19D7DF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DD")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000049")]
	public bool LastPositionValid
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000043")]
	public private Button LastPressedButton
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000D5")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D6")]
		private set { } //Length: 3
	}

	[Token(Token = "0x17000045")]
	public private DiscreteTime NextPressTime
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 5
		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D9")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x19D8B50", Offset = "0x19D7D50", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E7")]
	private static PointerState() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D7")]
	public ButtonsState get_ButtonsState() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000DA")]
	public int get_ClickCount() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000DE")]
	public int get_LastDisplayIndex() { }

	[Address(RVA = "0xB1EE40", Offset = "0xB1E040", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000DC")]
	public Vector2 get_LastPosition() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000E0")]
	public bool get_LastPositionValid() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000D5")]
	public Button get_LastPressedButton() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60000D8")]
	public DiscreteTime get_NextPressTime() { }

	[Address(RVA = "0x19D8790", Offset = "0x19D7990", Length = "0xB5")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerState), Member = "OnButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E4")]
	public void OnButtonChange(DiscreteTime currentTime, Button button, bool previousState, bool newState) { }

	[Address(RVA = "0x19D8850", Offset = "0x19D7A50", Length = "0x13E")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerState), Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000E2")]
	public void OnButtonDown(DiscreteTime currentTime, Button button) { }

	[Address(RVA = "0x19D8990", Offset = "0x19D7B90", Length = "0x71")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerState), Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000E3")]
	public void OnButtonUp(DiscreteTime currentTime, Button button) { }

	[Address(RVA = "0x19D8A10", Offset = "0x19D7C10", Length = "0x6E")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000E5")]
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	[Address(RVA = "0x19D8A80", Offset = "0x19D7C80", Length = "0xCE")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000E6")]
	public void Reset() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DB")]
	private void set_ClickCount(int value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DF")]
	private void set_LastDisplayIndex(int value) { }

	[Address(RVA = "0x19D8BF0", Offset = "0x19D7DF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DD")]
	private void set_LastPosition(Vector2 value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E1")]
	public void set_LastPositionValid(bool value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D6")]
	private void set_LastPressedButton(Button value) { }

	[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D9")]
	private void set_NextPressTime(DiscreteTime value) { }

}

