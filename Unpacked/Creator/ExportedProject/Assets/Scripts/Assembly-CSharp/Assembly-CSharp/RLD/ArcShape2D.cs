namespace RLD;

[Token(Token = "0x2000237")]
public class ArcShape2D : Shape2D
{
	[Token(Token = "0x2000239")]
	internal class BorderRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008C0")]
		private BorderRenderFlags _borderFlags; //Field offset: 0x10

		[Token(Token = "0x170006CD")]
		public BorderRenderFlags BorderFlags
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x600155A")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600155B")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5A7820", Offset = "0x5A6A20", Length = "0xE")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600155C")]
		public BorderRenderDescriptor() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600155A")]
		public BorderRenderFlags get_BorderFlags() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600155B")]
		public void set_BorderFlags(BorderRenderFlags value) { }

	}

	[Token(Token = "0x2000238")]
	internal enum BorderRenderFlags
	{
		None = 0,
		ExtremitiesBorder = 1,
		ArcBorder = 2,
		All = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008AF")]
	private BorderRenderDescriptor _borderRenderDesc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008B0")]
	private Rect _rect; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008B1")]
	private bool _forceShortestArc; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40008B2")]
	private float _radius; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008B3")]
	private Vector2 _origin; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008B4")]
	private Vector2 _startPoint; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008B5")]
	private Vector2 _endPoint; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008B6")]
	private List<Vector2> _borderPoints; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008B7")]
	private float _degreeAngleFromStart; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008B8")]
	private int _numBorderPoints; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008B9")]
	private bool _areBorderPointsDirty; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008BA")]
	private ArcEpsilon _epsilon; //Field offset: 0x5C

	[Token(Token = "0x170006C5")]
	public float AbsDegreeAngleFromStart
	{
		[Address(RVA = "0x58DEB0", Offset = "0x58D0B0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001546")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170006CB")]
	public float AreaEps
	{
		[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600154F")]
		 get { } //Length: 6
		[Address(RVA = "0x58DF30", Offset = "0x58D130", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001550")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170006CC")]
	public BorderRenderDescriptor BorderRenderDesc
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001551")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006C4")]
	public float DegreeAngleFromStart
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001544")]
		 get { } //Length: 6
		[Address(RVA = "0x58DF40", Offset = "0x58D140", Length = "0x32")]
		[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001545")]
		 set { } //Length: 50
	}

	[Token(Token = "0x170006C9")]
	public Vector2 EndPoint
	{
		[Address(RVA = "0x58DED0", Offset = "0x58D0D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600154C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170006CA")]
	public ArcEpsilon Epsilon
	{
		[Address(RVA = "0x3B91C0", Offset = "0x3B83C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600154D")]
		 get { } //Length: 19
		[Address(RVA = "0x58DF80", Offset = "0x58D180", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600154E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170006C3")]
	public bool ForceShortestArc
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001542")]
		 get { } //Length: 5
		[Address(RVA = "0x58DF90", Offset = "0x58D190", Length = "0x1D")]
		[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc2DLookAndFeel), typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001543")]
		 set { } //Length: 29
	}

	[Token(Token = "0x170006C7")]
	public int NumBorderPoints
	{
		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001549")]
		 get { } //Length: 4
		[Address(RVA = "0x58DFB0", Offset = "0x58D1B0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600154A")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170006C6")]
	public Vector2 Origin
	{
		[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001547")]
		 get { } //Length: 19
		[Address(RVA = "0x58DFD0", Offset = "0x58D1D0", Length = "0x8C")]
		[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001548")]
		 set { } //Length: 140
	}

	[Token(Token = "0x170006C2")]
	public float Radius
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001540")]
		 get { } //Length: 6
		[Address(RVA = "0x58E060", Offset = "0x58D260", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001541")]
		 set { } //Length: 146
	}

	[Token(Token = "0x170006C8")]
	public Vector2 StartPoint
	{
		[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600154B")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x58DE30", Offset = "0x58D030", Length = "0x71")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001559")]
	public ArcShape2D() { }

	[Address(RVA = "0x58D8D0", Offset = "0x58CAD0", Length = "0x134")]
	[CalledBy(Type = typeof(ArcShape2D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "set_ForceShortestArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "set_Origin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Vector2Ex), Member = "ToVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001558")]
	private void CalculateEndPoint() { }

	[Address(RVA = "0x58DA10", Offset = "0x58CC10", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcMath), Member = "LgArcContains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "ShArcContains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001556")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x58DEB0", Offset = "0x58D0B0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001546")]
	public float get_AbsDegreeAngleFromStart() { }

	[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600154F")]
	public float get_AreaEps() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001551")]
	public BorderRenderDescriptor get_BorderRenderDesc() { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001544")]
	public float get_DegreeAngleFromStart() { }

	[Address(RVA = "0x58DED0", Offset = "0x58D0D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600154C")]
	public Vector2 get_EndPoint() { }

	[Address(RVA = "0x3B91C0", Offset = "0x3B83C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600154D")]
	public ArcEpsilon get_Epsilon() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001542")]
	public bool get_ForceShortestArc() { }

	[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001549")]
	public int get_NumBorderPoints() { }

	[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001547")]
	public Vector2 get_Origin() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001540")]
	public float get_Radius() { }

	[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600154B")]
	public Vector2 get_StartPoint() { }

	[Address(RVA = "0x58DB00", Offset = "0x58CD00", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcShape2D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6001555")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x58DB40", Offset = "0x58CD40", Length = "0x7E")]
	[CalledBy(Type = typeof(ArcShape2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DArcBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x6001557")]
	private void OnBorderPointsFoundDirty() { }

	[Address(RVA = "0x58DBC0", Offset = "0x58CDC0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcShape2D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001552")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x58DC10", Offset = "0x58CE10", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArcShape2D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001553")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x58DF30", Offset = "0x58D130", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001550")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x58DF40", Offset = "0x58D140", Length = "0x32")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001545")]
	public void set_DegreeAngleFromStart(float value) { }

	[Address(RVA = "0x58DF80", Offset = "0x58D180", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600154E")]
	public void set_Epsilon(ArcEpsilon value) { }

	[Address(RVA = "0x58DF90", Offset = "0x58D190", Length = "0x1D")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc2DLookAndFeel), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001543")]
	public void set_ForceShortestArc(bool value) { }

	[Address(RVA = "0x58DFB0", Offset = "0x58D1B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600154A")]
	public void set_NumBorderPoints(int value) { }

	[Address(RVA = "0x58DFD0", Offset = "0x58D1D0", Length = "0x8C")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001548")]
	public void set_Origin(Vector2 value) { }

	[Address(RVA = "0x58E060", Offset = "0x58D260", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001541")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x58DD80", Offset = "0x58CF80", Length = "0xA3")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001554")]
	public void SetArcData(Vector2 startPoint, float radius) { }

}

