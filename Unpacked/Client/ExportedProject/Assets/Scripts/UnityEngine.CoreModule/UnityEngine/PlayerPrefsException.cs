namespace UnityEngine;

[Token(Token = "0x200010A")]
public class PlayerPrefsException : Exception
{

	[Address(RVA = "0x196A9F0", Offset = "0x1969BF0", Length = "0x59")]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000877")]
	public PlayerPrefsException(string error) { }

}

