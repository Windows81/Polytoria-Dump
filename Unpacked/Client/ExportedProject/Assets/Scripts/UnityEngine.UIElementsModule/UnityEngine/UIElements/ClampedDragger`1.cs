namespace UnityEngine.UIElements;

[Token(Token = "0x200004C")]
internal class ClampedDragger : Clickable
{
	[Flags]
	[Token(Token = "0x200004D")]
	internal enum DragDirection
	{
		None = 0,
		LowToHigh = 1,
		HighToLow = 2,
		Free = 4,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016D")]
	private Action dragging; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016E")]
	private Action draggingEnded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016F")]
	private DragDirection<T> <dragDirection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000170")]
	private BaseSlider<T> <slider>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000171")]
	private Vector2 <startMousePosition>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x14000002")]
	public event Action dragging
	{
		[Address(RVA = "0x96B9F0", Offset = "0x96ABF0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000230")]
		 add { } //Length: 158
		[Address(RVA = "0x96BF10", Offset = "0x96B110", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000231")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public event Action draggingEnded
	{
		[Address(RVA = "0x96B8B0", Offset = "0x96AAB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000232")]
		 add { } //Length: 158
		[Address(RVA = "0x96BC90", Offset = "0x96AE90", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000233")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700004A")]
	public Vector2 delta
	{
		[Address(RVA = "0x96BB30", Offset = "0x96AD30", Length = "0x35")]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MinMaxSlider), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000239")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000047")]
	public DragDirection<T> dragDirection
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000234")]
		 get { } //Length: 7
		[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000235")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000048")]
	private BaseSlider<T> slider
	{
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000236")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000049")]
	public private Vector2 startMousePosition
	{
		[Address(RVA = "0x96BBD0", Offset = "0x96ADD0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000237")]
		 get { } //Length: 25
		[Address(RVA = "0x96BFB0", Offset = "0x96B1B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000238")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x96B500", Offset = "0x96A700", Length = "0xDF")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x600023A")]
	public ClampedDragger`1(BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }

	[Address(RVA = "0x96B9F0", Offset = "0x96ABF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000230")]
	public void add_dragging(Action value) { }

	[Address(RVA = "0x96B8B0", Offset = "0x96AAB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000232")]
	public void add_draggingEnded(Action value) { }

	[Address(RVA = "0x96BB30", Offset = "0x96AD30", Length = "0x35")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000239")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000234")]
	public DragDirection<T> get_dragDirection() { }

	[Address(RVA = "0x96BBD0", Offset = "0x96ADD0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000237")]
	public Vector2 get_startMousePosition() { }

	[Address(RVA = "0x96AFA0", Offset = "0x96A1A0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023B")]
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x96B330", Offset = "0x96A530", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Clickable), Member = "ProcessMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023D")]
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	[Address(RVA = "0x96B4B0", Offset = "0x96A6B0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023C")]
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x96BF10", Offset = "0x96B110", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000231")]
	public void remove_dragging(Action value) { }

	[Address(RVA = "0x96BC90", Offset = "0x96AE90", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000233")]
	public void remove_draggingEnded(Action value) { }

	[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000235")]
	public void set_dragDirection(DragDirection<T> value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000236")]
	private void set_slider(BaseSlider<T> value) { }

	[Address(RVA = "0x96BFB0", Offset = "0x96B1B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000238")]
	private void set_startMousePosition(Vector2 value) { }

}

