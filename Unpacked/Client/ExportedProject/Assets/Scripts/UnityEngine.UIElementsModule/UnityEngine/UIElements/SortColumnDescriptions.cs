namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000121")]
[UxmlObject]
public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
{
	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000123")]
	public class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescriptions>
	{

		[Address(RVA = "0x1C2C710", Offset = "0x1C2B910", Length = "0x39")]
		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600091D")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000122")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x849EA0", Offset = "0x8490A0", Length = "0x22")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600091C")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000124")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B1")]
		private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions; //Field offset: 0x0

		[Address(RVA = "0x84C200", Offset = "0x84B400", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091F")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x84AC20", Offset = "0x849E20", Length = "0x1A0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091E")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005AF")]
	private readonly IList<SortColumnDescription> m_Descriptions; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B0")]
	private Action changed; //Field offset: 0x18

	[Token(Token = "0x14000023")]
	internal event Action changed
	{
		[Address(RVA = "0x1C29180", Offset = "0x1C28380", Length = "0x9E")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600090E")]
		internal add { } //Length: 158
		[Address(RVA = "0x1C292C0", Offset = "0x1C284C0", Length = "0x9E")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600090F")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x17000186")]
	public override int Count
	{
		[Address(RVA = "0x1C29220", Offset = "0x1C28420", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000918")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000187")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x1C29270", Offset = "0x1C28470", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000919")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x1C29100", Offset = "0x1C28300", Length = "0x77")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600091B")]
	public SortColumnDescriptions() { }

	[Address(RVA = "0x1C288F0", Offset = "0x1C27AF0", Length = "0x62")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortColumnDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000912")]
	public override void Add(SortColumnDescription item) { }

	[Address(RVA = "0x1C29180", Offset = "0x1C28380", Length = "0x9E")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600090E")]
	internal void add_changed(Action value) { }

	[Address(RVA = "0x1C28960", Offset = "0x1C27B60", Length = "0x189")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000913")]
	public override void Clear() { }

	[Address(RVA = "0x1C28AF0", Offset = "0x1C27CF0", Length = "0x58")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000914")]
	public override bool Contains(SortColumnDescription item) { }

	[Address(RVA = "0x1C28B50", Offset = "0x1C27D50", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000915")]
	public override void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	[Address(RVA = "0x1C29220", Offset = "0x1C28420", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000918")]
	public override int get_Count() { }

	[Address(RVA = "0x1C29270", Offset = "0x1C28470", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000919")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x1C28C20", Offset = "0x1C27E20", Length = "0x46")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000910")]
	public override IEnumerator<SortColumnDescription> GetEnumerator() { }

	[Address(RVA = "0x1C28C70", Offset = "0x1C27E70", Length = "0x2B0")]
	[CalledBy(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600091A")]
	public void Insert(int index, SortColumnDescription desc) { }

	[Address(RVA = "0x1818FE0", Offset = "0x18181E0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000917")]
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	[Address(RVA = "0x1C28F30", Offset = "0x1C28130", Length = "0x1CE")]
	[CalledBy(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000916")]
	public override bool Remove(SortColumnDescription desc) { }

	[Address(RVA = "0x1C292C0", Offset = "0x1C284C0", Length = "0x9E")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600090F")]
	internal void remove_changed(Action value) { }

	[Address(RVA = "0x1C28C20", Offset = "0x1C27E20", Length = "0x46")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000911")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

