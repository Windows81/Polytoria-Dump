namespace System;

[Token(Token = "0x200018E")]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000190")]
	private struct ListBuilder
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000602")]
		private T[] _items; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000603")]
		private T _item; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000604")]
		private int _count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000605")]
		private int _capacity; //Field offset: 0x0

		[Token(Token = "0x17000142")]
		public int Count
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E86")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000141")]
		public T Item
		{
			[Address(RVA = "0xCF41C0", Offset = "0xCF33C0", Length = "0x2E")]
			[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
			[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
			[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E83")]
			 get { } //Length: 46
		}

		[Address(RVA = "0xCF4180", Offset = "0xCF3380", Length = "0x34")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<ConstructorInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<PropertyInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<EventInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<FieldInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E82")]
		public ListBuilder`1(int capacity) { }

		[Address(RVA = "0xCF3E30", Offset = "0xCF3030", Length = "0x129")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<ConstructorInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<PropertyInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<EventInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<FieldInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E87")]
		public void Add(T item) { }

		[Address(RVA = "0xCF3F60", Offset = "0xCF3160", Length = "0xB3")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E85")]
		public void CopyTo(Object[] array, int index) { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E86")]
		public int get_Count() { }

		[Address(RVA = "0xCF41C0", Offset = "0xCF33C0", Length = "0x2E")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E83")]
		public T get_Item(int index) { }

		[Address(RVA = "0xCF4020", Offset = "0xCF3220", Length = "0x157")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MethodInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(ConstructorInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(EventInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(FieldInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(Type[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E84")]
		public T[] ToArray() { }

	}

	[Token(Token = "0x200018F")]
	public enum MemberListType
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3,
	}

	[Token(Token = "0x40005E8")]
	internal static readonly RuntimeType ValueType; //Field offset: 0x0
	[Token(Token = "0x40005F7")]
	private const BindingFlags ClassicBindingMask = 61696; //Field offset: 0x0
	[Token(Token = "0x40005F6")]
	private const BindingFlags BinderNonFieldGetSet = 16773888; //Field offset: 0x0
	[Token(Token = "0x40005F5")]
	private const BindingFlags BinderSetInvokeField = 2304; //Field offset: 0x0
	[Token(Token = "0x40005F4")]
	private const BindingFlags BinderGetSetField = 3072; //Field offset: 0x0
	[Token(Token = "0x40005F3")]
	private const BindingFlags BinderSetInvokeProperty = 8448; //Field offset: 0x0
	[Token(Token = "0x40005F1")]
	private const BindingFlags BinderNonCreateInstance = 15616; //Field offset: 0x0
	[Token(Token = "0x40005F0")]
	private const BindingFlags InvocationMask = 65280; //Field offset: 0x0
	[Token(Token = "0x40005F2")]
	private const BindingFlags BinderGetSetProperty = 12288; //Field offset: 0x0
	[Token(Token = "0x40005EF")]
	private const BindingFlags MemberBindingMask = 255; //Field offset: 0x0
	[Token(Token = "0x40005FC")]
	private const int GenericParameterCountAny = -1; //Field offset: 0x0
	[Token(Token = "0x40005E9")]
	internal static readonly RuntimeType EnumType; //Field offset: 0x8
	[Token(Token = "0x40005EA")]
	private static readonly RuntimeType ObjectType; //Field offset: 0x10
	[Token(Token = "0x40005EB")]
	private static readonly RuntimeType StringType; //Field offset: 0x18
	[Token(Token = "0x40005EC")]
	private static readonly RuntimeType DelegateType; //Field offset: 0x20
	[Token(Token = "0x40005ED")]
	private static Type[] s_SICtorParamTypes; //Field offset: 0x28
	[Token(Token = "0x40005EE")]
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; //Field offset: 0x30
	[Token(Token = "0x40005F8")]
	private static RuntimeType s_typedRef; //Field offset: 0x38
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005F9")]
	private MonoTypeInfo type_info; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005FA")]
	internal object GenericCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005FB")]
	private RuntimeConstructorInfo m_serializationCtor; //Field offset: 0x28

	[Token(Token = "0x1700012A")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x14E7DA0", Offset = "0x14E6FA0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E16")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700013B")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x14EC390", Offset = "0x14EB590", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
		[Token(Token = "0x6000E76")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700012C")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x14EC3A0", Offset = "0x14EB5A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
		[Token(Token = "0x6000E1C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000139")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x14EC3B0", Offset = "0x14EB5B0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000E5B")]
		 get { } //Length: 281
	}

	[Token(Token = "0x1700013A")]
	public virtual MethodBase DeclaringMethod
	{
		[Address(RVA = "0x14EC4D0", Offset = "0x14EB6D0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C8E0")]
		[Token(Token = "0x6000E6A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013C")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x14EC4E0", Offset = "0x14EB6E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C910")]
		[Token(Token = "0x6000E77")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013F")]
	public virtual string FullName
	{
		[Address(RVA = "0x14EC4F0", Offset = "0x14EB6F0", Length = "0x107")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000E7B")]
		 get { } //Length: 263
	}

	[Token(Token = "0x1700012F")]
	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		[Address(RVA = "0x14EC600", Offset = "0x14EB800", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E28")]
		 get { } //Length: 190
	}

	[Token(Token = "0x17000133")]
	public virtual int GenericParameterPosition
	{
		[Address(RVA = "0x14EC6C0", Offset = "0x14EB8C0", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B0C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E37")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000135")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x14EC750", Offset = "0x14EB950", Length = "0x47")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700012E")]
	public virtual bool IsEnum
	{
		[Address(RVA = "0x14EC7A0", Offset = "0x14EB9A0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E26")]
		 get { } //Length: 98
	}

	[Token(Token = "0x17000132")]
	public virtual bool IsGenericParameter
	{
		[Address(RVA = "0x14EC810", Offset = "0x14EBA10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000E36")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000134")]
	public virtual bool IsGenericType
	{
		[Address(RVA = "0x14EC830", Offset = "0x14EBA30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000E39")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000131")]
	public virtual bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x14EC820", Offset = "0x14EBA20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericTypeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000E35")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000130")]
	internal virtual bool IsSzArray
	{
		[Address(RVA = "0x14EC8A0", Offset = "0x14EBAA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSzArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000E29")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000140")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x14EC840", Offset = "0x14EBA40", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E7C")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000136")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x14EC8B0", Offset = "0x14EBAB0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
		[Token(Token = "0x6000E45")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000138")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x14EC8F0", Offset = "0x14EBAF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E47")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000129")]
	public virtual Module Module
	{
		[Address(RVA = "0x14E7DB0", Offset = "0x14E6FB0", Length = "0x7")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E14")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700013D")]
	public virtual string Name
	{
		[Address(RVA = "0x14EC900", Offset = "0x14EBB00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C940")]
		[Token(Token = "0x6000E78")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013E")]
	public virtual string Namespace
	{
		[Address(RVA = "0x14EC910", Offset = "0x14EBB10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CA00")]
		[Token(Token = "0x6000E79")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000137")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E46")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700012B")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x14EC940", Offset = "0x14EBB40", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000E18")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700012D")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1E")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x14EBE40", Offset = "0x14EB040", Length = "0x4E4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E81")]
	private static RuntimeType() { }

	[Address(RVA = "0x14EC330", Offset = "0x14EB530", Length = "0x45")]
	[CalledBy(Type = typeof(ReflectionOnlyType), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DFF")]
	internal RuntimeType() { }

	[Address(RVA = "0x14E00F0", Offset = "0x14DF2F0", Length = "0x1F0")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binder), typeof(Object[]), typeof(ParameterInfo[]), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E50")]
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3F")]
	public override object Clone() { }

	[Address(RVA = "0x14E02F0", Offset = "0x14DF4F0", Length = "0x292")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E48")]
	private void CreateInstanceCheckThis() { }

	[Address(RVA = "0x14E0590", Offset = "0x14DF790", Length = "0x11C")]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000E4A")]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x14E06B0", Offset = "0x14DF8B0", Length = "0x13E")]
	[CalledBy(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(RuntimeConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C090")]
	[Token(Token = "0x6000E5D")]
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	[Address(RVA = "0x14E07F0", Offset = "0x14DF9F0", Length = "0x852")]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(List`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000E49")]
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x14E1050", Offset = "0x14E0250", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A440")]
	[Token(Token = "0x6000E69")]
	private static object CreateInstanceInternal(Type type) { }

	[Address(RVA = "0x14E1060", Offset = "0x14E0260", Length = "0x2DD")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A440")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(RuntimeConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000E4F")]
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	[Address(RVA = "0x14E1340", Offset = "0x14E0540", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000E4E")]
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	[Address(RVA = "0x14E1390", Offset = "0x14E0590", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E3C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14E13A0", Offset = "0x14E05A0", Length = "0x208")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DFA")]
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	[Address(RVA = "0x14E15B0", Offset = "0x14E07B0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DFD")]
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x14E1660", Offset = "0x14E0860", Length = "0x26B")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeConstructorInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOptional", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DFE")]
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x14E18D0", Offset = "0x14E0AD0", Length = "0xA6")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DFC")]
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x14E1980", Offset = "0x14E0B80", Length = "0x7E")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DF9")]
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	[Address(RVA = "0x14E1A00", Offset = "0x14E0C00", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DFB")]
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	[Address(RVA = "0x14E1B20", Offset = "0x14E0D20", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DF8")]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) { }

	[Address(RVA = "0x14E1C30", Offset = "0x14E0E30", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DF7")]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) { }

	[Address(RVA = "0x14E1D80", Offset = "0x14E0F80", Length = "0x3D")]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000DF6")]
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	[Address(RVA = "0x14E1DC0", Offset = "0x14E0FC0", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsNested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000E44")]
	internal virtual string FormatTypeName(bool serialization) { }

	[Address(RVA = "0x14E7DA0", Offset = "0x14E6FA0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E16")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x14EC390", Offset = "0x14EB590", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
	[Token(Token = "0x6000E76")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x14EC3A0", Offset = "0x14EB5A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[Token(Token = "0x6000E1C")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x14EC3B0", Offset = "0x14EB5B0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000E5B")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x14EC4D0", Offset = "0x14EB6D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C8E0")]
	[Token(Token = "0x6000E6A")]
	public virtual MethodBase get_DeclaringMethod() { }

	[Address(RVA = "0x14EC4E0", Offset = "0x14EB6E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C910")]
	[Token(Token = "0x6000E77")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x14EC4F0", Offset = "0x14EB6F0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000E7B")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x14EC600", Offset = "0x14EB800", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E28")]
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	[Address(RVA = "0x14EC6C0", Offset = "0x14EB8C0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B0C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E37")]
	public virtual int get_GenericParameterPosition() { }

	[Address(RVA = "0x14EC750", Offset = "0x14EB950", Length = "0x47")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E3A")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x14EC7A0", Offset = "0x14EB9A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E26")]
	public virtual bool get_IsEnum() { }

	[Address(RVA = "0x14EC810", Offset = "0x14EBA10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E36")]
	public virtual bool get_IsGenericParameter() { }

	[Address(RVA = "0x14EC830", Offset = "0x14EBA30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E39")]
	public virtual bool get_IsGenericType() { }

	[Address(RVA = "0x14EC820", Offset = "0x14EBA20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericTypeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E35")]
	public virtual bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x14EC8A0", Offset = "0x14EBAA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSzArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E29")]
	internal virtual bool get_IsSzArray() { }

	[Address(RVA = "0x14EC840", Offset = "0x14EBA40", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E7C")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x14EC8B0", Offset = "0x14EBAB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
	[Token(Token = "0x6000E45")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x14EC8F0", Offset = "0x14EBAF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E47")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x14E7DB0", Offset = "0x14E6FB0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E14")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x14EC900", Offset = "0x14EBB00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C940")]
	[Token(Token = "0x6000E78")]
	public virtual string get_Name() { }

	[Address(RVA = "0x14EC910", Offset = "0x14EBB10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CA00")]
	[Token(Token = "0x6000E79")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E46")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x14EC940", Offset = "0x14EBB40", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E18")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1E")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x14E1F40", Offset = "0x14E1140", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetArrayRank", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E2B")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x14E1FD0", Offset = "0x14E11D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(TypeAttributes))]
	[Token(Token = "0x6000E1F")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x14E1FE0", Offset = "0x14E11E0", Length = "0x20B")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_BaseType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsEnum", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetBaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000E1D")]
	private RuntimeType GetBaseType() { }

	[Address(RVA = "0x14E21F0", Offset = "0x14E13F0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E53")]
	private string GetCachedName(TypeNameKind kind) { }

	[Address(RVA = "0x14E2260", Offset = "0x14E1460", Length = "0x3C1")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(ConstructorInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructors_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E01")]
	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E2630", Offset = "0x14E1830", Length = "0x294")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DefaultBinder), Member = "ExactBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E0D")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14E2B00", Offset = "0x14E1D00", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[ComVisible(True)]
	[Token(Token = "0x6000E07")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E28D0", Offset = "0x14E1AD0", Length = "0x226")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A710")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000E63")]
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	[Address(RVA = "0x14E2BA0", Offset = "0x14E1DA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A710")]
	[Token(Token = "0x6000E62")]
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E2C50", Offset = "0x14E1E50", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E42")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x14E2BB0", Offset = "0x14E1DB0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6000E41")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x14E2DF0", Offset = "0x14E1FF0", Length = "0x1AD")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000E4B")]
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	[Address(RVA = "0x14E2FA0", Offset = "0x14E21A0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E4C")]
	private string GetDefaultMemberName() { }

	[Address(RVA = "0x14E3090", Offset = "0x14E2290", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[Token(Token = "0x6000E2C")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x14E30A0", Offset = "0x14E22A0", Length = "0x22F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E31")]
	public virtual string GetEnumName(object value) { }

	[Address(RVA = "0x14E32D0", Offset = "0x14E24D0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E2D")]
	public virtual String[] GetEnumNames() { }

	[Address(RVA = "0x14E3400", Offset = "0x14E2600", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E2F")]
	public virtual Type GetEnumUnderlyingType() { }

	[Address(RVA = "0x14E34B0", Offset = "0x14E26B0", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ulong)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E2E")]
	public virtual Array GetEnumValues() { }

	[Address(RVA = "0x14E38F0", Offset = "0x14E2AF0", Length = "0x275")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000E0F")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E3640", Offset = "0x14E2840", Length = "0x2AF")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(EventInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000E03")]
	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E3D80", Offset = "0x14E2F80", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Token(Token = "0x6000E09")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E3B70", Offset = "0x14E2D70", Length = "0x202")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(EventInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021AB90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventInfo), Member = "GetEventFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(EventInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000E72")]
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x14E3E10", Offset = "0x14E3010", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021AB90")]
	[Token(Token = "0x6000E6F")]
	private IntPtr GetEvents_native(IntPtr name, MemberListType listType) { }

	[Address(RVA = "0x14E40D0", Offset = "0x14E32D0", Length = "0x477")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000E10")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E3E20", Offset = "0x14E3020", Length = "0x2AF")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(FieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000E04")]
	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E47F0", Offset = "0x14E39F0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Token(Token = "0x6000E0A")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E4550", Offset = "0x14E3750", Length = "0x291")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021AE00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeFieldHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(FieldInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000E71")]
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x14E4880", Offset = "0x14E3A80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021AE00")]
	[Token(Token = "0x6000E70")]
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x14EC380", Offset = "0x14EB580", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
	[Token(Token = "0x6000E6B")]
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	[Address(RVA = "0x14E4910", Offset = "0x14E3B10", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B070")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E33")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x14E4890", Offset = "0x14E3A90", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E32")]
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	[Address(RVA = "0x14E4900", Offset = "0x14E3B00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B070")]
	[Token(Token = "0x6000E6C")]
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	[Address(RVA = "0x14E4960", Offset = "0x14E3B60", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E6D")]
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	[Address(RVA = "0x14E49A0", Offset = "0x14E3BA0", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Constraints", ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E5C")]
	public virtual Type[] GetGenericParameterConstraints() { }

	[Address(RVA = "0x14E4AB0", Offset = "0x14E3CB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B0C0")]
	[Token(Token = "0x6000E6E")]
	private int GetGenericParameterPosition() { }

	[Address(RVA = "0x14E4AC0", Offset = "0x14E3CC0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E38")]
	public virtual Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x14E4B50", Offset = "0x14E3D50", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000E7A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14E4C10", Offset = "0x14E3E10", Length = "0x578")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000E11")]
	public virtual Type GetInterface(string fullname, bool ignoreCase) { }

	[Address(RVA = "0x14E5190", Offset = "0x14E4390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B190")]
	[Token(Token = "0x6000E73")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x14E51A0", Offset = "0x14E43A0", Length = "0x497")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ListBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E13")]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E5640", Offset = "0x14E4840", Length = "0x310")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ListBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E0C")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E5950", Offset = "0x14E4B50", Length = "0x2F9")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E80")]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E5C50", Offset = "0x14E4E50", Length = "0x339")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E00")]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E6420", Offset = "0x14E5620", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Token(Token = "0x6000E7E")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14E5F90", Offset = "0x14E5190", Length = "0x481")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000E7F")]
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14E6720", Offset = "0x14E5920", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Token(Token = "0x6000E06")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E6470", Offset = "0x14E5670", Length = "0x291")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000E60")]
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x14E6710", Offset = "0x14E5910", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B430")]
	[Token(Token = "0x6000E5F")]
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x14E6BE0", Offset = "0x14E5DE0", Length = "0x459")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E12")]
	public virtual Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E67D0", Offset = "0x14E59D0", Length = "0x402")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(Type[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E05")]
	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E7380", Offset = "0x14E6580", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Token(Token = "0x6000E0B")]
	public virtual Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E7040", Offset = "0x14E6240", Length = "0x336")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B6E0")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E75")]
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x14E7410", Offset = "0x14E6610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B6E0")]
	[Token(Token = "0x6000E74")]
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x14E7420", Offset = "0x14E6620", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E40")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14E7740", Offset = "0x14E6940", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Token(Token = "0x6000E08")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14E7490", Offset = "0x14E6690", Length = "0x291")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimePropertyInfo), Member = "GetPropertyFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B920")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000E64")]
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x14E7730", Offset = "0x14E6930", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B920")]
	[Token(Token = "0x6000E61")]
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x14E77D0", Offset = "0x14E69D0", Length = "0x2ED")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E02")]
	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x14E7AC0", Offset = "0x14E6CC0", Length = "0x2D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E0E")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14E7DA0", Offset = "0x14E6FA0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E17")]
	internal RuntimeAssembly GetRuntimeAssembly() { }

	[Address(RVA = "0x14E7DB0", Offset = "0x14E6FB0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E15")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x14E7DC0", Offset = "0x14E6FC0", Length = "0x247")]
	[CalledBy(Type = typeof(ObjectManager), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E4D")]
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	[Address(RVA = "0x14E8070", Offset = "0x14E7270", Length = "0x7D")]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DF2")]
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x14E8020", Offset = "0x14E7220", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BBC0")]
	[Token(Token = "0x6000E65")]
	protected virtual TypeCode GetTypeCodeImpl() { }

	[Address(RVA = "0x14E8010", Offset = "0x14E7210", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BBC0")]
	[Token(Token = "0x6000E66")]
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	[Address(RVA = "0x14E80F0", Offset = "0x14E72F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E27")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x14E8100", Offset = "0x14E7300", Length = "0x1682")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801897D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000E3B")]
	public virtual object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, Object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParams) { }

	[Address(RVA = "0x14E9790", Offset = "0x14E8990", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E2A")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x14E97A0", Offset = "0x14E89A0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "CanCastTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E1A")]
	public virtual bool IsAssignableFrom(Type c) { }

	[Address(RVA = "0x14E9880", Offset = "0x14E8A80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E21")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x14E9890", Offset = "0x14E8A90", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsComObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E24")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x14E98A0", Offset = "0x14E8AA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsContextful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E20")]
	protected virtual bool IsContextfulImpl() { }

	[Address(RVA = "0x14E98B0", Offset = "0x14E8AB0", Length = "0x598")]
	[CalledBy(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000E52")]
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	[Address(RVA = "0x14EA4E0", Offset = "0x14E96E0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E43")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x14EA680", Offset = "0x14E9880", Length = "0x5FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Enum), Member = "InternalGetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E30")]
	public virtual bool IsEnumDefined(object value) { }

	[Address(RVA = "0x14EAC80", Offset = "0x14E9E80", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E1B")]
	public virtual bool IsEquivalentTo(Type other) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E68")]
	private bool IsGenericCOMObjectImpl() { }

	[Address(RVA = "0x14EAD30", Offset = "0x14E9F30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInstanceOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E19")]
	public virtual bool IsInstanceOfType(object o) { }

	[Address(RVA = "0x14EAD40", Offset = "0x14E9F40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E23")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x14EAD50", Offset = "0x14E9F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E22")]
	protected virtual bool IsPrimitiveImpl() { }

	[Address(RVA = "0x14EAD60", Offset = "0x14E9F60", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSubclassOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ComVisible(True)]
	[Token(Token = "0x6000E7D")]
	public virtual bool IsSubclassOf(Type type) { }

	[Address(RVA = "0x14EAE60", Offset = "0x14EA060", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E25")]
	protected virtual bool IsValueTypeImpl() { }

	[Address(RVA = "0x14EC970", Offset = "0x14EBB70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CE70")]
	[Token(Token = "0x6000E54")]
	private Type make_array_type(int rank) { }

	[Address(RVA = "0x14EC980", Offset = "0x14EBB80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CED0")]
	[Token(Token = "0x6000E57")]
	private Type make_byref_type() { }

	[Address(RVA = "0x14EAF40", Offset = "0x14EA140", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CE70")]
	[Token(Token = "0x6000E55")]
	public virtual Type MakeArrayType() { }

	[Address(RVA = "0x14EAF50", Offset = "0x14EA150", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CE70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E56")]
	public virtual Type MakeArrayType(int rank) { }

	[Address(RVA = "0x14EAFB0", Offset = "0x14EA1B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CED0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E58")]
	public virtual Type MakeByRefType() { }

	[Address(RVA = "0x14EB020", Offset = "0x14EA220", Length = "0x5EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C090")]
	[Calls(Type = typeof(RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType[]), typeof(RuntimeType[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B070")]
	[Calls(Type = typeof(Type), Member = "MakeGenericSignatureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000E34")]
	public virtual Type MakeGenericType(Type[] instantiation) { }

	[Address(RVA = "0x14EB610", Offset = "0x14EA810", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C090")]
	[Token(Token = "0x6000E5E")]
	private static Type MakeGenericType(Type gt, Type[] types) { }

	[Address(RVA = "0x14EB630", Offset = "0x14EA830", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C190")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E5A")]
	public virtual Type MakePointerType() { }

	[Address(RVA = "0x14EB620", Offset = "0x14EA820", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C190")]
	[Token(Token = "0x6000E59")]
	private static Type MakePointerType(Type type) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3D")]
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3E")]
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	[Address(RVA = "0x14EB710", Offset = "0x14EA910", Length = "0x254")]
	[CalledBy(Type = typeof(RuntimeType), Member = "MakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DF4")]
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	[Address(RVA = "0x14EB970", Offset = "0x14EAB70", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DF5")]
	private static void SplitName(string fullname, out string name, out string ns) { }

	[Address(RVA = "0x14EBA80", Offset = "0x14EAC80", Length = "0x130")]
	[CalledBy(Type = typeof(RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType[]), typeof(RuntimeType[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF3")]
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	[Address(RVA = "0x14EBBC0", Offset = "0x14EADC0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C810")]
	[Token(Token = "0x6000E67")]
	public virtual string ToString() { }

	[Address(RVA = "0x14EBBD0", Offset = "0x14EADD0", Length = "0x268")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "IsConvertibleToPrimitiveType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000E51")]
	private object TryConvertToType(object value, ref bool failed) { }

}

