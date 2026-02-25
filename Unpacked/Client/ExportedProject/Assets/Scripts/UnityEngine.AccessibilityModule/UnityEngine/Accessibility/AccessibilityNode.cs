namespace UnityEngine.Accessibility;

[Token(Token = "0x2000010")]
public class AccessibilityNode
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000011")]
	private class ObservableList
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000060")]
		private readonly List<T> m_Items; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000061")]
		private Action listChanged; //Field offset: 0x0

		[Token(Token = "0x14000003")]
		public event Action listChanged
		{
			[Address(RVA = "0xE5BCB0", Offset = "0xE5AEB0", Length = "0x9E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000080")]
			 add { } //Length: 158
			[Address(RVA = "0xE5BF20", Offset = "0xE5B120", Length = "0x9E")]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000081")]
			 remove { } //Length: 158
		}

		[Token(Token = "0x17000030")]
		public override int Count
		{
			[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
			[CallerCount(Count = 83)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600007D")]
			 get { } //Length: 26
		}

		[Token(Token = "0x17000031")]
		public override T Item
		{
			[Address(RVA = "0xE5BD80", Offset = "0xE5AF80", Length = "0x2A")]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600007E")]
			 get { } //Length: 42
		}

		[Address(RVA = "0xE5BCB0", Offset = "0xE5AEB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		public void add_listChanged(Action value) { }

		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007D")]
		public override int get_Count() { }

		[Address(RVA = "0xE5BD80", Offset = "0xE5AF80", Length = "0x2A")]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007E")]
		public override T get_Item(int index) { }

		[Address(RVA = "0xE5BBA0", Offset = "0xE5ADA0", Length = "0x65")]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007F")]
		public override IEnumerator<T> GetEnumerator() { }

		[Address(RVA = "0xE5BF20", Offset = "0xE5B120", Length = "0x9E")]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000081")]
		public void remove_listChanged(Action value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private int <id>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private Func<Rect> m_FrameGetter; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private Action<AccessibilityNode, Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	private Func<Boolean> selected; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000050")]
	private Action incremented; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000051")]
	private Action decremented; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000052")]
	private Func<Boolean> dismissed; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000053")]
	private string m_Label; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000054")]
	private string m_Value; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000055")]
	private string m_Hint; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000056")]
	private bool m_IsActive; //Field offset: 0x60
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000057")]
	private AccessibilityRole m_Role; //Field offset: 0x62
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000058")]
	private bool m_AllowsDirectInteraction; //Field offset: 0x64
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x4000059")]
	private AccessibilityState m_State; //Field offset: 0x66
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400005A")]
	private AccessibilityNode m_Parent; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400005B")]
	private ObservableList<AccessibilityNode> m_Children; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400005C")]
	private ObservableList<AccessibilityAction> m_Actions; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400005D")]
	private Rect m_Frame; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400005E")]
	private SystemLanguage m_Language; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400005F")]
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x98

	[Token(Token = "0x17000029")]
	public bool allowsDirectInteraction
	{
		[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002C")]
	internal IList<AccessibilityNode> childList
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700002D")]
	public Rect frame
	{
		[Address(RVA = "0x18FE110", Offset = "0x18FD310", Length = "0x191")]
		[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600006E")]
		 get { } //Length: 401
	}

	[Token(Token = "0x1700002E")]
	public Func<Rect> frameGetter
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000070")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000026")]
	public string hint
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000067")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000023")]
	public int id
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000064")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000027")]
	public bool isActive
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000068")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000024")]
	public string label
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002F")]
	internal SystemLanguage language
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000072")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700002B")]
	public AccessibilityNode parent
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000028")]
	public AccessibilityRole role
	{
		[Address(RVA = "0x18FE2B0", Offset = "0x18FD4B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002A")]
	public AccessibilityState state
	{
		[Address(RVA = "0x18FE2C0", Offset = "0x18FD4C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000025")]
	public string value
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000066")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x18FD380", Offset = "0x18FC580", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	private void ActionsChanged() { }

	[Address(RVA = "0x18FD520", Offset = "0x18FC720", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000071")]
	internal void CalculateFrame() { }

	[Address(RVA = "0x18FD630", Offset = "0x18FC830", Length = "0x22D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	private void ChildrenChanged() { }

	[Address(RVA = "0x18FD860", Offset = "0x18FCA60", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007C")]
	internal bool Dismissed() { }

	[Address(RVA = "0x18FD8A0", Offset = "0x18FCAA0", Length = "0x383")]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObservableList`1), Member = "remove_listChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ObservableList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000063")]
	internal void FreeNative(bool freeChildren) { }

	[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	public bool get_allowsDirectInteraction() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	internal IList<AccessibilityNode> get_childList() { }

	[Address(RVA = "0x18FE110", Offset = "0x18FD310", Length = "0x191")]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006E")]
	public Rect get_frame() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public Func<Rect> get_frameGetter() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000067")]
	public string get_hint() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000064")]
	public int get_id() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000068")]
	public bool get_isActive() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public string get_label() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	internal SystemLanguage get_language() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public AccessibilityNode get_parent() { }

	[Address(RVA = "0x18FE2B0", Offset = "0x18FD4B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000069")]
	public AccessibilityRole get_role() { }

	[Address(RVA = "0x18FE2C0", Offset = "0x18FD4C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006B")]
	public AccessibilityState get_state() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000066")]
	public string get_value() { }

	[Address(RVA = "0x18FDC30", Offset = "0x18FCE30", Length = "0x1CC")]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNodeData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000073")]
	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x12A6420", Offset = "0x12A5620", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	internal void InvokeDecremented() { }

	[Address(RVA = "0x18FDE00", Offset = "0x18FD000", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	internal void InvokeFocusChanged(bool isNodeFocused) { }

	[Address(RVA = "0x18FDE20", Offset = "0x18FD020", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	internal void InvokeIncremented() { }

	[Address(RVA = "0x18FDE40", Offset = "0x18FD040", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000079")]
	internal bool InvokeSelected() { }

	[Address(RVA = "0x18FDE80", Offset = "0x18FD080", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000076")]
	private bool IsInActiveHierarchy() { }

	[Address(RVA = "0x18FDEF0", Offset = "0x18FD0F0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000077")]
	internal void NotifyFocusChanged(bool isNodeFocused) { }

	[Address(RVA = "0x18FE010", Offset = "0x18FD210", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006F")]
	private void SetFrame(Rect frame) { }

}

