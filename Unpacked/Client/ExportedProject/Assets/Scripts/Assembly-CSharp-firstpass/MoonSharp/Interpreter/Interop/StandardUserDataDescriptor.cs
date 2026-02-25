namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x200010E")]
public class StandardUserDataDescriptor : DispatchingUserDataDescriptor, IWireableDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x200010F")]
	private sealed class <>c
	{
		[Token(Token = "0x400044E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400044F")]
		public static Func<MoonSharpHideMemberAttribute, String> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x34E860", Offset = "0x34DA60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A67")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A68")]
		public <>c() { }

		[Address(RVA = "0x32E5C0", Offset = "0x32D7C0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A69")]
		internal string <FillMemberList>b__5_0(MoonSharpHideMemberAttribute a) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044D")]
	private InteropAccessMode <AccessMode>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000169")]
	public private InteropAccessMode AccessMode
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A61")]
		 get { } //Length: 4
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A62")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x349AF0", Offset = "0x348CF0", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(UserData), Member = "get_DefaultAccessMode", ReturnType = typeof(InteropAccessMode))]
	[Calls(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A63")]
	public StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, string friendlyName = null) { }

	[Address(RVA = "0x347D40", Offset = "0x346F40", Length = "0x1775")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string), typeof(IUserDataDescriptor)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GenericMethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(GenericMethodMemberDescriptor))]
	[Calls(Type = typeof(PropertyMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode)}, ReturnType = typeof(PropertyMemberDescriptor))]
	[Calls(Type = typeof(FieldMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(InteropAccessMode)}, ReturnType = typeof(FieldMemberDescriptor))]
	[Calls(Type = typeof(EventMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(InteropAccessMode)}, ReturnType = typeof(EventMemberDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002D00")]
	[Calls(Type = typeof(UserData), Member = "RegisterType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(UserData), Member = "CreateStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParameterDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(bool), typeof(object), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ParameterDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArrayMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyInfo), Member = "get_IsSpecialName", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMetaMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "IsDelegateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GenericMethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DispatchingUserDataDescriptor), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IMemberDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsSpecialName", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetConversionMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetMetaNamesFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(MethodMemberDescriptor))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 33)]
	[Token(Token = "0x6000A64")]
	private void FillMemberList() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A61")]
	public InteropAccessMode get_AccessMode() { }

	[Address(RVA = "0x3494C0", Offset = "0x3486C0", Length = "0x2F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(StandardUserDataDescriptor), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A65")]
	public override void PrepareForWiring(Table t) { }

	[Address(RVA = "0x3497C0", Offset = "0x3489C0", Length = "0x322")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A66")]
	private void Serialize(Table t, IEnumerable<KeyValuePair`2<String, IMemberDescriptor>> members) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A62")]
	private void set_AccessMode(InteropAccessMode value) { }

}

