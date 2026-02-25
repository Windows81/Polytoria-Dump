namespace System.Reflection;

[Token(Token = "0x20004F6")]
public class TypeDelegator : TypeInfo
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013CE")]
	protected Type typeImpl; //Field offset: 0x18

	[Token(Token = "0x170004A5")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x13CDEB0", Offset = "0x13CD0B0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022CF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AA")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x13CDE80", Offset = "0x13CD080", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022D4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AB")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x13CDEE0", Offset = "0x13CD0E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022D5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A8")]
	public virtual string FullName
	{
		[Address(RVA = "0x13CDF10", Offset = "0x13CD110", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022D2")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AF")]
	public virtual bool IsCollectible
	{
		[Address(RVA = "0x13CDF40", Offset = "0x13CD140", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022F0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AE")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x13CDF70", Offset = "0x13CD170", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022EF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AD")]
	public virtual bool IsGenericMethodParameter
	{
		[Address(RVA = "0x13CDFA0", Offset = "0x13CD1A0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022EB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004AC")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x13CDFD0", Offset = "0x13CD1D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022E7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A3")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13CE000", Offset = "0x13CD200", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60022CC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A4")]
	public virtual Module Module
	{
		[Address(RVA = "0x13CE030", Offset = "0x13CD230", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022CE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A7")]
	public virtual string Name
	{
		[Address(RVA = "0x13CA980", Offset = "0x13C9B80", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60022D1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A9")]
	public virtual string Namespace
	{
		[Address(RVA = "0x13CA9B0", Offset = "0x13C9BB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60022D3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A6")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x13CE060", Offset = "0x13CD260", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022D0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004B0")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x13CE090", Offset = "0x13CD290", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022F3")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x13CDDC0", Offset = "0x13CCFC0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60022CB")]
	public TypeDelegator(Type delegatingType) { }

	[Address(RVA = "0x13CDEB0", Offset = "0x13CD0B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022CF")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x13CDE80", Offset = "0x13CD080", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022D4")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x13CDEE0", Offset = "0x13CD0E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022D5")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x13CDF10", Offset = "0x13CD110", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022D2")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x13CDF40", Offset = "0x13CD140", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F0")]
	public virtual bool get_IsCollectible() { }

	[Address(RVA = "0x13CDF70", Offset = "0x13CD170", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022EF")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x13CDFA0", Offset = "0x13CD1A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022EB")]
	public virtual bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x13CDFD0", Offset = "0x13CD1D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E7")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x13CE000", Offset = "0x13CD200", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022CC")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x13CE030", Offset = "0x13CD230", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022CE")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x13CA980", Offset = "0x13C9B80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022D1")]
	public virtual string get_Name() { }

	[Address(RVA = "0x13CA9B0", Offset = "0x13C9BB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022D3")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x13CE060", Offset = "0x13CD260", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022D0")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[Address(RVA = "0x13CE090", Offset = "0x13CD290", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F3")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x13CD840", Offset = "0x13CCA40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022E6")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x13CD860", Offset = "0x13CCA60", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022D6")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x13CD890", Offset = "0x13CCA90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[Token(Token = "0x60022D7")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x3E3DD0", Offset = "0x3E2FD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022F4")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13CD8C0", Offset = "0x13CCAC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F5")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13CD8F0", Offset = "0x13CCAF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F1")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x13CD920", Offset = "0x13CCB20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022DE")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CD950", Offset = "0x13CCB50", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E1")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CD980", Offset = "0x13CCB80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022DA")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CD9B0", Offset = "0x13CCBB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022DB")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CD9E0", Offset = "0x13CCBE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022DC")]
	public virtual Type GetInterface(string name, bool ignoreCase) { }

	[Address(RVA = "0x13CDA10", Offset = "0x13CCC10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022DD")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x13CDA40", Offset = "0x13CCC40", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E4")]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDA70", Offset = "0x13CCC70", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E5")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDAA0", Offset = "0x13CCCA0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022D8")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x13CDAE0", Offset = "0x13CCCE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022D9")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDB10", Offset = "0x13CCD10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E3")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDB40", Offset = "0x13CCD40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E2")]
	public virtual Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDB70", Offset = "0x13CCD70", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022E0")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x13CDBA0", Offset = "0x13CCDA0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60022DF")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x13CDC70", Offset = "0x13CCE70", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022F2")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x13CDC90", Offset = "0x13CCE90", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022CD")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Address(RVA = "0x13CDCD0", Offset = "0x13CCED0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022E8")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x13CDCF0", Offset = "0x13CCEF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022EA")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x13CDD10", Offset = "0x13CCF10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022EE")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x13CDD30", Offset = "0x13CCF30", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F6")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13CDD60", Offset = "0x13CCF60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022EC")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x13CDD80", Offset = "0x13CCF80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022E9")]
	protected virtual bool IsPrimitiveImpl() { }

	[Address(RVA = "0x13CDDA0", Offset = "0x13CCFA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022ED")]
	protected virtual bool IsValueTypeImpl() { }

}

