namespace Battlehub.UIControls;

[RequireComponent(typeof(Toggle))]
[Token(Token = "0x2000034")]
public class TreeViewExpander : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <CoUpdateState>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000C2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C3")]
		public TreeViewExpander <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000066")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60001D0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000067")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60001D2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CD")]
		public <CoUpdateState>d__11(int <>1__state) { }

		[Address(RVA = "0x5D7C20", Offset = "0x5D6E20", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TreeViewExpander), Member = "DoUpdateState", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001CF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5D7CC0", Offset = "0x5D6EC0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60001D1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CE")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BD")]
	public Graphic OffGraphic; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000BE")]
	private Toggle m_toggle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000BF")]
	private bool m_canExpand; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40000C0")]
	private bool m_started; //Field offset: 0x31

	[Token(Token = "0x17000064")]
	public bool CanExpand
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 5
		[Address(RVA = "0x5D34F0", Offset = "0x5D26F0", Length = "0xA")]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "AwakeOverride", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
		[Token(Token = "0x60001C1")]
		 set { } //Length: 10
	}

	[Token(Token = "0x17000065")]
	public bool IsOn
	{
		[Address(RVA = "0x5D34D0", Offset = "0x5D26D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001C2")]
		 get { } //Length: 30
		[Address(RVA = "0x5D3500", Offset = "0x5D2700", Length = "0x1E")]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001C3")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CC")]
	public TreeViewExpander() { }

	[Address(RVA = "0x5D2FF0", Offset = "0x5D21F0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001C7")]
	private void Awake() { }

	[Address(RVA = "0x5D3120", Offset = "0x5D2320", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CoUpdateState>d__11))]
	[Token(Token = "0x60001C5")]
	private IEnumerator CoUpdateState() { }

	[Address(RVA = "0x5D3190", Offset = "0x5D2390", Length = "0x130")]
	[CalledBy(Type = typeof(<CoUpdateState>d__11), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C6")]
	private void DoUpdateState() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C0")]
	public bool get_CanExpand() { }

	[Address(RVA = "0x5D34D0", Offset = "0x5D26D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C2")]
	public bool get_IsOn() { }

	[Address(RVA = "0x5D32D0", Offset = "0x5D24D0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001CA")]
	private void OnDestroy() { }

	[Address(RVA = "0x5D33B0", Offset = "0x5D25B0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
	[Token(Token = "0x60001C9")]
	private void OnEnable() { }

	[Address(RVA = "0x5D3420", Offset = "0x5D2620", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
	[Token(Token = "0x60001CB")]
	private void OnValueChanged(bool value) { }

	[Address(RVA = "0x5D34F0", Offset = "0x5D26F0", Length = "0xA")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "AwakeOverride", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TreeViewExpander), Member = "UpdateState", ReturnType = typeof(void))]
	[Token(Token = "0x60001C1")]
	public void set_CanExpand(bool value) { }

	[Address(RVA = "0x5D3500", Offset = "0x5D2700", Length = "0x1E")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C3")]
	public void set_IsOn(bool value) { }

	[Address(RVA = "0x5D3430", Offset = "0x5D2630", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C8")]
	private void Start() { }

	[Address(RVA = "0x5D3440", Offset = "0x5D2640", Length = "0x84")]
	[CalledBy(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewExpander), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewExpander), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewExpander), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewItem), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewItem), Member = "AwakeOverride", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewItem), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TreeViewExpander), Member = "DoUpdateState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001C4")]
	private void UpdateState() { }

}

