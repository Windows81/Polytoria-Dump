namespace System.ComponentModel;

[Token(Token = "0x200015E")]
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F7")]
	private readonly Type _type; //Field offset: 0x20

	[Token(Token = "0x17000191")]
	internal TypeDescriptionProvider Provider
	{
		[Address(RVA = "0x179C650", Offset = "0x179B850", Length = "0x81")]
		[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
		[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtendedTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
		[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
		[Token(Token = "0x6000875")]
		internal get { } //Length: 129
	}

	[Address(RVA = "0x2C33D0", Offset = "0x2C25D0", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000874")]
	internal DelegatingTypeDescriptionProvider(Type type) { }

	[Address(RVA = "0x179C650", Offset = "0x179B850", Length = "0x81")]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtendedTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
	[Token(Token = "0x6000875")]
	internal TypeDescriptionProvider get_Provider() { }

	[Address(RVA = "0x179C530", Offset = "0x179B730", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000876")]
	public virtual IDictionary GetCache(object instance) { }

	[Address(RVA = "0x179C570", Offset = "0x179B770", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000877")]
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x179C5B0", Offset = "0x179B7B0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000878")]
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x179C600", Offset = "0x179B800", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000879")]
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

