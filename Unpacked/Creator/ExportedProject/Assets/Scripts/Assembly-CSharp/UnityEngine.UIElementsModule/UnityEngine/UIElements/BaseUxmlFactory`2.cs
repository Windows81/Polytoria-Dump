namespace UnityEngine.UIElements;

[Obsolete("BaseUxmlFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E1")]
public abstract class BaseUxmlFactory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001016")]
	internal TTraits m_Traits; //Field offset: 0x0

	[Token(Token = "0x17000976")]
	public override string uxmlName
	{
		[Address(RVA = "0x9633F0", Offset = "0x9625F0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002429")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000977")]
	public override string uxmlNamespace
	{
		[Address(RVA = "0x963450", Offset = "0x962650", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600242A")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000978")]
	public override string uxmlQualifiedName
	{
		[Address(RVA = "0x9634D0", Offset = "0x9626D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600242B")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000979")]
	public override Type uxmlType
	{
		[Address(RVA = "0x963530", Offset = "0x962730", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x600242C")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x9633A0", Offset = "0x9625A0", Length = "0x44")]
	[CalledBy(Type = typeof(UxmlObjectFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002428")]
	protected BaseUxmlFactory`2() { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242D")]
	public override bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x9633F0", Offset = "0x9625F0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002429")]
	public override string get_uxmlName() { }

	[Address(RVA = "0x963450", Offset = "0x962650", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242A")]
	public override string get_uxmlNamespace() { }

	[Address(RVA = "0x9634D0", Offset = "0x9626D0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242B")]
	public override string get_uxmlQualifiedName() { }

	[Address(RVA = "0x963530", Offset = "0x962730", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x600242C")]
	public override Type get_uxmlType() { }

}

