namespace MoonSharp.Interpreter.Interop.Converters;

[Token(Token = "0x200012D")]
internal static class TableConversions
{
	[CompilerGenerated]
	[Token(Token = "0x200012E")]
	private sealed class <>c
	{
		[Token(Token = "0x40004A7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004A8")]
		public static Func<DynValue, Object> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x40004A9")]
		public static Func<DynValue, Object> <>9__3_1; //Field offset: 0x10
		[Token(Token = "0x40004AA")]
		public static Func<DynValue, DynValue> <>9__3_2; //Field offset: 0x18
		[Token(Token = "0x40004AB")]
		public static Func<DynValue, DynValue> <>9__3_3; //Field offset: 0x20
		[Token(Token = "0x40004AC")]
		public static Func<DynValue, Object> <>9__3_4; //Field offset: 0x28
		[Token(Token = "0x40004AD")]
		public static Func<DynValue, DynValue> <>9__3_5; //Field offset: 0x30
		[Token(Token = "0x40004AE")]
		public static Func<DynValue, Object> <>9__3_6; //Field offset: 0x38
		[Token(Token = "0x40004AF")]
		public static Func<DynValue, DynValue> <>9__3_7; //Field offset: 0x40

		[Address(RVA = "0x371A80", Offset = "0x370C80", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B61")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B62")]
		public <>c() { }

		[Address(RVA = "0x371660", Offset = "0x370860", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B63")]
		internal object <ConvertTableToType>b__3_0(DynValue v) { }

		[Address(RVA = "0x371660", Offset = "0x370860", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B64")]
		internal object <ConvertTableToType>b__3_1(DynValue v) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B65")]
		internal DynValue <ConvertTableToType>b__3_2(DynValue v) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B66")]
		internal DynValue <ConvertTableToType>b__3_3(DynValue v) { }

		[Address(RVA = "0x371660", Offset = "0x370860", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B67")]
		internal object <ConvertTableToType>b__3_4(DynValue v) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B68")]
		internal DynValue <ConvertTableToType>b__3_5(DynValue v) { }

		[Address(RVA = "0x371660", Offset = "0x370860", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B69")]
		internal object <ConvertTableToType>b__3_6(DynValue v) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6A")]
		internal DynValue <ConvertTableToType>b__3_7(DynValue v) { }

	}


	[Address(RVA = "0x36B530", Offset = "0x36A730", Length = "0x63C")]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfTypeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000B5A")]
	internal static bool CanConvertTableToType(Table table, Type t) { }

	[Address(RVA = "0x36BB70", Offset = "0x36AD70", Length = "0x2A0")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B59")]
	internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict) { }

	[Address(RVA = "0x36BE20", Offset = "0x36B020", Length = "0x1EE")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B58")]
	internal static Table ConvertIListToTable(Script script, IList list) { }

	[Address(RVA = "0x36C010", Offset = "0x36B210", Length = "0x32A")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B5D")]
	internal static object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table) { }

	[Address(RVA = "0x36C340", Offset = "0x36B540", Length = "0x4AD")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Table), Member = "get_Pairs", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.TablePair>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B5C")]
	internal static object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table) { }

	[Address(RVA = "0x36C7F0", Offset = "0x36B9F0", Length = "0x2AA")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B5E")]
	internal static object ConvertTableToListOfGenericType(Type listType, Type itemType, Table table) { }

	[Address(RVA = "0x36CAA0", Offset = "0x36BCA0", Length = "0xE13")]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TableConversions), Member = "TableToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TK", "TV"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), "System.Func`2<DynValue, TK>", "System.Func`2<DynValue, TV>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TK, TV>")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(TableConversions), Member = "TableToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), "System.Func`2<DynValue, T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TableConversions), Member = "ConvertTableToArrayOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TableConversions), Member = "ConvertTableToListOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TableConversions), Member = "ConvertTableToDictionaryOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type), typeof(Table)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 13)]
	[Token(Token = "0x6000B5B")]
	internal static object ConvertTableToType(Table table, Type t) { }

	[Address(RVA = "0x769B00", Offset = "0x768D00", Length = "0x2CE")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Table), Member = "get_Pairs", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.TablePair>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B60")]
	internal static Dictionary<TK, TV> TableToDictionary(Table table, Func<DynValue, TK> keyconverter, Func<DynValue, TV> valconverter) { }

	[Address(RVA = "0x769FB0", Offset = "0x7691B0", Length = "0x14A")]
	[CalledBy(Type = typeof(TableConversions), Member = "ConvertTableToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B5F")]
	internal static List<T> TableToList(Table table, Func<DynValue, T> converter) { }

}

