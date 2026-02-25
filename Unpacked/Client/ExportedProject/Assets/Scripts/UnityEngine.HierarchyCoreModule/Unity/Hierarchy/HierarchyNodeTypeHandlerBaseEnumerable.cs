namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x200000D")]
public struct HierarchyNodeTypeHandlerBaseEnumerable
{
	[Token(Token = "0x200000E")]
	internal struct Enumerator : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		private readonly IMemoryOwner<IntPtr> m_Handlers; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000020")]
		private readonly int m_Count; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000021")]
		private int m_Index; //Field offset: 0xC

		[Token(Token = "0x17000006")]
		public HierarchyNodeTypeHandlerBase Current
		{
			[Address(RVA = "0x19960E0", Offset = "0x19952E0", Length = "0x128")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000036")]
			 get { } //Length: 296
		}

		[Address(RVA = "0x1995C00", Offset = "0x1994E00", Length = "0x2DF")]
		[CalledBy(Type = typeof(HierarchyNodeTypeHandlerBaseEnumerable), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[CalledBy(Type = typeof(HierarchyViewModel), Member = "SearchBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000034")]
		internal Enumerator(Hierarchy hierarchy) { }

		[Address(RVA = "0x19958D0", Offset = "0x1994AD0", Length = "0xB4")]
		[CalledBy(Type = typeof(HierarchyViewModel), Member = "SearchBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000035")]
		public override void Dispose() { }

		[Address(RVA = "0x19960E0", Offset = "0x19952E0", Length = "0x128")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		public HierarchyNodeTypeHandlerBase get_Current() { }

		[Address(RVA = "0x1995B90", Offset = "0x1994D90", Length = "0xF")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000037")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	internal HierarchyNodeTypeHandlerBaseEnumerable(Hierarchy hierarchy) { }

	[Address(RVA = "0x1997730", Offset = "0x1996930", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000033")]
	public Enumerator GetEnumerator() { }

}

