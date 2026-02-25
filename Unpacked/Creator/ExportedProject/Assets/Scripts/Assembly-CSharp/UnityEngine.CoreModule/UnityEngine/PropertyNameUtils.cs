namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PropertyName.h")]
[Token(Token = "0x2000116")]
internal class PropertyNameUtils
{

	[Address(RVA = "0x196B9C0", Offset = "0x196ABC0", Length = "0x1B4")]
	[CalledBy(Type = typeof(PropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PropertyNameFromStringICall", IsThreadSafe = True)]
	[Token(Token = "0x6000894")]
	public static PropertyName PropertyNameFromString(string name) { }

	[Address(RVA = "0x196B970", Offset = "0x196AB70", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000895")]
	private static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret) { }

}

