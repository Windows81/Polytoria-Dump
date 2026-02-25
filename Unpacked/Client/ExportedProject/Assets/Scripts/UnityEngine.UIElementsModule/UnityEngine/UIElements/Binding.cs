namespace UnityEngine.UIElements;

[Token(Token = "0x200001C")]
[UxmlObject]
public abstract class Binding
{
	[Token(Token = "0x4000038")]
	internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty."; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000035")]
	private bool m_Dirty; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000036")]
	private BindingUpdateTrigger m_UpdateTrigger; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000037")]
	private string <property>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700001B")]
	public bool isDirty
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		 get { } //Length: 5
	}

	[CreateProperty]
	[Token(Token = "0x1700001C")]
	public BindingUpdateTrigger updateTrigger
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000081")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000082")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x16D78A0", Offset = "0x16D6AA0", Length = "0x1A")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000083")]
	internal Binding() { }

	[Address(RVA = "0x1A96F40", Offset = "0x1A96140", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000085")]
	internal void ClearDirty() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public bool get_isDirty() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000081")]
	public BindingUpdateTrigger get_updateTrigger() { }

	[Address(RVA = "0x1A96F50", Offset = "0x1A96150", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600007C")]
	public static BindingLogLevel GetGlobalLogLevel() { }

	[Address(RVA = "0x1A96FB0", Offset = "0x1A961B0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007E")]
	public static BindingLogLevel GetPanelLogLevel(IPanel panel) { }

	[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000084")]
	public void MarkDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	protected private override void OnActivated(in BindingActivationContext context) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000088")]
	protected private override void OnDataSourceChanged(in DataSourceContextChanged context) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	protected private override void OnDeactivated(in BindingActivationContext context) { }

	[Address(RVA = "0x1A970C0", Offset = "0x1A962C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007F")]
	public static void ResetPanelLogLevel(IPanel panel) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public void set_updateTrigger(BindingUpdateTrigger value) { }

	[Address(RVA = "0x1A97140", Offset = "0x1A96340", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600007B")]
	public static void SetGlobalLogLevel(BindingLogLevel logLevel) { }

	[Address(RVA = "0x1A971A0", Offset = "0x1A963A0", Length = "0xCB")]
	[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007D")]
	public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel) { }

}

