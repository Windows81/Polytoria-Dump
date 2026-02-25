namespace RLD;

[Extension]
[Token(Token = "0x200016B")]
public static class RectEx
{

	[Address(RVA = "0x56B210", Offset = "0x56A410", Length = "0x206")]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "GetOverlappedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Camera), typeof(QueryConfig), typeof(MultiSelectOverlapMode), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "OverlapsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig), typeof(MultiSelectOverlapMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTObjectSelection+<>c__DisplayClass144_0", Member = "<PerformMultiSelect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600102A")]
	public static bool ContainsAllPoints(Rect rect, IEnumerable<Vector2> points) { }

	[Address(RVA = "0x56B420", Offset = "0x56A620", Length = "0x5D")]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001026")]
	public static Rect FromCenterAndSize(Vector2 center, Vector2 size) { }

	[Address(RVA = "0x56B480", Offset = "0x56A680", Length = "0x2B5")]
	[CalledBy(Type = typeof(QuadShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(ArcShape2D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CircleShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(ConeShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "CalculateRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(SegmentShape2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001027")]
	public static Rect FromPoints(IEnumerable<Vector2> points) { }

	[Address(RVA = "0x56B740", Offset = "0x56A940", Length = "0x7E")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "UpdateTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001028")]
	public static Rect FromTexture2D(Texture2D texture2D) { }

	[Address(RVA = "0x56B7C0", Offset = "0x56A9C0", Length = "0x10F")]
	[CalledBy(Type = typeof(GLRenderer), Member = "DrawRectBorder2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GLRenderer), Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "GetOverlappedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Camera), typeof(QueryConfig), typeof(MultiSelectOverlapMode), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "OverlapsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig), typeof(MultiSelectOverlapMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTObjectSelection+<>c__DisplayClass144_0", Member = "<PerformMultiSelect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6001023")]
	public static List<Vector2> GetCornerPoints(Rect rect) { }

	[Address(RVA = "0x56B8D0", Offset = "0x56AAD0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Extension]
	[Token(Token = "0x6001029")]
	public static Rect Inflate(Rect rect, float inflateAmount) { }

	[Address(RVA = "0x56B960", Offset = "0x56AB60", Length = "0xCE")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6001025")]
	public static Rect InvertScreenY(Rect rect) { }

	[Address(RVA = "0x56BA30", Offset = "0x56AC30", Length = "0x95")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "UpdateTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	[Token(Token = "0x6001024")]
	public static Rect PlaceBelowCenterHrz(Rect rect, Rect other) { }

}

