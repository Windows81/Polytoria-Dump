namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000FF")]
public struct Vector2 : IEquatable<Vector2>, IFormattable
{
	[Token(Token = "0x40004C0")]
	private static readonly Vector2 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40004C8")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40004C9")]
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	[Token(Token = "0x40004C1")]
	private static readonly Vector2 oneVector; //Field offset: 0x8
	[Token(Token = "0x40004C2")]
	private static readonly Vector2 upVector; //Field offset: 0x10
	[Token(Token = "0x40004C3")]
	private static readonly Vector2 downVector; //Field offset: 0x18
	[Token(Token = "0x40004C4")]
	private static readonly Vector2 leftVector; //Field offset: 0x20
	[Token(Token = "0x40004C5")]
	private static readonly Vector2 rightVector; //Field offset: 0x28
	[Token(Token = "0x40004C6")]
	private static readonly Vector2 positiveInfinityVector; //Field offset: 0x30
	[Token(Token = "0x40004C7")]
	private static readonly Vector2 negativeInfinityVector; //Field offset: 0x38
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004BE")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004BF")]
	public float y; //Field offset: 0x4

	[Token(Token = "0x1700015D")]
	public static Vector2 down
	{
		[Address(RVA = "0x1957AA0", Offset = "0x1956CA0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000807")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000156")]
	public float Item
	{
		[Address(RVA = "0x1093FE0", Offset = "0x10931E0", Length = "0x72")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007E4")]
		 get { } //Length: 114
		[Address(RVA = "0x1094060", Offset = "0x1093260", Length = "0x72")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Slider", Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007E5")]
		 set { } //Length: 114
	}

	[Token(Token = "0x1700015E")]
	public static Vector2 left
	{
		[Address(RVA = "0x1957AF0", Offset = "0x1956CF0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000808")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000158")]
	public float magnitude
	{
		[Address(RVA = "0x1957B40", Offset = "0x1956D40", Length = "0xAF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60007F3")]
		 get { } //Length: 175
	}

	[Token(Token = "0x17000160")]
	public static Vector2 negativeInfinity
	{
		[Address(RVA = "0x1957BF0", Offset = "0x1956DF0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600080A")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000157")]
	public Vector2 normalized
	{
		[Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", Length = "0xD5")]
		[CalledBy(Type = "RLD.Plane2D", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ArcShape2D", Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ArcShape2D", Member = "set_Origin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ArcShape2D", Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.PrimitiveFactory", Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", "System.Collections.Generic.List`1<Vector2>"}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
		[CalledBy(Type = "RLD.PrimitiveFactory", Member = "Generate2DPolyBorderPointsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", "RLD.PrimitiveFactory+PolyBorderDirection", typeof(float), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
		[CalledBy(Type = "RLD.PolygonMath", Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(bool), "RLD.PolygonEpsilon"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.Plane2D", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.Plane2D", Member = "set_Normal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.Vector2Ex", Member = "GetNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "RLD.QuaternionEx", Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
		[CalledBy(Type = "RLD.GizmoSglAxisRotationDrag3D", Member = "OnSessionBegin", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoTransformAxisMap2D", Member = "SetFreeAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoTransformAxisMap2D", Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoCircleCap2DController", Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoCircleCap2DController", Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoArrowCap2DController", Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.EqTriangle2D", Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.EqTriangleEdge"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "RLD.SegmentShape2D", Member = "set_Direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60007EC")]
		 get { } //Length: 213
	}

	[Token(Token = "0x1700015B")]
	public static Vector2 one
	{
		[Address(RVA = "0x1957C40", Offset = "0x1956E40", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000805")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700015F")]
	public static Vector2 right
	{
		[Address(RVA = "0x1957C90", Offset = "0x1956E90", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000809")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000159")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x1957CE0", Offset = "0x1956EE0", Length = "0x18")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60007F4")]
		 get { } //Length: 24
	}

	[Token(Token = "0x1700015C")]
	public static Vector2 up
	{
		[Address(RVA = "0x1957D00", Offset = "0x1956F00", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000806")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700015A")]
	public static Vector2 zero
	{
		[Address(RVA = "0x1957D50", Offset = "0x1956F50", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000804")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x19579B0", Offset = "0x1956BB0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600080B")]
	private static Vector2() { }

	[Address(RVA = "0x40FBC0", Offset = "0x40EDC0", Length = "0xA")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E6")]
	public Vector2(float x, float y) { }

	[Address(RVA = "0x1957510", Offset = "0x1956710", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F5")]
	public static float Distance(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x19575C0", Offset = "0x19567C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F2")]
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x1824110", Offset = "0x1823310", Length = "0x26")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60007F1")]
	public override bool Equals(Vector2 other) { }

	[Address(RVA = "0x19575F0", Offset = "0x19567F0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F0")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1957AA0", Offset = "0x1956CA0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000807")]
	public static Vector2 get_down() { }

	[Address(RVA = "0x1093FE0", Offset = "0x10931E0", Length = "0x72")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007E4")]
	public float get_Item(int index) { }

	[Address(RVA = "0x1957AF0", Offset = "0x1956CF0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000808")]
	public static Vector2 get_left() { }

	[Address(RVA = "0x1957B40", Offset = "0x1956D40", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F3")]
	public float get_magnitude() { }

	[Address(RVA = "0x1957BF0", Offset = "0x1956DF0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600080A")]
	public static Vector2 get_negativeInfinity() { }

	[Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", Length = "0xD5")]
	[CalledBy(Type = "RLD.SegmentShape2D", Member = "set_Direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EqTriangle2D", Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.EqTriangleEdge"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "RLD.GizmoArrowCap2DController", Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoCircleCap2DController", Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoCircleCap2DController", Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoTransformAxisMap2D", Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoTransformAxisMap2D", Member = "SetFreeAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.QuaternionEx", Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "RLD.Vector2Ex", Member = "GetNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "RLD.GizmoSglAxisRotationDrag3D", Member = "OnSessionBegin", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Plane2D", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.PolygonMath", Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(bool), "RLD.PolygonEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PrimitiveFactory", Member = "Generate2DPolyBorderPointsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", "RLD.PrimitiveFactory+PolyBorderDirection", typeof(float), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
	[CalledBy(Type = "RLD.PrimitiveFactory", Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", "System.Collections.Generic.List`1<Vector2>"}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
	[CalledBy(Type = "RLD.ArcShape2D", Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ArcShape2D", Member = "set_Origin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ArcShape2D", Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Plane2D", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Plane2D", Member = "set_Normal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007EC")]
	public Vector2 get_normalized() { }

	[Address(RVA = "0x1957C40", Offset = "0x1956E40", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000805")]
	public static Vector2 get_one() { }

	[Address(RVA = "0x1957C90", Offset = "0x1956E90", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000809")]
	public static Vector2 get_right() { }

	[Address(RVA = "0x1957CE0", Offset = "0x1956EE0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F4")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x1957D00", Offset = "0x1956F00", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000806")]
	public static Vector2 get_up() { }

	[Address(RVA = "0x1957D50", Offset = "0x1956F50", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000804")]
	public static Vector2 get_zero() { }

	[Address(RVA = "0x1957690", Offset = "0x1956890", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60007EF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x40ECA0", Offset = "0x40DEA0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E7")]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	[Address(RVA = "0x19576D0", Offset = "0x19568D0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007E8")]
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	[Address(RVA = "0x1957720", Offset = "0x1956920", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F7")]
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x1957760", Offset = "0x1956960", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F6")]
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x19577A0", Offset = "0x19569A0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007EB")]
	public void Normalize() { }

	[Address(RVA = "0x1957DA0", Offset = "0x1956FA0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F8")]
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x1564760", Offset = "0x1563960", Length = "0x31")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FB")]
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x1824370", Offset = "0x1823570", Length = "0x22")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FF")]
	public static Vector2 op_Division(Vector2 a, float d) { }

	[Address(RVA = "0x1957DE0", Offset = "0x1956FE0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000800")]
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x2BC210", Offset = "0x2BB410", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000803")]
	public static Vector3 op_Implicit(Vector2 v) { }

	[Address(RVA = "0x193C320", Offset = "0x193B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000802")]
	public static Vector2 op_Implicit(Vector3 v) { }

	[Address(RVA = "0x1957E30", Offset = "0x1957030", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000801")]
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	[Address(RVA = "0x1957E80", Offset = "0x1957080", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007FD")]
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	[Address(RVA = "0x1957830", Offset = "0x1956A30", Length = "0x31")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FA")]
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x1957EB0", Offset = "0x19570B0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007FE")]
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	[Address(RVA = "0x1957EE0", Offset = "0x19570E0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F9")]
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x1957F20", Offset = "0x1957120", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007FC")]
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	[Address(RVA = "0x1957830", Offset = "0x1956A30", Length = "0x31")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E9")]
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	[Address(RVA = "0x1957870", Offset = "0x1956A70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007EA")]
	public void Scale(Vector2 scale) { }

	[Address(RVA = "0x1094060", Offset = "0x1093260", Length = "0x72")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007E5")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x19578B0", Offset = "0x1956AB0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007EE")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x19578A0", Offset = "0x1956AA0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180866C70")]
	[Token(Token = "0x60007ED")]
	public virtual string ToString() { }

}

