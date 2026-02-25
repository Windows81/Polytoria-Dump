namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000508")]
internal static class LanguageDirectionExtensions
{

	[Address(RVA = "0x1B667B0", Offset = "0x1B659B0", Length = "0xC2")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Extension]
	[Token(Token = "0x60024E1")]
	internal static LanguageDirection toTextCore(LanguageDirection dir) { }

}

