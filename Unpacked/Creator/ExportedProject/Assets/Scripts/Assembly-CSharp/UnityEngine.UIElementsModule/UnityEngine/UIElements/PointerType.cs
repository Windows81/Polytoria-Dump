namespace UnityEngine.UIElements;

[Token(Token = "0x2000217")]
public static class PointerType
{
	[Token(Token = "0x4000887")]
	public static readonly string mouse; //Field offset: 0x0
	[Token(Token = "0x4000888")]
	public static readonly string touch; //Field offset: 0x8
	[Token(Token = "0x4000889")]
	public static readonly string pen; //Field offset: 0x10
	[Token(Token = "0x400088A")]
	public static readonly string tracked; //Field offset: 0x18
	[Token(Token = "0x400088B")]
	public static readonly string unknown; //Field offset: 0x20

	[Address(RVA = "0x1C5CA50", Offset = "0x1C5BC50", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E88")]
	private static PointerType() { }

	[Address(RVA = "0x1C5C810", Offset = "0x1C5BA10", Length = "0x1AB")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000E86")]
	internal static string GetPointerType(int pointerId) { }

	[Address(RVA = "0x1C5C9C0", Offset = "0x1C5BBC0", Length = "0x82")]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E87")]
	internal static bool IsDirectManipulationDevice(string pointerType) { }

}

