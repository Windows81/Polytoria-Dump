namespace System.ComponentModel;

[Token(Token = "0x2000188")]
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
{
	[Token(Token = "0x2000189")]
	private class ReflectedTypeData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400063C")]
		private Type _type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400063D")]
		private AttributeCollection _attributes; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400063E")]
		private EventDescriptorCollection _events; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400063F")]
		private PropertyDescriptorCollection _properties; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000640")]
		private TypeConverter _converter; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000641")]
		private Object[] _editors; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000642")]
		private Type[] _editorTypes; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000643")]
		private int _editorCount; //Field offset: 0x48

		[Token(Token = "0x170001C7")]
		internal bool IsPopulated
		{
			[Address(RVA = "0x17A8F50", Offset = "0x17A8150", Length = "0x23")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000977")]
			internal get { } //Length: 35
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000976")]
		internal ReflectedTypeData(Type type) { }

		[Address(RVA = "0x17A8F50", Offset = "0x17A8150", Length = "0x23")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000977")]
		internal bool get_IsPopulated() { }

		[Address(RVA = "0x17A8230", Offset = "0x17A7430", Length = "0x556")]
		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = typeof(AttributeCollection))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(OrderedDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000978")]
		internal AttributeCollection GetAttributes() { }

		[Address(RVA = "0x17A8790", Offset = "0x17A7990", Length = "0x596")]
		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
		[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "get_IntrinsicTypeConverters", ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ReflectedTypeData), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000979")]
		internal TypeConverter GetConverter(object instance) { }

		[Address(RVA = "0x17A8D30", Offset = "0x17A7F30", Length = "0x19F")]
		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600097A")]
		private Type GetTypeFromName(string typeName) { }

		[Address(RVA = "0x17A8ED0", Offset = "0x17A80D0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600097B")]
		internal void Refresh() { }

	}

	[Token(Token = "0x4000631")]
	private static Type[] _typeConstructor; //Field offset: 0x0
	[Token(Token = "0x4000632")]
	private static Hashtable _intrinsicTypeConverters; //Field offset: 0x8
	[Token(Token = "0x4000633")]
	private static object _intrinsicReferenceKey; //Field offset: 0x10
	[Token(Token = "0x4000634")]
	private static object _intrinsicNullableKey; //Field offset: 0x18
	[Token(Token = "0x4000635")]
	private static object _dictionaryKey; //Field offset: 0x20
	[Token(Token = "0x4000636")]
	private static Hashtable _attributeCache; //Field offset: 0x28
	[Token(Token = "0x4000637")]
	private static readonly Guid _extenderProviderKey; //Field offset: 0x30
	[Token(Token = "0x4000638")]
	private static readonly Guid _extenderPropertiesKey; //Field offset: 0x40
	[Token(Token = "0x4000639")]
	private static readonly Guid _extenderProviderPropertiesKey; //Field offset: 0x50
	[Token(Token = "0x400063A")]
	private static readonly Type[] _skipInterfaceAttributeList; //Field offset: 0x60
	[Token(Token = "0x400063B")]
	private static object _internalSyncObject; //Field offset: 0x68
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000630")]
	private Hashtable _typeData; //Field offset: 0x20

	[Token(Token = "0x170001C6")]
	private static Hashtable IntrinsicTypeConverters
	{
		[Address(RVA = "0x17A7920", Offset = "0x17A6B20", Length = "0x90F")]
		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 26)]
		[Token(Token = "0x6000966")]
		private get { } //Length: 2319
	}

	[Address(RVA = "0x17A7520", Offset = "0x17A6720", Length = "0x3F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000975")]
	private static ReflectTypeDescriptionProvider() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000965")]
	internal ReflectTypeDescriptionProvider() { }

	[Address(RVA = "0x17A60E0", Offset = "0x17A52E0", Length = "0x10C")]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000967")]
	private static object CreateInstance(Type objectType, Type callingType) { }

	[Address(RVA = "0x17A7920", Offset = "0x17A6B20", Length = "0x90F")]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 26)]
	[Token(Token = "0x6000966")]
	private static Hashtable get_IntrinsicTypeConverters() { }

	[Address(RVA = "0x17A61F0", Offset = "0x17A53F0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000968")]
	internal AttributeCollection GetAttributes(Type type) { }

	[Address(RVA = "0x17A6220", Offset = "0x17A5420", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000969")]
	public virtual IDictionary GetCache(object instance) { }

	[Address(RVA = "0x17A6410", Offset = "0x17A5610", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600096A")]
	internal TypeConverter GetConverter(Type type, object instance) { }

	[Address(RVA = "0x17A6450", Offset = "0x17A5650", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600096B")]
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	[Address(RVA = "0x17A64A0", Offset = "0x17A56A0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600096C")]
	internal TypeConverter GetExtendedConverter(object instance) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600096D")]
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600096E")]
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x17A6500", Offset = "0x17A5700", Length = "0x29A")]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600096F")]
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000970")]
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	[Address(RVA = "0x17A67A0", Offset = "0x17A59A0", Length = "0x43")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000971")]
	internal bool IsPopulated(Type type) { }

	[Address(RVA = "0x17A67F0", Offset = "0x17A59F0", Length = "0x4B9")]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000972")]
	private static Attribute[] ReflectGetAttributes(Type type) { }

	[Address(RVA = "0x17A6CB0", Offset = "0x17A5EB0", Length = "0x88")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000973")]
	internal void Refresh(Type type) { }

	[Address(RVA = "0x17A6D40", Offset = "0x17A5F40", Length = "0x7DE")]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	[Token(Token = "0x6000974")]
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

}

