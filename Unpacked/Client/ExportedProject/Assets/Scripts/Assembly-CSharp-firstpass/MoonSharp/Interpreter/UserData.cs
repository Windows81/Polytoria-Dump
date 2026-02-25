namespace MoonSharp.Interpreter;

[Token(Token = "0x2000057")]
public class UserData : RefIdObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private sealed class <>c
	{
		[Token(Token = "0x400020F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000210")]
		public static Func<KeyValuePair`2<Type, IUserDataDescriptor>, Type> <>9__48_0; //Field offset: 0x8

		[Address(RVA = "0x3142B0", Offset = "0x3134B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005AF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B0")]
		public <>c() { }

		[Address(RVA = "0x313AE0", Offset = "0x312CE0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005B1")]
		internal Type <GetRegisteredTypes>b__48_0(KeyValuePair<Type, IUserDataDescriptor> p) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020B")]
	private DynValue <UserValue>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400020C")]
	private object <Object>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400020D")]
	private IUserDataDescriptor <Descriptor>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400020E")]
	private Table m_MetaTable; //Field offset: 0x30

	[Token(Token = "0x170000C1")]
	public static InteropAccessMode DefaultAccessMode
	{
		[Address(RVA = "0x316470", Offset = "0x315670", Length = "0x89")]
		[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60005A5")]
		 get { } //Length: 137
		[Address(RVA = "0x316590", Offset = "0x315790", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeDescriptorRegistry), Member = "set_DefaultAccessMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode)}, ReturnType = typeof(void))]
		[Token(Token = "0x60005A6")]
		 set { } //Length: 71
	}

	[Token(Token = "0x170000BE")]
	public private IUserDataDescriptor Descriptor
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600058D")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600058E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BF")]
	public Table MetaTable
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000590")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000591")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000BD")]
	public private object Object
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600058B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600058C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000C0")]
	public static IRegistrationPolicy RegistrationPolicy
	{
		[Address(RVA = "0x316500", Offset = "0x315700", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 138
		[Address(RVA = "0x3165E0", Offset = "0x3157E0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60005A4")]
		 set { } //Length: 156
	}

	[Token(Token = "0x170000BC")]
	public DynValue UserValue
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000589")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600058A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x316300", Offset = "0x315500", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InteropRegistrationPolicy), Member = "get_Default", ReturnType = typeof(IRegistrationPolicy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UserData), Member = "RegisterType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "set_DefaultAccessMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600058F")]
	private static UserData() { }

	[Address(RVA = "0x3087A0", Offset = "0x3079A0", Length = "0x4B")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000588")]
	private UserData() { }

	[Address(RVA = "0x315560", Offset = "0x314760", Length = "0x345")]
	[CalledBy(Type = typeof(IoModule), Member = "tmpfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FileUserDataBase), Member = "write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MathModule), Member = "SetRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Random)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "HandleDefaultStreamSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(StandardFileType)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "SetDefaultFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(FileUserDataBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "SetStandardFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(StandardFileType), typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynamicModule), Member = "prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EnumerableWrapper), Member = "ConvertIterator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(IEnumerator)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(DynValue), Member = "NewUserData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600059F")]
	public static DynValue Create(object o) { }

	[Address(RVA = "0x315480", Offset = "0x314680", Length = "0xD7")]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "FillMemberList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "CreateValueSigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "CreateValueUnsigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewUserData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, ReturnType = typeof(DynValue))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600059E")]
	public static DynValue Create(object o, IUserDataDescriptor descr) { }

	[Address(RVA = "0x3153A0", Offset = "0x3145A0", Length = "0xDF")]
	[CalledBy(Type = typeof(UserData), Member = "CreateStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewUserData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, ReturnType = typeof(DynValue))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005A0")]
	public static DynValue CreateStatic(IUserDataDescriptor descr) { }

	[Address(RVA = "0x315240", Offset = "0x314440", Length = "0x155")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynValue), Member = "NewUserData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, ReturnType = typeof(DynValue))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005A1")]
	public static DynValue CreateStatic(Type t) { }

	[Address(RVA = "0x7C8F80", Offset = "0x7C8180", Length = "0x85")]
	[CalledBy(Type = typeof(JsonNull), Member = "Create", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ObjectToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UserData), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(UserData), Member = "CreateStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUserDataDescriptor)}, ReturnType = typeof(DynValue))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A2")]
	public static DynValue CreateStatic() { }

	[Address(RVA = "0x316470", Offset = "0x315670", Length = "0x89")]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005A5")]
	public static InteropAccessMode get_DefaultAccessMode() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600058D")]
	public IUserDataDescriptor get_Descriptor() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000590")]
	public Table get_MetaTable() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600058B")]
	public object get_Object() { }

	[Address(RVA = "0x316500", Offset = "0x315700", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005A3")]
	public static IRegistrationPolicy get_RegistrationPolicy() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000589")]
	public DynValue get_UserValue() { }

	[Address(RVA = "0x3158B0", Offset = "0x314AB0", Length = "0x392")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "get_RegisteredTypesHistory", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Type, MoonSharp.Interpreter.Interop.IUserDataDescriptor>>))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "get_RegisteredTypes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Type, MoonSharp.Interpreter.Interop.IUserDataDescriptor>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005AD")]
	public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false) { }

	[Address(RVA = "0x315C50", Offset = "0x314E50", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AC")]
	public static IUserDataDescriptor GetDescriptorForObject(object o) { }

	[Address(RVA = "0x7C9010", Offset = "0x7C8210", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005AA")]
	public static IUserDataDescriptor GetDescriptorForType(bool searchInterfaces) { }

	[Address(RVA = "0x315CC0", Offset = "0x314EC0", Length = "0x59")]
	[CalledBy(Type = typeof(UserData), Member = "CreateStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "GetDescriptorForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(IUserDataDescriptor))]
	[Token(Token = "0x60005AB")]
	public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces) { }

	[Address(RVA = "0x315D20", Offset = "0x314F20", Length = "0x59")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[Token(Token = "0x60005A8")]
	public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType) { }

	[Address(RVA = "0x315D80", Offset = "0x314F80", Length = "0x89")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005A9")]
	public static int GetExtensionMethodsChangeVersion() { }

	[Address(RVA = "0x315E10", Offset = "0x315010", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "get_RegisteredTypesHistory", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Type, MoonSharp.Interpreter.Interop.IUserDataDescriptor>>))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "get_RegisteredTypes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Type, MoonSharp.Interpreter.Interop.IUserDataDescriptor>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Token(Token = "0x60005AE")]
	public static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = false) { }

	[Address(RVA = "0x7C90A0", Offset = "0x7C82A0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "IsTypeRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600059B")]
	public static bool IsTypeRegistered() { }

	[Address(RVA = "0x315F70", Offset = "0x315170", Length = "0x49")]
	[CalledBy(Type = typeof(StandardGenericsUserDataDescriptor), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "IsTypeRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600059A")]
	public static bool IsTypeRegistered(Type t) { }

	[Address(RVA = "0x315FC0", Offset = "0x3151C0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assembly), Member = "GetCallingAssembly", ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000599")]
	public static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false) { }

	[Address(RVA = "0x316040", Offset = "0x315240", Length = "0x57")]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExtensionMethodsRegistry), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005A7")]
	public static void RegisterExtensionType(Type type, InteropAccessMode mode = 7) { }

	[Address(RVA = "0x3160A0", Offset = "0x3152A0", Length = "0x67")]
	[CalledBy(Type = typeof(UserData), Member = "RegisterProxyType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProxy", "TTarget"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TTarget, TProxy>", typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterProxyType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IProxyFactory), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[Token(Token = "0x6000594")]
	public static IUserDataDescriptor RegisterProxyType(IProxyFactory proxyFactory, InteropAccessMode accessMode = 7, string friendlyName = null) { }

	[Address(RVA = "0x7C9120", Offset = "0x7C8320", Length = "0xBD")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 70)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "RegisterProxyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IProxyFactory), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000595")]
	public static IUserDataDescriptor RegisterProxyType(Func<TTarget, TProxy> wrapDelegate, InteropAccessMode accessMode = 7, string friendlyName = null) { }

	[Address(RVA = "0x7C91E0", Offset = "0x7C83E0", Length = "0xA0")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UserData), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000592")]
	public static IUserDataDescriptor RegisterType(InteropAccessMode accessMode = 7, string friendlyName = null) { }

	[Address(RVA = "0x316110", Offset = "0x315310", Length = "0x71")]
	[CalledBy(Type = typeof(StandardGenericsUserDataDescriptor), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IUserDataDescriptor))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[Token(Token = "0x6000593")]
	public static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = 7, string friendlyName = null) { }

	[Address(RVA = "0x316230", Offset = "0x315430", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[Token(Token = "0x6000597")]
	public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor) { }

	[Address(RVA = "0x316190", Offset = "0x315390", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000598")]
	public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor) { }

	[Address(RVA = "0x7C9280", Offset = "0x7C8480", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000596")]
	public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor) { }

	[Address(RVA = "0x316590", Offset = "0x315790", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "set_DefaultAccessMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005A6")]
	public static void set_DefaultAccessMode(InteropAccessMode value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600058E")]
	private void set_Descriptor(IUserDataDescriptor value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000591")]
	public void set_MetaTable(Table value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600058C")]
	private void set_Object(object value) { }

	[Address(RVA = "0x3165E0", Offset = "0x3157E0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005A4")]
	public static void set_RegistrationPolicy(IRegistrationPolicy value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	public void set_UserValue(DynValue value) { }

	[Address(RVA = "0x3162A0", Offset = "0x3154A0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "UnregisterType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600059D")]
	public static void UnregisterType(Type t, bool deleteHistory = false) { }

	[Address(RVA = "0x7C9320", Offset = "0x7C8520", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptorRegistry), Member = "UnregisterType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600059C")]
	public static void UnregisterType(bool deleteHistory = false) { }

}

