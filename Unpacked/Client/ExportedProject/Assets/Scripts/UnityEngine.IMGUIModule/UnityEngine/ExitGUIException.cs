namespace UnityEngine;

[Token(Token = "0x2000021")]
public sealed class ExitGUIException : Exception
{

	[Address(RVA = "0x19BAB50", Offset = "0x19B9D50", Length = "0xBB")]
	[CalledBy(Type = typeof(GUIUtility), Member = "ExitGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600022F")]
	public ExitGUIException() { }

	[Address(RVA = "0x19BAC10", Offset = "0x19B9E10", Length = "0xCB")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[]), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000230")]
	internal ExitGUIException(string message) { }

}

