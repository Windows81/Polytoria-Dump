namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x20003FD")]
internal static class IOUtil
{

	[Address(RVA = "0x2F79D0", Offset = "0x2F6BD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD4")]
	internal static bool FlagTest(MessageEnum flag, MessageEnum target) { }

	[Address(RVA = "0x139E920", Offset = "0x139DB20", Length = "0x8C")]
	[CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001DD5")]
	internal static void WriteStringWithCode(string value, __BinaryWriter sout) { }

	[Address(RVA = "0x139E9B0", Offset = "0x139DBB0", Length = "0x142")]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001DD6")]
	internal static void WriteWithCode(Type type, object value, __BinaryWriter sout) { }

}

