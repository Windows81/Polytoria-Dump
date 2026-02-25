namespace Unity.Properties;

[Token(Token = "0x2000057")]
public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor
{
	[IsReadOnly]
	[Token(Token = "0x2000058")]
	private struct PropertyScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007E")]
		private readonly PathVisitor m_Visitor; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007F")]
		private readonly IProperty m_Property; //Field offset: 0x8

		[Address(RVA = "0x1A13310", Offset = "0x1A12510", Length = "0x61")]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000149")]
		public PropertyScope(PathVisitor visitor, IProperty property) { }

		[Address(RVA = "0x1A132E0", Offset = "0x1A124E0", Length = "0x2F")]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600014A")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000079")]
	private int m_PathIndex; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007A")]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400007B")]
	private IProperty <Property>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400007C")]
	private bool <ReadonlyVisit>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400007D")]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0xB4

	[Token(Token = "0x1700003B")]
	public PropertyPath Path
	{
		[Address(RVA = "0x19F63A0", Offset = "0x19F55A0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600013C")]
		 get { } //Length: 84
		[Address(RVA = "0x19F6400", Offset = "0x19F5600", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x600013D")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700003C")]
	private IProperty Property
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600013F")]
		private get { } //Length: 8
		[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000140")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700003D")]
	public bool ReadonlyVisit
	{
		[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000141")]
		 get { } //Length: 8
		[Address(RVA = "0x530330", Offset = "0x52F530", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000142")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700003E")]
	public VisitReturnCode ReturnCode
	{
		[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000143")]
		 get { } //Length: 7
		[Address(RVA = "0x184DF10", Offset = "0x184D110", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000144")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000148")]
	protected PathVisitor() { }

	[Address(RVA = "0x19F63A0", Offset = "0x19F55A0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600013C")]
	public PropertyPath get_Path() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600013F")]
	private IProperty get_Property() { }

	[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000141")]
	public bool get_ReadonlyVisit() { }

	[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	public VisitReturnCode get_ReturnCode() { }

	[Address(RVA = "0x19F6340", Offset = "0x19F5540", Length = "0x5F")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater+UIPathVisitor", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SetValueVisitor`1", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetValueVisitor`1", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600013E")]
	public override void Reset() { }

	[Address(RVA = "0x19F6400", Offset = "0x19F5600", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x600013D")]
	public void set_Path(PropertyPath value) { }

	[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000140")]
	private void set_Property(IProperty value) { }

	[Address(RVA = "0x530330", Offset = "0x52F530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000142")]
	public void set_ReadonlyVisit(bool value) { }

	[Address(RVA = "0x184DF10", Offset = "0x184D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000144")]
	protected void set_ReturnCode(VisitReturnCode value) { }

	[Address(RVA = "0x71D6C0", Offset = "0x71C8C0", Length = "0xA52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(AttributesScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C3C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Key", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000145")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x71EBA0", Offset = "0x71DDA0", Length = "0x255")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180028180")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyBag), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023C20")]
	[Calls(Type = typeof(PropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathVisitor), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyContainer), Member = "Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Int32Enum&), typeof(VisitParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000146")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000147")]
	protected override void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

}

