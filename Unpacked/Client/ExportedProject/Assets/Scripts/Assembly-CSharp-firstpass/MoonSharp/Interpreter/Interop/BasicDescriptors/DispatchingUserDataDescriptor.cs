namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Token(Token = "0x200012F")]
public abstract class DispatchingUserDataDescriptor : IUserDataDescriptor, IOptimizableDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private sealed class <>c__DisplayClass50_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BA")]
		public DispatchingUserDataDescriptor <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BB")]
		public object obj; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B95")]
		public <>c__DisplayClass50_0() { }

		[Address(RVA = "0x371700", Offset = "0x370900", Length = "0xE4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "PerformComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B96")]
		internal DynValue <MultiDispatchLessThanOrEqual>b__0(ScriptExecutionContext context, CallbackArguments args) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000131")]
	private sealed class <>c__DisplayClass51_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BC")]
		public DispatchingUserDataDescriptor <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BD")]
		public object obj; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B97")]
		public <>c__DisplayClass51_0() { }

		[Address(RVA = "0x3717F0", Offset = "0x3709F0", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "PerformComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B98")]
		internal DynValue <MultiDispatchLessThan>b__0(ScriptExecutionContext context, CallbackArguments args) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000132")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BE")]
		public DispatchingUserDataDescriptor <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BF")]
		public object obj; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B99")]
		public <>c__DisplayClass53_0() { }

		[Address(RVA = "0x3718E0", Offset = "0x370AE0", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(DynValue), Member = "ToObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B9A")]
		internal DynValue <MultiDispatchEqual>b__0(ScriptExecutionContext context, CallbackArguments args) { }

	}

	[Token(Token = "0x40004B3")]
	protected const string SPECIALNAME_INDEXER_GET = "get_Item"; //Field offset: 0x0
	[Token(Token = "0x40004B4")]
	protected const string SPECIALNAME_INDEXER_SET = "set_Item"; //Field offset: 0x0
	[Token(Token = "0x40004B5")]
	protected const string SPECIALNAME_CAST_EXPLICIT = "op_Explicit"; //Field offset: 0x0
	[Token(Token = "0x40004B6")]
	protected const string SPECIALNAME_CAST_IMPLICIT = "op_Implicit"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B0")]
	private int m_ExtMethodsVersion; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B1")]
	private Dictionary<String, IMemberDescriptor> m_MetaMembers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B2")]
	private Dictionary<String, IMemberDescriptor> m_Members; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B7")]
	private string <Name>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B8")]
	private Type <Type>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004B9")]
	private string <FriendlyName>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700017C")]
	public private string FriendlyName
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6F")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B70")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700017D")]
	public IEnumerable<String> MemberNames
	{
		[Address(RVA = "0x356810", Offset = "0x355A10", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B75")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700017E")]
	public IEnumerable<KeyValuePair`2<String, IMemberDescriptor>> Members
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B76")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017F")]
	public IEnumerable<String> MetaMemberNames
	{
		[Address(RVA = "0x356860", Offset = "0x355A60", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B79")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000180")]
	public IEnumerable<KeyValuePair`2<String, IMemberDescriptor>> MetaMembers
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017A")]
	public private override string Name
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700017B")]
	public private override Type Type
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6D")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6E")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3566E0", Offset = "0x3558E0", Length = "0x12D")]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(String[]), typeof(Object[]), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B71")]
	protected DispatchingUserDataDescriptor(Type type, string friendlyName = null) { }

	[Address(RVA = "0x353C30", Offset = "0x352E30", Length = "0x89")]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "FillMemberList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "AddEnumMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValueMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMemberTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>), typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B73")]
	public void AddDynValue(string name, DynValue value) { }

	[Address(RVA = "0x353E40", Offset = "0x353040", Length = "0x26")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMemberTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>), typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B74")]
	public void AddMember(string name, IMemberDescriptor desc) { }

	[Address(RVA = "0x353CC0", Offset = "0x352EC0", Length = "0x178")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMetaMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IOverloadableMemberDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "AddOverload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOverloadableMemberDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B7D")]
	private void AddMemberTo(Dictionary<String, IMemberDescriptor> members, string name, IMemberDescriptor desc) { }

	[Address(RVA = "0x353E70", Offset = "0x353070", Length = "0x26")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMemberTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>), typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B72")]
	public void AddMetaMember(string name, IMemberDescriptor desc) { }

	[Address(RVA = "0x330CE0", Offset = "0x32FEE0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B88")]
	public override string AsString(object obj) { }

	[Address(RVA = "0x353EA0", Offset = "0x3530A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DescriptorHelpers), Member = "Camelify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B86")]
	protected static string Camelify(string name) { }

	[Address(RVA = "0x353EB0", Offset = "0x3530B0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B90")]
	private bool CheckEquality(object obj, object p1, object p2) { }

	[Address(RVA = "0x353F10", Offset = "0x353110", Length = "0x93")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchToBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Token(Token = "0x6000B91")]
	private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName) { }

	[Address(RVA = "0x353FB0", Offset = "0x3531B0", Length = "0x3A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackFunction)}, ReturnType = typeof(ScriptExecutionContext))]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B89")]
	protected override DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, object obj, DynValue index, DynValue value) { }

	[Address(RVA = "0x354360", Offset = "0x353560", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Token(Token = "0x6000B77")]
	public IMemberDescriptor FindMember(string memberName) { }

	[Address(RVA = "0x3543B0", Offset = "0x3535B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Token(Token = "0x6000B7B")]
	public IMemberDescriptor FindMetaMember(string memberName) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6F")]
	public string get_FriendlyName() { }

	[Address(RVA = "0x356810", Offset = "0x355A10", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B75")]
	public IEnumerable<String> get_MemberNames() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B76")]
	public IEnumerable<KeyValuePair`2<String, IMemberDescriptor>> get_Members() { }

	[Address(RVA = "0x356860", Offset = "0x355A60", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B79")]
	public IEnumerable<String> get_MetaMemberNames() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7A")]
	public IEnumerable<KeyValuePair`2<String, IMemberDescriptor>> get_MetaMembers() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6B")]
	public override string get_Name() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6D")]
	public override Type get_Type() { }

	[Address(RVA = "0x354400", Offset = "0x353600", Length = "0x53")]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "AddEnumMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B80")]
	public bool HasMember(string exactName) { }

	[Address(RVA = "0x354460", Offset = "0x353660", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B81")]
	public bool HasMetaMember(string exactName) { }

	[Address(RVA = "0x3544C0", Offset = "0x3536C0", Length = "0x44B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5C00")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "UpperFirstLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "Camelify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UserData), Member = "GetExtensionMethodsChangeVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B7E")]
	public override DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	[Address(RVA = "0x354910", Offset = "0x353B10", Length = "0xB1")]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "IsTypeCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B94")]
	public override bool IsTypeCompatible(Type type, object obj) { }

	[Address(RVA = "0x3549D0", Offset = "0x353BD0", Length = "0x99E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetGetterCallbackAsDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "EnumerationToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "DispatchMetaOnMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetConversionMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Token(Token = "0x6000B8A")]
	public override DynValue MetaIndex(Script script, object obj, string metaname) { }

	[Address(RVA = "0x355370", Offset = "0x354570", Length = "0x4D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B85")]
	private override void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	[Address(RVA = "0x355850", Offset = "0x354A50", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B8F")]
	private DynValue MultiDispatchEqual(Script script, object obj) { }

	[Address(RVA = "0x355A70", Offset = "0x354C70", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B8D")]
	private DynValue MultiDispatchLessThan(Script script, object obj) { }

	[Address(RVA = "0x355940", Offset = "0x354B40", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B8C")]
	private DynValue MultiDispatchLessThanOrEqual(Script script, object obj) { }

	[Address(RVA = "0x355BA0", Offset = "0x354DA0", Length = "0xF8")]
	[CalledBy(Type = typeof(<>c__DisplayClass50_0), Member = "<MultiDispatchLessThanOrEqual>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(<>c__DisplayClass51_0), Member = "<MultiDispatchLessThan>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B8B")]
	private int PerformComparison(object obj, object p1, object p2) { }

	[Address(RVA = "0x355CA0", Offset = "0x354EA0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B78")]
	public void RemoveMember(string memberName) { }

	[Address(RVA = "0x355D00", Offset = "0x354F00", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B7C")]
	public void RemoveMetaMember(string memberName) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B70")]
	private void set_FriendlyName(string value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6C")]
	private void set_Name(string value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6E")]
	private void set_Type(Type value) { }

	[Address(RVA = "0x355D60", Offset = "0x354F60", Length = "0x2BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5C00")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "UpperFirstLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A80")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "Camelify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B83")]
	public override bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

	[Address(RVA = "0x356020", Offset = "0x355220", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetGetterCallbackAsDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000B8E")]
	private DynValue TryDispatchLength(Script script, object obj) { }

	[Address(RVA = "0x3561C0", Offset = "0x3553C0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetConversionMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "DispatchMetaOnMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000B93")]
	private DynValue TryDispatchToBool(Script script, object obj) { }

	[Address(RVA = "0x356280", Offset = "0x355480", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetConversionMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "DispatchMetaOnMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B92")]
	private DynValue TryDispatchToNumber(Script script, object obj) { }

	[Address(RVA = "0x356500", Offset = "0x355700", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B82")]
	protected override DynValue TryIndex(Script script, object obj, string indexName) { }

	[Address(RVA = "0x356370", Offset = "0x355570", Length = "0x185")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UserData), Member = "GetExtensionMethodsChangeVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "SetExtensionMethodsSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "GetCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>))]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B7F")]
	private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName) { }

	[Address(RVA = "0x3565C0", Offset = "0x3557C0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B84")]
	protected override bool TrySetIndex(Script script, object obj, string indexName, DynValue value) { }

	[Address(RVA = "0x3566D0", Offset = "0x3558D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DescriptorHelpers), Member = "UpperFirstLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B87")]
	protected static string UpperFirstLetter(string name) { }

}

