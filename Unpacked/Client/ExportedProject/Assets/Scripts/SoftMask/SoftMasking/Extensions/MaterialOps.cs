namespace SoftMasking.Extensions;

[Extension]
[Token(Token = "0x2000020")]
public static class MaterialOps
{

	[Address(RVA = "0x15622C0", Offset = "0x15614C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60000D4")]
	public static void EnableKeyword(Material mat, string keyword, bool enabled) { }

	[Address(RVA = "0x15622F0", Offset = "0x15614F0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60000D3")]
	public static bool HasDefaultETC1UIShader(Material mat) { }

	[Address(RVA = "0x1562380", Offset = "0x1561580", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60000D2")]
	public static bool HasDefaultUIShader(Material mat) { }

	[Address(RVA = "0x1562410", Offset = "0x1561610", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60000D1")]
	public static bool SupportsSoftMask(Material mat) { }

}

