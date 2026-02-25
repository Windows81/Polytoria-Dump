namespace System.Reflection;

[Token(Token = "0x200050F")]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147F")]
	internal IntPtr mhandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001480")]
	private string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001481")]
	private Type reftype; //Field offset: 0x20

	[Token(Token = "0x170004F2")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x13E64D0", Offset = "0x13E56D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002426")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170004EF")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002417")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004F3")]
	public virtual CallingConventions CallingConvention
	{
		[Address(RVA = "0x13E64E0", Offset = "0x13E56E0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002427")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170004F4")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x13E6510", Offset = "0x13E5710", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002428")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170004F6")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x13E6550", Offset = "0x13E5750", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[DeduplicatedMethod]
		[Token(Token = "0x600242A")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170004F8")]
	public virtual bool IsSecurityCritical
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002431")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004F9")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002432")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004F1")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002425")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004EE")]
	public virtual Module Module
	{
		[Address(RVA = "0x13E5F40", Offset = "0x13E5140", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002415")]
		 get { } //Length: 143
	}

	[Token(Token = "0x170004F7")]
	public virtual string Name
	{
		[Address(RVA = "0x13E6590", Offset = "0x13E5790", Length = "0x10")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600242B")]
		 get { } //Length: 16
	}

	[Token(Token = "0x170004F5")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002429")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004F0")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x13E65A0", Offset = "0x13E57A0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002418")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x13E6480", Offset = "0x13E5680", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002434")]
	public RuntimeConstructorInfo() { }

	[Address(RVA = "0x13E5A40", Offset = "0x13E4C40", Length = "0x239")]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binder), typeof(Object[]), typeof(ParameterInfo[]), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002422")]
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13E64D0", Offset = "0x13E56D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002426")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002417")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x13E64E0", Offset = "0x13E56E0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002427")]
	public virtual CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x13E6510", Offset = "0x13E5710", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002428")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002430")]
	private static int get_core_clr_security_level() { }

	[Address(RVA = "0x13E6550", Offset = "0x13E5750", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x600242A")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002431")]
	public virtual bool get_IsSecurityCritical() { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002433")]
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002432")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002425")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x13E5F40", Offset = "0x13E5140", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002415")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x13E6590", Offset = "0x13E5790", Length = "0x10")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600242B")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002429")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x13E65A0", Offset = "0x13E57A0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002418")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x13E5CE0", Offset = "0x13E4EE0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x600242E")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E5C80", Offset = "0x13E4E80", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x600242D")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13E5D50", Offset = "0x13E4F50", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x600241C")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x13E5D80", Offset = "0x13E4F80", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002419")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E5F30", Offset = "0x13E5130", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[DeduplicatedMethod]
	[Token(Token = "0x600241D")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x13E5F00", Offset = "0x13E5100", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[Token(Token = "0x600241F")]
	internal virtual int GetParametersCount() { }

	[Address(RVA = "0x13E5F30", Offset = "0x13E5130", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[DeduplicatedMethod]
	[Token(Token = "0x600241E")]
	internal virtual ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x13E5F40", Offset = "0x13E5140", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002416")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x13E5FD0", Offset = "0x13E51D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210730")]
	[Token(Token = "0x6002420")]
	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[Address(RVA = "0x13E5FE0", Offset = "0x13E51E0", Length = "0xE4")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210730")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002423")]
	public object InternalInvoke(object obj, Object[] parameters, bool wrapExceptions) { }

	[Address(RVA = "0x13E6100", Offset = "0x13E5300", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002421")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13E60D0", Offset = "0x13E52D0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002424")]
	public virtual object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13E6240", Offset = "0x13E5440", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600242C")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E62B0", Offset = "0x13E54B0", Length = "0x144")]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600241B")]
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E6400", Offset = "0x13E5600", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600241A")]
	internal string SerializationToString() { }

	[Address(RVA = "0x13E6420", Offset = "0x13E5620", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600242F")]
	public virtual string ToString() { }

}

