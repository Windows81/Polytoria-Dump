namespace UnityEngine.UIElements;

[HelpURL("UIE-tss")]
[Token(Token = "0x2000470")]
public class ThemeStyleSheet : StyleSheet
{

	[Address(RVA = "0x1B37290", Offset = "0x1B36490", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheet), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600211D")]
	public ThemeStyleSheet() { }

	[Address(RVA = "0x1B37260", Offset = "0x1B36460", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[Token(Token = "0x600211C")]
	internal virtual void OnEnable() { }

}

