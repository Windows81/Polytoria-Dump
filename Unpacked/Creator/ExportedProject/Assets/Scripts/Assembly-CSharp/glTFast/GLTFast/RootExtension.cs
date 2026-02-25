namespace GLTFast;

[Extension]
[Token(Token = "0x200004F")]
internal static class RootExtension
{

	[Address(RVA = "0x1079DF0", Offset = "0x1078FF0", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6000149")]
	internal static bool IsASkeletonMissing(RootBase root) { }

}

