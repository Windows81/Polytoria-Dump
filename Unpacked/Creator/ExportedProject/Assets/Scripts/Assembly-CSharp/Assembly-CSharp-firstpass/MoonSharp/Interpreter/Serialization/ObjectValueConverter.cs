namespace MoonSharp.Interpreter.Serialization;

[Token(Token = "0x20000AD")]
public static class ObjectValueConverter
{

	[Address(RVA = "0x3272B0", Offset = "0x3264B0", Length = "0x4CA")]
	[CalledBy(Type = typeof(ObjectValueConverter), Member = "SerializeObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ObjectToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(Table), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectValueConverter), Member = "SerializeObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(NumericConversions), Member = "TypeToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "TryObjectToTrivialDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60007B3")]
	public static DynValue SerializeObjectToDynValue(Script script, object o, DynValue valueForNulls = null) { }

}

