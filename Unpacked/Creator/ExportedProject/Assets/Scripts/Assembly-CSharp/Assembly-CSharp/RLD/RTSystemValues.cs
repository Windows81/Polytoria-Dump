namespace RLD;

[Token(Token = "0x2000200")]
public static class RTSystemValues
{

	[Token(Token = "0x1700062D")]
	public static float AxisAlpha
	{
		[Address(RVA = "0x5A1FB0", Offset = "0x5A11B0", Length = "0x9")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Token(Token = "0x60013A7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700062E")]
	public static Color CameraBkGradientFirstColor
	{
		[Address(RVA = "0x5A1FC0", Offset = "0x5A11C0", Length = "0x3B")]
		[CalledBy(Type = typeof(CameraBackgroundSettings), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTCameraBackground), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A8")]
		 get { } //Length: 59
	}

	[Token(Token = "0x1700062F")]
	public static Color CameraBkGradientSecondColor
	{
		[Address(RVA = "0x5A2000", Offset = "0x5A1200", Length = "0xF")]
		[CalledBy(Type = typeof(CameraBackgroundSettings), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTCameraBackground), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60013A9")]
		 get { } //Length: 15
	}

	[Token(Token = "0x1700062C")]
	public static Color CenterAxisColor
	{
		[Address(RVA = "0x5A2010", Offset = "0x5A1210", Length = "0x3B")]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A6")]
		 get { } //Length: 59
	}

	[Token(Token = "0x1700062A")]
	public static Color GridLineColor
	{
		[Address(RVA = "0x5A2050", Offset = "0x5A1250", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A4")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000631")]
	public static Color GuideBorderColor
	{
		[Address(RVA = "0x5A2090", Offset = "0x5A1290", Length = "0x1F")]
		[CalledBy(Type = typeof(GizmoRotationArc2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoRotationArc3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60013AB")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000630")]
	public static Color GuideFillColor
	{
		[Address(RVA = "0x5A20B0", Offset = "0x5A12B0", Length = "0x1F")]
		[CalledBy(Type = typeof(GizmoRotationArc2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoRotationArc3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60013AA")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700062B")]
	public static Color HoveredAxisColor
	{
		[Address(RVA = "0x5A20D0", Offset = "0x5A12D0", Length = "0x38")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A5")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000627")]
	public static Color XAxisColor
	{
		[Address(RVA = "0x5A2110", Offset = "0x5A1310", Length = "0x38")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A1")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000628")]
	public static Color YAxisColor
	{
		[Address(RVA = "0x5A2150", Offset = "0x5A1350", Length = "0x38")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A2")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000629")]
	public static Color ZAxisColor
	{
		[Address(RVA = "0x5A2190", Offset = "0x5A1390", Length = "0x38")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
		[Token(Token = "0x60013A3")]
		 get { } //Length: 56
	}

	[Address(RVA = "0x5A1FB0", Offset = "0x5A11B0", Length = "0x9")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x60013A7")]
	public static float get_AxisAlpha() { }

	[Address(RVA = "0x5A1FC0", Offset = "0x5A11C0", Length = "0x3B")]
	[CalledBy(Type = typeof(CameraBackgroundSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTCameraBackground), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A8")]
	public static Color get_CameraBkGradientFirstColor() { }

	[Address(RVA = "0x5A2000", Offset = "0x5A1200", Length = "0xF")]
	[CalledBy(Type = typeof(CameraBackgroundSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTCameraBackground), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60013A9")]
	public static Color get_CameraBkGradientSecondColor() { }

	[Address(RVA = "0x5A2010", Offset = "0x5A1210", Length = "0x3B")]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A6")]
	public static Color get_CenterAxisColor() { }

	[Address(RVA = "0x5A2050", Offset = "0x5A1250", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A4")]
	public static Color get_GridLineColor() { }

	[Address(RVA = "0x5A2090", Offset = "0x5A1290", Length = "0x1F")]
	[CalledBy(Type = typeof(GizmoRotationArc2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRotationArc3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60013AB")]
	public static Color get_GuideBorderColor() { }

	[Address(RVA = "0x5A20B0", Offset = "0x5A12B0", Length = "0x1F")]
	[CalledBy(Type = typeof(GizmoRotationArc2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRotationArc3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60013AA")]
	public static Color get_GuideFillColor() { }

	[Address(RVA = "0x5A20D0", Offset = "0x5A12D0", Length = "0x38")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A5")]
	public static Color get_HoveredAxisColor() { }

	[Address(RVA = "0x5A2110", Offset = "0x5A1310", Length = "0x38")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A1")]
	public static Color get_XAxisColor() { }

	[Address(RVA = "0x5A2150", Offset = "0x5A1350", Length = "0x38")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A2")]
	public static Color get_YAxisColor() { }

	[Address(RVA = "0x5A2190", Offset = "0x5A1390", Length = "0x38")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60013A3")]
	public static Color get_ZAxisColor() { }

}

