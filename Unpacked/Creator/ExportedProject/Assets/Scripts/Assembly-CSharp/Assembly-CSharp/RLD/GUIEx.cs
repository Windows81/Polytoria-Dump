namespace RLD;

[Token(Token = "0x2000162")]
public static class GUIEx
{
	[Token(Token = "0x4000647")]
	private static Stack<Color> _colorStack; //Field offset: 0x0

	[Address(RVA = "0x53F880", Offset = "0x53EA80", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FF2")]
	private static GUIEx() { }

	[Address(RVA = "0x53F6B0", Offset = "0x53E8B0", Length = "0xE0")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF1")]
	public static void PopColor() { }

	[Address(RVA = "0x53F7A0", Offset = "0x53E9A0", Length = "0xD0")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF0")]
	public static void PushColor(Color color) { }

}

