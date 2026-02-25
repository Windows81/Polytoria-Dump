namespace System.Reflection;

[Token(Token = "0x20004DD")]
public abstract class MethodBase : MemberInfo
{

	[Token(Token = "0x17000438")]
	public abstract MethodAttributes Attributes
	{
		[Token(Token = "0x60021B1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000439")]
	public override CallingConventions CallingConvention
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021B3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000447")]
	public override bool ContainsGenericParameters
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021C2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043A")]
	public override bool IsAbstract
	{
		[Address(RVA = "0x13BE1A0", Offset = "0x13BD3A0", Length = "0x24")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021B4")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700043F")]
	public override bool IsAssembly
	{
		[Address(RVA = "0x13BE1D0", Offset = "0x13BD3D0", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021B9")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700043B")]
	public override bool IsConstructor
	{
		[Address(RVA = "0x13BE200", Offset = "0x13BD400", Length = "0x95")]
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(CADMethodRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60021B5")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000440")]
	public override bool IsFamily
	{
		[Address(RVA = "0x13BE300", Offset = "0x13BD500", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021BA")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000441")]
	public override bool IsFamilyAndAssembly
	{
		[Address(RVA = "0x13BE2A0", Offset = "0x13BD4A0", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021BB")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000442")]
	public override bool IsFamilyOrAssembly
	{
		[Address(RVA = "0x13BE2D0", Offset = "0x13BD4D0", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021BC")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000445")]
	public override bool IsGenericMethod
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021BF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000446")]
	public override bool IsGenericMethodDefinition
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021C0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000443")]
	public override bool IsPrivate
	{
		[Address(RVA = "0x13BE330", Offset = "0x13BD530", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021BD")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000444")]
	public override bool IsPublic
	{
		[Address(RVA = "0x13BE360", Offset = "0x13BD560", Length = "0x24")]
		[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode", typeof(bool)}, ReturnType = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode", typeof(bool)}, ReturnType = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.EventMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.EventMemberDescriptor")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "IsPropertyInfoPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
		[CalledBy(Type = "MoonSharp.Interpreter.CallbackFunction", Member = "CheckCallbackSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", "System.Linq.Expressions.Expression[]", typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetGetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRaiseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetAddMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
		[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "Battlehub.Reflection", Member = "IsSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRemoveMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = "Battlehub.Reflection+<>c", Member = "<GetSerializableProperties>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 27)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021BE")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000449")]
	public override bool IsSecurityCritical
	{
		[Address(RVA = "0x13BE390", Offset = "0x13BD590", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021C6")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700043C")]
	public override bool IsSpecialName
	{
		[Address(RVA = "0x13BE3C0", Offset = "0x13BD5C0", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table"}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table"}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021B6")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700043D")]
	public override bool IsStatic
	{
		[Address(RVA = "0x13BE3F0", Offset = "0x13BD5F0", Length = "0x21")]
		[CallerCount(Count = 47)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021B7")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700043E")]
	public override bool IsVirtual
	{
		[Address(RVA = "0x13BE420", Offset = "0x13BD620", Length = "0x21")]
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021B8")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000448")]
	public abstract RuntimeMethodHandle MethodHandle
	{
		[Token(Token = "0x60021C5")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021AF")]
	protected MethodBase() { }

	[Address(RVA = "0x13BDA20", Offset = "0x13BCC20", Length = "0x1F6")]
	[CalledBy(Type = typeof(MethodBase), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021D1")]
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021C7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x13BDC20", Offset = "0x13BCE20", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(MethodBase), Member = "ConstructParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[]), typeof(CallingConventions), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60021CD")]
	internal override string FormatNameAndSig(bool serialization) { }

	[Token(Token = "0x60021B1")]
	public abstract MethodAttributes get_Attributes() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021B3")]
	public override CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021C2")]
	public override bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x13BE1A0", Offset = "0x13BD3A0", Length = "0x24")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021B4")]
	public override bool get_IsAbstract() { }

	[Address(RVA = "0x13BE1D0", Offset = "0x13BD3D0", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021B9")]
	public override bool get_IsAssembly() { }

	[Address(RVA = "0x13BE200", Offset = "0x13BD400", Length = "0x95")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADMethodRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021B5")]
	public override bool get_IsConstructor() { }

	[Address(RVA = "0x13BE300", Offset = "0x13BD500", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021BA")]
	public override bool get_IsFamily() { }

	[Address(RVA = "0x13BE2A0", Offset = "0x13BD4A0", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021BB")]
	public override bool get_IsFamilyAndAssembly() { }

	[Address(RVA = "0x13BE2D0", Offset = "0x13BD4D0", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021BC")]
	public override bool get_IsFamilyOrAssembly() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021BF")]
	public override bool get_IsGenericMethod() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021C0")]
	public override bool get_IsGenericMethodDefinition() { }

	[Address(RVA = "0x13BE330", Offset = "0x13BD530", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021BD")]
	public override bool get_IsPrivate() { }

	[Address(RVA = "0x13BE360", Offset = "0x13BD560", Length = "0x24")]
	[CalledBy(Type = "Battlehub.Reflection+<>c", Member = "<GetSerializableProperties>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRemoveMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "IsSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetAddMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetGetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRaiseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "MoonSharp.Interpreter.CallbackFunction", Member = "CheckCallbackSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "IsPropertyInfoPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.EventMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.EventMemberDescriptor")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode", typeof(bool)}, ReturnType = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode", typeof(bool)}, ReturnType = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor")]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", "System.Linq.Expressions.Expression[]", typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021BE")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x13BE390", Offset = "0x13BD590", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021C6")]
	public override bool get_IsSecurityCritical() { }

	[Address(RVA = "0x13BE3C0", Offset = "0x13BD5C0", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021B6")]
	public override bool get_IsSpecialName() { }

	[Address(RVA = "0x13BE3F0", Offset = "0x13BD5F0", Length = "0x21")]
	[CallerCount(Count = 47)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021B7")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x13BE420", Offset = "0x13BD620", Length = "0x21")]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021B8")]
	public override bool get_IsVirtual() { }

	[Token(Token = "0x60021C5")]
	public abstract RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x13BDD60", Offset = "0x13BCF60", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021C1")]
	public override Type[] GetGenericArguments() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021C8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13BDDB0", Offset = "0x13BCFB0", Length = "0x234")]
	[CalledBy(Type = typeof(RuntimeMethodHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleInternalType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021D0")]
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	[Token(Token = "0x60021B2")]
	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	[Token(Token = "0x60021B0")]
	public abstract ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x13BE130", Offset = "0x13BD330", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021CC")]
	internal override int GetParametersCount() { }

	[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021CB")]
	internal override ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021CF")]
	internal override ParameterInfo[] GetParametersNoCopy() { }

	[Address(RVA = "0x13BDFF0", Offset = "0x13BD1F0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021CE")]
	internal override Type[] GetParameterTypes() { }

	[Address(RVA = "0x13BE160", Offset = "0x13BD360", Length = "0x36")]
	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60021C3")]
	public override object Invoke(object obj, Object[] parameters) { }

	[Token(Token = "0x60021C4")]
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13BE450", Offset = "0x13BD650", Length = "0x261")]
	[CalledBy(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractFormattedStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackTrace)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(MethodCall), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021C9")]
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	[Address(RVA = "0x13BE6C0", Offset = "0x13BD8C0", Length = "0x13")]
	[CalledBy(Type = typeof(Type), Member = "get_IsGenericMethodParameter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Exception), Member = "get_Source", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(MethodCall), Member = "get_MethodSignature", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_MethodName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_MethodSignature", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_TypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60021CA")]
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

}

