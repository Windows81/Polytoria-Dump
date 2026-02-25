//Type is in global namespace

[Token(Token = "0x2000003")]
public static class EmptySprite
{
	[Token(Token = "0x4000003")]
	private static Sprite instance; //Field offset: 0x0

	[Address(RVA = "0x3AFF80", Offset = "0x3AF180", Length = "0xCE")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralImage), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnVerticesDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000004")]
	public static Sprite Get() { }

	[Address(RVA = "0x3B0050", Offset = "0x3AF250", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000005")]
	public static bool IsEmptySprite(Sprite s) { }

}

