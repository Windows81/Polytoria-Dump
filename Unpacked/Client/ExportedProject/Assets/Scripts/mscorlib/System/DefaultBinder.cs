namespace System;

[Token(Token = "0x200017F")]
internal class DefaultBinder : Binder
{
	[CompilerGenerated]
	[Token(Token = "0x2000182")]
	private sealed class <>c
	{
		[Token(Token = "0x40005A9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005AA")]
		public static Predicate<Type> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x14EE510", Offset = "0x14ED710", Length = "0xB2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D79")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D7A")]
		public <>c() { }

		[Address(RVA = "0x14EE4E0", Offset = "0x14ED6E0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D7B")]
		internal bool <SelectProperty>b__2_0(Type t) { }

	}

	[Token(Token = "0x2000180")]
	public class BinderState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000596")]
		internal Int32[] m_argsMap; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000597")]
		internal int m_originalSize; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000598")]
		internal bool m_isParamArray; //Field offset: 0x1C

		[Address(RVA = "0x115CA10", Offset = "0x115BC10", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D78")]
		internal BinderState(Int32[] argsMap, int originalSize, bool isParamArray) { }

	}

	[Flags]
	[Token(Token = "0x2000181")]
	private enum Primitives
	{
		Boolean = 8,
		Char = 16,
		SByte = 32,
		Byte = 64,
		Int16 = 128,
		UInt16 = 256,
		Int32 = 512,
		UInt32 = 1024,
		Int64 = 2048,
		UInt64 = 4096,
		Single = 8192,
		Double = 16384,
		Decimal = 32768,
		DateTime = 65536,
		String = 262144,
	}

	[Token(Token = "0x4000595")]
	private static Primitives[] _primitiveConversions; //Field offset: 0x0

	[Address(RVA = "0x14D7DC0", Offset = "0x14D6FC0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D77")]
	private static DefaultBinder() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D76")]
	public DefaultBinder() { }

	[Address(RVA = "0x14D17C0", Offset = "0x14D09C0", Length = "0x6F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D60")]
	public virtual FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	[Address(RVA = "0x14D1EC0", Offset = "0x14D10C0", Length = "0x26DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "UnsafeCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32[])}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultBinder), Member = "ReorderParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DefaultBinder), Member = "CreateParamOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(ParameterInfo[]), typeof(String[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 29)]
	[Token(Token = "0x6000D5F")]
	public virtual MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, String[] names, out object state) { }

	[Address(RVA = "0x14D45A0", Offset = "0x14D37A0", Length = "0xEE")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D74")]
	private static bool CanChangePrimitive(Type source, Type target) { }

	[Address(RVA = "0x14D47A0", Offset = "0x14D39A0", Length = "0xBC")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D70")]
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	[Address(RVA = "0x14D4690", Offset = "0x14D3890", Length = "0x102")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D71")]
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	[Address(RVA = "0x14D49F0", Offset = "0x14D3BF0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D75")]
	private static bool CanPrimitiveWiden(Type source, Type target) { }

	[Address(RVA = "0x14D4AC0", Offset = "0x14D3CC0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D62")]
	public virtual object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	[Address(RVA = "0x14D4B20", Offset = "0x14D3D20", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D72")]
	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	[Address(RVA = "0x14D4B20", Offset = "0x14D3D20", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6B")]
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	[Address(RVA = "0x14D4C90", Offset = "0x14D3E90", Length = "0x234")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D6F")]
	private static bool CreateParamOrder(Int32[] paramOrder, ParameterInfo[] pars, String[] names) { }

	[Address(RVA = "0x14D4ED0", Offset = "0x14D40D0", Length = "0x2C0")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000D64")]
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14D51A0", Offset = "0x14D43A0", Length = "0x2F7")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000D65")]
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14D54A0", Offset = "0x14D46A0", Length = "0x19B")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "ExactBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D6D")]
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	[Address(RVA = "0x14D5F70", Offset = "0x14D5170", Length = "0x437")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D66")]
	private static int FindMostSpecific(ParameterInfo[] p1, Int32[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[Address(RVA = "0x14D5640", Offset = "0x14D4840", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D69")]
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	[Address(RVA = "0x14D5760", Offset = "0x14D4960", Length = "0x2D4")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D68")]
	private static int FindMostSpecificMethod(MethodBase m1, Int32[] paramOrder1, Type paramArrayType1, MethodBase m2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[Address(RVA = "0x14D5A40", Offset = "0x14D4C40", Length = "0x116")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D6A")]
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	[Address(RVA = "0x14D5B60", Offset = "0x14D4D60", Length = "0x403")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000D67")]
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	[Address(RVA = "0x14D63B0", Offset = "0x14D55B0", Length = "0x68")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(FieldInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(PropertyInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D6C")]
	internal static int GetHierarchyDepth(Type t) { }

	[Address(RVA = "0x14D6420", Offset = "0x14D5620", Length = "0x385")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultBinder), Member = "ReorderParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D63")]
	public virtual void ReorderArgumentArray(ref Object[] args, object state) { }

	[Address(RVA = "0x14D67B0", Offset = "0x14D59B0", Length = "0x1A3")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "ReorderArgumentArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D6E")]
	private static void ReorderParams(Int32[] paramOrder, Object[] vars) { }

	[Address(RVA = "0x14D6960", Offset = "0x14D5B60", Length = "0x8A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanChangePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryResolveAgainstGenericMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(MethodInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000D73")]
	public virtual MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14D7210", Offset = "0x14D6410", Length = "0xBAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(PropertyInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Contract), Member = "ForAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x6000D61")]
	public virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

