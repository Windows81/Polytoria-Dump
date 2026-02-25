namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x2000150")]
public class AttributeCollection : ICollection, IEnumerable
{
	[Token(Token = "0x2000151")]
	private struct AttributeEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EC")]
		public Type type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005ED")]
		public int index; //Field offset: 0x8

	}

	[Token(Token = "0x40005E6")]
	public static readonly AttributeCollection Empty; //Field offset: 0x0
	[Token(Token = "0x40005E7")]
	private static Hashtable s_defaultAttributes; //Field offset: 0x8
	[Token(Token = "0x40005E9")]
	private static readonly object s_internalSyncObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E8")]
	private readonly Attribute[] _attributes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005EA")]
	private AttributeEntry[] _foundAttributeTypes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005EB")]
	private int _index; //Field offset: 0x20

	[Token(Token = "0x17000184")]
	protected override Attribute[] Attributes
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000185")]
	public int Count
	{
		[Address(RVA = "0x177B1D0", Offset = "0x177A3D0", Length = "0x29")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082B")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000186")]
	public override Attribute Item
	{
		[Address(RVA = "0x177B490", Offset = "0x177A690", Length = "0x556")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x600082C")]
		 get { } //Length: 1366
	}

	[Token(Token = "0x17000188")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x177B1D0", Offset = "0x177A3D0", Length = "0x29")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000830")]
		private get { } //Length: 41
	}

	[Token(Token = "0x17000187")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082F")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x177B200", Offset = "0x177A400", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000833")]
	private static AttributeCollection() { }

	[Address(RVA = "0x177B390", Offset = "0x177A590", Length = "0xFC")]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "CreateAttributeCollection", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000829")]
	public AttributeCollection(Attribute[] attributes) { }

	[Address(RVA = "0x177AC00", Offset = "0x1779E00", Length = "0x89")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000832")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082A")]
	protected override Attribute[] get_Attributes() { }

	[Address(RVA = "0x177B1D0", Offset = "0x177A3D0", Length = "0x29")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082B")]
	public int get_Count() { }

	[Address(RVA = "0x177B490", Offset = "0x177A690", Length = "0x556")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600082C")]
	public override Attribute get_Item(Type attributeType) { }

	[Address(RVA = "0x177AC90", Offset = "0x1779E90", Length = "0x507")]
	[CalledBy(Type = typeof(AttributeCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600082D")]
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	[Address(RVA = "0x177B1A0", Offset = "0x177A3A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082E")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x177B1D0", Offset = "0x177A3D0", Length = "0x29")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000830")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082F")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x177B1A0", Offset = "0x177A3A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000831")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

