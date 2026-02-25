namespace System.Diagnostics;

[SwitchLevel(typeof(bool))]
[Token(Token = "0x20000FD")]
public class BooleanSwitch : Switch
{

	[Address(RVA = "0x1765C30", Offset = "0x1764E30", Length = "0x93")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Switch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000615")]
	public BooleanSwitch(string displayName, string description) { }

}

