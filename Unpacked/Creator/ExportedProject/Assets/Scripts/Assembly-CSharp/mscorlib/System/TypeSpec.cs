namespace System;

[Token(Token = "0x20001D4")]
internal class TypeSpec
{
	[Flags]
	[Token(Token = "0x20001D5")]
	public enum DisplayNameFormat
	{
		Default = 0,
		WANT_ASSEMBLY = 1,
		NO_MODIFIERS = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000924")]
	private TypeIdentifier name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000925")]
	private string assembly_name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000926")]
	private List<TypeIdentifier> nested; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000927")]
	private List<TypeSpec> generic_params; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000928")]
	private List<ModifierSpec> modifier_spec; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000929")]
	private bool is_byref; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400092A")]
	private string display_fullname; //Field offset: 0x40

	[Token(Token = "0x1700017A")]
	internal string DisplayFullName
	{
		[Address(RVA = "0x151E180", Offset = "0x151D380", Length = "0x3E")]
		[CalledBy(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001040")]
		internal get { } //Length: 62
	}

	[Token(Token = "0x17000179")]
	internal bool HasModifiers
	{
		[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600103D")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600104A")]
	public TypeSpec() { }

	[Address(RVA = "0x151BDC0", Offset = "0x151AFC0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001045")]
	private void AddModifier(ModifierSpec md) { }

	[Address(RVA = "0x151BEC0", Offset = "0x151B0C0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001044")]
	private void AddName(string type_name) { }

	[Address(RVA = "0x151C010", Offset = "0x151B210", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001047")]
	private static void BoundCheck(int idx, string s) { }

	[Address(RVA = "0x151E180", Offset = "0x151D380", Length = "0x3E")]
	[CalledBy(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001040")]
	internal string get_DisplayFullName() { }

	[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600103D")]
	internal bool get_HasModifiers() { }

	[Address(RVA = "0x151C0A0", Offset = "0x151B2A0", Length = "0x47E")]
	[CalledBy(Type = typeof(TypeSpec), Member = "get_DisplayFullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(TypeSpec), Member = "get_DisplayFullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeSpec), Member = "GetModifierString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600103E")]
	private string GetDisplayFullName(DisplayNameFormat flags) { }

	[Address(RVA = "0x151C520", Offset = "0x151B720", Length = "0x1FE")]
	[CalledBy(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600103F")]
	private StringBuilder GetModifierString(StringBuilder sb) { }

	[Address(RVA = "0x151D5F0", Offset = "0x151C7F0", Length = "0xE8")]
	[CalledBy(Type = typeof(TypeNameParser), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeSpec), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(TypeSpec))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001041")]
	internal static TypeSpec Parse(string typeName) { }

	[Address(RVA = "0x151C720", Offset = "0x151B920", Length = "0x138")]
	[CalledBy(Type = typeof(TypeSpec), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TypeSpec))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001049")]
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	[Address(RVA = "0x151BD40", Offset = "0x151AF40", Length = "0x73")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001048")]
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	[Address(RVA = "0x151D6E0", Offset = "0x151C8E0", Length = "0x939")]
	[CalledBy(Type = typeof(TypeNameParser), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypeSpec), Member = "GetDisplayFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayNameFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019C670")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6001043")]
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x151E020", Offset = "0x151D220", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001046")]
	private static void SkipSpace(string name, ref int pos) { }

	[Address(RVA = "0x151E0A0", Offset = "0x151D2A0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001042")]
	internal static string UnescapeInternalName(string displayName) { }

}

