namespace RLD;

[Token(Token = "0x200029C")]
public class MultiSelectShape
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A18")]
	private Rect _enclosingRect; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A19")]
	private bool _isVisible; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A1A")]
	private int _minSize; //Field offset: 0x24

	[Token(Token = "0x1700083F")]
	public Rect EnclosingRect
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001907")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000840")]
	public bool IsVisible
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001908")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001909")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000841")]
	public int MinSize
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600190A")]
		 get { } //Length: 4
		[Address(RVA = "0x3E81C0", Offset = "0x3E73C0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600190B")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x3E81A0", Offset = "0x3E73A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001912")]
	public MultiSelectShape() { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001907")]
	public Rect get_EnclosingRect() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001908")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600190A")]
	public int get_MinSize() { }

	[Address(RVA = "0x3E7A70", Offset = "0x3E6C70", Length = "0x3B0")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcScreenRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RectEx), Member = "GetCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(RectEx), Member = "ContainsAllPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600190E")]
	public void GetOverlappedObjects(List<GameObject> gameObjects, Camera camera, QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode, List<GameObject> overlappedObjects) { }

	[Address(RVA = "0x3E7E30", Offset = "0x3E7030", Length = "0x39")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001911")]
	private bool IsBigEnoughForOverlap() { }

	[Address(RVA = "0x3E7E70", Offset = "0x3E7070", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcScreenRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectEx), Member = "GetCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(RectEx), Member = "ContainsAllPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600190F")]
	public bool OverlapsObject(GameObject gameObject, Camera camera, QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode) { }

	[Address(RVA = "0x3E7FE0", Offset = "0x3E71E0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPool), Member = "get_SimpleColor", ReturnType = typeof(Material))]
	[Calls(Type = typeof(MaterialEx), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialEx), Member = "SetCullModeOff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawRectBorder2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001910")]
	public void Render(Color fillColor, Color borderColor, Camera camera) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001909")]
	public void set_IsVisible(bool value) { }

	[Address(RVA = "0x3E81C0", Offset = "0x3E73C0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600190B")]
	public void set_MinSize(int value) { }

	[Address(RVA = "0x3E8120", Offset = "0x3E7320", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600190D")]
	public void SetEnclosingRectBottomRightPoint(Vector2 bottomRightPoint) { }

	[Address(RVA = "0x3E8160", Offset = "0x3E7360", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600190C")]
	public void SetEnclosingRectTopLeftPoint(Vector2 topLeftPoint) { }

}

