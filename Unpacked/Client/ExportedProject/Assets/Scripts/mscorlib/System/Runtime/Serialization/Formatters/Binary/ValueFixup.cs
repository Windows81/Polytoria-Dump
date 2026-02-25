namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000425")]
internal sealed class ValueFixup
{
	[Token(Token = "0x4001153")]
	internal static MemberInfo valueInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400114E")]
	internal ValueFixupEnum valueFixupEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400114F")]
	internal Array arrayObj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001150")]
	internal Int32[] indexMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001151")]
	internal object header; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001152")]
	internal object memberObject; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001154")]
	internal ReadObjectInfo objectInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001155")]
	internal string memberName; //Field offset: 0x40

	[Address(RVA = "0x13CEA60", Offset = "0x13CDC60", Length = "0x55")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F3C")]
	internal ValueFixup(Array arrayObj, Int32[] indexMap) { }

	[Address(RVA = "0x13CEAC0", Offset = "0x13CDCC0", Length = "0x72")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F3D")]
	internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	[Address(RVA = "0x13CE6F0", Offset = "0x13CD8F0", Length = "0x363")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F3E")]
	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

