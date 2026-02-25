namespace System.Reflection;

[Token(Token = "0x20004E3")]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	[Token(Token = "0x400138E")]
	private const int MetadataToken_ParamDef = 134217728; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001388")]
	protected ParameterAttributes AttrsImpl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001389")]
	protected Type ClassImpl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400138A")]
	protected object DefaultValueImpl; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400138B")]
	protected MemberInfo MemberImpl; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400138C")]
	protected string NameImpl; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400138D")]
	protected int PositionImpl; //Field offset: 0x38

	[Token(Token = "0x17000451")]
	public override ParameterAttributes Attributes
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000459")]
	public override object DefaultValue
	{
		[Address(RVA = "0x13C02C0", Offset = "0x13BF4C0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021FC")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000456")]
	public bool IsIn
	{
		[Address(RVA = "0x13C02F0", Offset = "0x13BF4F0", Length = "0x1E")]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60021F9")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000457")]
	public bool IsOptional
	{
		[Address(RVA = "0x13C0310", Offset = "0x13BF510", Length = "0x21")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021FA")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000458")]
	public bool IsOut
	{
		[Address(RVA = "0x13C0340", Offset = "0x13BF540", Length = "0x21")]
		[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
		[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021FB")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000452")]
	public override MemberInfo Member
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000453")]
	public override string Name
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F6")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000454")]
	public override Type ParameterType
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000455")]
	public override int Position
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F8")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F3")]
	protected ParameterInfo() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F4")]
	public override ParameterAttributes get_Attributes() { }

	[Address(RVA = "0x13C02C0", Offset = "0x13BF4C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021FC")]
	public override object get_DefaultValue() { }

	[Address(RVA = "0x13C02F0", Offset = "0x13BF4F0", Length = "0x1E")]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021F9")]
	public bool get_IsIn() { }

	[Address(RVA = "0x13C0310", Offset = "0x13BF510", Length = "0x21")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021FA")]
	public bool get_IsOptional() { }

	[Address(RVA = "0x13C0340", Offset = "0x13BF540", Length = "0x21")]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021FB")]
	public bool get_IsOut() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F5")]
	public override MemberInfo get_Member() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F6")]
	public override string get_Name() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F7")]
	public override Type get_ParameterType() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F8")]
	public override int get_Position() { }

	[Address(RVA = "0x13BFD50", Offset = "0x13BEF50", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60021FE")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13BFE00", Offset = "0x13BF000", Length = "0x3AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60021FF")]
	public override object GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x13C01B0", Offset = "0x13BF3B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60021FD")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13C0230", Offset = "0x13BF430", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "FormatTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002200")]
	public virtual string ToString() { }

}

