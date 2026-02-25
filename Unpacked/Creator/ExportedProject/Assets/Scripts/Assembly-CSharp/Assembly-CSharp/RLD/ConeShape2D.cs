namespace RLD;

[Token(Token = "0x2000242")]
public class ConeShape2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008EC")]
	private Vector2 _baseCenter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008ED")]
	private float _rotationDegrees; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40008EE")]
	private float _baseRadius; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008EF")]
	private float _height; //Field offset: 0x20

	[Token(Token = "0x17000715")]
	public Vector2 BaseCenter
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015FB")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015FC")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000716")]
	public Vector2 BaseLeft
	{
		[Address(RVA = "0x5AB320", Offset = "0x5AA520", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
		[Token(Token = "0x60015FD")]
		 get { } //Length: 93
		[Address(RVA = "0x5AB6A0", Offset = "0x5AA8A0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
		[Token(Token = "0x60015FE")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000719")]
	public float BaseRadius
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001603")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001604")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000717")]
	public Vector2 BaseRight
	{
		[Address(RVA = "0x5AB380", Offset = "0x5AA580", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
		[Token(Token = "0x60015FF")]
		 get { } //Length: 93
		[Address(RVA = "0x5AB6F0", Offset = "0x5AA8F0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
		[Token(Token = "0x6001600")]
		 set { } //Length: 82
	}

	[Token(Token = "0x1700071D")]
	public Vector2 CentralAxis
	{
		[Address(RVA = "0x5AB3E0", Offset = "0x5AA5E0", Length = "0xE2")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600160A")]
		 get { } //Length: 226
	}

	[Token(Token = "0x1700071A")]
	public float Height
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001605")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001606")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000722")]
	public static Vector2 ModelBaseCenter
	{
		[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600160F")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000720")]
	public static Vector2 ModelRight
	{
		[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600160D")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000721")]
	public static Vector2 ModelUp
	{
		[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600160E")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700071E")]
	public Vector2 Right
	{
		[Address(RVA = "0x5AB4D0", Offset = "0x5AA6D0", Length = "0xE2")]
		[CalledBy(Type = typeof(ConeShape2D), Member = "get_BaseLeft", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "set_BaseLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "get_BaseRight", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "set_BaseRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConeShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600160B")]
		 get { } //Length: 226
	}

	[Token(Token = "0x1700071C")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5AB5C0", Offset = "0x5AA7C0", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Token(Token = "0x6001609")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700071B")]
	public float RotationDegrees
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001607")]
		 get { } //Length: 6
		[Address(RVA = "0x5AB750", Offset = "0x5AA950", Length = "0x24")]
		[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Token(Token = "0x6001608")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000718")]
	public Vector2 Tip
	{
		[Address(RVA = "0x5AB640", Offset = "0x5AA840", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001601")]
		 get { } //Length: 93
		[Address(RVA = "0x5AB780", Offset = "0x5AA980", Length = "0x52")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001602")]
		 set { } //Length: 82
	}

	[Token(Token = "0x1700071F")]
	public Vector2 Up
	{
		[Address(RVA = "0x5AB3E0", Offset = "0x5AA5E0", Length = "0xE2")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600160C")]
		 get { } //Length: 226
	}

	[Address(RVA = "0x5AB2B0", Offset = "0x5AA4B0", Length = "0x63")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001614")]
	public ConeShape2D() { }

	[Address(RVA = "0x5AAC20", Offset = "0x5A9E20", Length = "0x1C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001612")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015FB")]
	public Vector2 get_BaseCenter() { }

	[Address(RVA = "0x5AB320", Offset = "0x5AA520", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Token(Token = "0x60015FD")]
	public Vector2 get_BaseLeft() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001603")]
	public float get_BaseRadius() { }

	[Address(RVA = "0x5AB380", Offset = "0x5AA580", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Token(Token = "0x60015FF")]
	public Vector2 get_BaseRight() { }

	[Address(RVA = "0x5AB3E0", Offset = "0x5AA5E0", Length = "0xE2")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600160A")]
	public Vector2 get_CentralAxis() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001605")]
	public float get_Height() { }

	[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600160F")]
	public static Vector2 get_ModelBaseCenter() { }

	[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600160D")]
	public static Vector2 get_ModelRight() { }

	[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600160E")]
	public static Vector2 get_ModelUp() { }

	[Address(RVA = "0x5AB4D0", Offset = "0x5AA6D0", Length = "0xE2")]
	[CalledBy(Type = typeof(ConeShape2D), Member = "get_BaseLeft", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "set_BaseLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "get_BaseRight", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "set_BaseRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600160B")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x5AB5C0", Offset = "0x5AA7C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001609")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001607")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x5AB640", Offset = "0x5AA840", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001601")]
	public Vector2 get_Tip() { }

	[Address(RVA = "0x5AB3E0", Offset = "0x5AA5E0", Length = "0xE2")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600160C")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x5AADE0", Offset = "0x5A9FE0", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001613")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5AAF80", Offset = "0x5AA180", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001610")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5AB120", Offset = "0x5AA320", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001611")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015FC")]
	public void set_BaseCenter(Vector2 value) { }

	[Address(RVA = "0x5AB6A0", Offset = "0x5AA8A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Token(Token = "0x60015FE")]
	public void set_BaseLeft(Vector2 value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001604")]
	public void set_BaseRadius(float value) { }

	[Address(RVA = "0x5AB6F0", Offset = "0x5AA8F0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Token(Token = "0x6001600")]
	public void set_BaseRight(Vector2 value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001606")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5AB750", Offset = "0x5AA950", Length = "0x24")]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Token(Token = "0x6001608")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5AB780", Offset = "0x5AA980", Length = "0x52")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001602")]
	public void set_Tip(Vector2 value) { }

}

