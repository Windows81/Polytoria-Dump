namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x2000102")]
public class OverloadedMethodMemberDescriptor : IOptimizableDescriptor, IMemberDescriptor, IWireableDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x2000105")]
	private sealed class <>c
	{
		[Token(Token = "0x4000412")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000413")]
		public static Func<IOverloadableMemberDescriptor, Boolean> <>9__37_0; //Field offset: 0x8

		[Address(RVA = "0x34E630", Offset = "0x34D830", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60009EA")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009EB")]
		public <>c() { }

		[Address(RVA = "0x34D6D0", Offset = "0x34C8D0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009EC")]
		internal bool <get_IsStatic>b__37_0(IOverloadableMemberDescriptor o) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000106")]
	private sealed class <>c__DisplayClass33_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000414")]
		public OverloadedMethodMemberDescriptor <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000415")]
		public Script script; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000416")]
		public object obj; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009ED")]
		public <>c__DisplayClass33_0() { }

		[Address(RVA = "0x34E4B0", Offset = "0x34D6B0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009EE")]
		internal DynValue <GetCallback>b__0(ScriptExecutionContext context, CallbackArguments args) { }

	}

	[Token(Token = "0x2000103")]
	private class OverloadableMemberDescriptorComparer : IComparer<IOverloadableMemberDescriptor>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E8")]
		public OverloadableMemberDescriptorComparer() { }

		[Address(RVA = "0x33E8E0", Offset = "0x33DAE0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009E7")]
		public override int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y) { }

	}

	[Token(Token = "0x2000104")]
	private class OverloadCacheItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400040D")]
		public bool HasObject; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400040E")]
		public IOverloadableMemberDescriptor Method; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400040F")]
		public List<DataType> ArgsDataType; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000410")]
		public List<Type> ArgsUserDataType; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000411")]
		public int HitIndexAtLastHit; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E9")]
		public OverloadCacheItem() { }

	}

	[Token(Token = "0x4000403")]
	private const int CACHE_SIZE = 5; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000404")]
	private List<IOverloadableMemberDescriptor> m_Overloads; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000405")]
	private List<IOverloadableMemberDescriptor> m_ExtOverloads; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000406")]
	private bool m_Unsorted; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000407")]
	private OverloadCacheItem[] m_Cache; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000408")]
	private int m_CacheHits; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000409")]
	private int m_ExtensionMethodVersion; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400040A")]
	private bool <IgnoreExtensionMethods>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400040B")]
	private string <Name>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400040C")]
	private Type <DeclaringType>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x1700014F")]
	public private Type DeclaringType
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D6")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700014D")]
	public bool IgnoreExtensionMethods
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CE")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000151")]
	public override bool IsStatic
	{
		[Address(RVA = "0x340900", Offset = "0x33FB00", Length = "0x111")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60009E2")]
		 get { } //Length: 273
	}

	[Token(Token = "0x17000152")]
	public override MemberDescriptorAccess MemberAccess
	{
		[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014E")]
	public private override string Name
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D4")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D5")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000150")]
	public int OverloadCount
	{
		[Address(RVA = "0x340A20", Offset = "0x33FC20", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009D9")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x3407E0", Offset = "0x33F9E0", Length = "0x110")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IOverloadableMemberDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60009D0")]
	public OverloadedMethodMemberDescriptor(string name, Type declaringType) { }

	[Address(RVA = "0x340710", Offset = "0x33F910", Length = "0xCD")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMemberTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>), typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D1")]
	public OverloadedMethodMemberDescriptor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor) { }

	[Address(RVA = "0x340690", Offset = "0x33F890", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009D2")]
	public OverloadedMethodMemberDescriptor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors) { }

	[Address(RVA = "0x33E970", Offset = "0x33DB70", Length = "0xB3")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMemberTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>), typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D8")]
	public void AddOverload(IOverloadableMemberDescriptor overload) { }

	[Address(RVA = "0x33EA30", Offset = "0x33DC30", Length = "0x4A3")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60009DB")]
	private void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload) { }

	[Address(RVA = "0x33EEE0", Offset = "0x33E0E0", Length = "0x674")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CalcScoreForSingleArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterDescriptor), typeof(Type), typeof(DynValue), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B30")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CallbackArguments), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DD")]
	private int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod) { }

	[Address(RVA = "0x33F560", Offset = "0x33E760", Length = "0xB3")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CalcScoreForOverload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(IOverloadableMemberDescriptor), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfTypeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DE")]
	private static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional) { }

	[Address(RVA = "0x33F620", Offset = "0x33E820", Length = "0x1C7")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PerformOverloadedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009DC")]
	private bool CheckMatch(bool hasObject, CallbackArguments args, OverloadCacheItem overloadCacheItem) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D6")]
	public Type get_DeclaringType() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CE")]
	public bool get_IgnoreExtensionMethods() { }

	[Address(RVA = "0x340900", Offset = "0x33FB00", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009E2")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E3")]
	public override MemberDescriptorAccess get_MemberAccess() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D4")]
	public override string get_Name() { }

	[Address(RVA = "0x340A20", Offset = "0x33FC20", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009D9")]
	public int get_OverloadCount() { }

	[Address(RVA = "0x33F920", Offset = "0x33EB20", Length = "0xE0")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009DF")]
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj) { }

	[Address(RVA = "0x33F7F0", Offset = "0x33E9F0", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009E1")]
	public CallbackFunction GetCallbackFunction(Script script, object obj = null) { }

	[Address(RVA = "0x33FA10", Offset = "0x33EC10", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackFunction)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009E4")]
	public override DynValue GetValue(Script script, object obj) { }

	[Address(RVA = "0x33FB70", Offset = "0x33ED70", Length = "0x24C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009E0")]
	private override void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	[Address(RVA = "0x33FDC0", Offset = "0x33EFC0", Length = "0x4C8")]
	[CalledBy(Type = typeof(<>c__DisplayClass33_0), Member = "<GetCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CheckMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CallbackArguments), typeof(OverloadCacheItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CallbackArguments), typeof(IOverloadableMemberDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UserData), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[Calls(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CalcScoreForOverload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(IOverloadableMemberDescriptor), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009550")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UserData), Member = "GetExtensionMethodsChangeVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DA")]
	private DynValue PerformOverloadedCall(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	[Address(RVA = "0x340290", Offset = "0x33F490", Length = "0x3C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60009E6")]
	public override void PrepareForWiring(Table t) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D7")]
	private void set_DeclaringType(Type value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CF")]
	public void set_IgnoreExtensionMethods(bool value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D5")]
	private void set_Name(string value) { }

	[Address(RVA = "0x340660", Offset = "0x33F860", Length = "0x2D")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60009D3")]
	internal void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods) { }

	[Address(RVA = "0x334BA0", Offset = "0x333DA0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(MemberDescriptorAccess), typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E5")]
	public override void SetValue(Script script, object obj, DynValue value) { }

}

