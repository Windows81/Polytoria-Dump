namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000006")]
public struct HierarchyNodeChildren
{
	[Token(Token = "0x2000007")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000F")]
		private readonly HierarchyNodeChildren m_Enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000010")]
		private int m_Index; //Field offset: 0x18

		[IsReadOnly]
		[Token(Token = "0x17000002")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x1994FB0", Offset = "0x19941B0", Length = "0xF6")]
			[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(HierarchyNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsDeduplicatedMethods(Count = 2)]
			[Token(Token = "0x600000D")]
			 get { } //Length: 246
		}

		[Address(RVA = "0x1995FE0", Offset = "0x19951E0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600000C")]
		internal Enumerator(in HierarchyNodeChildren enumerable) { }

		[Address(RVA = "0x1994FB0", Offset = "0x19941B0", Length = "0xF6")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600000D")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x1995990", Offset = "0x1994B90", Length = "0xF")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000E")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000B")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000C")]
	private readonly HierarchyNode* m_Ptr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	private readonly int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400000E")]
	private readonly int m_Count; //Field offset: 0x14

	[Address(RVA = "0x19975B0", Offset = "0x19967B0", Length = "0x175")]
	[CalledBy(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000009")]
	internal HierarchyNodeChildren(Hierarchy hierarchy, IntPtr nodeChildrenPtr) { }

	[Address(RVA = "0x1997570", Offset = "0x1996770", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600000A")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x1995280", Offset = "0x1994480", Length = "0x306")]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600000B")]
	private void ThrowIfVersionChanged() { }

}

