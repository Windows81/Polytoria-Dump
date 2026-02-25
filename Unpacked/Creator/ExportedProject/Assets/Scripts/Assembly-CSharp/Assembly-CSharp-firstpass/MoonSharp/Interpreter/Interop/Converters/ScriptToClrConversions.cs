namespace MoonSharp.Interpreter.Interop.Converters;

[Token(Token = "0x200012A")]
internal static class ScriptToClrConversions
{
	[Token(Token = "0x400048C")]
	internal const int WEIGHT_MAX_VALUE = 100; //Field offset: 0x0
	[Token(Token = "0x400049F")]
	internal const int WEIGHT_BYREF_BONUSMALUS = -10; //Field offset: 0x0
	[Token(Token = "0x400049E")]
	internal const int WEIGHT_EXTRA_PARAMS_MALUS = 2; //Field offset: 0x0
	[Token(Token = "0x400049D")]
	internal const int WEIGHT_NO_EXTRA_PARAMS_BONUS = 100; //Field offset: 0x0
	[Token(Token = "0x400049C")]
	internal const int WEIGHT_NO_MATCH = 0; //Field offset: 0x0
	[Token(Token = "0x400049B")]
	internal const int WEIGHT_NUMBER_DOWNCAST = 99; //Field offset: 0x0
	[Token(Token = "0x400049A")]
	internal const int WEIGHT_TABLE_CONVERSION = 90; //Field offset: 0x0
	[Token(Token = "0x4000499")]
	internal const int WEIGHT_USERDATA_TO_STRING = 5; //Field offset: 0x0
	[Token(Token = "0x4000498")]
	internal const int WEIGHT_NUMBER_TO_ENUM = 90; //Field offset: 0x0
	[Token(Token = "0x4000497")]
	internal const int WEIGHT_NUMBER_TO_STRING = 50; //Field offset: 0x0
	[Token(Token = "0x4000496")]
	internal const int WEIGHT_BOOL_TO_STRING = 5; //Field offset: 0x0
	[Token(Token = "0x4000495")]
	internal const int WEIGHT_NIL_WITH_DEFAULT = 25; //Field offset: 0x0
	[Token(Token = "0x4000494")]
	internal const int WEIGHT_VOID_WITHOUT_DEFAULT = 25; //Field offset: 0x0
	[Token(Token = "0x4000493")]
	internal const int WEIGHT_VOID_WITH_DEFAULT = 50; //Field offset: 0x0
	[Token(Token = "0x4000492")]
	internal const int WEIGHT_NIL_TO_REFTYPE = 100; //Field offset: 0x0
	[Token(Token = "0x4000491")]
	internal const int WEIGHT_NIL_TO_NULLABLE = 100; //Field offset: 0x0
	[Token(Token = "0x4000490")]
	internal const int WEIGHT_STRING_TO_CHAR = 98; //Field offset: 0x0
	[Token(Token = "0x400048F")]
	internal const int WEIGHT_STRING_TO_STRINGBUILDER = 99; //Field offset: 0x0
	[Token(Token = "0x400048E")]
	internal const int WEIGHT_EXACT_MATCH = 100; //Field offset: 0x0
	[Token(Token = "0x400048D")]
	internal const int WEIGHT_CUSTOM_CONVERTER_MATCH = 100; //Field offset: 0x0
	[Token(Token = "0x40004A0")]
	internal const int WEIGHT_VARARGS_MALUS = 1; //Field offset: 0x0
	[Token(Token = "0x40004A1")]
	internal const int WEIGHT_VARARGS_EMPTY = 40; //Field offset: 0x0

	[Address(RVA = "0x36ABD0", Offset = "0x369DD0", Length = "0x334")]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Closure), Member = "<GetDelegate>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Coroutine+<AsEnumerable>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Table), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Table), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.LinqHelpers+<>c", Member = "<AsObjects>b__2_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(DynValue), Member = "get_Boolean", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "ConvertObjectFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CustomConvertersCollection), Member = "GetScriptToClrCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type)}, ReturnType = typeof(System.Func`2<MoonSharp.Interpreter.DynValue, System.Object>))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B51")]
	internal static object DynValueToObject(DynValue value) { }

	[Address(RVA = "0x369DB0", Offset = "0x368FB0", Length = "0xDF0")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToArrayOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToListOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToDictionaryOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(HardwiredMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ArrayMemberDescriptor), Member = "ArrayIndexerSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(PropertyTableAssigner), Member = "TryAssignProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(DynValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynValue), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Closure), Member = "GetDelegate", ReturnType = typeof(ScriptFunctionDelegate))]
	[Calls(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "ConvertObjectFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType), typeof(Type)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomConvertersCollection), Member = "GetScriptToClrCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type)}, ReturnType = typeof(System.Func`2<MoonSharp.Interpreter.DynValue, System.Object>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringConversions), Member = "GetStringSubtype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StringSubtype))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DynValue), Member = "get_Boolean", ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "HasImplicitConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(NumericConversions), Member = "DoubleToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(double)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000B53")]
	internal static object DynValueToObjectOfType(DynValue value, Type desiredType, object defaultValue, bool isOptional) { }

	[Address(RVA = "0x369510", Offset = "0x368710", Length = "0x874")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CalcScoreForSingleArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterDescriptor), typeof(Type), typeof(DynValue), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(TableConversions), Member = "CanConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "HasImplicitConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CustomConvertersCollection), Member = "GetScriptToClrCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type)}, ReturnType = typeof(System.Func`2<MoonSharp.Interpreter.DynValue, System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringConversions), Member = "GetStringSubtype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StringSubtype))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B54")]
	internal static int DynValueToObjectOfTypeWeight(DynValue value, Type desiredType, bool isOptional) { }

	[Address(RVA = "0x36AF30", Offset = "0x36A130", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B55")]
	private static int GetNumericTypeWeight(Type desiredType) { }

	[Address(RVA = "0x36AFF0", Offset = "0x36A1F0", Length = "0x189")]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "HasImplicitConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfTypeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "HasImplicitConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000B52")]
	public static MethodInfo HasImplicitConversion(Type baseType, Type targetType) { }

}

