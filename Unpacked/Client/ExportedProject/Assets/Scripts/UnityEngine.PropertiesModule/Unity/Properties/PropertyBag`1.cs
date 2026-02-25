namespace Unity.Properties;

[Token(Token = "0x2000041")]
public abstract class PropertyBag : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005F")]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000032")]
	protected override InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000101")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000031")]
	private override InstantiationKind Unity.Properties.IConstructor.InstantiationKind
	{
		[Address(RVA = "0xE89DB0", Offset = "0xE88FB0", Length = "0x14")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FD")]
		private get { } //Length: 20
	}

	[Address(RVA = "0x9DF410", Offset = "0x9DE610", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F6")]
	private static PropertyBag`1() { }

	[Address(RVA = "0xE8CB80", Offset = "0xE8BD80", Length = "0xE")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	protected PropertyBag`1() { }

	[Address(RVA = "0xE89A40", Offset = "0xE88C40", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800096A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F8")]
	public override void Accept(ITypeVisitor visitor) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	protected override InstantiationKind get_InstantiationKind() { }

	[Token(Token = "0x60000FF")]
	public abstract PropertyCollection<TContainer> GetProperties() { }

	[Token(Token = "0x6000100")]
	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	protected override TContainer Instantiate() { }

	[Address(RVA = "0xE89DB0", Offset = "0xE88FB0", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	private override InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	private override TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	[Address(RVA = "0xE8C870", Offset = "0xE8BA70", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F7")]
	private override void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	[Address(RVA = "0xE8AAC0", Offset = "0xE89CC0", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(PropertyBag), Member = "AcceptWithSpecializedVisitor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", typeof(IPropertyBagVisitor), "TContainer&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	private override void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, ref object container) { }

	[Address(RVA = "0xE89DD0", Offset = "0xE88FD0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	private override void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container) { }

	[Address(RVA = "0xE8A080", Offset = "0xE89280", Length = "0x52")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties() { }

	[Address(RVA = "0xE8A130", Offset = "0xE89330", Length = "0x52")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(ref TContainer container) { }

}

