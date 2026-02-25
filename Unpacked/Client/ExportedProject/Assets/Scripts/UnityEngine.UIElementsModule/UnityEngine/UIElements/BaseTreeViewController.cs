namespace UnityEngine.UIElements;

[Token(Token = "0x2000054")]
public abstract class BaseTreeViewController : CollectionViewController
{
	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <GetAllItemIds>d__23 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000195")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000196")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000197")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000198")]
		private IEnumerable<Int32> rootIds; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000199")]
		public IEnumerable<Int32> <>3__rootIds; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400019A")]
		public BaseTreeViewController <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400019B")]
		private Enumerator <>s__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400019C")]
		private HierarchyFlattenedNode <flattenedNode>5__2; //Field offset: 0x58
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x400019D")]
		private HierarchyNode <node>5__3; //Field offset: 0x74
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400019E")]
		private IEnumerator<Int32> <>s__4; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400019F")]
		private int <id>5__5; //Field offset: 0x88
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40001A0")]
		private HierarchyNode <parentNode>5__6; //Field offset: 0x8C
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40001A1")]
		private HierarchyFlattenedNodeChildren <flattenedNodeChildren>5__7; //Field offset: 0x98
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40001A2")]
		private Enumerator <>s__8; //Field offset: 0xB0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x40001A3")]
		private HierarchyNode <node>5__9; //Field offset: 0xE8

		[Token(Token = "0x1700005A")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002D2")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700005B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002D4")]
			private get { } //Length: 33
		}

		[Address(RVA = "0x158E220", Offset = "0x158D420", Length = "0x436")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		public <GetAllItemIds>d__23(int <>1__state) { }

		[Address(RVA = "0x1ACD260", Offset = "0x1ACC460", Length = "0x56")]
		[CalledBy(Type = typeof(<GetAllItemIds>d__23), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60002D1")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1ACC980", Offset = "0x1ACBB80", Length = "0x781")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(<GetAllItemIds>d__23), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyFlattenedNodeChildren))]
		[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AB78B0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002D0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1ACD110", Offset = "0x1ACC310", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D5")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D2")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x1ACD110", Offset = "0x1ACC310", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1ACD1C0", Offset = "0x1ACC3C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60002D3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1ACD200", Offset = "0x1ACC400", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.UIElements.BackgroundRepeat+PropertyBag+YProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AB78C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60002CF")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private sealed class <GetChildrenIds>d__25 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001A5")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A6")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001A7")]
		private int id; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A8")]
		public int <>3__id; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A9")]
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001AA")]
		private HierarchyNode <nodeById>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001AB")]
		private HierarchyNodeChildren <nodes>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001AC")]
		private Enumerator <>s__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001AD")]
		private HierarchyNode <node>5__4; //Field offset: 0x70

		[Token(Token = "0x1700005C")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002DA")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700005D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002DC")]
			private get { } //Length: 33
		}

		[Address(RVA = "0x158E220", Offset = "0x158D420", Length = "0x436")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D7")]
		public <GetChildrenIds>d__25(int <>1__state) { }

		[Address(RVA = "0x1ACD520", Offset = "0x1ACC720", Length = "0x191")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
		[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002D9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1ACD6C0", Offset = "0x1ACC8C0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DD")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DA")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x1ACD6C0", Offset = "0x1ACC8C0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DE")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1ACD770", Offset = "0x1ACC970", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60002DB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <GetChildrenIdsByIndex>d__41 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001AE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001AF")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B0")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001B1")]
		private int index; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B2")]
		public int <>3__index; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B3")]
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001B4")]
		private HierarchyNodeChildren <nodes>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001B5")]
		private Enumerator <>s__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001B6")]
		private HierarchyNode <node>5__3; //Field offset: 0x68

		[Token(Token = "0x1700005E")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002E2")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700005F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60002E4")]
			private get { } //Length: 33
		}

		[Address(RVA = "0x158E220", Offset = "0x158D420", Length = "0x436")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DF")]
		public <GetChildrenIdsByIndex>d__41(int <>1__state) { }

		[Address(RVA = "0x1ACD2C0", Offset = "0x1ACC4C0", Length = "0x16E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002E1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1ACD430", Offset = "0x1ACC630", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E5")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E2")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x1ACD430", Offset = "0x1ACC630", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1ACD4E0", Offset = "0x1ACC6E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60002E3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E0")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000194")]
	private static readonly ProfilerMarker K_ExpandItemByIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400018D")]
	 Hierarchy m_Hierarchy; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400018E")]
	 HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400018F")]
	 HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000190")]
	 Dictionary<Int32, HierarchyNode> m_IdToNodeDictionary; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000191")]
	private IHierarchyProperty<Int32> m_TreeViewDataProperty; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000192")]
	private bool m_HierarchyHasPendingChanged; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000193")]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x60

	[Token(Token = "0x14000009")]
	internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
	{
		[Address(RVA = "0x1AC3DB0", Offset = "0x1AC2FB0", Length = "0xAC")]
		[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000299")]
		internal add { } //Length: 172
		[Address(RVA = "0x1AC3EE0", Offset = "0x1AC30E0", Length = "0xAC")]
		[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600029A")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x17000057")]
	protected BaseTreeView baseTreeView
	{
		[Address(RVA = "0x1AC3E60", Offset = "0x1AC3060", Length = "0x72")]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000298")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000058")]
	 Hierarchy hierarchy
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600029D")]
		 get { } //Length: 95
		[Address(RVA = "0x1AC3F90", Offset = "0x1AC3190", Length = "0x160")]
		[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600029E")]
		 set { } //Length: 352
	}

	[Token(Token = "0x17000059")]
	public virtual IList itemsSource
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A0")]
		 get { } //Length: 5
		[Address(RVA = "0x1AC4100", Offset = "0x1AC3300", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60002A1")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x1AC3B40", Offset = "0x1AC2D40", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerCategory), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerCategory)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002CD")]
	private static BaseTreeViewController() { }

	[Address(RVA = "0x1AC3BC0", Offset = "0x1AC2DC0", Length = "0x1E2")]
	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600029B")]
	protected BaseTreeViewController() { }

	[Address(RVA = "0x1AC3DB0", Offset = "0x1AC2FB0", Length = "0xAC")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000299")]
	internal void add_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B6")]
	public override bool CanChangeExpandedState(int id) { }

	[Address(RVA = "0x1ABFF60", Offset = "0x1ABF160", Length = "0x44")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C7")]
	internal void ClearIdToNodeDictionary() { }

	[Address(RVA = "0x1AC03D0", Offset = "0x1ABF5D0", Length = "0xD6")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002BC")]
	public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true) { }

	[Address(RVA = "0x1ABFFB0", Offset = "0x1ABF1B0", Length = "0xC9")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002BB")]
	public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true) { }

	[Address(RVA = "0x1AC0080", Offset = "0x1ABF280", Length = "0x34C")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002BE")]
	private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh) { }

	[Address(RVA = "0x1AC04B0", Offset = "0x1ABF6B0", Length = "0x7B")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "<SetRootItems>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "<SetRootItems>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = typeof(HierarchyNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002C5")]
	internal HierarchyNode CreateNode(in HierarchyNode parent) { }

	[Address(RVA = "0x1AC0530", Offset = "0x1ABF730", Length = "0xC8")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600029F")]
	internal void DisposeHierarchy() { }

	[Address(RVA = "0x1AC0600", Offset = "0x1ABF800", Length = "0x51")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002B0")]
	public bool Exists(int id) { }

	[Address(RVA = "0x1AC0BF0", Offset = "0x1ABFDF0", Length = "0xD6")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002BA")]
	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true) { }

	[Address(RVA = "0x1AC0660", Offset = "0x1ABF860", Length = "0x1AE")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B9")]
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true) { }

	[Address(RVA = "0x1AC0810", Offset = "0x1ABFA10", Length = "0x3D5")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002BD")]
	private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh) { }

	[Address(RVA = "0x1AC0CD0", Offset = "0x1ABFED0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600029C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1AC3E60", Offset = "0x1AC3060", Length = "0x72")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000298")]
	protected BaseTreeView get_baseTreeView() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600029D")]
	 Hierarchy get_hierarchy() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A0")]
	public virtual IList get_itemsSource() { }

	[Address(RVA = "0x1AC0D30", Offset = "0x1ABFF30", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<GetAllItemIds>d__23))]
	[Token(Token = "0x60002A2")]
	public override IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	[Address(RVA = "0x1AC0DC0", Offset = "0x1ABFFC0", Length = "0x24A")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B3")]
	public int GetChildIndexForId(int id) { }

	[Address(RVA = "0x1AC1090", Offset = "0x1AC0290", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<GetChildrenIds>d__25))]
	[Token(Token = "0x60002A4")]
	public override IEnumerable<Int32> GetChildrenIds(int id) { }

	[Address(RVA = "0x1AC1010", Offset = "0x1AC0210", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<GetChildrenIdsByIndex>d__41))]
	[Token(Token = "0x60002B2")]
	public IEnumerable<Int32> GetChildrenIdsByIndex(int index) { }

	[Address(RVA = "0x1AC1110", Offset = "0x1AC0310", Length = "0x3EF")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(HierarchyViewNodesEnumerable), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "EnumerateNodesWithAllFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNodeFlags)}, ReturnType = typeof(HierarchyViewNodesEnumerable))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void GetExpandedItemIds(List<Int32> list) { }

	[Address(RVA = "0x1AC1500", Offset = "0x1AC0700", Length = "0x98")]
	[CalledBy(Type = typeof(<GetChildrenIds>d__25), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CB")]
	internal HierarchyNode GetHierarchyNodeById(int id) { }

	[Address(RVA = "0x1AC15A0", Offset = "0x1AC07A0", Length = "0x3D")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CC")]
	internal HierarchyNode GetHierarchyNodeByIndex(int index) { }

	[Address(RVA = "0x1AC15E0", Offset = "0x1AC07E0", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002AE")]
	public virtual int GetIdForIndex(int index) { }

	[Address(RVA = "0x1AC17B0", Offset = "0x1AC09B0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "CombinedComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002B4")]
	public int GetIndentationDepth(int id) { }

	[Address(RVA = "0x1AC16F0", Offset = "0x1AC08F0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002B5")]
	public int GetIndentationDepthByIndex(int index) { }

	[Address(RVA = "0x1AC1860", Offset = "0x1AC0A60", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002AD")]
	public virtual int GetIndexForId(int id) { }

	[Address(RVA = "0x1AC1920", Offset = "0x1AC0B20", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A3")]
	public override int GetParentId(int id) { }

	[Address(RVA = "0x1AC1B30", Offset = "0x1AC0D30", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002AF")]
	public override bool HasChildren(int id) { }

	[Address(RVA = "0x1AC1AD0", Offset = "0x1AC0CD0", Length = "0x52")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B1")]
	public bool HasChildrenByIndex(int index) { }

	[Address(RVA = "0x1AC1BE0", Offset = "0x1AC0DE0", Length = "0x24E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ReusableTreeViewItem), Member = "UpdateIndentLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002A7")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x1AC1E30", Offset = "0x1AC1030", Length = "0x246")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A8")]
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x1AC2080", Offset = "0x1AC1280", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableTreeViewItem)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A6")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x1AC2130", Offset = "0x1AC1330", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C3")]
	private bool IsChildOf(int childId, int id) { }

	[Address(RVA = "0x1AC23F0", Offset = "0x1AC15F0", Length = "0xFE")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B7")]
	public bool IsExpanded(int id) { }

	[Address(RVA = "0x1AC22B0", Offset = "0x1AC14B0", Length = "0x135")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B8")]
	public bool IsExpandedByIndex(int index) { }

	[Address(RVA = "0x1AC24F0", Offset = "0x1AC16F0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C2")]
	private bool IsIndexValid(int index) { }

	[Address(RVA = "0x1AC2520", Offset = "0x1AC1720", Length = "0x50")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C0")]
	internal bool IsViewDataKeyEnabled() { }

	[Address(RVA = "0x1AC2580", Offset = "0x1AC1780", Length = "0x2EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A5")]
	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	[Address(RVA = "0x1AC2870", Offset = "0x1AC1A70", Length = "0x712")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002AA")]
	private void OnItemPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1AC2F90", Offset = "0x1AC2190", Length = "0x25A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002AC")]
	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x1AC31F0", Offset = "0x1AC23F0", Length = "0x209")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002C9")]
	internal void OnViewDataReadyUpdateNodes() { }

	[Address(RVA = "0x1AC3400", Offset = "0x1AC2600", Length = "0x1D9")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002A9")]
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	[Address(RVA = "0x1AC35E0", Offset = "0x1AC27E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Token(Token = "0x60002C1")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x1AC35F0", Offset = "0x1AC27F0", Length = "0xA9")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002AB")]
	private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren) { }

	[Address(RVA = "0x1AC36A0", Offset = "0x1AC28A0", Length = "0x19")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C4")]
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	[Address(RVA = "0x1AC3EE0", Offset = "0x1AC30E0", Length = "0xAC")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600029A")]
	internal void remove_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[Address(RVA = "0x1AC3F90", Offset = "0x1AC3190", Length = "0x160")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029E")]
	 void set_hierarchy(Hierarchy value) { }

	[Address(RVA = "0x1AC4100", Offset = "0x1AC3300", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60002A1")]
	public virtual void set_itemsSource(IList value) { }

	[Address(RVA = "0x1AC36C0", Offset = "0x1AC28C0", Length = "0x84")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "PreRefresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = "PreRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CA")]
	internal void UpdateHierarchy() { }

	[Address(RVA = "0x1AC3750", Offset = "0x1AC2950", Length = "0x13A")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "<SetRootItems>b__7_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "<SetRootItems>b__6_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, Unity.Hierarchy.HierarchyNode>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C6")]
	internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true) { }

	[Address(RVA = "0x1AC3890", Offset = "0x1AC2A90", Length = "0x2A3")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "SortChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "GetChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode[]))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "SetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002C8")]
	internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex) { }

}

