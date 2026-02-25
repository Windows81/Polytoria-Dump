namespace RLD;

[Token(Token = "0x2000110")]
public class RotationGizmoSettings3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400049E")]
	private float _camRightSnapStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400049F")]
	private float _camUpSnapStep; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004A0")]
	private GizmoPlaneSlider3DSettings[] _sliderSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004A1")]
	private GizmoPlaneSlider2DSettings _camLookSliderSettings; //Field offset: 0x38

	[Token(Token = "0x1700038B")]
	public float AxisLineHoverEps
	{
		[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B02")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700038C")]
	public float AxisTorusHoverEps
	{
		[Address(RVA = "0x5160E0", Offset = "0x5152E0", Length = "0x31")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B03")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700038D")]
	public float CamLookLineHoverEps
	{
		[Address(RVA = "0x524430", Offset = "0x523630", Length = "0x1C")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B04")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000396")]
	public float CamLookSnapStep
	{
		[Address(RVA = "0x519430", Offset = "0x518630", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0D")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700038E")]
	public float CamLookThickHoverEps
	{
		[Address(RVA = "0x524450", Offset = "0x523650", Length = "0x1C")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B05")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000394")]
	public float CamRightSnapStep
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000395")]
	public float CamUpSnapStep
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700038F")]
	public bool CanHoverCulledPixels
	{
		[Address(RVA = "0x524470", Offset = "0x523670", Length = "0x33")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B06")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000397")]
	public float DragSensitivity
	{
		[Address(RVA = "0x5244B0", Offset = "0x5236B0", Length = "0x31")]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B0E")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000390")]
	public GizmoSnapMode SnapMode
	{
		[Address(RVA = "0x5244F0", Offset = "0x5236F0", Length = "0x2F")]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B07")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000391")]
	public float XSnapStep
	{
		[Address(RVA = "0x524520", Offset = "0x523720", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B08")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000392")]
	public float YSnapStep
	{
		[Address(RVA = "0x524560", Offset = "0x523760", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B09")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000393")]
	public float ZSnapStep
	{
		[Address(RVA = "0x5245A0", Offset = "0x5237A0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B0A")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x524210", Offset = "0x523410", Length = "0x21F")]
	[CalledBy(Type = typeof(RotationGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoPlaneSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B0F")]
	public RotationGizmoSettings3D() { }

	[Address(RVA = "0x523FA0", Offset = "0x5231A0", Length = "0x2C")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B1C")]
	public void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x523FD0", Offset = "0x5231D0", Length = "0x45")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B1B")]
	public void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) { }

	[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B02")]
	public float get_AxisLineHoverEps() { }

	[Address(RVA = "0x5160E0", Offset = "0x5152E0", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B03")]
	public float get_AxisTorusHoverEps() { }

	[Address(RVA = "0x524430", Offset = "0x523630", Length = "0x1C")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B04")]
	public float get_CamLookLineHoverEps() { }

	[Address(RVA = "0x519430", Offset = "0x518630", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0D")]
	public float get_CamLookSnapStep() { }

	[Address(RVA = "0x524450", Offset = "0x523650", Length = "0x1C")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B05")]
	public float get_CamLookThickHoverEps() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0B")]
	public float get_CamRightSnapStep() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0C")]
	public float get_CamUpSnapStep() { }

	[Address(RVA = "0x524470", Offset = "0x523670", Length = "0x33")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B06")]
	public bool get_CanHoverCulledPixels() { }

	[Address(RVA = "0x5244B0", Offset = "0x5236B0", Length = "0x31")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B0E")]
	public float get_DragSensitivity() { }

	[Address(RVA = "0x5244F0", Offset = "0x5236F0", Length = "0x2F")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B07")]
	public GizmoSnapMode get_SnapMode() { }

	[Address(RVA = "0x524520", Offset = "0x523720", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B08")]
	public float get_XSnapStep() { }

	[Address(RVA = "0x524560", Offset = "0x523760", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B09")]
	public float get_YSnapStep() { }

	[Address(RVA = "0x5245A0", Offset = "0x5237A0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B0A")]
	public float get_ZSnapStep() { }

	[Address(RVA = "0x515750", Offset = "0x514950", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B11")]
	public void SetAxisLineHoverEps(float eps) { }

	[Address(RVA = "0x524020", Offset = "0x523220", Length = "0x3A")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetRotateSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "SetRotateSnapSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B15")]
	public void SetAxisSnapStep(int axisIndex, float snapStep) { }

	[Address(RVA = "0x5151F0", Offset = "0x5143F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B12")]
	public void SetAxisTorusHoverEps(float eps) { }

	[Address(RVA = "0x524060", Offset = "0x523260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B13")]
	public void SetCamLookLineHoverEps(float eps) { }

	[Address(RVA = "0x524080", Offset = "0x523280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B18")]
	public void SetCamLookSnapStep(float snapStep) { }

	[Address(RVA = "0x5240A0", Offset = "0x5232A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B14")]
	public void SetCamLookThickHoverEps(float eps) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B16")]
	public void SetCamRightSnapStep(float snapStep) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B17")]
	public void SetCamUpSnapStep(float snapStep) { }

	[Address(RVA = "0x5240C0", Offset = "0x5232C0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B10")]
	public void SetCanHoverCulledPixels(bool canHover) { }

	[Address(RVA = "0x524120", Offset = "0x523320", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B1A")]
	public void SetDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x5241B0", Offset = "0x5233B0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B19")]
	public void SetSnapMode(GizmoSnapMode snapMode) { }

}

