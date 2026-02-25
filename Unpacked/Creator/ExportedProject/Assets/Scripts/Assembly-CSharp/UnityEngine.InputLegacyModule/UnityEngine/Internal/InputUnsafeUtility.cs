namespace UnityEngine.Internal;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x200000D")]
internal static class InputUnsafeUtility
{

	[Address(RVA = "0x19D9550", Offset = "0x19D8750", Length = "0x186")]
	[CalledBy(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004A")]
	internal static float GetAxis(string axisName) { }

	[Address(RVA = "0x19D9510", Offset = "0x19D8710", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004B")]
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	[Address(RVA = "0x19D94D0", Offset = "0x19D86D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	private static float GetAxis_Injected(ref ManagedSpanWrapper axisName) { }

	[Address(RVA = "0x19D9340", Offset = "0x19D8540", Length = "0x186")]
	[CalledBy(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004C")]
	internal static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x19D9300", Offset = "0x19D8500", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004D")]
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	[Address(RVA = "0x19D92C0", Offset = "0x19D84C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000055")]
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	[Address(RVA = "0x19D9B80", Offset = "0x19D8D80", Length = "0x180")]
	[CalledBy(Type = typeof(Input), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004E")]
	internal static bool GetButton(string buttonName) { }

	[Address(RVA = "0x19D9B40", Offset = "0x19D8D40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004F")]
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x19D9B00", Offset = "0x19D8D00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	private static bool GetButton_Injected(ref ManagedSpanWrapper buttonName) { }

	[Address(RVA = "0x19D9760", Offset = "0x19D8960", Length = "0x180")]
	[CalledBy(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000050")]
	internal static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x19D9720", Offset = "0x19D8920", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000051")]
	internal static byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x19D96E0", Offset = "0x19D88E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000057")]
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }

	[Address(RVA = "0x19D9970", Offset = "0x19D8B70", Length = "0x180")]
	[CalledBy(Type = typeof(Input), Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000052")]
	internal static bool GetButtonUp(string buttonName) { }

	[Address(RVA = "0x19D9930", Offset = "0x19D8B30", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000053")]
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x19D98F0", Offset = "0x19D8AF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	private static bool GetButtonUp_Injected(ref ManagedSpanWrapper buttonName) { }

	[Address(RVA = "0x19D9D10", Offset = "0x19D8F10", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000049")]
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	[Address(RVA = "0x19D9D50", Offset = "0x19D8F50", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000047")]
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	[Address(RVA = "0x19D9D90", Offset = "0x19D8F90", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000048")]
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

}

