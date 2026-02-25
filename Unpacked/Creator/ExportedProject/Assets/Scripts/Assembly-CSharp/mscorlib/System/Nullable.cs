namespace System;

[Token(Token = "0x200011A")]
public static class Nullable
{

	[Address(RVA = "0x14A46E0", Offset = "0x14A38E0", Length = "0x14A")]
	[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.ScriptToClrConversions", Member = "DynValueToObjectOfTypeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.ScriptToClrConversions", Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.NumericConversions", Member = "DoubleToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(double)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.NullableConverter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60008B4")]
	public static Type GetUnderlyingType(Type nullableType) { }

}

