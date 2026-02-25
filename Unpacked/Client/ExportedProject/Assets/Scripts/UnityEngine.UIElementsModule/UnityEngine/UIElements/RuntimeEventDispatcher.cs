namespace UnityEngine.UIElements;

[Token(Token = "0x200026F")]
internal static class RuntimeEventDispatcher
{

	[Address(RVA = "0x1C73F20", Offset = "0x1C73120", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[Token(Token = "0x6001120")]
	public static EventDispatcher Create() { }

}

