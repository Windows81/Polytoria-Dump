namespace RLD;

[Token(Token = "0x200011A")]
public class UniversalGizmoSettings2D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000519")]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400051A")]
	private GizmoPlaneSlider2DSettings _mvDblSliderSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400051B")]
	private GizmoLineSlider2DSettings[] _mvSglSliderSettings; //Field offset: 0x38

	[Token(Token = "0x17000481")]
	public UniversalGizmoSettingsCategory DisplayCategory
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D68")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D69")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700047D")]
	public float MvBoxSliderHoverEps
	{
		[Address(RVA = "0x54F0F0", Offset = "0x54E2F0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D64")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000480")]
	public float MvDragSensitivity
	{
		[Address(RVA = "0x518D90", Offset = "0x517F90", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D67")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700047C")]
	public float MvLineSliderHoverEps
	{
		[Address(RVA = "0x54F130", Offset = "0x54E330", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D63")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700047E")]
	public float MvXSnapStep
	{
		[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D65")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700047F")]
	public float MvYSnapStep
	{
		[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D66")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x54EF50", Offset = "0x54E150", Length = "0x19C")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoPlaneSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6A")]
	public UniversalGizmoSettings2D() { }

	[Address(RVA = "0x54E9E0", Offset = "0x54DBE0", Length = "0x2C")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D71")]
	public void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x54EA10", Offset = "0x54DC10", Length = "0x63")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D70")]
	public void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D68")]
	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	[Address(RVA = "0x54F0F0", Offset = "0x54E2F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D64")]
	public float get_MvBoxSliderHoverEps() { }

	[Address(RVA = "0x518D90", Offset = "0x517F90", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D67")]
	public float get_MvDragSensitivity() { }

	[Address(RVA = "0x54F130", Offset = "0x54E330", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D63")]
	public float get_MvLineSliderHoverEps() { }

	[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D65")]
	public float get_MvXSnapStep() { }

	[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D66")]
	public float get_MvYSnapStep() { }

	[Address(RVA = "0x528B60", Offset = "0x527D60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D73")]
	private GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x54EA80", Offset = "0x54DC80", Length = "0x254")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = "set_OffsetSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x6000D72")]
	public void Inherit(MoveGizmoSettings2D settings) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D69")]
	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x54ECE0", Offset = "0x54DEE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6C")]
	public void SetMvBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x54ED50", Offset = "0x54DF50", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D6F")]
	public void SetMvDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x54EDE0", Offset = "0x54DFE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6B")]
	public void SetMvLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x54EE50", Offset = "0x54E050", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = "set_OffsetSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6D")]
	public void SetMvXSnapStep(float snapStep) { }

	[Address(RVA = "0x54EED0", Offset = "0x54E0D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = "set_OffsetSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6E")]
	public void SetMvYSnapStep(float snapStep) { }

}

