namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000004")]
public struct HierarchyFlattenedNodeChildren
{
	[Token(Token = "0x2000005")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000005")]
		private readonly HierarchyFlattenedNodeChildren m_Enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000006")]
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000007")]
		private readonly HierarchyNode m_Node; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000008")]
		private int m_CurrentIndex; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000009")]
		private int m_ChildrenIndex; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000A")]
		private int m_ChildrenCount; //Field offset: 0x30

		[IsReadOnly]
		[Token(Token = "0x17000001")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x19962A0", Offset = "0x19954A0", Length = "0x2E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000007")]
			 get { } //Length: 46
		}

		[Address(RVA = "0x1995BA0", Offset = "0x1994DA0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000006")]
		internal Enumerator(HierarchyFlattenedNodeChildren enumerable, HierarchyNode node) { }

		[Address(RVA = "0x19962A0", Offset = "0x19954A0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000007")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x19959A0", Offset = "0x1994BA0", Length = "0x166")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000002")]
	private readonly HierarchyNode m_Node; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000003")]
	private readonly int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000004")]
	private readonly int m_Count; //Field offset: 0x14

	[Address(RVA = "0x1996690", Offset = "0x1995890", Length = "0x253")]
	[CalledBy(Type = typeof(HierarchyFlattened), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyFlattenedNodeChildren))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000003")]
	internal HierarchyFlattenedNodeChildren(HierarchyFlattened hierarchyFlattened, in HierarchyNode node) { }

	[Address(RVA = "0x1996610", Offset = "0x1995810", Length = "0x78")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000004")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x19950B0", Offset = "0x19942B0", Length = "0x146")]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000005")]
	private void ThrowIfVersionChanged() { }

}

