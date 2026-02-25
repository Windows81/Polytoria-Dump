namespace System;

[Token(Token = "0x2000145")]
public abstract class Type : MemberInfo
{
	[Token(Token = "0x4000482")]
	private static Binder s_defaultBinder; //Field offset: 0x0
	[Token(Token = "0x4000483")]
	public static readonly char Delimiter; //Field offset: 0x8
	[Token(Token = "0x4000484")]
	public static readonly Type[] EmptyTypes; //Field offset: 0x10
	[Token(Token = "0x4000485")]
	public static readonly object Missing; //Field offset: 0x18
	[Token(Token = "0x4000486")]
	public static readonly MemberFilter FilterAttribute; //Field offset: 0x20
	[Token(Token = "0x4000487")]
	public static readonly MemberFilter FilterName; //Field offset: 0x28
	[Token(Token = "0x4000488")]
	public static readonly MemberFilter FilterNameIgnoreCase; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000489")]
	internal RuntimeTypeHandle _impl; //Field offset: 0x10

	[Token(Token = "0x170000C3")]
	public abstract Assembly Assembly
	{
		[Token(Token = "0x6000A7D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C1")]
	public abstract string AssemblyQualifiedName
	{
		[Token(Token = "0x6000A7B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D8")]
	public override TypeAttributes Attributes
	{
		[Address(RVA = "0x14C9CA0", Offset = "0x14C8EA0", Length = "0x14")]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
		[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A9B")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000EE")]
	public abstract Type BaseType
	{
		[Token(Token = "0x6000ADC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BD")]
	public override bool ContainsGenericParameters
	{
		[Address(RVA = "0x14C9CC0", Offset = "0x14C8EC0", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x6000A6E")]
		 get { } //Length: 357
	}

	[Token(Token = "0x170000C7")]
	public override MethodBase DeclaringMethod
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A81")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C6")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A80")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EF")]
	public static Binder DefaultBinder
	{
		[Address(RVA = "0x14C9E30", Offset = "0x14C9030", Length = "0xD3")]
		[CalledBy(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(FormatterServices), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000AEF")]
		 get { } //Length: 211
	}

	[Token(Token = "0x170000C2")]
	public abstract string FullName
	{
		[Token(Token = "0x6000A7C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000F2")]
	internal string FullNameOrDefault
	{
		[Address(RVA = "0x14C9F10", Offset = "0x14C9110", Length = "0x8B")]
		[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000AFC")]
		internal get { } //Length: 139
	}

	[Token(Token = "0x170000D7")]
	public override GenericParameterAttributes GenericParameterAttributes
	{
		[Address(RVA = "0x14C9FA0", Offset = "0x14C91A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000A99")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170000D6")]
	public override int GenericParameterPosition
	{
		[Address(RVA = "0x14C9FE0", Offset = "0x14C91E0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000A98")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000D5")]
	public override Type[] GenericTypeArguments
	{
		[Address(RVA = "0x14CA030", Offset = "0x14C9230", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000A96")]
		 get { } //Length: 134
	}

	[Token(Token = "0x170000D4")]
	public override bool HasElementType
	{
		[Address(RVA = "0x14CA0C0", Offset = "0x14C92C0", Length = "0x14")]
		[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A91")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000F3")]
	internal string InternalNameIfAvailable
	{
		[Address(RVA = "0x14CA0E0", Offset = "0x14C92E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AFF")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170000D9")]
	public override bool IsAbstract
	{
		[Address(RVA = "0x14CA110", Offset = "0x14C9310", Length = "0x24")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.JsonUtility", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessManager+<>c", Member = "<ReloadBaseTypes>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
		[CalledBy(Type = "SoftMasking.MaterialReplacer", Member = "IsMaterialReplacerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000CA")]
	public override bool IsArray
	{
		[Address(RVA = "0x14CA140", Offset = "0x14C9340", Length = "0x14")]
		[CallerCount(Count = 50)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A84")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000CB")]
	public override bool IsByRef
	{
		[Address(RVA = "0x14CA160", Offset = "0x14C9360", Length = "0x14")]
		[CallerCount(Count = 63)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A86")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000DB")]
	public override bool IsClass
	{
		[Address(RVA = "0x14CA1A0", Offset = "0x14C93A0", Length = "0x49")]
		[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.Reflection+<>c__DisplayClass14_0", Member = "<GetAssignableFromTypes>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.Reflection", Member = "IsClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A9F")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170000E7")]
	public override bool IsCollectible
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000E5")]
	public override bool IsCOMObject
	{
		[Address(RVA = "0x14CA180", Offset = "0x14C9380", Length = "0x14")]
		[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AA9")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000CD")]
	public override bool IsConstructedGenericType
	{
		[Address(RVA = "0x14CA1F0", Offset = "0x14C93F0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000A8A")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000E6")]
	public override bool IsContextful
	{
		[Address(RVA = "0x14CA220", Offset = "0x14C9420", Length = "0x14")]
		[CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AAB")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000E8")]
	public override bool IsEnum
	{
		[Address(RVA = "0x14CA240", Offset = "0x14C9440", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AAE")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170000E4")]
	public override bool IsExplicitLayout
	{
		[Address(RVA = "0x14CA2C0", Offset = "0x14C94C0", Length = "0x23")]
		[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA8")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000CF")]
	public override bool IsGenericMethodParameter
	{
		[Address(RVA = "0x14CA2F0", Offset = "0x14C94F0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000A8C")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000CE")]
	public override bool IsGenericParameter
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000D0")]
	public override bool IsGenericType
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000D1")]
	public override bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000F1")]
	public override bool IsInterface
	{
		[Address(RVA = "0x14CA340", Offset = "0x14C9540", Length = "0xC4")]
		[CallerCount(Count = 47)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AF5")]
		 get { } //Length: 196
	}

	[Token(Token = "0x170000E9")]
	public override bool IsMarshalByRef
	{
		[Address(RVA = "0x14CA410", Offset = "0x14C9610", Length = "0x14")]
		[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingSurrogateSelector), Member = "GetSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StreamingContext), typeof(ISurrogateSelector&)}, ReturnType = typeof(ISerializationSurrogate))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AAF")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000C5")]
	public bool IsNested
	{
		[Address(RVA = "0x14CA550", Offset = "0x14C9750", Length = "0x3D")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A7F")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170000DC")]
	public override bool IsNestedAssembly
	{
		[Address(RVA = "0x14CA430", Offset = "0x14C9630", Length = "0x24")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA0")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000DD")]
	public override bool IsNestedFamANDAssem
	{
		[Address(RVA = "0x14CA460", Offset = "0x14C9660", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA1")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000DE")]
	public override bool IsNestedFamily
	{
		[Address(RVA = "0x14CA4C0", Offset = "0x14C96C0", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA2")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000DF")]
	public override bool IsNestedFamORAssem
	{
		[Address(RVA = "0x14CA490", Offset = "0x14C9690", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA3")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000E0")]
	public override bool IsNestedPrivate
	{
		[Address(RVA = "0x14CA4F0", Offset = "0x14C96F0", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA4")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000E1")]
	public override bool IsNestedPublic
	{
		[Address(RVA = "0x14CA520", Offset = "0x14C9720", Length = "0x23")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "IsNestedPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA5")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000E2")]
	public override bool IsNotPublic
	{
		[Address(RVA = "0x14CA590", Offset = "0x14C9790", Length = "0x21")]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170000CC")]
	public override bool IsPointer
	{
		[Address(RVA = "0x14CA5C0", Offset = "0x14C97C0", Length = "0x14")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor+<>c", Member = "<CheckMethodIsCompatible>b__16_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
		[CalledBy(Type = "Unity.Properties.TypeTraits", Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.ConstantCheck", Member = "AnalyzeTypeIs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(Type)}, ReturnType = "System.Linq.Expressions.AnalyzeTypeIsResult")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor+<>c", Member = "<CheckMethodIsCompatible>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "IsPointerImpl", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Pointer), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
		[CalledBy(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Array+ArrayEnumerator", Member = "get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "CreateProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IMemberInfo", "Unity.Properties.Internal.ReflectedPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 19)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A88")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000EA")]
	public override bool IsPrimitive
	{
		[Address(RVA = "0x14CA5E0", Offset = "0x14C97E0", Length = "0x14")]
		[CallerCount(Count = 37)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AB1")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000E3")]
	public override bool IsPublic
	{
		[Address(RVA = "0x14CA600", Offset = "0x14C9800", Length = "0x23")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AA7")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000DA")]
	public override bool IsSealed
	{
		[Address(RVA = "0x14CA660", Offset = "0x14C9860", Length = "0x24")]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
		[CalledBy(Type = typeof(NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A9E")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000BC")]
	public override bool IsSerializable
	{
		[Address(RVA = "0x14CA690", Offset = "0x14C9890", Length = "0x171")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A6D")]
		 get { } //Length: 369
	}

	[Token(Token = "0x170000EC")]
	public override bool IsSignatureType
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000F0")]
	internal override bool IsSzArray
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF2")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000D2")]
	public override bool IsSZArray
	{
		[Address(RVA = "0x14CA630", Offset = "0x14C9830", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000A8F")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000EB")]
	public override bool IsValueType
	{
		[Address(RVA = "0x14CA810", Offset = "0x14C9A10", Length = "0x14")]
		[CallerCount(Count = 99)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AB3")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000D3")]
	public override bool IsVariableBoundArray
	{
		[Address(RVA = "0x14CA830", Offset = "0x14C9A30", Length = "0x47")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A90")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000BE")]
	public bool IsVisible
	{
		[Address(RVA = "0x14CA880", Offset = "0x14C9A80", Length = "0x1C7")]
		[CalledBy(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 9)]
		[Token(Token = "0x6000A70")]
		 get { } //Length: 455
	}

	[Token(Token = "0x170000BF")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A78")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000C4")]
	public abstract Module Module
	{
		[Token(Token = "0x6000A7E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000F4")]
	internal string NameOrDefault
	{
		[Address(RVA = "0x14CAA50", Offset = "0x14C9C50", Length = "0x60")]
		[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B00")]
		internal get { } //Length: 96
	}

	[Token(Token = "0x170000C0")]
	public abstract string Namespace
	{
		[Token(Token = "0x6000A7A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C8")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A82")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000ED")]
	public override RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x14CAAB0", Offset = "0x14C9CB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000AD8")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170000C9")]
	public abstract Type UnderlyingSystemType
	{
		[Token(Token = "0x6000A83")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x14C9AB0", Offset = "0x14C8CB0", Length = "0x1EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000B01")]
	private static Type() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A77")]
	protected Type() { }

	[Address(RVA = "0x14C5CE0", Offset = "0x14C4EE0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214020")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A6B")]
	private static int BinarySearch(Array array, object value) { }

	[Address(RVA = "0x14C5F00", Offset = "0x14C5100", Length = "0x64")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AEC")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x14C5E80", Offset = "0x14C5080", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AEE")]
	public override bool Equals(Type o) { }

	[Address(RVA = "0x14C5F70", Offset = "0x14C5170", Length = "0x374")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A74")]
	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x14C62F0", Offset = "0x14C54F0", Length = "0x1AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A76")]
	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x14C64A0", Offset = "0x14C56A0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A75")]
	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x14C6680", Offset = "0x14C5880", Length = "0x16")]
	[CalledBy(Type = typeof(ParameterInfo), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF3")]
	internal string FormatTypeName() { }

	[Address(RVA = "0x14C6640", Offset = "0x14C5840", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AF4")]
	internal override string FormatTypeName(bool serialization) { }

	[Token(Token = "0x6000A7D")]
	public abstract Assembly get_Assembly() { }

	[Token(Token = "0x6000A7B")]
	public abstract string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x14C9CA0", Offset = "0x14C8EA0", Length = "0x14")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A9B")]
	public override TypeAttributes get_Attributes() { }

	[Token(Token = "0x6000ADC")]
	public abstract Type get_BaseType() { }

	[Address(RVA = "0x14C9CC0", Offset = "0x14C8EC0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000A6E")]
	public override bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A81")]
	public override MethodBase get_DeclaringMethod() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A80")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x14C9E30", Offset = "0x14C9030", Length = "0xD3")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FormatterServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AEF")]
	public static Binder get_DefaultBinder() { }

	[Token(Token = "0x6000A7C")]
	public abstract string get_FullName() { }

	[Address(RVA = "0x14C9F10", Offset = "0x14C9110", Length = "0x8B")]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AFC")]
	internal string get_FullNameOrDefault() { }

	[Address(RVA = "0x14C9FA0", Offset = "0x14C91A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A99")]
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	[Address(RVA = "0x14C9FE0", Offset = "0x14C91E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A98")]
	public override int get_GenericParameterPosition() { }

	[Address(RVA = "0x14CA030", Offset = "0x14C9230", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A96")]
	public override Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0x14CA0C0", Offset = "0x14C92C0", Length = "0x14")]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A91")]
	public override bool get_HasElementType() { }

	[Address(RVA = "0x14CA0E0", Offset = "0x14C92E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFF")]
	internal string get_InternalNameIfAvailable() { }

	[Address(RVA = "0x14CA110", Offset = "0x14C9310", Length = "0x24")]
	[CalledBy(Type = "SoftMasking.MaterialReplacer", Member = "IsMaterialReplacerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessManager+<>c", Member = "<ReloadBaseTypes>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.JsonUtility", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A9D")]
	public override bool get_IsAbstract() { }

	[Address(RVA = "0x14CA140", Offset = "0x14C9340", Length = "0x14")]
	[CallerCount(Count = 50)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A84")]
	public override bool get_IsArray() { }

	[Address(RVA = "0x14CA160", Offset = "0x14C9360", Length = "0x14")]
	[CallerCount(Count = 63)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A86")]
	public override bool get_IsByRef() { }

	[Address(RVA = "0x14CA1A0", Offset = "0x14C93A0", Length = "0x49")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.Reflection+<>c__DisplayClass14_0", Member = "<GetAssignableFromTypes>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "IsClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A9F")]
	public override bool get_IsClass() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAD")]
	public override bool get_IsCollectible() { }

	[Address(RVA = "0x14CA180", Offset = "0x14C9380", Length = "0x14")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AA9")]
	public override bool get_IsCOMObject() { }

	[Address(RVA = "0x14CA1F0", Offset = "0x14C93F0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A8A")]
	public override bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x14CA220", Offset = "0x14C9420", Length = "0x14")]
	[CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AAB")]
	public override bool get_IsContextful() { }

	[Address(RVA = "0x14CA240", Offset = "0x14C9440", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AAE")]
	public override bool get_IsEnum() { }

	[Address(RVA = "0x14CA2C0", Offset = "0x14C94C0", Length = "0x23")]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA8")]
	public override bool get_IsExplicitLayout() { }

	[Address(RVA = "0x14CA2F0", Offset = "0x14C94F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A8C")]
	public override bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8B")]
	public override bool get_IsGenericParameter() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8D")]
	public override bool get_IsGenericType() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8E")]
	public override bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x14CA340", Offset = "0x14C9540", Length = "0xC4")]
	[CallerCount(Count = 47)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF5")]
	public override bool get_IsInterface() { }

	[Address(RVA = "0x14CA410", Offset = "0x14C9610", Length = "0x14")]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingSurrogateSelector), Member = "GetSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StreamingContext), typeof(ISurrogateSelector&)}, ReturnType = typeof(ISerializationSurrogate))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AAF")]
	public override bool get_IsMarshalByRef() { }

	[Address(RVA = "0x14CA550", Offset = "0x14C9750", Length = "0x3D")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A7F")]
	public bool get_IsNested() { }

	[Address(RVA = "0x14CA430", Offset = "0x14C9630", Length = "0x24")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA0")]
	public override bool get_IsNestedAssembly() { }

	[Address(RVA = "0x14CA460", Offset = "0x14C9660", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA1")]
	public override bool get_IsNestedFamANDAssem() { }

	[Address(RVA = "0x14CA4C0", Offset = "0x14C96C0", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA2")]
	public override bool get_IsNestedFamily() { }

	[Address(RVA = "0x14CA490", Offset = "0x14C9690", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA3")]
	public override bool get_IsNestedFamORAssem() { }

	[Address(RVA = "0x14CA4F0", Offset = "0x14C96F0", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA4")]
	public override bool get_IsNestedPrivate() { }

	[Address(RVA = "0x14CA520", Offset = "0x14C9720", Length = "0x23")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "IsNestedPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA5")]
	public override bool get_IsNestedPublic() { }

	[Address(RVA = "0x14CA590", Offset = "0x14C9790", Length = "0x21")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA6")]
	public override bool get_IsNotPublic() { }

	[Address(RVA = "0x14CA5C0", Offset = "0x14C97C0", Length = "0x14")]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "CreateProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IMemberInfo", "Unity.Properties.Internal.ReflectedPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+ArrayEnumerator", Member = "get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(Pointer), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor+<>c", Member = "<CheckMethodIsCompatible>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.ConstantCheck", Member = "AnalyzeTypeIs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(Type)}, ReturnType = "System.Linq.Expressions.AnalyzeTypeIsResult")]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeTraits", Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor+<>c", Member = "<CheckMethodIsCompatible>b__16_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "IsPointerImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A88")]
	public override bool get_IsPointer() { }

	[Address(RVA = "0x14CA5E0", Offset = "0x14C97E0", Length = "0x14")]
	[CallerCount(Count = 37)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB1")]
	public override bool get_IsPrimitive() { }

	[Address(RVA = "0x14CA600", Offset = "0x14C9800", Length = "0x23")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AA7")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x14CA660", Offset = "0x14C9860", Length = "0x24")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A9E")]
	public override bool get_IsSealed() { }

	[Address(RVA = "0x14CA690", Offset = "0x14C9890", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A6D")]
	public override bool get_IsSerializable() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB5")]
	public override bool get_IsSignatureType() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF2")]
	internal override bool get_IsSzArray() { }

	[Address(RVA = "0x14CA630", Offset = "0x14C9830", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A8F")]
	public override bool get_IsSZArray() { }

	[Address(RVA = "0x14CA810", Offset = "0x14C9A10", Length = "0x14")]
	[CallerCount(Count = 99)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB3")]
	public override bool get_IsValueType() { }

	[Address(RVA = "0x14CA830", Offset = "0x14C9A30", Length = "0x47")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A90")]
	public override bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x14CA880", Offset = "0x14C9A80", Length = "0x1C7")]
	[CalledBy(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000A70")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A78")]
	public virtual MemberTypes get_MemberType() { }

	[Token(Token = "0x6000A7E")]
	public abstract Module get_Module() { }

	[Address(RVA = "0x14CAA50", Offset = "0x14C9C50", Length = "0x60")]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B00")]
	internal string get_NameOrDefault() { }

	[Token(Token = "0x6000A7A")]
	public abstract string get_Namespace() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A82")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x14CAAB0", Offset = "0x14C9CB0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AD8")]
	public override RuntimeTypeHandle get_TypeHandle() { }

	[Token(Token = "0x6000A83")]
	public abstract Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x14C66A0", Offset = "0x14C58A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A94")]
	public override int GetArrayRank() { }

	[Token(Token = "0x6000A9C")]
	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x14C6860", Offset = "0x14C5A60", Length = "0x15E")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(RuntimeConstructorInfo))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[Token(Token = "0x6000AB8")]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C66F0", Offset = "0x14C58F0", Length = "0x167")]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[Token(Token = "0x6000AB7")]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C69C0", Offset = "0x14C5BC0", Length = "0x154")]
	[CalledBy(Type = "System.ComponentModel.GuidConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "GetObjectCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Object", typeof(MethodInfo), "UnityEngine.Events.ArgumentCache"}, ReturnType = "UnityEngine.Events.BaseInvokableCall")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[Token(Token = "0x6000AB6")]
	public override ConstructorInfo GetConstructor(Type[] types) { }

	[Token(Token = "0x6000AB9")]
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	[Token(Token = "0x6000ABA")]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000A93")]
	public abstract Type GetElementType() { }

	[Address(RVA = "0x14C6B20", Offset = "0x14C5D20", Length = "0x448")]
	[CalledBy(Type = typeof(Type), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumRawConstantValues", ReturnType = typeof(Array))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A6A")]
	private void GetEnumData(out String[] enumNames, out Array enumValues) { }

	[Address(RVA = "0x14C6F70", Offset = "0x14C6170", Length = "0x3AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214020")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A67")]
	public override string GetEnumName(object value) { }

	[Address(RVA = "0x14C7320", Offset = "0x14C6520", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A68")]
	public override String[] GetEnumNames() { }

	[Address(RVA = "0x14C73D0", Offset = "0x14C65D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A69")]
	private Array GetEnumRawConstantValues() { }

	[Address(RVA = "0x14C7400", Offset = "0x14C6600", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000AE3")]
	public override Type GetEnumUnderlyingType() { }

	[Address(RVA = "0x14C7550", Offset = "0x14C6750", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE4")]
	public override Array GetEnumValues() { }

	[Token(Token = "0x6000ABB")]
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Token(Token = "0x6000ABC")]
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000ABE")]
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C7600", Offset = "0x14C6800", Length = "0x1A")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureFormatUtilities", Member = "IsObsolete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "FieldInfo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ABD")]
	public override FieldInfo GetField(string name) { }

	[Token(Token = "0x6000ABF")]
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C7620", Offset = "0x14C6820", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A97")]
	public override Type[] GetGenericArguments() { }

	[Address(RVA = "0x14C7670", Offset = "0x14C6870", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A9A")]
	public override Type[] GetGenericParameterConstraints() { }

	[Address(RVA = "0x14C7710", Offset = "0x14C6910", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A95")]
	public override Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x14C7760", Offset = "0x14C6960", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AED")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6000ADF")]
	public abstract Type GetInterface(string name, bool ignoreCase) { }

	[Address(RVA = "0x14C77C0", Offset = "0x14C69C0", Length = "0x17")]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkCurrent", Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADE")]
	public override Type GetInterface(string name) { }

	[Token(Token = "0x6000AE0")]
	public abstract Type[] GetInterfaces() { }

	[Address(RVA = "0x14C7810", Offset = "0x14C6A10", Length = "0x1A")]
	[CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC0")]
	public override MemberInfo[] GetMember(string name) { }

	[Address(RVA = "0x14C77E0", Offset = "0x14C69E0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC1")]
	public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C7830", Offset = "0x14C6A30", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AC2")]
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Token(Token = "0x6000AC3")]
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C7D10", Offset = "0x14C6F10", Length = "0x1C7")]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetMethodImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180195F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC9")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C7EE0", Offset = "0x14C70E0", Length = "0x1B9")]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomMarshaler))]
	[CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeExtensions", Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "UnityEngine.AndroidJavaProxy", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "UnityEngine.AndroidJavaObject")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180195F90")]
	[Token(Token = "0x6000AC8")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C7880", Offset = "0x14C6A80", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180195F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC7")]
	public override MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C7B60", Offset = "0x14C6D60", Length = "0x1A7")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileInvocationExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkClrBase", Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Linq.Expressions.CachedReflectionInfo", Member = "get_String_op_Equality_String_String", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Linq.Expressions.CachedReflectionInfo", Member = "get_Math_Pow_Double_Double", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Linq.Expressions.ExpressionStringBuilder", Member = "VisitExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = "System.Linq.Expressions.Expression")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CallInstruction", Member = "GetArrayAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.CallInstruction")]
	[CalledBy(Type = "UnityEngine.UI.ReflectionMethodsCache", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180195F90")]
	[Token(Token = "0x6000AC6")]
	public override MethodInfo GetMethod(string name, Type[] types) { }

	[Address(RVA = "0x14C7AD0", Offset = "0x14C6CD0", Length = "0x90")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC5")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C7A30", Offset = "0x14C6C30", Length = "0x96")]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = "GetMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkClrBase", Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CallInstruction", Member = "GetArrayAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.CallInstruction")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC4")]
	public override MethodInfo GetMethod(string name) { }

	[Token(Token = "0x6000ACA")]
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C80A0", Offset = "0x14C72A0", Length = "0x19")]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACB")]
	public override MethodInfo[] GetMethods() { }

	[Token(Token = "0x6000ACC")]
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000ACD")]
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Token(Token = "0x6000ACE")]
	public abstract Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000AD7")]
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C80C0", Offset = "0x14C72C0", Length = "0x19")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlDocument", "Polytoria.Datamodel.Instance", "System.Xml.XmlElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD6")]
	public override PropertyInfo[] GetProperties() { }

	[Address(RVA = "0x14C83A0", Offset = "0x14C75A0", Length = "0x8D")]
	[CalledBy(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = typeof(DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.XmlNodeList", "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD0")]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x14C80E0", Offset = "0x14C72E0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180196010")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AD3")]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C81D0", Offset = "0x14C73D0", Length = "0xD7")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180196010")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AD2")]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	[Address(RVA = "0x14C84D0", Offset = "0x14C76D0", Length = "0x115")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD1")]
	public override PropertyInfo GetProperty(string name, Type returnType) { }

	[Address(RVA = "0x14C82B0", Offset = "0x14C74B0", Length = "0xEC")]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180196010")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AD4")]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C8430", Offset = "0x14C7630", Length = "0x93")]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkClrBase", Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "PropertyInfo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACF")]
	public override PropertyInfo GetProperty(string name) { }

	[Token(Token = "0x6000AD5")]
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x14C85F0", Offset = "0x14C77F0", Length = "0x5D")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A6F")]
	internal Type GetRootElementType() { }

	[Address(RVA = "0x14C8960", Offset = "0x14C7B60", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[Token(Token = "0x6000AF6")]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x14C8870", Offset = "0x14C7A70", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[Token(Token = "0x6000AF7")]
	public static Type GetType(string typeName, bool throwOnError) { }

	[Address(RVA = "0x14C89F0", Offset = "0x14C7BF0", Length = "0x7")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A79")]
	public override Type GetType() { }

	[Address(RVA = "0x14C88F0", Offset = "0x14C7AF0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[Token(Token = "0x6000AF8")]
	public static Type GetType(string typeName) { }

	[Address(RVA = "0x14C8A00", Offset = "0x14C7C00", Length = "0x2E")]
	[CalledBy(Type = typeof(ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(string), typeof(Type&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeNameParser), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000AF9")]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError) { }

	[Address(RVA = "0x14C8750", Offset = "0x14C7950", Length = "0x47")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADA")]
	public static TypeCode GetTypeCode(Type type) { }

	[Address(RVA = "0x14C8650", Offset = "0x14C7850", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000ADB")]
	protected override TypeCode GetTypeCodeImpl() { }

	[Address(RVA = "0x14C87A0", Offset = "0x14C79A0", Length = "0x38")]
	[CallerCount(Count = 3263)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Token(Token = "0x6000AF0")]
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	[Address(RVA = "0x14C87E0", Offset = "0x14C79E0", Length = "0x89")]
	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD9")]
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	[Token(Token = "0x6000A92")]
	protected abstract bool HasElementTypeImpl() { }

	[Address(RVA = "0x14C8A30", Offset = "0x14C7C30", Length = "0x11C")]
	[CalledBy(Type = typeof(Type), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A73")]
	internal bool ImplementInterface(Type ifaceType) { }

	[Address(RVA = "0x14CAAF0", Offset = "0x14C9CF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Token(Token = "0x6000AF1")]
	private static Type internal_from_handle(IntPtr handle) { }

	[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFE")]
	internal override string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	[Token(Token = "0x6000ADD")]
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Token(Token = "0x6000A85")]
	protected abstract bool IsArrayImpl() { }

	[Address(RVA = "0x14C8B50", Offset = "0x14C7D50", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000A72")]
	public override bool IsAssignableFrom(Type c) { }

	[Token(Token = "0x6000A87")]
	protected abstract bool IsByRefImpl() { }

	[Token(Token = "0x6000AAA")]
	protected abstract bool IsCOMObjectImpl() { }

	[Address(RVA = "0x14C8CE0", Offset = "0x14C7EE0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AAC")]
	protected override bool IsContextfulImpl() { }

	[Address(RVA = "0x14C8D80", Offset = "0x14C7F80", Length = "0x5A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214020")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213F80")]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A66")]
	public override bool IsEnumDefined(object value) { }

	[Address(RVA = "0x14C9330", Offset = "0x14C8530", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AE2")]
	public override bool IsEquivalentTo(Type other) { }

	[Address(RVA = "0x14C9370", Offset = "0x14C8570", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE1")]
	public override bool IsInstanceOfType(object o) { }

	[Address(RVA = "0x14C93B0", Offset = "0x14C85B0", Length = "0x282")]
	[CalledBy(Type = typeof(Type), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A6C")]
	internal static bool IsIntegerType(Type t) { }

	[Address(RVA = "0x14C9640", Offset = "0x14C8840", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB0")]
	protected override bool IsMarshalByRefImpl() { }

	[Token(Token = "0x6000A89")]
	protected abstract bool IsPointerImpl() { }

	[Token(Token = "0x6000AB2")]
	protected abstract bool IsPrimitiveImpl() { }

	[Address(RVA = "0x14C96E0", Offset = "0x14C88E0", Length = "0x8A")]
	[CalledBy(Type = typeof(Type), Member = "get_IsSerializable", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(Pointer), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AFD")]
	internal bool IsRuntimeImplemented() { }

	[Address(RVA = "0x14C9770", Offset = "0x14C8970", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[Token(Token = "0x6000A71")]
	public override bool IsSubclassOf(Type c) { }

	[Address(RVA = "0x14C9810", Offset = "0x14C8A10", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB4")]
	protected override bool IsValueTypeImpl() { }

	[Address(RVA = "0x14C98D0", Offset = "0x14C8AD0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AE6")]
	public override Type MakeArrayType(int rank) { }

	[Address(RVA = "0x14C9890", Offset = "0x14C8A90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AE5")]
	public override Type MakeArrayType() { }

	[Address(RVA = "0x14C9910", Offset = "0x14C8B10", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AE7")]
	public override Type MakeByRefType() { }

	[Address(RVA = "0x14C9950", Offset = "0x14C8B50", Length = "0x64")]
	[CalledBy(Type = typeof(RuntimeType), Member = "MakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SignatureConstructedGenericType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AEA")]
	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	[Address(RVA = "0x14C99C0", Offset = "0x14C8BC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AE8")]
	public override Type MakeGenericType(Type[] typeArguments) { }

	[Address(RVA = "0x14C9A10", Offset = "0x14C8C10", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AE9")]
	public override Type MakePointerType() { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFA")]
	public static bool op_Equality(Type left, Type right) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFB")]
	public static bool op_Inequality(Type left, Type right) { }

	[Address(RVA = "0x14C9A50", Offset = "0x14C8C50", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AEB")]
	public virtual string ToString() { }

}

