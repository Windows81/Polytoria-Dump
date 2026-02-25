namespace UnityEngine.UI;

[Token(Token = "0x2000010")]
internal class RectangularVertexClipper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	private readonly Vector3[] m_WorldCorners; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private readonly Vector3[] m_CanvasCorners; //Field offset: 0x18

	[Address(RVA = "0x1A917B0", Offset = "0x1A909B0", Length = "0x76")]
	[CalledBy(Type = typeof(RectMask2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005A")]
	public RectangularVertexClipper() { }

	[Address(RVA = "0x1A915E0", Offset = "0x1A907E0", Length = "0x1C8")]
	[CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000059")]
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

}

