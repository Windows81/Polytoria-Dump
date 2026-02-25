namespace System.Reflection;

[Token(Token = "0x2000514")]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable
{
	[Token(Token = "0x2000516")]
	private sealed class Getter : MulticastDelegate
	{

		[Address(RVA = "0xC583B0", Offset = "0xC575B0", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002470")]
		public Getter`2(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002471")]
		public override R Invoke(T _this) { }

	}

	[Token(Token = "0x2000515")]
	private sealed class GetterAdapter : MulticastDelegate
	{

		[Address(RVA = "0xC31020", Offset = "0xC30220", Length = "0x124")]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600246E")]
		public GetterAdapter(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246F")]
		public override object Invoke(object _this) { }

	}

	[Token(Token = "0x2000517")]
	private sealed class StaticGetter : MulticastDelegate
	{

		[Address(RVA = "0xC43530", Offset = "0xC42730", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002472")]
		public StaticGetter`1(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002473")]
		public override R Invoke() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001497")]
	internal IntPtr klass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001498")]
	internal IntPtr prop; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001499")]
	private MonoPropertyInfo info; //Field offset: 0x20
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400149A")]
	private PInfo cached; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400149B")]
	private GetterAdapter cached_getter; //Field offset: 0x58

	[Token(Token = "0x17000501")]
	public virtual PropertyAttributes Attributes
	{
		[Address(RVA = "0x13EC9F0", Offset = "0x13EBBF0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[Token(Token = "0x6002457")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170004FE")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600244D")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000502")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x13ECA30", Offset = "0x13EBC30", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002458")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000503")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x13ECA70", Offset = "0x13EBC70", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002459")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000506")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x13ECAB0", Offset = "0x13EBCB0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[Token(Token = "0x600245C")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000508")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002469")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004FF")]
	public virtual Module Module
	{
		[Address(RVA = "0x13EC430", Offset = "0x13EB630", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600244E")]
		 get { } //Length: 137
	}

	[Token(Token = "0x17000507")]
	public virtual string Name
	{
		[Address(RVA = "0x13ECAF0", Offset = "0x13EBCF0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[Token(Token = "0x600245D")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000504")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x13ECB30", Offset = "0x13EBD30", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600245A")]
		 get { } //Length: 181
	}

	[Token(Token = "0x17000505")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x13ECC70", Offset = "0x13EBE70", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
		[Token(Token = "0x600245B")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000500")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x13ECBF0", Offset = "0x13EBDF0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002450")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246D")]
	public RuntimePropertyInfo() { }

	[Address(RVA = "0x13EB980", Offset = "0x13EAB80", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x6002456")]
	private void CachePropertyInfo(PInfo flags) { }

	[Address(RVA = "0x13EB9C0", Offset = "0x13EABC0", Length = "0x2E0")]
	[CalledBy(Type = typeof(MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "SerializationToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6002453")]
	private string FormatNameAndSig(bool serialization) { }

	[Address(RVA = "0x13EC9F0", Offset = "0x13EBBF0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x6002457")]
	public virtual PropertyAttributes get_Attributes() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600244D")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x13ECA30", Offset = "0x13EBC30", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002458")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x13ECA70", Offset = "0x13EBC70", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002459")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x13ECAB0", Offset = "0x13EBCB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x600245C")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600246A")]
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002469")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x13EC430", Offset = "0x13EB630", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600244E")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x13ECAF0", Offset = "0x13EBCF0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x600245D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x13ECCB0", Offset = "0x13EBEB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x600244C")]
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	[Address(RVA = "0x13ECB30", Offset = "0x13EBD30", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600245A")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x13ECC70", Offset = "0x13EBE70", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Token(Token = "0x600245B")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x13ECBF0", Offset = "0x13EBDF0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002450")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x13EBD00", Offset = "0x13EAF00", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6002463")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13EBCB0", Offset = "0x13EAEB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6002462")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13EBD60", Offset = "0x13EAF60", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600244F")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x13EBDE0", Offset = "0x13EAFE0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600245E")]
	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	[Address(RVA = "0x13EBE60", Offset = "0x13EB060", Length = "0x396")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600245F")]
	public virtual ParameterInfo[] GetIndexParameters() { }

	[Address(RVA = "0x13EC200", Offset = "0x13EB400", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002454")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13EC370", Offset = "0x13EB570", Length = "0xBE")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600246C")]
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x13EC430", Offset = "0x13EB630", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002451")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x13EC4C0", Offset = "0x13EB6C0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210840")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002460")]
	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	[Address(RVA = "0x758140", Offset = "0x757340", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002464")]
	private static object GetterAdapterFrame(Getter<T, R> getter, object obj) { }

	[Address(RVA = "0x13C1240", Offset = "0x13C0440", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002466")]
	public virtual object GetValue(object obj, Object[] index) { }

	[Address(RVA = "0x13EC540", Offset = "0x13EB740", Length = "0x1D5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801897D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002467")]
	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x13ECCC0", Offset = "0x13EBEC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210940")]
	[Token(Token = "0x600246B")]
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	[Address(RVA = "0x13EC720", Offset = "0x13EB920", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002461")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13EC780", Offset = "0x13EB980", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002455")]
	internal string SerializationToString() { }

	[Address(RVA = "0x13EC790", Offset = "0x13EB990", Length = "0x24E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002468")]
	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x758270", Offset = "0x757470", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002465")]
	private static object StaticGetterAdapterFrame(StaticGetter<R> getter, object obj) { }

	[Address(RVA = "0x13EC9E0", Offset = "0x13EBBE0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002452")]
	public virtual string ToString() { }

}

