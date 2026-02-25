namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x2000012")]
public struct HierarchyViewNodesEnumerable
{
	[Token(Token = "0x2000014")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000029")]
		private readonly Predicate m_Predicate; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002A")]
		private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002B")]
		private readonly HierarchyFlattenedNode* m_NodesPtr; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400002C")]
		private readonly int m_NodesCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400002D")]
		private readonly int m_Version; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002E")]
		private int m_Index; //Field offset: 0x28

		[IsReadOnly]
		[Token(Token = "0x17000007")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x19962D0", Offset = "0x19954D0", Length = "0x22")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			[Token(Token = "0x6000048")]
			 get { } //Length: 34
		}

		[Address(RVA = "0x1995EE0", Offset = "0x19950E0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000047")]
		internal Enumerator(HierarchyViewNodesEnumerable enumerable) { }

		[Address(RVA = "0x19962D0", Offset = "0x19954D0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Token(Token = "0x6000048")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x1995B30", Offset = "0x1994D30", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000049")]
		public bool MoveNext() { }

		[Address(RVA = "0x1994E00", Offset = "0x1994000", Length = "0x1A8")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600004A")]
		private void ThrowIfVersionChanged() { }

	}

	[Token(Token = "0x2000013")]
	public sealed class Predicate : MulticastDelegate
	{

		[Address(RVA = "0x199C8E0", Offset = "0x199BAE0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000045")]
		public Predicate(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000046")]
		public override bool Invoke(in HierarchyNode node, HierarchyNodeFlags flags) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000025")]
	private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000026")]
	private readonly Predicate m_Predicate; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10

	[Address(RVA = "0x199B3E0", Offset = "0x199A5E0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000043")]
	internal HierarchyViewNodesEnumerable(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate) { }

	[Address(RVA = "0x199B330", Offset = "0x199A530", Length = "0xAB")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000044")]
	public Enumerator GetEnumerator() { }

}

