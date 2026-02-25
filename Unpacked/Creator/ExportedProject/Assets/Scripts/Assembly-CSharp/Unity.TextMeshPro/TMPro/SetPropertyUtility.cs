namespace TMPro;

[Token(Token = "0x200006F")]
internal static class SetPropertyUtility
{

	[Address(RVA = "0x684ED0", Offset = "0x6840D0", Length = "0x5F")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	public static bool SetClass(ref T currentValue, T newValue) { }

	[Address(RVA = "0x18DE4F0", Offset = "0x18DD6F0", Length = "0x3E")]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000402")]
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	[Address(RVA = "0x759360", Offset = "0x758560", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000403")]
	public static bool SetEquatableStruct(ref T currentValue, T newValue) { }

	[Address(RVA = "0x684F30", Offset = "0x684130", Length = "0x90")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000404")]
	public static bool SetStruct(ref T currentValue, T newValue) { }

}

