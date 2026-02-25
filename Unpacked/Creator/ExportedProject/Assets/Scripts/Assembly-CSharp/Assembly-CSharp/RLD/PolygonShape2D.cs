namespace RLD;

[Token(Token = "0x200024A")]
public class PolygonShape2D : Shape2D
{
	[Token(Token = "0x200024C")]
	internal class BorderRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400091F")]
		private Shape2DBorderType _borderType; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000920")]
		private float _thickness; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000921")]
		private Shape2DBorderDirection _direction; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000922")]
		private ThickBorderFillMode _fillMode; //Field offset: 0x1C

		[Token(Token = "0x1700077F")]
		public Shape2DBorderType BorderType
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016DD")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016DE")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000781")]
		public Shape2DBorderDirection Direction
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E1")]
			 get { } //Length: 4
			[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E2")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000782")]
		public ThickBorderFillMode FillMode
		{
			[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E3")]
			 get { } //Length: 4
			[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E4")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000780")]
		public float Thickness
		{
			[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016DF")]
			 get { } //Length: 6
			[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E0")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5A7830", Offset = "0x5A6A30", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60016E5")]
		public BorderRenderDescriptor() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016DD")]
		public Shape2DBorderType get_BorderType() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E1")]
		public Shape2DBorderDirection get_Direction() { }

		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E3")]
		public ThickBorderFillMode get_FillMode() { }

		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016DF")]
		public float get_Thickness() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016DE")]
		public void set_BorderType(Shape2DBorderType value) { }

		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E2")]
		public void set_Direction(Shape2DBorderDirection value) { }

		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E4")]
		public void set_FillMode(ThickBorderFillMode value) { }

		[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E0")]
		public void set_Thickness(float value) { }

	}

	[Token(Token = "0x200024B")]
	internal enum ThickBorderFillMode
	{
		Filled = 0,
		Border = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000913")]
	private Rect _rect; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000914")]
	private bool _isRectDirty; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000915")]
	private bool _isClosed; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000916")]
	private List<Vector2> _cwPolyPoints; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000917")]
	private List<Vector2> _thickCwBorderPoints; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000918")]
	private bool _isThickBorderDirty; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000919")]
	private PolygonEpsilon _epsilon; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400091A")]
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400091B")]
	private BorderRenderDescriptor _borderRenderDesc; //Field offset: 0x50

	[Token(Token = "0x17000779")]
	public float AreaEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C7")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C8")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700077E")]
	public BorderRenderDescriptor BorderRenderDesc
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000778")]
	public PolygonEpsilon Epsilon
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C5")]
		 get { } //Length: 11
		[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C6")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700077C")]
	public bool IsClosed
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000777")]
	public int NumPoints
	{
		[Address(RVA = "0x5B9AF0", Offset = "0x5B8CF0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016C4")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700077D")]
	public Shape2DPtContainMode PtContainMode
	{
		[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CE")]
		 get { } //Length: 4
		[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700077B")]
	public float ThickWireEps
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CB")]
		 get { } //Length: 6
		[Address(RVA = "0x5B9B50", Offset = "0x5B8D50", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60016CC")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700077A")]
	public float WireEps
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C9")]
		 get { } //Length: 6
		[Address(RVA = "0x5B9B60", Offset = "0x5B8D60", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CA")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x5B99F0", Offset = "0x5B8BF0", Length = "0xFA")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(PolygonShape2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60016DC")]
	public PolygonShape2D() { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B80C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x60016DA")]
	private void CalculateRect() { }

	[Address(RVA = "0x5B8EF0", Offset = "0x5B80F0", Length = "0x55")]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DPolyBorderPointsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(PolyBorderDirection), typeof(float), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60016DB")]
	private void CalculateThickBorderPoints() { }

	[Address(RVA = "0x5B8F50", Offset = "0x5B8150", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PolygonShape2D), Member = "CalculateThickBorderPoints", ReturnType = typeof(void))]
	[Calls(Type = typeof(PolygonMath), Member = "Is2DPointOnThickBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PolygonMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PolygonMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016D9")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x5B9050", Offset = "0x5B8250", Length = "0xFB")]
	[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinPolygon2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016D6")]
	public void CopyPoints(PolygonShape2D sourcePoly) { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016C7")]
	public float get_AreaEps() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016D0")]
	public BorderRenderDescriptor get_BorderRenderDesc() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016C5")]
	public PolygonEpsilon get_Epsilon() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016CD")]
	public bool get_IsClosed() { }

	[Address(RVA = "0x5B9AF0", Offset = "0x5B8CF0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016C4")]
	public int get_NumPoints() { }

	[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016CE")]
	public Shape2DPtContainMode get_PtContainMode() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016CB")]
	public float get_ThickWireEps() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016C9")]
	public float get_WireEps() { }

	[Address(RVA = "0x5B9150", Offset = "0x5B8350", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x60016D5")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5B91A0", Offset = "0x5B83A0", Length = "0x2F2")]
	[CalledBy(Type = typeof(GizmoPolygonPlaneSlider2DController), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60016D1")]
	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x5B94A0", Offset = "0x5B86A0", Length = "0x68")]
	[CalledBy(Type = typeof(GizmoRotationArc2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc2DLookAndFeel), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60016D4")]
	public List<Vector2> GetPoints() { }

	[Address(RVA = "0x5B9510", Offset = "0x5B8710", Length = "0x1E1")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "MakePolySphereBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PrimitiveFactory), Member = "GenerateSphereBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "ConvertWorldToScreenPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60016D8")]
	public void MakeSphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera) { }

	[Address(RVA = "0x5B9700", Offset = "0x5B8900", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60016D2")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5B9780", Offset = "0x5B8980", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DPolyBorderPointsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(PolyBorderDirection), typeof(float), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DPolyBorderQuadsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(PolyBorderDirection), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawQuads2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60016D3")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016C8")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016C6")]
	public void set_Epsilon(PolygonEpsilon value) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016CF")]
	public void set_PtContainMode(Shape2DPtContainMode value) { }

	[Address(RVA = "0x5B9B50", Offset = "0x5B8D50", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016CC")]
	public void set_ThickWireEps(float value) { }

	[Address(RVA = "0x5B9B60", Offset = "0x5B8D60", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016CA")]
	public void set_WireEps(float value) { }

	[Address(RVA = "0x5B9880", Offset = "0x5B8A80", Length = "0x164")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "SetPolyCwPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60016D7")]
	public void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed) { }

}

